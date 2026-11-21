using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Ui;

// Token: 0x02001E27 RID: 7719
public class RoleSkillTreeInfoViewData : UiPopViewData, IRoleSkillTreeInfoItemData
{
	// Token: 0x17001D2F RID: 7471
	// (get) Token: 0x060131A6 RID: 78246 RVA: 0x00595A3A File Offset: 0x00593C3A
	// (set) Token: 0x060131A7 RID: 78247 RVA: 0x00595A42 File Offset: 0x00593C42
	public int RoleId { get; set; }

	// Token: 0x17001D30 RID: 7472
	// (get) Token: 0x060131A8 RID: 78248 RVA: 0x00595A4B File Offset: 0x00593C4B
	// (set) Token: 0x060131A9 RID: 78249 RVA: 0x00595A53 File Offset: 0x00593C53
	public int SkillNodeId { get; set; }

	// Token: 0x0400A40C RID: 41996
	[Nullable(2)]
	public RoleViewAgent RoleViewAgent;
}
