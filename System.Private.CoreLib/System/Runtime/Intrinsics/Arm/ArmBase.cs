using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000557 RID: 1367
	[CLSCompliant(false)]
	public abstract class ArmBase
	{
		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06005CBA RID: 23738 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int LeadingZeroCount(int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int LeadingZeroCount(uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ReverseElementBits(int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ReverseElementBits(uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Yield()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000558 RID: 1368
		public abstract class Arm64
		{
			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x06005CC0 RID: 23744 RVA: 0x00007B65 File Offset: 0x00005D65
			public static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06005CC1 RID: 23745 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static int LeadingSignCount(int value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CC2 RID: 23746 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static int LeadingSignCount(long value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CC3 RID: 23747 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static int LeadingZeroCount(long value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CC4 RID: 23748 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static int LeadingZeroCount(ulong value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CC5 RID: 23749 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static long MultiplyHigh(long left, long right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CC6 RID: 23750 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong MultiplyHigh(ulong left, ulong right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CC7 RID: 23751 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static long ReverseElementBits(long value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CC8 RID: 23752 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ReverseElementBits(ulong value)
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
