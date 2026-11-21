using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C9 RID: 29129
	public class IMinAlertValueT
	{
		// Token: 0x1700D54C RID: 54604
		// (get) Token: 0x06032AAE RID: 207534 RVA: 0x006D8492 File Offset: 0x006D6692
		// (set) Token: 0x06032AAF RID: 207535 RVA: 0x006D849A File Offset: 0x006D669A
		public EValueChangeType Type { get; set; }

		// Token: 0x06032AB0 RID: 207536 RVA: 0x006D84A3 File Offset: 0x006D66A3
		public IMinAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
