using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F7 RID: 26359
	public class IExecAlertSystemActionT
	{
		// Token: 0x1700C3E7 RID: 50151
		// (get) Token: 0x0602DD80 RID: 187776 RVA: 0x00644E7D File Offset: 0x0064307D
		// (set) Token: 0x0602DD81 RID: 187777 RVA: 0x00644E85 File Offset: 0x00643085
		public TAlertSystemOptionUnion Option { get; set; }

		// Token: 0x0602DD82 RID: 187778 RVA: 0x00644E8E File Offset: 0x0064308E
		public IExecAlertSystemActionT()
		{
			this.Option = null;
		}
	}
}
