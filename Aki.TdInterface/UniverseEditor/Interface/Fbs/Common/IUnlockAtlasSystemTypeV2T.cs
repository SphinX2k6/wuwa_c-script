using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E5B RID: 24155
	public class IUnlockAtlasSystemTypeV2T
	{
		// Token: 0x1700B4A3 RID: 46243
		// (get) Token: 0x060295E9 RID: 169449 RVA: 0x005ABD22 File Offset: 0x005A9F22
		// (set) Token: 0x060295EA RID: 169450 RVA: 0x005ABD2A File Offset: 0x005A9F2A
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x060295EB RID: 169451 RVA: 0x005ABD33 File Offset: 0x005A9F33
		public IUnlockAtlasSystemTypeV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
		}
	}
}
