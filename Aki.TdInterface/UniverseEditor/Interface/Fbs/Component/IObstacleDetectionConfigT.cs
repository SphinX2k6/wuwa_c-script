using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C34 RID: 23604
	public class IObstacleDetectionConfigT
	{
		// Token: 0x1700AD5D RID: 44381
		// (get) Token: 0x060271F7 RID: 160247 RVA: 0x0055C6F7 File Offset: 0x0055A8F7
		// (set) Token: 0x060271F8 RID: 160248 RVA: 0x0055C6FF File Offset: 0x0055A8FF
		public ITrafficMatchTargetT ObstacleDetectionType { get; set; }

		// Token: 0x1700AD5E RID: 44382
		// (get) Token: 0x060271F9 RID: 160249 RVA: 0x0055C708 File Offset: 0x0055A908
		// (set) Token: 0x060271FA RID: 160250 RVA: 0x0055C710 File Offset: 0x0055A910
		public TTriggerShapeUnion ExtraObstacleDetectionRange { get; set; }

		// Token: 0x060271FB RID: 160251 RVA: 0x0055C719 File Offset: 0x0055A919
		public IObstacleDetectionConfigT()
		{
			this.ObstacleDetectionType = null;
			this.ExtraObstacleDetectionRange = null;
		}
	}
}
