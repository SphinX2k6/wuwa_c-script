using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Movement;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02003668 RID: 13928
	[NullableContext(1)]
	[Nullable(0)]
	internal class GridRollbackCapture : IRollbackCapture
	{
		// Token: 0x06024213 RID: 147987 RVA: 0x00A3AD6F File Offset: 0x00A38F6F
		public GridRollbackCapture(WuWaGoGrid grid)
		{
			this.Grid = grid;
			this.PreCoordinate = Vector.Create();
			this.PreCoordinate.DeepCopy(this.Grid.Coordinate);
		}

		// Token: 0x06024214 RID: 147988 RVA: 0x00A3ADA0 File Offset: 0x00A38FA0
		public void Restore()
		{
			Transform originTransform = WuWaGoModel.Instance.GameData.OriginTransform;
			if (originTransform == null)
			{
				return;
			}
			Vector coordinate = this.Grid.Coordinate;
			if (coordinate.Equals(this.PreCoordinate, 9.999999747378752E-05))
			{
				return;
			}
			AActor applique = this.Grid.Applique;
			if (applique != null && applique.IsValid())
			{
				WuWaGoActorMoveHelper.SnapMoveTargetsByGridCoordinateDelta(originTransform, coordinate, this.PreCoordinate, new List<IWuWaGoWorldMoveTarget>
				{
					new WuWaGoWorldMoveTarget
					{
						Actor = applique
					}
				});
			}
			this.Grid.SetCoordinate(this.PreCoordinate);
		}

		// Token: 0x04014255 RID: 82517
		private readonly Vector PreCoordinate;

		// Token: 0x04014256 RID: 82518
		private readonly WuWaGoGrid Grid;
	}
}
