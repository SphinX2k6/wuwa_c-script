using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000123 RID: 291
	[NullableContext(1)]
	[Nullable(0)]
	public class FuncOpenLibrary
	{
		// Token: 0x06000A91 RID: 2705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFirstTimestamp_Internal(uint timestamp);

		// Token: 0x06000A92 RID: 2706 RVA: 0x00033F97 File Offset: 0x00032197
		public static void SetFirstTimestamp(long timestamp)
		{
			FuncOpenLibrary.SetFirstTimestamp_Internal((uint)timestamp);
		}

		// Token: 0x06000A93 RID: 2707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void TryOpen_Internal(ref FArrayBuffer view);

		// Token: 0x06000A94 RID: 2708 RVA: 0x00033FA0 File Offset: 0x000321A0
		public static void TryOpen(ref FArrayBuffer view)
		{
			FuncOpenLibrary.TryOpen_Internal(ref view);
		}

		// Token: 0x06000A95 RID: 2709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer GetEBuffer_Internal();

		// Token: 0x06000A96 RID: 2710 RVA: 0x00033FA8 File Offset: 0x000321A8
		public static FArrayBuffer GetEBuffer()
		{
			return FuncOpenLibrary.GetEBuffer_Internal();
		}

		// Token: 0x06000A97 RID: 2711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void FreeArrayBuffer_Internal(ref FArrayBuffer view);

		// Token: 0x06000A98 RID: 2712 RVA: 0x00033FAF File Offset: 0x000321AF
		public static void FreeArrayBuffer(ref FArrayBuffer view)
		{
			FuncOpenLibrary.FreeArrayBuffer_Internal(ref view);
		}

		// Token: 0x06000A99 RID: 2713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetIsCheckEncrypt_Internal(string str);

		// Token: 0x06000A9A RID: 2714 RVA: 0x00033FB7 File Offset: 0x000321B7
		public static void SetIsCheckEncrypt(string str)
		{
			FuncOpenLibrary.SetIsCheckEncrypt_Internal(str);
		}
	}
}
