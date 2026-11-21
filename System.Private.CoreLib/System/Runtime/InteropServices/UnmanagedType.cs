using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005FA RID: 1530
	public enum UnmanagedType
	{
		// Token: 0x040012E1 RID: 4833
		Bool = 2,
		// Token: 0x040012E2 RID: 4834
		I1,
		// Token: 0x040012E3 RID: 4835
		U1,
		// Token: 0x040012E4 RID: 4836
		I2,
		// Token: 0x040012E5 RID: 4837
		U2,
		// Token: 0x040012E6 RID: 4838
		I4,
		// Token: 0x040012E7 RID: 4839
		U4,
		// Token: 0x040012E8 RID: 4840
		I8,
		// Token: 0x040012E9 RID: 4841
		U8,
		// Token: 0x040012EA RID: 4842
		R4,
		// Token: 0x040012EB RID: 4843
		R8,
		// Token: 0x040012EC RID: 4844
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Marshalling as Currency may be unavailable in future releases.")]
		Currency = 15,
		// Token: 0x040012ED RID: 4845
		BStr = 19,
		// Token: 0x040012EE RID: 4846
		LPStr,
		// Token: 0x040012EF RID: 4847
		LPWStr,
		// Token: 0x040012F0 RID: 4848
		LPTStr,
		// Token: 0x040012F1 RID: 4849
		ByValTStr,
		// Token: 0x040012F2 RID: 4850
		IUnknown = 25,
		// Token: 0x040012F3 RID: 4851
		[EditorBrowsable(EditorBrowsableState.Never)]
		IDispatch,
		// Token: 0x040012F4 RID: 4852
		[EditorBrowsable(EditorBrowsableState.Never)]
		Struct,
		// Token: 0x040012F5 RID: 4853
		Interface,
		// Token: 0x040012F6 RID: 4854
		[EditorBrowsable(EditorBrowsableState.Never)]
		SafeArray,
		// Token: 0x040012F7 RID: 4855
		ByValArray,
		// Token: 0x040012F8 RID: 4856
		SysInt,
		// Token: 0x040012F9 RID: 4857
		SysUInt,
		// Token: 0x040012FA RID: 4858
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Marshalling as VBByRefString may be unavailable in future releases.")]
		VBByRefStr = 34,
		// Token: 0x040012FB RID: 4859
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Marshalling as AnsiBStr may be unavailable in future releases.")]
		AnsiBStr,
		// Token: 0x040012FC RID: 4860
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Marshalling as TBstr may be unavailable in future releases.")]
		TBStr,
		// Token: 0x040012FD RID: 4861
		[EditorBrowsable(EditorBrowsableState.Never)]
		VariantBool,
		// Token: 0x040012FE RID: 4862
		FunctionPtr,
		// Token: 0x040012FF RID: 4863
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Marshalling arbitrary types may be unavailable in future releases. Specify the type you wish to marshal as.")]
		AsAny = 40,
		// Token: 0x04001300 RID: 4864
		LPArray = 42,
		// Token: 0x04001301 RID: 4865
		LPStruct,
		// Token: 0x04001302 RID: 4866
		CustomMarshaler,
		// Token: 0x04001303 RID: 4867
		Error,
		// Token: 0x04001304 RID: 4868
		IInspectable,
		// Token: 0x04001305 RID: 4869
		HString,
		// Token: 0x04001306 RID: 4870
		LPUTF8Str
	}
}
