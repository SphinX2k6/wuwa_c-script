using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002955 RID: 10581
[NullableContext(1)]
[Nullable(0)]
public class UpdateGroupParams : IUpdateGroupParams
{
	// Token: 0x17001D5E RID: 7518
	// (get) Token: 0x06015DC7 RID: 89543 RVA: 0x00583F54 File Offset: 0x00582154
	// (set) Token: 0x06015DC8 RID: 89544 RVA: 0x00583F5C File Offset: 0x0058215C
	public ETeamGroupType GroupType { get; set; }

	// Token: 0x17001D5F RID: 7519
	// (get) Token: 0x06015DC9 RID: 89545 RVA: 0x00583F65 File Offset: 0x00582165
	// (set) Token: 0x06015DCA RID: 89546 RVA: 0x00583F6D File Offset: 0x0058216D
	public IList<SceneTeamRole> GroupRoleList { get; set; }

	// Token: 0x17001D60 RID: 7520
	// (get) Token: 0x06015DCB RID: 89547 RVA: 0x00583F76 File Offset: 0x00582176
	// (set) Token: 0x06015DCC RID: 89548 RVA: 0x00583F7E File Offset: 0x0058217E
	public int CurrentRoleId { get; set; }

	// Token: 0x17001D61 RID: 7521
	// (get) Token: 0x06015DCD RID: 89549 RVA: 0x00583F87 File Offset: 0x00582187
	// (set) Token: 0x06015DCE RID: 89550 RVA: 0x00583F8F File Offset: 0x0058218F
	public ETeamLivingState? LivingState { get; set; }

	// Token: 0x17001D62 RID: 7522
	// (get) Token: 0x06015DCF RID: 89551 RVA: 0x00583F98 File Offset: 0x00582198
	// (set) Token: 0x06015DD0 RID: 89552 RVA: 0x00583FA0 File Offset: 0x005821A0
	public bool? IsFixedLocation { get; set; }

	// Token: 0x17001D63 RID: 7523
	// (get) Token: 0x06015DD1 RID: 89553 RVA: 0x00583FA9 File Offset: 0x005821A9
	// (set) Token: 0x06015DD2 RID: 89554 RVA: 0x00583FB1 File Offset: 0x005821B1
	public bool? ReplaceAllRole { get; set; }
}
