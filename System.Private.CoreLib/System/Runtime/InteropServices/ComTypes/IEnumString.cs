using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000634 RID: 1588
	[NullableContext(1)]
	[Guid("00000101-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumString
	{
		// Token: 0x06007264 RID: 29284
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 0)] [Out] string[] rgelt, IntPtr pceltFetched);

		// Token: 0x06007265 RID: 29285
		[PreserveSig]
		int Skip(int celt);

		// Token: 0x06007266 RID: 29286
		void Reset();

		// Token: 0x06007267 RID: 29287
		void Clone(out IEnumString ppenum);
	}
}
