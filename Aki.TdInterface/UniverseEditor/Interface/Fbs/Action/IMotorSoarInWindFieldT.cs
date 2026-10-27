using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B34 RID: 27444
	public class IMotorSoarInWindFieldT
	{
		// Token: 0x1700CBEE RID: 52206
		// (get) Token: 0x060302BB RID: 197307 RVA: 0x0068C0DD File Offset: 0x0068A2DD
		// (set) Token: 0x060302BC RID: 197308 RVA: 0x0068C0E5 File Offset: 0x0068A2E5
		public TMotorSoarInWindFieldControlTypeUnion ControlType { get; set; }

		// Token: 0x060302BD RID: 197309 RVA: 0x0068C0EE File Offset: 0x0068A2EE
		public IMotorSoarInWindFieldT()
		{
			this.ControlType = null;
		}
	}
}
