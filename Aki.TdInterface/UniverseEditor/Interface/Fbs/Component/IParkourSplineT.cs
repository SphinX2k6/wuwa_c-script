using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C58 RID: 23640
	public class IParkourSplineT
	{
		// Token: 0x1700ADAD RID: 44461
		// (get) Token: 0x06027345 RID: 160581 RVA: 0x0055ED18 File Offset: 0x0055CF18
		// (set) Token: 0x06027346 RID: 160582 RVA: 0x0055ED20 File Offset: 0x0055CF20
		public ESplineType Type { get; set; }

		// Token: 0x1700ADAE RID: 44462
		// (get) Token: 0x06027347 RID: 160583 RVA: 0x0055ED29 File Offset: 0x0055CF29
		// (set) Token: 0x06027348 RID: 160584 RVA: 0x0055ED31 File Offset: 0x0055CF31
		public bool IsRequireToEnd { get; set; }

		// Token: 0x1700ADAF RID: 44463
		// (get) Token: 0x06027349 RID: 160585 RVA: 0x0055ED3A File Offset: 0x0055CF3A
		// (set) Token: 0x0602734A RID: 160586 RVA: 0x0055ED42 File Offset: 0x0055CF42
		public int CheckPointsRequire { get; set; }

		// Token: 0x1700ADB0 RID: 44464
		// (get) Token: 0x0602734B RID: 160587 RVA: 0x0055ED4B File Offset: 0x0055CF4B
		// (set) Token: 0x0602734C RID: 160588 RVA: 0x0055ED53 File Offset: 0x0055CF53
		public string CheckPointResource { get; set; }

		// Token: 0x1700ADB1 RID: 44465
		// (get) Token: 0x0602734D RID: 160589 RVA: 0x0055ED5C File Offset: 0x0055CF5C
		// (set) Token: 0x0602734E RID: 160590 RVA: 0x0055ED64 File Offset: 0x0055CF64
		public string CheckPointsDestroyRes { get; set; }

		// Token: 0x1700ADB2 RID: 44466
		// (get) Token: 0x0602734F RID: 160591 RVA: 0x0055ED6D File Offset: 0x0055CF6D
		// (set) Token: 0x06027350 RID: 160592 RVA: 0x0055ED75 File Offset: 0x0055CF75
		public string StartResource { get; set; }

		// Token: 0x1700ADB3 RID: 44467
		// (get) Token: 0x06027351 RID: 160593 RVA: 0x0055ED7E File Offset: 0x0055CF7E
		// (set) Token: 0x06027352 RID: 160594 RVA: 0x0055ED86 File Offset: 0x0055CF86
		public string EndResource { get; set; }

		// Token: 0x1700ADB4 RID: 44468
		// (get) Token: 0x06027353 RID: 160595 RVA: 0x0055ED8F File Offset: 0x0055CF8F
		// (set) Token: 0x06027354 RID: 160596 RVA: 0x0055ED97 File Offset: 0x0055CF97
		public List<IParkourSplinePointT> Points { get; set; }

		// Token: 0x06027355 RID: 160597 RVA: 0x0055EDA0 File Offset: 0x0055CFA0
		public IParkourSplineT()
		{
			this.Type = ESplineType.Common;
			this.IsRequireToEnd = false;
			this.CheckPointsRequire = 0;
			this.CheckPointResource = null;
			this.CheckPointsDestroyRes = null;
			this.StartResource = null;
			this.EndResource = null;
			this.Points = null;
		}
	}
}
