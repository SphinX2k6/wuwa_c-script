using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

// Token: 0x02002BCB RID: 11211
[NullableContext(1)]
[Nullable(0)]
public class TowerDefenseEventPreviewMonsterSpawner
{
	// Token: 0x0601747F RID: 95359 RVA: 0x005EA9A1 File Offset: 0x005E8BA1
	public void Init(Dictionary<int, TrapDefenseMonsterPbGroup> data)
	{
		this.Reset();
		this.InitPreviewMonsters(data);
		this.PreviewSplines();
	}

	// Token: 0x06017480 RID: 95360 RVA: 0x005EA9B8 File Offset: 0x005E8BB8
	private unsafe void PreviewSplines()
	{
		TowerDefenseEventModel.Instance.GetWaveSplineIds(this.PreviewSplineIds);
		foreach (int num in this.PreviewSplineIds)
		{
			if (GameSplineModel.Instance.LoadAndGetSplineComponent(num, 0, EIdType.SimpleCombatPreviewId) == null)
			{
				GameSplineModel.Instance.ReleaseSpline(num, 0L, EIdType.SimpleCombatPreviewId);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefenseEvent;
				ELogAuthor author = ELogAuthor.XY;
				string message = "预览怪物组样条线加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("splineId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				TsGameSplineActor splineActorBySplineId = GameSplineModel.Instance.GetSplineActorBySplineId(num);
				ISplineType splineData = splineActorBySplineId.SplineData;
				if (splineData == null || splineData.Type != ESplineType.Effect)
				{
					GameSplineModel.Instance.ReleaseSpline(num, 0L, EIdType.SimpleCombatPreviewId);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.TowerDefenseEvent;
					ELogAuthor author2 = ELogAuthor.XY;
					string message2 = "预览怪物组样条线类型错误";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("splineId", num);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item = "splineType";
					ISplineType splineData2 = splineActorBySplineId.SplineData;
					ptr = new ValueTuple<string, object>(item, (splineData2 != null) ? new ESplineType?(splineData2.Type) : null);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					IEffectSpline effectSpline = splineActorBySplineId.SplineData as IEffectSpline;
					EffectSystem instance3 = EffectSystem.Instance;
					UObject world = GlobalData.World;
					FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
					int num2 = instance3.SpawnEffect(world, ftransformDouble, effectSpline.Effect, "TowerDefenseEventPreviewMonsterSpawner.PreviewSplines", new EffectContext(null, splineActorBySplineId, false), EEffectType.Scene, null, null, null, false, false);
					if (EffectSystem.Instance.IsValid(num2))
					{
						OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num2);
						AActor parent = splineActorBySplineId;
						FName? fname = null;
						effectActor.K2_AttachToActor(parent, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
						EffectSystem.Instance.SetEffectIgnoreVisibilityOptimize(num2, true);
					}
					this.SpawnedSplines[num] = num2;
				}
			}
		}
	}

