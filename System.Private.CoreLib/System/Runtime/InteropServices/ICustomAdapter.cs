using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005D3 RID: 1491
	[NullableContext(1)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface ICustomAdapter
	{
		// Token: 0x0600702E RID: 28718
		[return: MarshalAs(UnmanagedType.IUnknown)]
		object GetUnderlyingObject();
	}
}
