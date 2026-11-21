using System;

// Token: 0x02001EC3 RID: 7875
public class RequestChangeRoleParams : IRequestChangeRoleParams
{
	// Token: 0x17001DA9 RID: 7593
	// (get) Token: 0x0601374B RID: 79691 RVA: 0x005ABB1C File Offset: 0x005A9D1C
	// (set) Token: 0x0601374C RID: 79692 RVA: 0x005ABB24 File Offset: 0x005A9D24
	public bool? FilterSameRole { get; set; }

	// Token: 0x17001DAA RID: 7594
	// (get) Token: 0x0601374D RID: 79693 RVA: 0x005ABB2D File Offset: 0x005A9D2D
	// (set) Token: 0x0601374E RID: 79694 RVA: 0x005ABB35 File Offset: 0x005A9D35
	public bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001DAB RID: 7595
	// (get) Token: 0x0601374F RID: 79695 RVA: 0x005ABB3E File Offset: 0x005A9D3E
	// (set) Token: 0x06013750 RID: 79696 RVA: 0x005ABB46 File Offset: 0x005A9D46
	public bool? ForceInheritTransform { get; set; }

	// Token: 0x17001DAC RID: 7596
	// (get) Token: 0x06013751 RID: 79697 RVA: 0x005ABB4F File Offset: 0x005A9D4F
	// (set) Token: 0x06013752 RID: 79698 RVA: 0x005ABB57 File Offset: 0x005A9D57
	public bool? GoBattleInvincible { get; set; }

	// Token: 0x17001DAD RID: 7597
	// (get) Token: 0x06013753 RID: 79699 RVA: 0x005ABB60 File Offset: 0x005A9D60
	// (set) Token: 0x06013754 RID: 79700 RVA: 0x005ABB68 File Offset: 0x005A9D68
	public bool? CanUseGoBattleSkill { get; set; }
}
