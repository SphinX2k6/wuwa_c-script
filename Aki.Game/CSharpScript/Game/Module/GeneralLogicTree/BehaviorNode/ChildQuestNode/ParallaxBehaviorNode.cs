using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049B2 RID: 18866
	[NullableContext(1)]
	[Nullable(0)]
	public class ParallaxBehaviorNode : TickBehaviorNode
	{
		// Token: 0x0602F3F9 RID: 193529 RVA: 0x00D2CAD6 File Offset: 0x00D2ACD6
		public ParallaxBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F3FA RID: 193530 RVA: 0x00D2CAF8 File Offset: 0x00D2ACF8
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			if (base.OnCreate(nodeConfig))
			{
				IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
				if (childQuestBtNode != null)
				{
					IParallaxAlignQuestCondition parallaxAlignQuestCondition = childQuestBtNode.Condition as IParallaxAlignQuestCondition;
					if (parallaxAlignQuestCondition == null)
					{
						return false;
					}
					this.Config = parallaxAlignQuestCondition;
					if (this.Config == null)
					{
						return false;
					}
					this.PointA = Vector.Create((double)this.Config.SourcePos.X.GetValueOrDefault(), (double)this.Config.SourcePos.Y.GetValueOrDefault(), (double)this.Config.SourcePos.Z.GetValueOrDefault());
					this.PointB = Vector.Create((double)this.Config.TargetPos.X.GetValueOrDefault(), (double)this.Config.TargetPos.Y.GetValueOrDefault(), (double)this.Config.TargetPos.Z.GetValueOrDefault());
					return base.OnCreate(nodeConfig);
				}
			}
			return false;
		}

		// Token: 0x0602F3FB RID: 193531 RVA: 0x00D2CBF0 File Offset: 0x00D2ADF0
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			this.IsFinish = false;
			int valueOrDefault = this.Config.BallEntity.GetValueOrDefault();
			if (valueOrDefault != 0)
			{
				int entityIdByPbDataId = CreatureModel.Instance.GetEntityIdByPbDataId(valueOrDefault);
				if (entityIdByPbDataId != 0)
				{
					this.ActorComponent = EntitySystem.Instance.GetComponent<SceneItemActorComponent>(entityIdByPbDataId);
				}
			}
			base.OnStart(reason);
		}

		// Token: 0x0602F3FC RID: 193532 RVA: 0x00D2CC42 File Offset: 0x00D2AE42
		protected override void OnEnd(bool bFinished)
		{
			this.IsFinish = true;
			base.OnEnd(bFinished);
		}

		// Token: 0x0602F3FD RID: 193533 RVA: 0x00D2CC54 File Offset: 0x00D2AE54
		protected override void OnTick(float delta)
		{
			if (this.IsFinish)
			{
				return;
			}
			FVector2D fvector2D = new FVector2D();
			APlayerController playerController = Global.PlayerController;
			FVectorDouble fvectorDouble = this.PointA.ToUeVector(false);
			if (!UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble, ref fvector2D, false))
			{
				this.FixingTime = 0f;
				return;
			}
			this.ScreenPointA.FromUeVector2D(fvector2D);
			APlayerController playerController2 = Global.PlayerController;
			fvectorDouble = this.PointB.ToUeVector(false);
			if (!UGameplayStatics.D_ProjectWorldToScreen(playerController2, fvectorDouble, ref fvector2D, false))
			{
				this.FixingTime = 0f;
				return;
			}
			this.ScreenPointB.FromUeVector2D(fvector2D);
			int valueOrDefault = this.Config.BallEntity.GetValueOrDefault();
			if (this.ActorComponent == null && valueOrDefault != 0)
			{
				int entityIdByPbDataId = CreatureModel.Instance.GetEntityIdByPbDataId(valueOrDefault);
				if (entityIdByPbDataId != 0)
				{
					this.ActorComponent = EntitySystem.Instance.GetComponent<SceneItemActorComponent>(entityIdByPbDataId);
				}
			}
			APlayerController playerController3 = Global.PlayerController;
			int num = 0;
			int num2 = 0;
			playerController3.GetViewportSize(ref num, ref num2);
			double num3 = Math.Max(Math.Abs(this.ScreenPointA.X - this.ScreenPointB.X) / (double)num, Math.Abs(this.ScreenPointA.Y - this.ScreenPointB.Y) / (double)num2);
			if (this.ActorComponent != null)
			{
				float num4 = (float)MathCommon.Clamp((num3 - (double)this.Config.ErrorRange) / (double)(this.Config.BrightnessAdjustRange.Value - this.Config.ErrorRange), 0.0, 1.0);
				float valueOrDefault2 = this.Config.DefaultBrightness.GetValueOrDefault();
				if (this.Config.FinalColor != null)
				{
					float value = this.Config.FinalColor.R.Value;
					float value2 = this.Config.FinalColor.G.Value;
					float value3 = this.Config.FinalColor.B.Value;
					float value4 = this.Config.FinalColor.A.Value;
					float r = MathCommon.Lerp(valueOrDefault2 * value, value, 1f - num4) / 255f;
					float g = MathCommon.Lerp(valueOrDefault2 * value2, value2, 1f - num4) / 255f;
					float b = MathCommon.Lerp(valueOrDefault2 * value3, value3, 1f - num4) / 255f;
					float a = MathCommon.Lerp(valueOrDefault2 * value4, value4, 1f - num4);
					this.ActorComponent.UpdateInteractionMaterialColorParam("E_Action_EmissionColor", r, g, b, a);
				}
				else
				{
					float num5 = MathCommon.Lerp(valueOrDefault2, 1f, 1f - num4);
					this.ActorComponent.UpdateInteractionMaterialColorParam("E_Action_EmissionColor", num5, num5, num5, 1f);
				}
			}
			if (num3 > (double)this.Config.ErrorRange)
			{
				this.FixingTime = 0f;
				return;
			}
			this.FixingTime += delta;
			float valueOrDefault3 = this.Config.FixationTime.GetValueOrDefault();
			if (valueOrDefault3 == 0f || this.FixingTime >= valueOrDefault3 * 1000f)
			{
				this.SubmitNode(null);
				this.IsFinish = true;
			}
		}

		// Token: 0x040190EA RID: 102634
		private const string EMISSION_PARAM_NAME = "E_Action_EmissionColor";

		// Token: 0x040190EB RID: 102635
		[Nullable(2)]
		private Vector PointA;

		// Token: 0x040190EC RID: 102636
		[Nullable(2)]
		private Vector PointB;

		// Token: 0x040190ED RID: 102637
		private readonly Vector2D ScreenPointA = Vector2D.Create();

		// Token: 0x040190EE RID: 102638
		private readonly Vector2D ScreenPointB = Vector2D.Create();

		// Token: 0x040190EF RID: 102639
		[Nullable(2)]
		private IParallaxAlignQuestCondition Config;

		// Token: 0x040190F0 RID: 102640
		private float FixingTime;

		// Token: 0x040190F1 RID: 102641
		private bool IsFinish;

		// Token: 0x040190F2 RID: 102642
		[Nullable(2)]
		private SceneItemActorComponent ActorComponent;
	}
}
