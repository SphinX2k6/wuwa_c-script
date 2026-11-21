using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002346 RID: 9030
[NullableContext(1)]
[Nullable(0)]
public class KuroHitResultCache
{
	// Token: 0x0601637D RID: 91005 RVA: 0x0067A66C File Offset: 0x0067886C
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

	// Token: 0x0400BB84 RID: 48004
	public int HitCount;

	// Token: 0x0400BB85 RID: 48005
	public List<AActor> Actors = new List<AActor>();

	// Token: 0x0400BB86 RID: 48006
	public List<FName> BoneNameArray = new List<FName>();

	// Token: 0x0400BB87 RID: 48007
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<TWeakObjectPtr<UPrimitiveComponent>> Components = new List<TWeakObjectPtr<UPrimitiveComponent>>();

	// Token: 0x0400BB88 RID: 48008
	public List<float> ImpactPointX = new List<float>();

	// Token: 0x0400BB89 RID: 48009
	public List<float> ImpactPointY = new List<float>();

	// Token: 0x0400BB8A RID: 48010
	public List<float> ImpactPointZ = new List<float>();

	// Token: 0x0400BB8B RID: 48011
	[StaticVariableRuleIgnore]
	private static readonly Stat stat = Stat.Create("KuroHitResultCache", "", "");
}
