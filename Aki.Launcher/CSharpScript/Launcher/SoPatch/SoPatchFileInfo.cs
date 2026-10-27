using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000104 RID: 260
	[NullableContext(1)]
	[Nullable(0)]
	public class SoPatchFileInfo
	{
		// Token: 0x040004D0 RID: 1232
		public string Name = "";

		// Token: 0x040004D1 RID: 1233
		public int Size;

		// Token: 0x040004D2 RID: 1234
		public string Hash = "";

		// Token: 0x040004D3 RID: 1235
		public string Md5 = "";

		// Token: 0x040004D4 RID: 1236
		public string DestHash = "";
	}
}
