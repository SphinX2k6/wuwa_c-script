using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200065A RID: 1626
	[NullableContext(1)]
	[Guid("00020402-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface ITypeLib
	{
		// Token: 0x060072CF RID: 29391
		[PreserveSig]
		int GetTypeInfoCount();

		// Token: 0x060072D0 RID: 29392
		void GetTypeInfo(int index, out ITypeInfo ppTI);

		// Token: 0x060072D1 RID: 29393
		void GetTypeInfoType(int index, out TYPEKIND pTKind);

		// Token: 0x060072D2 RID: 29394
		void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);

		// Token: 0x060072D3 RID: 29395
		void GetLibAttr(out IntPtr ppTLibAttr);

		// Token: 0x060072D4 RID: 29396
		void GetTypeComp(out ITypeComp ppTComp);

		// Token: 0x060072D5 RID: 29397
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		// Token: 0x060072D6 RID: 29398
		[return: MarshalAs(UnmanagedType.Bool)]
		bool IsName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal);

		// Token: 0x060072D7 RID: 29399
		void FindName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal, [MarshalAs(UnmanagedType.LPArray)] [Out] ITypeInfo[] ppTInfo, [MarshalAs(UnmanagedType.LPArray)] [Out] int[] rgMemId, ref short pcFound);

		// Token: 0x060072D8 RID: 29400
		[PreserveSig]
		void ReleaseTLibAttr(IntPtr pTLibAttr);
	}
}
