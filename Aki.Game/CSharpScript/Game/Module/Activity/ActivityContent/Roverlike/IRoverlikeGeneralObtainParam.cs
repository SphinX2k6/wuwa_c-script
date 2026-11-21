using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005081 RID: 20609
	[NullableContext(1)]
	public interface IRoverlikeGeneralObtainParam
	{
		// Token: 0x170064CF RID: 25807
		// (get) Token: 0x0603395B RID: 211291
		// (set) Token: 0x0603395C RID: 211292
		List<RoverlikeGainEntry> Entries { get; set; }

		// Token: 0x170064D0 RID: 25808
		// (get) Token: 0x0603395D RID: 211293
		// (set) Token: 0x0603395E RID: 211294
		bool IsLose { get; set; }
	}
}
