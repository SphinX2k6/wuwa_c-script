using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B02 RID: 23298
	public class SplinePointArrivalContext : GeneralContext
	{
		// Token: 0x06039498 RID: 234648 RVA: 0x0100A568 File Offset: 0x01008768
		public SplinePointArrivalContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.SplinePointArrival);
		}

		// Token: 0x06039499 RID: 234649 RVA: 0x0100A57D File Offset: 0x0100877D
		public override void Reset()
		{
			base.Reset();
			this.EntityId = 0;
			this.SplineId = 0;
			this.PointIndex = 0;
		}

		// Token: 0x0603949A RID: 234650 RVA: 0x0100A59C File Offset: 0x0100879C
		[NullableContext(1)]
		public static SplinePointArrivalContext Create(int entityId, int splineId, int pointIndex)
		{
			SplinePointArrivalContext splinePointArrivalContext = GeneralContext.GetObj(EGeneralContextType.SplinePointArrival, null, () => new SplinePointArrivalContext()) as SplinePointArrivalContext;
			splinePointArrivalContext.EntityId = entityId;
			splinePointArrivalContext.SplineId = splineId;
			splinePointArrivalContext.PointIndex = pointIndex;
			return splinePointArrivalContext;
		}

		// Token: 0x0401E2A5 RID: 123557
		public int EntityId;

		// Token: 0x0401E2A6 RID: 123558
		public int SplineId;

		// Token: 0x0401E2A7 RID: 123559
		public int PointIndex;
	}
}
