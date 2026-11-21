using System;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020000B0 RID: 176
public static class KuroGameBudgetAllocatorInterface
{
	// Token: 0x06000581 RID: 1409 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
	public static void OnObjectUpdate(IntPtr gcHandlePtr, float deltaSeconds, int deltaFrames, float distance)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.ScheduledTick(deltaSeconds, deltaFrames, distance);
		}
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x0001C818 File Offset: 0x0001AA18
	public static void OnObjectLateUpdate(IntPtr gcHandlePtr, float deltaSeconds, int deltaFrames, float distance)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.ScheduledAfterTick(deltaSeconds, deltaFrames, distance);
		}
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0001C848 File Offset: 0x0001AA48
	public static void OnObjectEnabledChange(IntPtr gcHandlePtr, bool enable, float distance)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.OnEnabledChange(enable, distance);
		}
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0001C874 File Offset: 0x0001AA74
	public static void OnObjectWasRecentlyRenderedChange(IntPtr gcHandlePtr, bool wasRecentlyRendered)
	{
		IGameBudgetManagedObject gameBudgetManagedObject = GCHandle.FromIntPtr(gcHandlePtr).Target as IGameBudgetManagedObject;
		if (gameBudgetManagedObject != null)
		{
			gameBudgetManagedObject.OnWasRecentlyRenderedOnScreenChange(wasRecentlyRendered);
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
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

	// Token: 0x06000586 RID: 1414 RVA: 0x0001C90C File Offset: 0x0001AB0C
	public unsafe static void OnceTaskIsEmptyFunction(void* inGroupIdPtr, void** inResultPtr)
	{
		IGameBudgetOnceTaskGroup onceTaskGroupById = GameBudgetInterfaceController.Instance.GetOnceTaskGroupById(*(FName*)inGroupIdPtr);
		if (onceTaskGroupById != null)
		{
			*(*(IntPtr*)inResultPtr) = (onceTaskGroupById.IsEmpty() ? 1 : 0);
		}
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0001C93C File Offset: 0x0001AB3C
	public unsafe static void OnceTaskConsumeFunction(void* inGroupIdPtr)
	{
		IGameBudgetOnceTaskGroup onceTaskGroupById = GameBudgetInterfaceController.Instance.GetOnceTaskGroupById(*(FName*)inGroupIdPtr);
		if (onceTaskGroupById != null)
		{
			onceTaskGroupById.Consume();
		}
	}
}
