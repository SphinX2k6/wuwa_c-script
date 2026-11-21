using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007286 RID: 29318
	public class IMotorSoarInWindFieldExitWindFieldT
	{
		// Token: 0x1700D6EA RID: 55018
		// (get) Token: 0x06033170 RID: 209264 RVA: 0x006E5156 File Offset: 0x006E3356
		// (set) Token: 0x06033171 RID: 209265 RVA: 0x006E515E File Offset: 0x006E335E
		public EMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x06033172 RID: 209266 RVA: 0x006E5167 File Offset: 0x006E3367
		public IMotorSoarInWindFieldExitWindFieldT()
		{
			this.Type = EMotorSoarInWindFieldControlType.EnterWindField;
		}
	}
}
