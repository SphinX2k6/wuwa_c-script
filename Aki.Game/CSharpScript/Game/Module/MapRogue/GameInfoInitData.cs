using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004582 RID: 17794
	[NullableContext(1)]
	[Nullable(0)]
	public class GameInfoInitData : IGameInfoInitData
	{
		// Token: 0x17005A6A RID: 23146
		// (get) Token: 0x0602CD47 RID: 183623 RVA: 0x00C8BA07 File Offset: 0x00C89C07
		// (set) Token: 0x0602CD48 RID: 183624 RVA: 0x00C8BA0F File Offset: 0x00C89C0F
		public int InstanceId { get; set; }

		// Token: 0x17005A6B RID: 23147
		// (get) Token: 0x0602CD49 RID: 183625 RVA: 0x00C8BA18 File Offset: 0x00C89C18
		// (set) Token: 0x0602CD4A RID: 183626 RVA: 0x00C8BA20 File Offset: 0x00C89C20
		public int RandomSeed { get; set; }

		// Token: 0x17005A6C RID: 23148
		// (get) Token: 0x0602CD4B RID: 183627 RVA: 0x00C8BA29 File Offset: 0x00C89C29
		// (set) Token: 0x0602CD4C RID: 183628 RVA: 0x00C8BA31 File Offset: 0x00C89C31
		public int MoodMin { get; set; }

		// Token: 0x17005A6D RID: 23149
		// (get) Token: 0x0602CD4D RID: 183629 RVA: 0x00C8BA3A File Offset: 0x00C89C3A
		// (set) Token: 0x0602CD4E RID: 183630 RVA: 0x00C8BA42 File Offset: 0x00C89C42
		public int MoodMax { get; set; }

		// Token: 0x17005A6E RID: 23150
		// (get) Token: 0x0602CD4F RID: 183631 RVA: 0x00C8BA4B File Offset: 0x00C89C4B
		// (set) Token: 0x0602CD50 RID: 183632 RVA: 0x00C8BA53 File Offset: 0x00C89C53
		public int InitMood { get; set; }

		// Token: 0x17005A6F RID: 23151
		// (get) Token: 0x0602CD51 RID: 183633 RVA: 0x00C8BA5C File Offset: 0x00C89C5C
		// (set) Token: 0x0602CD52 RID: 183634 RVA: 0x00C8BA64 File Offset: 0x00C89C64
		public List<MapGridData> MapGrids { get; set; }

		// Token: 0x17005A70 RID: 23152
		// (get) Token: 0x0602CD53 RID: 183635 RVA: 0x00C8BA6D File Offset: 0x00C89C6D
		// (set) Token: 0x0602CD54 RID: 183636 RVA: 0x00C8BA75 File Offset: 0x00C89C75
		public int MapWidth { get; set; }

		// Token: 0x17005A71 RID: 23153
		// (get) Token: 0x0602CD55 RID: 183637 RVA: 0x00C8BA7E File Offset: 0x00C89C7E
		// (set) Token: 0x0602CD56 RID: 183638 RVA: 0x00C8BA86 File Offset: 0x00C89C86
		public int MapHeight { get; set; }

		// Token: 0x17005A72 RID: 23154
		// (get) Token: 0x0602CD57 RID: 183639 RVA: 0x00C8BA8F File Offset: 0x00C89C8F
		// (set) Token: 0x0602CD58 RID: 183640 RVA: 0x00C8BA97 File Offset: 0x00C89C97
		public int PlayerGridIndex { get; set; }

		// Token: 0x17005A73 RID: 23155
		// (get) Token: 0x0602CD59 RID: 183641 RVA: 0x00C8BAA0 File Offset: 0x00C89CA0
		// (set) Token: 0x0602CD5A RID: 183642 RVA: 0x00C8BAA8 File Offset: 0x00C89CA8
		public int TeamLv { get; set; }

		// Token: 0x17005A74 RID: 23156
		// (get) Token: 0x0602CD5B RID: 183643 RVA: 0x00C8BAB1 File Offset: 0x00C89CB1
		// (set) Token: 0x0602CD5C RID: 183644 RVA: 0x00C8BAB9 File Offset: 0x00C89CB9
		public bool InBattle { get; set; }

		// Token: 0x17005A75 RID: 23157
		// (get) Token: 0x0602CD5D RID: 183645 RVA: 0x00C8BAC2 File Offset: 0x00C89CC2
		// (set) Token: 0x0602CD5E RID: 183646 RVA: 0x00C8BACA File Offset: 0x00C89CCA
		public int CurrencyItemId { get; set; }

		// Token: 0x17005A76 RID: 23158
		// (get) Token: 0x0602CD5F RID: 183647 RVA: 0x00C8BAD3 File Offset: 0x00C89CD3
		// (set) Token: 0x0602CD60 RID: 183648 RVA: 0x00C8BADB File Offset: 0x00C89CDB
		public int MoodRuleId { get; set; }

		// Token: 0x17005A77 RID: 23159
		// (get) Token: 0x0602CD61 RID: 183649 RVA: 0x00C8BAE4 File Offset: 0x00C89CE4
		// (set) Token: 0x0602CD62 RID: 183650 RVA: 0x00C8BAEC File Offset: 0x00C89CEC
		public int RoleMaxStar { get; set; }

		// Token: 0x17005A78 RID: 23160
		// (get) Token: 0x0602CD63 RID: 183651 RVA: 0x00C8BAF5 File Offset: 0x00C89CF5
		// (set) Token: 0x0602CD64 RID: 183652 RVA: 0x00C8BAFD File Offset: 0x00C89CFD
		public int RoleLevel { get; set; }
	}
}
