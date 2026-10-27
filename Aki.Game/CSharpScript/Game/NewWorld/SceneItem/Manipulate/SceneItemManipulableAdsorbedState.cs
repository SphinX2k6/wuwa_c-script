using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071DD RID: 29149
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableAdsorbedState : SceneItemManipulableBaseState
	{
		// Token: 0x0604758D RID: 292237 RVA: 0x01223F80 File Offset: 0x01222180
		public SceneItemManipulableAdsorbedState(SceneItemManipulatableComponent sceneItem) : base(sceneItem)
		{
		}

		// Token: 0x0604758E RID: 292238 RVA: 0x01223FE0 File Offset: 0x012221E0
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

		// Token: 0x0604758F RID: 292239 RVA: 0x01224130 File Offset: 0x01222330
		protected override void OnExit()
		{
			base.OnExit();
			this.SceneItem.ForceMoving = false;
			this.IsInit = false;
		}

		// Token: 0x06047590 RID: 292240 RVA: 0x0122414C File Offset: 0x0122234C
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

		// Token: 0x06047591 RID: 292241 RVA: 0x01224254 File Offset: 0x01222454
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

		// Token: 0x06047592 RID: 292242 RVA: 0x012242A7 File Offset: 0x012224A7
		private void MatchOutlet()
		{
			this.SceneItem.ActivatedOutlet = this.SceneItem.TargetOutletComponent;
			this.SceneItem.ActivatedOutlet.EntityInSocket = this.SceneItem;
			this.SceneItem.RequestAttachToOutlet();
		}

		// Token: 0x0402582A RID: 153642
		private bool IsInit;

		// Token: 0x0402582B RID: 153643
		[Nullable(2)]
		private UCurveFloat AdsorptionCurve;

		// Token: 0x0402582C RID: 153644
		private float AdsorptionCurveLength;

		// Token: 0x0402582D RID: 153645
		private float AdsorbTimer;

		// Token: 0x0402582E RID: 153646
		private bool IsFirst = true;

		// Token: 0x0402582F RID: 153647
		private readonly Vector StartLoc = Vector.Create();

		// Token: 0x04025830 RID: 153648
		private readonly Vector EndLoc = Vector.Create();

		// Token: 0x04025831 RID: 153649
		private readonly Vector CurrentLoc = Vector.Create();

		// Token: 0x04025832 RID: 153650
		private readonly Rotator StartRot = Rotator.Create();

		// Token: 0x04025833 RID: 153651
		private readonly Rotator EndRot = Rotator.Create();

		// Token: 0x04025834 RID: 153652
		private readonly Rotator CurrentRot = Rotator.Create();
	}
}
