using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005A RID: 90
	public abstract class CriticalHandleZeroOrMinusOneIsInvalid : CriticalHandle
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x000051DD File Offset: 0x000033DD
		protected CriticalHandleZeroOrMinusOneIsInvalid() : base(IntPtr.Zero)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000051EA File Offset: 0x000033EA
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero || this.handle == new IntPtr(-1);
			}
		}
	}
}
