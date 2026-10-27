using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000226 RID: 550
	[NullableContext(1)]
	[Nullable(0)]
	public class PatchParams
	{
		// Token: 0x06000E11 RID: 3601 RVA: 0x00054D3C File Offset: 0x00052F3C
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

		// Token: 0x040008D4 RID: 2260
		public bool PatchSuccess;

		// Token: 0x040008D5 RID: 2261
		public readonly LocalFileInfo DiffFile;

		// Token: 0x040008D6 RID: 2262
		public readonly string OldDir;

		// Token: 0x040008D7 RID: 2263
		public readonly string NewDir;

		// Token: 0x040008D8 RID: 2264
		public readonly List<LocalFileInfo> OldModify;

		// Token: 0x040008D9 RID: 2265
		public readonly Dictionary<string, LocalFileInfo> AllDestFiles;

		// Token: 0x040008DA RID: 2266
		public readonly long CopySize;

		// Token: 0x040008DB RID: 2267
		public readonly long NewRefSize;
	}
}
