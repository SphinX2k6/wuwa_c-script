using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000062 RID: 98
	internal sealed class SafeThreadHandle : SafeHandle
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00005B70 File Offset: 0x00003D70
		public SafeThreadHandle() : base((IntPtr)0, true)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00005B7C File Offset: 0x00003D7C
		public override bool IsInvalid
		{
			get
			{
				long num = (long)this.handle;
				return num - -1L <= 1L;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00005B35 File Offset: 0x00003D35
		protected override bool ReleaseHandle()
		{
			return Interop.Kernel32.CloseHandle(this.handle);
		}
	}
}
