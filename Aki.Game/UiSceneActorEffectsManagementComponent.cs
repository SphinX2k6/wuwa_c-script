using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02001D19 RID: 7449
[NullableContext(1)]
[Nullable(0)]
public class UiSceneActorEffectsManagementComponent
{
	// Token: 0x06012712 RID: 75538 RVA: 0x00572EB0 File Offset: 0x005710B0
	public int PlayEffect(string effectId, USceneComponent parent, FTransformDouble? transform = null, FName? socketName = null, [Nullable(2)] Action<ELoadEffectResult, int> callback = null)
	{
		string effectPath = EffectUtil.GetEffectPath(effectId);
		return this.PlayEffectByPath(effectPath, parent, transform, socketName, callback);
	}

	// Token: 0x06012713 RID: 75539 RVA: 0x00572ED4 File Offset: 0x005710D4
	public int PlayEffectByPath(string effectPath, USceneComponent parent, FTransformDouble? transform = null, FName? socketName = null, [Nullable(2)] Action<ELoadEffectResult, int> callback = null)
	{
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = transform;
		ftransformDouble = new FTransformDouble?(ftransformDouble ?? this.CacheTransform);
		int num = instance.SpawnEffect(world, ftransformDouble, effectPath, "[RoleAnimStateEffectManager.PlayEffect]", new EffectContext(null, parent, false), EEffectType.UiScene3D, null, callback, null, false, false);
		if (EffectSystem.Instance.IsValid(num))
		{
			this.EffectCacheList.Add(num);
		}
		FName? fname = socketName;
		if (fname == null || fname.Value.IsNone())
		{
			fname = new FName?(this.DefaultSocketName);
		}
		if (EffectSystem.Instance.IsValid(num))
		{
			EffectSystem.Instance.GetEffectActor(num).K2_AttachToComponent(parent, new FName?(fname.Value), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
		}
		return num;
	}

	// Token: 0x06012714 RID: 75540 RVA: 0x00572FA4 File Offset: 0x005711A4
	public void PlayEffectList(TArray<TSoftObjectPtr<UObject>> effects, USceneComponent parent, FTransformDouble? transform = null, FName? socketName = null)
	{
		if (effects == null)
		{
			return;
		}
		for (int i = 0; i < effects.Num(); i++)
		{
			TSoftObjectPtr<UObject> tsoftObjectPtr = effects.Get(i);
			this.PlayEffectByPath(tsoftObjectPtr.ToAssetPathName(), parent, transform, socketName, null);
		}
	}

	// Token: 0x06012715 RID: 75541 RVA: 0x00572FE0 File Offset: 0x005711E0
	public void AttachEffect(int effectHandle)
	{
		this.EffectCacheList.Add(effectHandle);
	}

	// Token: 0x06012716 RID: 75542 RVA: 0x00572FF0 File Offset: 0x005711F0
	public void DestroyEffect()
	{
		if (this.EffectCacheList == null || this.EffectCacheList.Count == 0)
		{
			return;
		}
		foreach (int handle in this.EffectCacheList)
		{
			EffectSystem.Instance.StopEffectById(handle, "[RoleAnimStateEffectManager.RecycleEffect]", true, null);
		}
		this.EffectCacheList.Clear();
	}

	// Token: 0x06012717 RID: 75543 RVA: 0x00573078 File Offset: 0x00571278
	public void StopEffect(int effectHandle)
	{
		EffectSystem.Instance.StopEffectById(effectHandle, "[RoleAnimStateEffectManager.StopEffect]", true, null);
	}

	// Token: 0x06012718 RID: 75544 RVA: 0x005730A0 File Offset: 0x005712A0
	public UiSceneActorEffectsManagementComponent()
	{
		FRotator frotator = new FRotator(0f, 0f, 0f);
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
		FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble2;
		this.CacheTransform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
		this.DefaultSocketName = CharacterNameDefines.Instance.ROOT;
		base..ctor();
	}

	// Token: 0x0400A091 RID: 41105
	private readonly List<int> EffectCacheList = new List<int>();

	// Token: 0x0400A092 RID: 41106
	private readonly FTransformDouble CacheTransform;

	// Token: 0x0400A093 RID: 41107
	private readonly FName DefaultSocketName;
}
