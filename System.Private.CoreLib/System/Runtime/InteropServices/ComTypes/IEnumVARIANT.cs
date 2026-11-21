using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000635 RID: 1589
	[NullableContext(1)]
	[Guid("00020404-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumVARIANT
	{
		// Token: 0x06007268 RID: 29288
		[PreserveSig]
		int Next(int celt, [Nullable(new byte[]
		{
			1,
			2
		})] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] object[] rgVar, IntPtr pceltFetched);

		// Token: 0x06007269 RID: 29289
		[PreserveSig]
		int Skip(int celt);

		// Token: 0x0600726A RID: 29290
		[PreserveSig]
		int Reset();

		// Token: 0x0600726B RID: 29291
		IEnumVARIANT Clone();
	}
}
