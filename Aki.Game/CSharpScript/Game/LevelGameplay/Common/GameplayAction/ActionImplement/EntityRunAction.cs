using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F2A RID: 28458
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityRunAction : EntityMoveAction
	{
		// Token: 0x060453D9 RID: 283609 RVA: 0x01122168 File Offset: 0x01120368
		protected override void OnExecuteAction()
		{
			BaseActorComponent moveActorComp = base.GetMoveActorComp();
			if (moveActorComp == null)
			{
				base.FinishExecute();
				return;
			}
			this.TargetLocation.Subtraction(moveActorComp.ActorLocationProxy, this.MoveDirection);
			this.MoveDirection.Normalize(9.99999993922529E-09);
		}

		// Token: 0x060453DA RID: 283610 RVA: 0x011221B3 File Offset: 0x011203B3
		protected override void OnInterruptAction()
		{
		}

		// Token: 0x060453DB RID: 283611 RVA: 0x011221B8 File Offset: 0x011203B8
		public override void TickAction(float delta)
		{
			BaseActorComponent moveActorComp = base.GetMoveActorComp();
			if (moveActorComp == null)
			{
				base.FinishExecute();
				return;
			}
			IRunConfig runConfig = this.Config as IRunConfig;
			Vector actorLocationProxy = moveActorComp.ActorLocationProxy;
			this.TargetLocation.Subtraction(actorLocationProxy, this.TempVector);
			double num = this.TempVector.SizeSquared();
			float num2 = runConfig.MoveSpeed * delta * 0.001f;
			if ((double)(num2 * num2) > num)
			{
				moveActorComp.SetActorLocationAndRotation(this.TargetLocation.ToUeVector(false), this.TargetRotator.ToUeRotator(), "EntityRunAction", false, null);
				CharacterActorComponent characterActorComponent = moveActorComp as CharacterActorComponent;
				if (characterActorComponent != null)
				{
					characterActorComponent.SetInputRotator(this.TempRotator);
				}
				base.FinishExecute();
				return;
			}
			this.TempVector.DeepCopy(this.MoveDirection);
			this.TempVector.MultiplyEqual((double)num2);
			this.TempVector.AdditionEqual(actorLocationProxy);
			Rotator actorRotationProxy = moveActorComp.ActorRotationProxy;
			if (!actorRotationProxy.Equals2(this.TargetRotator, 0.0001f))
			{
				this.TempRotator.DeepCopy(this.TargetRotator);
				MathUtils.Instance.RotatorInterpConstantTo(actorRotationProxy, this.TempRotator, delta * 0.001f, runConfig.RotateSpeed, this.TempRotator);
				moveActorComp.SetActorLocationAndRotation(this.TempVector.ToUeVector(false), this.TempRotator.ToUeRotator(), "EntityRunAction", false, null);
				CharacterActorComponent characterActorComponent2 = moveActorComp as CharacterActorComponent;
				if (characterActorComponent2 != null)
				{
					characterActorComponent2.SetInputRotator(this.TempRotator);
				}
				return;
			}
			moveActorComp.SetActorLocation(this.TempVector.ToUeVector(false), "EntityRunAction", false);
		}

		// Token: 0x0402419C RID: 147868
		private readonly Vector MoveDirection = Vector.Create();

		// Token: 0x0402419D RID: 147869
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0402419E RID: 147870
		private readonly Rotator TempRotator = Rotator.Create();
	}
}
