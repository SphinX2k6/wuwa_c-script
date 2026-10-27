using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B5 RID: 29109
	public class IStartRoadNetworkNavigationT
	{
		// Token: 0x1700D832 RID: 55346
		// (get) Token: 0x060339E8 RID: 211432 RVA: 0x006F3906 File Offset: 0x006F1B06
		// (set) Token: 0x060339E9 RID: 211433 RVA: 0x006F390E File Offset: 0x006F1B0E
		public ISceneItemRoadNetworkNavigationT Target { get; set; }

		// Token: 0x1700D833 RID: 55347
		// (get) Token: 0x060339EA RID: 211434 RVA: 0x006F3917 File Offset: 0x006F1B17
		// (set) Token: 0x060339EB RID: 211435 RVA: 0x006F391F File Offset: 0x006F1B1F
		public ISplineWayPointT Start { get; set; }

		// Token: 0x1700D834 RID: 55348
		// (get) Token: 0x060339EC RID: 211436 RVA: 0x006F3928 File Offset: 0x006F1B28
		// (set) Token: 0x060339ED RID: 211437 RVA: 0x006F3930 File Offset: 0x006F1B30
		public ISplineWayPointT End { get; set; }

		// Token: 0x060339EE RID: 211438 RVA: 0x006F3939 File Offset: 0x006F1B39
		public IStartRoadNetworkNavigationT()
		{
			this.Target = null;
			this.Start = null;
			this.End = null;
		}
	}
}
