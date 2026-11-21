using System;
using System.Buffers;
using System.IO;
using System.IO.Strategies;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks.Sources;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005D RID: 93
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00005255 File Offset: 0x00003455
		public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(preexistingHandle);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000527F File Offset: 0x0000347F
		internal string Path
		{
			get
			{
				return this._path;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00005287 File Offset: 0x00003487
		public SafeFileHandle() : base(true)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000052AA File Offset: 0x000034AA
		public bool IsAsync
		{
			get
			{
				return (this.GetFileOptions() & FileOptions.Asynchronous) > FileOptions.None;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000052BB File Offset: 0x000034BB
		internal bool IsNoBuffering
		{
			get
			{
				return (this.GetFileOptions() & (FileOptions)536870912) > FileOptions.None;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000052CC File Offset: 0x000034CC
		internal bool CanSeek
		{
			get
			{
				return !base.IsClosed && this.GetFileType() == 1;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000052E1 File Offset: 0x000034E1
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x000052E9 File Offset: 0x000034E9
		internal ThreadPoolBoundHandle ThreadPoolBinding { get; set; }

		// Token: 0x060001C3 RID: 451 RVA: 0x000052F2 File Offset: 0x000034F2
		internal bool TryGetCachedLength(out long cachedLength)
		{
			cachedLength = this._length;
			return this._lengthCanBeCached && cachedLength >= 0L;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00005310 File Offset: 0x00003510
		internal static SafeFileHandle Open(string fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options, long preallocationSize, UnixFileMode? unixCreateMode = null)
		{
			SafeFileHandle result;
			using (DisableMediaInsertionPrompt.Create())
			{
				SafeFileHandle safeFileHandle = SafeFileHandle.CreateFile(fullPath, mode, access, share, options);
				if (preallocationSize > 0L)
				{
					SafeFileHandle.Preallocate(fullPath, preallocationSize, safeFileHandle);
				}
				if ((options & FileOptions.Asynchronous) != FileOptions.None)
				{
					safeFileHandle.InitThreadPoolBinding();
				}
				result = safeFileHandle;
			}
			return result;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005374 File Offset: 0x00003574
		private unsafe static SafeFileHandle CreateFile(string fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options)
		{
			Interop.Kernel32.SECURITY_ATTRIBUTES security_ATTRIBUTES = default(Interop.Kernel32.SECURITY_ATTRIBUTES);
			if ((share & FileShare.Inheritable) != FileShare.None)
			{
				security_ATTRIBUTES = new Interop.Kernel32.SECURITY_ATTRIBUTES
				{
					nLength = (uint)sizeof(Interop.Kernel32.SECURITY_ATTRIBUTES),
					bInheritHandle = Interop.BOOL.TRUE
				};
			}
			int dwDesiredAccess = (((access & FileAccess.Read) == FileAccess.Read) ? int.MinValue : 0) | (((access & FileAccess.Write) == FileAccess.Write) ? 1073741824 : 0);
			share &= ~FileShare.Inheritable;
			if (mode == FileMode.Append)
			{
				mode = FileMode.OpenOrCreate;
			}
			int dwFlagsAndAttributes = (int)(options | (FileOptions)1048576);
			SafeFileHandle safeFileHandle = Interop.Kernel32.CreateFile(fullPath, dwDesiredAccess, share, &security_ATTRIBUTES, mode, dwFlagsAndAttributes, IntPtr.Zero);
			if (safeFileHandle.IsInvalid)
			{
				int num = Marshal.GetLastPInvokeError();
				if (num == 3 && fullPath.Length == PathInternal.GetRootLength(fullPath))
				{
					num = 5;
				}
				safeFileHandle.Dispose();
				throw Win32Marshal.GetExceptionForWin32Error(num, fullPath, null);
			}
			safeFileHandle._path = fullPath;
			safeFileHandle._fileOptions = options;
			safeFileHandle._lengthCanBeCached = ((share & FileShare.Write) == FileShare.None && (access & FileAccess.Write) == (FileAccess)0);
			return safeFileHandle;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00005458 File Offset: 0x00003658
		private unsafe static void Preallocate(string fullPath, long preallocationSize, SafeFileHandle fileHandle)
		{
			Interop.Kernel32.FILE_ALLOCATION_INFO file_ALLOCATION_INFO = new Interop.Kernel32.FILE_ALLOCATION_INFO
			{
				AllocationSize = preallocationSize
			};
			if (!Interop.Kernel32.SetFileInformationByHandle(fileHandle, 5, (void*)(&file_ALLOCATION_INFO), (uint)sizeof(Interop.Kernel32.FILE_ALLOCATION_INFO)))
			{
				int lastPInvokeError = Marshal.GetLastPInvokeError();
				if (lastPInvokeError == 112 || lastPInvokeError == 223)
				{
					fileHandle.Dispose();
					Interop.Kernel32.DeleteFile(fullPath);
					throw new IOException(SR.Format((lastPInvokeError == 112) ? SR.IO_DiskFull_Path_AllocationSize : SR.IO_FileTooLarge_Path_AllocationSize, fullPath, preallocationSize));
				}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000054CC File Offset: 0x000036CC
		internal void EnsureThreadPoolBindingInitialized()
		{
			if (this.IsAsync && this.ThreadPoolBinding == null)
			{
				this.<EnsureThreadPoolBindingInitialized>g__Init|24_0();
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000054E4 File Offset: 0x000036E4
		private void InitThreadPoolBinding()
		{
			try
			{
				this.ThreadPoolBinding = ThreadPoolBoundHandle.BindHandle(this);
			}
			catch (ArgumentException innerException)
			{
				if (base.OwnsHandle)
				{
					base.Dispose();
				}
				throw new IOException(SR.IO_BindHandleFailed, innerException);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000552C File Offset: 0x0000372C
		internal unsafe FileOptions GetFileOptions()
		{
			FileOptions fileOptions = this._fileOptions;
			if (fileOptions != (FileOptions)(-1))
			{
				return fileOptions;
			}
			Interop.NtDll.IO_STATUS_BLOCK io_STATUS_BLOCK;
			Interop.NtDll.CreateOptions createOptions;
			int num = Interop.NtDll.NtQueryInformationFile(this, out io_STATUS_BLOCK, (void*)(&createOptions), 4U, 16U);
			if ((long)num != 0L)
			{
				throw Win32Marshal.GetExceptionForWin32Error((int)Interop.NtDll.RtlNtStatusToDosError(num), "", null);
			}
			FileOptions fileOptions2 = FileOptions.None;
			if ((createOptions & (Interop.NtDll.CreateOptions)48U) == (Interop.NtDll.CreateOptions)0U)
			{
				fileOptions2 |= FileOptions.Asynchronous;
			}
			if ((createOptions & Interop.NtDll.CreateOptions.FILE_WRITE_THROUGH) != (Interop.NtDll.CreateOptions)0U)
			{
				fileOptions2 |= FileOptions.WriteThrough;
			}
			if ((createOptions & Interop.NtDll.CreateOptions.FILE_RANDOM_ACCESS) != (Interop.NtDll.CreateOptions)0U)
			{
				fileOptions2 |= FileOptions.RandomAccess;
			}
			if ((createOptions & Interop.NtDll.CreateOptions.FILE_SEQUENTIAL_ONLY) != (Interop.NtDll.CreateOptions)0U)
			{
				fileOptions2 |= FileOptions.SequentialScan;
			}
			if ((createOptions & Interop.NtDll.CreateOptions.FILE_DELETE_ON_CLOSE) != (Interop.NtDll.CreateOptions)0U)
			{
				fileOptions2 |= FileOptions.DeleteOnClose;
			}
			if ((createOptions & Interop.NtDll.CreateOptions.FILE_NO_INTERMEDIATE_BUFFERING) != (Interop.NtDll.CreateOptions)0U)
			{
				fileOptions2 |= (FileOptions)536870912;
			}
			return this._fileOptions = fileOptions2;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000055D4 File Offset: 0x000037D4
		internal int GetFileType()
		{
			int num = this._fileType;
			if (num == -1)
			{
				num = (this._fileType = Interop.Kernel32.GetFileType(this));
			}
			return num;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000055FF File Offset: 0x000037FF
		internal long GetFileLength()
		{
			if (!this._lengthCanBeCached)
			{
				return this.<GetFileLength>g__GetFileLengthCore|28_0();
			}
			if (this._length < 0L)
			{
				this._length = this.<GetFileLength>g__GetFileLengthCore|28_0();
			}
			return this._length;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000562C File Offset: 0x0000382C
		internal SafeFileHandle.OverlappedValueTaskSource GetOverlappedValueTaskSource()
		{
			return Interlocked.Exchange<SafeFileHandle.OverlappedValueTaskSource>(ref this._reusableOverlappedValueTaskSource, null) ?? new SafeFileHandle.OverlappedValueTaskSource(this);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00005644 File Offset: 0x00003844
		protected override bool ReleaseHandle()
		{
			bool result = Interop.Kernel32.CloseHandle(this.handle);
			SafeFileHandle.OverlappedValueTaskSource overlappedValueTaskSource = Interlocked.Exchange<SafeFileHandle.OverlappedValueTaskSource>(ref this._reusableOverlappedValueTaskSource, null);
			if (overlappedValueTaskSource == null)
			{
				return result;
			}
			overlappedValueTaskSource.Dispose();
			return result;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00005667 File Offset: 0x00003867
		private void TryToReuse(SafeFileHandle.OverlappedValueTaskSource source)
		{
			source._source.Reset();
			if (Interlocked.CompareExchange<SafeFileHandle.OverlappedValueTaskSource>(ref this._reusableOverlappedValueTaskSource, source, null) != null)
			{
				source._preallocatedOverlapped.Dispose();
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00005690 File Offset: 0x00003890
		[CompilerGenerated]
		private void <EnsureThreadPoolBindingInitialized>g__Init|24_0()
		{
			lock (this)
			{
				if (this.ThreadPoolBinding == null)
				{
					this.InitThreadPoolBinding();
				}
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000056D4 File Offset: 0x000038D4
		[CompilerGenerated]
		private unsafe long <GetFileLength>g__GetFileLengthCore|28_0()
		{
			Interop.Kernel32.FILE_STANDARD_INFO file_STANDARD_INFO;
			if (Interop.Kernel32.GetFileInformationByHandleEx(this, 1, (void*)(&file_STANDARD_INFO), (uint)sizeof(Interop.Kernel32.FILE_STANDARD_INFO)))
			{
				return file_STANDARD_INFO.EndOfFile;
			}
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (this.Path == null || !PathInternal.IsDevice(this.Path))
			{
				throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, this.Path, null);
			}
			Interop.Kernel32.STORAGE_READ_CAPACITY storage_READ_CAPACITY;
			uint num;
			if (!Interop.Kernel32.DeviceIoControl(this, 2969920U, null, 0U, (void*)(&storage_READ_CAPACITY), (uint)sizeof(Interop.Kernel32.STORAGE_READ_CAPACITY), out num, IntPtr.Zero))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error(this.Path);
			}
			if ((ulong)num != (ulong)((long)sizeof(Interop.Kernel32.STORAGE_READ_CAPACITY)))
			{
				throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, this.Path, null);
			}
			return storage_READ_CAPACITY.DiskLength;
		}

		// Token: 0x040001C3 RID: 451
		private string _path;

		// Token: 0x040001C4 RID: 452
		private long _length = -1L;

		// Token: 0x040001C5 RID: 453
		private bool _lengthCanBeCached;

		// Token: 0x040001C6 RID: 454
		private volatile FileOptions _fileOptions = (FileOptions)(-1);

		// Token: 0x040001C7 RID: 455
		private volatile int _fileType = -1;

		// Token: 0x040001C9 RID: 457
		private SafeFileHandle.OverlappedValueTaskSource _reusableOverlappedValueTaskSource;

		// Token: 0x0200005E RID: 94
		internal sealed class OverlappedValueTaskSource : IValueTaskSource<int>, IValueTaskSource
		{
			// Token: 0x060001D1 RID: 465 RVA: 0x00005773 File Offset: 0x00003973
			internal OverlappedValueTaskSource(SafeFileHandle fileHandle)
			{
				this._fileHandle = fileHandle;
				this._source.RunContinuationsAsynchronously = true;
				this._preallocatedOverlapped = PreAllocatedOverlapped.UnsafeCreate(SafeFileHandle.OverlappedValueTaskSource.s_ioCallback, this, null);
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x000057A0 File Offset: 0x000039A0
			internal void Dispose()
			{
				this.ReleaseResources();
				this._preallocatedOverlapped.Dispose();
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x000057B3 File Offset: 0x000039B3
			internal static Exception GetIOError(int errorCode, string path)
			{
				if (errorCode != 38)
				{
					return Win32Marshal.GetExceptionForWin32Error(errorCode, path, null);
				}
				return ThrowHelper.CreateEndOfFileException();
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x000057C8 File Offset: 0x000039C8
			internal unsafe NativeOverlapped* PrepareForOperation(ReadOnlyMemory<byte> memory, long fileOffset, OSFileStreamStrategy strategy = null)
			{
				this._result = 0UL;
				this._strategy = strategy;
				this._bufferSize = memory.Length;
				this._memoryHandle = memory.Pin();
				this._overlapped = this._fileHandle.ThreadPoolBinding.AllocateNativeOverlapped(this._preallocatedOverlapped);
				if (this._fileHandle.CanSeek)
				{
					this._overlapped->OffsetLow = (int)fileOffset;
					this._overlapped->OffsetHigh = (int)(fileOffset >> 32);
				}
				return this._overlapped;
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0000584A File Offset: 0x00003A4A
			public ValueTaskSourceStatus GetStatus(short token)
			{
				return this._source.GetStatus(token);
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x00005858 File Offset: 0x00003A58
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				this._source.OnCompleted(continuation, state, token, flags);
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x0000586A File Offset: 0x00003A6A
			void IValueTaskSource.GetResult(short token)
			{
				this.GetResult(token);
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00005874 File Offset: 0x00003A74
			public int GetResult(short token)
			{
				int result;
				try
				{
					result = this._source.GetResult(token);
				}
				finally
				{
					this._fileHandle.TryToReuse(this);
				}
				return result;
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x000058B0 File Offset: 0x00003AB0
			internal short Version
			{
				get
				{
					return this._source.Version;
				}
			}

			// Token: 0x060001DA RID: 474 RVA: 0x000058C0 File Offset: 0x00003AC0
			internal void RegisterForCancellation(CancellationToken cancellationToken)
			{
				if (cancellationToken.CanBeCanceled)
				{
					try
					{
						this._cancellationRegistration = cancellationToken.UnsafeRegister(delegate(object s, CancellationToken token)
						{
							SafeFileHandle.OverlappedValueTaskSource overlappedValueTaskSource = (SafeFileHandle.OverlappedValueTaskSource)s;
							if (!overlappedValueTaskSource._fileHandle.IsInvalid)
							{
								try
								{
									Interop.Kernel32.CancelIoEx(overlappedValueTaskSource._fileHandle, overlappedValueTaskSource._overlapped);
								}
								catch (ObjectDisposedException)
								{
								}
							}
						}, this);
					}
					catch (OutOfMemoryException)
					{
					}
				}
			}

			// Token: 0x060001DB RID: 475 RVA: 0x00005918 File Offset: 0x00003B18
			private void ReleaseResources()
			{
				this._strategy = null;
				this._cancellationRegistration.Dispose();
				this._memoryHandle.Dispose();
				if (this._overlapped != null)
				{
					this._fileHandle.ThreadPoolBinding.FreeNativeOverlapped(this._overlapped);
					this._overlapped = null;
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x0000596C File Offset: 0x00003B6C
			internal void FinishedScheduling()
			{
				ulong num = Interlocked.Exchange(ref this._result, 1UL);
				if (num != 0UL)
				{
					this.Complete((uint)num, (uint)(num >> 32) & 2147483647U);
				}
			}

			// Token: 0x060001DD RID: 477 RVA: 0x000059A0 File Offset: 0x00003BA0
			private unsafe static void IOCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
			{
				SafeFileHandle.OverlappedValueTaskSource overlappedValueTaskSource = (SafeFileHandle.OverlappedValueTaskSource)ThreadPoolBoundHandle.GetNativeOverlappedState(pOverlapped);
				if (Interlocked.Exchange(ref overlappedValueTaskSource._result, 9223372036854775808UL | (ulong)numBytes << 32 | (ulong)errorCode) != 0UL)
				{
					overlappedValueTaskSource.Complete(errorCode, numBytes);
				}
			}

			// Token: 0x060001DE RID: 478 RVA: 0x000059E0 File Offset: 0x00003BE0
			internal void Complete(uint errorCode, uint numBytes)
			{
				OSFileStreamStrategy strategy = this._strategy;
				this.ReleaseResources();
				if (errorCode <= 38U)
				{
					if (errorCode != 0U && errorCode != 38U)
					{
						goto IL_99;
					}
				}
				else if (errorCode != 109U && errorCode != 232U)
				{
					if (errorCode != 995U)
					{
						goto IL_99;
					}
					if (strategy != null)
					{
						strategy.OnIncompleteOperation(this._bufferSize, 0);
					}
					CancellationToken token = this._cancellationRegistration.Token;
					this._source.SetException(token.IsCancellationRequested ? new OperationCanceledException(token) : new OperationCanceledException());
					return;
				}
				if ((long)this._bufferSize != (long)((ulong)numBytes) && strategy != null)
				{
					strategy.OnIncompleteOperation(this._bufferSize, (int)numBytes);
				}
				this._source.SetResult((int)numBytes);
				return;
				IL_99:
				if (strategy != null)
				{
					strategy.OnIncompleteOperation(this._bufferSize, 0);
				}
				this._source.SetException(Win32Marshal.GetExceptionForWin32Error((int)errorCode, "", null));
			}

			// Token: 0x040001CA RID: 458
			internal static readonly IOCompletionCallback s_ioCallback = new IOCompletionCallback(SafeFileHandle.OverlappedValueTaskSource.IOCallback);

			// Token: 0x040001CB RID: 459
			internal readonly PreAllocatedOverlapped _preallocatedOverlapped;

			// Token: 0x040001CC RID: 460
			internal readonly SafeFileHandle _fileHandle;

			// Token: 0x040001CD RID: 461
			private OSFileStreamStrategy _strategy;

			// Token: 0x040001CE RID: 462
			internal MemoryHandle _memoryHandle;

			// Token: 0x040001CF RID: 463
			private int _bufferSize;

			// Token: 0x040001D0 RID: 464
			internal ManualResetValueTaskSourceCore<int> _source;

			// Token: 0x040001D1 RID: 465
			private unsafe NativeOverlapped* _overlapped;

			// Token: 0x040001D2 RID: 466
			private CancellationTokenRegistration _cancellationRegistration;

			// Token: 0x040001D3 RID: 467
			internal ulong _result;
		}
	}
}
