using System;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000063 RID: 99
	internal sealed class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00005B1C File Offset: 0x00003D1C
		public SafeFindHandle() : base(true)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00005BA0 File Offset: 0x00003DA0
		protected override bool ReleaseHandle()
		{
			return Interop.Kernel32.FindClose(this.handle);
		}
	}
}
