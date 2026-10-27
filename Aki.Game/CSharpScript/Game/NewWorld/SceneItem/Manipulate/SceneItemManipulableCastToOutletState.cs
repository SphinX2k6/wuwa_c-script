using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071E3 RID: 29155
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableCastToOutletState : SceneItemManipulableCastState
	{
		// Token: 0x060475CA RID: 292298 RVA: 0x012258DE File Offset: 0x01223ADE
		public SceneItemManipulableCastToOutletState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, cameraShake, gamepadShake)
		{
		}

		// Token: 0x060475CB RID: 292299 RVA: 0x012258E9 File Offset: 0x01223AE9
		public void SetTarget(Entity newValue)
		{
			this.TargetInternal = newValue;
		}

		// Token: 0x060475CC RID: 292300 RVA: 0x012258F2 File Offset: 0x01223AF2
		public override void SetEnterCallback(Action callback)
		{
			this.EnterCallback = callback;
		}

		// Token: 0x060475CD RID: 292301 RVA: 0x012258FC File Offset: 0x01223AFC
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

		// Token: 0x060475CE RID: 292302 RVA: 0x012259AC File Offset: 0x01223BAC
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

		// Token: 0x060475CF RID: 292303 RVA: 0x01225A28 File Offset: 0x01223C28
		protected override void OnExit()
		{
			base.OnExit();
			this.TargetInternal = null;
			this.SceneItem.StopSequence();
		}

		// Token: 0x060475D0 RID: 292304 RVA: 0x01225A44 File Offset: 0x01223C44
		private void UpdateRotation(float alpha)
		{
			float alpha2 = UKismetMathLibrary.Ease(0f, 1f, alpha, EEasingFunc.EaseInOut, 2f, 2);
			global::Rotator socketRotator = this.SceneItem.TargetOutletComponent.GetSocketRotator(this.SceneItem.Entity);
			global::Rotator rotator = global::Rotator.Create();
			global::Rotator.Lerp(this.StartRot, socketRotator, alpha2, rotator);
			this.SceneItem.ActorComp.SetActorRotation(rotator.ToUeRotator(), "[ManipulableCastToOutletState.UpdateRotation]", false);
		}

		// Token: 0x060475D1 RID: 292305 RVA: 0x01225AB8 File Offset: 0x01223CB8
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

		// Token: 0x060475D2 RID: 292306 RVA: 0x01225B3C File Offset: 0x01223D3C
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

		// Token: 0x04025865 RID: 153701
		[Nullable(2)]
		private Entity TargetInternal;
	}
}
