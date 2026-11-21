using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022B RID: 555
	[NullableContext(1)]
	[Nullable(0)]
	public class PatchParams
	{
		// Token: 0x06000E52 RID: 3666 RVA: 0x00057830 File Offset: 0x00055A30
		public PatchParams(LocalFileInfo diffFile, string oldDir, string newDir, List<LocalFileInfo> oldModify, Dictionary<string, LocalFileInfo> allDestFiles, long copySize, long newRefSize)
		{
			this.DiffFile = diffFile;
			this.OldDir = oldDir;
			this.NewDir = newDir;
			this.OldModify = oldModify;
			this.AllDestFiles = allDestFiles;
			this.CopySize = copySize;
			this.NewRefSize = newRefSize;
		}

		// Token: 0x04000915 RID: 2325
		public bool PatchSuccess;

		// Token: 0x04000916 RID: 2326
		public readonly LocalFileInfo DiffFile;

		// Token: 0x04000917 RID: 2327
		public readonly string OldDir;

		// Token: 0x04000918 RID: 2328
		public readonly string NewDir;

		// Token: 0x04000919 RID: 2329
		public readonly List<LocalFileInfo> OldModify;

		// Token: 0x0400091A RID: 2330
		public readonly Dictionary<string, LocalFileInfo> OldDelete = new Dictionary<string, LocalFileInfo>();

		// Token: 0x0400091B RID: 2331
		public readonly Dictionary<string, LocalFileInfo> AllDestFiles;

		// Token: 0x0400091C RID: 2332
		public readonly long CopySize;

		// Token: 0x0400091D RID: 2333
		public readonly long NewRefSize;
	}
}
