using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F9 RID: 21497
	public class IInhalationAbilityComponentT
	{
		// Token: 0x17009E32 RID: 40498
		// (get) Token: 0x060234DF RID: 144607 RVA: 0x004E33F1 File Offset: 0x004E15F1
		// (set) Token: 0x060234E0 RID: 144608 RVA: 0x004E33F9 File Offset: 0x004E15F9
		public bool Disabled { get; set; }

		// Token: 0x17009E33 RID: 40499
		// (get) Token: 0x060234E1 RID: 144609 RVA: 0x004E3402 File Offset: 0x004E1602
		// (set) Token: 0x060234E2 RID: 144610 RVA: 0x004E340A File Offset: 0x004E160A
		public List<IInhalationConfigT> InhalationConfigs { get; set; }

		// Token: 0x17009E34 RID: 40500
		// (get) Token: 0x060234E3 RID: 144611 RVA: 0x004E3413 File Offset: 0x004E1613
		// (set) Token: 0x060234E4 RID: 144612 RVA: 0x004E341B File Offset: 0x004E161B
		public byte NullMask { get; set; }

		// Token: 0x060234E5 RID: 144613 RVA: 0x004E3424 File Offset: 0x004E1624
		public IInhalationAbilityComponentT()
		{
			this.Disabled = false;
			this.InhalationConfigs = null;
			this.NullMask = 0;
		}
	}
}
