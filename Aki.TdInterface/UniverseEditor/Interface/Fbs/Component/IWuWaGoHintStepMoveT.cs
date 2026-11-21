using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D2 RID: 25042
	public class IWuWaGoHintStepMoveT
	{
		// Token: 0x1700BAB6 RID: 47798
		// (get) Token: 0x0602A93D RID: 174397 RVA: 0x005CE45F File Offset: 0x005CC65F
		// (set) Token: 0x0602A93E RID: 174398 RVA: 0x005CE467 File Offset: 0x005CC667
		public EWuWaGoHintStepType Type { get; set; }

		// Token: 0x1700BAB7 RID: 47799
		// (get) Token: 0x0602A93F RID: 174399 RVA: 0x005CE470 File Offset: 0x005CC670
		// (set) Token: 0x0602A940 RID: 174400 RVA: 0x005CE478 File Offset: 0x005CC678
		public IVectorInfoT Position { get; set; }

		// Token: 0x0602A941 RID: 174401 RVA: 0x005CE481 File Offset: 0x005CC681
		public IWuWaGoHintStepMoveT()
		{
			this.Type = EWuWaGoHintStepType.Move;
			this.Position = null;
		}
	}
}
