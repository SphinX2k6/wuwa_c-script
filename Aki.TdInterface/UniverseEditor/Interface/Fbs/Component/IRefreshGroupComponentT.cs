using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582A RID: 22570
	public class IRefreshGroupComponentT
	{
		// Token: 0x1700A89B RID: 43163
		// (get) Token: 0x06025F65 RID: 155493 RVA: 0x0053C01C File Offset: 0x0053A21C
		// (set) Token: 0x06025F66 RID: 155494 RVA: 0x0053C024 File Offset: 0x0053A224
		public bool Disabled { get; set; }

		// Token: 0x1700A89C RID: 43164
		// (get) Token: 0x06025F67 RID: 155495 RVA: 0x0053C02D File Offset: 0x0053A22D
		// (set) Token: 0x06025F68 RID: 155496 RVA: 0x0053C035 File Offset: 0x0053A235
		public List<int> EntityIds { get; set; }

		// Token: 0x1700A89D RID: 43165
		// (get) Token: 0x06025F69 RID: 155497 RVA: 0x0053C03E File Offset: 0x0053A23E
		// (set) Token: 0x06025F6A RID: 155498 RVA: 0x0053C046 File Offset: 0x0053A246
		public TRefreshContentUnion RefreshContent { get; set; }

		// Token: 0x1700A89E RID: 43166
		// (get) Token: 0x06025F6B RID: 155499 RVA: 0x0053C04F File Offset: 0x0053A24F
		// (set) Token: 0x06025F6C RID: 155500 RVA: 0x0053C057 File Offset: 0x0053A257
		public TRefreshRuleUnion RefreshRule { get; set; }

		// Token: 0x1700A89F RID: 43167
		// (get) Token: 0x06025F6D RID: 155501 RVA: 0x0053C060 File Offset: 0x0053A260
		// (set) Token: 0x06025F6E RID: 155502 RVA: 0x0053C068 File Offset: 0x0053A268
		public IStateChangeConfigT StateChangeConfig { get; set; }

		// Token: 0x1700A8A0 RID: 43168
		// (get) Token: 0x06025F6F RID: 155503 RVA: 0x0053C071 File Offset: 0x0053A271
		// (set) Token: 0x06025F70 RID: 155504 RVA: 0x0053C079 File Offset: 0x0053A279
		public byte NullMask { get; set; }

		// Token: 0x06025F71 RID: 155505 RVA: 0x0053C082 File Offset: 0x0053A282
		public IRefreshGroupComponentT()
		{
			this.Disabled = false;
			this.EntityIds = null;
			this.RefreshContent = null;
			this.RefreshRule = null;
			this.StateChangeConfig = null;
			this.NullMask = 0;
		}
	}
}
