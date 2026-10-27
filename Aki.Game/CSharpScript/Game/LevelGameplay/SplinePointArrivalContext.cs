using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A6 RID: 27046
	public class SplinePointArrivalContext : GeneralContext
	{
		// Token: 0x06043460 RID: 275552 RVA: 0x01066300 File Offset: 0x01064500
		public SplinePointArrivalContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.SplinePointArrival);
		}

		// Token: 0x06043461 RID: 275553 RVA: 0x01066315 File Offset: 0x01064515
		public override void Reset()
		{
			base.Reset();
			this.EntityId = 0;
			this.SplineId = 0;
			this.PointIndex = 0;
		}

		// Token: 0x06043462 RID: 275554 RVA: 0x01066334 File Offset: 0x01064534
		[NullableContext(1)]
		public static SplinePointArrivalContext Create(int entityId, int splineId, int pointIndex)
		{
			SplinePointArrivalContext splinePointArrivalContext = GeneralContext.GetObj(EGeneralContextType.SplinePointArrival, null, () => new SplinePointArrivalContext()) as SplinePointArrivalContext;
			splinePointArrivalContext.EntityId = entityId;
			splinePointArrivalContext.SplineId = splineId;
			splinePointArrivalContext.PointIndex = pointIndex;
			return splinePointArrivalContext;
		}

		// Token: 0x040230BB RID: 143547
		public int EntityId;

		// Token: 0x040230BC RID: 143548
		public int SplineId;

		// Token: 0x040230BD RID: 143549
		public int PointIndex;
	}
}
