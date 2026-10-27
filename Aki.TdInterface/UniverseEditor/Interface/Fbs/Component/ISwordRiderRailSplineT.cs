using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A14 RID: 23060
	public class ISwordRiderRailSplineT
	{
		// Token: 0x1700AD4F RID: 44367
		// (get) Token: 0x06027289 RID: 160393 RVA: 0x00563014 File Offset: 0x00561214
		// (set) Token: 0x0602728A RID: 160394 RVA: 0x0056301C File Offset: 0x0056121C
		public ESplineType Type { get; set; }

		// Token: 0x1700AD50 RID: 44368
		// (get) Token: 0x0602728B RID: 160395 RVA: 0x00563025 File Offset: 0x00561225
		// (set) Token: 0x0602728C RID: 160396 RVA: 0x0056302D File Offset: 0x0056122D
		public ESwordRiderRailWall WallType { get; set; }

		// Token: 0x1700AD51 RID: 44369
		// (get) Token: 0x0602728D RID: 160397 RVA: 0x00563036 File Offset: 0x00561236
		// (set) Token: 0x0602728E RID: 160398 RVA: 0x0056303E File Offset: 0x0056123E
		public string PathEffect { get; set; }

		// Token: 0x1700AD52 RID: 44370
		// (get) Token: 0x0602728F RID: 160399 RVA: 0x00563047 File Offset: 0x00561247
		// (set) Token: 0x06027290 RID: 160400 RVA: 0x0056304F File Offset: 0x0056124F
		public List<ISwordRiderRailSplinePointT> Points { get; set; }

		// Token: 0x06027291 RID: 160401 RVA: 0x00563058 File Offset: 0x00561258
		public ISwordRiderRailSplineT()
		{
			this.Type = ESplineType.Common;
			this.WallType = ESwordRiderRailWall.Inner;
			this.PathEffect = null;
			this.Points = null;
		}
	}
}
