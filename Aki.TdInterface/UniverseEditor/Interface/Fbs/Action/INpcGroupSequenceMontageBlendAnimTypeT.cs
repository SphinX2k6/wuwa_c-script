using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731A RID: 29466
	public class INpcGroupSequenceMontageBlendAnimTypeT
	{
		// Token: 0x1700D7FA RID: 55290
		// (get) Token: 0x06033613 RID: 210451 RVA: 0x006ED848 File Offset: 0x006EBA48
		// (set) Token: 0x06033614 RID: 210452 RVA: 0x006ED850 File Offset: 0x006EBA50
		public ENpcGroupSequenceBlendAnimType Type { get; set; }

		// Token: 0x1700D7FB RID: 55291
		// (get) Token: 0x06033615 RID: 210453 RVA: 0x006ED859 File Offset: 0x006EBA59
		// (set) Token: 0x06033616 RID: 210454 RVA: 0x006ED861 File Offset: 0x006EBA61
		public int MontageId { get; set; }

		// Token: 0x06033617 RID: 210455 RVA: 0x006ED86A File Offset: 0x006EBA6A
		public INpcGroupSequenceMontageBlendAnimTypeT()
		{
			this.Type = ENpcGroupSequenceBlendAnimType.AnimSequence;
			this.MontageId = 0;
		}
	}
}
