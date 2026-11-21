using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TowerDefenseEvent.Define;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

// Token: 0x02002145 RID: 8517
[NullableContext(1)]
[Nullable(0)]
internal class TowerDefenseEventSplineMonsterSpawner
{
	// Token: 0x06014EA8 RID: 85672 RVA: 0x0061701C File Offset: 0x0061521C
	public unsafe void Init(TowerDefenseEventPreviewMonsterSpawner owner, int splineId, TrapDefenseMonsterPbGroup group)
	{
		this.Owner = owner;
		this.SplineId = splineId;
		this.SpawnDelay = TimeUtil.Instance.SetTimeMillisecond((double)group.PreviewDelayTime);
		this.SpawnInterval = TimeUtil.Instance.SetTimeMillisecond((double)group.PreviewIntervalTime);
		this.SpawnTimestamp = this.SpawnDelay;
		this.SpawnIndex = 0;
		foreach (int configId in group.MonsterConfigIds)
		{
			TowerDefenseEventMonsterModel towerDefenseEventMonsterModel = TowerDefenseEventMonsterModel.InitFromConfigId(configId);
			string text = TowerDefenseEventConfig.FillUpModelInfo(towerDefenseEventMonsterModel, false);
			if (text != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefenseEvent;
				ELogAuthor author = ELogAuthor.XY;
				string message = "初始化预览怪物失败: " + text;
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", towerDefenseEventMonsterModel.ConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("templateId", towerDefenseEventMonsterModel.TemplateId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("combatId", towerDefenseEventMonsterModel.CombatId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("subTypeId", towerDefenseEventMonsterModel.SubTypeId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				towerDefenseEventMonsterModel.Release();
			}
			else
			{
				this.PreviewMonsters.Add(towerDefenseEventMonsterModel);
			}
		}
	}

	// Token: 0x06014EA9 RID: 85673 RVA: 0x00617194 File Offset: 0x00615394
	public void OnTick(float delta)
	{
		if (this.PreviewMonsters.Count == 0 || delta > 1000f)
		{
			return;
		}
		this.SpawnTimestamp -= (double)delta;
		if (this.SpawnTimestamp > 0.0)
		{
			return;
		}
		this.SpawnIndex %= this.PreviewMonsters.Count;
		this.SpawnPreviewMonster();
		this.SpawnTimestamp = this.SpawnTimestamp % this.SpawnInterval + this.SpawnInterval;
		this.SpawnIndex++;
	}

	// Token: 0x06014EAA RID: 85674 RVA: 0x00617220 File Offset: 0x00615420
	private unsafe void SpawnPreviewMonster()
	{
		ITowerDefenseEventMonsterInfo towerDefenseEventMonsterInfo = this.PreviewMonsters[this.SpawnIndex];
		if (towerDefenseEventMonsterInfo == null)
		{
			return;
		}
		int spawnUid = this.Owner.GetSpawnUid();
		USplineComponent usplineComponent = null;
		if (this.SplineId != 0)
		{
			usplineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(this.SplineId, spawnUid, EIdType.SimpleCombatPreviewId);
			if (usplineComponent == null)
			{
				GameSplineModel.Instance.ReleaseSpline(this.SplineId, (long)spawnUid, EIdType.SimpleCombatPreviewId);
			}
		}
		if (usplineComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TowerDefenseEvent;
			ELogAuthor author = ELogAuthor.XY;
			string message = "预览怪物生成失败，样条线组件未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", towerDefenseEventMonsterInfo.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("splineId", this.SplineId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		FVectorDouble fvectorDouble = usplineComponent.D_GetLocationAtSplinePoint(0, ESplineCoordinateSpace.World);
		FRotator rotationAtSplinePoint = usplineComponent.GetRotationAtSplinePoint(0, ESplineCoordinateSpace.World);
		FVector fvector = global::Vector.OneVectorDouble;
		FTransformDouble transform = new FTransformDouble(ref rotationAtSplinePoint, ref fvectorDouble, ref fvector);
		KuroSimpleCombatController.Instance.AsyncAddEntity(new KscEntityParam
		{
			CreatureId = (long)spawnUid,
			SimpleCombatId = towerDefenseEventMonsterInfo.CombatId,
			AssetPath = towerDefenseEventMonsterInfo.AssetPath,
			PropertyId = towerDefenseEventMonsterInfo.PropertyId,
			Transform = transform,
			Spline = usplineComponent,
			IsPreview = new bool?(true)
		});
		this.SpawnedMonsters[(long)spawnUid] = towerDefenseEventMonsterInfo;
	}

	// Token: 0x06014EAB RID: 85675 RVA: 0x00617380 File Offset: 0x00615580
	public void RemovePreviewMonster(long uid)
	{
		ITowerDefenseEventMonsterInfo towerDefenseEventMonsterInfo;
		if (!this.SpawnedMonsters.TryGetValue(uid, out towerDefenseEventMonsterInfo))
		{
			return;
		}
		if (towerDefenseEventMonsterInfo.SplineId != null)
		{
			int? splineId = towerDefenseEventMonsterInfo.SplineId;
			int num = 0;
			if (!(splineId.GetValueOrDefault() == num & splineId != null))
			{
				GameSplineModel.Instance.ReleaseSpline(towerDefenseEventMonsterInfo.SplineId.Value, uid, EIdType.SimpleCombatPreviewId);
			}
		}
		this.SpawnedMonsters.Remove(uid);
	}

	// Token: 0x06014EAC RID: 85676 RVA: 0x006173F4 File Offset: 0x006155F4
	private void ReleasePreviewMonsters()
	{
		foreach (KeyValuePair<long, ITowerDefenseEventMonsterInfo> keyValuePair in this.SpawnedMonsters)
		{
			long key = keyValuePair.Key;
			ITowerDefenseEventMonsterInfo value = keyValuePair.Value;
			KuroSimpleCombatController.Instance.RemoveEntity(key, TowerDefenseEventRemoveReason.Preview);
			if (value.SplineId != null && value.SplineId.Value != 0)
			{
				GameSplineModel.Instance.ReleaseSpline(value.SplineId.Value, key, EIdType.SimpleCombatPreviewId);
			}
		}
		this.SpawnedMonsters.Clear();
		foreach (ITowerDefenseEventMonsterInfo towerDefenseEventMonsterInfo in this.PreviewMonsters)
		{
			towerDefenseEventMonsterInfo.Release();
		}
		this.PreviewMonsters.Clear();
	}

	// Token: 0x06014EAD RID: 85677 RVA: 0x006174F4 File Offset: 0x006156F4
	public void Reset()
	{
		this.ReleasePreviewMonsters();
	}

	// Token: 0x0400B22D RID: 45613
	[Nullable(2)]
	private TowerDefenseEventPreviewMonsterSpawner Owner;

	// Token: 0x0400B22E RID: 45614
	private int SplineId;

	// Token: 0x0400B22F RID: 45615
	private double SpawnDelay;

	// Token: 0x0400B230 RID: 45616
	private double SpawnInterval;

	// Token: 0x0400B231 RID: 45617
	private readonly List<ITowerDefenseEventMonsterInfo> PreviewMonsters = new List<ITowerDefenseEventMonsterInfo>();

	// Token: 0x0400B232 RID: 45618
	private readonly Dictionary<long, ITowerDefenseEventMonsterInfo> SpawnedMonsters = new Dictionary<long, ITowerDefenseEventMonsterInfo>();

	// Token: 0x0400B233 RID: 45619
	private double SpawnTimestamp;

	// Token: 0x0400B234 RID: 45620
	private int SpawnIndex;
}
