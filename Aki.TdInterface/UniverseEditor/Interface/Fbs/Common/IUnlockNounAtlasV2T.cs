using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E64 RID: 24164
	public class IUnlockNounAtlasV2T
	{
		// Token: 0x1700B4AE RID: 46254
		// (get) Token: 0x06029625 RID: 169509 RVA: 0x005AC2C4 File Offset: 0x005AA4C4
		// (set) Token: 0x06029626 RID: 169510 RVA: 0x005AC2CC File Offset: 0x005AA4CC
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700B4AF RID: 46255
		// (get) Token: 0x06029627 RID: 169511 RVA: 0x005AC2D5 File Offset: 0x005AA4D5
		// (set) Token: 0x06029628 RID: 169512 RVA: 0x005AC2DD File Offset: 0x005AA4DD
		public int Id { get; set; }

		// Token: 0x06029629 RID: 169513 RVA: 0x005AC2E6 File Offset: 0x005AA4E6
		public IUnlockNounAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
