using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;

// Token: 0x02002BCE RID: 11214
public static class TowerDefenseEventUtility
{
	// Token: 0x06017490 RID: 95376 RVA: 0x005EB31D File Offset: 0x005E951D
	public static GridPbDirection ConvertDegree2Direction(float degree)
	{
		if (degree > 45f && degree < 135f)
		{
			return GridPbDirection.GridRight;
		}
		if (degree > 135f || degree < -135f)
		{
			return GridPbDirection.GridBackward;
		}
		if (degree > -135f && degree < -45f)
		{
			return GridPbDirection.GridLeft;
		}
		return GridPbDirection.GridForward;
	}

	// Token: 0x06017491 RID: 95377 RVA: 0x005EB358 File Offset: 0x005E9558
	public static int ConvertDirection2Degree(GridPbDirection? direction)
	{
		if (direction != null)
		{
			switch (direction.GetValueOrDefault())
			{
			case GridPbDirection.GridBackward:
				return 180;
			case GridPbDirection.GridLeft:
				return -90;
			case GridPbDirection.GridRight:
				return 90;
			}
		}
		return 0;
	}

	// Token: 0x06017492 RID: 95378 RVA: 0x005EB39C File Offset: 0x005E959C
	[NullableContext(1)]
	public static bool ValidatePlacementWithGridNormal(ETowerDefenseEventTrapPlacementType placementType, global::Vector gridNormal, float threshold = 0.7f)
	{
		switch (placementType)
		{
		case ETowerDefenseEventTrapPlacementType.Ground:
			return gridNormal.DotProduct(global::Vector.UpVectorProxy) > (double)threshold;
		case ETowerDefenseEventTrapPlacementType.Wall:
			return Math.Abs(gridNormal.DotProduct(global::Vector.UpVectorProxy)) < (double)(1f - threshold);
		case ETowerDefenseEventTrapPlacementType.Roof:
			return gridNormal.DotProduct(global::Vector.DownVectorProxy) > (double)threshold;
		}
		return false;
	}
}
