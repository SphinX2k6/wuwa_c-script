using System;
using UnrealEngine;

// Token: 0x020000A9 RID: 169
public interface IGameBudgetOnceTaskGroup
{
	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x0600050D RID: 1293
	FName GroupId { get; }

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600050E RID: 1294
	int Priority { get; }

	// Token: 0x0600050F RID: 1295
	bool IsEmpty();

	// Token: 0x06000510 RID: 1296
	void Consume();
}
