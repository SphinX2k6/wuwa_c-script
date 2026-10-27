using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070D7 RID: 28887
	[NullableContext(1)]
	[Nullable(0)]
	public class StackableChessComponent : EntityComponent, IStackableChessAgent, IChessAgent
	{
		// Token: 0x060467C5 RID: 288709 RVA: 0x011B389D File Offset: 0x011B1A9D
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<BaseActorComponent>();
			return true;
		}

		// Token: 0x060467C6 RID: 288710 RVA: 0x011B38B1 File Offset: 0x011B1AB1
		[NullableContext(2)]
		public virtual Vector GetStackableLocation()
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return null;
			}
			return actorComp.ActorLocationProxy;
		}

		// Token: 0x060467C7 RID: 288711 RVA: 0x011B38C4 File Offset: 0x011B1AC4
		[NullableContext(2)]
		public virtual Rotator GetStackableRotator(bool isSameDirection)
		{
			if (this.ActorComp == null)
			{
				return null;
			}
			if (isSameDirection)
			{
				return this.ActorComp.ActorRotationProxy;
			}
			if (this.TargetVector == null)
			{
				this.TargetVector = Vector.Create();
			}
			if (this.TargetRotator == null)
			{
				this.TargetRotator = Rotator.Create();
			}
			Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
			Vector actorUpProxy = this.ActorComp.ActorUpProxy;
			actorForwardProxy.RotateAngleAxis(180.0, actorUpProxy, this.TargetVector);
			this.TargetVector.Rotation(this.TargetRotator);
			return this.TargetRotator;
		}

		// Token: 0x060467C8 RID: 288712 RVA: 0x011B3954 File Offset: 0x011B1B54
		public void AttachToTarget(IStackableChessAgent target)
		{
			BaseActorComponent actorComp = ((StackableChessComponent)target).ActorComp;
			BaseActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 == null || !actorComp2.Valid || (actorComp == null || !actorComp.Valid))
			{
				return;
			}
			FName? attachSocketName = this.GetAttachSocketName();
			if (attachSocketName == null)
			{
				return;
			}
			AActor owner = this.ActorComp.Owner;
			if (owner == null)
			{
				return;
			}
			owner.K2_AttachToComponent(actorComp.SkeletalMesh, attachSocketName.Value, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true);
		}

		// Token: 0x060467C9 RID: 288713 RVA: 0x011B39CE File Offset: 0x011B1BCE
		public void DetachFromTarget(IStackableChessAgent target)
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Valid)
			{
				return;
			}
			AActor owner = this.ActorComp.Owner;
			if (owner == null)
			{
				return;
			}
			owner.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}

		// Token: 0x060467CA RID: 288714 RVA: 0x011B3A00 File Offset: 0x011B1C00
		public virtual void Move(Vector location, Rotator rotator, bool performIsForward, Action finishCallback)
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetActorLocationAndRotation(location.ToUeVector(false), rotator.ToUeRotator(), "ChessMove", false, null);
			}
			finishCallback();
		}

		// Token: 0x060467CB RID: 288715 RVA: 0x011B3A44 File Offset: 0x011B1C44
		public virtual void Teleport(Vector location, Rotator rotator)
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.SetActorLocationAndRotation(location.ToUeVector(false), rotator.ToUeRotator(), "ChessTeleport", false, null);
		}

		// Token: 0x060467CC RID: 288716 RVA: 0x011B3A7E File Offset: 0x011B1C7E
		public virtual void OnPreviousMoveStateChange(IStackableChessAgent agent, bool isMoving, bool previousIsForward, bool isSameDirection)
		{
		}

		// Token: 0x060467CD RID: 288717 RVA: 0x011B3A80 File Offset: 0x011B1C80
		public virtual bool IsPerformRecursion(int type)
		{
			return false;
		}

		// Token: 0x060467CE RID: 288718 RVA: 0x011B3A83 File Offset: 0x011B1C83
		public virtual void Perform(int type, [Nullable(2)] Vector pointLocation, Action finishCallback)
		{
			finishCallback();
		}

		// Token: 0x060467CF RID: 288719 RVA: 0x011B3A8B File Offset: 0x011B1C8B
		public virtual void OnPreviousPerformStateChange(IStackableChessAgent agent, int type, bool isPerforming)
		{
		}

		// Token: 0x060467D0 RID: 288720 RVA: 0x011B3A8D File Offset: 0x011B1C8D
		[NullableContext(2)]
		public Vector GetLocation()
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return null;
			}
			return actorComp.ActorLocationProxy;
		}

		// Token: 0x060467D1 RID: 288721 RVA: 0x011B3AA0 File Offset: 0x011B1CA0
		protected virtual FName? GetAttachSocketName()
		{
			return null;
		}

		// Token: 0x060467D2 RID: 288722 RVA: 0x011B3AB8 File Offset: 0x011B1CB8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			StackableChessComponent stackableChessComponent = (StackableChessComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (stackableChessComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetVector"))
			{
				if (stackableChessComponent.TargetVector == null)
				{
					this.TargetVector = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TargetVector), "TargetVector"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetRotator"))
			{
				if (stackableChessComponent.TargetRotator == null)
				{
					this.TargetRotator = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TargetRotator), "TargetRotator"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024F26 RID: 151334
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x04024F27 RID: 151335
		[Nullable(2)]
		private Vector TargetVector;

		// Token: 0x04024F28 RID: 151336
		[Nullable(2)]
		private Rotator TargetRotator;
	}
}
