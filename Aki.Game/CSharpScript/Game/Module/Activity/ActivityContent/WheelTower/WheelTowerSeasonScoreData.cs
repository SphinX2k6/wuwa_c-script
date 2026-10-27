using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F3E RID: 24382
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonScoreData : IWheelTowerSeasonScoreData
	{
		// Token: 0x17008F73 RID: 36723
		// (get) Token: 0x0603DF0E RID: 253710 RVA: 0x00EF5938 File Offset: 0x00EF3B38
		// (set) Token: 0x0603DF0F RID: 253711 RVA: 0x00EF5940 File Offset: 0x00EF3B40
		public int Score { get; set; }

		// Token: 0x17008F74 RID: 36724
		// (get) Token: 0x0603DF10 RID: 253712 RVA: 0x00EF5949 File Offset: 0x00EF3B49
		// (set) Token: 0x0603DF11 RID: 253713 RVA: 0x00EF5951 File Offset: 0x00EF3B51
		public int PrevScore { get; set; }

		// Token: 0x17008F75 RID: 36725
		// (get) Token: 0x0603DF12 RID: 253714 RVA: 0x00EF595A File Offset: 0x00EF3B5A
		// (set) Token: 0x0603DF13 RID: 253715 RVA: 0x00EF5962 File Offset: 0x00EF3B62
		public int TotalScore { get; set; }

		// Token: 0x17008F76 RID: 36726
		// (get) Token: 0x0603DF14 RID: 253716 RVA: 0x00EF596B File Offset: 0x00EF3B6B
		// (set) Token: 0x0603DF15 RID: 253717 RVA: 0x00EF5973 File Offset: 0x00EF3B73
		public int CurScore { get; set; }

		// Token: 0x17008F77 RID: 36727
		// (get) Token: 0x0603DF16 RID: 253718 RVA: 0x00EF597C File Offset: 0x00EF3B7C
		// (set) Token: 0x0603DF17 RID: 253719 RVA: 0x00EF5984 File Offset: 0x00EF3B84
		public bool IsReceived { get; set; }

		// Token: 0x17008F78 RID: 36728
		// (get) Token: 0x0603DF18 RID: 253720 RVA: 0x00EF598D File Offset: 0x00EF3B8D
		// (set) Token: 0x0603DF19 RID: 253721 RVA: 0x00EF5995 File Offset: 0x00EF3B95
		public int DropId { get; set; }

		// Token: 0x17008F79 RID: 36729
		// (get) Token: 0x0603DF1A RID: 253722 RVA: 0x00EF599E File Offset: 0x00EF3B9E
		// (set) Token: 0x0603DF1B RID: 253723 RVA: 0x00EF59A6 File Offset: 0x00EF3BA6
		public int MotorPreviewId { get; set; }

		// Token: 0x17008F7A RID: 36730
		// (get) Token: 0x0603DF1C RID: 253724 RVA: 0x00EF59AF File Offset: 0x00EF3BAF
		// (set) Token: 0x0603DF1D RID: 253725 RVA: 0x00EF59B7 File Offset: 0x00EF3BB7
		public int WeaponPreviewId { get; set; }

		// Token: 0x17008F7B RID: 36731
		// (get) Token: 0x0603DF1E RID: 253726 RVA: 0x00EF59C0 File Offset: 0x00EF3BC0
		// (set) Token: 0x0603DF1F RID: 253727 RVA: 0x00EF59C8 File Offset: 0x00EF3BC8
		public string PreviewIcon { get; set; }
	}
}
