using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EFD RID: 16125
	public class ILevelPlayInformationViewT
	{
		// Token: 0x17006FDB RID: 28635
		// (get) Token: 0x06016D2E RID: 93486 RVA: 0x0034ABEB File Offset: 0x00348DEB
		// (set) Token: 0x06016D2F RID: 93487 RVA: 0x0034ABF3 File Offset: 0x00348DF3
		public EInformationViewType Type { get; set; }

		// Token: 0x17006FDC RID: 28636
		// (get) Token: 0x06016D30 RID: 93488 RVA: 0x0034ABFC File Offset: 0x00348DFC
		// (set) Token: 0x06016D31 RID: 93489 RVA: 0x0034AC04 File Offset: 0x00348E04
		public List<ILevelPlayInformationT> InformationConfig { get; set; }

		// Token: 0x06016D32 RID: 93490 RVA: 0x0034AC0D File Offset: 0x00348E0D
		public ILevelPlayInformationViewT()
		{
			this.Type = EInformationViewType.LevelPlay;
			this.InformationConfig = null;
		}
	}
}
