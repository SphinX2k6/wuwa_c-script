using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200236A RID: 9066
[NullableContext(1)]
[Nullable(0)]
public class BulletHitResult
{
	// Token: 0x0601656E RID: 91502 RVA: 0x00680C40 File Offset: 0x0067EE40
	public void AppendHitResult(UKuroHitResult hitResult, int index)
	{
		this.HitCount++;
		this.BoneNameArray.Add(hitResult.BoneNameArray.Get(index));
		this.ImpactPointX.Add((double)hitResult.ImpactPointX_Array.Get(index));
		this.ImpactPointY.Add((double)hitResult.ImpactPointY_Array.Get(index));
		this.ImpactPointZ.Add((double)hitResult.ImpactPointZ_Array.Get(index));
	}

	// Token: 0x0601656F RID: 91503 RVA: 0x00680CBC File Offset: 0x0067EEBC
	public void AppendHitTempResult(BulletHitTempResult hitTempResult, string boneName)
	{
		this.HitCount++;
		this.BoneNameArray.Add(boneName);
		this.ImpactPointX.Add(hitTempResult.ImpactPoint.X);
		this.ImpactPointY.Add(hitTempResult.ImpactPoint.Y);
		this.ImpactPointZ.Add(hitTempResult.ImpactPoint.Z);
	}

	// Token: 0x0400BD00 RID: 48384
	public int HitCount;

	// Token: 0x0400BD01 RID: 48385
	public List<string> BoneNameArray = new List<string>();

	// Token: 0x0400BD02 RID: 48386
	public List<double> ImpactPointX = new List<double>();

	// Token: 0x0400BD03 RID: 48387
	public List<double> ImpactPointY = new List<double>();

	// Token: 0x0400BD04 RID: 48388
	public List<double> ImpactPointZ = new List<double>();
}
