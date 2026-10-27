using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F4B RID: 24395
	public class WheelTowerMedalGroupData : IWheelTowerMedalGroupData
	{
		// Token: 0x17008FC4 RID: 36804
		// (get) Token: 0x0603DFB7 RID: 253879 RVA: 0x00EF5D06 File Offset: 0x00EF3F06
		// (set) Token: 0x0603DFB8 RID: 253880 RVA: 0x00EF5D0E File Offset: 0x00EF3F0E
		public int GroupId { get; set; }

		// Token: 0x17008FC5 RID: 36805
		// (get) Token: 0x0603DFB9 RID: 253881 RVA: 0x00EF5D17 File Offset: 0x00EF3F17
		// (set) Token: 0x0603DFBA RID: 253882 RVA: 0x00EF5D1F File Offset: 0x00EF3F1F
		public int SeasonId { get; set; }

		// Token: 0x17008FC6 RID: 36806
		// (get) Token: 0x0603DFBB RID: 253883 RVA: 0x00EF5D28 File Offset: 0x00EF3F28
		// (set) Token: 0x0603DFBC RID: 253884 RVA: 0x00EF5D30 File Offset: 0x00EF3F30
		public int CycleId { get; set; }

		// Token: 0x17008FC7 RID: 36807
		// (get) Token: 0x0603DFBD RID: 253885 RVA: 0x00EF5D39 File Offset: 0x00EF3F39
		// (set) Token: 0x0603DFBE RID: 253886 RVA: 0x00EF5D41 File Offset: 0x00EF3F41
		public int Progress { get; set; }

		// Token: 0x17008FC8 RID: 36808
		// (get) Token: 0x0603DFBF RID: 253887 RVA: 0x00EF5D4A File Offset: 0x00EF3F4A
		// (set) Token: 0x0603DFC0 RID: 253888 RVA: 0x00EF5D52 File Offset: 0x00EF3F52
		public long CompleteTime { get; set; }

		// Token: 0x17008FC9 RID: 36809
		// (get) Token: 0x0603DFC1 RID: 253889 RVA: 0x00EF5D5B File Offset: 0x00EF3F5B
		// (set) Token: 0x0603DFC2 RID: 253890 RVA: 0x00EF5D63 File Offset: 0x00EF3F63
		public int CurrentMedalId { get; set; }

		// Token: 0x17008FCA RID: 36810
		// (get) Token: 0x0603DFC3 RID: 253891 RVA: 0x00EF5D6C File Offset: 0x00EF3F6C
		// (set) Token: 0x0603DFC4 RID: 253892 RVA: 0x00EF5D74 File Offset: 0x00EF3F74
		public int NextMedalId { get; set; }

		// Token: 0x17008FCB RID: 36811
		// (get) Token: 0x0603DFC5 RID: 253893 RVA: 0x00EF5D7D File Offset: 0x00EF3F7D
		// (set) Token: 0x0603DFC6 RID: 253894 RVA: 0x00EF5D85 File Offset: 0x00EF3F85
		public int CurrentTarget { get; set; }

		// Token: 0x17008FCC RID: 36812
		// (get) Token: 0x0603DFC7 RID: 253895 RVA: 0x00EF5D8E File Offset: 0x00EF3F8E
		// (set) Token: 0x0603DFC8 RID: 253896 RVA: 0x00EF5D96 File Offset: 0x00EF3F96
		public bool IsMaxLevel { get; set; }
	}
}
