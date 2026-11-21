using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x02000211 RID: 529
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoItem
	{
		// Token: 0x040008BC RID: 2236
		public string PakName = "";

		// Token: 0x040008BD RID: 2237
		[JsonConverter(typeof(TsBigIntJsonConverter))]
		public long PakSize;

		// Token: 0x040008BE RID: 2238
		public string PakHash = "";

		// Token: 0x040008BF RID: 2239
		public string SigName = "";

		// Token: 0x040008C0 RID: 2240
		[JsonConverter(typeof(TsBigIntJsonConverter))]
		public long SigSize;

		// Token: 0x040008C1 RID: 2241
		public string SigHash = "";
	}
}
