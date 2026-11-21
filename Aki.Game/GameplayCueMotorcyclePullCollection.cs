using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

// Token: 0x02002521 RID: 9505
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueMotorcyclePullCollection : GameplayCueBase
{
	// Token: 0x06017827 RID: 96295 RVA: 0x006EFD9F File Offset: 0x006EDF9F
	protected override void OnInit()
	{
	}

	// Token: 0x06017828 RID: 96296 RVA: 0x006EFDA4 File Offset: 0x006EDFA4
	public override void OnDisable()
	{
		VehicleBuffComponent motorcycleBuffComponent = this.MotorcycleBuffComponent;
		if (motorcycleBuffComponent != null)
		{
			motorcycleBuffComponent.RemoveBuff(640003034L, 1, "模拟摩托车采集物采集过程结束", null, null, null);
		}
		this.FakePullCollectionFinished = true;
	}

	// Token: 0x06017829 RID: 96297 RVA: 0x006EFDF0 File Offset: 0x006EDFF0
	protected override void OnTick(float delta)
	{
		if (this.HookItem == null)
		{
			return;
		}
		if (this.FakePullCollectionProgress)
		{
			this.FakePullCollectionProgressTick(delta);
			return;
		}
		this.PullCollectionProgressTick(delta);
	}

	// Token: 0x0601782A RID: 96298 RVA: 0x006EFE14 File Offset: 0x006EE014
	private void FakePullCollectionProgressTick(float delta)
	{
		if (this.FakePullCollectionFinished)
		{
			Log.Instance.Info(ELogModule.SceneItem, ELogAuthor.CK, "模拟摩托车采集物采集过程已经结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		CharacterActorComponent characterActorComponent;
		if (getCurrentEntity == null)
		{
			characterActorComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
		}
		CharacterActorComponent characterActorComponent2 = characterActorComponent;
		if (characterActorComponent2 == null || !characterActorComponent2.Valid)
		{
			VehicleBuffComponent motorcycleBuffComponent = this.MotorcycleBuffComponent;
			if (motorcycleBuffComponent != null)
			{
				motorcycleBuffComponent.RemoveBuff(640003034L, 1, "模拟摩托车采集物采集过程结束", null, null, null);
			}
			this.FakePullCollectionFinished = true;
			return;
		}
		this.CurrentMoveSpeed = MathF.Min(this.CurrentMoveSpeed + 500f, 6000f);
		this.TmpVector.DeepCopy(characterActorComponent2.ActorLocationProxy);
		if (this.TmpVector.SubtractionEqual(this.PullingTargetLocation).SizeSquared() < 22500.0)
		{
			VehicleBuffComponent motorcycleBuffComponent2 = this.MotorcycleBuffComponent;
			if (motorcycleBuffComponent2 != null)
			{
				motorcycleBuffComponent2.RemoveBuff(640003034L, 1, "模拟摩托车采集物采集过程结束", null, null, null);
			}
			this.FakePullCollectionFinished = true;
			return;
		}
		this.TmpVector.Normalize(0.009999999776482582);
		this.TmpVector.MultiplyEqual((double)(this.CurrentMoveSpeed * delta)).AdditionEqual(this.PullingTargetLocation);
		GameplayCueHookCommonItem hookItem = this.HookItem;
		if (hookItem != null)
		{
			hookItem.Tick(this.TmpVector.ToUeVector(false));
		}
		this.PullingTargetLocation.DeepCopy(this.TmpVector);
	}

	// Token: 0x0601782B RID: 96299 RVA: 0x006EFFAC File Offset: 0x006EE1AC
	private void PullCollectionProgressTick(float delta)
	{
		GrapplingHookPointComponent pullingTarget = this.PullingTarget;
		if (pullingTarget == null || !pullingTarget.Valid || !this.PullingTarget.Active)
		{
			return;
		}
		FVectorDouble fvectorDouble = this.PullingTarget.TriggerLocation.ToUeVector(false);
		GameplayCueHookCommonItem hookItem = this.HookItem;
		if (hookItem != null)
		{
			hookItem.Tick(fvectorDouble);
		}
		this.LastLocation = new FVectorDouble?(fvectorDouble);
	}

	// Token: 0x0601782C RID: 96300 RVA: 0x006F0010 File Offset: 0x006EE210
	protected override void OnCreate()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		MotorcycleExploreComponent motorcycleExploreComponent = (entity != null) ? entity.GetComponent<MotorcycleExploreComponent>() : null;
		if (motorcycleExploreComponent == null || !motorcycleExploreComponent.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CK, "GameplayCueMotorcyclePullCollection播放失败, 摩托车探索组件已失效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		WorldEntity entity2 = this.EntityHandle.Entity;
		this.MotorcycleBuffComponent = ((entity2 != null) ? entity2.GetComponent<VehicleBuffComponent>() : null);
		VehicleBuffComponent motorcycleBuffComponent = this.MotorcycleBuffComponent;
		if (motorcycleBuffComponent == null || !motorcycleBuffComponent.Valid)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CK, "GameplayCueMotorcyclePullCollection播放失败, 摩托车Buff组件已失效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GrapplingHookPointComponent pullingTarget = motorcycleExploreComponent.PullingTarget;
		if (pullingTarget == null || !pullingTarget.Active)
		{
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CK, "GameplayCueMotorcyclePullCollection播放失败, 当前探索组件正在交互实体已失效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PullingTarget = pullingTarget;
		this.FakePullCollectionProgress = !pullingTarget.PullCollectionWithProgress;
		if (this.FakePullCollectionProgress)
		{
			this.PullingTargetLocation.DeepCopy(this.PullingTarget.TriggerLocation);
		}
		this.HookItem = GameplayCueHookCommonItem.Spawn(this.ActorInternal, FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value, this.PullingTargetLocation.ToUeVector(false), this.GetResourcePaths(), true);
	}

	// Token: 0x0601782D RID: 96301 RVA: 0x006F0154 File Offset: 0x006EE354
	private string[] GetResourcePaths()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		string[] array = this.CueConfig.Resources();
		if (baseActorComponent == null || !baseActorComponent.Valid)
		{
			return array;
		}
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (baseActorComponent.GetReplaceEffect(array[i]) ?? array[i]);
		}
		return array2;
	}

	// Token: 0x0601782E RID: 96302 RVA: 0x006F01C3 File Offset: 0x006EE3C3
	protected override void OnDestroy()
	{
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
	}

	// Token: 0x0400C7F8 RID: 51192
	[Nullable(2)]
	private GameplayCueHookCommonItem HookItem;

	// Token: 0x0400C7F9 RID: 51193
	[Nullable(2)]
	private GrapplingHookPointComponent PullingTarget;

	// Token: 0x0400C7FA RID: 51194
	[Nullable(2)]
	private VehicleBuffComponent MotorcycleBuffComponent;

	// Token: 0x0400C7FB RID: 51195
	private FVectorDouble? LastLocation;

	// Token: 0x0400C7FC RID: 51196
	private readonly Vector PullingTargetLocation = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400C7FD RID: 51197
	private readonly Vector TmpVector = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400C7FE RID: 51198
	private bool FakePullCollectionProgress;

	// Token: 0x0400C7FF RID: 51199
	private bool FakePullCollectionFinished;

	// Token: 0x0400C800 RID: 51200
	private float CurrentMoveSpeed;

	// Token: 0x0400C801 RID: 51201
	private const float NORMALIZE = 0.01f;

	// Token: 0x0400C802 RID: 51202
	private const int PULL_COLLECTION_EFFECT_BUFF_ID = 640003034;
}
