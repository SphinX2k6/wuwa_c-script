using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200058A RID: 1418
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Lzcnt : X86Base
	{
		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06006C20 RID: 27680 RVA: 0x0010968F File Offset: 0x0010788F
		public new static bool IsSupported
		{
			get
			{
				return Lzcnt.IsSupported;
			}
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x00109696 File Offset: 0x00107896
		public static uint LeadingZeroCount(uint value)
		{
			return Lzcnt.LeadingZeroCount(value);
		}

		// Token: 0x0200058B RID: 1419
		[Intrinsic]
		public new abstract class X64 : X86Base.X64
		{
			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x06006C22 RID: 27682 RVA: 0x0010969E File Offset: 0x0010789E
			public new static bool IsSupported
			{
				get
				{
					return Lzcnt.X64.IsSupported;
				}
			}

			// Token: 0x06006C23 RID: 27683 RVA: 0x001096A5 File Offset: 0x001078A5
			public static ulong LeadingZeroCount(ulong value)
			{
				return Lzcnt.X64.LeadingZeroCount(value);
			}
		}
	}
}
