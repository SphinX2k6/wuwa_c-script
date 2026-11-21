using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A1D RID: 31261
	public class ISwingT
	{
		// Token: 0x1700E50E RID: 58638
		// (get) Token: 0x06037146 RID: 225606 RVA: 0x0075C401 File Offset: 0x0075A601
		// (set) Token: 0x06037147 RID: 225607 RVA: 0x0075C409 File Offset: 0x0075A609
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700E50F RID: 58639
		// (get) Token: 0x06037148 RID: 225608 RVA: 0x0075C412 File Offset: 0x0075A612
		// (set) Token: 0x06037149 RID: 225609 RVA: 0x0075C41A File Offset: 0x0075A61A
		public string SwingDa { get; set; }

		// Token: 0x1700E510 RID: 58640
		// (get) Token: 0x0603714A RID: 225610 RVA: 0x0075C423 File Offset: 0x0075A623
		// (set) Token: 0x0603714B RID: 225611 RVA: 0x0075C42B File Offset: 0x0075A62B
		public int EntityId { get; set; }

		// Token: 0x0603714C RID: 225612 RVA: 0x0075C434 File Offset: 0x0075A634
		public ISwingT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.SwingDa = null;
			this.EntityId = 0;
		}
	}
}
