using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD7 RID: 23511
	public class INpcPerformOnMonsterClosebyT
	{
		// Token: 0x1700AC0E RID: 44046
		// (get) Token: 0x06026D1A RID: 159002 RVA: 0x00550E73 File Offset: 0x0054F073
		// (set) Token: 0x06026D1B RID: 159003 RVA: 0x00550E7B File Offset: 0x0054F07B
		public float Range { get; set; }

		// Token: 0x1700AC0F RID: 44047
		// (get) Token: 0x06026D1C RID: 159004 RVA: 0x00550E84 File Offset: 0x0054F084
		// (set) Token: 0x06026D1D RID: 159005 RVA: 0x00550E8C File Offset: 0x0054F08C
		public IMontageIdT Montage { get; set; }

		// Token: 0x1700AC10 RID: 44048
		// (get) Token: 0x06026D1E RID: 159006 RVA: 0x00550E95 File Offset: 0x0054F095
		// (set) Token: 0x06026D1F RID: 159007 RVA: 0x00550E9D File Offset: 0x0054F09D
		public IBubbleIndexT Bubble { get; set; }

		// Token: 0x1700AC11 RID: 44049
		// (get) Token: 0x06026D20 RID: 159008 RVA: 0x00550EA6 File Offset: 0x0054F0A6
		// (set) Token: 0x06026D21 RID: 159009 RVA: 0x00550EAE File Offset: 0x0054F0AE
		public int BubbleRate { get; set; }

		// Token: 0x06026D22 RID: 159010 RVA: 0x00550EB7 File Offset: 0x0054F0B7
		public INpcPerformOnMonsterClosebyT()
		{
			this.Range = 0f;
			this.Montage = null;
			this.Bubble = null;
			this.BubbleRate = 0;
		}
	}
}
