using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D17 RID: 27927
	public class IEnableUiOperationT
	{
		// Token: 0x1700CCE9 RID: 52457
		// (get) Token: 0x060302AA RID: 197290 RVA: 0x0068CC36 File Offset: 0x0068AE36
		// (set) Token: 0x060302AB RID: 197291 RVA: 0x0068CC3E File Offset: 0x0068AE3E
		public EUiOperationType Type { get; set; }

		// Token: 0x060302AC RID: 197292 RVA: 0x0068CC47 File Offset: 0x0068AE47
		public IEnableUiOperationT()
		{
			this.Type = EUiOperationType.Enable;
		}
	}
}
