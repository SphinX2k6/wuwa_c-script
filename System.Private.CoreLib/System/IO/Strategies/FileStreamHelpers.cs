using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Strategies
{
	// Token: 0x0200085D RID: 2141
	internal static class FileStreamHelpers
	{
		// Token: 0x060087F8 RID: 34808 RVA: 0x0014A554 File Offset: 0x00148754
		internal static FileStreamStrategy ChooseStrategy(FileStream fileStream, SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
		{
			FileStreamStrategy strategy = FileStreamHelpers.EnableBufferingIfNeeded(FileStreamHelpers.ChooseStrategyCore(handle, access, isAsync), bufferSize);
			return FileStreamHelpers.WrapIfDerivedType(fileStream, strategy);
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x0014A578 File Offset: 0x00148778
		internal static FileStreamStrategy ChooseStrategy(FileStream fileStream, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, long preallocationSize, UnixFileMode? unixCreateMode)
		{
			FileStreamStrategy strategy = FileStreamHelpers.EnableBufferingIfNeeded(FileStreamHelpers.ChooseStrategyCore(path, mode, access, share, options, preallocationSize, unixCreateMode), bufferSize);
			return FileStreamHelpers.WrapIfDerivedType(fileStream, strategy);
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x0014A5A4 File Offset: 0x001487A4
		private static FileStreamStrategy EnableBufferingIfNeeded(FileStreamStrategy strategy, int bufferSize)
		{
			if (bufferSize <= 1)
			{
				return strategy;
			}
			return new BufferedFileStreamStrategy(strategy, bufferSize);
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x0014A5B3 File Offset: 0x001487B3
		private static FileStreamStrategy WrapIfDerivedType(FileStream fileStream, FileStreamStrategy strategy)
		{
			if (!(fileStream.GetType() == typeof(FileStream)))
			{
				return new DerivedFileStreamStrategy(fileStream, strategy);
			}
			return strategy;
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x0014A5D5 File Offset: 0x001487D5
		internal static bool IsIoRelatedException(Exception e)
		{
			return e is IOException || e is UnauthorizedAccessException || e is NotSupportedException || (e is ArgumentException && !(e is ArgumentNullException));
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x0014A608 File Offset: 0x00148808
		internal static void ValidateArguments(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, long preallocationSize)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, "path");
			FileShare fileShare = share & ~FileShare.Inheritable;
			string text = null;
			if (mode < FileMode.CreateNew || mode > FileMode.Append)
			{
				text = "mode";
			}
			else if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				text = "access";
			}
			else if (fileShare < FileShare.None || fileShare > (FileShare.Read | FileShare.Write | FileShare.Delete))
			{
				text = "share";
			}
			if (text != null)
			{
				throw new ArgumentOutOfRangeException(text, SR.ArgumentOutOfRange_Enum);
			}
			if (FileStreamHelpers.AreInvalid(options))
			{
				throw new ArgumentOutOfRangeException("options", SR.ArgumentOutOfRange_Enum);
			}
			if (bufferSize < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum("bufferSize");
			}
			else if (preallocationSize < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum("preallocationSize");
			}
			if ((access & FileAccess.Write) == (FileAccess)0 && (mode == FileMode.Truncate || mode == FileMode.CreateNew || mode == FileMode.Create || mode == FileMode.Append))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidFileModeAndAccessCombo, mode, access), "access");
			}
			if ((access & FileAccess.Read) != (FileAccess)0 && mode == FileMode.Append)
			{
				throw new ArgumentException(SR.Argument_InvalidAppendMode, "access");
			}
			if (preallocationSize > 0L)
			{
				FileStreamHelpers.ValidateArgumentsForPreallocation(mode, access);
			}
			FileStreamHelpers.SerializationGuard(access);
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x0014A700 File Offset: 0x00148900
		internal static void ValidateArgumentsForPreallocation(FileMode mode, FileAccess access)
		{
			if ((access & FileAccess.Write) == (FileAccess)0)
			{
				throw new ArgumentException(SR.Argument_InvalidPreallocateAccess, "access");
			}
			if (mode != FileMode.Create && mode != FileMode.CreateNew)
			{
				throw new ArgumentException(SR.Argument_InvalidPreallocateMode, "mode");
			}
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x0014A72F File Offset: 0x0014892F
		internal static void SerializationGuard(FileAccess access)
		{
			if ((access & FileAccess.Write) == FileAccess.Write)
			{
				SerializationInfo.ThrowIfDeserializationInProgress("AllowFileWrites", ref FileStreamHelpers.s_cachedSerializationSwitch);
			}
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x0014A746 File Offset: 0x00148946
		internal static bool AreInvalid(FileOptions options)
		{
			return options != FileOptions.None && (options & (FileOptions)33538047) > FileOptions.None;
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x0014A757 File Offset: 0x00148957
		private static OSFileStreamStrategy ChooseStrategyCore(SafeFileHandle handle, FileAccess access, bool isAsync)
		{
			if (!isAsync)
			{
				return new SyncWindowsFileStreamStrategy(handle, access);
			}
			return new AsyncWindowsFileStreamStrategy(handle, access);
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x0014A76B File Offset: 0x0014896B
		private static FileStreamStrategy ChooseStrategyCore(string path, FileMode mode, FileAccess access, FileShare share, FileOptions options, long preallocationSize, UnixFileMode? unixCreateMode)
		{
			if ((options & FileOptions.Asynchronous) == FileOptions.None)
			{
				return new SyncWindowsFileStreamStrategy(path, mode, access, share, options, preallocationSize, unixCreateMode);
			}
			return new AsyncWindowsFileStreamStrategy(path, mode, access, share, options, preallocationSize, unixCreateMode);
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x0014A796 File Offset: 0x00148996
		internal static void FlushToDisk(SafeFileHandle handle)
		{
			if (!Interop.Kernel32.FlushFileBuffers(handle) && Marshal.GetLastPInvokeError() != 5)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error(handle.Path);
			}
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x0014A7B4 File Offset: 0x001489B4
		internal static long Seek(SafeFileHandle handle, long offset, SeekOrigin origin, bool closeInvalidHandle = false)
		{
			long result;
			if (Interop.Kernel32.SetFilePointerEx(handle, offset, out result, (uint)origin))
			{
				return result;
			}
			if (closeInvalidHandle)
			{
				throw Win32Marshal.GetExceptionForWin32Error(FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle), handle.Path, null);
			}
			throw Win32Marshal.GetExceptionForLastWin32Error(handle.Path);
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x0014A7F0 File Offset: 0x001489F0
		internal static void ThrowInvalidArgument(SafeFileHandle handle)
		{
			throw Win32Marshal.GetExceptionForWin32Error(87, handle.Path, null);
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x0014A800 File Offset: 0x00148A00
		internal static int GetLastWin32ErrorAndDisposeHandleIfInvalid(SafeFileHandle handle)
		{
			int lastPInvokeError = Marshal.GetLastPInvokeError();
			if (lastPInvokeError == 6)
			{
				handle.Dispose();
			}
			return lastPInvokeError;
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x0014A814 File Offset: 0x00148A14
		internal static void Lock(SafeFileHandle handle, bool _, long position, long length)
		{
			int offsetLow = (int)position;
			int offsetHigh = (int)(position >> 32);
			int countLow = (int)length;
			int countHigh = (int)(length >> 32);
			if (!Interop.Kernel32.LockFile(handle, offsetLow, offsetHigh, countLow, countHigh))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error(handle.Path);
			}
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x0014A84C File Offset: 0x00148A4C
		internal static void Unlock(SafeFileHandle handle, long position, long length)
		{
			int offsetLow = (int)position;
			int offsetHigh = (int)(position >> 32);
			int countLow = (int)length;
			int countHigh = (int)(length >> 32);
			if (!Interop.Kernel32.UnlockFile(handle, offsetLow, offsetHigh, countLow, countHigh))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error(handle.Path);
			}
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x0014A884 File Offset: 0x00148A84
		internal unsafe static int ReadFileNative(SafeFileHandle handle, Span<byte> bytes, NativeOverlapped* overlapped, out int errorCode)
		{
			int result = 0;
			bool flag;
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* bytes2 = reference;
				flag = (((overlapped == null) ? Interop.Kernel32.ReadFile(handle, bytes2, bytes.Length, out result, overlapped) : Interop.Kernel32.ReadFile(handle, bytes2, bytes.Length, IntPtr.Zero, overlapped)) != 0);
			}
			if (!flag)
			{
				errorCode = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
				return -1;
			}
			errorCode = 0;
			return result;
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x0014A8DC File Offset: 0x00148ADC
		internal static Task AsyncModeCopyToAsync(SafeFileHandle handle, bool canSeek, long filePosition, Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			FileStreamHelpers.<AsyncModeCopyToAsync>d__21 <AsyncModeCopyToAsync>d__;
			<AsyncModeCopyToAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AsyncModeCopyToAsync>d__.handle = handle;
			<AsyncModeCopyToAsync>d__.canSeek = canSeek;
			<AsyncModeCopyToAsync>d__.filePosition = filePosition;
			<AsyncModeCopyToAsync>d__.destination = destination;
			<AsyncModeCopyToAsync>d__.bufferSize = bufferSize;
			<AsyncModeCopyToAsync>d__.cancellationToken = cancellationToken;
			<AsyncModeCopyToAsync>d__.<>1__state = -1;
			<AsyncModeCopyToAsync>d__.<>t__builder.Start<FileStreamHelpers.<AsyncModeCopyToAsync>d__21>(ref <AsyncModeCopyToAsync>d__);
			return <AsyncModeCopyToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04001DB4 RID: 7604
		private static int s_cachedSerializationSwitch;

		// Token: 0x0200085E RID: 2142
		private sealed class AsyncCopyToAwaitable : ICriticalNotifyCompletion, INotifyCompletion
		{
			// Token: 0x170011E8 RID: 4584
			// (get) Token: 0x0600880B RID: 34827 RVA: 0x00007B62 File Offset: 0x00005D62
			internal object CancellationLock
			{
				get
				{
					return this;
				}
			}

			// Token: 0x0600880C RID: 34828 RVA: 0x0014A949 File Offset: 0x00148B49
			internal AsyncCopyToAwaitable(SafeFileHandle fileHandle)
			{
				this._fileHandle = fileHandle;
			}

			// Token: 0x0600880D RID: 34829 RVA: 0x0014A958 File Offset: 0x00148B58
			internal void ResetForNextOperation()
			{
				this._continuation = null;
				this._errorCode = 0U;
				this._numBytes = 0U;
			}

			// Token: 0x0600880E RID: 34830 RVA: 0x0014A970 File Offset: 0x00148B70
			internal unsafe static void IOCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP)
			{
				FileStreamHelpers.AsyncCopyToAwaitable asyncCopyToAwaitable = (FileStreamHelpers.AsyncCopyToAwaitable)ThreadPoolBoundHandle.GetNativeOverlappedState(pOVERLAP);
				asyncCopyToAwaitable._errorCode = errorCode;
				asyncCopyToAwaitable._numBytes = numBytes;
				Action action = asyncCopyToAwaitable._continuation ?? Interlocked.CompareExchange<Action>(ref asyncCopyToAwaitable._continuation, FileStreamHelpers.AsyncCopyToAwaitable.s_sentinel, null);
				if (action == null)
				{
					return;
				}
				action();
			}

			// Token: 0x0600880F RID: 34831 RVA: 0x0014A9BC File Offset: 0x00148BBC
			internal void MarkCompleted()
			{
				this._continuation = FileStreamHelpers.AsyncCopyToAwaitable.s_sentinel;
			}

			// Token: 0x06008810 RID: 34832 RVA: 0x00007B62 File Offset: 0x00005D62
			public FileStreamHelpers.AsyncCopyToAwaitable GetAwaiter()
			{
				return this;
			}

			// Token: 0x170011E9 RID: 4585
			// (get) Token: 0x06008811 RID: 34833 RVA: 0x0014A9C9 File Offset: 0x00148BC9
			public bool IsCompleted
			{
				get
				{
					return this._continuation == FileStreamHelpers.AsyncCopyToAwaitable.s_sentinel;
				}
			}

			// Token: 0x06008812 RID: 34834 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public void GetResult()
			{
			}

			// Token: 0x06008813 RID: 34835 RVA: 0x0014A9D8 File Offset: 0x00148BD8
			public void OnCompleted(Action continuation)
			{
				this.UnsafeOnCompleted(continuation);
			}

			// Token: 0x06008814 RID: 34836 RVA: 0x0014A9E1 File Offset: 0x00148BE1
			public void UnsafeOnCompleted(Action continuation)
			{
				if (this._continuation == FileStreamHelpers.AsyncCopyToAwaitable.s_sentinel || Interlocked.CompareExchange<Action>(ref this._continuation, continuation, null) != null)
				{
					Task.Run(continuation);
				}
			}

			// Token: 0x04001DB5 RID: 7605
			private static readonly Action s_sentinel = delegate()
			{
			};

			// Token: 0x04001DB6 RID: 7606
			internal static readonly IOCompletionCallback s_callback = new IOCompletionCallback(FileStreamHelpers.AsyncCopyToAwaitable.IOCallback);

			// Token: 0x04001DB7 RID: 7607
			internal readonly SafeFileHandle _fileHandle;

			// Token: 0x04001DB8 RID: 7608
			internal long _position;

			// Token: 0x04001DB9 RID: 7609
			internal unsafe NativeOverlapped* _nativeOverlapped;

			// Token: 0x04001DBA RID: 7610
			internal Action _continuation;

			// Token: 0x04001DBB RID: 7611
			internal uint _errorCode;

			// Token: 0x04001DBC RID: 7612
			internal uint _numBytes;
		}
	}
}
