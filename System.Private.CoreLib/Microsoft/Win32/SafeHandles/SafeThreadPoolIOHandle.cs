using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000064 RID: 100
	internal sealed class SafeThreadPoolIOHandle : SafeHandle
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00005B42 File Offset: 0x00003D42
		public SafeThreadPoolIOHandle() : base(IntPtr.Zero, true)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00005BAD File Offset: 0x00003DAD
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00005BBC File Offset: 0x00003DBC
		protected override bool ReleaseHandle()
		{
			Interop.Kernel32.CloseThreadpoolIo(this.handle);
			return true;
		}
	}
}
