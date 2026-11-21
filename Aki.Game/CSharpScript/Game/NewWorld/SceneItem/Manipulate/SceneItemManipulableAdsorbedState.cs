using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x02006292 RID: 25234
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableAdsorbedState : SceneItemManipulableBaseState
	{
		// Token: 0x0603CE8F RID: 249487 RVA: 0x0117DDB4 File Offset: 0x0117BFB4
		public SceneItemManipulableAdsorbedState(SceneItemManipulatableComponent sceneItem) : base(sceneItem)
		{
		}

		// Token: 0x0603CE90 RID: 249488 RVA: 0x0117DE14 File Offset: 0x0117C014
		protected override void OnEnter()
		{
			this.SceneItem.ClearCastDestroyTimer();
			this.SceneItem.TryAddTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中"]);
			this.SceneItem.IsCanBeHeld = true;
			base.OpenPhysicsSplit();
			this.PropComp.IsMoving = false;
			if (!FNameUtil.IsNothing(this.SceneItem.ManipulateBaseConfig.待机状态碰撞预设))
			{
				this.SceneItem.ActorComp.GetPrimitiveComponent().SetCollisionProfileName(this.SceneItem.ManipulateBaseConfig.待机状态碰撞预设, true);
			}
			if (!this.IsInit)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CH;
				string message = "被控物进入被吸附状态之前未初始化吸附配置";
				string item = "PbDataId";
				SceneItemManipulatableComponent sceneItem = this.SceneItem;
				int? num;
				if (sceneItem == null)
				{
					num = null;
				}
				else
				{
					SceneItemActorComponent actorComp = sceneItem.ActorComp;
					num = ((actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				}
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.SceneItem.ForceMoving = true;
			this.SceneItem.ResetForceDisplace();
			this.SceneItem.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.Kinematic;
			this.AdsorbTimer = 0f;
			this.IsFirst = true;
			Rotator startRot = this.StartRot;
			FRotator actorRotation = this.SceneItem.ActorComp.ActorRotation;
			startRot.DeepCopy(actorRotation);
		}

		// Token: 0x0603CE91 RID: 249489 RVA: 0x0117DF64 File Offset: 0x0117C164
		protected override void OnExit()
		{
			base.OnExit();
			this.SceneItem.ForceMoving = false;
			this.IsInit = false;
		}

		// Token: 0x0603CE92 RID: 249490 RVA: 0x0117DF80 File Offset: 0x0117C180
		protected override void OnTick(float delta)
		{
			if (this.IsFirst)
			{
				this.StartLoc.DeepCopy(this.SceneItem.ActorComp.ActorLocationProxy);
				this.IsFirst = false;
			}
			this.AdsorbTimer += delta;
			this.AdsorbTimer = Math.Min(this.AdsorbTimer, this.AdsorptionCurveLength);
			float floatValue = this.AdsorptionCurve.GetFloatValue(this.AdsorbTimer / this.AdsorptionCurveLength);
			Vector.Lerp(this.StartLoc, this.EndLoc, (double)floatValue, this.CurrentLoc);
			Rotator.Lerp(this.StartRot, this.EndRot, floatValue, this.CurrentRot);
			this.SceneItem.ActorComp.SetActorLocationAndRotation(this.CurrentLoc.ToUeVector(false), this.CurrentRot.ToUeRotator(), "[SceneItemOutletComponent.EntityMoveTickHandle]", false, null);
			if (this.AdsorbTimer >= this.AdsorptionCurveLength)
			{
				this.MatchOutlet();
				SceneItemManipulatableComponent sceneItem = this.SceneItem;
				if (sceneItem == null)
				{
					return;
				}
				sceneItem.SetState(SceneItemManipulatableComponent.EManipulatableState.MatchingOutlet, "AdsorbState over time");
			}
		}

		// Token: 0x0603CE93 RID: 249491 RVA: 0x0117E088 File Offset: 0x0117C288
		public void InitAdsorptionConfig([Nullable(2)] UCurveFloat adsorptionCurve, Vector endLoc, Rotator endRot)
		{
			this.IsInit = true;
			this.AdsorptionCurve = adsorptionCurve;
			if (adsorptionCurve != null)
			{
				float num = 0f;
				float adsorptionCurveLength = 0f;
				adsorptionCurve.GetTimeRange(ref num, ref adsorptionCurveLength);
				this.AdsorptionCurveLength = adsorptionCurveLength;
			}
			this.EndLoc.DeepCopy(endLoc);
			this.EndRot.DeepCopy(endRot);
		}

		// Token: 0x0603CE94 RID: 249492 RVA: 0x0117E0DB File Offset: 0x0117C2DB
		private void MatchOutlet()
		{
			this.SceneItem.ActivatedOutlet = this.SceneItem.TargetOutletComponent;
			this.SceneItem.ActivatedOutlet.EntityInSocket = this.SceneItem;
			this.SceneItem.RequestAttachToOutlet();
		}

		// Token: 0x04020499 RID: 132249
		private bool IsInit;

		// Token: 0x0402049A RID: 132250
		[Nullable(2)]
		private UCurveFloat AdsorptionCurve;

		// Token: 0x0402049B RID: 132251
		private float AdsorptionCurveLength;

		// Token: 0x0402049C RID: 132252
		private float AdsorbTimer;

		// Token: 0x0402049D RID: 132253
		private bool IsFirst = true;

		// Token: 0x0402049E RID: 132254
		private readonly Vector StartLoc = Vector.Create();

		// Token: 0x0402049F RID: 132255
		private readonly Vector EndLoc = Vector.Create();

		// Token: 0x040204A0 RID: 132256
		private readonly Vector CurrentLoc = Vector.Create();

		// Token: 0x040204A1 RID: 132257
		private readonly Rotator StartRot = Rotator.Create();

		// Token: 0x040204A2 RID: 132258
		private readonly Rotator EndRot = Rotator.Create();

		// Token: 0x040204A3 RID: 132259
		private readonly Rotator CurrentRot = Rotator.Create();
	}
}
