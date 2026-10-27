using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EFA RID: 16122
	public class ILevelPlayInformationT
	{
		// Token: 0x17006FD6 RID: 28630
		// (get) Token: 0x06016D12 RID: 93458 RVA: 0x0034A844 File Offset: 0x00348A44
		// (set) Token: 0x06016D13 RID: 93459 RVA: 0x0034A84C File Offset: 0x00348A4C
		public string TidMainTitle { get; set; }

		// Token: 0x17006FD7 RID: 28631
		// (get) Token: 0x06016D14 RID: 93460 RVA: 0x0034A855 File Offset: 0x00348A55
		// (set) Token: 0x06016D15 RID: 93461 RVA: 0x0034A85D File Offset: 0x00348A5D
		public List<IInformationSubTitleT> SubTitles { get; set; }

		// Token: 0x06016D16 RID: 93462 RVA: 0x0034A866 File Offset: 0x00348A66
		public ILevelPlayInformationT()
		{
			this.TidMainTitle = null;
			this.SubTitles = null;
		}
	}
}
