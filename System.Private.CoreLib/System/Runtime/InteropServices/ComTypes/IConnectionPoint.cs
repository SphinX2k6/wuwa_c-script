using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200062E RID: 1582
	[NullableContext(1)]
	[Guid("B196B286-BAB4-101A-B69C-00AA00341D07")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IConnectionPoint
	{
		// Token: 0x06007251 RID: 29265
		void GetConnectionInterface(out Guid pIID);

		// Token: 0x06007252 RID: 29266
		void GetConnectionPointContainer(out IConnectionPointContainer ppCPC);

		// Token: 0x06007253 RID: 29267
		void Advise([MarshalAs(UnmanagedType.Interface)] object pUnkSink, out int pdwCookie);

		// Token: 0x06007254 RID: 29268
		void Unadvise(int dwCookie);

		// Token: 0x06007255 RID: 29269
		void EnumConnections(out IEnumConnections ppEnum);
	}
}
