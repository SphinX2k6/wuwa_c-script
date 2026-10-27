using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005737 RID: 22327
	public class IPickInteractComponentT
	{
		// Token: 0x1700A671 RID: 42609
		// (get) Token: 0x06025621 RID: 153121 RVA: 0x00528871 File Offset: 0x00526A71
		// (set) Token: 0x06025622 RID: 153122 RVA: 0x00528879 File Offset: 0x00526A79
		public bool Disabled { get; set; }

		// Token: 0x1700A672 RID: 42610
		// (get) Token: 0x06025623 RID: 153123 RVA: 0x00528882 File Offset: 0x00526A82
		// (set) Token: 0x06025624 RID: 153124 RVA: 0x0052888A File Offset: 0x00526A8A
		public IChessmanPickInteractionT PickInteractType { get; set; }

		// Token: 0x1700A673 RID: 42611
		// (get) Token: 0x06025625 RID: 153125 RVA: 0x00528893 File Offset: 0x00526A93
		// (set) Token: 0x06025626 RID: 153126 RVA: 0x0052889B File Offset: 0x00526A9B
		public byte NullMask { get; set; }

		// Token: 0x06025627 RID: 153127 RVA: 0x005288A4 File Offset: 0x00526AA4
		public IPickInteractComponentT()
		{
			this.Disabled = false;
			this.PickInteractType = null;
			this.NullMask = 0;
		}
	}
}
