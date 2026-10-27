using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005705 RID: 22277
	public class IPatrolActionT
	{
		// Token: 0x1700A5DF RID: 42463
		// (get) Token: 0x060253F5 RID: 152565 RVA: 0x00523D67 File Offset: 0x00521F67
		// (set) Token: 0x060253F6 RID: 152566 RVA: 0x00523D6F File Offset: 0x00521F6F
		public int Point { get; set; }

		// Token: 0x1700A5E0 RID: 42464
		// (get) Token: 0x060253F7 RID: 152567 RVA: 0x00523D78 File Offset: 0x00521F78
		// (set) Token: 0x060253F8 RID: 152568 RVA: 0x00523D80 File Offset: 0x00521F80
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x060253F9 RID: 152569 RVA: 0x00523D89 File Offset: 0x00521F89
		public IPatrolActionT()
		{
			this.Point = 0;
			this.Actions = null;
		}
	}
}
