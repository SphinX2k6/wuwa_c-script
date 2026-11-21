using System;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000060 RID: 96
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00005B1C File Offset: 0x00003D1C
		public SafeWaitHandle() : base(true)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00005B25 File Offset: 0x00003D25
		public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(existingHandle);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005B35 File Offset: 0x00003D35
		protected override bool ReleaseHandle()
		{
			return Interop.Kernel32.CloseHandle(this.handle);
		}
	}
}
