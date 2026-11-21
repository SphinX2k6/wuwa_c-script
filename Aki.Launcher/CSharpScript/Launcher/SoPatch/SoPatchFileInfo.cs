using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000108 RID: 264
	[NullableContext(1)]
	[Nullable(0)]
	public class SoPatchFileInfo
	{
		// Token: 0x0400050B RID: 1291
		public string Name = "";

		// Token: 0x0400050C RID: 1292
		public int Size;

		// Token: 0x0400050D RID: 1293
		public string Hash = "";

		// Token: 0x0400050E RID: 1294
		public string Md5 = "";

		// Token: 0x0400050F RID: 1295
		public string DestHash = "";
	}
}
