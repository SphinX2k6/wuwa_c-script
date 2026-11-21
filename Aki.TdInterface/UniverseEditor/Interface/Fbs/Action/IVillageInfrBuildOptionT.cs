using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D35 RID: 32053
	public class IVillageInfrBuildOptionT
	{
		// Token: 0x1700EFEB RID: 61419
		// (get) Token: 0x06039DE2 RID: 237026 RVA: 0x007CE8DA File Offset: 0x007CCADA
		// (set) Token: 0x06039DE3 RID: 237027 RVA: 0x007CE8E2 File Offset: 0x007CCAE2
		public EVillageInfrBuildType Type { get; set; }

		// Token: 0x06039DE4 RID: 237028 RVA: 0x007CE8EB File Offset: 0x007CCAEB
		public IVillageInfrBuildOptionT()
		{
			this.Type = EVillageInfrBuildType.Village;
		}
	}
}
