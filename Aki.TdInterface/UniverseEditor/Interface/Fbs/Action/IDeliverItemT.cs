using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200656B RID: 25963
	public class IDeliverItemT
	{
		// Token: 0x1700C0EE RID: 49390
		// (get) Token: 0x0602D0B8 RID: 184504 RVA: 0x0062E57C File Offset: 0x0062C77C
		// (set) Token: 0x0602D0B9 RID: 184505 RVA: 0x0062E584 File Offset: 0x0062C784
		public int ItemId { get; set; }

		// Token: 0x1700C0EF RID: 49391
		// (get) Token: 0x0602D0BA RID: 184506 RVA: 0x0062E58D File Offset: 0x0062C78D
		// (set) Token: 0x0602D0BB RID: 184507 RVA: 0x0062E595 File Offset: 0x0062C795
		public int Count { get; set; }

		// Token: 0x0602D0BC RID: 184508 RVA: 0x0062E59E File Offset: 0x0062C79E
		public IDeliverItemT()
		{
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}
