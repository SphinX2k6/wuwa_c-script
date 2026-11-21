using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBA RID: 27834
	public class IEnableAllMotorRadioOperationT
	{
		// Token: 0x1700CC2F RID: 52271
		// (get) Token: 0x0602FF96 RID: 196502 RVA: 0x006878AA File Offset: 0x00685AAA
		// (set) Token: 0x0602FF97 RID: 196503 RVA: 0x006878B2 File Offset: 0x00685AB2
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x0602FF98 RID: 196504 RVA: 0x006878BB File Offset: 0x00685ABB
		public IEnableAllMotorRadioOperationT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
		}
	}
}
