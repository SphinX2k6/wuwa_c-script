using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200062D RID: 1581
	[NullableContext(1)]
	[Guid("0000000e-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IBindCtx
	{
		// Token: 0x06007247 RID: 29255
		void RegisterObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

		// Token: 0x06007248 RID: 29256
		void RevokeObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

		// Token: 0x06007249 RID: 29257
		void ReleaseBoundObjects();

		// Token: 0x0600724A RID: 29258
		void SetBindOptions([In] ref BIND_OPTS pbindopts);

		// Token: 0x0600724B RID: 29259
		void GetBindOptions(ref BIND_OPTS pbindopts);

		// Token: 0x0600724C RID: 29260
		[NullableContext(2)]
		void GetRunningObjectTable(out IRunningObjectTable pprot);

		// Token: 0x0600724D RID: 29261
		void RegisterObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] object punk);

		// Token: 0x0600724E RID: 29262
		void GetObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [Nullable(2)] [MarshalAs(UnmanagedType.Interface)] out object ppunk);

		// Token: 0x0600724F RID: 29263
		[NullableContext(2)]
		void EnumObjectParam(out IEnumString ppenum);

		// Token: 0x06007250 RID: 29264
		[PreserveSig]
		int RevokeObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey);
	}
}
