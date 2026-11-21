using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200649B RID: 25755
	public class IUnlockAtlasSystemTypeV2T
	{
		// Token: 0x1700BE0C RID: 48652
		// (get) Token: 0x0602BC85 RID: 179333 RVA: 0x005F4BCA File Offset: 0x005F2DCA
		// (set) Token: 0x0602BC86 RID: 179334 RVA: 0x005F4BD2 File Offset: 0x005F2DD2
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x0602BC87 RID: 179335 RVA: 0x005F4BDB File Offset: 0x005F2DDB
		public IUnlockAtlasSystemTypeV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
		}
	}
}
