using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002954 RID: 10580
[NullableContext(1)]
public interface IUpdateGroupParams
{
	// Token: 0x17001D58 RID: 7512
	// (get) Token: 0x06015DBB RID: 89531
	// (set) Token: 0x06015DBC RID: 89532
	ETeamGroupType GroupType { get; set; }

	// Token: 0x17001D59 RID: 7513
	// (get) Token: 0x06015DBD RID: 89533
	// (set) Token: 0x06015DBE RID: 89534
	IList<SceneTeamRole> GroupRoleList { get; set; }

	// Token: 0x17001D5A RID: 7514
	// (get) Token: 0x06015DBF RID: 89535
	// (set) Token: 0x06015DC0 RID: 89536
	int CurrentRoleId { get; set; }

	// Token: 0x17001D5B RID: 7515
	// (get) Token: 0x06015DC1 RID: 89537
	// (set) Token: 0x06015DC2 RID: 89538
	ETeamLivingState? LivingState { get; set; }

	// Token: 0x17001D5C RID: 7516
	// (get) Token: 0x06015DC3 RID: 89539
	// (set) Token: 0x06015DC4 RID: 89540
	bool? IsFixedLocation { get; set; }

	// Token: 0x17001D5D RID: 7517
	// (get) Token: 0x06015DC5 RID: 89541
	// (set) Token: 0x06015DC6 RID: 89542
	bool? ReplaceAllRole { get; set; }
}
