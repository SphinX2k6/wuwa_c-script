using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200059C RID: 1436
	[CLSCompliant(false)]
	public abstract class X86Serialize : X86Base
	{
		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06006E84 RID: 28292 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Serialize()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200059D RID: 1437
		[Intrinsic]
		public new abstract class X64 : X86Base.X64
		{
			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x06006E86 RID: 28294 RVA: 0x00007B65 File Offset: 0x00005D65
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
