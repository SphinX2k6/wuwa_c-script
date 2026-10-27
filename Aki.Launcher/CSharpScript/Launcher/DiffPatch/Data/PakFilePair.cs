using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000228 RID: 552
	[NullableContext(1)]
	[Nullable(0)]
	public class PakFilePair
	{
		// Token: 0x040008E0 RID: 2272
		public LocalFileInfo Pak;

		// Token: 0x040008E1 RID: 2273
		public LocalFileInfo Sig;

		// Token: 0x040008E2 RID: 2274
		public LocalFileInfo Utoc;

		// Token: 0x040008E3 RID: 2275
		public LocalFileInfo Ucas;

		// Token: 0x040008E4 RID: 2276
		public int MountOrder = 4;
	}
}
