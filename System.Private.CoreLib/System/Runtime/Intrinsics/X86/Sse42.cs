using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000598 RID: 1432
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Sse42 : Sse41
	{
		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x0010AA50 File Offset: 0x00108C50
		public new static bool IsSupported
		{
			get
			{
				return Sse42.IsSupported;
			}
		}

		// Token: 0x06006E64 RID: 28260 RVA: 0x0010AA57 File Offset: 0x00108C57
		public static Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right)
		{
			return Sse42.CompareGreaterThan(left, right);
		}

		// Token: 0x06006E65 RID: 28261 RVA: 0x0010AA60 File Offset: 0x00108C60
		public static uint Crc32(uint crc, byte data)
		{
			return Sse42.Crc32(crc, data);
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x0010AA69 File Offset: 0x00108C69
		public static uint Crc32(uint crc, ushort data)
		{
			return Sse42.Crc32(crc, data);
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x0010AA72 File Offset: 0x00108C72
		public static uint Crc32(uint crc, uint data)
		{
			return Sse42.Crc32(crc, data);
		}

		// Token: 0x02000599 RID: 1433
		[Intrinsic]
		public new abstract class X64 : Sse41.X64
		{
			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x06006E68 RID: 28264 RVA: 0x0010AA7B File Offset: 0x00108C7B
			public new static bool IsSupported
			{
				get
				{
					return Sse42.X64.IsSupported;
				}
			}

			// Token: 0x06006E69 RID: 28265 RVA: 0x0010AA82 File Offset: 0x00108C82
			public static ulong Crc32(ulong crc, ulong data)
			{
				return Sse42.X64.Crc32(crc, data);
			}
		}
	}
}
