using System;

// Token: 0x020027EF RID: 10223
public interface ISkillSlotExtendData
{
	// Token: 0x17001B91 RID: 7057
	// (get) Token: 0x06014FC7 RID: 85959
	// (set) Token: 0x06014FC8 RID: 85960
	int RoleId { get; set; }

	// Token: 0x17001B92 RID: 7058
	// (get) Token: 0x06014FC9 RID: 85961
	// (set) Token: 0x06014FCA RID: 85962
	int SkillNodeId { get; set; }

	// Token: 0x17001B93 RID: 7059
	// (get) Token: 0x06014FCB RID: 85963
	// (set) Token: 0x06014FCC RID: 85964
	int IconId { get; set; }

	// Token: 0x17001B94 RID: 7060
	// (get) Token: 0x06014FCD RID: 85965
	// (set) Token: 0x06014FCE RID: 85966
	int CurrentLevel { get; set; }

	// Token: 0x17001B95 RID: 7061
	// (get) Token: 0x06014FCF RID: 85967
	// (set) Token: 0x06014FD0 RID: 85968
	int NormalTargetLevel { get; set; }

	// Token: 0x17001B96 RID: 7062
	// (get) Token: 0x06014FD1 RID: 85969
	// (set) Token: 0x06014FD2 RID: 85970
	int PerfectTargetLevel { get; set; }

	// Token: 0x17001B97 RID: 7063
	// (get) Token: 0x06014FD3 RID: 85971
	// (set) Token: 0x06014FD4 RID: 85972
	ESkillType SkillType { get; set; }

	// Token: 0x17001B98 RID: 7064
	// (get) Token: 0x06014FD5 RID: 85973
	// (set) Token: 0x06014FD6 RID: 85974
	int NodeIndex { get; set; }
}
