using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA2 RID: 16290
	public class IPlayerHavingItemCountT
	{
		// Token: 0x170071BD RID: 29117
		// (get) Token: 0x06017470 RID: 95344 RVA: 0x0035B3F4 File Offset: 0x003595F4
		// (set) Token: 0x06017471 RID: 95345 RVA: 0x0035B3FC File Offset: 0x003595FC
		public EBindingProgressType Type { get; set; }

		// Token: 0x170071BE RID: 29118
		// (get) Token: 0x06017472 RID: 95346 RVA: 0x0035B405 File Offset: 0x00359605
		// (set) Token: 0x06017473 RID: 95347 RVA: 0x0035B40D File Offset: 0x0035960D
		public int ItemId { get; set; }

		// Token: 0x06017474 RID: 95348 RVA: 0x0035B416 File Offset: 0x00359616
		public IPlayerHavingItemCountT()
		{
			this.Type = EBindingProgressType.PlayerHavingItemCount;
			this.ItemId = 0;
		}
	}
}
