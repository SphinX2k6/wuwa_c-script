using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000124 RID: 292
	[NullableContext(1)]
	[Nullable(0)]
	public class FuncOpenLibrary
	{
		// Token: 0x06000AE8 RID: 2792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFirstTimestamp_Internal(uint timestamp);

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00034A0B File Offset: 0x00032C0B
		public static void SetFirstTimestamp(long timestamp)
		{
			FuncOpenLibrary.SetFirstTimestamp_Internal((uint)timestamp);
		}

		// Token: 0x06000AEA RID: 2794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void TryOpen_Internal(ref FArrayBuffer view);

		// Token: 0x06000AEB RID: 2795 RVA: 0x00034A14 File Offset: 0x00032C14
		public static void TryOpen(ref FArrayBuffer view)
		{
			FuncOpenLibrary.TryOpen_Internal(ref view);
		}

		// Token: 0x06000AEC RID: 2796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FArrayBuffer GetEBuffer_Internal();

		// Token: 0x06000AED RID: 2797 RVA: 0x00034A1C File Offset: 0x00032C1C
		public static FArrayBuffer GetEBuffer()
		{
			return FuncOpenLibrary.GetEBuffer_Internal();
		}

		// Token: 0x06000AEE RID: 2798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void FreeArrayBuffer_Internal(ref FArrayBuffer view);

		// Token: 0x06000AEF RID: 2799 RVA: 0x00034A23 File Offset: 0x00032C23
		public static void FreeArrayBuffer(ref FArrayBuffer view)
		{
			FuncOpenLibrary.FreeArrayBuffer_Internal(ref view);
		}

		// Token: 0x06000AF0 RID: 2800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetIsCheckEncrypt_Internal(string str);

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00034A2B File Offset: 0x00032C2B
		public static void SetIsCheckEncrypt(string str)
		{
			FuncOpenLibrary.SetIsCheckEncrypt_Internal(str);
		}
	}
}
