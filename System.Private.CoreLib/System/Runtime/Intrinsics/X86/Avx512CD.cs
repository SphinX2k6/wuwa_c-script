using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000576 RID: 1398
	[CLSCompliant(false)]
	public abstract class Avx512CD : Avx512F
	{
		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06006841 RID: 26689 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> DetectConflicts(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> DetectConflicts(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> DetectConflicts(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> DetectConflicts(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> LeadingZeroCount(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> LeadingZeroCount(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> LeadingZeroCount(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> LeadingZeroCount(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000577 RID: 1399
		public new abstract class VL : Avx512F.VL
		{
			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x0600684A RID: 26698 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x0600684B RID: 26699 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> DetectConflicts(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600684C RID: 26700 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> DetectConflicts(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600684D RID: 26701 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> DetectConflicts(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600684E RID: 26702 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> DetectConflicts(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600684F RID: 26703 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> DetectConflicts(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006850 RID: 26704 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> DetectConflicts(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006851 RID: 26705 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> DetectConflicts(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006852 RID: 26706 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> DetectConflicts(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006853 RID: 26707 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> LeadingZeroCount(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006854 RID: 26708 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> LeadingZeroCount(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006855 RID: 26709 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> LeadingZeroCount(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006856 RID: 26710 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> LeadingZeroCount(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006857 RID: 26711 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> LeadingZeroCount(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006858 RID: 26712 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> LeadingZeroCount(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006859 RID: 26713 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> LeadingZeroCount(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600685A RID: 26714 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> LeadingZeroCount(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x02000578 RID: 1400
		public new abstract class X64 : Avx512F.X64
		{
			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x0600685B RID: 26715 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}
		}
	}
}
