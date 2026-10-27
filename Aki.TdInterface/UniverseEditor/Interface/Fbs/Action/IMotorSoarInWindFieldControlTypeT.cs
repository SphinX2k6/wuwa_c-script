using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B37 RID: 27447
	public class IMotorSoarInWindFieldControlTypeT
	{
		// Token: 0x1700CBF1 RID: 52209
		// (get) Token: 0x060302CD RID: 197325 RVA: 0x0068C28A File Offset: 0x0068A48A
		// (set) Token: 0x060302CE RID: 197326 RVA: 0x0068C292 File Offset: 0x0068A492
		public EMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x060302CF RID: 197327 RVA: 0x0068C29B File Offset: 0x0068A49B
		public IMotorSoarInWindFieldControlTypeT()
		{
			this.Type = EMotorSoarInWindFieldControlType.EnterWindField;
		}
	}
}
