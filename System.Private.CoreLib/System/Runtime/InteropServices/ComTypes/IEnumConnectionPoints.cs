using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000630 RID: 1584
	[NullableContext(1)]
	[Guid("B196B285-BAB4-101A-B69C-00AA00341D07")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumConnectionPoints
	{
		// Token: 0x06007258 RID: 29272
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] IConnectionPoint[] rgelt, IntPtr pceltFetched);

		// Token: 0x06007259 RID: 29273
		[PreserveSig]
		int Skip(int celt);

		// Token: 0x0600725A RID: 29274
		void Reset();

		// Token: 0x0600725B RID: 29275
		void Clone(out IEnumConnectionPoints ppenum);
	}
}
