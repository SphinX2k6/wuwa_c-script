using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011B RID: 283
	[NullableContext(1)]
	[Nullable(0)]
	public static class FCrashSightProxy
	{
		// Token: 0x06000A75 RID: 2677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void TestCriticalError_Internal();

		// Token: 0x06000A76 RID: 2678 RVA: 0x00034401 File Offset: 0x00032601
		public static void TestCriticalError()
		{
			FCrashSightProxy.TestCriticalError_Internal();
		}

		// Token: 0x06000A77 RID: 2679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Test_Internal();

		// Token: 0x06000A78 RID: 2680 RVA: 0x00034408 File Offset: 0x00032608
		public static void Test()
		{
			FCrashSightProxy.Test_Internal();
		}

		// Token: 0x06000A79 RID: 2681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetUserId_Internal(string userId);

		// Token: 0x06000A7A RID: 2682 RVA: 0x0003440F File Offset: 0x0003260F
		public static void SetUserId(string userId)
		{
			FCrashSightProxy.SetUserId_Internal(userId);
		}

		// Token: 0x06000A7B RID: 2683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCustomDataCache_Internal(string key, string value);

		// Token: 0x06000A7C RID: 2684 RVA: 0x00034417 File Offset: 0x00032617
		public static void SetCustomDataCache(string key, string value)
		{
			FCrashSightProxy.SetCustomDataCache_Internal(key, value);
		}

		// Token: 0x06000A7D RID: 2685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCustomDataByFName_Internal(in FName key, string value);

		// Token: 0x06000A7E RID: 2686 RVA: 0x00034420 File Offset: 0x00032620
		public static void SetCustomDataByFName(in FName key, string value)
		{
			FCrashSightProxy.SetCustomDataByFName_Internal(key, value);
		}

		// Token: 0x06000A7F RID: 2687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCustomData_Internal(string key, string value);

		// Token: 0x06000A80 RID: 2688 RVA: 0x00034429 File Offset: 0x00032629
		public static void SetCustomData(string key, string value)
		{
			FCrashSightProxy.SetCustomData_Internal(key, value);
		}

		// Token: 0x06000A81 RID: 2689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetBranchInfo_Internal(string stream, string changelist);

		// Token: 0x06000A82 RID: 2690 RVA: 0x00034432 File Offset: 0x00032632
		public static void SetBranchInfo(string stream, string changelist)
		{
			FCrashSightProxy.SetBranchInfo_Internal(stream, changelist);
		}

		// Token: 0x06000A83 RID: 2691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ReportException_Internal(int type, string name, string message, string stack, string extras, bool async, bool quit, int dumpNativeType);

		// Token: 0x06000A84 RID: 2692 RVA: 0x0003443B File Offset: 0x0003263B
		public static void ReportException(int type, string name, string message, string stack, string extras, bool async, bool quit, int dumpNativeType)
		{
			FCrashSightProxy.ReportException_Internal(type, name, message, stack, extras, async, quit, dumpNativeType);
		}

		// Token: 0x06000A85 RID: 2693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetSdkDeviceId_Internal();

		// Token: 0x06000A86 RID: 2694 RVA: 0x0003444E File Offset: 0x0003264E
		public static string GetSdkDeviceId()
		{
			return FCrashSightProxy.GetSdkDeviceId_Internal();
		}
	}
}
