using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D95 RID: 15765
	public class ICommonEventEntityStateChangeT
	{
		// Token: 0x17006C6D RID: 27757
		// (get) Token: 0x06015E56 RID: 89686 RVA: 0x003295F4 File Offset: 0x003277F4
		// (set) Token: 0x06015E57 RID: 89687 RVA: 0x003295FC File Offset: 0x003277FC
		public ECommonEventType Type { get; set; }

		// Token: 0x17006C6E RID: 27758
		// (get) Token: 0x06015E58 RID: 89688 RVA: 0x00329605 File Offset: 0x00327805
		// (set) Token: 0x06015E59 RID: 89689 RVA: 0x0032960D File Offset: 0x0032780D
		public int EntityId { get; set; }

		// Token: 0x06015E5A RID: 89690 RVA: 0x00329616 File Offset: 0x00327816
		public ICommonEventEntityStateChangeT()
		{
			this.Type = ECommonEventType.VarValueChange;
			this.EntityId = 0;
		}
	}
}
