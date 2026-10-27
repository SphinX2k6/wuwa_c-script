using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006104 RID: 24836
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGeneralObtainParam : IRoverlikeGeneralObtainParam
	{
		// Token: 0x1700916F RID: 37231
		// (get) Token: 0x0603EC9D RID: 257181 RVA: 0x00F29C46 File Offset: 0x00F27E46
		// (set) Token: 0x0603EC9E RID: 257182 RVA: 0x00F29C4E File Offset: 0x00F27E4E
		public List<RoverlikeGainEntry> Entries { get; set; } = new List<RoverlikeGainEntry>();

		// Token: 0x17009170 RID: 37232
		// (get) Token: 0x0603EC9F RID: 257183 RVA: 0x00F29C57 File Offset: 0x00F27E57
		// (set) Token: 0x0603ECA0 RID: 257184 RVA: 0x00F29C5F File Offset: 0x00F27E5F
		public bool IsLose { get; set; }
	}
}
