using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Movement;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02004737 RID: 18231
	[NullableContext(1)]
	[Nullable(0)]
	internal class GridRollbackCapture : IRollbackCapture
	{
		// Token: 0x0602FA49 RID: 195145 RVA: 0x00B0AE1B File Offset: 0x00B0901B
		public GridRollbackCapture(WuWaGoGrid grid)
		{
			this.Grid = grid;
			this.PreCoordinate = Vector.Create();
			this.PreCoordinate.DeepCopy(this.Grid.Coordinate);
		}

		// Token: 0x0602FA4A RID: 195146 RVA: 0x00B0AE4C File Offset: 0x00B0904C
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

		// Token: 0x04019BA5 RID: 105381
		private readonly Vector PreCoordinate;

		// Token: 0x04019BA6 RID: 105382
		private readonly WuWaGoGrid Grid;
	}
}
