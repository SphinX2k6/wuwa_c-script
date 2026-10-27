using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F88 RID: 28552
	public class ISequenceUnlockPointsT
	{
		// Token: 0x1700D415 RID: 54293
		// (get) Token: 0x06032752 RID: 206674 RVA: 0x006CFA6B File Offset: 0x006CDC6B
		// (set) Token: 0x06032753 RID: 206675 RVA: 0x006CFA73 File Offset: 0x006CDC73
		public EInteractUnlockType Type { get; set; }

		// Token: 0x1700D416 RID: 54294
		// (get) Token: 0x06032754 RID: 206676 RVA: 0x006CFA7C File Offset: 0x006CDC7C
		// (set) Token: 0x06032755 RID: 206677 RVA: 0x006CFA84 File Offset: 0x006CDC84
		public List<ISequenceInteractStageT> Stages { get; set; }

		// Token: 0x06032756 RID: 206678 RVA: 0x006CFA8D File Offset: 0x006CDC8D
		public ISequenceUnlockPointsT()
		{
			this.Type = EInteractUnlockType.Sequence;
			this.Stages = null;
		}
	}
}
