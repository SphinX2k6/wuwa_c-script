using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000632 RID: 1586
	[NullableContext(1)]
	[Guid("B196B287-BAB4-101A-B69C-00AA00341D07")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumConnections
	{
		// Token: 0x0600725C RID: 29276
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] CONNECTDATA[] rgelt, IntPtr pceltFetched);

		// Token: 0x0600725D RID: 29277
		[PreserveSig]
		int Skip(int celt);

		// Token: 0x0600725E RID: 29278
		void Reset();

		// Token: 0x0600725F RID: 29279
		void Clone(out IEnumConnections ppenum);
	}
}
