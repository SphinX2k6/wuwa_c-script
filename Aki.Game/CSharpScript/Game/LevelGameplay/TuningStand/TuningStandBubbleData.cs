using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069C8 RID: 27080
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandBubbleData : ITuningStandBubbleData
	{
		// Token: 0x17009871 RID: 39025
		// (get) Token: 0x06043603 RID: 275971 RVA: 0x01076441 File Offset: 0x01074641
		// (set) Token: 0x06043604 RID: 275972 RVA: 0x01076449 File Offset: 0x01074649
		public float WaitTime { get; set; }

		// Token: 0x17009872 RID: 39026
		// (get) Token: 0x06043605 RID: 275973 RVA: 0x01076452 File Offset: 0x01074652
		// (set) Token: 0x06043606 RID: 275974 RVA: 0x0107645A File Offset: 0x0107465A
		public string MainRoleTex { get; set; }

		// Token: 0x17009873 RID: 39027
		// (get) Token: 0x06043607 RID: 275975 RVA: 0x01076463 File Offset: 0x01074663
		// (set) Token: 0x06043608 RID: 275976 RVA: 0x0107646B File Offset: 0x0107466B
		public string MainRoleTalk { get; set; }

		// Token: 0x17009874 RID: 39028
		// (get) Token: 0x06043609 RID: 275977 RVA: 0x01076474 File Offset: 0x01074674
		// (set) Token: 0x0604360A RID: 275978 RVA: 0x0107647C File Offset: 0x0107467C
		public string FloroTex { get; set; }

		// Token: 0x17009875 RID: 39029
		// (get) Token: 0x0604360B RID: 275979 RVA: 0x01076485 File Offset: 0x01074685
		// (set) Token: 0x0604360C RID: 275980 RVA: 0x0107648D File Offset: 0x0107468D
		public string FloroTalk { get; set; }
	}
}
