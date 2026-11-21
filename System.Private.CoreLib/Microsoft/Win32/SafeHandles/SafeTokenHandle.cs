using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000061 RID: 97
	internal sealed class SafeTokenHandle : SafeHandle
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00005B42 File Offset: 0x00003D42
		public SafeTokenHandle() : base(IntPtr.Zero, true)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00005B50 File Offset: 0x00003D50
		public override bool IsInvalid
		{
			get
			{
				return this.handle == new IntPtr(0) || this.handle == new IntPtr(-1);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00005B35 File Offset: 0x00003D35
		protected override bool ReleaseHandle()
		{
			return Interop.Kernel32.CloseHandle(this.handle);
		}
	}
}
