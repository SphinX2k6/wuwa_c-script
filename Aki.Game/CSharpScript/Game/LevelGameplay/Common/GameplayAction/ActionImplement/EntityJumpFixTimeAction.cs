using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F2F RID: 28463
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityJumpFixTimeAction : EntityMoveAction
	{
		// Token: 0x060453FE RID: 283646 RVA: 0x0112244C File Offset: 0x0112064C
		protected override void OnExecuteAction()
		{
			BaseActorComponent moveActorComp = base.GetMoveActorComp();
			if (moveActorComp == null)
			{
				base.FinishExecute();
				return;
			}
			IJumpConfig jumpConfig = this.Config as IJumpConfig;
			this.CurrentJumpTime = 0f;
			this.StartLocation.DeepCopy(moveActorComp.ActorLocationProxy);
			float num = (float)(this.TargetLocation.Z - this.StartLocation.Z);
			if (num >= 0f)
			{
				this.SignOffsetRate = MathCommon.Clamp(num / jumpConfig.MaxRiseHeightEdge, 0f, 1f);
				return;
			}
			this.SignOffsetRate = MathCommon.Clamp(num / jumpConfig.MaxFallHeightEdge, -1f, 0f);
		}

		// Token: 0x060453FF RID: 283647 RVA: 0x011224EE File Offset: 0x011206EE
		protected override void OnInterruptAction()
		{
		}

		// Token: 0x06045400 RID: 283648 RVA: 0x011224F0 File Offset: 0x011206F0
		public override void TickAction(float delta)
		{
			BaseActorComponent moveActorComp = base.GetMoveActorComp();
			if (moveActorComp == null)
			{
				base.FinishExecute();
				return;
			}
			IJumpConfig jumpConfig = this.Config as IJumpConfig;
			this.CurrentJumpTime += delta;
			if (this.CurrentJumpTime >= jumpConfig.JumpTime)
			{
				moveActorComp.SetActorLocationAndRotation(this.TargetLocation.ToUeVector(false), this.TargetRotator.ToUeRotator(), "EntityJumpFixTimeAction", false, null);
				CharacterActorComponent characterActorComponent = moveActorComp as CharacterActorComponent;
				if (characterActorComponent != null)
				{
					characterActorComponent.SetInputRotator(this.TempRotator);
				}
				base.FinishExecute();
				return;
			}
			float num = MathCommon.Clamp(this.CurrentJumpTime / jumpConfig.JumpTime, 0f, 1f);
			Vector.Lerp(this.StartLocation, this.TargetLocation, (double)num, this.TempVector);
			float powerCurveValue = this.GetPowerCurveValue(num, 2f);
			float floatValue;
			if (this.SignOffsetRate > 0f)
			{
				floatValue = jumpConfig.MoveRiseCurve.GetFloatValue(num);
			}
			else
			{
				floatValue = jumpConfig.MoveFallCurve.GetFloatValue(num);
			}
			float num2 = Math.Abs(this.SignOffsetRate);
			float num3 = (powerCurveValue * (1f - num2) + floatValue * num2) * jumpConfig.MoveBaseHeightOffset;
			this.TempVector.Z += (double)num3;
			Rotator actorRotationProxy = moveActorComp.ActorRotationProxy;
			if (!actorRotationProxy.Equals2(this.TargetRotator, 0.0001f))
			{
				this.TempRotator.DeepCopy(this.TargetRotator);
				MathUtils.Instance.RotatorInterpConstantTo(actorRotationProxy, this.TempRotator, delta * 0.001f, jumpConfig.RotateSpeed, this.TempRotator);
				moveActorComp.SetActorLocationAndRotation(this.TempVector.ToUeVector(false), this.TempRotator.ToUeRotator(), "EntityJumpFixTimeAction", false, null);
				CharacterActorComponent characterActorComponent2 = moveActorComp as CharacterActorComponent;
				if (characterActorComponent2 != null)
				{
					characterActorComponent2.SetInputRotator(this.TempRotator);
				}
				return;
			}
			moveActorComp.SetActorLocation(this.TempVector.ToUeVector(false), "EntityJumpFixTimeAction", false);
		}

		// Token: 0x06045401 RID: 283649 RVA: 0x011226E1 File Offset: 0x011208E1
		private float GetPowerCurveValue(float key, float pow)
		{
			return 1f - (float)Math.Pow((double)Math.Abs(2f * key - 1f), (double)pow);
		}

		// Token: 0x040241AA RID: 147882
		private float CurrentJumpTime;

		// Token: 0x040241AB RID: 147883
		private float SignOffsetRate;

		// Token: 0x040241AC RID: 147884
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x040241AD RID: 147885
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x040241AE RID: 147886
		private readonly Rotator TempRotator = Rotator.Create();
	}
}
