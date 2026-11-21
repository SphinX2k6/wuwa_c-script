using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000059 RID: 89
	public abstract class CriticalHandleMinusOneIsInvalid : CriticalHandle
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x000051BF File Offset: 0x000033BF
		protected CriticalHandleMinusOneIsInvalid() : base(new IntPtr(-1))
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000051CD File Offset: 0x000033CD
		public override bool IsInvalid
		{
			get
			{
				return this.handle == new IntPtr(-1);
			}
		}
	}
}
