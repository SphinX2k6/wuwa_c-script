using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200021D RID: 541
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(ResFileInfoConverter))]
	public class ResFileInfo
	{
		// Token: 0x040008BD RID: 2237
		public string Name = "";

		// Token: 0x040008BE RID: 2238
		public long Size;

		// Token: 0x040008BF RID: 2239
		public string Hash = "";
	}
}
