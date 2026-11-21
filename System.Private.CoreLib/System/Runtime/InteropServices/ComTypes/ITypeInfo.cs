using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000655 RID: 1621
	[NullableContext(1)]
	[Guid("00020401-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface ITypeInfo
	{
		// Token: 0x0600729A RID: 29338
		void GetTypeAttr(out IntPtr ppTypeAttr);

		// Token: 0x0600729B RID: 29339
		void GetTypeComp(out ITypeComp ppTComp);

		// Token: 0x0600729C RID: 29340
		void GetFuncDesc(int index, out IntPtr ppFuncDesc);

		// Token: 0x0600729D RID: 29341
		void GetVarDesc(int index, out IntPtr ppVarDesc);

		// Token: 0x0600729E RID: 29342
		void GetNames(int memid, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] [Out] string[] rgBstrNames, int cMaxNames, out int pcNames);

		// Token: 0x0600729F RID: 29343
		void GetRefTypeOfImplType(int index, out int href);

		// Token: 0x060072A0 RID: 29344
		void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);

		// Token: 0x060072A1 RID: 29345
		void GetIDsOfNames([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] [In] string[] rgszNames, int cNames, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] int[] pMemId);

		// Token: 0x060072A2 RID: 29346
		void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);

		// Token: 0x060072A3 RID: 29347
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		// Token: 0x060072A4 RID: 29348
		void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);

		// Token: 0x060072A5 RID: 29349
		void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);

		// Token: 0x060072A6 RID: 29350
		void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

		// Token: 0x060072A7 RID: 29351
		void CreateInstance([Nullable(2)] [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

		// Token: 0x060072A8 RID: 29352
		[NullableContext(2)]
		void GetMops(int memid, out string pBstrMops);

		// Token: 0x060072A9 RID: 29353
		void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);

		// Token: 0x060072AA RID: 29354
		[PreserveSig]
		void ReleaseTypeAttr(IntPtr pTypeAttr);

		// Token: 0x060072AB RID: 29355
		[PreserveSig]
		void ReleaseFuncDesc(IntPtr pFuncDesc);

		// Token: 0x060072AC RID: 29356
		[PreserveSig]
		void ReleaseVarDesc(IntPtr pVarDesc);
	}
}
