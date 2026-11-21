using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C46 RID: 23622
	public class IOnMoveWithSplineEndAttachTimingT
	{
		// Token: 0x1700AD83 RID: 44419
		// (get) Token: 0x06027295 RID: 160405 RVA: 0x0055D8B4 File Offset: 0x0055BAB4
		// (set) Token: 0x06027296 RID: 160406 RVA: 0x0055D8BC File Offset: 0x0055BABC
		public EAttachTimingType Type { get; set; }

		// Token: 0x1700AD84 RID: 44420
		// (get) Token: 0x06027297 RID: 160407 RVA: 0x0055D8C5 File Offset: 0x0055BAC5
		// (set) Token: 0x06027298 RID: 160408 RVA: 0x0055D8CD File Offset: 0x0055BACD
		public int SplineEntityId { get; set; }

		// Token: 0x06027299 RID: 160409 RVA: 0x0055D8D6 File Offset: 0x0055BAD6
		public IOnMoveWithSplineEndAttachTimingT()
		{
			this.Type = EAttachTimingType.Default;
			this.SplineEntityId = 0;
		}
	}
}
