using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A43 RID: 10819
[NullableContext(1)]
[Nullable(0)]
public class VoxelUtils
{
	// Token: 0x0601B418 RID: 111640 RVA: 0x0085EEC0 File Offset: 0x0085D0C0
	public static FKuroVoxelInfo GetVoxelInfo(UWorld world, FVectorDouble location, ref int errorCode, float searchStep = -1f)
	{
		return UKuroVoxelSystem.D_GetVoxelInfoAtPos(world, location, ref errorCode, (double)searchStep);
	}

	// Token: 0x0601B419 RID: 111641 RVA: 0x0085EECC File Offset: 0x0085D0CC
	public static bool TryGetVoxelInfo(UWorld world, FVectorDouble location, ref FKuroVoxelInfo outVoxelInfo, ref int errorCode, float searchStep = -1f)
	{
		return !UKuroVoxelSystem.D_TryGetVoxelInfoAtPos(world, location, ref outVoxelInfo, ref errorCode, (double)searchStep) && errorCode == 0;
	}
}
