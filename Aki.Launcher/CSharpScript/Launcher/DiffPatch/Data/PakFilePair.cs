using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022D RID: 557
	[NullableContext(1)]
	[Nullable(0)]
	public class PakFilePair
	{
		// Token: 0x04000922 RID: 2338
		public LocalFileInfo Pak;

		// Token: 0x04000923 RID: 2339
		public LocalFileInfo Sig;

		// Token: 0x04000924 RID: 2340
		public LocalFileInfo Utoc;

		// Token: 0x04000925 RID: 2341
		public LocalFileInfo Ucas;

		// Token: 0x04000926 RID: 2342
		public int MountOrder = 4;
	}
}
