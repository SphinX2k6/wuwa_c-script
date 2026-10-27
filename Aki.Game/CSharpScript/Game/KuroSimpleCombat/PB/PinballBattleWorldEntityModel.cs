using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FBB RID: 28603
	[NullableContext(2)]
	[Nullable(0)]
	internal class PinballBattleWorldEntityModel
	{
		// Token: 0x0402444B RID: 148555
		public int Uid;

		// Token: 0x0402444C RID: 148556
		public int CombatId;

		// Token: 0x0402444D RID: 148557
		public int PropertyId;

		// Token: 0x0402444E RID: 148558
		public string AssetPath;

		// Token: 0x0402444F RID: 148559
		public int? SplineId;

		// Token: 0x04024450 RID: 148560
		public Dictionary<int, int> BuffIdLayers;

		// Token: 0x04024451 RID: 148561
		public Dictionary<int, int> AttributeMap;
	}
}
