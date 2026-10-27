using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E61 RID: 24161
	public class IUnlockGeographicalAtlasV2T
	{
		// Token: 0x1700B4A9 RID: 46249
		// (get) Token: 0x0602960F RID: 169487 RVA: 0x005AC0C4 File Offset: 0x005AA2C4
		// (set) Token: 0x06029610 RID: 169488 RVA: 0x005AC0CC File Offset: 0x005AA2CC
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700B4AA RID: 46250
		// (get) Token: 0x06029611 RID: 169489 RVA: 0x005AC0D5 File Offset: 0x005AA2D5
		// (set) Token: 0x06029612 RID: 169490 RVA: 0x005AC0DD File Offset: 0x005AA2DD
		public int Id { get; set; }

		// Token: 0x06029613 RID: 169491 RVA: 0x005AC0E6 File Offset: 0x005AA2E6
		public IUnlockGeographicalAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
