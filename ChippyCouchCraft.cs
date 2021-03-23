using Terraria.ModLoader;

namespace ChippyCouchCraft
{
	public class ChippyCouchCraft : Mod
	{
		public static ChippyCouchCraft Instance;

		public ChippyCouchCraft()
		{
			Instance = this;
		}

		public override void Load()
		{
			if(Instance == null || Instance != this)
			{
				Instance = this;
			}
		}
	}
}