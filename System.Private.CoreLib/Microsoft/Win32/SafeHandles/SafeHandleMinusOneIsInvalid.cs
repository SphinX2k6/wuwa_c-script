using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005B RID: 91
	public abstract class SafeHandleMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00005209 File Offset: 0x00003409
		protected SafeHandleMinusOneIsInvalid(bool ownsHandle) : base(new IntPtr(-1), ownsHandle)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00005218 File Offset: 0x00003418
		public override bool IsInvalid
		{
			get
			{
				return this.handle == new IntPtr(-1);
			}
		}
	}
}
