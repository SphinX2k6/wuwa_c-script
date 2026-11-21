using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000225 RID: 549
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(PatchManifestConverter))]
	public class PatchManifest
	{
		// Token: 0x0400090B RID: 2315
		public List<ResFileInfo> BaseFiles = new List<ResFileInfo>();

		// Token: 0x0400090C RID: 2316
		public List<ResFileInfo> PatchFiles = new List<ResFileInfo>();

		// Token: 0x0400090D RID: 2317
		public Dictionary<string, List<PatchInfo>> BaseDiffMap = new Dictionary<string, List<PatchInfo>>();

		// Token: 0x0400090E RID: 2318
		public Dictionary<string, List<PatchInfo>> CurDiffMap = new Dictionary<string, List<PatchInfo>>();

		// Token: 0x0400090F RID: 2319
		public Dictionary<string, List<PatchInfo>> RevertMap = new Dictionary<string, List<PatchInfo>>();
	}
}
