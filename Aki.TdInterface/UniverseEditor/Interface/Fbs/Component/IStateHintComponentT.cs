using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FB8 RID: 24504
	public class IStateHintComponentT
	{
		// Token: 0x1700B57C RID: 46460
		// (get) Token: 0x060293AC RID: 168876 RVA: 0x005A0CBD File Offset: 0x0059EEBD
		// (set) Token: 0x060293AD RID: 168877 RVA: 0x005A0CC5 File Offset: 0x0059EEC5
		public bool Disabled { get; set; }

		// Token: 0x1700B57D RID: 46461
		// (get) Token: 0x060293AE RID: 168878 RVA: 0x005A0CCE File Offset: 0x0059EECE
		// (set) Token: 0x060293AF RID: 168879 RVA: 0x005A0CD6 File Offset: 0x0059EED6
		public List<IEntityStateConditionT> ActiveConditions { get; set; }

		// Token: 0x1700B57E RID: 46462
		// (get) Token: 0x060293B0 RID: 168880 RVA: 0x005A0CDF File Offset: 0x0059EEDF
		// (set) Token: 0x060293B1 RID: 168881 RVA: 0x005A0CE7 File Offset: 0x0059EEE7
		public byte NullMask { get; set; }

		// Token: 0x060293B2 RID: 168882 RVA: 0x005A0CF0 File Offset: 0x0059EEF0
		public IStateHintComponentT()
		{
			this.Disabled = false;
			this.ActiveConditions = null;
			this.NullMask = 0;
		}
	}
}
