using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005693 RID: 22163
	public class IObstacleDetectionConfigT
	{
		// Token: 0x1700A4CE RID: 42190
		// (get) Token: 0x06024FBE RID: 151486 RVA: 0x0051BB5B File Offset: 0x00519D5B
		// (set) Token: 0x06024FBF RID: 151487 RVA: 0x0051BB63 File Offset: 0x00519D63
		public ITrafficMatchTargetT ObstacleDetectionType { get; set; }

		// Token: 0x1700A4CF RID: 42191
		// (get) Token: 0x06024FC0 RID: 151488 RVA: 0x0051BB6C File Offset: 0x00519D6C
		// (set) Token: 0x06024FC1 RID: 151489 RVA: 0x0051BB74 File Offset: 0x00519D74
		public TTriggerShapeUnion ExtraObstacleDetectionRange { get; set; }

		// Token: 0x06024FC2 RID: 151490 RVA: 0x0051BB7D File Offset: 0x00519D7D
		public IObstacleDetectionConfigT()
		{
			this.ObstacleDetectionType = null;
			this.ExtraObstacleDetectionRange = null;
		}
	}
}
