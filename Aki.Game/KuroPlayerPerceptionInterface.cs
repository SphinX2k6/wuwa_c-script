using System;
using System.Runtime.InteropServices;

// Token: 0x02003285 RID: 12933
public static class KuroPlayerPerceptionInterface
{
	// Token: 0x0601BFD0 RID: 114640 RVA: 0x007C7244 File Offset: 0x007C5444
	public static void OnEnter(IntPtr gcHandlePtr)
	{
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			playerPerceptionEvent.ExecuteOnEnter();
		}
	}

	// Token: 0x0601BFD1 RID: 114641 RVA: 0x007C7270 File Offset: 0x007C5470
	public static void OnLeave(IntPtr gcHandlePtr)
	{
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			playerPerceptionEvent.ExecuteOnLeave();
		}
	}

	// Token: 0x0601BFD2 RID: 114642 RVA: 0x007C729C File Offset: 0x007C549C
	public unsafe static void EnterCondition(IntPtr gcHandlePtr, void** resultPtr)
	{
		bool* ptr = *(IntPtr*)resultPtr;
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			*ptr = playerPerceptionEvent.ExecuteEnterCondition();
		}
	}

	// Token: 0x0601BFD3 RID: 114643 RVA: 0x007C72CC File Offset: 0x007C54CC
	public static void OnDestroy(IntPtr gcHandlePtr)
	{
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			playerPerceptionEvent.ExecuteOnDestroy();
		}
	}
}
