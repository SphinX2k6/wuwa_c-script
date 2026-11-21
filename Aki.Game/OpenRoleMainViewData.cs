using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001E52 RID: 7762
[NullableContext(2)]
[Nullable(0)]
public class OpenRoleMainViewData : IOpenRoleMainViewData
{
	// Token: 0x17001D4F RID: 7503
	// (get) Token: 0x06013353 RID: 78675 RVA: 0x0059D73D File Offset: 0x0059B93D
	// (set) Token: 0x06013354 RID: 78676 RVA: 0x0059D745 File Offset: 0x0059B945
	public ERoleAgentType AgentType { get; set; }

	// Token: 0x17001D50 RID: 7504
	// (get) Token: 0x06013355 RID: 78677 RVA: 0x0059D74E File Offset: 0x0059B94E
	// (set) Token: 0x06013356 RID: 78678 RVA: 0x0059D756 File Offset: 0x0059B956
	public int? SelectRoleId { get; set; }

	// Token: 0x17001D51 RID: 7505
	// (get) Token: 0x06013357 RID: 78679 RVA: 0x0059D75F File Offset: 0x0059B95F
	// (set) Token: 0x06013358 RID: 78680 RVA: 0x0059D767 File Offset: 0x0059B967
	public List<int> RoleIdList { get; set; }

	// Token: 0x17001D52 RID: 7506
	// (get) Token: 0x06013359 RID: 78681 RVA: 0x0059D770 File Offset: 0x0059B970
	// (set) Token: 0x0601335A RID: 78682 RVA: 0x0059D778 File Offset: 0x0059B978
	public EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x17001D53 RID: 7507
	// (get) Token: 0x0601335B RID: 78683 RVA: 0x0059D781 File Offset: 0x0059B981
	// (set) Token: 0x0601335C RID: 78684 RVA: 0x0059D789 File Offset: 0x0059B989
	public TOpenViewCallBack FinishCallback { get; set; }

	// Token: 0x17001D54 RID: 7508
	// (get) Token: 0x0601335D RID: 78685 RVA: 0x0059D792 File Offset: 0x0059B992
	// (set) Token: 0x0601335E RID: 78686 RVA: 0x0059D79A File Offset: 0x0059B99A
	public ETeamPositionType? TeamPositionType { get; set; }

	// Token: 0x17001D55 RID: 7509
	// (get) Token: 0x0601335F RID: 78687 RVA: 0x0059D7A3 File Offset: 0x0059B9A3
	// (set) Token: 0x06013360 RID: 78688 RVA: 0x0059D7AB File Offset: 0x0059B9AB
	public ERoleViewSource? Source { get; set; }

	// Token: 0x17001D56 RID: 7510
	// (get) Token: 0x06013361 RID: 78689 RVA: 0x0059D7B4 File Offset: 0x0059B9B4
	// (set) Token: 0x06013362 RID: 78690 RVA: 0x0059D7BC File Offset: 0x0059B9BC
	public bool UseMainViewSort { get; set; }
}
