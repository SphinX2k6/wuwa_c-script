using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022E RID: 558
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalFileInfo
	{
		// Token: 0x06000E55 RID: 3669 RVA: 0x000578B8 File Offset: 0x00055AB8
		public LocalFileInfo(string keyName, string filePath, long expectSize)
		{
			this.KeyName = keyName;
			this.FilePath = filePath;
			this.ExpectSize = expectSize;
			this.LocalSize = UKuroLauncherLibrary.GetFileSize(this.FilePath);
			this.IsChunk0or1 = ChunkTool.IsChunk0or1(this.FilePath);
			this.IsRestartRequiredAfterHotPatchChunk = ChunkTool.IsRestartRequiredAfterHotPatchChunk(this.FilePath);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0005791B File Offset: 0x00055B1B
		public virtual long GetSelfSize()
		{
			if (this.LocalSize < 0L)
			{
				return 0L;
			}
			return this.LocalSize;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00057930 File Offset: 0x00055B30
		public virtual long GetLocalSize()
		{
			return this.GetSelfSize();
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00057938 File Offset: 0x00055B38
		public virtual bool IsCompleteFile()
		{
			return this.ExpectSize <= 0L || (this.ExpectSize > 0L && this.LocalSize == this.ExpectSize);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00057960 File Offset: 0x00055B60
		public void DeleteSelf()
		{
			if (UBlueprintPathsLibrary.FileExists(this.FilePath))
			{
				UKuroLauncherLibrary.DeleteFile(this.FilePath);
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0005797B File Offset: 0x00055B7B
		public virtual void DeleteAll()
		{
			LauncherFileLib.RemoveDownloadFile(this.FilePath);
			this.LocalSize = -1L;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00057990 File Offset: 0x00055B90
		public virtual string GetHash()
		{
			throw new Exception("LocalFileInfo.GetHash is not implement. file:" + this.FilePath);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000579A7 File Offset: 0x00055BA7
		public virtual RequireFileInfo GetRequireInfo()
		{
			throw new Exception("LocalFileInfo.GetRequireInfo is not implement. file:" + this.FilePath);
		}

		// Token: 0x04000927 RID: 2343
		private long LocalSize = -1L;

		// Token: 0x04000928 RID: 2344
		public readonly bool IsChunk0or1;

		// Token: 0x04000929 RID: 2345
		public readonly bool IsRestartRequiredAfterHotPatchChunk;

		// Token: 0x0400092A RID: 2346
		protected readonly string KeyName;

		// Token: 0x0400092B RID: 2347
		public readonly string FilePath;

		// Token: 0x0400092C RID: 2348
		public readonly long ExpectSize;
	}
}
