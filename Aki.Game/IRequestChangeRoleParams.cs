using System;

// Token: 0x02001EC2 RID: 7874
public interface IRequestChangeRoleParams
{
	// Token: 0x17001DA4 RID: 7588
	// (get) Token: 0x06013741 RID: 79681
	// (set) Token: 0x06013742 RID: 79682
	bool? FilterSameRole { get; set; }

	// Token: 0x17001DA5 RID: 7589
	// (get) Token: 0x06013743 RID: 79683
	// (set) Token: 0x06013744 RID: 79684
	bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001DA6 RID: 7590
	// (get) Token: 0x06013745 RID: 79685
	// (set) Token: 0x06013746 RID: 79686
	bool? ForceInheritTransform { get; set; }

	// Token: 0x17001DA7 RID: 7591
	// (get) Token: 0x06013747 RID: 79687
	// (set) Token: 0x06013748 RID: 79688
	bool? GoBattleInvincible { get; set; }

	// Token: 0x17001DA8 RID: 7592
	// (get) Token: 0x06013749 RID: 79689
	// (set) Token: 0x0601374A RID: 79690
	bool? CanUseGoBattleSkill { get; set; }
}
