using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DEB RID: 11755
[NullableContext(1)]
[Nullable(0)]
public class KuroHitResultCache
{
	// Token: 0x06018AD0 RID: 101072 RVA: 0x00654534 File Offset: 0x00652734
	public void Append(UKuroHitResult ueObj)
	{
		int hitCount = ueObj.GetHitCount();
		this.HitCount += hitCount;
		TArray<TWeakObjectPtr<AActor>> actors = ueObj.Actors;
		TArray<string> boneNameArray = ueObj.BoneNameArray;
		TArray<TWeakObjectPtr<UPrimitiveComponent>> components = ueObj.Components;
		TArray<float> impactPointX_Array = ueObj.ImpactPointX_Array;
		TArray<float> impactPointY_Array = ueObj.ImpactPointY_Array;
		TArray<float> impactPointZ_Array = ueObj.ImpactPointZ_Array;
		for (int i = 0; i < hitCount; i++)
		{
			this.Actors.Add(actors.Get(i));
			this.BoneNameArray.Add(FNameUtil.GetDynamicFName(boneNameArray.Get(i)).Value);
			this.Components.Add(components.Get(i));
			this.ImpactPointX.Add(impactPointX_Array.Get(i));
			this.ImpactPointY.Add(impactPointY_Array.Get(i));
			this.ImpactPointZ.Add(impactPointZ_Array.Get(i));
		}
	}

	// Token: 0x0400B7FE RID: 47102
	public int HitCount;

	// Token: 0x0400B7FF RID: 47103
	public List<AActor> Actors = new List<AActor>();

	// Token: 0x0400B800 RID: 47104
	public List<FName> BoneNameArray = new List<FName>();

	// Token: 0x0400B801 RID: 47105
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<TWeakObjectPtr<UPrimitiveComponent>> Components = new List<TWeakObjectPtr<UPrimitiveComponent>>();

	// Token: 0x0400B802 RID: 47106
	public List<float> ImpactPointX = new List<float>();

	// Token: 0x0400B803 RID: 47107
	public List<float> ImpactPointY = new List<float>();

	// Token: 0x0400B804 RID: 47108
	public List<float> ImpactPointZ = new List<float>();

	// Token: 0x0400B805 RID: 47109
	[StaticVariableRuleIgnore]
	private static readonly Stat stat = Stat.Create("KuroHitResultCache", "", "");
}
