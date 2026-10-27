using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727E RID: 29310
	public class ISystemFunctionT
	{
		// Token: 0x1700D976 RID: 55670
		// (get) Token: 0x06034015 RID: 213013 RVA: 0x006FE312 File Offset: 0x006FC512
		// (set) Token: 0x06034016 RID: 213014 RVA: 0x006FE31A File Offset: 0x006FC51A
		public ESystemFunction Type { get; set; }

		// Token: 0x06034017 RID: 213015 RVA: 0x006FE323 File Offset: 0x006FC523
		public ISystemFunctionT()
		{
			this.Type = ESystemFunction.BuyGoods;
		}
	}
}
