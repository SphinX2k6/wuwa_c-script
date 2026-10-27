using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006103 RID: 24835
	[NullableContext(1)]
	public interface IRoverlikeGeneralObtainParam
	{
		// Token: 0x1700916D RID: 37229
		// (get) Token: 0x0603EC99 RID: 257177
		// (set) Token: 0x0603EC9A RID: 257178
		List<RoverlikeGainEntry> Entries { get; set; }

		// Token: 0x1700916E RID: 37230
		// (get) Token: 0x0603EC9B RID: 257179
		// (set) Token: 0x0603EC9C RID: 257180
		bool IsLose { get; set; }
	}
}
