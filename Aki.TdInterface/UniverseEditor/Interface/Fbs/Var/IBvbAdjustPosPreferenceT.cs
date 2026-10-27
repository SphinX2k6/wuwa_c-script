using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A25 RID: 14885
	public class IBvbAdjustPosPreferenceT
	{
		// Token: 0x17006608 RID: 26120
		// (get) Token: 0x0601421F RID: 82463 RVA: 0x002F1E82 File Offset: 0x002F0082
		// (set) Token: 0x06014220 RID: 82464 RVA: 0x002F1E8A File Offset: 0x002F008A
		public ESystemVarName Type { get; set; }

		// Token: 0x06014221 RID: 82465 RVA: 0x002F1E93 File Offset: 0x002F0093
		public IBvbAdjustPosPreferenceT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
