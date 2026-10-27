using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A74 RID: 27252
	public class IMaskTransitionT
	{
		// Token: 0x1700CA32 RID: 51762
		// (get) Token: 0x0602FBB9 RID: 195513 RVA: 0x0067ED6A File Offset: 0x0067CF6A
		// (set) Token: 0x0602FBBA RID: 195514 RVA: 0x0067ED72 File Offset: 0x0067CF72
		public ELevelSequenceTransition Type { get; set; }

		// Token: 0x1700CA33 RID: 51763
		// (get) Token: 0x0602FBBB RID: 195515 RVA: 0x0067ED7B File Offset: 0x0067CF7B
		// (set) Token: 0x0602FBBC RID: 195516 RVA: 0x0067ED83 File Offset: 0x0067CF83
		public float Duration { get; set; }

		// Token: 0x1700CA34 RID: 51764
		// (get) Token: 0x0602FBBD RID: 195517 RVA: 0x0067ED8C File Offset: 0x0067CF8C
		// (set) Token: 0x0602FBBE RID: 195518 RVA: 0x0067ED94 File Offset: 0x0067CF94
		public ETransitionMask Mask { get; set; }

		// Token: 0x1700CA35 RID: 51765
		// (get) Token: 0x0602FBBF RID: 195519 RVA: 0x0067ED9D File Offset: 0x0067CF9D
		// (set) Token: 0x0602FBC0 RID: 195520 RVA: 0x0067EDA5 File Offset: 0x0067CFA5
		public IEaseDataT FadeIn { get; set; }

		// Token: 0x1700CA36 RID: 51766
		// (get) Token: 0x0602FBC1 RID: 195521 RVA: 0x0067EDAE File Offset: 0x0067CFAE
		// (set) Token: 0x0602FBC2 RID: 195522 RVA: 0x0067EDB6 File Offset: 0x0067CFB6
		public IEaseDataT FadeOut { get; set; }

		// Token: 0x1700CA37 RID: 51767
		// (get) Token: 0x0602FBC3 RID: 195523 RVA: 0x0067EDBF File Offset: 0x0067CFBF
		// (set) Token: 0x0602FBC4 RID: 195524 RVA: 0x0067EDC7 File Offset: 0x0067CFC7
		public byte NullMask { get; set; }

		// Token: 0x0602FBC5 RID: 195525 RVA: 0x0067EDD0 File Offset: 0x0067CFD0
		public IMaskTransitionT()
		{
			this.Type = ELevelSequenceTransition.Camera;
			this.Duration = 0f;
			this.Mask = ETransitionMask.BlackMask;
			this.FadeIn = null;
			this.FadeOut = null;
			this.NullMask = 0;
		}
	}
}
