using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF0 RID: 28656
	public class IICenterTextFadeOutT
	{
		// Token: 0x1700D1E7 RID: 53735
		// (get) Token: 0x06031A82 RID: 203394 RVA: 0x006BA032 File Offset: 0x006B8232
		// (set) Token: 0x06031A83 RID: 203395 RVA: 0x006BA03A File Offset: 0x006B823A
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x1700D1E8 RID: 53736
		// (get) Token: 0x06031A84 RID: 203396 RVA: 0x006BA043 File Offset: 0x006B8243
		// (set) Token: 0x06031A85 RID: 203397 RVA: 0x006BA04B File Offset: 0x006B824B
		public float FadeInTime { get; set; }

		// Token: 0x1700D1E9 RID: 53737
		// (get) Token: 0x06031A86 RID: 203398 RVA: 0x006BA054 File Offset: 0x006B8254
		// (set) Token: 0x06031A87 RID: 203399 RVA: 0x006BA05C File Offset: 0x006B825C
		public float FadeOutTime { get; set; }

		// Token: 0x06031A88 RID: 203400 RVA: 0x006BA065 File Offset: 0x006B8265
		public IICenterTextFadeOutT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
		}
	}
}
