using System;
using System.ComponentModel;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;

namespace System.IO
{
	// Token: 0x020007FD RID: 2045
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
	{
		// Token: 0x06008302 RID: 33538 RVA: 0x001387C5 File Offset: 0x001369C5
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected FileSystemInfo(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06008303 RID: 33539 RVA: 0x001387D9 File Offset: 0x001369D9
		internal void Invalidate()
		{
			this._linkTargetIsValid = false;
			this.InvalidateCore();
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06008305 RID: 33541 RVA: 0x001387E8 File Offset: 0x001369E8
		public virtual string FullName
		{
			get
			{
				return this.FullPath;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06008306 RID: 33542 RVA: 0x001387F0 File Offset: 0x001369F0
		public string Extension
		{
			get
			{
				int length = this.FullPath.Length;
				int num = length;
				while (--num >= 0)
				{
					char c = this.FullPath[num];
					if (c == '.')
					{
						return this.FullPath.Substring(num, length - num);
					}
					if (PathInternal.IsDirectorySeparator(c) || c == Path.VolumeSeparatorChar)
					{
						break;
					}
				}
				return string.Empty;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06008307 RID: 33543
		public abstract string Name { get; }

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06008308 RID: 33544
		public abstract bool Exists { get; }

		// Token: 0x06008309 RID: 33545
		public abstract void Delete();

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x0600830A RID: 33546 RVA: 0x0013884C File Offset: 0x00136A4C
		// (set) Token: 0x0600830B RID: 33547 RVA: 0x00138867 File Offset: 0x00136A67
		public DateTime CreationTime
		{
			get
			{
				return this.CreationTimeUtc.ToLocalTime();
			}
			set
			{
				this.CreationTimeUtc = value.ToUniversalTime();
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x0600830C RID: 33548 RVA: 0x00138878 File Offset: 0x00136A78
		// (set) Token: 0x0600830D RID: 33549 RVA: 0x00138893 File Offset: 0x00136A93
		public DateTime CreationTimeUtc
		{
			get
			{
				return this.CreationTimeCore.UtcDateTime;
			}
			set
			{
				this.CreationTimeCore = File.GetUtcDateTimeOffset(value);
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x0600830E RID: 33550 RVA: 0x001388A4 File Offset: 0x00136AA4
		// (set) Token: 0x0600830F RID: 33551 RVA: 0x001388BF File Offset: 0x00136ABF
		public DateTime LastAccessTime
		{
			get
			{
				return this.LastAccessTimeUtc.ToLocalTime();
			}
			set
			{
				this.LastAccessTimeUtc = value.ToUniversalTime();
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06008310 RID: 33552 RVA: 0x001388D0 File Offset: 0x00136AD0
		// (set) Token: 0x06008311 RID: 33553 RVA: 0x001388EB File Offset: 0x00136AEB
		public DateTime LastAccessTimeUtc
		{
			get
			{
				return this.LastAccessTimeCore.UtcDateTime;
			}
			set
			{
				this.LastAccessTimeCore = File.GetUtcDateTimeOffset(value);
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06008312 RID: 33554 RVA: 0x001388FC File Offset: 0x00136AFC
		// (set) Token: 0x06008313 RID: 33555 RVA: 0x00138917 File Offset: 0x00136B17
		public DateTime LastWriteTime
		{
			get
			{
				return this.LastWriteTimeUtc.ToLocalTime();
			}
			set
			{
				this.LastWriteTimeUtc = value.ToUniversalTime();
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06008314 RID: 33556 RVA: 0x00138928 File Offset: 0x00136B28
		// (set) Token: 0x06008315 RID: 33557 RVA: 0x00138943 File Offset: 0x00136B43
		public DateTime LastWriteTimeUtc
		{
			get
			{
				return this.LastWriteTimeCore.UtcDateTime;
			}
			set
			{
				this.LastWriteTimeCore = File.GetUtcDateTimeOffset(value);
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06008316 RID: 33558 RVA: 0x00138951 File Offset: 0x00136B51
		[Nullable(2)]
		public string LinkTarget
		{
			[NullableContext(2)]
			get
			{
				if (this._linkTargetIsValid)
				{
					return this._linkTarget;
				}
				this._linkTarget = FileSystem.GetLinkTarget(this.FullPath, this is DirectoryInfo);
				this._linkTargetIsValid = true;
				return this._linkTarget;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06008317 RID: 33559 RVA: 0x00138989 File Offset: 0x00136B89
		// (set) Token: 0x06008318 RID: 33560 RVA: 0x0013898D File Offset: 0x00136B8D
		public UnixFileMode UnixFileMode
		{
			get
			{
				return (UnixFileMode)(-1);
			}
			[UnsupportedOSPlatform("windows")]
			set
			{
				this.UnixFileModeCore = value;
			}
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x00138996 File Offset: 0x00136B96
		public void CreateAsSymbolicLink(string pathToTarget)
		{
			FileSystem.VerifyValidPath(pathToTarget, "pathToTarget");
			FileSystem.CreateSymbolicLink(this.OriginalPath, pathToTarget, this is DirectoryInfo);
			this.Invalidate();
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x001389BE File Offset: 0x00136BBE
		[NullableContext(2)]
		public FileSystemInfo ResolveLinkTarget(bool returnFinalTarget)
		{
			return FileSystem.ResolveLinkTarget(this.FullPath, returnFinalTarget, this is DirectoryInfo);
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x001389D5 File Offset: 0x00136BD5
		public override string ToString()
		{
			return this.OriginalPath ?? string.Empty;
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x001389E6 File Offset: 0x00136BE6
		protected FileSystemInfo()
		{
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x001389F8 File Offset: 0x00136BF8
		internal static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData)
		{
			DirectoryInfo directoryInfo = findData.IsDirectory ? new DirectoryInfo(fullPath, null, findData.FileName.ToString(), true) : new FileInfo(fullPath, null, findData.FileName.ToString(), true);
			directoryInfo.Init(findData._info);
			return directoryInfo;
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x00138A53 File Offset: 0x00136C53
		internal void InvalidateCore()
		{
			this._dataInitialized = -1;
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x00138A5C File Offset: 0x00136C5C
		internal unsafe void Init(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
		{
			this._data.dwFileAttributes = (int)info->FileAttributes;
			this._data.ftCreationTime = *(Interop.Kernel32.FILE_TIME*)(&info->CreationTime);
			this._data.ftLastAccessTime = *(Interop.Kernel32.FILE_TIME*)(&info->LastAccessTime);
			this._data.ftLastWriteTime = *(Interop.Kernel32.FILE_TIME*)(&info->LastWriteTime);
			this._data.nFileSizeHigh = (uint)(info->EndOfFile >> 32);
			this._data.nFileSizeLow = (uint)info->EndOfFile;
			this._dataInitialized = 0;
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x00138AED File Offset: 0x00136CED
		// (set) Token: 0x06008321 RID: 33569 RVA: 0x00138B00 File Offset: 0x00136D00
		public FileAttributes Attributes
		{
			get
			{
				this.EnsureDataInitialized();
				return (FileAttributes)this._data.dwFileAttributes;
			}
			set
			{
				FileSystem.SetAttributes(this.FullPath, value);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06008322 RID: 33570 RVA: 0x00138B18 File Offset: 0x00136D18
		internal bool ExistsCore
		{
			get
			{
				if (this._dataInitialized == -1)
				{
					this.RefreshCore();
				}
				return this._dataInitialized == 0 && this._data.dwFileAttributes != -1 && this is DirectoryInfo == ((this._data.dwFileAttributes & 16) == 16);
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06008323 RID: 33571 RVA: 0x00138B6B File Offset: 0x00136D6B
		// (set) Token: 0x06008324 RID: 33572 RVA: 0x00138B83 File Offset: 0x00136D83
		internal DateTimeOffset CreationTimeCore
		{
			get
			{
				this.EnsureDataInitialized();
				return this._data.ftCreationTime.ToDateTimeOffset();
			}
			set
			{
				FileSystem.SetCreationTime(this.FullPath, value, this is DirectoryInfo);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06008325 RID: 33573 RVA: 0x00138BA1 File Offset: 0x00136DA1
		// (set) Token: 0x06008326 RID: 33574 RVA: 0x00138BB9 File Offset: 0x00136DB9
		internal DateTimeOffset LastAccessTimeCore
		{
			get
			{
				this.EnsureDataInitialized();
				return this._data.ftLastAccessTime.ToDateTimeOffset();
			}
			set
			{
				FileSystem.SetLastAccessTime(this.FullPath, value, this is DirectoryInfo);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06008327 RID: 33575 RVA: 0x00138BD7 File Offset: 0x00136DD7
		// (set) Token: 0x06008328 RID: 33576 RVA: 0x00138BEF File Offset: 0x00136DEF
		internal DateTimeOffset LastWriteTimeCore
		{
			get
			{
				this.EnsureDataInitialized();
				return this._data.ftLastWriteTime.ToDateTimeOffset();
			}
			set
			{
				FileSystem.SetLastWriteTime(this.FullPath, value, this is DirectoryInfo);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06008329 RID: 33577 RVA: 0x00138C0D File Offset: 0x00136E0D
		internal long LengthCore
		{
			get
			{
				this.EnsureDataInitialized();
				return (long)((ulong)this._data.nFileSizeHigh << 32 | ((ulong)this._data.nFileSizeLow & (ulong)-1));
			}
		}

		// Token: 0x1700118C RID: 4492
		// (set) Token: 0x0600832A RID: 33578 RVA: 0x00133731 File Offset: 0x00131931
		internal UnixFileMode UnixFileModeCore
		{
			set
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_UnixFileMode);
			}
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x00138C34 File Offset: 0x00136E34
		private void EnsureDataInitialized()
		{
			if (this._dataInitialized == -1)
			{
				this._data = default(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA);
				this.RefreshCore();
			}
			if (this._dataInitialized != 0)
			{
				throw Win32Marshal.GetExceptionForWin32Error(this._dataInitialized, this.FullPath, null);
			}
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x00138C6C File Offset: 0x00136E6C
		public void Refresh()
		{
			this._linkTargetIsValid = false;
			this.RefreshCore();
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x00138C7B File Offset: 0x00136E7B
		private void RefreshCore()
		{
			this._dataInitialized = FileSystem.FillAttributeInfo(this.FullPath, ref this._data, false);
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x0600832E RID: 33582 RVA: 0x00138C95 File Offset: 0x00136E95
		internal string NormalizedPath
		{
			get
			{
				if (!PathInternal.EndsWithPeriodOrSpace(this.FullPath))
				{
					return this.FullPath;
				}
				return PathInternal.EnsureExtendedPrefix(this.FullPath);
			}
		}

		// Token: 0x04001BB5 RID: 7093
		protected string FullPath;

		// Token: 0x04001BB6 RID: 7094
		protected string OriginalPath;

		// Token: 0x04001BB7 RID: 7095
		internal string _name;

		// Token: 0x04001BB8 RID: 7096
		private string _linkTarget;

		// Token: 0x04001BB9 RID: 7097
		private bool _linkTargetIsValid;

		// Token: 0x04001BBA RID: 7098
		private Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data;

		// Token: 0x04001BBB RID: 7099
		private int _dataInitialized = -1;
	}
}
