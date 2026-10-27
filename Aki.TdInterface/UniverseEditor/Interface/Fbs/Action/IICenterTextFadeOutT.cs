using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693D RID: 26941
	public class IICenterTextFadeOutT
	{
		// Token: 0x1700C7E4 RID: 51172
		// (get) Token: 0x0602F0B2 RID: 192690 RVA: 0x00669B4A File Offset: 0x00667D4A
		// (set) Token: 0x0602F0B3 RID: 192691 RVA: 0x00669B52 File Offset: 0x00667D52
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x1700C7E5 RID: 51173
		// (get) Token: 0x0602F0B4 RID: 192692 RVA: 0x00669B5B File Offset: 0x00667D5B
		// (set) Token: 0x0602F0B5 RID: 192693 RVA: 0x00669B63 File Offset: 0x00667D63
		public float FadeInTime { get; set; }

		// Token: 0x1700C7E6 RID: 51174
		// (get) Token: 0x0602F0B6 RID: 192694 RVA: 0x00669B6C File Offset: 0x00667D6C
		// (set) Token: 0x0602F0B7 RID: 192695 RVA: 0x00669B74 File Offset: 0x00667D74
		public float FadeOutTime { get; set; }

		// Token: 0x0602F0B8 RID: 192696 RVA: 0x00669B7D File Offset: 0x00667D7D
		public IICenterTextFadeOutT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
		}
	}
}
