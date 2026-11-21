using System;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020000AA RID: 170
public interface IGameBudgetManagedObject
{
	// Token: 0x06000544 RID: 1348
	void ScheduledTick(float deltaSeconds, int deltaFrames, float distance);

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000545 RID: 1349
	bool HasScheduledAfterTick { get; }

	// Token: 0x06000546 RID: 1350 RVA: 0x0001BDB8 File Offset: 0x00019FB8
	void ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
	{
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000547 RID: 1351
	bool HasOnEnabledChange { get; }

	// Token: 0x06000548 RID: 1352 RVA: 0x0001BDBA File Offset: 0x00019FBA
	void OnEnabledChange(bool enable, float distance)
	{
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000549 RID: 1353
	bool HasOnWasRecentlyRenderedOnScreenChange { get; }

	// Token: 0x0600054A RID: 1354 RVA: 0x0001BDBC File Offset: 0x00019FBC
	void OnWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001BDBE File Offset: 0x00019FBE
	bool HasLocationProxyFunction
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0001BDC4 File Offset: 0x00019FC4
	FVectorDouble? LocationProxyFunction()
	{
		return null;
	}

	// Token: 0x0600054D RID: 1357
	GCHandle GetGCHandle();
}
