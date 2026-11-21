using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005FF RID: 1535
	[Guid("00000003-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IMarshal
	{
		// Token: 0x060071AD RID: 29101
		[PreserveSig]
		int GetUnmarshalClass(ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out Guid pCid);

		// Token: 0x060071AE RID: 29102
		[PreserveSig]
		int GetMarshalSizeMax(ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out int pSize);

		// Token: 0x060071AF RID: 29103
		[PreserveSig]
		int MarshalInterface(IntPtr pStm, ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags);

		// Token: 0x060071B0 RID: 29104
		[PreserveSig]
		int UnmarshalInterface(IntPtr pStm, ref Guid riid, out IntPtr ppv);

		// Token: 0x060071B1 RID: 29105
		[PreserveSig]
		int ReleaseMarshalData(IntPtr pStm);

		// Token: 0x060071B2 RID: 29106
		[PreserveSig]
		int DisconnectObject(int dwReserved);
	}
}
