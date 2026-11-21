using System;
using Microsoft.Win32.SafeHandles;

namespace Internal.Win32.SafeHandles
{
	// Token: 0x0200006B RID: 107
	internal sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00005B1C File Offset: 0x00003D1C
		public SafeRegistryHandle() : base(true)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00005B25 File Offset: 0x00003D25
		public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(preexistingHandle);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000062F2 File Offset: 0x000044F2
		protected override bool ReleaseHandle()
		{
			return Interop.Advapi32.RegCloseKey(this.handle) == 0;
		}
	}
}
