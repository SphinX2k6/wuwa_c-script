using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Strategies;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	// Token: 0x0200080A RID: 2058
	public static class RandomAccess
	{
		// Token: 0x060083BA RID: 33722 RVA: 0x0013B5C1 File Offset: 0x001397C1
		[NullableContext(1)]
		public static long GetLength(SafeFileHandle handle)
		{
			RandomAccess.ValidateInput(handle, 0L, false);
			return handle.GetFileLength();
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x0013B5D2 File Offset: 0x001397D2
		[NullableContext(1)]
		public static void SetLength(SafeFileHandle handle, long length)
		{
			RandomAccess.ValidateInput(handle, 0L, false);
			if (length < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum("length");
			}
			RandomAccess.SetFileLength(handle, length);
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x0013B5F3 File Offset: 0x001397F3
		public static int Read([Nullable(1)] SafeFileHandle handle, Span<byte> buffer, long fileOffset)
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			return RandomAccess.ReadAtOffset(handle, buffer, fileOffset);
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x0013B605 File Offset: 0x00139805
		[NullableContext(1)]
		public static long Read(SafeFileHandle handle, [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<Memory<byte>> buffers, long fileOffset)
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			RandomAccess.ValidateBuffers<Memory<byte>>(buffers);
			return RandomAccess.ReadScatterAtOffset(handle, buffers, fileOffset);
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x0013B61D File Offset: 0x0013981D
		public static ValueTask<int> ReadAsync([Nullable(1)] SafeFileHandle handle, Memory<byte> buffer, long fileOffset, CancellationToken cancellationToken = default(CancellationToken))
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			return RandomAccess.ReadAtOffsetAsync(handle, buffer, fileOffset, cancellationToken, null);
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x0013B641 File Offset: 0x00139841
		public static ValueTask<long> ReadAsync([Nullable(1)] SafeFileHandle handle, [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<Memory<byte>> buffers, long fileOffset, CancellationToken cancellationToken = default(CancellationToken))
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			RandomAccess.ValidateBuffers<Memory<byte>>(buffers);
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<long>(cancellationToken);
			}
			return RandomAccess.ReadScatterAtOffsetAsync(handle, buffers, fileOffset, cancellationToken);
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x0013B66A File Offset: 0x0013986A
		public static void Write([Nullable(1)] SafeFileHandle handle, ReadOnlySpan<byte> buffer, long fileOffset)
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			RandomAccess.WriteAtOffset(handle, buffer, fileOffset);
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x0013B67C File Offset: 0x0013987C
		[NullableContext(1)]
		public static void Write(SafeFileHandle handle, [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset)
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			RandomAccess.ValidateBuffers<ReadOnlyMemory<byte>>(buffers);
			RandomAccess.WriteGatherAtOffset(handle, buffers, fileOffset);
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x0013B694 File Offset: 0x00139894
		public static ValueTask WriteAsync([Nullable(1)] SafeFileHandle handle, ReadOnlyMemory<byte> buffer, long fileOffset, CancellationToken cancellationToken = default(CancellationToken))
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled(cancellationToken);
			}
			return RandomAccess.WriteAtOffsetAsync(handle, buffer, fileOffset, cancellationToken, null);
		}

		// Token: 0x060083C3 RID: 33731 RVA: 0x0013B6B8 File Offset: 0x001398B8
		[NullableContext(1)]
		public static ValueTask WriteAsync(SafeFileHandle handle, [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset, CancellationToken cancellationToken = default(CancellationToken))
		{
			RandomAccess.ValidateInput(handle, fileOffset, false);
			RandomAccess.ValidateBuffers<ReadOnlyMemory<byte>>(buffers);
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled(cancellationToken);
			}
			return RandomAccess.WriteGatherAtOffsetAsync(handle, buffers, fileOffset, cancellationToken);
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x0013B6E1 File Offset: 0x001398E1
		[NullableContext(1)]
		public static void FlushToDisk(SafeFileHandle handle)
		{
			RandomAccess.ValidateInput(handle, 0L, true);
			FileStreamHelpers.FlushToDisk(handle);
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x0013B6F4 File Offset: 0x001398F4
		private static void ValidateInput(SafeFileHandle handle, long fileOffset, bool allowUnseekableHandles = false)
		{
			if (handle == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.handle);
				return;
			}
			if (handle.IsInvalid)
			{
				ThrowHelper.ThrowArgumentException_InvalidHandle("handle");
				return;
			}
			if (!handle.CanSeek)
			{
				if (handle.IsClosed)
				{
					ThrowHelper.ThrowObjectDisposedException_FileClosed();
				}
				if (!allowUnseekableHandles)
				{
					ThrowHelper.ThrowNotSupportedException_UnseekableStream();
					return;
				}
			}
			else if (fileOffset < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum("fileOffset");
			}
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x0013B74C File Offset: 0x0013994C
		private static void ValidateBuffers<T>(IReadOnlyList<T> buffers)
		{
			if (buffers == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.buffers);
			}
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x0013B758 File Offset: 0x00139958
		internal unsafe static void SetFileLength(SafeFileHandle handle, long length)
		{
			Interop.Kernel32.FILE_END_OF_FILE_INFO file_END_OF_FILE_INFO = new Interop.Kernel32.FILE_END_OF_FILE_INFO
			{
				EndOfFile = length
			};
			if (!Interop.Kernel32.SetFileInformationByHandle(handle, 6, (void*)(&file_END_OF_FILE_INFO), (uint)sizeof(Interop.Kernel32.FILE_END_OF_FILE_INFO)))
			{
				int lastPInvokeError = Marshal.GetLastPInvokeError();
				throw (lastPInvokeError == 87) ? new ArgumentOutOfRangeException("length", SR.ArgumentOutOfRange_FileLengthTooBig) : Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, handle.Path, null);
			}
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x0013B7B4 File Offset: 0x001399B4
		internal unsafe static int ReadAtOffset(SafeFileHandle handle, Span<byte> buffer, long fileOffset)
		{
			if (handle.IsAsync)
			{
				return RandomAccess.ReadSyncUsingAsyncHandle(handle, buffer, fileOffset);
			}
			NativeOverlapped nativeOverlappedForSyncHandle = RandomAccess.GetNativeOverlappedForSyncHandle(handle, fileOffset);
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* bytes = reference;
				int num;
				if (Interop.Kernel32.ReadFile(handle, bytes, buffer.Length, out num, &nativeOverlappedForSyncHandle) != 0)
				{
					return num;
				}
				int lastWin32ErrorAndDisposeHandleIfInvalid = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
				int result;
				if (lastWin32ErrorAndDisposeHandleIfInvalid == 38)
				{
					result = num;
				}
				else
				{
					if (!RandomAccess.IsEndOfFile(lastWin32ErrorAndDisposeHandleIfInvalid, handle, fileOffset))
					{
						throw Win32Marshal.GetExceptionForWin32Error(lastWin32ErrorAndDisposeHandleIfInvalid, handle.Path, null);
					}
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x0013B830 File Offset: 0x00139A30
		private unsafe static int ReadSyncUsingAsyncHandle(SafeFileHandle handle, Span<byte> buffer, long fileOffset)
		{
			handle.EnsureThreadPoolBindingInitialized();
			RandomAccess.CallbackResetEvent callbackResetEvent = new RandomAccess.CallbackResetEvent(handle.ThreadPoolBinding);
			NativeOverlapped* ptr = null;
			int result2;
			try
			{
				ptr = RandomAccess.GetNativeOverlappedForAsyncHandle(handle, fileOffset, callbackResetEvent);
				try
				{
					fixed (byte* ptr2 = MemoryMarshal.GetReference<byte>(buffer))
					{
						byte* bytes = ptr2;
						Interop.Kernel32.ReadFile(handle, bytes, buffer.Length, IntPtr.Zero, ptr);
						int num = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
						if (num == 997)
						{
							callbackResetEvent.WaitOne();
							num = 0;
						}
						if (num == 0)
						{
							int result = 0;
							if (Interop.Kernel32.GetOverlappedResult(handle, ptr, ref result, false))
							{
								return result;
							}
							num = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
						}
						else
						{
							callbackResetEvent.ReleaseRefCount(ptr);
						}
						if (!RandomAccess.IsEndOfFile(num, handle, fileOffset))
						{
							throw Win32Marshal.GetExceptionForWin32Error(num, handle.Path, null);
						}
						ptr->InternalLow = IntPtr.Zero;
						result2 = 0;
					}
				}
				finally
				{
					byte* ptr2 = null;
				}
			}
			finally
			{
				if (ptr != null)
				{
					callbackResetEvent.ReleaseRefCount(ptr);
				}
				callbackResetEvent.Dispose();
			}
			return result2;
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x0013B920 File Offset: 0x00139B20
		internal unsafe static void WriteAtOffset(SafeFileHandle handle, ReadOnlySpan<byte> buffer, long fileOffset)
		{
			if (buffer.IsEmpty)
			{
				return;
			}
			if (handle.IsAsync)
			{
				RandomAccess.WriteSyncUsingAsyncHandle(handle, buffer, fileOffset);
				return;
			}
			NativeOverlapped nativeOverlappedForSyncHandle = RandomAccess.GetNativeOverlappedForSyncHandle(handle, fileOffset);
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* bytes = reference;
				int num;
				if (Interop.Kernel32.WriteFile(handle, bytes, buffer.Length, out num, &nativeOverlappedForSyncHandle) != 0)
				{
					return;
				}
				throw Win32Marshal.GetExceptionForWin32Error(FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle), handle.Path, null);
			}
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x0013B984 File Offset: 0x00139B84
		private unsafe static void WriteSyncUsingAsyncHandle(SafeFileHandle handle, ReadOnlySpan<byte> buffer, long fileOffset)
		{
			if (buffer.IsEmpty)
			{
				return;
			}
			handle.EnsureThreadPoolBindingInitialized();
			RandomAccess.CallbackResetEvent callbackResetEvent = new RandomAccess.CallbackResetEvent(handle.ThreadPoolBinding);
			NativeOverlapped* ptr = null;
			try
			{
				ptr = RandomAccess.GetNativeOverlappedForAsyncHandle(handle, fileOffset, callbackResetEvent);
				try
				{
					fixed (byte* ptr2 = MemoryMarshal.GetReference<byte>(buffer))
					{
						byte* bytes = ptr2;
						Interop.Kernel32.WriteFile(handle, bytes, buffer.Length, IntPtr.Zero, ptr);
						int num = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
						if (num == 997)
						{
							callbackResetEvent.WaitOne();
							num = 0;
						}
						if (num == 0)
						{
							int num2 = 0;
							if (Interop.Kernel32.GetOverlappedResult(handle, ptr, ref num2, false))
							{
								return;
							}
							num = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
						}
						else
						{
							callbackResetEvent.ReleaseRefCount(ptr);
						}
						Exception ex;
						if (num == 87)
						{
							ex = new IOException(SR.IO_FileTooLong);
						}
						else
						{
							ex = Win32Marshal.GetExceptionForWin32Error(num, handle.Path, null);
						}
						throw ex;
					}
				}
				finally
				{
					byte* ptr2 = null;
				}
			}
			finally
			{
				if (ptr != null)
				{
					callbackResetEvent.ReleaseRefCount(ptr);
				}
				callbackResetEvent.Dispose();
			}
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0013BA74 File Offset: 0x00139C74
		internal static ValueTask<int> ReadAtOffsetAsync(SafeFileHandle handle, Memory<byte> buffer, long fileOffset, CancellationToken cancellationToken, OSFileStreamStrategy strategy = null)
		{
			if (!handle.IsAsync)
			{
				return AsyncOverSyncWithIoCancellation.InvokeAsync<ValueTuple<SafeFileHandle, Memory<byte>, long, OSFileStreamStrategy>, int>(delegate([TupleElementNames(new string[]
				{
					"handle",
					"buffer",
					"fileOffset",
					"strategy"
				})] ValueTuple<SafeFileHandle, Memory<byte>, long, OSFileStreamStrategy> state)
				{
					int result;
					try
					{
						int num = RandomAccess.ReadAtOffset(state.Item1, state.Item2.Span, state.Item3);
						if (num != state.Item2.Length)
						{
							OSFileStreamStrategy item3 = state.Item4;
							if (item3 != null)
							{
								item3.OnIncompleteOperation(state.Item2.Length, num);
							}
						}
						result = num;
					}
					catch (Exception obj) when (state.Item4 != null)
					{
						state.Item4.OnIncompleteOperation(state.Item2.Length, 0);
						throw;
					}
					return result;
				}, new ValueTuple<SafeFileHandle, Memory<byte>, long, OSFileStreamStrategy>(handle, buffer, fileOffset, strategy), cancellationToken);
			}
			ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int> valueTuple = RandomAccess.QueueAsyncReadFile(handle, buffer, fileOffset, cancellationToken, strategy);
			SafeFileHandle.OverlappedValueTaskSource item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			if (item != null)
			{
				return new ValueTask<int>(item, item.Version);
			}
			if (item2 == 0)
			{
				return ValueTask.FromResult<int>(0);
			}
			return ValueTask.FromException<int>(Win32Marshal.GetExceptionForWin32Error(item2, handle.Path, null));
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x0013BB00 File Offset: 0x00139D00
		[return: TupleElementNames(new string[]
		{
			"vts",
			"errorCode"
		})]
		private unsafe static ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int> QueueAsyncReadFile(SafeFileHandle handle, Memory<byte> buffer, long fileOffset, CancellationToken cancellationToken, OSFileStreamStrategy strategy)
		{
			handle.EnsureThreadPoolBindingInitialized();
			SafeFileHandle.OverlappedValueTaskSource overlappedValueTaskSource = handle.GetOverlappedValueTaskSource();
			int num = 0;
			try
			{
				NativeOverlapped* ptr = overlappedValueTaskSource.PrepareForOperation(buffer, fileOffset, strategy);
				if (Interop.Kernel32.ReadFile(handle, (byte*)overlappedValueTaskSource._memoryHandle.Pointer, buffer.Length, IntPtr.Zero, ptr) == 0)
				{
					num = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
					if (num == 997)
					{
						overlappedValueTaskSource.RegisterForCancellation(cancellationToken);
					}
					else
					{
						if (RandomAccess.IsEndOfFile(num, handle, fileOffset))
						{
							ptr->InternalLow = IntPtr.Zero;
							overlappedValueTaskSource.Dispose();
							return new ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int>(null, 0);
						}
						overlappedValueTaskSource.Dispose();
						return new ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int>(null, num);
					}
				}
			}
			catch
			{
				overlappedValueTaskSource.Dispose();
				throw;
			}
			finally
			{
				if (num != 997 && num != 0 && strategy != null)
				{
					strategy.OnIncompleteOperation(buffer.Length, 0);
				}
			}
			overlappedValueTaskSource.FinishedScheduling();
			return new ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int>(overlappedValueTaskSource, -1);
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x0013BBF0 File Offset: 0x00139DF0
		internal static ValueTask WriteAtOffsetAsync(SafeFileHandle handle, ReadOnlyMemory<byte> buffer, long fileOffset, CancellationToken cancellationToken, OSFileStreamStrategy strategy = null)
		{
			if (!handle.IsAsync)
			{
				return AsyncOverSyncWithIoCancellation.InvokeAsync<ValueTuple<SafeFileHandle, ReadOnlyMemory<byte>, long, OSFileStreamStrategy>>(delegate([TupleElementNames(new string[]
				{
					"handle",
					"buffer",
					"fileOffset",
					"strategy"
				})] ValueTuple<SafeFileHandle, ReadOnlyMemory<byte>, long, OSFileStreamStrategy> state)
				{
					try
					{
						RandomAccess.WriteAtOffset(state.Item1, state.Item2.Span, state.Item3);
					}
					catch (Exception obj) when (state.Item4 != null)
					{
						state.Item4.OnIncompleteOperation(state.Item2.Length, 0);
						throw;
					}
				}, new ValueTuple<SafeFileHandle, ReadOnlyMemory<byte>, long, OSFileStreamStrategy>(handle, buffer, fileOffset, strategy), cancellationToken);
			}
			ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int> valueTuple = RandomAccess.QueueAsyncWriteFile(handle, buffer, fileOffset, cancellationToken, strategy);
			SafeFileHandle.OverlappedValueTaskSource item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			if (item != null)
			{
				return new ValueTask(item, item.Version);
			}
			if (item2 == 0)
			{
				return ValueTask.CompletedTask;
			}
			return ValueTask.FromException(Win32Marshal.GetExceptionForWin32Error(item2, handle.Path, null));
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x0013BC78 File Offset: 0x00139E78
		[return: TupleElementNames(new string[]
		{
			"vts",
			"errorCode"
		})]
		private unsafe static ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int> QueueAsyncWriteFile(SafeFileHandle handle, ReadOnlyMemory<byte> buffer, long fileOffset, CancellationToken cancellationToken, OSFileStreamStrategy strategy)
		{
			handle.EnsureThreadPoolBindingInitialized();
			SafeFileHandle.OverlappedValueTaskSource overlappedValueTaskSource = handle.GetOverlappedValueTaskSource();
			int num = 0;
			try
			{
				NativeOverlapped* lpOverlapped = overlappedValueTaskSource.PrepareForOperation(buffer, fileOffset, strategy);
				if (Interop.Kernel32.WriteFile(handle, (byte*)overlappedValueTaskSource._memoryHandle.Pointer, buffer.Length, IntPtr.Zero, lpOverlapped) == 0)
				{
					num = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
					if (num != 997)
					{
						overlappedValueTaskSource.Dispose();
						return new ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int>(null, num);
					}
					overlappedValueTaskSource.RegisterForCancellation(cancellationToken);
				}
			}
			catch
			{
				overlappedValueTaskSource.Dispose();
				throw;
			}
			finally
			{
				if (num != 997 && num != 0 && strategy != null)
				{
					strategy.OnIncompleteOperation(buffer.Length, 0);
				}
			}
			overlappedValueTaskSource.FinishedScheduling();
			return new ValueTuple<SafeFileHandle.OverlappedValueTaskSource, int>(overlappedValueTaskSource, -1);
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x0013BD3C File Offset: 0x00139F3C
		internal static long ReadScatterAtOffset(SafeFileHandle handle, IReadOnlyList<Memory<byte>> buffers, long fileOffset)
		{
			long num = 0L;
			int count = buffers.Count;
			for (int i = 0; i < count; i++)
			{
				Span<byte> span = buffers[i].Span;
				int num2 = RandomAccess.ReadAtOffset(handle, span, fileOffset + num);
				num += (long)num2;
				if (num2 != span.Length)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x0013BD90 File Offset: 0x00139F90
		internal static void WriteGatherAtOffset(SafeFileHandle handle, IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset)
		{
			int num = 0;
			int count = buffers.Count;
			for (int i = 0; i < count; i++)
			{
				ReadOnlySpan<byte> span = buffers[i].Span;
				RandomAccess.WriteAtOffset(handle, span, fileOffset + (long)num);
				num += span.Length;
			}
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x0013BDD8 File Offset: 0x00139FD8
		private static bool CanUseScatterGatherWindowsAPIs(SafeFileHandle handle)
		{
			return handle.IsAsync && (handle.GetFileOptions() & (FileOptions)536870912) > FileOptions.None;
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x0013BDF4 File Offset: 0x00139FF4
		private unsafe static bool TryPrepareScatterGatherBuffers<T, THandler>(IReadOnlyList<T> buffers, [NotNullWhen(true)] out MemoryHandle[] handlesToDispose, out IntPtr segmentsPtr, out int totalBytes) where T : struct where THandler : struct, RandomAccess.IMemoryHandler<T>
		{
			int systemPageSize = Environment.SystemPageSize;
			long num = (long)(systemPageSize - 1);
			int count = buffers.Count;
			handlesToDispose = null;
			segmentsPtr = IntPtr.Zero;
			totalBytes = 0;
			long* ptr = null;
			bool flag = false;
			bool result;
			try
			{
				long num2 = 0L;
				for (int i = 0; i < count; i++)
				{
					T t = buffers[i];
					int length = RandomAccess.IMemoryHandler<T>.GetLength(t);
					num2 += (long)length;
					if (length != systemPageSize || num2 > 2147483647L)
					{
						return false;
					}
					MemoryHandle memoryHandle = RandomAccess.IMemoryHandler<T>.Pin(t);
					long num3 = memoryHandle.Pointer;
					if ((num3 & num) != 0L)
					{
						memoryHandle.Dispose();
						return false;
					}
					MemoryHandle[] array;
					if ((array = handlesToDispose) == null)
					{
						MemoryHandle[] array2;
						handlesToDispose = (array2 = new MemoryHandle[count]);
						array = array2;
					}
					array[i] = memoryHandle;
					if (ptr == null)
					{
						ptr = (long*)NativeMemory.Alloc((UIntPtr)((IntPtr)count + (IntPtr)1), (UIntPtr)((IntPtr)8));
						ptr[count] = 0L;
					}
					ptr[i] = num3;
				}
				segmentsPtr = ptr;
				totalBytes = (int)num2;
				flag = true;
				result = (handlesToDispose != null);
			}
			finally
			{
				if (!flag)
				{
					RandomAccess.CleanupScatterGatherBuffers(handlesToDispose, ptr);
				}
			}
			return result;
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x0013BF18 File Offset: 0x0013A118
		private static void CleanupScatterGatherBuffers(MemoryHandle[] handlesToDispose, IntPtr segmentsPtr)
		{
			if (handlesToDispose != null)
			{
				foreach (MemoryHandle memoryHandle in handlesToDispose)
				{
					memoryHandle.Dispose();
				}
			}
			if (segmentsPtr != IntPtr.Zero)
			{
				NativeMemory.Free(segmentsPtr);
			}
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x0013BF58 File Offset: 0x0013A158
		private static ValueTask<long> ReadScatterAtOffsetAsync(SafeFileHandle handle, IReadOnlyList<Memory<byte>> buffers, long fileOffset, CancellationToken cancellationToken)
		{
			if (!handle.IsAsync)
			{
				return AsyncOverSyncWithIoCancellation.InvokeAsync<ValueTuple<SafeFileHandle, IReadOnlyList<Memory<byte>>, long>, long>(([TupleElementNames(new string[]
				{
					"handle",
					"buffers",
					"fileOffset"
				})] ValueTuple<SafeFileHandle, IReadOnlyList<Memory<byte>>, long> state) => RandomAccess.ReadScatterAtOffset(state.Item1, state.Item2, state.Item3), new ValueTuple<SafeFileHandle, IReadOnlyList<Memory<byte>>, long>(handle, buffers, fileOffset), cancellationToken);
			}
			MemoryHandle[] handlesToDispose;
			IntPtr segmentsPtr;
			int totalBytes;
			if (RandomAccess.CanUseScatterGatherWindowsAPIs(handle) && RandomAccess.TryPrepareScatterGatherBuffers<Memory<byte>, RandomAccess.MemoryHandler>(buffers, out handlesToDispose, out segmentsPtr, out totalBytes))
			{
				return RandomAccess.ReadScatterAtOffsetSingleSyscallAsync(handle, handlesToDispose, segmentsPtr, fileOffset, totalBytes, cancellationToken);
			}
			return RandomAccess.ReadScatterAtOffsetMultipleSyscallsAsync(handle, buffers, fileOffset, cancellationToken);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x0013BFC8 File Offset: 0x0013A1C8
		private static ValueTask<long> ReadScatterAtOffsetSingleSyscallAsync(SafeFileHandle handle, MemoryHandle[] handlesToDispose, IntPtr segmentsPtr, long fileOffset, int totalBytes, CancellationToken cancellationToken)
		{
			RandomAccess.<ReadScatterAtOffsetSingleSyscallAsync>d__29 <ReadScatterAtOffsetSingleSyscallAsync>d__;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<long>.Create();
			<ReadScatterAtOffsetSingleSyscallAsync>d__.handle = handle;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.handlesToDispose = handlesToDispose;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.segmentsPtr = segmentsPtr;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.fileOffset = fileOffset;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.totalBytes = totalBytes;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.cancellationToken = cancellationToken;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.<>1__state = -1;
			<ReadScatterAtOffsetSingleSyscallAsync>d__.<>t__builder.Start<RandomAccess.<ReadScatterAtOffsetSingleSyscallAsync>d__29>(ref <ReadScatterAtOffsetSingleSyscallAsync>d__);
			return <ReadScatterAtOffsetSingleSyscallAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x0013C038 File Offset: 0x0013A238
		private unsafe static ValueTask<int> ReadFileScatterAsync(SafeFileHandle handle, IntPtr segmentsPtr, int bytesToRead, long fileOffset, CancellationToken cancellationToken)
		{
			handle.EnsureThreadPoolBindingInitialized();
			SafeFileHandle.OverlappedValueTaskSource overlappedValueTaskSource = handle.GetOverlappedValueTaskSource();
			try
			{
				NativeOverlapped* ptr = overlappedValueTaskSource.PrepareForOperation(Memory<byte>.Empty, fileOffset, null);
				if (Interop.Kernel32.ReadFileScatter(handle, segmentsPtr, bytesToRead, IntPtr.Zero, ptr) == 0)
				{
					int lastWin32ErrorAndDisposeHandleIfInvalid = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
					if (lastWin32ErrorAndDisposeHandleIfInvalid == 997)
					{
						overlappedValueTaskSource.RegisterForCancellation(cancellationToken);
					}
					else
					{
						if (RandomAccess.IsEndOfFile(lastWin32ErrorAndDisposeHandleIfInvalid, handle, fileOffset))
						{
							ptr->InternalLow = IntPtr.Zero;
							overlappedValueTaskSource.Dispose();
							return ValueTask.FromResult<int>(0);
						}
						overlappedValueTaskSource.Dispose();
						return ValueTask.FromException<int>(Win32Marshal.GetExceptionForWin32Error(lastWin32ErrorAndDisposeHandleIfInvalid, handle.Path, null));
					}
				}
			}
			catch
			{
				overlappedValueTaskSource.Dispose();
				throw;
			}
			overlappedValueTaskSource.FinishedScheduling();
			return new ValueTask<int>(overlappedValueTaskSource, overlappedValueTaskSource.Version);
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0013C0FC File Offset: 0x0013A2FC
		private static ValueTask<long> ReadScatterAtOffsetMultipleSyscallsAsync(SafeFileHandle handle, IReadOnlyList<Memory<byte>> buffers, long fileOffset, CancellationToken cancellationToken)
		{
			RandomAccess.<ReadScatterAtOffsetMultipleSyscallsAsync>d__31 <ReadScatterAtOffsetMultipleSyscallsAsync>d__;
			<ReadScatterAtOffsetMultipleSyscallsAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<long>.Create();
			<ReadScatterAtOffsetMultipleSyscallsAsync>d__.handle = handle;
			<ReadScatterAtOffsetMultipleSyscallsAsync>d__.buffers = buffers;
			<ReadScatterAtOffsetMultipleSyscallsAsync>d__.fileOffset = fileOffset;
			<ReadScatterAtOffsetMultipleSyscallsAsync>d__.cancellationToken = cancellationToken;
			<ReadScatterAtOffsetMultipleSyscallsAsync>d__.<>1__state = -1;
			<ReadScatterAtOffsetMultipleSyscallsAsync>d__.<>t__builder.Start<RandomAccess.<ReadScatterAtOffsetMultipleSyscallsAsync>d__31>(ref <ReadScatterAtOffsetMultipleSyscallsAsync>d__);
			return <ReadScatterAtOffsetMultipleSyscallsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x0013C158 File Offset: 0x0013A358
		private static ValueTask WriteGatherAtOffsetAsync(SafeFileHandle handle, IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset, CancellationToken cancellationToken)
		{
			if (!handle.IsAsync)
			{
				return AsyncOverSyncWithIoCancellation.InvokeAsync<ValueTuple<SafeFileHandle, IReadOnlyList<ReadOnlyMemory<byte>>, long>>(delegate([TupleElementNames(new string[]
				{
					"handle",
					"buffers",
					"fileOffset"
				})] ValueTuple<SafeFileHandle, IReadOnlyList<ReadOnlyMemory<byte>>, long> state)
				{
					RandomAccess.WriteGatherAtOffset(state.Item1, state.Item2, state.Item3);
				}, new ValueTuple<SafeFileHandle, IReadOnlyList<ReadOnlyMemory<byte>>, long>(handle, buffers, fileOffset), cancellationToken);
			}
			MemoryHandle[] handlesToDispose;
			IntPtr segmentsPtr;
			int totalBytes;
			if (RandomAccess.CanUseScatterGatherWindowsAPIs(handle) && RandomAccess.TryPrepareScatterGatherBuffers<ReadOnlyMemory<byte>, RandomAccess.ReadOnlyMemoryHandler>(buffers, out handlesToDispose, out segmentsPtr, out totalBytes))
			{
				return RandomAccess.WriteGatherAtOffsetSingleSyscallAsync(handle, handlesToDispose, segmentsPtr, fileOffset, totalBytes, cancellationToken);
			}
			return RandomAccess.WriteGatherAtOffsetMultipleSyscallsAsync(handle, buffers, fileOffset, cancellationToken);
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x0013C1C8 File Offset: 0x0013A3C8
		private static ValueTask WriteGatherAtOffsetSingleSyscallAsync(SafeFileHandle handle, MemoryHandle[] handlesToDispose, IntPtr segmentsPtr, long fileOffset, int totalBytes, CancellationToken cancellationToken)
		{
			RandomAccess.<WriteGatherAtOffsetSingleSyscallAsync>d__33 <WriteGatherAtOffsetSingleSyscallAsync>d__;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<WriteGatherAtOffsetSingleSyscallAsync>d__.handle = handle;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.handlesToDispose = handlesToDispose;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.segmentsPtr = segmentsPtr;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.fileOffset = fileOffset;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.totalBytes = totalBytes;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.cancellationToken = cancellationToken;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.<>1__state = -1;
			<WriteGatherAtOffsetSingleSyscallAsync>d__.<>t__builder.Start<RandomAccess.<WriteGatherAtOffsetSingleSyscallAsync>d__33>(ref <WriteGatherAtOffsetSingleSyscallAsync>d__);
			return <WriteGatherAtOffsetSingleSyscallAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x0013C238 File Offset: 0x0013A438
		private unsafe static ValueTask WriteFileGatherAsync(SafeFileHandle handle, IntPtr segmentsPtr, int bytesToWrite, long fileOffset, CancellationToken cancellationToken)
		{
			handle.EnsureThreadPoolBindingInitialized();
			SafeFileHandle.OverlappedValueTaskSource overlappedValueTaskSource = handle.GetOverlappedValueTaskSource();
			try
			{
				NativeOverlapped* lpOverlapped = overlappedValueTaskSource.PrepareForOperation(ReadOnlyMemory<byte>.Empty, fileOffset, null);
				if (Interop.Kernel32.WriteFileGather(handle, segmentsPtr, bytesToWrite, IntPtr.Zero, lpOverlapped) == 0)
				{
					int lastWin32ErrorAndDisposeHandleIfInvalid = FileStreamHelpers.GetLastWin32ErrorAndDisposeHandleIfInvalid(handle);
					if (lastWin32ErrorAndDisposeHandleIfInvalid != 997)
					{
						overlappedValueTaskSource.Dispose();
						return ValueTask.FromException(SafeFileHandle.OverlappedValueTaskSource.GetIOError(lastWin32ErrorAndDisposeHandleIfInvalid, null));
					}
					overlappedValueTaskSource.RegisterForCancellation(cancellationToken);
				}
			}
			catch
			{
				overlappedValueTaskSource.Dispose();
				throw;
			}
			overlappedValueTaskSource.FinishedScheduling();
			return new ValueTask(overlappedValueTaskSource, overlappedValueTaskSource.Version);
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x0013C2D0 File Offset: 0x0013A4D0
		private static ValueTask WriteGatherAtOffsetMultipleSyscallsAsync(SafeFileHandle handle, IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset, CancellationToken cancellationToken)
		{
			RandomAccess.<WriteGatherAtOffsetMultipleSyscallsAsync>d__35 <WriteGatherAtOffsetMultipleSyscallsAsync>d__;
			<WriteGatherAtOffsetMultipleSyscallsAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<WriteGatherAtOffsetMultipleSyscallsAsync>d__.handle = handle;
			<WriteGatherAtOffsetMultipleSyscallsAsync>d__.buffers = buffers;
			<WriteGatherAtOffsetMultipleSyscallsAsync>d__.fileOffset = fileOffset;
			<WriteGatherAtOffsetMultipleSyscallsAsync>d__.cancellationToken = cancellationToken;
			<WriteGatherAtOffsetMultipleSyscallsAsync>d__.<>1__state = -1;
			<WriteGatherAtOffsetMultipleSyscallsAsync>d__.<>t__builder.Start<RandomAccess.<WriteGatherAtOffsetMultipleSyscallsAsync>d__35>(ref <WriteGatherAtOffsetMultipleSyscallsAsync>d__);
			return <WriteGatherAtOffsetMultipleSyscallsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x0013C32C File Offset: 0x0013A52C
		private unsafe static NativeOverlapped* GetNativeOverlappedForAsyncHandle(SafeFileHandle handle, long fileOffset, RandomAccess.CallbackResetEvent resetEvent)
		{
			NativeOverlapped* ptr = handle.ThreadPoolBinding.UnsafeAllocateNativeOverlapped(RandomAccess.s_callback, resetEvent, null);
			if (handle.CanSeek)
			{
				ptr->OffsetLow = (int)fileOffset;
				ptr->OffsetHigh = (int)(fileOffset >> 32);
			}
			ptr->EventHandle = resetEvent.SafeWaitHandle.DangerousGetHandle();
			return ptr;
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x0013C37C File Offset: 0x0013A57C
		private static NativeOverlapped GetNativeOverlappedForSyncHandle(SafeFileHandle handle, long fileOffset)
		{
			NativeOverlapped result = default(NativeOverlapped);
			if (handle.CanSeek)
			{
				result.OffsetLow = (int)fileOffset;
				result.OffsetHigh = (int)(fileOffset >> 32);
			}
			return result;
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x0013C3AF File Offset: 0x0013A5AF
		private static IOCompletionCallback AllocateCallback()
		{
			return new IOCompletionCallback(RandomAccess.<AllocateCallback>g__Callback|38_0);
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x0013C3C0 File Offset: 0x0013A5C0
		internal static bool IsEndOfFile(int errorCode, SafeFileHandle handle, long fileOffset)
		{
			if (errorCode <= 87)
			{
				if (errorCode != 38)
				{
					if (errorCode != 87)
					{
						return false;
					}
					if (!RandomAccess.IsEndOfFileForNoBuffering(handle, fileOffset))
					{
						return false;
					}
				}
			}
			else if (errorCode != 109 && errorCode != 233)
			{
				return false;
			}
			return true;
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x0013C3FB File Offset: 0x0013A5FB
		private static bool IsEndOfFileForNoBuffering(SafeFileHandle fileHandle, long fileOffset)
		{
			return fileHandle.IsNoBuffering && fileHandle.CanSeek && fileOffset >= fileHandle.GetFileLength();
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x0013C427 File Offset: 0x0013A627
		[CompilerGenerated]
		internal unsafe static void <AllocateCallback>g__Callback|38_0(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
		{
			((RandomAccess.CallbackResetEvent)ThreadPoolBoundHandle.GetNativeOverlappedState(pOverlapped)).ReleaseRefCount(pOverlapped);
		}

		// Token: 0x04001BE5 RID: 7141
		private static readonly IOCompletionCallback s_callback = RandomAccess.AllocateCallback();

		// Token: 0x0200080B RID: 2059
		private sealed class CallbackResetEvent : EventWaitHandle
		{
			// Token: 0x060083E4 RID: 33764 RVA: 0x0013C43A File Offset: 0x0013A63A
			internal CallbackResetEvent(ThreadPoolBoundHandle threadPoolBoundHandle) : base(false, EventResetMode.ManualReset)
			{
				this._threadPoolBoundHandle = threadPoolBoundHandle;
			}

			// Token: 0x060083E5 RID: 33765 RVA: 0x0013C452 File Offset: 0x0013A652
			internal unsafe void ReleaseRefCount(NativeOverlapped* pOverlapped)
			{
				if (Interlocked.Decrement(ref this._freeWhenZero) == 0)
				{
					this._threadPoolBoundHandle.FreeNativeOverlapped(pOverlapped);
				}
			}

			// Token: 0x04001BE6 RID: 7142
			private readonly ThreadPoolBoundHandle _threadPoolBoundHandle;

			// Token: 0x04001BE7 RID: 7143
			private int _freeWhenZero = 2;
		}

		// Token: 0x0200080C RID: 2060
		private interface IMemoryHandler<T>
		{
			// Token: 0x060083E6 RID: 33766
			public abstract static int GetLength(in T memory);

			// Token: 0x060083E7 RID: 33767
			public abstract static MemoryHandle Pin(in T memory);
		}

		// Token: 0x0200080D RID: 2061
		private readonly struct MemoryHandler : RandomAccess.IMemoryHandler<Memory<byte>>
		{
			// Token: 0x060083E8 RID: 33768 RVA: 0x0013C46D File Offset: 0x0013A66D
			public static int GetLength(in Memory<byte> memory)
			{
				return memory.Length;
			}

			// Token: 0x060083E9 RID: 33769 RVA: 0x0013C475 File Offset: 0x0013A675
			public static MemoryHandle Pin(in Memory<byte> memory)
			{
				return memory.Pin();
			}

			// Token: 0x060083EA RID: 33770 RVA: 0x0013C47D File Offset: 0x0013A67D
			int RandomAccess.IMemoryHandler<Memory<byte>>.GetLength(in Memory<byte> memory)
			{
				return RandomAccess.MemoryHandler.GetLength(memory);
			}

			// Token: 0x060083EB RID: 33771 RVA: 0x0013C485 File Offset: 0x0013A685
			MemoryHandle RandomAccess.IMemoryHandler<Memory<byte>>.Pin(in Memory<byte> memory)
			{
				return RandomAccess.MemoryHandler.Pin(memory);
			}
		}

		// Token: 0x0200080E RID: 2062
		private readonly struct ReadOnlyMemoryHandler : RandomAccess.IMemoryHandler<ReadOnlyMemory<byte>>
		{
			// Token: 0x060083EC RID: 33772 RVA: 0x0013C48D File Offset: 0x0013A68D
			public static int GetLength(in ReadOnlyMemory<byte> memory)
			{
				return memory.Length;
			}

			// Token: 0x060083ED RID: 33773 RVA: 0x0013C495 File Offset: 0x0013A695
			public static MemoryHandle Pin(in ReadOnlyMemory<byte> memory)
			{
				return memory.Pin();
			}

			// Token: 0x060083EE RID: 33774 RVA: 0x0013C49D File Offset: 0x0013A69D
			int RandomAccess.IMemoryHandler<ReadOnlyMemory<byte>>.GetLength(in ReadOnlyMemory<byte> memory)
			{
				return RandomAccess.ReadOnlyMemoryHandler.GetLength(memory);
			}

			// Token: 0x060083EF RID: 33775 RVA: 0x0013C4A5 File Offset: 0x0013A6A5
			MemoryHandle RandomAccess.IMemoryHandler<ReadOnlyMemory<byte>>.Pin(in ReadOnlyMemory<byte> memory)
			{
				return RandomAccess.ReadOnlyMemoryHandler.Pin(memory);
			}
		}
	}
}
