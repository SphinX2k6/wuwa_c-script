using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200279F RID: 10143
[NullableContext(1)]
[Nullable(0)]
public class UiSceneActorEffectsManagementComponent
{
	// Token: 0x06014D3D RID: 85309 RVA: 0x00548D54 File Offset: 0x00546F54
	public int PlayEffect(string effectId, USceneComponent parent, FTransformDouble? transform = null, FName? socketName = null, [Nullable(2)] Action<ELoadEffectResult, int> callback = null)
	{
		string effectPath = EffectUtil.GetEffectPath(effectId);
		return this.PlayEffectByPath(effectPath, parent, transform, socketName, callback);
	}

	// Token: 0x06014D3E RID: 85310 RVA: 0x00548D78 File Offset: 0x00546F78
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

	// Token: 0x06014D3F RID: 85311 RVA: 0x00548E48 File Offset: 0x00547048
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

	// Token: 0x06014D40 RID: 85312 RVA: 0x00548E84 File Offset: 0x00547084
	public void AttachEffect(int effectHandle)
	{
		this.EffectCacheList.Add(effectHandle);
	}

	// Token: 0x06014D41 RID: 85313 RVA: 0x00548E94 File Offset: 0x00547094
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

	// Token: 0x06014D42 RID: 85314 RVA: 0x00548F1C File Offset: 0x0054711C
	public void StopEffect(int effectHandle)
	{
		EffectSystem.Instance.StopEffectById(effectHandle, "[RoleAnimStateEffectManager.StopEffect]", true, null);
	}

	// Token: 0x06014D43 RID: 85315 RVA: 0x00548F44 File Offset: 0x00547144
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

	// Token: 0x04009CC3 RID: 40131
	private readonly List<int> EffectCacheList = new List<int>();

	// Token: 0x04009CC4 RID: 40132
	private readonly FTransformDouble CacheTransform;

	// Token: 0x04009CC5 RID: 40133
	private readonly FName DefaultSocketName;
}
