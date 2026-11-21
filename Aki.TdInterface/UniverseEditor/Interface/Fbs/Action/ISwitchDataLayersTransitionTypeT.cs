using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A26 RID: 31270
	public class ISwitchDataLayersTransitionTypeT
	{
		// Token: 0x1700E521 RID: 58657
		// (get) Token: 0x060371A4 RID: 225700 RVA: 0x0075CE22 File Offset: 0x0075B022
		// (set) Token: 0x060371A5 RID: 225701 RVA: 0x0075CE2A File Offset: 0x0075B02A
		public ESwitchDataLayersTransitionType Type { get; set; }

		// Token: 0x060371A6 RID: 225702 RVA: 0x0075CE33 File Offset: 0x0075B033
		public ISwitchDataLayersTransitionTypeT()
		{
			this.Type = ESwitchDataLayersTransitionType.Sequence;
		}
	}
}
