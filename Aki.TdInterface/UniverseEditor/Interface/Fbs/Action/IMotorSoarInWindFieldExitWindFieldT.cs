using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B40 RID: 27456
	public class IMotorSoarInWindFieldExitWindFieldT
	{
		// Token: 0x1700CC05 RID: 52229
		// (get) Token: 0x06030319 RID: 197401 RVA: 0x0068CB9A File Offset: 0x0068AD9A
		// (set) Token: 0x0603031A RID: 197402 RVA: 0x0068CBA2 File Offset: 0x0068ADA2
		public EMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x0603031B RID: 197403 RVA: 0x0068CBAB File Offset: 0x0068ADAB
		public IMotorSoarInWindFieldExitWindFieldT()
		{
			this.Type = EMotorSoarInWindFieldControlType.EnterWindField;
		}
	}
}
