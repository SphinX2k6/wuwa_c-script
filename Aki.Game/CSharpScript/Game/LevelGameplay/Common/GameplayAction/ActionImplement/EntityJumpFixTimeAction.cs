using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060B0 RID: 24752
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityJumpFixTimeAction : EntityMoveAction
	{
		// Token: 0x0603B5AC RID: 243116 RVA: 0x010CC3F8 File Offset: 0x010CA5F8
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

		// Token: 0x0603B5AD RID: 243117 RVA: 0x010CC49A File Offset: 0x010CA69A
		protected override void OnInterruptAction()
		{
		}

		// Token: 0x0603B5AE RID: 243118 RVA: 0x010CC49C File Offset: 0x010CA69C
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

		// Token: 0x0603B5AF RID: 243119 RVA: 0x010CC68D File Offset: 0x010CA88D
		private float GetPowerCurveValue(float key, float pow)
		{
			return 1f - (float)Math.Pow((double)Math.Abs(2f * key - 1f), (double)pow);
		}

		// Token: 0x0401F45F RID: 128095
		private float CurrentJumpTime;

		// Token: 0x0401F460 RID: 128096
		private float SignOffsetRate;

		// Token: 0x0401F461 RID: 128097
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401F462 RID: 128098
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401F463 RID: 128099
		private readonly Rotator TempRotator = Rotator.Create();
	}
}
