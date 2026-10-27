using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007416 RID: 29718
	public class IToggleScanSplineEffectT
	{
		// Token: 0x1700E1AD RID: 57773
		// (get) Token: 0x06035FCB RID: 221131 RVA: 0x0075847A File Offset: 0x0075667A
		// (set) Token: 0x06035FCC RID: 221132 RVA: 0x00758482 File Offset: 0x00756682
		public ETraceSplineOptionType Type { get; set; }

		// Token: 0x06035FCD RID: 221133 RVA: 0x0075848B File Offset: 0x0075668B
		public IToggleScanSplineEffectT()
		{
			this.Type = ETraceSplineOptionType.Open;
		}
	}
}
