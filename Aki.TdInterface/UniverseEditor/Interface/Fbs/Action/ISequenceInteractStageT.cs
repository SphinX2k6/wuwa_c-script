using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F85 RID: 28549
	public class ISequenceInteractStageT
	{
		// Token: 0x1700D40D RID: 54285
		// (get) Token: 0x06032730 RID: 206640 RVA: 0x006CF64B File Offset: 0x006CD84B
		// (set) Token: 0x06032731 RID: 206641 RVA: 0x006CF653 File Offset: 0x006CD853
		public List<TInteractEffectUnion> EnterStageEffects { get; set; }

		// Token: 0x1700D40E RID: 54286
		// (get) Token: 0x06032732 RID: 206642 RVA: 0x006CF65C File Offset: 0x006CD85C
		// (set) Token: 0x06032733 RID: 206643 RVA: 0x006CF664 File Offset: 0x006CD864
		public List<IInteractPointT> InteractPoints { get; set; }

		// Token: 0x1700D40F RID: 54287
		// (get) Token: 0x06032734 RID: 206644 RVA: 0x006CF66D File Offset: 0x006CD86D
		// (set) Token: 0x06032735 RID: 206645 RVA: 0x006CF675 File Offset: 0x006CD875
		public string UiTipText { get; set; }

		// Token: 0x1700D410 RID: 54288
		// (get) Token: 0x06032736 RID: 206646 RVA: 0x006CF67E File Offset: 0x006CD87E
		// (set) Token: 0x06032737 RID: 206647 RVA: 0x006CF686 File Offset: 0x006CD886
		public bool IsResetAfterStageEnd { get; set; }

		// Token: 0x1700D411 RID: 54289
		// (get) Token: 0x06032738 RID: 206648 RVA: 0x006CF68F File Offset: 0x006CD88F
		// (set) Token: 0x06032739 RID: 206649 RVA: 0x006CF697 File Offset: 0x006CD897
		public byte NullMask { get; set; }

		// Token: 0x0603273A RID: 206650 RVA: 0x006CF6A0 File Offset: 0x006CD8A0
		public ISequenceInteractStageT()
		{
			this.EnterStageEffects = null;
			this.InteractPoints = null;
			this.UiTipText = null;
			this.IsResetAfterStageEnd = false;
			this.NullMask = 0;
		}
	}
}
