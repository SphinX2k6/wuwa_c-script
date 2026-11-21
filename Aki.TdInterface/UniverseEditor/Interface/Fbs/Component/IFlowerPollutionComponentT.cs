using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E8 RID: 22504
	public class IFlowerPollutionComponentT
	{
		// Token: 0x1700A2CD RID: 41677
		// (get) Token: 0x060245E9 RID: 148969 RVA: 0x004FF631 File Offset: 0x004FD831
		// (set) Token: 0x060245EA RID: 148970 RVA: 0x004FF639 File Offset: 0x004FD839
		public bool Disabled { get; set; }

		// Token: 0x1700A2CE RID: 41678
		// (get) Token: 0x060245EB RID: 148971 RVA: 0x004FF642 File Offset: 0x004FD842
		// (set) Token: 0x060245EC RID: 148972 RVA: 0x004FF64A File Offset: 0x004FD84A
		public IFlowerPollutionSplineConfigT SplineConfigs { get; set; }

		// Token: 0x1700A2CF RID: 41679
		// (get) Token: 0x060245ED RID: 148973 RVA: 0x004FF653 File Offset: 0x004FD853
		// (set) Token: 0x060245EE RID: 148974 RVA: 0x004FF65B File Offset: 0x004FD85B
		public IFlowerPollutionPointLightConfigT PointLightConfig { get; set; }

		// Token: 0x1700A2D0 RID: 41680
		// (get) Token: 0x060245EF RID: 148975 RVA: 0x004FF664 File Offset: 0x004FD864
		// (set) Token: 0x060245F0 RID: 148976 RVA: 0x004FF66C File Offset: 0x004FD86C
		public List<int> ObstacleEntityIds { get; set; }

		// Token: 0x1700A2D1 RID: 41681
		// (get) Token: 0x060245F1 RID: 148977 RVA: 0x004FF675 File Offset: 0x004FD875
		// (set) Token: 0x060245F2 RID: 148978 RVA: 0x004FF67D File Offset: 0x004FD87D
		public List<int> PollutionSourceEntityIds { get; set; }

		// Token: 0x1700A2D2 RID: 41682
		// (get) Token: 0x060245F3 RID: 148979 RVA: 0x004FF686 File Offset: 0x004FD886
		// (set) Token: 0x060245F4 RID: 148980 RVA: 0x004FF68E File Offset: 0x004FD88E
		public List<IActionInfoT> OnEnterPollutionRangeActions { get; set; }

		// Token: 0x1700A2D3 RID: 41683
		// (get) Token: 0x060245F5 RID: 148981 RVA: 0x004FF697 File Offset: 0x004FD897
		// (set) Token: 0x060245F6 RID: 148982 RVA: 0x004FF69F File Offset: 0x004FD89F
		public List<IActionInfoT> OnLeavePollutionRangeActions { get; set; }

		// Token: 0x1700A2D4 RID: 41684
		// (get) Token: 0x060245F7 RID: 148983 RVA: 0x004FF6A8 File Offset: 0x004FD8A8
		// (set) Token: 0x060245F8 RID: 148984 RVA: 0x004FF6B0 File Offset: 0x004FD8B0
		public string BakeData { get; set; }

		// Token: 0x1700A2D5 RID: 41685
		// (get) Token: 0x060245F9 RID: 148985 RVA: 0x004FF6B9 File Offset: 0x004FD8B9
		// (set) Token: 0x060245FA RID: 148986 RVA: 0x004FF6C1 File Offset: 0x004FD8C1
		public byte NullMask { get; set; }

		// Token: 0x060245FB RID: 148987 RVA: 0x004FF6CC File Offset: 0x004FD8CC
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
