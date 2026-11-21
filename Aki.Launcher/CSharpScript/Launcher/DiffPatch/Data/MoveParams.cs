using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022A RID: 554
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveParams
	{
		// Token: 0x06000E51 RID: 3665 RVA: 0x0005781A File Offset: 0x00055A1A
		public MoveParams(LocalFileInfo oldFile, LocalFileInfo newFile)
		{
			this.OldFile = oldFile;
			this.NewFile = newFile;
		}

		// Token: 0x04000913 RID: 2323
		public readonly LocalFileInfo OldFile;

		// Token: 0x04000914 RID: 2324
		public readonly LocalFileInfo NewFile;
	}
}
