using System;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Strategies
{
	// Token: 0x02000866 RID: 2150
	internal sealed class SyncWindowsFileStreamStrategy : OSFileStreamStrategy
	{
		// Token: 0x06008856 RID: 34902 RVA: 0x0014B4BA File Offset: 0x001496BA
		internal SyncWindowsFileStreamStrategy(SafeFileHandle handle, FileAccess access) : base(handle, access)
		{
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x0014B4C4 File Offset: 0x001496C4
		internal SyncWindowsFileStreamStrategy(string path, FileMode mode, FileAccess access, FileShare share, FileOptions options, long preallocationSize, UnixFileMode? unixCreateMode) : base(path, mode, access, share, options, preallocationSize, unixCreateMode)
		{
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06008858 RID: 34904 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override bool IsAsync
		{
			get
			{
				return false;
			}
		}
	}
}
