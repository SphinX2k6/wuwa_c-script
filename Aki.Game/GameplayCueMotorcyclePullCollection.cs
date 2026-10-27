using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

// Token: 0x02002FCD RID: 12237
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueMotorcyclePullCollection : GameplayCueBase
{
	// Token: 0x06019F15 RID: 106261 RVA: 0x006C94CB File Offset: 0x006C76CB
	protected override void OnInit()
	{
	}

	// Token: 0x06019F16 RID: 106262 RVA: 0x006C94D0 File Offset: 0x006C76D0
	public override void OnDisable()
	{
		VehicleBuffComponent motorcycleBuffComponent = this.MotorcycleBuffComponent;
		if (motorcycleBuffComponent != null)
		{
			motorcycleBuffComponent.RemoveBuff(640003034L, 1, "模拟摩托车采集物采集过程结束", null, null, null);
		}
		this.FakePullCollectionFinished = true;
	}

	// Token: 0x06019F17 RID: 106263 RVA: 0x006C951C File Offset: 0x006C771C
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

	// Token: 0x06019F18 RID: 106264 RVA: 0x006C9540 File Offset: 0x006C7740
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

	// Token: 0x06019F19 RID: 106265 RVA: 0x006C96D8 File Offset: 0x006C78D8
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

	// Token: 0x06019F1A RID: 106266 RVA: 0x006C973C File Offset: 0x006C793C
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

	// Token: 0x06019F1B RID: 106267 RVA: 0x006C9880 File Offset: 0x006C7A80
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

	// Token: 0x06019F1C RID: 106268 RVA: 0x006C98EF File Offset: 0x006C7AEF
	protected override void OnDestroy()
	{
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
	}

	// Token: 0x0400C44F RID: 50255
	[Nullable(2)]
	private GameplayCueHookCommonItem HookItem;

	// Token: 0x0400C450 RID: 50256
	[Nullable(2)]
	private GrapplingHookPointComponent PullingTarget;

	// Token: 0x0400C451 RID: 50257
	[Nullable(2)]
	private VehicleBuffComponent MotorcycleBuffComponent;

	// Token: 0x0400C452 RID: 50258
	private FVectorDouble? LastLocation;

	// Token: 0x0400C453 RID: 50259
	private readonly Vector PullingTargetLocation = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400C454 RID: 50260
	private readonly Vector TmpVector = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400C455 RID: 50261
	private bool FakePullCollectionProgress;

	// Token: 0x0400C456 RID: 50262
	private bool FakePullCollectionFinished;

	// Token: 0x0400C457 RID: 50263
	private float CurrentMoveSpeed;

	// Token: 0x0400C458 RID: 50264
	private const float NORMALIZE = 0.01f;

	// Token: 0x0400C459 RID: 50265
	private const int PULL_COLLECTION_EFFECT_BUFF_ID = 640003034;
}
