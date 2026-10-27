using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D1 RID: 26065
	public class IDisableAllMotorRadioOperationT
	{
		// Token: 0x1700C16E RID: 49518
		// (get) Token: 0x0602D346 RID: 185158 RVA: 0x00632472 File Offset: 0x00630672
		// (set) Token: 0x0602D347 RID: 185159 RVA: 0x0063247A File Offset: 0x0063067A
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x0602D348 RID: 185160 RVA: 0x00632483 File Offset: 0x00630683
		public IDisableAllMotorRadioOperationT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
		}
	}
}
