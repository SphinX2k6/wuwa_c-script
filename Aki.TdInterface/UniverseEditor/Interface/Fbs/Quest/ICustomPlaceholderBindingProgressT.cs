using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D9 RID: 16857
	public class ICustomPlaceholderBindingProgressT
	{
		// Token: 0x170072E0 RID: 29408
		// (get) Token: 0x0601763C RID: 95804 RVA: 0x00358007 File Offset: 0x00356207
		// (set) Token: 0x0601763D RID: 95805 RVA: 0x0035800F File Offset: 0x0035620F
		public string PlaceHolderName { get; set; }

		// Token: 0x170072E1 RID: 29409
		// (get) Token: 0x0601763E RID: 95806 RVA: 0x00358018 File Offset: 0x00356218
		// (set) Token: 0x0601763F RID: 95807 RVA: 0x00358020 File Offset: 0x00356220
		public IPlayerHavingItemCountT BindingProgressType { get; set; }

		// Token: 0x06017640 RID: 95808 RVA: 0x00358029 File Offset: 0x00356229
		public ICustomPlaceholderBindingProgressT()
		{
			this.PlaceHolderName = null;
			this.BindingProgressType = null;
		}
	}
}
