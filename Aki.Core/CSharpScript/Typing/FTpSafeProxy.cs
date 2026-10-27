using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000122 RID: 290
	[NullableContext(1)]
	[Nullable(0)]
	public static class FTpSafeProxy
	{
		// Token: 0x06000A87 RID: 2695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetUserInfo_Internal(int accountType, int worldId, string openId, int playerId);

		// Token: 0x06000A88 RID: 2696 RVA: 0x00033F6F File Offset: 0x0003216F
		public static void SetUserInfo(int accountType, int worldId, string openId, int playerId)
		{
			FTpSafeProxy.SetUserInfo_Internal(accountType, worldId, openId, playerId);
		}

		// Token: 0x06000A89 RID: 2697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer GetAntiData_Internal();

		// Token: 0x06000A8A RID: 2698 RVA: 0x00033F7A File Offset: 0x0003217A
		public static FArrayBuffer GetAntiData()
		{
			return FTpSafeProxy.GetAntiData_Internal();
		}

		// Token: 0x06000A8B RID: 2699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer GetAntiData2_Internal();

		// Token: 0x06000A8C RID: 2700 RVA: 0x00033F81 File Offset: 0x00032181
		public static FArrayBuffer GetAntiData2()
		{
			return FTpSafeProxy.GetAntiData2_Internal();
		}

		// Token: 0x06000A8D RID: 2701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RecvAntiData_Internal(in FArrayBuffer buffer);

		// Token: 0x06000A8E RID: 2702 RVA: 0x00033F88 File Offset: 0x00032188
		public static void RecvAntiData(in FArrayBuffer buffer)
		{
			FTpSafeProxy.RecvAntiData_Internal(buffer);
		}

		// Token: 0x06000A8F RID: 2703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Logout_Internal();

		// Token: 0x06000A90 RID: 2704 RVA: 0x00033F90 File Offset: 0x00032190
		public static void Logout()
		{
			FTpSafeProxy.Logout_Internal();
		}
	}
}
