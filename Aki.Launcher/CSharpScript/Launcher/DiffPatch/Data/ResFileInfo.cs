using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000222 RID: 546
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(ResFileInfoConverter))]
	public class ResFileInfo
	{
		// Token: 0x040008FE RID: 2302
		public string Name = "";

		// Token: 0x040008FF RID: 2303
		public long Size;

		// Token: 0x04000900 RID: 2304
		public string Hash = "";
	}
}
