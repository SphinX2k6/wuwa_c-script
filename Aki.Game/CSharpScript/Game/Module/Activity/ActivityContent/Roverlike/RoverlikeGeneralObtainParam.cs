using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005082 RID: 20610
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGeneralObtainParam : IRoverlikeGeneralObtainParam
	{
		// Token: 0x170064D1 RID: 25809
		// (get) Token: 0x0603395F RID: 211295 RVA: 0x00E70A5A File Offset: 0x00E6EC5A
		// (set) Token: 0x06033960 RID: 211296 RVA: 0x00E70A62 File Offset: 0x00E6EC62
		public List<RoverlikeGainEntry> Entries { get; set; } = new List<RoverlikeGainEntry>();

		// Token: 0x170064D2 RID: 25810
		// (get) Token: 0x06033961 RID: 211297 RVA: 0x00E70A6B File Offset: 0x00E6EC6B
		// (set) Token: 0x06033962 RID: 211298 RVA: 0x00E70A73 File Offset: 0x00E6EC73
		public bool IsLose { get; set; }
	}
}
