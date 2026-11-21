using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000639 RID: 1593
	[NullableContext(1)]
	[Guid("00000010-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IRunningObjectTable
	{
		// Token: 0x06007286 RID: 29318
		int Register(int grfFlags, [MarshalAs(UnmanagedType.Interface)] object punkObject, IMoniker pmkObjectName);

		// Token: 0x06007287 RID: 29319
		void Revoke(int dwRegister);

		// Token: 0x06007288 RID: 29320
		[PreserveSig]
		int IsRunning(IMoniker pmkObjectName);

		// Token: 0x06007289 RID: 29321
		[PreserveSig]
		int GetObject(IMoniker pmkObjectName, [MarshalAs(UnmanagedType.Interface)] out object ppunkObject);

		// Token: 0x0600728A RID: 29322
		void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);

		// Token: 0x0600728B RID: 29323
		[PreserveSig]
		int GetTimeOfLastChange(IMoniker pmkObjectName, out FILETIME pfiletime);

		// Token: 0x0600728C RID: 29324
		void EnumRunning(out IEnumMoniker ppenumMoniker);
	}
}
