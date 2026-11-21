using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001ECF RID: 7887
[NullableContext(1)]
public interface IUpdateGroupParams
{
	// Token: 0x17001DB1 RID: 7601
	// (get) Token: 0x060137BF RID: 79807
	// (set) Token: 0x060137C0 RID: 79808
	ETeamGroupType GroupType { get; set; }

	// Token: 0x17001DB2 RID: 7602
	// (get) Token: 0x060137C1 RID: 79809
	// (set) Token: 0x060137C2 RID: 79810
	IList<SceneTeamRole> GroupRoleList { get; set; }

	// Token: 0x17001DB3 RID: 7603
	// (get) Token: 0x060137C3 RID: 79811
	// (set) Token: 0x060137C4 RID: 79812
	int CurrentRoleId { get; set; }

	// Token: 0x17001DB4 RID: 7604
	// (get) Token: 0x060137C5 RID: 79813
	// (set) Token: 0x060137C6 RID: 79814
	ETeamLivingState? LivingState { get; set; }

	// Token: 0x17001DB5 RID: 7605
	// (get) Token: 0x060137C7 RID: 79815
	// (set) Token: 0x060137C8 RID: 79816
	bool? IsFixedLocation { get; set; }

	// Token: 0x17001DB6 RID: 7606
	// (get) Token: 0x060137C9 RID: 79817
	// (set) Token: 0x060137CA RID: 79818
	bool? ReplaceAllRole { get; set; }
}
