using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace System.IO
{
	// Token: 0x020007E2 RID: 2018
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		// Token: 0x0600816F RID: 33135 RVA: 0x00133835 File Offset: 0x00131A35
		public DirectoryInfo(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			this.Init(path, Path.GetFullPath(path), null, true);
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x00133857 File Offset: 0x00131A57
		internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			this.Init(originalPath, fullPath, fileName, isNormalized);
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x0013386A File Offset: 0x00131A6A
		private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			this.OriginalPath = originalPath;
			if (fullPath == null)
			{
				fullPath = originalPath;
			}
			fullPath = (isNormalized ? fullPath : Path.GetFullPath(fullPath));
			this._name = fileName;
			this.FullPath = fullPath;
			this._isNormalized = isNormalized;
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06008172 RID: 33138 RVA: 0x001338A0 File Offset: 0x00131AA0
		public override string Name
		{
			get
			{
				string text = this._name;
				if (text == null)
				{
					ReadOnlySpan<char> readOnlySpan = this.FullPath.AsSpan();
					text = (this._name = (PathInternal.IsRoot(readOnlySpan) ? readOnlySpan : Path.GetFileName(Path.TrimEndingDirectorySeparator(readOnlySpan))).ToString());
				}
				return text;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06008173 RID: 33139 RVA: 0x001338F0 File Offset: 0x00131AF0
		[Nullable(2)]
		public DirectoryInfo Parent
		{
			[NullableContext(2)]
			get
			{
				string directoryName = Path.GetDirectoryName(PathInternal.IsRoot(this.FullPath.AsSpan()) ? this.FullPath : Path.TrimEndingDirectorySeparator(this.FullPath));
				if (directoryName == null)
				{
					return null;
				}
				return new DirectoryInfo(directoryName, null, null, true);
			}
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x00133938 File Offset: 0x00131B38
		public DirectoryInfo CreateSubdirectory(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			if (PathInternal.IsEffectivelyEmpty(path.AsSpan()))
			{
				throw new ArgumentException(SR.Argument_PathEmpty, "path");
			}
			if (Path.IsPathRooted(path))
			{
				throw new ArgumentException(SR.Arg_Path2IsRooted, "path");
			}
			string fullPath = Path.GetFullPath(Path.Combine(this.FullPath, path));
			ReadOnlySpan<char> span = Path.TrimEndingDirectorySeparator(fullPath.AsSpan());
			ReadOnlySpan<char> value = Path.TrimEndingDirectorySeparator(this.FullPath.AsSpan());
			if (span.StartsWith(value, StringComparison.OrdinalIgnoreCase) && (span.Length == value.Length || PathInternal.IsDirectorySeparator(fullPath[value.Length])))
			{
				FileSystem.CreateDirectory(fullPath, null);
				return new DirectoryInfo(fullPath);
			}
			throw new ArgumentException(SR.Format(SR.Argument_InvalidSubPath, path, this.FullPath), "path");
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x00133A0B File Offset: 0x00131C0B
		public void Create()
		{
			FileSystem.CreateDirectory(this.FullPath, null);
			base.Invalidate();
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x00133A1F File Offset: 0x00131C1F
		public FileInfo[] GetFiles()
		{
			return this.GetFiles("*", EnumerationOptions.Compatible);
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x00133A31 File Offset: 0x00131C31
		public FileInfo[] GetFiles(string searchPattern)
		{
			return this.GetFiles(searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x00133A3F File Offset: 0x00131C3F
		public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			return this.GetFiles(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x00133A4E File Offset: 0x00131C4E
		public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return new List<FileInfo>((IEnumerable<FileInfo>)this.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Files, enumerationOptions)).ToArray();
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x00133A6E File Offset: 0x00131C6E
		public FileSystemInfo[] GetFileSystemInfos()
		{
			return this.GetFileSystemInfos("*", EnumerationOptions.Compatible);
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x00133A80 File Offset: 0x00131C80
		public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return this.GetFileSystemInfos(searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x00133A8E File Offset: 0x00131C8E
		public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return this.GetFileSystemInfos(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x00133A9D File Offset: 0x00131C9D
		public FileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return new List<FileSystemInfo>(this.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Both, enumerationOptions)).ToArray();
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x00133AB8 File Offset: 0x00131CB8
		public DirectoryInfo[] GetDirectories()
		{
			return this.GetDirectories("*", EnumerationOptions.Compatible);
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00133ACA File Offset: 0x00131CCA
		public DirectoryInfo[] GetDirectories(string searchPattern)
		{
			return this.GetDirectories(searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x00133AD8 File Offset: 0x00131CD8
		public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			return this.GetDirectories(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x00133AE7 File Offset: 0x00131CE7
		public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return new List<DirectoryInfo>((IEnumerable<DirectoryInfo>)this.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Directories, enumerationOptions)).ToArray();
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x00133B07 File Offset: 0x00131D07
		public IEnumerable<DirectoryInfo> EnumerateDirectories()
		{
			return this.EnumerateDirectories("*", EnumerationOptions.Compatible);
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x00133B19 File Offset: 0x00131D19
		public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern)
		{
			return this.EnumerateDirectories(searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x00133B27 File Offset: 0x00131D27
		public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
		{
			return this.EnumerateDirectories(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x00133B36 File Offset: 0x00131D36
		public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return (IEnumerable<DirectoryInfo>)this.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Directories, enumerationOptions);
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x00133B4C File Offset: 0x00131D4C
		public IEnumerable<FileInfo> EnumerateFiles()
		{
			return this.EnumerateFiles("*", EnumerationOptions.Compatible);
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x00133B5E File Offset: 0x00131D5E
		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern)
		{
			return this.EnumerateFiles(searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x00133B6C File Offset: 0x00131D6C
		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return this.EnumerateFiles(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00133B7B File Offset: 0x00131D7B
		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return (IEnumerable<FileInfo>)this.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Files, enumerationOptions);
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00133B91 File Offset: 0x00131D91
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
		{
			return this.EnumerateFileSystemInfos("*", EnumerationOptions.Compatible);
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x00133BA3 File Offset: 0x00131DA3
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
		{
			return this.EnumerateFileSystemInfos(searchPattern, EnumerationOptions.Compatible);
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x00133BB1 File Offset: 0x00131DB1
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return this.EnumerateFileSystemInfos(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x00133BC0 File Offset: 0x00131DC0
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return this.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Both, enumerationOptions);
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x00133BD4 File Offset: 0x00131DD4
		private IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			ArgumentNullException.ThrowIfNull(searchPattern, "searchPattern");
			this._isNormalized &= FileSystemEnumerableFactory.NormalizeInputs(ref path, ref searchPattern, options.MatchType);
			IEnumerable<FileSystemInfo> result;
			switch (searchTarget)
			{
			case SearchTarget.Files:
				result = FileSystemEnumerableFactory.FileInfos(path, searchPattern, options, this._isNormalized);
				break;
			case SearchTarget.Directories:
				result = FileSystemEnumerableFactory.DirectoryInfos(path, searchPattern, options, this._isNormalized);
				break;
			case SearchTarget.Both:
				result = FileSystemEnumerableFactory.FileSystemInfos(path, searchPattern, options, this._isNormalized);
				break;
			default:
				throw new ArgumentException(SR.ArgumentOutOfRange_Enum, "searchTarget");
			}
			return result;
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x0600818F RID: 33167 RVA: 0x00133C66 File Offset: 0x00131E66
		public DirectoryInfo Root
		{
			get
			{
				return new DirectoryInfo(Path.GetPathRoot(this.FullPath));
			}
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x00133C78 File Offset: 0x00131E78
		public void MoveTo(string destDirName)
		{
			ArgumentException.ThrowIfNullOrEmpty(destDirName, "destDirName");
			string fullPath = Path.GetFullPath(destDirName);
			FileSystem.MoveDirectory(this.FullPath, fullPath);
			this.Init(destDirName, PathInternal.EnsureTrailingSeparator(fullPath), null, true);
			base.Invalidate();
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x00133CB8 File Offset: 0x00131EB8
		public override void Delete()
		{
			this.Delete(false);
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x00133CC1 File Offset: 0x00131EC1
		public void Delete(bool recursive)
		{
			FileSystem.RemoveDirectory(this.FullPath, recursive);
			base.Invalidate();
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06008193 RID: 33171 RVA: 0x00133CD8 File Offset: 0x00131ED8
		public override bool Exists
		{
			get
			{
				bool result;
				try
				{
					result = base.ExistsCore;
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x04001B14 RID: 6932
		private bool _isNormalized;
	}
}
