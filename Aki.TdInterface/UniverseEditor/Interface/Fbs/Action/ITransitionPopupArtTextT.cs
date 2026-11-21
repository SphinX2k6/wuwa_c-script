using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C30 RID: 31792
	public class ITransitionPopupArtTextT
	{
		// Token: 0x1700EE0E RID: 60942
		// (get) Token: 0x060394E5 RID: 234725 RVA: 0x007BD38B File Offset: 0x007BB58B
		// (set) Token: 0x060394E6 RID: 234726 RVA: 0x007BD393 File Offset: 0x007BB593
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x1700EE0F RID: 60943
		// (get) Token: 0x060394E7 RID: 234727 RVA: 0x007BD39C File Offset: 0x007BB59C
		// (set) Token: 0x060394E8 RID: 234728 RVA: 0x007BD3A4 File Offset: 0x007BB5A4
		public ITransitionPopupYuanChengArtTextT ArtTextType { get; set; }

		// Token: 0x060394E9 RID: 234729 RVA: 0x007BD3AD File Offset: 0x007BB5AD
		public ITransitionPopupArtTextT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
			this.ArtTextType = null;
		}
	}
}
