using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F3A RID: 24378
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerPopupData : IWheelTowerPopupData
	{
		// Token: 0x17008F59 RID: 36697
		// (get) Token: 0x0603DED8 RID: 253656 RVA: 0x00EF584C File Offset: 0x00EF3A4C
		// (set) Token: 0x0603DED9 RID: 253657 RVA: 0x00EF5854 File Offset: 0x00EF3A54
		public int TotalScore { get; set; }

		// Token: 0x17008F5A RID: 36698
		// (get) Token: 0x0603DEDA RID: 253658 RVA: 0x00EF585D File Offset: 0x00EF3A5D
		// (set) Token: 0x0603DEDB RID: 253659 RVA: 0x00EF5865 File Offset: 0x00EF3A65
		public int RoundScore { get; set; }

		// Token: 0x17008F5B RID: 36699
		// (get) Token: 0x0603DEDC RID: 253660 RVA: 0x00EF586E File Offset: 0x00EF3A6E
		// (set) Token: 0x0603DEDD RID: 253661 RVA: 0x00EF5876 File Offset: 0x00EF3A76
		public int ScoreRecord { get; set; }

		// Token: 0x17008F5C RID: 36700
		// (get) Token: 0x0603DEDE RID: 253662 RVA: 0x00EF587F File Offset: 0x00EF3A7F
		// (set) Token: 0x0603DEDF RID: 253663 RVA: 0x00EF5887 File Offset: 0x00EF3A87
		public List<int> TeamRoleIdList { get; set; } = new List<int>();

		// Token: 0x17008F5D RID: 36701
		// (get) Token: 0x0603DEE0 RID: 253664 RVA: 0x00EF5890 File Offset: 0x00EF3A90
		// (set) Token: 0x0603DEE1 RID: 253665 RVA: 0x00EF5898 File Offset: 0x00EF3A98
		public int BuffId { get; set; }
	}
}
