using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B85 RID: 7045
[NullableContext(1)]
public interface IQuestTreeNodeUnlockCondition
{
	// Token: 0x17001A64 RID: 6756
	// (get) Token: 0x060118EE RID: 71918
	bool IsFinished { get; }

	// Token: 0x17001A65 RID: 6757
	// (get) Token: 0x060118EF RID: 71919
	string Text { get; }

	// Token: 0x17001A66 RID: 6758
	// (get) Token: 0x060118F0 RID: 71920
	int HelpId { get; }

	// Token: 0x17001A67 RID: 6759
	// (get) Token: 0x060118F1 RID: 71921
	List<object> TextParam { get; }

	// Token: 0x17001A68 RID: 6760
	// (get) Token: 0x060118F2 RID: 71922
	bool HasGoto { get; }

	// Token: 0x060118F3 RID: 71923
	void Goto();
}
