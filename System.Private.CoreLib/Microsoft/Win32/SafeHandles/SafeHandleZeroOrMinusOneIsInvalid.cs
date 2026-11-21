using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005C RID: 92
	public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00005228 File Offset: 0x00003428
		protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle) : base(IntPtr.Zero, ownsHandle)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00005236 File Offset: 0x00003436
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero || this.handle == new IntPtr(-1);
			}
		}
	}
}
