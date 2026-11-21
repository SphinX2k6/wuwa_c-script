using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;

// Token: 0x02002149 RID: 8521
public static class TowerDefenseEventUtility
{
	// Token: 0x06014EC1 RID: 85697 RVA: 0x00617EB5 File Offset: 0x006160B5
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

	// Token: 0x06014EC2 RID: 85698 RVA: 0x00617EF0 File Offset: 0x006160F0
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

	// Token: 0x06014EC3 RID: 85699 RVA: 0x00617F34 File Offset: 0x00616134
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
