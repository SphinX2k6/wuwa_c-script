using System;
using System.Runtime.CompilerServices;

// Token: 0x02001528 RID: 5416
public class LevelPlayReportDefine
{
	// Token: 0x020077D2 RID: 30674
	public enum ELevelPlayReportState
	{
		// Token: 0x04026E5E RID: 159326
		Close,
		// Token: 0x04026E5F RID: 159327
		Wait,
		// Token: 0x04026E60 RID: 159328
		Open,
		// Token: 0x04026E61 RID: 159329
		Finish,
		// Token: 0x04026E62 RID: 159330
		AllPlayerGetReward,
		// Token: 0x04026E63 RID: 159331
		Hide
	}

	// Token: 0x020077D3 RID: 30675
	[NullableContext(1)]
	public interface ILevelPlayReportConfigData
	{
		// Token: 0x17007815 RID: 30741
		// (get) Token: 0x06040CDF RID: 265439
		// (set) Token: 0x06040CE0 RID: 265440
		int LevelPlayId { get; set; }

		// Token: 0x17007816 RID: 30742
		// (get) Token: 0x06040CE1 RID: 265441
		// (set) Token: 0x06040CE2 RID: 265442
		string[] Vars { get; set; }

		// Token: 0x17007817 RID: 30743
		// (get) Token: 0x06040CE3 RID: 265443
		// (set) Token: 0x06040CE4 RID: 265444
		int[] Chests { get; set; }

		// Token: 0x17007818 RID: 30744
		// (get) Token: 0x06040CE5 RID: 265445
		// (set) Token: 0x06040CE6 RID: 265446
		int Type { get; set; }

		// Token: 0x17007819 RID: 30745
		// (get) Token: 0x06040CE7 RID: 265447
		// (set) Token: 0x06040CE8 RID: 265448
		string[] Descs { get; set; }

		// Token: 0x1700781A RID: 30746
		// (get) Token: 0x06040CE9 RID: 265449
		// (set) Token: 0x06040CEA RID: 265450
		string GetBoxNumKey { get; set; }
	}

	// Token: 0x020077D4 RID: 30676
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPlayReportConfigData : LevelPlayReportDefine.ILevelPlayReportConfigData
	{
		// Token: 0x1700781B RID: 30747
		// (get) Token: 0x06040CEB RID: 265451 RVA: 0x01319016 File Offset: 0x01317216
		// (set) Token: 0x06040CEC RID: 265452 RVA: 0x0131901E File Offset: 0x0131721E
		public int LevelPlayId { get; set; }

		// Token: 0x1700781C RID: 30748
		// (get) Token: 0x06040CED RID: 265453 RVA: 0x01319027 File Offset: 0x01317227
		// (set) Token: 0x06040CEE RID: 265454 RVA: 0x0131902F File Offset: 0x0131722F
		public string[] Vars { get; set; }

		// Token: 0x1700781D RID: 30749
		// (get) Token: 0x06040CEF RID: 265455 RVA: 0x01319038 File Offset: 0x01317238
		// (set) Token: 0x06040CF0 RID: 265456 RVA: 0x01319040 File Offset: 0x01317240
		public int[] Chests { get; set; }

		// Token: 0x1700781E RID: 30750
		// (get) Token: 0x06040CF1 RID: 265457 RVA: 0x01319049 File Offset: 0x01317249
		// (set) Token: 0x06040CF2 RID: 265458 RVA: 0x01319051 File Offset: 0x01317251
		public int Type { get; set; }

		// Token: 0x1700781F RID: 30751
		// (get) Token: 0x06040CF3 RID: 265459 RVA: 0x0131905A File Offset: 0x0131725A
		// (set) Token: 0x06040CF4 RID: 265460 RVA: 0x01319062 File Offset: 0x01317262
		public string[] Descs { get; set; }

		// Token: 0x17007820 RID: 30752
		// (get) Token: 0x06040CF5 RID: 265461 RVA: 0x0131906B File Offset: 0x0131726B
		// (set) Token: 0x06040CF6 RID: 265462 RVA: 0x01319073 File Offset: 0x01317273
		public string GetBoxNumKey { get; set; }
	}
}
