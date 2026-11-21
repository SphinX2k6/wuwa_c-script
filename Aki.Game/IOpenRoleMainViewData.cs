using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001E51 RID: 7761
[NullableContext(2)]
public interface IOpenRoleMainViewData
{
	// Token: 0x17001D47 RID: 7495
	// (get) Token: 0x06013343 RID: 78659
	// (set) Token: 0x06013344 RID: 78660
	ERoleAgentType AgentType { get; set; }

	// Token: 0x17001D48 RID: 7496
	// (get) Token: 0x06013345 RID: 78661
	// (set) Token: 0x06013346 RID: 78662
	int? SelectRoleId { get; set; }

	// Token: 0x17001D49 RID: 7497
	// (get) Token: 0x06013347 RID: 78663
	// (set) Token: 0x06013348 RID: 78664
	List<int> RoleIdList { get; set; }

	// Token: 0x17001D4A RID: 7498
	// (get) Token: 0x06013349 RID: 78665
	// (set) Token: 0x0601334A RID: 78666
	EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x17001D4B RID: 7499
	// (get) Token: 0x0601334B RID: 78667
	// (set) Token: 0x0601334C RID: 78668
	TOpenViewCallBack FinishCallback { get; set; }

	// Token: 0x17001D4C RID: 7500
	// (get) Token: 0x0601334D RID: 78669
	// (set) Token: 0x0601334E RID: 78670
	ETeamPositionType? TeamPositionType { get; set; }

	// Token: 0x17001D4D RID: 7501
	// (get) Token: 0x0601334F RID: 78671
	// (set) Token: 0x06013350 RID: 78672
	ERoleViewSource? Source { get; set; }

	// Token: 0x17001D4E RID: 7502
	// (get) Token: 0x06013351 RID: 78673
	// (set) Token: 0x06013352 RID: 78674
	bool UseMainViewSort { get; set; }
}
