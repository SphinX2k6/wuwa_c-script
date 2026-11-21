using System;
using System.Runtime.CompilerServices;

namespace System.IO.Enumeration
{
	// Token: 0x02000867 RID: 2151
	[CompilerFeatureRequired("RefStructs")]
	public ref struct FileSystemEntry
	{
		// Token: 0x06008859 RID: 34905 RVA: 0x0014B698 File Offset: 0x00149898
		[NullableContext(1)]
		public string ToSpecifiedFullPath()
		{
			ReadOnlySpan<char> readOnlySpan = this.Directory.Slice(this.RootDirectory.Length);
			if (Path.EndsInDirectorySeparator(this.OriginalRootDirectory) && PathInternal.StartsWithDirectorySeparator(readOnlySpan))
			{
				readOnlySpan = readOnlySpan.Slice(1);
			}
			return FileSystemEntry.Join(this.OriginalRootDirectory, readOnlySpan, this.FileName);
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x0014B6F2 File Offset: 0x001498F2
		internal unsafe static void Initialize(ref FileSystemEntry entry, Interop.NtDll.FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory)
		{
			entry._info = info;
			entry.Directory = directory;
			entry.RootDirectory = rootDirectory;
			entry.OriginalRootDirectory = originalRootDirectory;
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600885B RID: 34907 RVA: 0x0014B711 File Offset: 0x00149911
		// (set) Token: 0x0600885C RID: 34908 RVA: 0x0014B719 File Offset: 0x00149919
		public ReadOnlySpan<char> Directory { readonly get; private set; }

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x0600885D RID: 34909 RVA: 0x0014B722 File Offset: 0x00149922
		// (set) Token: 0x0600885E RID: 34910 RVA: 0x0014B72A File Offset: 0x0014992A
		public ReadOnlySpan<char> RootDirectory { readonly get; private set; }

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600885F RID: 34911 RVA: 0x0014B733 File Offset: 0x00149933
		// (set) Token: 0x06008860 RID: 34912 RVA: 0x0014B73B File Offset: 0x0014993B
		public ReadOnlySpan<char> OriginalRootDirectory { readonly get; private set; }

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06008861 RID: 34913 RVA: 0x0014B744 File Offset: 0x00149944
		public unsafe ReadOnlySpan<char> FileName
		{
			get
			{
				return this._info->FileName;
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06008862 RID: 34914 RVA: 0x0014B751 File Offset: 0x00149951
		public unsafe FileAttributes Attributes
		{
			get
			{
				return this._info->FileAttributes;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06008863 RID: 34915 RVA: 0x0014B75E File Offset: 0x0014995E
		public unsafe long Length
		{
			get
			{
				return this._info->EndOfFile;
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06008864 RID: 34916 RVA: 0x0014B76B File Offset: 0x0014996B
		public unsafe DateTimeOffset CreationTimeUtc
		{
			get
			{
				return this._info->CreationTime.ToDateTimeOffset();
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06008865 RID: 34917 RVA: 0x0014B77D File Offset: 0x0014997D
		public unsafe DateTimeOffset LastAccessTimeUtc
		{
			get
			{
				return this._info->LastAccessTime.ToDateTimeOffset();
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06008866 RID: 34918 RVA: 0x0014B78F File Offset: 0x0014998F
		public unsafe DateTimeOffset LastWriteTimeUtc
		{
			get
			{
				return this._info->LastWriteTime.ToDateTimeOffset();
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06008867 RID: 34919 RVA: 0x0014B7A1 File Offset: 0x001499A1
		public bool IsDirectory
		{
			get
			{
				return (this.Attributes & FileAttributes.Directory) > FileAttributes.None;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06008868 RID: 34920 RVA: 0x0014B7AF File Offset: 0x001499AF
		public bool IsHidden
		{
			get
			{
				return (this.Attributes & FileAttributes.Hidden) > FileAttributes.None;
			}
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x0014B7BC File Offset: 0x001499BC
		[NullableContext(1)]
		public FileSystemInfo ToFileSystemInfo()
		{
			return FileSystemInfo.Create(Path.Join(this.Directory, this.FileName), ref this);
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x0014B7D5 File Offset: 0x001499D5
		[NullableContext(1)]
		public string ToFullPath()
		{
			return Path.Join(this.Directory, this.FileName);
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x0014B7E8 File Offset: 0x001499E8
		private unsafe static string Join(ReadOnlySpan<char> originalRootDirectory, ReadOnlySpan<char> relativePath, ReadOnlySpan<char> fileName)
		{
			if (originalRootDirectory.Length == 2 && *originalRootDirectory[1] == (ushort)Path.VolumeSeparatorChar)
			{
				return originalRootDirectory + Path.Join(relativePath, fileName);
			}
			return Path.Join(originalRootDirectory, relativePath, fileName);
		}

		// Token: 0x04001DDA RID: 7642
		internal unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _info;
	}
}
