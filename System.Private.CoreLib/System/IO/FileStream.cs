using System;
using System.ComponentModel;
using System.IO.Strategies;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	// Token: 0x020007F8 RID: 2040
	[NullableContext(1)]
	[Nullable(0)]
	public class FileStream : Stream
	{
		// Token: 0x06008278 RID: 33400 RVA: 0x00136A87 File Offset: 0x00134C87
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access) instead.")]
		public FileStream(IntPtr handle, FileAccess access) : this(handle, access, true, 4096, false)
		{
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x00136A98 File Offset: 0x00134C98
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access) and optionally make a new SafeFileHandle with ownsHandle=false if needed instead.")]
		public FileStream(IntPtr handle, FileAccess access, bool ownsHandle) : this(handle, access, ownsHandle, 4096, false)
		{
		}

		// Token: 0x0600827A RID: 33402 RVA: 0x00136AA9 File Offset: 0x00134CA9
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) and optionally make a new SafeFileHandle with ownsHandle=false if needed instead.")]
		public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize) : this(handle, access, ownsHandle, bufferSize, false)
		{
		}

		// Token: 0x0600827B RID: 33403 RVA: 0x00136AB8 File Offset: 0x00134CB8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) and optionally make a new SafeFileHandle with ownsHandle=false if needed instead.")]
		public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync)
		{
			SafeFileHandle safeFileHandle = new SafeFileHandle(handle, ownsHandle);
			try
			{
				FileStream.ValidateHandle(safeFileHandle, access, bufferSize, isAsync);
				this._strategy = FileStreamHelpers.ChooseStrategy(this, safeFileHandle, access, bufferSize, isAsync);
			}
			catch
			{
				GC.SuppressFinalize(safeFileHandle);
				throw;
			}
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x00136B0C File Offset: 0x00134D0C
		private static void ValidateHandle(SafeFileHandle handle, FileAccess access, int bufferSize)
		{
			if (handle.IsInvalid)
			{
				throw new ArgumentException(SR.Arg_InvalidHandle, "handle");
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access", SR.ArgumentOutOfRange_Enum);
			}
			if (bufferSize < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum("bufferSize");
				return;
			}
			if (handle.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
		}

		// Token: 0x0600827D RID: 33405 RVA: 0x00136B65 File Offset: 0x00134D65
		private static void ValidateHandle(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
		{
			FileStream.ValidateHandle(handle, access, bufferSize);
			if (isAsync && !handle.IsAsync)
			{
				ThrowHelper.ThrowArgumentException_HandleNotAsync("handle");
				return;
			}
			if (!isAsync && handle.IsAsync)
			{
				ThrowHelper.ThrowArgumentException_HandleNotSync("handle");
			}
		}

		// Token: 0x0600827E RID: 33406 RVA: 0x00136B9A File Offset: 0x00134D9A
		public FileStream(SafeFileHandle handle, FileAccess access) : this(handle, access, 4096)
		{
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x00136BA9 File Offset: 0x00134DA9
		public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize)
		{
			FileStream.ValidateHandle(handle, access, bufferSize);
			this._strategy = FileStreamHelpers.ChooseStrategy(this, handle, access, bufferSize, handle.IsAsync);
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x00136BCE File Offset: 0x00134DCE
		public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
		{
			FileStream.ValidateHandle(handle, access, bufferSize, isAsync);
			this._strategy = FileStreamHelpers.ChooseStrategy(this, handle, access, bufferSize, isAsync);
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x00136BF1 File Offset: 0x00134DF1
		public FileStream(string path, FileMode mode) : this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.Read, 4096, false)
		{
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x00136C0A File Offset: 0x00134E0A
		public FileStream(string path, FileMode mode, FileAccess access) : this(path, mode, access, FileShare.Read, 4096, false)
		{
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x00136C1C File Offset: 0x00134E1C
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share) : this(path, mode, access, share, 4096, false)
		{
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x00136C2F File Offset: 0x00134E2F
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) : this(path, mode, access, share, bufferSize, false)
		{
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x00136C3F File Offset: 0x00134E3F
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) : this(path, mode, access, share, bufferSize, useAsync ? FileOptions.Asynchronous : FileOptions.None)
		{
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x00136C5A File Offset: 0x00134E5A
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) : this(path, mode, access, share, bufferSize, options, 0L)
		{
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x00136C70 File Offset: 0x00134E70
		~FileStream()
		{
			this.Dispose(false);
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x00136CA0 File Offset: 0x00134EA0
		public FileStream(string path, FileStreamOptions options)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			ArgumentNullException.ThrowIfNull(options, "options");
			if ((options.Access & FileAccess.Read) != (FileAccess)0 && options.Mode == FileMode.Append)
			{
				throw new ArgumentException(SR.Argument_InvalidAppendMode, "options");
			}
			if ((options.Access & FileAccess.Write) == (FileAccess)0 && (options.Mode == FileMode.Truncate || options.Mode == FileMode.CreateNew || options.Mode == FileMode.Create || options.Mode == FileMode.Append))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidFileModeAndAccessCombo, options.Mode, options.Access), "options");
			}
			if (options.PreallocationSize > 0L)
			{
				FileStreamHelpers.ValidateArgumentsForPreallocation(options.Mode, options.Access);
			}
			if (options.UnixCreateMode != null && (options.Mode == FileMode.Truncate || options.Mode == FileMode.Open))
			{
				throw new ArgumentException(SR.Argument_InvalidUnixCreateMode, "options");
			}
			FileStreamHelpers.SerializationGuard(options.Access);
			this._strategy = FileStreamHelpers.ChooseStrategy(this, path, options.Mode, options.Access, options.Share, options.BufferSize, options.Options, options.PreallocationSize, options.UnixCreateMode);
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x00136DD4 File Offset: 0x00134FD4
		private FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, long preallocationSize)
		{
			FileStreamHelpers.ValidateArguments(path, mode, access, share, bufferSize, options, preallocationSize);
			this._strategy = FileStreamHelpers.ChooseStrategy(this, path, mode, access, share, bufferSize, options, preallocationSize, null);
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600828A RID: 33418 RVA: 0x00136E17 File Offset: 0x00135017
		[Obsolete("FileStream.Handle has been deprecated. Use FileStream's SafeFileHandle property instead.")]
		public virtual IntPtr Handle
		{
			get
			{
				return this._strategy.Handle;
			}
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x00136E24 File Offset: 0x00135024
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("macos")]
		[UnsupportedOSPlatform("tvos")]
		[UnsupportedOSPlatform("freebsd")]
		public virtual void Lock(long position, long length)
		{
			if (position < 0L || length < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum((position < 0L) ? "position" : "length");
			}
			else if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			this._strategy.Lock(position, length);
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x00136E74 File Offset: 0x00135074
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("macos")]
		[UnsupportedOSPlatform("tvos")]
		[UnsupportedOSPlatform("freebsd")]
		public virtual void Unlock(long position, long length)
		{
			if (position < 0L || length < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum((position < 0L) ? "position" : "length");
			}
			else if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			this._strategy.Unlock(position, length);
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x00136EC2 File Offset: 0x001350C2
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			return this._strategy.FlushAsync(cancellationToken);
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x00136EF2 File Offset: 0x001350F2
		public override int Read(byte[] buffer, int offset, int count)
		{
			this.ValidateReadWriteArgs(buffer, offset, count);
			return this._strategy.Read(buffer, offset, count);
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x00136F0B File Offset: 0x0013510B
		[NullableContext(0)]
		public override int Read(Span<byte> buffer)
		{
			return this._strategy.Read(buffer);
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x00136F1C File Offset: 0x0013511C
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			if (!this._strategy.CanRead)
			{
				if (this._strategy.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			return this._strategy.ReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x00136F78 File Offset: 0x00135178
		[NullableContext(0)]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			if (!this._strategy.CanRead)
			{
				if (this._strategy.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			return this._strategy.ReadAsync(buffer, cancellationToken);
		}

		// Token: 0x06008292 RID: 33426 RVA: 0x00136FC6 File Offset: 0x001351C6
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.ValidateReadWriteArgs(buffer, offset, count);
			this._strategy.Write(buffer, offset, count);
		}

		// Token: 0x06008293 RID: 33427 RVA: 0x00136FDF File Offset: 0x001351DF
		[NullableContext(0)]
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			this._strategy.Write(buffer);
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x00136FF0 File Offset: 0x001351F0
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (!this._strategy.CanWrite)
			{
				if (this._strategy.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			return this._strategy.WriteAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x0013704C File Offset: 0x0013524C
		[NullableContext(0)]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled(cancellationToken);
			}
			if (!this._strategy.CanWrite)
			{
				if (this._strategy.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			return this._strategy.WriteAsync(buffer, cancellationToken);
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x0013709A File Offset: 0x0013529A
		public override void Flush()
		{
			this.Flush(false);
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x001370A3 File Offset: 0x001352A3
		public virtual void Flush(bool flushToDisk)
		{
			if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			this._strategy.Flush(flushToDisk);
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x001370C3 File Offset: 0x001352C3
		public override bool CanRead
		{
			get
			{
				return this._strategy.CanRead;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06008299 RID: 33433 RVA: 0x001370D0 File Offset: 0x001352D0
		public override bool CanWrite
		{
			get
			{
				return this._strategy.CanWrite;
			}
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x001370DD File Offset: 0x001352DD
		private void ValidateReadWriteArgs(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x001370FC File Offset: 0x001352FC
		public override void SetLength(long value)
		{
			if (value < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			else if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			else if (!this.CanSeek)
			{
				ThrowHelper.ThrowNotSupportedException_UnseekableStream();
			}
			else if (!this.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			this._strategy.SetLength(value);
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600829C RID: 33436 RVA: 0x00137154 File Offset: 0x00135354
		public virtual SafeFileHandle SafeFileHandle
		{
			get
			{
				return this._strategy.SafeFileHandle;
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600829D RID: 33437 RVA: 0x00137161 File Offset: 0x00135361
		public virtual string Name
		{
			get
			{
				return this._strategy.Name;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x0600829E RID: 33438 RVA: 0x0013716E File Offset: 0x0013536E
		public virtual bool IsAsync
		{
			get
			{
				return this._strategy.IsAsync;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x0600829F RID: 33439 RVA: 0x0013717B File Offset: 0x0013537B
		public override long Length
		{
			get
			{
				if (this._strategy.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				else if (!this.CanSeek)
				{
					ThrowHelper.ThrowNotSupportedException_UnseekableStream();
				}
				return this._strategy.Length;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060082A0 RID: 33440 RVA: 0x001371A9 File Offset: 0x001353A9
		// (set) Token: 0x060082A1 RID: 33441 RVA: 0x001371D7 File Offset: 0x001353D7
		public override long Position
		{
			get
			{
				if (this._strategy.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				else if (!this.CanSeek)
				{
					ThrowHelper.ThrowNotSupportedException_UnseekableStream();
				}
				return this._strategy.Position;
			}
			set
			{
				if (value < 0L)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
				}
				else if (!this.CanSeek)
				{
					if (this._strategy.IsClosed)
					{
						ThrowHelper.ThrowObjectDisposedException_FileClosed();
					}
					ThrowHelper.ThrowNotSupportedException_UnseekableStream();
				}
				this._strategy.Position = value;
			}
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x00137213 File Offset: 0x00135413
		public override int ReadByte()
		{
			return this._strategy.ReadByte();
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x00137220 File Offset: 0x00135420
		public override void WriteByte(byte value)
		{
			this._strategy.WriteByte(value);
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x0013722E File Offset: 0x0013542E
		protected override void Dispose(bool disposing)
		{
			FileStreamStrategy strategy = this._strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.DisposeInternal(disposing);
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x00137244 File Offset: 0x00135444
		public override ValueTask DisposeAsync()
		{
			FileStream.<DisposeAsync>d__57 <DisposeAsync>d__;
			<DisposeAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposeAsync>d__.<>4__this = this;
			<DisposeAsync>d__.<>1__state = -1;
			<DisposeAsync>d__.<>t__builder.Start<FileStream.<DisposeAsync>d__57>(ref <DisposeAsync>d__);
			return <DisposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x00137287 File Offset: 0x00135487
		public override void CopyTo(Stream destination, int bufferSize)
		{
			Stream.ValidateCopyToArguments(destination, bufferSize);
			this._strategy.CopyTo(destination, bufferSize);
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0013729D File Offset: 0x0013549D
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			Stream.ValidateCopyToArguments(destination, bufferSize);
			return this._strategy.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x001372B4 File Offset: 0x001354B4
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, [Nullable(2)] AsyncCallback callback, [Nullable(2)] object state)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			else if (!this.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			return this._strategy.BeginRead(buffer, offset, count, callback, state);
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x001372F1 File Offset: 0x001354F1
		public override int EndRead(IAsyncResult asyncResult)
		{
			ArgumentNullException.ThrowIfNull(asyncResult, "asyncResult");
			return this._strategy.EndRead(asyncResult);
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x0013730A File Offset: 0x0013550A
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, [Nullable(2)] AsyncCallback callback, [Nullable(2)] object state)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_FileClosed();
			}
			else if (!this.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			return this._strategy.BeginWrite(buffer, offset, count, callback, state);
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x00137347 File Offset: 0x00135547
		public override void EndWrite(IAsyncResult asyncResult)
		{
			ArgumentNullException.ThrowIfNull(asyncResult, "asyncResult");
			this._strategy.EndWrite(asyncResult);
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060082AC RID: 33452 RVA: 0x00137360 File Offset: 0x00135560
		public override bool CanSeek
		{
			get
			{
				return this._strategy.CanSeek;
			}
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x00137370 File Offset: 0x00135570
		public override long Seek(long offset, SeekOrigin origin)
		{
			if (origin < SeekOrigin.Begin || origin > SeekOrigin.End)
			{
				throw new ArgumentException(SR.Argument_InvalidSeekOrigin, "origin");
			}
			if (!this.CanSeek)
			{
				if (this._strategy.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				ThrowHelper.ThrowNotSupportedException_UnseekableStream();
			}
			return this._strategy.Seek(offset, origin);
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x001373C1 File Offset: 0x001355C1
		internal Task BaseFlushAsync(CancellationToken cancellationToken)
		{
			return base.FlushAsync(cancellationToken);
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x001373CA File Offset: 0x001355CA
		internal int BaseRead(Span<byte> buffer)
		{
			return base.Read(buffer);
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x001373D3 File Offset: 0x001355D3
		internal Task<int> BaseReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return base.ReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x001373E0 File Offset: 0x001355E0
		internal ValueTask<int> BaseReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return base.ReadAsync(buffer, cancellationToken);
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x001373EA File Offset: 0x001355EA
		internal void BaseWrite(ReadOnlySpan<byte> buffer)
		{
			base.Write(buffer);
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x001373F3 File Offset: 0x001355F3
		internal Task BaseWriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return base.WriteAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x00137400 File Offset: 0x00135600
		internal ValueTask BaseWriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return base.WriteAsync(buffer, cancellationToken);
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x0013740A File Offset: 0x0013560A
		internal ValueTask BaseDisposeAsync()
		{
			return base.DisposeAsync();
		}

		// Token: 0x060082B6 RID: 33462 RVA: 0x00137412 File Offset: 0x00135612
		internal Task BaseCopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return base.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		// Token: 0x060082B7 RID: 33463 RVA: 0x0013741D File Offset: 0x0013561D
		internal IAsyncResult BaseBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return base.BeginRead(buffer, offset, count, callback, state);
		}

		// Token: 0x060082B8 RID: 33464 RVA: 0x0013742C File Offset: 0x0013562C
		internal int BaseEndRead(IAsyncResult asyncResult)
		{
			return base.EndRead(asyncResult);
		}

		// Token: 0x060082B9 RID: 33465 RVA: 0x00137435 File Offset: 0x00135635
		internal IAsyncResult BaseBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return base.BeginWrite(buffer, offset, count, callback, state);
		}

		// Token: 0x060082BA RID: 33466 RVA: 0x00137444 File Offset: 0x00135644
		internal void BaseEndWrite(IAsyncResult asyncResult)
		{
			base.EndWrite(asyncResult);
		}

		// Token: 0x04001BA8 RID: 7080
		private readonly FileStreamStrategy _strategy;
	}
}
