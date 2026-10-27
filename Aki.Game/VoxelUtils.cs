using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020034CF RID: 13519
[NullableContext(1)]
[Nullable(0)]
public class VoxelUtils
{
	// Token: 0x0601D719 RID: 120601 RVA: 0x00837A18 File Offset: 0x00835C18
	public static FKuroVoxelInfo GetVoxelInfo(UWorld world, FVectorDouble location, ref int errorCode, float searchStep = -1f)
	{
		return UKuroVoxelSystem.D_GetVoxelInfoAtPos(world, location, ref errorCode, (double)searchStep);
	}

	// Token: 0x0601D71A RID: 120602 RVA: 0x00837A24 File Offset: 0x00835C24
	public static bool TryGetVoxelInfo(UWorld world, FVectorDouble location, ref FKuroVoxelInfo outVoxelInfo, ref int errorCode, float searchStep = -1f)
	{
		return !UKuroVoxelSystem.D_TryGetVoxelInfoAtPos(world, location, ref outVoxelInfo, ref errorCode, (double)searchStep) && errorCode == 0;
	}
}
