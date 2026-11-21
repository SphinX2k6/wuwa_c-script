using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Strategies
{
	// Token: 0x02000863 RID: 2147
	internal abstract class OSFileStreamStrategy : FileStreamStrategy
	{
		// Token: 0x0600882A RID: 34858 RVA: 0x0014AF99 File Offset: 0x00149199
		internal OSFileStreamStrategy(SafeFileHandle handle, FileAccess access)
		{
			this._access = access;
			handle.EnsureThreadPoolBindingInitialized();
			if (handle.CanSeek)
			{
				this._filePosition = FileStreamHelpers.Seek(handle, 0L, SeekOrigin.Current, false);
			}
			else
			{
				this._filePosition = 0L;
			}
			this._fileHandle = handle;
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x0014AFD8 File Offset: 0x001491D8
		internal OSFileStreamStrategy(string path, FileMode mode, FileAccess access, FileShare share, FileOptions options, long preallocationSize, UnixFileMode? unixCreateMode)
		{
			string fullPath = Path.GetFullPath(path);
			this._access = access;
			this._fileHandle = SafeFileHandle.Open(fullPath, mode, access, share, options, preallocationSize, unixCreateMode);
			try
			{
				if (mode == FileMode.Append && this.CanSeek)
				{
					this._appendStart = (this._filePosition = this.Length);
				}
				else
				{
					this._appendStart = -1L;
				}
			}
			catch
			{
				this._fileHandle.Dispose();
				this._fileHandle = null;
				throw;
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x0014B064 File Offset: 0x00149264
		internal override bool IsAsync
		{
			get
			{
				return this._fileHandle.IsAsync;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x0600882D RID: 34861 RVA: 0x0014B071 File Offset: 0x00149271
		public sealed override bool CanSeek
		{
			get
			{
				return this._fileHandle.CanSeek;
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x0600882E RID: 34862 RVA: 0x0014B07E File Offset: 0x0014927E
		public sealed override bool CanRead
		{
			get
			{
				return !this._fileHandle.IsClosed && (this._access & FileAccess.Read) > (FileAccess)0;
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600882F RID: 34863 RVA: 0x0014B09A File Offset: 0x0014929A
		public sealed override bool CanWrite
		{
			get
			{
				return !this._fileHandle.IsClosed && (this._access & FileAccess.Write) > (FileAccess)0;
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x0014B0B6 File Offset: 0x001492B6
		public sealed override long Length
		{
			get
			{
				return this._fileHandle.GetFileLength();
			}
		}

		// Token: 0x06008831 RID: 34865 RVA: 0x0014B0C3 File Offset: 0x001492C3
		internal void OnIncompleteOperation(int expectedBytesTransferred, int actualBytesTransferred)
		{
			Interlocked.Add(ref this._filePosition, (long)(actualBytesTransferred - expectedBytesTransferred));
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x0014B0D5 File Offset: 0x001492D5
		// (set) Token: 0x06008833 RID: 34867 RVA: 0x001483CE File Offset: 0x001465CE
		public sealed override long Position
		{
			get
			{
				return this._filePosition;
			}
			set
			{
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06008834 RID: 34868 RVA: 0x0014B0DD File Offset: 0x001492DD
		internal sealed override string Name
		{
			get
			{
				return this._fileHandle.Path ?? SR.IO_UnknownFileName;
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06008835 RID: 34869 RVA: 0x0014B0F3 File Offset: 0x001492F3
		internal sealed override bool IsClosed
		{
			get
			{
				return this._fileHandle.IsClosed;
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x0014B100 File Offset: 0x00149300
		internal sealed override SafeFileHandle SafeFileHandle
		{
			get
			{
				if (this.CanSeek)
				{
					FileStreamHelpers.Seek(this._fileHandle, this._filePosition, SeekOrigin.Begin, false);
				}
				return this._fileHandle;
			}
		}

		// Token: 0x06008837 RID: 34871 RVA: 0x0014B124 File Offset: 0x00149324
		public sealed override ValueTask DisposeAsync()
		{
			if (this._fileHandle != null && !this._fileHandle.IsClosed)
			{
				ThreadPoolBoundHandle threadPoolBinding = this._fileHandle.ThreadPoolBinding;
				if (threadPoolBinding != null)
				{
					threadPoolBinding.Dispose();
				}
				this._fileHandle.Dispose();
			}
			return ValueTask.CompletedTask;
		}

		// Token: 0x06008838 RID: 34872 RVA: 0x0014B161 File Offset: 0x00149361
		protected sealed override void Dispose(bool disposing)
		{
			if (disposing && this._fileHandle != null && !this._fileHandle.IsClosed)
			{
				ThreadPoolBoundHandle threadPoolBinding = this._fileHandle.ThreadPoolBinding;
				if (threadPoolBinding != null)
				{
					threadPoolBinding.Dispose();
				}
				this._fileHandle.Dispose();
			}
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public sealed override void Flush()
		{
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x001414EE File Offset: 0x0013F6EE
		public sealed override Task FlushAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x0014B19C File Offset: 0x0014939C
		internal sealed override void Flush(bool flushToDisk)
		{
			if (flushToDisk && this.CanWrite)
			{
				FileStreamHelpers.FlushToDisk(this._fileHandle);
			}
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x0014B1B4 File Offset: 0x001493B4
		public sealed override long Seek(long offset, SeekOrigin origin)
		{
			long filePosition = this._filePosition;
			long num;
			if (origin != SeekOrigin.Begin)
			{
				if (origin != SeekOrigin.End)
				{
					num = this._filePosition + offset;
				}
				else
				{
					num = this.Length + offset;
				}
			}
			else
			{
				num = offset;
			}
			long num2 = num;
			if (num2 >= 0L)
			{
				this._filePosition = num2;
			}
			else
			{
				FileStreamHelpers.ThrowInvalidArgument(this._fileHandle);
			}
			if (this._appendStart != -1L && num2 < this._appendStart)
			{
				this._filePosition = filePosition;
				throw new IOException(SR.IO_SeekAppendOverwrite);
			}
			return num2;
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x0014B22A File Offset: 0x0014942A
		internal sealed override void Lock(long position, long length)
		{
			FileStreamHelpers.Lock(this._fileHandle, this.CanWrite, position, length);
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x0014B23F File Offset: 0x0014943F
		internal sealed override void Unlock(long position, long length)
		{
			FileStreamHelpers.Unlock(this._fileHandle, position, length);
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x0014B24E File Offset: 0x0014944E
		public sealed override void SetLength(long value)
		{
			if (this._appendStart != -1L && value < this._appendStart)
			{
				throw new IOException(SR.IO_SetLengthAppendTruncate);
			}
			this.SetLengthCore(value);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x0014B275 File Offset: 0x00149475
		protected void SetLengthCore(long value)
		{
			RandomAccess.SetFileLength(this._fileHandle, value);
			if (this._filePosition > value)
			{
				this._filePosition = value;
			}
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x0014B294 File Offset: 0x00149494
		public sealed override int ReadByte()
		{
			byte result = 0;
			if (this.Read(new Span<byte>(ref result)) == 0)
			{
				return -1;
			}
			return (int)result;
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x0014B2B5 File Offset: 0x001494B5
		public sealed override int Read(byte[] buffer, int offset, int count)
		{
			return this.Read(new Span<byte>(buffer, offset, count));
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x0014B2C8 File Offset: 0x001494C8
		public sealed override int Read(Span<byte> buffer)
		{
			if (this._fileHandle.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			else if ((this._access & FileAccess.Read) == (FileAccess)0)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			int num = RandomAccess.ReadAtOffset(this._fileHandle, buffer, this._filePosition);
			this._filePosition += (long)num;
			return num;
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x0008AB90 File Offset: 0x00088D90
		public sealed override void WriteByte(byte value)
		{
			this.Write(new ReadOnlySpan<byte>(ref value));
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x0014B31B File Offset: 0x0014951B
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.Write(new ReadOnlySpan<byte>(buffer, offset, count));
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x0014B32C File Offset: 0x0014952C
		public sealed override void Write(ReadOnlySpan<byte> buffer)
		{
			if (this._fileHandle.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			else if ((this._access & FileAccess.Write) == (FileAccess)0)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			RandomAccess.WriteAtOffset(this._fileHandle, buffer, this._filePosition);
			this._filePosition += (long)buffer.Length;
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x0014B383 File Offset: 0x00149583
		public sealed override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToAsyncResult.Begin(base.WriteAsync(buffer, offset, count), callback, state);
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x0008A775 File Offset: 0x00088975
		public sealed override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToAsyncResult.End(asyncResult);
		}

		// Token: 0x06008849 RID: 34889 RVA: 0x0014B398 File Offset: 0x00149598
		public sealed override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this.WriteAsync(new ReadOnlyMemory<byte>(buffer, offset, count), cancellationToken).AsTask();
		}

		// Token: 0x0600884A RID: 34890 RVA: 0x0014B3C0 File Offset: 0x001495C0
		public sealed override ValueTask WriteAsync(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			long fileOffset = this.CanSeek ? (Interlocked.Add(ref this._filePosition, (long)source.Length) - (long)source.Length) : -1L;
			return RandomAccess.WriteAtOffsetAsync(this._fileHandle, source, fileOffset, cancellationToken, this);
		}

		// Token: 0x0600884B RID: 34891 RVA: 0x0014B405 File Offset: 0x00149605
		public sealed override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToAsyncResult.Begin(base.ReadAsync(buffer, offset, count), callback, state);
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x0008A76D File Offset: 0x0008896D
		public sealed override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToAsyncResult.End<int>(asyncResult);
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x0014B41C File Offset: 0x0014961C
		public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this.ReadAsync(new Memory<byte>(buffer, offset, count), cancellationToken).AsTask();
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x0014B444 File Offset: 0x00149644
		public sealed override ValueTask<int> ReadAsync(Memory<byte> destination, CancellationToken cancellationToken)
		{
			if (!this.CanSeek)
			{
				return RandomAccess.ReadAtOffsetAsync(this._fileHandle, destination, -1L, cancellationToken, null);
			}
			long num;
			if (this._fileHandle.TryGetCachedLength(out num) && Volatile.Read(ref this._filePosition) >= num)
			{
				return ValueTask.FromResult<int>(0);
			}
			long fileOffset = Interlocked.Add(ref this._filePosition, (long)destination.Length) - (long)destination.Length;
			return RandomAccess.ReadAtOffsetAsync(this._fileHandle, destination, fileOffset, cancellationToken, this);
		}

		// Token: 0x04001DCF RID: 7631
		protected readonly SafeFileHandle _fileHandle;

		// Token: 0x04001DD0 RID: 7632
		private readonly FileAccess _access;

		// Token: 0x04001DD1 RID: 7633
		protected long _filePosition;

		// Token: 0x04001DD2 RID: 7634
		private readonly long _appendStart;
	}
}
