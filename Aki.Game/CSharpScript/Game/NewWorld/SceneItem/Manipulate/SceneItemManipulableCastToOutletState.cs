using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x02006298 RID: 25240
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableCastToOutletState : SceneItemManipulableCastState
	{
		// Token: 0x0603CECC RID: 249548 RVA: 0x0117F716 File Offset: 0x0117D916
		public SceneItemManipulableCastToOutletState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, cameraShake, gamepadShake)
		{
		}

		// Token: 0x0603CECD RID: 249549 RVA: 0x0117F721 File Offset: 0x0117D921
		public void SetTarget(Entity newValue)
		{
			this.TargetInternal = newValue;
		}

		// Token: 0x0603CECE RID: 249550 RVA: 0x0117F72A File Offset: 0x0117D92A
		public override void SetEnterCallback(Action callback)
		{
			this.EnterCallback = callback;
		}

		// Token: 0x0603CECF RID: 249551 RVA: 0x0117F734 File Offset: 0x0117D934
		protected override void OnEnter()
		{
			Entity targetInternal = this.TargetInternal;
			if (targetInternal == null || !targetInternal.Valid)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "被控物进入CastToTarget时,没有设置目标", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.OnEnter();
			this.SceneItem.IsCanBeHeld = false;
			this.SceneItem.TargetActorComponent = this.TargetInternal.GetComponent<BaseActorComponent>();
			this.SceneItem.TargetOutletComponent = this.TargetInternal.GetComponent<SceneItemOutletComponent>();
			if (this.NeedNotifyServer)
			{
				LevelGamePlayController.Instance.ManipulatableBeCastOrDrop2Server(this.SceneItem.Entity.Id, EControlState.LockBaseThrowing);
			}
			base.StartCast();
			base.CalcDirection();
		}

		// Token: 0x0603CED0 RID: 249552 RVA: 0x0117F7E4 File Offset: 0x0117D9E4
		protected override void OnTick(float delta)
		{
			this.Timer += delta;
			float num = MathUtils.Instance.Clamp(this.Timer / this.CastDuration, 0f, 1f);
			UCurveFloat castCurve = this.SceneItem.CastCurve;
			if (castCurve != null && castCurve.IsValid())
			{
				num = this.SceneItem.CastCurve.GetFloatValue(num);
			}
			this.UpdateLocation(num);
			this.UpdateRotation(num);
			this.CheckFinish();
		}

		// Token: 0x0603CED1 RID: 249553 RVA: 0x0117F860 File Offset: 0x0117DA60
		protected override void OnExit()
		{
			base.OnExit();
			this.TargetInternal = null;
			this.SceneItem.StopSequence();
		}

		// Token: 0x0603CED2 RID: 249554 RVA: 0x0117F87C File Offset: 0x0117DA7C
		private void UpdateRotation(float alpha)
		{
			float alpha2 = UKismetMathLibrary.Ease(0f, 1f, alpha, EEasingFunc.EaseInOut, 2f, 2);
			global::Rotator socketRotator = this.SceneItem.TargetOutletComponent.GetSocketRotator(this.SceneItem.Entity);
			global::Rotator rotator = global::Rotator.Create();
			global::Rotator.Lerp(this.StartRot, socketRotator, alpha2, rotator);
			this.SceneItem.ActorComp.SetActorRotation(rotator.ToUeRotator(), "[ManipulableCastToOutletState.UpdateRotation]", false);
		}

		// Token: 0x0603CED3 RID: 249555 RVA: 0x0117F8F0 File Offset: 0x0117DAF0
		private void CheckFinish()
		{
			if (this.Timer < this.CastDuration && this.CastDuration > 0f)
			{
				return;
			}
			if (this.SceneItem.PlayingMatchSequence)
			{
				return;
			}
			if (this.SceneItem.MatchSequence != null)
			{
				this.SceneItem.PlayingMatchSequence = true;
				this.SceneItem.PlayMatchSequence(delegate
				{
					this.MatchOutlet();
					this.SceneItem.PlayingMatchSequence = false;
				}, false);
			}
			else
			{
				this.MatchOutlet();
			}
			if (this.FinishCallback != null)
			{
				this.FinishCallback();
			}
		}

		// Token: 0x0603CED4 RID: 249556 RVA: 0x0117F974 File Offset: 0x0117DB74
		private void MatchOutlet()
		{
			this.SceneItem.ActivatedOutlet = this.SceneItem.TargetOutletComponent;
			this.SceneItem.ActivatedOutlet.EntityInSocket = this.SceneItem;
			Entity entity = this.SceneItem.TargetOutletComponent.Entity;
			if (!this.SceneItem.ShouldPlayMismatchSequence(entity))
			{
				SceneItemManipulatableComponent sceneItem = this.SceneItem;
				if (sceneItem != null)
				{
					sceneItem.SetState(SceneItemManipulatableComponent.EManipulatableState.MatchingOutlet, "CastToOutlet Finish");
				}
				this.SceneItem.RequestAttachToOutlet();
				return;
			}
			this.SceneItem.CastFreeState.NeedResetPhysicsMode = false;
			SceneItemManipulatableComponent sceneItem2 = this.SceneItem;
			if (sceneItem2 != null)
			{
				sceneItem2.SetState(SceneItemManipulatableComponent.EManipulatableState.BeCastingFree, "CastToOutlet Finish");
			}
			SceneItemManipulatableComponent sceneItem3 = this.SceneItem;
			if (sceneItem3 == null)
			{
				return;
			}
			sceneItem3.TryPlayMismatchSequence(entity);
		}

		// Token: 0x040204D4 RID: 132308
		[Nullable(2)]
		private Entity TargetInternal;
	}
}
