using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200065C RID: 1628
	internal static class JitHelpers
	{
		// Token: 0x060072E7 RID: 29415 RVA: 0x00112198 File Offset: 0x00110398
		[Intrinsic]
		public static bool EnumEquals<T>(T x, T y) where T : struct, Enum
		{
			return x.Equals(y);
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x001121AD File Offset: 0x001103AD
		[Intrinsic]
		public static int EnumCompareTo<T>(T x, T y) where T : struct, Enum
		{
			return x.CompareTo(y);
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x0000FD41 File Offset: 0x0000DF41
		[Intrinsic]
		internal static void DisableInline()
		{
			throw new NotImplementedException();
		}
	}
}
