using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02005798 RID: 22424
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyDetailBookBigItemData
	{
		// Token: 0x17008882 RID: 34946
		// (get) Token: 0x06038F8C RID: 233356 RVA: 0x00D8B2AC File Offset: 0x00D894AC
		// (set) Token: 0x06038F8D RID: 233357 RVA: 0x00D8B2B4 File Offset: 0x00D894B4
		public int TargetLevel { get; set; }

		// Token: 0x17008883 RID: 34947
		// (get) Token: 0x06038F8E RID: 233358 RVA: 0x00D8B2BD File Offset: 0x00D894BD
		// (set) Token: 0x06038F8F RID: 233359 RVA: 0x00D8B2C5 File Offset: 0x00D894C5
		public EKurotatoEnemyDetailBookTabAllOrWave TabAllOrWave { get; set; }

		// Token: 0x06038F90 RID: 233360 RVA: 0x00D8B2CE File Offset: 0x00D894CE
		public List<KurotatoEnemyData> GetMonsterGridItemDataList()
		{
			return this.MonsterGridItemDataList;
		}

		// Token: 0x0401DDA6 RID: 122278
		protected readonly Dictionary<int, int> WaveMonsterIdToNum = new Dictionary<int, int>();

		// Token: 0x0401DDA7 RID: 122279
		protected readonly List<KurotatoEnemyData> MonsterGridItemDataList = new List<KurotatoEnemyData>();

		// Token: 0x0401DDA8 RID: 122280
		[Nullable(2)]
		public KurotatoEnemyData CurSelectedGridItemData;
	}
}
