using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF9 RID: 23289
	public class IMonitorComponentT
	{
		// Token: 0x1700A9FA RID: 43514
		// (get) Token: 0x06026454 RID: 156756 RVA: 0x0053E746 File Offset: 0x0053C946
		// (set) Token: 0x06026455 RID: 156757 RVA: 0x0053E74E File Offset: 0x0053C94E
		public bool Disabled { get; set; }

		// Token: 0x1700A9FB RID: 43515
		// (get) Token: 0x06026456 RID: 156758 RVA: 0x0053E757 File Offset: 0x0053C957
		// (set) Token: 0x06026457 RID: 156759 RVA: 0x0053E75F File Offset: 0x0053C95F
		public IConeTriggerShapeT Range { get; set; }

		// Token: 0x1700A9FC RID: 43516
		// (get) Token: 0x06026458 RID: 156760 RVA: 0x0053E768 File Offset: 0x0053C968
		// (set) Token: 0x06026459 RID: 156761 RVA: 0x0053E770 File Offset: 0x0053C970
		public string AttachPoint { get; set; }

		// Token: 0x1700A9FD RID: 43517
		// (get) Token: 0x0602645A RID: 156762 RVA: 0x0053E779 File Offset: 0x0053C979
		// (set) Token: 0x0602645B RID: 156763 RVA: 0x0053E781 File Offset: 0x0053C981
		public List<string> AvailableStates { get; set; }

		// Token: 0x1700A9FE RID: 43518
		// (get) Token: 0x0602645C RID: 156764 RVA: 0x0053E78A File Offset: 0x0053C98A
		// (set) Token: 0x0602645D RID: 156765 RVA: 0x0053E792 File Offset: 0x0053C992
		public string StateAfterTriggered { get; set; }

		// Token: 0x1700A9FF RID: 43519
		// (get) Token: 0x0602645E RID: 156766 RVA: 0x0053E79B File Offset: 0x0053C99B
		// (set) Token: 0x0602645F RID: 156767 RVA: 0x0053E7A3 File Offset: 0x0053C9A3
		public string StateAfterLeaved { get; set; }

		// Token: 0x1700AA00 RID: 43520
		// (get) Token: 0x06026460 RID: 156768 RVA: 0x0053E7AC File Offset: 0x0053C9AC
		// (set) Token: 0x06026461 RID: 156769 RVA: 0x0053E7B4 File Offset: 0x0053C9B4
		public byte NullMask { get; set; }

		// Token: 0x06026462 RID: 156770 RVA: 0x0053E7BD File Offset: 0x0053C9BD
		public IMonitorComponentT()
		{
			this.Disabled = false;
			this.Range = null;
			this.AttachPoint = null;
			this.AvailableStates = null;
			this.StateAfterTriggered = null;
			this.StateAfterLeaved = null;
			this.NullMask = 0;
		}
	}
}
