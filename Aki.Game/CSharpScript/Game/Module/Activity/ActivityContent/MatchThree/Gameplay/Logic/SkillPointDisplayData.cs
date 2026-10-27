using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064FD RID: 25853
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct SkillPointDisplayData
	{
		// Token: 0x06040E76 RID: 265846 RVA: 0x00FBAE49 File Offset: 0x00FB9049
		public SkillPointDisplayData(int energyNode, string icon, bool charged, bool released)
		{
			this.EnergyNode = energyNode;
			this.Icon = icon;
			this.Charged = charged;
			this.Released = released;
		}

		// Token: 0x04021D3F RID: 138559
		public readonly int EnergyNode;

		// Token: 0x04021D40 RID: 138560
		public readonly string Icon;

		// Token: 0x04021D41 RID: 138561
		public readonly bool Charged;

		// Token: 0x04021D42 RID: 138562
		public readonly bool Released;
	}
}
