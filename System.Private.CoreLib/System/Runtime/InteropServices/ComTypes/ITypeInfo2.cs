using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000656 RID: 1622
	[NullableContext(1)]
	[Guid("00020412-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface ITypeInfo2 : ITypeInfo
	{
		// Token: 0x060072AD RID: 29357
		void GetTypeAttr(out IntPtr ppTypeAttr);

		// Token: 0x060072AE RID: 29358
		void GetTypeComp(out ITypeComp ppTComp);

		// Token: 0x060072AF RID: 29359
		void GetFuncDesc(int index, out IntPtr ppFuncDesc);

		// Token: 0x060072B0 RID: 29360
		void GetVarDesc(int index, out IntPtr ppVarDesc);

		// Token: 0x060072B1 RID: 29361
		void GetNames(int memid, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] [Out] string[] rgBstrNames, int cMaxNames, out int pcNames);

		// Token: 0x060072B2 RID: 29362
		void GetRefTypeOfImplType(int index, out int href);

		// Token: 0x060072B3 RID: 29363
		void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);

		// Token: 0x060072B4 RID: 29364
		void GetIDsOfNames([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] [In] string[] rgszNames, int cNames, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] int[] pMemId);

		// Token: 0x060072B5 RID: 29365
		void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);

		// Token: 0x060072B6 RID: 29366
		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		// Token: 0x060072B7 RID: 29367
		void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);

		// Token: 0x060072B8 RID: 29368
		void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);

		// Token: 0x060072B9 RID: 29369
		void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

		// Token: 0x060072BA RID: 29370
		void CreateInstance([Nullable(2)] [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

		// Token: 0x060072BB RID: 29371
		[NullableContext(2)]
		void GetMops(int memid, out string pBstrMops);

		// Token: 0x060072BC RID: 29372
		void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);

		// Token: 0x060072BD RID: 29373
		[PreserveSig]
		void ReleaseTypeAttr(IntPtr pTypeAttr);

		// Token: 0x060072BE RID: 29374
		[PreserveSig]
		void ReleaseFuncDesc(IntPtr pFuncDesc);

		// Token: 0x060072BF RID: 29375
		[PreserveSig]
		void ReleaseVarDesc(IntPtr pVarDesc);

		// Token: 0x060072C0 RID: 29376
		void GetTypeKind(out TYPEKIND pTypeKind);

		// Token: 0x060072C1 RID: 29377
		void GetTypeFlags(out int pTypeFlags);

		// Token: 0x060072C2 RID: 29378
		void GetFuncIndexOfMemId(int memid, INVOKEKIND invKind, out int pFuncIndex);

		// Token: 0x060072C3 RID: 29379
		void GetVarIndexOfMemId(int memid, out int pVarIndex);

		// Token: 0x060072C4 RID: 29380
		void GetCustData(ref Guid guid, out object pVarVal);

		// Token: 0x060072C5 RID: 29381
		void GetFuncCustData(int index, ref Guid guid, out object pVarVal);

		// Token: 0x060072C6 RID: 29382
		void GetParamCustData(int indexFunc, int indexParam, ref Guid guid, out object pVarVal);

		// Token: 0x060072C7 RID: 29383
		void GetVarCustData(int index, ref Guid guid, out object pVarVal);

		// Token: 0x060072C8 RID: 29384
		void GetImplTypeCustData(int index, ref Guid guid, out object pVarVal);

		// Token: 0x060072C9 RID: 29385
		[LCIDConversion(1)]
		void GetDocumentation2(int memid, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);

		// Token: 0x060072CA RID: 29386
		void GetAllCustData(IntPtr pCustData);

		// Token: 0x060072CB RID: 29387
		void GetAllFuncCustData(int index, IntPtr pCustData);

		// Token: 0x060072CC RID: 29388
		void GetAllParamCustData(int indexFunc, int indexParam, IntPtr pCustData);

		// Token: 0x060072CD RID: 29389
		void GetAllVarCustData(int index, IntPtr pCustData);

		// Token: 0x060072CE RID: 29390
		void GetAllImplTypeCustData(int index, IntPtr pCustData);
	}
}
