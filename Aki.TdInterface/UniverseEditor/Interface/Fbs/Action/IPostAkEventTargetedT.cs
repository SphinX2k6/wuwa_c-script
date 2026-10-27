using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7B RID: 28027
	public class IPostAkEventTargetedT
	{
		// Token: 0x1700D122 RID: 53538
		// (get) Token: 0x0603182E RID: 202798 RVA: 0x006B6419 File Offset: 0x006B4619
		// (set) Token: 0x0603182F RID: 202799 RVA: 0x006B6421 File Offset: 0x006B4621
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700D123 RID: 53539
		// (get) Token: 0x06031830 RID: 202800 RVA: 0x006B642A File Offset: 0x006B462A
		// (set) Token: 0x06031831 RID: 202801 RVA: 0x006B6432 File Offset: 0x006B4632
		public int EntityId { get; set; }

		// Token: 0x1700D124 RID: 53540
		// (get) Token: 0x06031832 RID: 202802 RVA: 0x006B643B File Offset: 0x006B463B
		// (set) Token: 0x06031833 RID: 202803 RVA: 0x006B6443 File Offset: 0x006B4643
		public string AkEvent { get; set; }

		// Token: 0x06031834 RID: 202804 RVA: 0x006B644C File Offset: 0x006B464C
		public IPostAkEventTargetedT()
		{
			this.Type = EPostAkEvent.Global;
			this.EntityId = 0;
			this.AkEvent = null;
		}
	}
}
