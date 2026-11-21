using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.IO.Enumeration
{
	// Token: 0x02000868 RID: 2152
	public abstract class FileSystemEnumerator<[Nullable(2)] TResult> : CriticalFinalizerObject, IEnumerator<!0>, IDisposable, IEnumerator
	{
		// Token: 0x0600886C RID: 34924 RVA: 0x0014B81F File Offset: 0x00149A1F
		[NullableContext(1)]
		public FileSystemEnumerator(string directory, [Nullable(2)] EnumerationOptions options = null) : this(directory, false, options)
		{
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x0014B82C File Offset: 0x00149A2C
		internal FileSystemEnumerator(string directory, bool isNormalized, EnumerationOptions options = null)
		{
			ArgumentNullException.ThrowIfNull(directory, "directory");
			this._originalRootDirectory = directory;
			string path = isNormalized ? directory : Path.GetFullPath(directory);
			this._rootDirectory = Path.TrimEndingDirectorySeparator(path);
			this._options = (options ?? EnumerationOptions.Default);
			this._remainingRecursionDepth = this._options.MaxRecursionDepth;
			this.Init();
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x000070DD File Offset: 0x000052DD
		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry)
		{
			return true;
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x000070DD File Offset: 0x000052DD
		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
		{
			return true;
		}

		// Token: 0x06008870 RID: 34928
		[NullableContext(1)]
		protected abstract TResult TransformEntry(ref FileSystemEntry entry);

		// Token: 0x06008871 RID: 34929 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory)
		{
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x00007B65 File Offset: 0x00005D65
		protected virtual bool ContinueOnError(int error)
		{
			return false;
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06008873 RID: 34931 RVA: 0x0014B89C File Offset: 0x00149A9C
		[Nullable(1)]
		public TResult Current
		{
			[NullableContext(1)]
			get
			{
				return this._current;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06008874 RID: 34932 RVA: 0x0014B8A4 File Offset: 0x00149AA4
		[Nullable(2)]
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x0014B8B1 File Offset: 0x00149AB1
		private unsafe void DirectoryFinished()
		{
			this._entry = default(Interop.NtDll.FILE_FULL_DIR_INFORMATION*);
			this.CloseDirectoryHandle();
			this.OnDirectoryFinished(this._currentPath.AsSpan());
			if (!this.DequeueNextDirectory())
			{
				this._lastEntryFound = true;
				return;
			}
			this.FindNextEntry();
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x0001A563 File Offset: 0x00018763
		public void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x0014B8EC File Offset: 0x00149AEC
		public void Dispose()
		{
			this.InternalDispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x0014B8FC File Offset: 0x00149AFC
		~FileSystemEnumerator()
		{
			this.InternalDispose(false);
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x0014B92C File Offset: 0x00149B2C
		private void Init()
		{
			using (default(DisableMediaInsertionPrompt))
			{
				this._directoryHandle = this.CreateDirectoryHandle(this._rootDirectory, false);
				if (this._directoryHandle == IntPtr.Zero)
				{
					this._lastEntryFound = true;
				}
			}
			this._currentPath = this._rootDirectory;
			int bufferSize = this._options.BufferSize;
			this._bufferLength = ((bufferSize <= 0) ? 4096 : Math.Max(1024, bufferSize));
			try
			{
				this._buffer = Marshal.AllocHGlobal(this._bufferLength);
			}
			catch
			{
				this.CloseDirectoryHandle();
				throw;
			}
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x0014B9E4 File Offset: 0x00149BE4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe bool GetData()
		{
			Interop.NtDll.IO_STATUS_BLOCK io_STATUS_BLOCK;
			int num = Interop.NtDll.NtQueryDirectoryFile(this._directoryHandle, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, &io_STATUS_BLOCK, this._buffer, (uint)this._bufferLength, Interop.NtDll.FILE_INFORMATION_CLASS.FileFullDirectoryInformation, Interop.BOOLEAN.FALSE, null, Interop.BOOLEAN.FALSE);
			uint num2 = (uint)num;
			if (num2 == 0U)
			{
				return true;
			}
			if (num2 == 2147483654U)
			{
				this.DirectoryFinished();
				return false;
			}
			if (num2 == 3221225487U)
			{
				this.DirectoryFinished();
				return false;
			}
			int num3 = (int)Interop.NtDll.RtlNtStatusToDosError(num);
			if ((num3 == 5 && this._options.IgnoreInaccessible) || this.ContinueOnError(num3))
			{
				this.DirectoryFinished();
				return false;
			}
			throw Win32Marshal.GetExceptionForWin32Error(num3, this._currentPath, null);
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x0014BA80 File Offset: 0x00149C80
		private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<char> relativePath, string fullPath)
		{
			ValueTuple<uint, IntPtr> valueTuple = Interop.NtDll.CreateFile(relativePath, this._directoryHandle, Interop.NtDll.CreateDisposition.FILE_OPEN, Interop.NtDll.DesiredAccess.FILE_READ_DATA | Interop.NtDll.DesiredAccess.SYNCHRONIZE, FileShare.Read | FileShare.Write | FileShare.Delete, FileAttributes.None, (Interop.NtDll.CreateOptions)16417U, Interop.ObjectAttributes.OBJ_CASE_INSENSITIVE, null, 0U, null, null);
			uint item = valueTuple.Item1;
			IntPtr item2 = valueTuple.Item2;
			if (item == 0U)
			{
				return item2;
			}
			int num = (int)Interop.NtDll.RtlNtStatusToDosError((int)item);
			if (this.ContinueOnDirectoryError(num, true))
			{
				return IntPtr.Zero;
			}
			throw Win32Marshal.GetExceptionForWin32Error(num, fullPath, null);
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x0014BAE0 File Offset: 0x00149CE0
		private void CloseDirectoryHandle()
		{
			IntPtr intPtr = Interlocked.Exchange(ref this._directoryHandle, IntPtr.Zero);
			if (intPtr != IntPtr.Zero)
			{
				Interop.Kernel32.CloseHandle(intPtr);
			}
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x0014BB10 File Offset: 0x00149D10
		private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
		{
			IntPtr intPtr = Interop.Kernel32.CreateFile_IntPtr(path, 1, FileShare.Read | FileShare.Write | FileShare.Delete, FileMode.Open, 33554432);
			if (intPtr != IntPtr.Zero && intPtr != (IntPtr)(-1))
			{
				return intPtr;
			}
			int num = Marshal.GetLastPInvokeError();
			if (this.ContinueOnDirectoryError(num, ignoreNotFound))
			{
				return IntPtr.Zero;
			}
			if (num == 2)
			{
				num = 3;
			}
			throw Win32Marshal.GetExceptionForWin32Error(num, path, null);
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x0014BB5F File Offset: 0x00149D5F
		private bool ContinueOnDirectoryError(int error, bool ignoreNotFound)
		{
			return (ignoreNotFound && (error == 2 || error == 3 || error == 267)) || (error == 5 && this._options.IgnoreInaccessible) || this.ContinueOnError(error);
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x0014BB90 File Offset: 0x00149D90
		public unsafe bool MoveNext()
		{
			if (this._lastEntryFound)
			{
				return false;
			}
			FileSystemEntry fileSystemEntry = default(FileSystemEntry);
			object @lock = this._lock;
			bool result;
			lock (@lock)
			{
				if (this._lastEntryFound)
				{
					result = false;
				}
				else
				{
					for (;;)
					{
						this.FindNextEntry();
						if (this._lastEntryFound)
						{
							break;
						}
						FileSystemEntry.Initialize(ref fileSystemEntry, this._entry, this._currentPath.AsSpan(), this._rootDirectory.AsSpan(), this._originalRootDirectory.AsSpan());
						if ((this._entry->FileAttributes & this._options.AttributesToSkip) == FileAttributes.None)
						{
							if ((this._entry->FileAttributes & FileAttributes.Directory) != FileAttributes.None)
							{
								if (this._entry->FileName.Length <= 2 && *this._entry->FileName[0] == 46 && (this._entry->FileName.Length != 2 || *this._entry->FileName[1] == 46))
								{
									if (!this._options.ReturnSpecialDirectories)
									{
										continue;
									}
								}
								else if (this._options.RecurseSubdirectories && this._remainingRecursionDepth > 0 && this.ShouldRecurseIntoEntry(ref fileSystemEntry))
								{
									string text = Path.Join(this._currentPath.AsSpan(), this._entry->FileName);
									IntPtr intPtr = this.CreateRelativeDirectoryHandle(this._entry->FileName, text);
									if (intPtr != IntPtr.Zero)
									{
										try
										{
											if (this._pending == null)
											{
												this._pending = new Queue<ValueTuple<IntPtr, string, int>>();
											}
											this._pending.Enqueue(new ValueTuple<IntPtr, string, int>(intPtr, text, this._remainingRecursionDepth - 1));
										}
										catch
										{
											Interop.Kernel32.CloseHandle(intPtr);
											throw;
										}
									}
								}
							}
							if (this.ShouldIncludeEntry(ref fileSystemEntry))
							{
								goto Block_16;
							}
						}
					}
					return false;
					Block_16:
					this._current = this.TransformEntry(ref fileSystemEntry);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x0014BDB0 File Offset: 0x00149FB0
		private void FindNextEntry()
		{
			this._entry = Interop.NtDll.FILE_FULL_DIR_INFORMATION.GetNextInfo(this._entry);
			if (this._entry != null)
			{
				return;
			}
			if (this.GetData())
			{
				this._entry = this._buffer;
			}
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x0014BDE4 File Offset: 0x00149FE4
		private bool DequeueNextDirectory()
		{
			if (this._pending == null || this._pending.Count == 0)
			{
				return false;
			}
			ValueTuple<IntPtr, string, int> valueTuple = this._pending.Dequeue();
			this._directoryHandle = valueTuple.Item1;
			this._currentPath = valueTuple.Item2;
			this._remainingRecursionDepth = valueTuple.Item3;
			return true;
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x0014BE3C File Offset: 0x0014A03C
		private void InternalDispose(bool disposing)
		{
			if (this._lock != null)
			{
				object @lock = this._lock;
				lock (@lock)
				{
					this._lastEntryFound = true;
					this.CloseDirectoryHandle();
					if (this._pending != null)
					{
						while (this._pending.Count > 0)
						{
							Interop.Kernel32.CloseHandle(this._pending.Dequeue().Item1);
						}
						this._pending = null;
					}
					if (this._buffer != 0)
					{
						Marshal.FreeHGlobal(this._buffer);
					}
					this._buffer = (IntPtr)0;
				}
			}
			this.Dispose(disposing);
		}

		// Token: 0x04001DDE RID: 7646
		private int _remainingRecursionDepth;

		// Token: 0x04001DDF RID: 7647
		private readonly string _originalRootDirectory;

		// Token: 0x04001DE0 RID: 7648
		private readonly string _rootDirectory;

		// Token: 0x04001DE1 RID: 7649
		private readonly EnumerationOptions _options;

		// Token: 0x04001DE2 RID: 7650
		private readonly object _lock = new object();

		// Token: 0x04001DE3 RID: 7651
		private unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _entry;

		// Token: 0x04001DE4 RID: 7652
		private TResult _current;

		// Token: 0x04001DE5 RID: 7653
		private IntPtr _buffer;

		// Token: 0x04001DE6 RID: 7654
		private int _bufferLength;

		// Token: 0x04001DE7 RID: 7655
		private IntPtr _directoryHandle;

		// Token: 0x04001DE8 RID: 7656
		private string _currentPath;

		// Token: 0x04001DE9 RID: 7657
		private bool _lastEntryFound;

		// Token: 0x04001DEA RID: 7658
		[TupleElementNames(new string[]
		{
			"Handle",
			"Path",
			"RemainingDepth"
		})]
		private Queue<ValueTuple<IntPtr, string, int>> _pending;
	}
}
