using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006649 RID: 26185
	public class IEnableAllMotorRadioOperationT
	{
		// Token: 0x1700C291 RID: 49809
		// (get) Token: 0x0602D7C5 RID: 186309 RVA: 0x0063AD42 File Offset: 0x00638F42
		// (set) Token: 0x0602D7C6 RID: 186310 RVA: 0x0063AD4A File Offset: 0x00638F4A
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x0602D7C7 RID: 186311 RVA: 0x0063AD53 File Offset: 0x00638F53
		public IEnableAllMotorRadioOperationT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
		}
	}
}
