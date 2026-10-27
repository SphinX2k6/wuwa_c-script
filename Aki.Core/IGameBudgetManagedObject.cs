using System;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020000A8 RID: 168
public interface IGameBudgetManagedObject
{
	// Token: 0x06000503 RID: 1283
	void ScheduledTick(float deltaSeconds, int deltaFrames, float distance);

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000504 RID: 1284
	bool HasScheduledAfterTick { get; }

	// Token: 0x06000505 RID: 1285 RVA: 0x0001B6D0 File Offset: 0x000198D0
	void ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
	{
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000506 RID: 1286
	bool HasOnEnabledChange { get; }

	// Token: 0x06000507 RID: 1287 RVA: 0x0001B6D2 File Offset: 0x000198D2
	void OnEnabledChange(bool enable, float distance)
	{
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000508 RID: 1288
	bool HasOnWasRecentlyRenderedOnScreenChange { get; }

	// Token: 0x06000509 RID: 1289 RVA: 0x0001B6D4 File Offset: 0x000198D4
	void OnWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001B6D6 File Offset: 0x000198D6
	bool HasLocationProxyFunction
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0001B6DC File Offset: 0x000198DC
	FVectorDouble? LocationProxyFunction()
	{
		return null;
	}

	// Token: 0x0600050C RID: 1292
	GCHandle GetGCHandle();
}
