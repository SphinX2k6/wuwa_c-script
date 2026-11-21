using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000224 RID: 548
	[NullableContext(1)]
	[Nullable(0)]
	public class PatchInfo
	{
		// Token: 0x04000903 RID: 2307
		public bool Group;

		// Token: 0x04000904 RID: 2308
		public string GroupName = "";

		// Token: 0x04000905 RID: 2309
		public ResFileInfo DiffFile;

		// Token: 0x04000906 RID: 2310
		[JsonConverter(typeof(TsBigIntJsonConverter))]
		public long NewRefSize;

		// Token: 0x04000907 RID: 2311
		public HashSet<string> NewFiles = new HashSet<string>();

		// Token: 0x04000908 RID: 2312
		public HashSet<string> DelFiles = new HashSet<string>();

		// Token: 0x04000909 RID: 2313
		public HashSet<string> ModFiles = new HashSet<string>();

		// Token: 0x0400090A RID: 2314
		public HashSet<IdenticalPair> SameFiles = new HashSet<IdenticalPair>();
	}
}
