using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E0E RID: 11790
[NullableContext(1)]
[Nullable(0)]
public class BulletHitResult
{
	// Token: 0x06018CAD RID: 101549 RVA: 0x0065AA6C File Offset: 0x00658C6C
	public void AppendHitResult(UKuroHitResult hitResult, int index)
	{
		this.HitCount++;
		this.BoneNameArray.Add(hitResult.BoneNameArray.Get(index));
		this.ImpactPointX.Add((double)hitResult.ImpactPointX_Array.Get(index));
		this.ImpactPointY.Add((double)hitResult.ImpactPointY_Array.Get(index));
		this.ImpactPointZ.Add((double)hitResult.ImpactPointZ_Array.Get(index));
	}

	// Token: 0x06018CAE RID: 101550 RVA: 0x0065AAE8 File Offset: 0x00658CE8
	public void AppendHitTempResult(BulletHitTempResult hitTempResult, string boneName)
	{
		this.HitCount++;
		this.BoneNameArray.Add(boneName);
		this.ImpactPointX.Add(hitTempResult.ImpactPoint.X);
		this.ImpactPointY.Add(hitTempResult.ImpactPoint.Y);
		this.ImpactPointZ.Add(hitTempResult.ImpactPoint.Z);
	}

	// Token: 0x0400B972 RID: 47474
	public int HitCount;

	// Token: 0x0400B973 RID: 47475
	public List<string> BoneNameArray = new List<string>();

	// Token: 0x0400B974 RID: 47476
	public List<double> ImpactPointX = new List<double>();

	// Token: 0x0400B975 RID: 47477
	public List<double> ImpactPointY = new List<double>();

	// Token: 0x0400B976 RID: 47478
	public List<double> ImpactPointZ = new List<double>();
}
