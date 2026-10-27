using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200472C RID: 18220
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoGridController
	{
		// Token: 0x0602F9D0 RID: 195024 RVA: 0x00B07930 File Offset: 0x00B05B30
		public WuWaGoGridController(WuWaGoGrid grid)
		{
		}

		// Token: 0x0602F9D1 RID: 195025 RVA: 0x00B07940 File Offset: 0x00B05B40
		public IWuWaGoGridRelocationRequest CreateRelocationRequest(Vector targetCoordinate)
		{
			Vector vector = Vector.Create(this.Grid.Coordinate);
			Vector vector2 = Vector.Create(targetCoordinate);
			return new WuWaGoGridRelocationRequest
			{
				GridController = this,
				Grid = this.Grid,
				StartCoordinate = vector,
				TargetCoordinate = vector2,
				OldKey = WuWaGoUtil.GetCoordinateKeyByVector(vector),
				TargetKey = WuWaGoUtil.GetCoordinateKeyByVector(vector2),
				Participants = this.Grid.SnapshotMoveParticipants()
			};
		}

		// Token: 0x0602F9D2 RID: 195026 RVA: 0x00B079B4 File Offset: 0x00B05BB4
		public List<IWuWaGoWorldMoveTarget> BuildWorldMoveTargets(IWuWaGoGridRelocationRequest request)
		{
			List<IWuWaGoWorldMoveTarget> list = new List<IWuWaGoWorldMoveTarget>();
			foreach (IWuWaGoGridMoveParticipant wuWaGoGridMoveParticipant in request.Participants)
			{
				Func<IWuWaGoGridRelocationContext, IWuWaGoWorldMoveTarget> createWorldMoveTarget = wuWaGoGridMoveParticipant.CreateWorldMoveTarget;
				IWuWaGoWorldMoveTarget wuWaGoWorldMoveTarget = (createWorldMoveTarget != null) ? createWorldMoveTarget(request) : null;
				if (wuWaGoWorldMoveTarget != null)
				{
					list.Add(wuWaGoWorldMoveTarget);
				}
			}
			return WuWaGoActorMoveHelper.BuildGridMoveTargets(request.Grid, null, null, list);
		}

		// Token: 0x04019B5B RID: 105307
		public readonly WuWaGoGrid Grid = grid;
	}
}
