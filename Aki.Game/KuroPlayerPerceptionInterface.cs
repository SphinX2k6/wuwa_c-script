using System;
using System.Runtime.InteropServices;

// Token: 0x020027F6 RID: 10230
public static class KuroPlayerPerceptionInterface
{
	// Token: 0x06019BD4 RID: 105428 RVA: 0x007EE5D4 File Offset: 0x007EC7D4
	public static void OnEnter(IntPtr gcHandlePtr)
	{
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			playerPerceptionEvent.ExecuteOnEnter();
		}
	}

	// Token: 0x06019BD5 RID: 105429 RVA: 0x007EE600 File Offset: 0x007EC800
	public static void OnLeave(IntPtr gcHandlePtr)
	{
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			playerPerceptionEvent.ExecuteOnLeave();
		}
	}

	// Token: 0x06019BD6 RID: 105430 RVA: 0x007EE62C File Offset: 0x007EC82C
	public unsafe static void EnterCondition(IntPtr gcHandlePtr, void** resultPtr)
	{
		bool* ptr = *(IntPtr*)resultPtr;
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			*ptr = playerPerceptionEvent.ExecuteEnterCondition();
		}
	}

	// Token: 0x06019BD7 RID: 105431 RVA: 0x007EE65C File Offset: 0x007EC85C
	public static void OnDestroy(IntPtr gcHandlePtr)
	{
		PlayerPerceptionEvent playerPerceptionEvent = GCHandle.FromIntPtr(gcHandlePtr).Target as PlayerPerceptionEvent;
		if (playerPerceptionEvent != null)
		{
			playerPerceptionEvent.ExecuteOnDestroy();
		}
	}
}
