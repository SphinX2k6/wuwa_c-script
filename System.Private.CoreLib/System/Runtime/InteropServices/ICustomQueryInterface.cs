using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005D6 RID: 1494
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface ICustomQueryInterface
	{
		// Token: 0x06007035 RID: 28725
		CustomQueryInterfaceResult GetInterface([In] ref Guid iid, out IntPtr ppv);
	}
}
