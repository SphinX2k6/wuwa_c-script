using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000003 RID: 3
	internal static class HexConverter
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int FromChar(int c)
		{
			if (c < HexConverter.CharToHexLookup.Length)
			{
				return (int)(*HexConverter.CharToHexLookup[c]);
			}
			return 255;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002084 File Offset: 0x00000284
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsHexChar(int c)
		{
			if (IntPtr.Size == 8)
			{
				ulong num = (ulong)(c - 48);
				ulong num2 = 18428868213665201664UL << (int)num;
				ulong num3 = num - 64UL;
				return (num2 & num3) < 0UL;
			}
			return HexConverter.FromChar(c) != 255;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020CB File Offset: 0x000002CB
		public unsafe static ReadOnlySpan<byte> CharToHexLookup
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.21244F82B210125632917591768F6BF22EB6861F80C6C25A25BD26DFB580EA7B), 256);
			}
		}
	}
}
