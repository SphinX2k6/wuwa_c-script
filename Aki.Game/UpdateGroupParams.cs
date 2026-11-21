using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001ED0 RID: 7888
[NullableContext(1)]
[Nullable(0)]
public class UpdateGroupParams : IUpdateGroupParams
{
	// Token: 0x17001DB7 RID: 7607
	// (get) Token: 0x060137CB RID: 79819 RVA: 0x005AEF54 File Offset: 0x005AD154
	// (set) Token: 0x060137CC RID: 79820 RVA: 0x005AEF5C File Offset: 0x005AD15C
	public ETeamGroupType GroupType { get; set; }

	// Token: 0x17001DB8 RID: 7608
	// (get) Token: 0x060137CD RID: 79821 RVA: 0x005AEF65 File Offset: 0x005AD165
	// (set) Token: 0x060137CE RID: 79822 RVA: 0x005AEF6D File Offset: 0x005AD16D
	public IList<SceneTeamRole> GroupRoleList { get; set; }

	// Token: 0x17001DB9 RID: 7609
	// (get) Token: 0x060137CF RID: 79823 RVA: 0x005AEF76 File Offset: 0x005AD176
	// (set) Token: 0x060137D0 RID: 79824 RVA: 0x005AEF7E File Offset: 0x005AD17E
	public int CurrentRoleId { get; set; }

	// Token: 0x17001DBA RID: 7610
	// (get) Token: 0x060137D1 RID: 79825 RVA: 0x005AEF87 File Offset: 0x005AD187
	// (set) Token: 0x060137D2 RID: 79826 RVA: 0x005AEF8F File Offset: 0x005AD18F
	public ETeamLivingState? LivingState { get; set; }

	// Token: 0x17001DBB RID: 7611
	// (get) Token: 0x060137D3 RID: 79827 RVA: 0x005AEF98 File Offset: 0x005AD198
	// (set) Token: 0x060137D4 RID: 79828 RVA: 0x005AEFA0 File Offset: 0x005AD1A0
	public bool? IsFixedLocation { get; set; }

	// Token: 0x17001DBC RID: 7612
	// (get) Token: 0x060137D5 RID: 79829 RVA: 0x005AEFA9 File Offset: 0x005AD1A9
	// (set) Token: 0x060137D6 RID: 79830 RVA: 0x005AEFB1 File Offset: 0x005AD1B1
	public bool? ReplaceAllRole { get; set; }
}
