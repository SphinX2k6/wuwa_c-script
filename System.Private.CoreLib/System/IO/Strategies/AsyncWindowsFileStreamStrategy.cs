using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Strategies
{
	// Token: 0x02000864 RID: 2148
	internal sealed class AsyncWindowsFileStreamStrategy : OSFileStreamStrategy
	{
		// Token: 0x0600884F RID: 34895 RVA: 0x0014B4BA File Offset: 0x001496BA
		internal AsyncWindowsFileStreamStrategy(SafeFileHandle handle, FileAccess access) : base(handle, access)
		{
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x0014B4C4 File Offset: 0x001496C4
		internal AsyncWindowsFileStreamStrategy(string path, FileMode mode, FileAccess access, FileShare share, FileOptions options, long preallocationSize, UnixFileMode? unixCreateMode) : base(path, mode, access, share, options, preallocationSize, unixCreateMode)
		{
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06008851 RID: 34897 RVA: 0x000070DD File Offset: 0x000052DD
		internal override bool IsAsync
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x0014B4D7 File Offset: 0x001496D7
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			if (this._fileHandle.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			if (!this.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			return this.AsyncModeCopyToAsync(destination, bufferSize, cancellationToken);
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x0014B514 File Offset: 0x00149714
		private Task AsyncModeCopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			AsyncWindowsFileStreamStrategy.<AsyncModeCopyToAsync>d__5 <AsyncModeCopyToAsync>d__;
			<AsyncModeCopyToAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AsyncModeCopyToAsync>d__.<>4__this = this;
			<AsyncModeCopyToAsync>d__.destination = destination;
			<AsyncModeCopyToAsync>d__.bufferSize = bufferSize;
			<AsyncModeCopyToAsync>d__.cancellationToken = cancellationToken;
			<AsyncModeCopyToAsync>d__.<>1__state = -1;
			<AsyncModeCopyToAsync>d__.<>t__builder.Start<AsyncWindowsFileStreamStrategy.<AsyncModeCopyToAsync>d__5>(ref <AsyncModeCopyToAsync>d__);
			return <AsyncModeCopyToAsync>d__.<>t__builder.Task;
		}
	}
}
