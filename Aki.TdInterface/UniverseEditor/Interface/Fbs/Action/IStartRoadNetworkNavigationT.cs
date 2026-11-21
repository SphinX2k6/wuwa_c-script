using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200798A RID: 31114
	public class IStartRoadNetworkNavigationT
	{
		// Token: 0x1700E429 RID: 58409
		// (get) Token: 0x06036CE6 RID: 224486 RVA: 0x00754BD2 File Offset: 0x00752DD2
		// (set) Token: 0x06036CE7 RID: 224487 RVA: 0x00754BDA File Offset: 0x00752DDA
		public ISceneItemRoadNetworkNavigationT Target { get; set; }

		// Token: 0x1700E42A RID: 58410
		// (get) Token: 0x06036CE8 RID: 224488 RVA: 0x00754BE3 File Offset: 0x00752DE3
		// (set) Token: 0x06036CE9 RID: 224489 RVA: 0x00754BEB File Offset: 0x00752DEB
		public ISplineWayPointT Start { get; set; }

		// Token: 0x1700E42B RID: 58411
		// (get) Token: 0x06036CEA RID: 224490 RVA: 0x00754BF4 File Offset: 0x00752DF4
		// (set) Token: 0x06036CEB RID: 224491 RVA: 0x00754BFC File Offset: 0x00752DFC
		public ISplineWayPointT End { get; set; }

		// Token: 0x06036CEC RID: 224492 RVA: 0x00754C05 File Offset: 0x00752E05
		public IStartRoadNetworkNavigationT()
		{
			this.Target = null;
			this.Start = null;
			this.End = null;
		}
	}
}
