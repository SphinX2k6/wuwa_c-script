using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E67 RID: 24167
	public class IUnlockPanoramaAtlasV2T
	{
		// Token: 0x1700B4B3 RID: 46259
		// (get) Token: 0x0602963B RID: 169531 RVA: 0x005AC4C4 File Offset: 0x005AA6C4
		// (set) Token: 0x0602963C RID: 169532 RVA: 0x005AC4CC File Offset: 0x005AA6CC
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700B4B4 RID: 46260
		// (get) Token: 0x0602963D RID: 169533 RVA: 0x005AC4D5 File Offset: 0x005AA6D5
		// (set) Token: 0x0602963E RID: 169534 RVA: 0x005AC4DD File Offset: 0x005AA6DD
		public int Id { get; set; }

		// Token: 0x0602963F RID: 169535 RVA: 0x005AC4E6 File Offset: 0x005AA6E6
		public IUnlockPanoramaAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
