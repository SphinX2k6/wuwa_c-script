using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A2 RID: 26786
	public class IBubbleIndexT
	{
		// Token: 0x1700C4D6 RID: 50390
		// (get) Token: 0x0602DCB1 RID: 187569 RVA: 0x0064250B File Offset: 0x0064070B
		// (set) Token: 0x0602DCB2 RID: 187570 RVA: 0x00642513 File Offset: 0x00640713
		public string FlowListName { get; set; }

		// Token: 0x1700C4D7 RID: 50391
		// (get) Token: 0x0602DCB3 RID: 187571 RVA: 0x0064251C File Offset: 0x0064071C
		// (set) Token: 0x0602DCB4 RID: 187572 RVA: 0x00642524 File Offset: 0x00640724
		public int FlowId { get; set; }

		// Token: 0x1700C4D8 RID: 50392
		// (get) Token: 0x0602DCB5 RID: 187573 RVA: 0x0064252D File Offset: 0x0064072D
		// (set) Token: 0x0602DCB6 RID: 187574 RVA: 0x00642535 File Offset: 0x00640735
		public int StateId { get; set; }

		// Token: 0x1700C4D9 RID: 50393
		// (get) Token: 0x0602DCB7 RID: 187575 RVA: 0x0064253E File Offset: 0x0064073E
		// (set) Token: 0x0602DCB8 RID: 187576 RVA: 0x00642546 File Offset: 0x00640746
		public byte NullMask { get; set; }

		// Token: 0x0602DCB9 RID: 187577 RVA: 0x0064254F File Offset: 0x0064074F
		public IBubbleIndexT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
			this.NullMask = 0;
		}
	}
}
