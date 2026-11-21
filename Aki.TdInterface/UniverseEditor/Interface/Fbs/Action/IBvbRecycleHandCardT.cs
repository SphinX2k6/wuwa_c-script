using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C9 RID: 26825
	public class IBvbRecycleHandCardT
	{
		// Token: 0x1700C52B RID: 50475
		// (get) Token: 0x0602DE33 RID: 187955 RVA: 0x0064510E File Offset: 0x0064330E
		// (set) Token: 0x0602DE34 RID: 187956 RVA: 0x00645116 File Offset: 0x00643316
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C52C RID: 50476
		// (get) Token: 0x0602DE35 RID: 187957 RVA: 0x0064511F File Offset: 0x0064331F
		// (set) Token: 0x0602DE36 RID: 187958 RVA: 0x00645127 File Offset: 0x00643327
		public int HandCardIndex { get; set; }

		// Token: 0x1700C52D RID: 50477
		// (get) Token: 0x0602DE37 RID: 187959 RVA: 0x00645130 File Offset: 0x00643330
		// (set) Token: 0x0602DE38 RID: 187960 RVA: 0x00645138 File Offset: 0x00643338
		public byte NullMask { get; set; }

		// Token: 0x0602DE39 RID: 187961 RVA: 0x00645141 File Offset: 0x00643341
		public IBvbRecycleHandCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.HandCardIndex = 0;
			this.NullMask = 0;
		}
	}
}
