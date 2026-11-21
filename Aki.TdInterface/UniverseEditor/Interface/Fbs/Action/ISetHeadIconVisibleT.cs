using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C8 RID: 30664
	public class ISetHeadIconVisibleT
	{
		// Token: 0x1700E0CB RID: 57547
		// (get) Token: 0x06035DDB RID: 220635 RVA: 0x007379EF File Offset: 0x00735BEF
		// (set) Token: 0x06035DDC RID: 220636 RVA: 0x007379F7 File Offset: 0x00735BF7
		public THeadStyleUnion HeadStyleConfig { get; set; }

		// Token: 0x1700E0CC RID: 57548
		// (get) Token: 0x06035DDD RID: 220637 RVA: 0x00737A00 File Offset: 0x00735C00
		// (set) Token: 0x06035DDE RID: 220638 RVA: 0x00737A08 File Offset: 0x00735C08
		public bool Visible { get; set; }

		// Token: 0x06035DDF RID: 220639 RVA: 0x00737A11 File Offset: 0x00735C11
		public ISetHeadIconVisibleT()
		{
			this.HeadStyleConfig = null;
			this.Visible = false;
		}
	}
}
