using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774E RID: 30542
	public class ISequenceUnlockPointsT
	{
		// Token: 0x1700DFE4 RID: 57316
		// (get) Token: 0x060359A2 RID: 219554 RVA: 0x0072F423 File Offset: 0x0072D623
		// (set) Token: 0x060359A3 RID: 219555 RVA: 0x0072F42B File Offset: 0x0072D62B
		public EInteractUnlockType Type { get; set; }

		// Token: 0x1700DFE5 RID: 57317
		// (get) Token: 0x060359A4 RID: 219556 RVA: 0x0072F434 File Offset: 0x0072D634
		// (set) Token: 0x060359A5 RID: 219557 RVA: 0x0072F43C File Offset: 0x0072D63C
		public List<ISequenceInteractStageT> Stages { get; set; }

		// Token: 0x060359A6 RID: 219558 RVA: 0x0072F445 File Offset: 0x0072D645
		public ISequenceUnlockPointsT()
		{
			this.Type = EInteractUnlockType.Sequence;
			this.Stages = null;
		}
	}
}
