using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000123 RID: 291
	[NullableContext(1)]
	[Nullable(0)]
	public static class FTpSafeProxy
	{
		// Token: 0x06000ADE RID: 2782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetUserInfo_Internal(int accountType, int worldId, string openId, int playerId);

		// Token: 0x06000ADF RID: 2783 RVA: 0x000349E3 File Offset: 0x00032BE3
		public static void SetUserInfo(int accountType, int worldId, string openId, int playerId)
		{
			FTpSafeProxy.SetUserInfo_Internal(accountType, worldId, openId, playerId);
		}

		// Token: 0x06000AE0 RID: 2784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer GetAntiData_Internal();

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000349EE File Offset: 0x00032BEE
		public static FArrayBuffer GetAntiData()
		{
			return FTpSafeProxy.GetAntiData_Internal();
		}

		// Token: 0x06000AE2 RID: 2786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer GetAntiData2_Internal();

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000349F5 File Offset: 0x00032BF5
		public static FArrayBuffer GetAntiData2()
		{
			return FTpSafeProxy.GetAntiData2_Internal();
		}

		// Token: 0x06000AE4 RID: 2788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RecvAntiData_Internal(in FArrayBuffer buffer);

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000349FC File Offset: 0x00032BFC
		public static void RecvAntiData(in FArrayBuffer buffer)
		{
			FTpSafeProxy.RecvAntiData_Internal(buffer);
		}

		// Token: 0x06000AE6 RID: 2790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Logout_Internal();

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00034A04 File Offset: 0x00032C04
		public static void Logout()
		{
			FTpSafeProxy.Logout_Internal();
		}
	}
}
