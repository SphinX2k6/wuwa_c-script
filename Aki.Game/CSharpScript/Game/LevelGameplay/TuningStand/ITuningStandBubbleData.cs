using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069C7 RID: 27079
	[NullableContext(2)]
	public interface ITuningStandBubbleData
	{
		// Token: 0x1700986C RID: 39020
		// (get) Token: 0x060435F9 RID: 275961
		// (set) Token: 0x060435FA RID: 275962
		float WaitTime { get; set; }

		// Token: 0x1700986D RID: 39021
		// (get) Token: 0x060435FB RID: 275963
		// (set) Token: 0x060435FC RID: 275964
		string MainRoleTex { get; set; }

		// Token: 0x1700986E RID: 39022
		// (get) Token: 0x060435FD RID: 275965
		// (set) Token: 0x060435FE RID: 275966
		string MainRoleTalk { get; set; }

		// Token: 0x1700986F RID: 39023
		// (get) Token: 0x060435FF RID: 275967
		// (set) Token: 0x06043600 RID: 275968
		string FloroTex { get; set; }

		// Token: 0x17009870 RID: 39024
		// (get) Token: 0x06043601 RID: 275969
		// (set) Token: 0x06043602 RID: 275970
		string FloroTalk { get; set; }
	}
}
