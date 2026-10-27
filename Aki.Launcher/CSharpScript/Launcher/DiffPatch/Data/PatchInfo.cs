using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200021F RID: 543
	[NullableContext(1)]
	[Nullable(0)]
	public class PatchInfo
	{
		// Token: 0x040008C2 RID: 2242
		public bool Group;

		// Token: 0x040008C3 RID: 2243
		public string GroupName = "";

		// Token: 0x040008C4 RID: 2244
		public ResFileInfo DiffFile;

		// Token: 0x040008C5 RID: 2245
		[JsonConverter(typeof(TsBigIntJsonConverter))]
		public long NewRefSize;

		// Token: 0x040008C6 RID: 2246
		public HashSet<string> NewFiles = new HashSet<string>();

		// Token: 0x040008C7 RID: 2247
		public HashSet<string> DelFiles = new HashSet<string>();

		// Token: 0x040008C8 RID: 2248
		public HashSet<string> ModFiles = new HashSet<string>();

		// Token: 0x040008C9 RID: 2249
		public HashSet<IdenticalPair> SameFiles = new HashSet<IdenticalPair>();
	}
}
