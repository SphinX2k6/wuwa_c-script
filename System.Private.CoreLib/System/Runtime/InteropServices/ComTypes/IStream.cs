using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200063B RID: 1595
	[NullableContext(1)]
	[Guid("0000000c-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IStream
	{
		// Token: 0x0600728D RID: 29325
		void Read([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] byte[] pv, int cb, IntPtr pcbRead);

		// Token: 0x0600728E RID: 29326
		void Write([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv, int cb, IntPtr pcbWritten);

		// Token: 0x0600728F RID: 29327
		void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);

		// Token: 0x06007290 RID: 29328
		void SetSize(long libNewSize);

		// Token: 0x06007291 RID: 29329
		void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);

		// Token: 0x06007292 RID: 29330
		void Commit(int grfCommitFlags);

		// Token: 0x06007293 RID: 29331
		void Revert();

		// Token: 0x06007294 RID: 29332
		void LockRegion(long libOffset, long cb, int dwLockType);

		// Token: 0x06007295 RID: 29333
		void UnlockRegion(long libOffset, long cb, int dwLockType);

		// Token: 0x06007296 RID: 29334
		void Stat(out STATSTG pstatstg, int grfStatFlag);

		// Token: 0x06007297 RID: 29335
		void Clone(out IStream ppstm);
	}
}
