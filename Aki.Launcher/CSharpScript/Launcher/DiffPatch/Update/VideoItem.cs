using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x0200020C RID: 524
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoItem
	{
		// Token: 0x0400087B RID: 2171
		public string PakName = "";

		// Token: 0x0400087C RID: 2172
		[JsonConverter(typeof(TsBigIntJsonConverter))]
		public long PakSize;

		// Token: 0x0400087D RID: 2173
		public string PakHash = "";

		// Token: 0x0400087E RID: 2174
		public string SigName = "";

		// Token: 0x0400087F RID: 2175
		[JsonConverter(typeof(TsBigIntJsonConverter))]
		public long SigSize;

		// Token: 0x04000880 RID: 2176
		public string SigHash = "";
	}
}
