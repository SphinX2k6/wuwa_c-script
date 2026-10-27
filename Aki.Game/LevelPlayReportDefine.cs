using System;
using System.Runtime.CompilerServices;

// Token: 0x02002055 RID: 8277
public class LevelPlayReportDefine
{
	// Token: 0x0200864B RID: 34379
	public enum ELevelPlayReportState
	{
		// Token: 0x0402BB4F RID: 179023
		Close,
		// Token: 0x0402BB50 RID: 179024
		Wait,
		// Token: 0x0402BB51 RID: 179025
		Open,
		// Token: 0x0402BB52 RID: 179026
		Finish,
		// Token: 0x0402BB53 RID: 179027
		AllPlayerGetReward,
		// Token: 0x0402BB54 RID: 179028
		Hide
	}

	// Token: 0x0200864C RID: 34380
	[NullableContext(1)]
	public interface ILevelPlayReportConfigData
	{
		// Token: 0x1700A077 RID: 41079
		// (get) Token: 0x0604A8E5 RID: 305381
		// (set) Token: 0x0604A8E6 RID: 305382
		int LevelPlayId { get; set; }

		// Token: 0x1700A078 RID: 41080
		// (get) Token: 0x0604A8E7 RID: 305383
		// (set) Token: 0x0604A8E8 RID: 305384
		string[] Vars { get; set; }

		// Token: 0x1700A079 RID: 41081
		// (get) Token: 0x0604A8E9 RID: 305385
		// (set) Token: 0x0604A8EA RID: 305386
		int[] Chests { get; set; }

		// Token: 0x1700A07A RID: 41082
		// (get) Token: 0x0604A8EB RID: 305387
		// (set) Token: 0x0604A8EC RID: 305388
		int Type { get; set; }

		// Token: 0x1700A07B RID: 41083
		// (get) Token: 0x0604A8ED RID: 305389
		// (set) Token: 0x0604A8EE RID: 305390
		string[] Descs { get; set; }

		// Token: 0x1700A07C RID: 41084
		// (get) Token: 0x0604A8EF RID: 305391
		// (set) Token: 0x0604A8F0 RID: 305392
		string GetBoxNumKey { get; set; }
	}

	// Token: 0x0200864D RID: 34381
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPlayReportConfigData : LevelPlayReportDefine.ILevelPlayReportConfigData
	{
		// Token: 0x1700A07D RID: 41085
		// (get) Token: 0x0604A8F1 RID: 305393 RVA: 0x01375BB6 File Offset: 0x01373DB6
		// (set) Token: 0x0604A8F2 RID: 305394 RVA: 0x01375BBE File Offset: 0x01373DBE
		public int LevelPlayId { get; set; }

		// Token: 0x1700A07E RID: 41086
		// (get) Token: 0x0604A8F3 RID: 305395 RVA: 0x01375BC7 File Offset: 0x01373DC7
		// (set) Token: 0x0604A8F4 RID: 305396 RVA: 0x01375BCF File Offset: 0x01373DCF
		public string[] Vars { get; set; }

		// Token: 0x1700A07F RID: 41087
		// (get) Token: 0x0604A8F5 RID: 305397 RVA: 0x01375BD8 File Offset: 0x01373DD8
		// (set) Token: 0x0604A8F6 RID: 305398 RVA: 0x01375BE0 File Offset: 0x01373DE0
		public int[] Chests { get; set; }

		// Token: 0x1700A080 RID: 41088
		// (get) Token: 0x0604A8F7 RID: 305399 RVA: 0x01375BE9 File Offset: 0x01373DE9
		// (set) Token: 0x0604A8F8 RID: 305400 RVA: 0x01375BF1 File Offset: 0x01373DF1
		public int Type { get; set; }

		// Token: 0x1700A081 RID: 41089
		// (get) Token: 0x0604A8F9 RID: 305401 RVA: 0x01375BFA File Offset: 0x01373DFA
		// (set) Token: 0x0604A8FA RID: 305402 RVA: 0x01375C02 File Offset: 0x01373E02
		public string[] Descs { get; set; }

		// Token: 0x1700A082 RID: 41090
		// (get) Token: 0x0604A8FB RID: 305403 RVA: 0x01375C0B File Offset: 0x01373E0B
		// (set) Token: 0x0604A8FC RID: 305404 RVA: 0x01375C13 File Offset: 0x01373E13
		public string GetBoxNumKey { get; set; }
	}
}
