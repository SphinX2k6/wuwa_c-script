using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000229 RID: 553
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalFileInfo
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x00054DB0 File Offset: 0x00052FB0
		public LocalFileInfo(string keyName, string filePath, long expectSize)
		{
			this.KeyName = keyName;
			this.FilePath = filePath;
			this.ExpectSize = expectSize;
			this.LocalSize = UKuroLauncherLibrary.GetFileSize(this.FilePath);
			this.IsChunk0or1 = ChunkTool.IsChunk0or1(this.FilePath);
			this.IsRestartRequiredAfterHotPatchChunk = ChunkTool.IsRestartRequiredAfterHotPatchChunk(this.FilePath);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00054E13 File Offset: 0x00053013
		public virtual long GetSelfSize()
		{
			if (this.LocalSize < 0L)
			{
				return 0L;
			}
			return this.LocalSize;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00054E28 File Offset: 0x00053028
		public virtual long GetLocalSize()
		{
			return this.GetSelfSize();
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00054E30 File Offset: 0x00053030
		public virtual bool IsCompleteFile()
		{
			return this.ExpectSize <= 0L || (this.ExpectSize > 0L && this.LocalSize == this.ExpectSize);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00054E58 File Offset: 0x00053058
		public void DeleteSelf()
		{
			if (UBlueprintPathsLibrary.FileExists(this.FilePath))
			{
				UKuroLauncherLibrary.DeleteFile(this.FilePath);
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00054E73 File Offset: 0x00053073
		public virtual void DeleteAll()
		{
			LauncherFileLib.RemoveDownloadFile(this.FilePath);
			this.LocalSize = -1L;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00054E88 File Offset: 0x00053088
		public virtual string GetHash()
		{
			throw new Exception("LocalFileInfo.GetHash is not implement. file:" + this.FilePath);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00054E9F File Offset: 0x0005309F
		public virtual RequireFileInfo GetRequireInfo()
		{
			throw new Exception("LocalFileInfo.GetRequireInfo is not implement. file:" + this.FilePath);
		}

		// Token: 0x040008E5 RID: 2277
		private long LocalSize = -1L;

		// Token: 0x040008E6 RID: 2278
		public readonly bool IsChunk0or1;

		// Token: 0x040008E7 RID: 2279
		public readonly bool IsRestartRequiredAfterHotPatchChunk;

		// Token: 0x040008E8 RID: 2280
		protected readonly string KeyName;

		// Token: 0x040008E9 RID: 2281
		public readonly string FilePath;

		// Token: 0x040008EA RID: 2282
		public readonly long ExpectSize;
	}
}
