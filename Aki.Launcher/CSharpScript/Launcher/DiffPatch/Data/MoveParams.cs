using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000225 RID: 549
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveParams
	{
		// Token: 0x06000E10 RID: 3600 RVA: 0x00054D26 File Offset: 0x00052F26
		public MoveParams(LocalFileInfo oldFile, LocalFileInfo newFile)
		{
			this.OldFile = oldFile;
			this.NewFile = newFile;
		}

		// Token: 0x040008D2 RID: 2258
		public readonly LocalFileInfo OldFile;

		// Token: 0x040008D3 RID: 2259
		public readonly LocalFileInfo NewFile;
	}
}
