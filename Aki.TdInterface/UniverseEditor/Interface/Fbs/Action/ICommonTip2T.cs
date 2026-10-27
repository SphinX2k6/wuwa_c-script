using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006481 RID: 25729
	public class ICommonTip2T
	{
		// Token: 0x1700BF7A RID: 49018
		// (get) Token: 0x0602C966 RID: 182630 RVA: 0x0061FB51 File Offset: 0x0061DD51
		// (set) Token: 0x0602C967 RID: 182631 RVA: 0x0061FB59 File Offset: 0x0061DD59
		public ICommonTip2PrepareCountdownT TipOption { get; set; }

		// Token: 0x0602C968 RID: 182632 RVA: 0x0061FB62 File Offset: 0x0061DD62
		public ICommonTip2T()
		{
			this.TipOption = null;
		}
	}
}
