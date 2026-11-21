using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200062F RID: 1583
	[NullableContext(1)]
	[Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IConnectionPointContainer
	{
		// Token: 0x06007256 RID: 29270
		void EnumConnectionPoints(out IEnumConnectionPoints ppEnum);

		// Token: 0x06007257 RID: 29271
		[NullableContext(2)]
		void FindConnectionPoint([In] ref Guid riid, out IConnectionPoint ppCP);
	}
}
