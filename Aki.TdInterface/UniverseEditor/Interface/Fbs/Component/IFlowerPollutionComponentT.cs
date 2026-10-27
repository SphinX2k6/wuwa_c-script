using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005280 RID: 21120
	public class IFlowerPollutionComponentT
	{
		// Token: 0x17009ACF RID: 39631
		// (get) Token: 0x0602264F RID: 140879 RVA: 0x004C4AC1 File Offset: 0x004C2CC1
		// (set) Token: 0x06022650 RID: 140880 RVA: 0x004C4AC9 File Offset: 0x004C2CC9
		public bool Disabled { get; set; }

		// Token: 0x17009AD0 RID: 39632
		// (get) Token: 0x06022651 RID: 140881 RVA: 0x004C4AD2 File Offset: 0x004C2CD2
		// (set) Token: 0x06022652 RID: 140882 RVA: 0x004C4ADA File Offset: 0x004C2CDA
		public IFlowerPollutionSplineConfigT SplineConfigs { get; set; }

		// Token: 0x17009AD1 RID: 39633
		// (get) Token: 0x06022653 RID: 140883 RVA: 0x004C4AE3 File Offset: 0x004C2CE3
		// (set) Token: 0x06022654 RID: 140884 RVA: 0x004C4AEB File Offset: 0x004C2CEB
		public IFlowerPollutionPointLightConfigT PointLightConfig { get; set; }

		// Token: 0x17009AD2 RID: 39634
		// (get) Token: 0x06022655 RID: 140885 RVA: 0x004C4AF4 File Offset: 0x004C2CF4
		// (set) Token: 0x06022656 RID: 140886 RVA: 0x004C4AFC File Offset: 0x004C2CFC
		public List<int> ObstacleEntityIds { get; set; }

		// Token: 0x17009AD3 RID: 39635
		// (get) Token: 0x06022657 RID: 140887 RVA: 0x004C4B05 File Offset: 0x004C2D05
		// (set) Token: 0x06022658 RID: 140888 RVA: 0x004C4B0D File Offset: 0x004C2D0D
		public List<int> PollutionSourceEntityIds { get; set; }

		// Token: 0x17009AD4 RID: 39636
		// (get) Token: 0x06022659 RID: 140889 RVA: 0x004C4B16 File Offset: 0x004C2D16
		// (set) Token: 0x0602265A RID: 140890 RVA: 0x004C4B1E File Offset: 0x004C2D1E
		public List<IActionInfoT> OnEnterPollutionRangeActions { get; set; }

		// Token: 0x17009AD5 RID: 39637
		// (get) Token: 0x0602265B RID: 140891 RVA: 0x004C4B27 File Offset: 0x004C2D27
		// (set) Token: 0x0602265C RID: 140892 RVA: 0x004C4B2F File Offset: 0x004C2D2F
		public List<IActionInfoT> OnLeavePollutionRangeActions { get; set; }

		// Token: 0x17009AD6 RID: 39638
		// (get) Token: 0x0602265D RID: 140893 RVA: 0x004C4B38 File Offset: 0x004C2D38
		// (set) Token: 0x0602265E RID: 140894 RVA: 0x004C4B40 File Offset: 0x004C2D40
		public string BakeData { get; set; }

		// Token: 0x17009AD7 RID: 39639
		// (get) Token: 0x0602265F RID: 140895 RVA: 0x004C4B49 File Offset: 0x004C2D49
		// (set) Token: 0x06022660 RID: 140896 RVA: 0x004C4B51 File Offset: 0x004C2D51
		public byte NullMask { get; set; }

		// Token: 0x06022661 RID: 140897 RVA: 0x004C4B5C File Offset: 0x004C2D5C
		public IFlowerPollutionComponentT()
		{
			this.Disabled = false;
			this.SplineConfigs = null;
			this.PointLightConfig = null;
			this.ObstacleEntityIds = null;
			this.PollutionSourceEntityIds = null;
			this.OnEnterPollutionRangeActions = null;
			this.OnLeavePollutionRangeActions = null;
			this.BakeData = null;
			this.NullMask = 0;
		}
	}
}
