using System;

// Token: 0x02001ED5 RID: 7893
public interface IChangeRoleParams
{
	// Token: 0x17001DC9 RID: 7625
	// (get) Token: 0x060137F2 RID: 79858
	// (set) Token: 0x060137F3 RID: 79859
	bool? UseGoBattleSkill { get; set; }

	// Token: 0x17001DCA RID: 7626
	// (get) Token: 0x060137F4 RID: 79860
	// (set) Token: 0x060137F5 RID: 79861
	double? CoolDown { get; set; }

	// Token: 0x17001DCB RID: 7627
	// (get) Token: 0x060137F6 RID: 79862
	// (set) Token: 0x060137F7 RID: 79863
	bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001DCC RID: 7628
	// (get) Token: 0x060137F8 RID: 79864
	// (set) Token: 0x060137F9 RID: 79865
	bool? AllowRefreshTransform { get; set; }

	// Token: 0x17001DCD RID: 7629
	// (get) Token: 0x060137FA RID: 79866
	// (set) Token: 0x060137FB RID: 79867
	bool? ForceInheritTransform { get; set; }

	// Token: 0x17001DCE RID: 7630
	// (get) Token: 0x060137FC RID: 79868
	// (set) Token: 0x060137FD RID: 79869
	bool? ForceChangeRole { get; set; }
}
