using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200476F RID: 18287
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyDetailBookBigItemData
	{
		// Token: 0x17005C4A RID: 23626
		// (get) Token: 0x0602DE9C RID: 188060 RVA: 0x00CDA028 File Offset: 0x00CD8228
		// (set) Token: 0x0602DE9D RID: 188061 RVA: 0x00CDA030 File Offset: 0x00CD8230
		public int TargetLevel { get; set; }

		// Token: 0x17005C4B RID: 23627
		// (get) Token: 0x0602DE9E RID: 188062 RVA: 0x00CDA039 File Offset: 0x00CD8239
		// (set) Token: 0x0602DE9F RID: 188063 RVA: 0x00CDA041 File Offset: 0x00CD8241
		public EKurotatoEnemyDetailBookTabAllOrWave TabAllOrWave { get; set; }

		// Token: 0x0602DEA0 RID: 188064 RVA: 0x00CDA04A File Offset: 0x00CD824A
		public List<KurotatoEnemyData> GetMonsterGridItemDataList()
		{
			return this.MonsterGridItemDataList;
		}

		// Token: 0x0401883C RID: 100412
		protected readonly Dictionary<int, int> WaveMonsterIdToNum = new Dictionary<int, int>();

		// Token: 0x0401883D RID: 100413
		protected readonly List<KurotatoEnemyData> MonsterGridItemDataList = new List<KurotatoEnemyData>();

		// Token: 0x0401883E RID: 100414
		[Nullable(2)]
		public KurotatoEnemyData CurSelectedGridItemData;
	}
}
