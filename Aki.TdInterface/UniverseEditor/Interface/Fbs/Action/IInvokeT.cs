using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007065 RID: 28773
	public class IInvokeT
	{
		// Token: 0x1700D2BD RID: 53949
		// (get) Token: 0x06031E55 RID: 204373 RVA: 0x006C0FCF File Offset: 0x006BF1CF
		// (set) Token: 0x06031E56 RID: 204374 RVA: 0x006C0FD7 File Offset: 0x006BF1D7
		public int Who { get; set; }

		// Token: 0x1700D2BE RID: 53950
		// (get) Token: 0x06031E57 RID: 204375 RVA: 0x006C0FE0 File Offset: 0x006BF1E0
		// (set) Token: 0x06031E58 RID: 204376 RVA: 0x006C0FE8 File Offset: 0x006BF1E8
		public IActionInfoT ActionInfo { get; set; }

		// Token: 0x06031E59 RID: 204377 RVA: 0x006C0FF1 File Offset: 0x006BF1F1
		public IInvokeT()
		{
			this.Who = 0;
			this.ActionInfo = null;
		}
	}
}
