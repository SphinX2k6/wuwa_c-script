using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC0 RID: 31936
	public class IUnLockCookSystemItemT
	{
		// Token: 0x1700EF16 RID: 61206
		// (get) Token: 0x060399D0 RID: 235984 RVA: 0x007C61F7 File Offset: 0x007C43F7
		// (set) Token: 0x060399D1 RID: 235985 RVA: 0x007C61FF File Offset: 0x007C43FF
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700EF17 RID: 61207
		// (get) Token: 0x060399D2 RID: 235986 RVA: 0x007C6208 File Offset: 0x007C4408
		// (set) Token: 0x060399D3 RID: 235987 RVA: 0x007C6210 File Offset: 0x007C4410
		public IUnlockCookSystemCookBookT UnlockOption { get; set; }

		// Token: 0x060399D4 RID: 235988 RVA: 0x007C6219 File Offset: 0x007C4419
		public IUnLockCookSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.UnlockOption = null;
		}
	}
}
