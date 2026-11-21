using System;

// Token: 0x0200172F RID: 5935
public interface IMotorLevelAttrData
{
	// Token: 0x170015E7 RID: 5607
	// (get) Token: 0x0600E6A9 RID: 59049
	// (set) Token: 0x0600E6AA RID: 59050
	int AttrId { get; set; }

	// Token: 0x170015E8 RID: 5608
	// (get) Token: 0x0600E6AB RID: 59051
	// (set) Token: 0x0600E6AC RID: 59052
	int Level { get; set; }

	// Token: 0x170015E9 RID: 5609
	// (get) Token: 0x0600E6AD RID: 59053
	// (set) Token: 0x0600E6AE RID: 59054
	bool IsShowBg { get; set; }

	// Token: 0x170015EA RID: 5610
	// (get) Token: 0x0600E6AF RID: 59055
	// (set) Token: 0x0600E6B0 RID: 59056
	bool IsSpecial { get; set; }
}
