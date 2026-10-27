using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743D RID: 29757
	public class ITransitionPopupArtTextT
	{
		// Token: 0x1700E1F1 RID: 57841
		// (get) Token: 0x060360FC RID: 221436 RVA: 0x0075A65F File Offset: 0x0075885F
		// (set) Token: 0x060360FD RID: 221437 RVA: 0x0075A667 File Offset: 0x00758867
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x1700E1F2 RID: 57842
		// (get) Token: 0x060360FE RID: 221438 RVA: 0x0075A670 File Offset: 0x00758870
		// (set) Token: 0x060360FF RID: 221439 RVA: 0x0075A678 File Offset: 0x00758878
		public ITransitionPopupYuanChengArtTextT ArtTextType { get; set; }

		// Token: 0x06036100 RID: 221440 RVA: 0x0075A681 File Offset: 0x00758881
		public ITransitionPopupArtTextT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
			this.ArtTextType = null;
		}
	}
}
