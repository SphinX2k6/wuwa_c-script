using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B2 RID: 27058
	public class IInvokeT
	{
		// Token: 0x1700C8B8 RID: 51384
		// (get) Token: 0x0602F479 RID: 193657 RVA: 0x006708CB File Offset: 0x0066EACB
		// (set) Token: 0x0602F47A RID: 193658 RVA: 0x006708D3 File Offset: 0x0066EAD3
		public int Who { get; set; }

		// Token: 0x1700C8B9 RID: 51385
		// (get) Token: 0x0602F47B RID: 193659 RVA: 0x006708DC File Offset: 0x0066EADC
		// (set) Token: 0x0602F47C RID: 193660 RVA: 0x006708E4 File Offset: 0x0066EAE4
		public IActionInfoT ActionInfo { get; set; }

		// Token: 0x0602F47D RID: 193661 RVA: 0x006708ED File Offset: 0x0066EAED
		public IInvokeT()
		{
			this.Who = 0;
			this.ActionInfo = null;
		}
	}
}
