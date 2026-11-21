using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200065B RID: 1627
	[NullableContext(1)]
	[Guid("00020411-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface ITypeLib2 : ITypeLib
	{
		// Token: 0x060072D9 RID: 29401
		[PreserveSig]
		int GetTypeInfoCount();

		// Token: 0x060072DA RID: 29402
		void GetTypeInfo(int index, out ITypeInfo ppTI);

		// Token: 0x060072DB RID: 29403
		void GetTypeInfoType(int index, out TYPEKIND pTKind);

		// Token: 0x060072DC RID: 29404
		void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);

		// Token: 0x060072DD RID: 29405
		void GetLibAttr(out IntPtr ppTLibAttr);

		// Token: 0x060072DE RID: 29406
		void GetTypeComp(out ITypeComp ppTComp);

		// Token: 0x060072DF RID: 29407
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		// Token: 0x060072E0 RID: 29408
		[return: MarshalAs(UnmanagedType.Bool)]
		bool IsName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal);

		// Token: 0x060072E1 RID: 29409
		void FindName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal, [MarshalAs(UnmanagedType.LPArray)] [Out] ITypeInfo[] ppTInfo, [MarshalAs(UnmanagedType.LPArray)] [Out] int[] rgMemId, ref short pcFound);

		// Token: 0x060072E2 RID: 29410
		[PreserveSig]
		void ReleaseTLibAttr(IntPtr pTLibAttr);

		// Token: 0x060072E3 RID: 29411
		void GetCustData(ref Guid guid, out object pVarVal);

		// Token: 0x060072E4 RID: 29412
		void GetLibStatistics(IntPtr pcUniqueNames, out int pcchUniqueNames);

		// Token: 0x060072E5 RID: 29413
		[LCIDConversion(1)]
		void GetDocumentation2(int index, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);

		// Token: 0x060072E6 RID: 29414
		void GetAllCustData(IntPtr pCustData);
	}
}
