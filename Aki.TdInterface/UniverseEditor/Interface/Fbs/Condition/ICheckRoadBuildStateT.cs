using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B0C RID: 19212
	public class ICheckRoadBuildStateT
	{
		// Token: 0x17008B5F RID: 35679
		// (get) Token: 0x0601E374 RID: 123764 RVA: 0x0043C9F6 File Offset: 0x0043ABF6
		// (set) Token: 0x0601E375 RID: 123765 RVA: 0x0043C9FE File Offset: 0x0043ABFE
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008B60 RID: 35680
		// (get) Token: 0x0601E376 RID: 123766 RVA: 0x0043CA07 File Offset: 0x0043AC07
		// (set) Token: 0x0601E377 RID: 123767 RVA: 0x0043CA0F File Offset: 0x0043AC0F
		public int RoadId { get; set; }

		// Token: 0x17008B61 RID: 35681
		// (get) Token: 0x0601E378 RID: 123768 RVA: 0x0043CA18 File Offset: 0x0043AC18
		// (set) Token: 0x0601E379 RID: 123769 RVA: 0x0043CA20 File Offset: 0x0043AC20
		public bool IsBuilt { get; set; }

		// Token: 0x0601E37A RID: 123770 RVA: 0x0043CA29 File Offset: 0x0043AC29
		public ICheckRoadBuildStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.RoadId = 0;
			this.IsBuilt = false;
		}
	}
}
