using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004691 RID: 18065
	public class ISetTimeT
	{
		// Token: 0x1700803E RID: 32830
		// (get) Token: 0x0601B6DB RID: 112347 RVA: 0x003E57D8 File Offset: 0x003E39D8
		// (set) Token: 0x0601B6DC RID: 112348 RVA: 0x003E57E0 File Offset: 0x003E39E0
		public EGmCommand Type { get; set; }

		// Token: 0x1700803F RID: 32831
		// (get) Token: 0x0601B6DD RID: 112349 RVA: 0x003E57E9 File Offset: 0x003E39E9
		// (set) Token: 0x0601B6DE RID: 112350 RVA: 0x003E57F1 File Offset: 0x003E39F1
		public int Hour { get; set; }

		// Token: 0x17008040 RID: 32832
		// (get) Token: 0x0601B6DF RID: 112351 RVA: 0x003E57FA File Offset: 0x003E39FA
		// (set) Token: 0x0601B6E0 RID: 112352 RVA: 0x003E5802 File Offset: 0x003E3A02
		public int Minute { get; set; }

		// Token: 0x17008041 RID: 32833
		// (get) Token: 0x0601B6E1 RID: 112353 RVA: 0x003E580B File Offset: 0x003E3A0B
		// (set) Token: 0x0601B6E2 RID: 112354 RVA: 0x003E5813 File Offset: 0x003E3A13
		public bool ShowUi { get; set; }

		// Token: 0x0601B6E3 RID: 112355 RVA: 0x003E581C File Offset: 0x003E3A1C
		public ISetTimeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Hour = 0;
			this.Minute = 0;
			this.ShowUi = false;
		}
	}
}