	// Token: 0x06017481 RID: 95361 RVA: 0x005EABD4 File Offset: 0x005E8DD4
	private void ReleaseSplines()
	{
		foreach (KeyValuePair<int, int> keyValuePair in this.SpawnedSplines)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			GameSplineModel.Instance.ReleaseSpline(key, 0L, EIdType.SimpleCombatPreviewId);
			if (EffectSystem.Instance.IsValid(value))
			{
				EffectSystem.Instance.StopEffectById(value, "TowerDefenseEventPreviewMonsterSpawner.ReleaseSplines", true, null);
			}
		}
		this.SpawnedSplines.Clear();
		this.PreviewSplineIds.Clear();
	}

	// Token: 0x06017482 RID: 95362 RVA: 0x005EAC80 File Offset: 0x005E8E80
	private void InitPreviewMonsters(Dictionary<int, TrapDefenseMonsterPbGroup> data)
	{
		foreach (int num in data.Keys)
		{
			TrapDefenseMonsterPbGroup trapDefenseMonsterPbGroup;
			if (data.TryGetValue(num, out trapDefenseMonsterPbGroup) && trapDefenseMonsterPbGroup != null && trapDefenseMonsterPbGroup.MonsterConfigIds != null && trapDefenseMonsterPbGroup.MonsterConfigIds.Count != 0)
			{
				int num2 = num;
				TowerDefenseEventSplineMonsterSpawner towerDefenseEventSplineMonsterSpawner = TowerDefenseEventPreviewMonsterSpawner.SplineSpawnerPool.Get();
				if (towerDefenseEventSplineMonsterSpawner == null)
				{
					towerDefenseEventSplineMonsterSpawner = TowerDefenseEventPreviewMonsterSpawner.SplineSpawnerPool.Create();
				}
				towerDefenseEventSplineMonsterSpawner.Init(this, num2, trapDefenseMonsterPbGroup);
				this.SplineMonsterSpawners[num2] = towerDefenseEventSplineMonsterSpawner;
			}
		}
	}

	// Token: 0x06017483 RID: 95363 RVA: 0x005EAD28 File Offset: 0x005E8F28
	public int GetSpawnUid()
	{
		this.SpawnedUid += 2;
		return this.SpawnedUid;
	}

	// Token: 0x06017484 RID: 95364 RVA: 0x005EAD40 File Offset: 0x005E8F40
	public void OnTick(float delta)
	{
		if (this.SplineMonsterSpawners.Count == 0)
		{
			return;
		}
		foreach (TowerDefenseEventSplineMonsterSpawner towerDefenseEventSplineMonsterSpawner in this.SplineMonsterSpawners.Values)
		{
			towerDefenseEventSplineMonsterSpawner.OnTick(delta);
		}
	}

	// Token: 0x06017485 RID: 95365 RVA: 0x005EADA4 File Offset: 0x005E8FA4
	private void ReleaseSplineSpawners()
	{
		foreach (TowerDefenseEventSplineMonsterSpawner towerDefenseEventSplineMonsterSpawner in this.SplineMonsterSpawners.Values)
		{
			towerDefenseEventSplineMonsterSpawner.Reset();
			TowerDefenseEventPreviewMonsterSpawner.SplineSpawnerPool.Put(towerDefenseEventSplineMonsterSpawner);
		}
		this.SplineMonsterSpawners.Clear();
	}

	// Token: 0x06017486 RID: 95366 RVA: 0x005EAE14 File Offset: 0x005E9014
	public void RemovePreviewMonster(long uid)
	{
		foreach (TowerDefenseEventSplineMonsterSpawner towerDefenseEventSplineMonsterSpawner in this.SplineMonsterSpawners.Values)
		{
			towerDefenseEventSplineMonsterSpawner.RemovePreviewMonster(uid);
		}
	}

	// Token: 0x06017487 RID: 95367 RVA: 0x005EAE6C File Offset: 0x005E906C
	public void Reset()
	{
		this.SpawnedUid = 1;
		this.ReleaseSplines();
		this.ReleaseSplineSpawners();
	}

	// Token: 0x06017488 RID: 95368 RVA: 0x005EAE81 File Offset: 0x005E9081
	public void Clear()
	{
		this.Reset();
		TowerDefenseEventPreviewMonsterSpawner.SplineSpawnerPool.Clear();
	}

	// Token: 0x0400AE30 RID: 44592
	private static readonly Pool<TowerDefenseEventSplineMonsterSpawner> SplineSpawnerPool = new Pool<TowerDefenseEventSplineMonsterSpawner>(10, () => new TowerDefenseEventSplineMonsterSpawner(), null);

	// Token: 0x0400AE31 RID: 44593
	private int SpawnedUid = 1;

	// Token: 0x0400AE32 RID: 44594
	private readonly Dictionary<int, TowerDefenseEventSplineMonsterSpawner> SplineMonsterSpawners = new Dictionary<int, TowerDefenseEventSplineMonsterSpawner>();

	// Token: 0x0400AE33 RID: 44595
	private readonly List<int> PreviewSplineIds = new List<int>();

	// Token: 0x0400AE34 RID: 44596
	private readonly Dictionary<int, int> SpawnedSplines = new Dictionary<int, int>();
}
