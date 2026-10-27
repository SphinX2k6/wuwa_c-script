using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011A RID: 282
	[NullableContext(1)]
	[Nullable(0)]
	public static class FCrashSightProxy
	{
		// Token: 0x06000A1E RID: 2590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void TestCriticalError_Internal();

		// Token: 0x06000A1F RID: 2591 RVA: 0x0003398D File Offset: 0x00031B8D
		public static void TestCriticalError()
		{
			FCrashSightProxy.TestCriticalError_Internal();
		}

		// Token: 0x06000A20 RID: 2592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Test_Internal();

		// Token: 0x06000A21 RID: 2593 RVA: 0x00033994 File Offset: 0x00031B94
		public static void Test()
		{
			FCrashSightProxy.Test_Internal();
		}

		// Token: 0x06000A22 RID: 2594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetUserId_Internal(string userId);

		// Token: 0x06000A23 RID: 2595 RVA: 0x0003399B File Offset: 0x00031B9B
		public static void SetUserId(string userId)
		{
			FCrashSightProxy.SetUserId_Internal(userId);
		}

		// Token: 0x06000A24 RID: 2596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCustomDataCache_Internal(string key, string value);

		// Token: 0x06000A25 RID: 2597 RVA: 0x000339A3 File Offset: 0x00031BA3
		public static void SetCustomDataCache(string key, string value)
		{
			FCrashSightProxy.SetCustomDataCache_Internal(key, value);
		}

		// Token: 0x06000A26 RID: 2598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCustomDataByFName_Internal(in FName key, string value);

		// Token: 0x06000A27 RID: 2599 RVA: 0x000339AC File Offset: 0x00031BAC
		public static void SetCustomDataByFName(in FName key, string value)
		{
			FCrashSightProxy.SetCustomDataByFName_Internal(key, value);
		}

		// Token: 0x06000A28 RID: 2600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCustomData_Internal(string key, string value);

		// Token: 0x06000A29 RID: 2601 RVA: 0x000339B5 File Offset: 0x00031BB5
		public static void SetCustomData(string key, string value)
		{
			FCrashSightProxy.SetCustomData_Internal(key, value);
		}

		// Token: 0x06000A2A RID: 2602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetBranchInfo_Internal(string stream, string changelist);

		// Token: 0x06000A2B RID: 2603 RVA: 0x000339BE File Offset: 0x00031BBE
		public static void SetBranchInfo(string stream, string changelist)
		{
			FCrashSightProxy.SetBranchInfo_Internal(stream, changelist);
		}

		// Token: 0x06000A2C RID: 2604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ReportException_Internal(int type, string name, string message, string stack, string extras, bool async, bool quit, int dumpNativeType);

		// Token: 0x06000A2D RID: 2605 RVA: 0x000339C7 File Offset: 0x00031BC7
		public static void ReportException(int type, string name, string message, string stack, string extras, bool async, bool quit, int dumpNativeType)
		{
			FCrashSightProxy.ReportException_Internal(type, name, message, stack, extras, async, quit, dumpNativeType);
		}

		// Token: 0x06000A2E RID: 2606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetSdkDeviceId_Internal();

		// Token: 0x06000A2F RID: 2607 RVA: 0x000339DA File Offset: 0x00031BDA
		public static string GetSdkDeviceId()
		{
			return FCrashSightProxy.GetSdkDeviceId_Internal();
		}
	}
}
