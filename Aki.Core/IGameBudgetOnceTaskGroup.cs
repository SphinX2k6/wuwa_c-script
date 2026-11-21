using System;
using UnrealEngine;

// Token: 0x020000AB RID: 171
public interface IGameBudgetOnceTaskGroup
{
	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600054E RID: 1358
	FName GroupId { get; }

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x0600054F RID: 1359
	int Priority { get; }

	// Token: 0x06000550 RID: 1360
	bool IsEmpty();

	// Token: 0x06000551 RID: 1361
	void Consume();
}
