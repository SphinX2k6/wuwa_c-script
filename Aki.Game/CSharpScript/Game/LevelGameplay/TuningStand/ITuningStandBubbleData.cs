using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B23 RID: 23331
	[NullableContext(2)]
	public interface ITuningStandBubbleData
	{
		// Token: 0x17006D4C RID: 27980
		// (get) Token: 0x06039635 RID: 235061
		// (set) Token: 0x06039636 RID: 235062
		float WaitTime { get; set; }

		// Token: 0x17006D4D RID: 27981
		// (get) Token: 0x06039637 RID: 235063
		// (set) Token: 0x06039638 RID: 235064
		string MainRoleTex { get; set; }

		// Token: 0x17006D4E RID: 27982
		// (get) Token: 0x06039639 RID: 235065
		// (set) Token: 0x0603963A RID: 235066
		string MainRoleTalk { get; set; }

		// Token: 0x17006D4F RID: 27983
		// (get) Token: 0x0603963B RID: 235067
		// (set) Token: 0x0603963C RID: 235068
		string FloroTex { get; set; }

		// Token: 0x17006D50 RID: 27984
		// (get) Token: 0x0603963D RID: 235069
		// (set) Token: 0x0603963E RID: 235070
		string FloroTalk { get; set; }
	}
}
