using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;

namespace System.IO
{
	// Token: 0x020007F3 RID: 2035
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class FileInfo : FileSystemInfo
	{
		// Token: 0x0600824F RID: 33359 RVA: 0x00136542 File Offset: 0x00134742
		public FileInfo(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			this..ctor(fileName, null, null, false);
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x0013655D File Offset: 0x0013475D
		internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			this.OriginalPath = originalPath;
			if (fullPath == null)
			{
				fullPath = originalPath;
			}
			this.FullPath = (isNormalized ? (fullPath ?? originalPath) : Path.GetFullPath(fullPath));
			this._name = fileName;
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06008251 RID: 33361 RVA: 0x00136594 File Offset: 0x00134794
		public override string Name
		{
			get
			{
				string result;
				if ((result = this._name) == null)
				{
					result = (this._name = Path.GetFileName(this.OriginalPath));
				}
				return result;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x001365BF File Offset: 0x001347BF
		public long Length
		{
			get
			{
				if ((base.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
				{
					throw new FileNotFoundException(SR.Format(SR.IO_FileNotFound_FileName, this.FullPath), this.FullPath);
				}
				return base.LengthCore;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06008253 RID: 33363 RVA: 0x001365F0 File Offset: 0x001347F0
		[Nullable(2)]
		public string DirectoryName
		{
			[NullableContext(2)]
			get
			{
				return Path.GetDirectoryName(this.FullPath);
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06008254 RID: 33364 RVA: 0x00136600 File Offset: 0x00134800
		[Nullable(2)]
		public DirectoryInfo Directory
		{
			[NullableContext(2)]
			get
			{
				string directoryName = this.DirectoryName;
				if (directoryName == null)
				{
					return null;
				}
				return new DirectoryInfo(directoryName);
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06008255 RID: 33365 RVA: 0x0013661F File Offset: 0x0013481F
		// (set) Token: 0x06008256 RID: 33366 RVA: 0x0013662C File Offset: 0x0013482C
		public bool IsReadOnly
		{
			get
			{
				return (base.Attributes & FileAttributes.ReadOnly) > FileAttributes.None;
			}
			set
			{
				if (value)
				{
					base.Attributes |= FileAttributes.ReadOnly;
					return;
				}
				base.Attributes &= ~FileAttributes.ReadOnly;
			}
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x0013664F File Offset: 0x0013484F
		public FileStream Open(FileStreamOptions options)
		{
			return File.Open(base.NormalizedPath, options);
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x0013665D File Offset: 0x0013485D
		public StreamReader OpenText()
		{
			return new StreamReader(base.NormalizedPath, Encoding.UTF8, true);
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x00136670 File Offset: 0x00134870
		public StreamWriter CreateText()
		{
			return this.CreateStreamWriter(false);
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x00136679 File Offset: 0x00134879
		public StreamWriter AppendText()
		{
			return this.CreateStreamWriter(true);
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x00136682 File Offset: 0x00134882
		public FileInfo CopyTo(string destFileName)
		{
			return this.CopyTo(destFileName, false);
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x0013668C File Offset: 0x0013488C
		public FileInfo CopyTo(string destFileName, bool overwrite)
		{
			ArgumentException.ThrowIfNullOrEmpty(destFileName, "destFileName");
			string fullPath = Path.GetFullPath(destFileName);
			FileSystem.CopyFile(this.FullPath, fullPath, overwrite);
			return new FileInfo(fullPath, null, null, true);
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x001366C1 File Offset: 0x001348C1
		public FileStream Create()
		{
			FileStream result = File.Create(base.NormalizedPath);
			base.Invalidate();
			return result;
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x001366D4 File Offset: 0x001348D4
		public override void Delete()
		{
			FileSystem.DeleteFile(this.FullPath);
			base.Invalidate();
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x0600825F RID: 33375 RVA: 0x001366E8 File Offset: 0x001348E8
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

		// Token: 0x06008260 RID: 33376 RVA: 0x00136714 File Offset: 0x00134914
		public FileStream Open(FileMode mode)
		{
			return this.Open(mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None);
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x00136726 File Offset: 0x00134926
		public FileStream Open(FileMode mode, FileAccess access)
		{
			return this.Open(mode, access, FileShare.None);
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x00136731 File Offset: 0x00134931
		public FileStream Open(FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStream(base.NormalizedPath, mode, access, share);
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x00136741 File Offset: 0x00134941
		public FileStream OpenRead()
		{
			return new FileStream(base.NormalizedPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, false);
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x00136757 File Offset: 0x00134957
		public FileStream OpenWrite()
		{
			return new FileStream(base.NormalizedPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x00136767 File Offset: 0x00134967
		public void MoveTo(string destFileName)
		{
			this.MoveTo(destFileName, false);
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x00136774 File Offset: 0x00134974
		public void MoveTo(string destFileName, bool overwrite)
		{
			ArgumentException.ThrowIfNullOrEmpty(destFileName, "destFileName");
			string fullPath = Path.GetFullPath(destFileName);
			if (!new DirectoryInfo(Path.GetDirectoryName(this.FullName)).Exists)
			{
				throw new DirectoryNotFoundException(SR.Format(SR.IO_PathNotFound_Path, this.FullName));
			}
			if (!this.Exists)
			{
				throw new FileNotFoundException(SR.Format(SR.IO_FileNotFound_FileName, this.FullName), this.FullName);
			}
			FileSystem.MoveFile(this.FullPath, fullPath, overwrite);
			this.FullPath = fullPath;
			this.OriginalPath = destFileName;
			this._name = Path.GetFileName(fullPath);
			base.Invalidate();
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x00136811 File Offset: 0x00134A11
		public FileInfo Replace(string destinationFileName, [Nullable(2)] string destinationBackupFileName)
		{
			return this.Replace(destinationFileName, destinationBackupFileName, false);
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x0013681C File Offset: 0x00134A1C
		public FileInfo Replace(string destinationFileName, [Nullable(2)] string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			ArgumentNullException.ThrowIfNull(destinationFileName, "destinationFileName");
			FileSystem.ReplaceFile(this.FullPath, Path.GetFullPath(destinationFileName), (destinationBackupFileName != null) ? Path.GetFullPath(destinationBackupFileName) : null, ignoreMetadataErrors);
			return new FileInfo(destinationFileName);
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x0013684D File Offset: 0x00134A4D
		[SupportedOSPlatform("windows")]
		public void Decrypt()
		{
			File.Decrypt(this.FullPath);
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x0013685A File Offset: 0x00134A5A
		[SupportedOSPlatform("windows")]
		public void Encrypt()
		{
			File.Encrypt(this.FullPath);
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x00136867 File Offset: 0x00134A67
		private StreamWriter CreateStreamWriter(bool append)
		{
			StreamWriter result = new StreamWriter(base.NormalizedPath, append);
			base.Invalidate();
			return result;
		}
	}
}
