using System;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020000AE RID: 174
public static class KuroGameBudgetAllocatorInterface
{
	// Token: 0x06000540 RID: 1344 RVA: 0x0001C100 File Offset: 0x0001A300
	public static void OnObjectUpdate(IntPtr gcHandlePtr, float deltaSeconds, int deltaFrames, float distance)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.ScheduledTick(deltaSeconds, deltaFrames, distance);
		}
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0001C130 File Offset: 0x0001A330
	public static void OnObjectLateUpdate(IntPtr gcHandlePtr, float deltaSeconds, int deltaFrames, float distance)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.ScheduledAfterTick(deltaSeconds, deltaFrames, distance);
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0001C160 File Offset: 0x0001A360
	public static void OnObjectEnabledChange(IntPtr gcHandlePtr, bool enable, float distance)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.OnEnabledChange(enable, distance);
		}
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0001C18C File Offset: 0x0001A38C
	public static void OnObjectWasRecentlyRenderedChange(IntPtr gcHandlePtr, bool wasRecentlyRendered)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.OnWasRecentlyRenderedOnScreenChange(wasRecentlyRendered);
		}
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
	public unsafe static void ObjectLocationProxyFunction(IntPtr gcHandlePtr, void* inLocationPtr)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			FVectorDouble? fvectorDouble = gameBudgetManagedObject.LocationProxyFunction();
			if (fvectorDouble != null)
			{
				((FVectorDouble*)inLocationPtr)->X = fvectorDouble.Value.X;
				((FVectorDouble*)inLocationPtr)->Y = fvectorDouble.Value.Y;
				((FVectorDouble*)inLocationPtr)->Z = fvectorDouble.Value.Z;
			}
		}
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0001C224 File Offset: 0x0001A424
	public unsafe static void OnceTaskIsEmptyFunction(void* inGroupIdPtr, void** inResultPtr)
	{
		IGameBudgetOnceTaskGroup onceTaskGroupById = GameBudgetInterfaceController.Instance.GetOnceTaskGroupById(*(FName*)inGroupIdPtr);
		if (onceTaskGroupById != null)
		{
			*(*(IntPtr*)inResultPtr) = (onceTaskGroupById.IsEmpty() ? 1 : 0);
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0001C254 File Offset: 0x0001A454
	public unsafe static void OnceTaskConsumeFunction(void* inGroupIdPtr)
	{
		IGameBudgetOnceTaskGroup onceTaskGroupById = GameBudgetInterfaceController.Instance.GetOnceTaskGroupById(*(FName*)inGroupIdPtr);
		if (onceTaskGroupById != null)
		{
			onceTaskGroupById.Consume();
		}
	}
}
