using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Ui;

// Token: 0x020028AC RID: 10412
public class RoleSkillTreeInfoViewData : UiPopViewData, IRoleSkillTreeInfoItemData
{
	// Token: 0x17001CD7 RID: 7383
	// (get) Token: 0x060157A6 RID: 87974 RVA: 0x0056ABF2 File Offset: 0x00568DF2
	// (set) Token: 0x060157A7 RID: 87975 RVA: 0x0056ABFA File Offset: 0x00568DFA
	public int RoleId { get; set; }

	// Token: 0x17001CD8 RID: 7384
	// (get) Token: 0x060157A8 RID: 87976 RVA: 0x0056AC03 File Offset: 0x00568E03
	// (set) Token: 0x060157A9 RID: 87977 RVA: 0x0056AC0B File Offset: 0x00568E0B
	public int SkillNodeId { get; set; }

	// Token: 0x0400A023 RID: 40995
	[Nullable(2)]
	public RoleViewAgent RoleViewAgent;
}
