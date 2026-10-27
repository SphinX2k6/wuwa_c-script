using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C00 RID: 23552
	public class BossPilingScoreTabInfo : IBossPilingScoreTabInfo
	{
		// Token: 0x17008D88 RID: 36232
		// (get) Token: 0x0603B86E RID: 243822 RVA: 0x00E3213E File Offset: 0x00E3033E
		// (set) Token: 0x0603B86F RID: 243823 RVA: 0x00E32146 File Offset: 0x00E30346
		public int BossHp { get; set; }

		// Token: 0x17008D89 RID: 36233
		// (get) Token: 0x0603B870 RID: 243824 RVA: 0x00E3214F File Offset: 0x00E3034F
		// (set) Token: 0x0603B871 RID: 243825 RVA: 0x00E32157 File Offset: 0x00E30357
		public int Quality { get; set; }

		// Token: 0x17008D8A RID: 36234
		// (get) Token: 0x0603B872 RID: 243826 RVA: 0x00E32160 File Offset: 0x00E30360
		// (set) Token: 0x0603B873 RID: 243827 RVA: 0x00E32168 File Offset: 0x00E30368
		public bool IsAchieve { get; set; }
	}
}
