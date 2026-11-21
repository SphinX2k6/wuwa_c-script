using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006021 RID: 24609
	public class ISwordRiderRailSplineT
	{
		// Token: 0x1700B687 RID: 46727
		// (get) Token: 0x06029801 RID: 169985 RVA: 0x005A9FD8 File Offset: 0x005A81D8
		// (set) Token: 0x06029802 RID: 169986 RVA: 0x005A9FE0 File Offset: 0x005A81E0
		public ESplineType Type { get; set; }

		// Token: 0x1700B688 RID: 46728
		// (get) Token: 0x06029803 RID: 169987 RVA: 0x005A9FE9 File Offset: 0x005A81E9
		// (set) Token: 0x06029804 RID: 169988 RVA: 0x005A9FF1 File Offset: 0x005A81F1
		public ESwordRiderRailWall WallType { get; set; }

		// Token: 0x1700B689 RID: 46729
		// (get) Token: 0x06029805 RID: 169989 RVA: 0x005A9FFA File Offset: 0x005A81FA
		// (set) Token: 0x06029806 RID: 169990 RVA: 0x005AA002 File Offset: 0x005A8202
		public string PathEffect { get; set; }

		// Token: 0x1700B68A RID: 46730
		// (get) Token: 0x06029807 RID: 169991 RVA: 0x005AA00B File Offset: 0x005A820B
		// (set) Token: 0x06029808 RID: 169992 RVA: 0x005AA013 File Offset: 0x005A8213
		public List<ISwordRiderRailSplinePointT> Points { get; set; }

		// Token: 0x06029809 RID: 169993 RVA: 0x005AA01C File Offset: 0x005A821C
		public ISwordRiderRailSplineT()
		{
			this.Type = ESplineType.Common;
			this.WallType = ESwordRiderRailWall.Inner;
			this.PathEffect = null;
			this.Points = null;
		}
	}
}
