using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000220 RID: 544
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(PatchManifestConverter))]
	public class PatchManifest
	{
		// Token: 0x040008CA RID: 2250
		public List<ResFileInfo> BaseFiles = new List<ResFileInfo>();

		// Token: 0x040008CB RID: 2251
		public List<ResFileInfo> PatchFiles = new List<ResFileInfo>();

		// Token: 0x040008CC RID: 2252
		public Dictionary<string, List<PatchInfo>> BaseDiffMap = new Dictionary<string, List<PatchInfo>>();

		// Token: 0x040008CD RID: 2253
		public Dictionary<string, List<PatchInfo>> CurDiffMap = new Dictionary<string, List<PatchInfo>>();

		// Token: 0x040008CE RID: 2254
		public Dictionary<string, List<PatchInfo>> RevertMap = new Dictionary<string, List<PatchInfo>>();
	}
}
