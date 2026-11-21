using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x0200547B RID: 21627
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct SkillPointDisplayData
	{
		// Token: 0x06035B3A RID: 219962 RVA: 0x00F01E79 File Offset: 0x00F00079
		public SkillPointDisplayData(int energyNode, string icon, bool charged, bool released)
		{
			this.EnergyNode = energyNode;
			this.Icon = icon;
			this.Charged = charged;
			this.Released = released;
		}

		// Token: 0x0401C670 RID: 116336
		public readonly int EnergyNode;

		// Token: 0x0401C671 RID: 116337
		public readonly string Icon;

		// Token: 0x0401C672 RID: 116338
		public readonly bool Charged;

		// Token: 0x0401C673 RID: 116339
		public readonly bool Released;
	}
}
