using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200269A RID: 9882
[NullableContext(1)]
public interface IQuestTreeNodeUnlockCondition
{
	// Token: 0x17001A2C RID: 6700
	// (get) Token: 0x0601440C RID: 82956
	bool IsFinished { get; }

	// Token: 0x17001A2D RID: 6701
	// (get) Token: 0x0601440D RID: 82957
	string Text { get; }

	// Token: 0x17001A2E RID: 6702
	// (get) Token: 0x0601440E RID: 82958
	int HelpId { get; }

	// Token: 0x17001A2F RID: 6703
	// (get) Token: 0x0601440F RID: 82959
	List<object> TextParam { get; }

	// Token: 0x17001A30 RID: 6704
	// (get) Token: 0x06014410 RID: 82960
	bool HasGoto { get; }

	// Token: 0x06014411 RID: 82961
	void Goto();
}
