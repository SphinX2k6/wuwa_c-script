using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200365D RID: 13917
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoGridController
	{
		// Token: 0x0602419A RID: 147866 RVA: 0x00A377BC File Offset: 0x00A359BC
		public WuWaGoGridController(WuWaGoGrid grid)
		{
		}

		// Token: 0x0602419B RID: 147867 RVA: 0x00A377CC File Offset: 0x00A359CC
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

		// Token: 0x0602419C RID: 147868 RVA: 0x00A37840 File Offset: 0x00A35A40
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

		// Token: 0x0401420B RID: 82443
		public readonly WuWaGoGrid Grid = grid;
	}
}
