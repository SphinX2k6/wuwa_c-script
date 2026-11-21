using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x0200613C RID: 24892
	[NullableContext(2)]
	[Nullable(0)]
	internal class PinballBattleWorldEntityModel
	{
		// Token: 0x0401F700 RID: 128768
		public int Uid;

		// Token: 0x0401F701 RID: 128769
		public int CombatId;

		// Token: 0x0401F702 RID: 128770
		public int PropertyId;

		// Token: 0x0401F703 RID: 128771
		public string AssetPath;

		// Token: 0x0401F704 RID: 128772
		public int? SplineId;

		// Token: 0x0401F705 RID: 128773
		public Dictionary<int, int> BuffIdLayers;

		// Token: 0x0401F706 RID: 128774
		public Dictionary<int, int> AttributeMap;
	}
}
