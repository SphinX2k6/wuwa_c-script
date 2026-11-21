using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000638 RID: 1592
	[NullableContext(1)]
	[Guid("0000010b-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IPersistFile
	{
		// Token: 0x06007280 RID: 29312
		void GetClassID(out Guid pClassID);

		// Token: 0x06007281 RID: 29313
		[PreserveSig]
		int IsDirty();

		// Token: 0x06007282 RID: 29314
		void Load([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, int dwMode);

		// Token: 0x06007283 RID: 29315
		[NullableContext(2)]
		void Save([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.Bool)] bool fRemember);

		// Token: 0x06007284 RID: 29316
		void SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string pszFileName);

		// Token: 0x06007285 RID: 29317
		void GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);
	}
}
