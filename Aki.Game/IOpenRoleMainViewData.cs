using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020028D6 RID: 10454
[NullableContext(2)]
public interface IOpenRoleMainViewData
{
	// Token: 0x17001CEF RID: 7407
	// (get) Token: 0x06015943 RID: 88387
	// (set) Token: 0x06015944 RID: 88388
	ERoleAgentType AgentType { get; set; }

	// Token: 0x17001CF0 RID: 7408
	// (get) Token: 0x06015945 RID: 88389
	// (set) Token: 0x06015946 RID: 88390
	int? SelectRoleId { get; set; }

	// Token: 0x17001CF1 RID: 7409
	// (get) Token: 0x06015947 RID: 88391
	// (set) Token: 0x06015948 RID: 88392
	List<int> RoleIdList { get; set; }

	// Token: 0x17001CF2 RID: 7410
	// (get) Token: 0x06015949 RID: 88393
	// (set) Token: 0x0601594A RID: 88394
	EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x17001CF3 RID: 7411
	// (get) Token: 0x0601594B RID: 88395
	// (set) Token: 0x0601594C RID: 88396
	TOpenViewCallBack FinishCallback { get; set; }

	// Token: 0x17001CF4 RID: 7412
	// (get) Token: 0x0601594D RID: 88397
	// (set) Token: 0x0601594E RID: 88398
	ETeamPositionType? TeamPositionType { get; set; }

	// Token: 0x17001CF5 RID: 7413
	// (get) Token: 0x0601594F RID: 88399
	// (set) Token: 0x06015950 RID: 88400
	ERoleViewSource? Source { get; set; }
}
