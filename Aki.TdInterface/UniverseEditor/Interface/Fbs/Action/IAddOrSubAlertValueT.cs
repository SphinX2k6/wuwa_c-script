using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200612F RID: 24879
	public class IAddOrSubAlertValueT
	{
		// Token: 0x1700B75F RID: 46943
		// (get) Token: 0x0602A87F RID: 174207 RVA: 0x005DB450 File Offset: 0x005D9650
		// (set) Token: 0x0602A880 RID: 174208 RVA: 0x005DB458 File Offset: 0x005D9658
		public EValueChangeType Type { get; set; }

		// Token: 0x1700B760 RID: 46944
		// (get) Token: 0x0602A881 RID: 174209 RVA: 0x005DB461 File Offset: 0x005D9661
		// (set) Token: 0x0602A882 RID: 174210 RVA: 0x005DB469 File Offset: 0x005D9669
		public float DeltaValue { get; set; }

		// Token: 0x0602A883 RID: 174211 RVA: 0x005DB472 File Offset: 0x005D9672
		public IAddOrSubAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.DeltaValue = 0f;
		}
	}
}
