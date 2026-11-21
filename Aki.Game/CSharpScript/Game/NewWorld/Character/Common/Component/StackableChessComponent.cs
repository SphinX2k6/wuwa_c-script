using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200633B RID: 25403
	[NullableContext(1)]
	[Nullable(0)]
	public class StackableChessComponent : EntityComponent, IStackableChessAgent, IChessAgent
	{
		// Token: 0x0603D8CC RID: 252108 RVA: 0x011D293D File Offset: 0x011D0B3D
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<BaseActorComponent>();
			return true;
		}

		// Token: 0x0603D8CD RID: 252109 RVA: 0x011D2951 File Offset: 0x011D0B51
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

		// Token: 0x0603D8CE RID: 252110 RVA: 0x011D2964 File Offset: 0x011D0B64
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

		// Token: 0x0603D8CF RID: 252111 RVA: 0x011D29F4 File Offset: 0x011D0BF4
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

		// Token: 0x0603D8D0 RID: 252112 RVA: 0x011D2A6E File Offset: 0x011D0C6E
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

		// Token: 0x0603D8D1 RID: 252113 RVA: 0x011D2AA0 File Offset: 0x011D0CA0
		public virtual void Move(Vector location, Rotator rotator, bool performIsForward, Action finishCallback)
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetActorLocationAndRotation(location.ToUeVector(false), rotator.ToUeRotator(), "ChessMove", false, null);
			}
			finishCallback();
		}

		// Token: 0x0603D8D2 RID: 252114 RVA: 0x011D2AE4 File Offset: 0x011D0CE4
		public virtual void Teleport(Vector location, Rotator rotator)
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.SetActorLocationAndRotation(location.ToUeVector(false), rotator.ToUeRotator(), "ChessTeleport", false, null);
		}

		// Token: 0x0603D8D3 RID: 252115 RVA: 0x011D2B1E File Offset: 0x011D0D1E
		public virtual void OnPreviousMoveStateChange(IStackableChessAgent agent, bool isMoving, bool previousIsForward, bool isSameDirection)
		{
		}

		// Token: 0x0603D8D4 RID: 252116 RVA: 0x011D2B20 File Offset: 0x011D0D20
		public virtual bool IsPerformRecursion(int type)
		{
			return false;
		}

		// Token: 0x0603D8D5 RID: 252117 RVA: 0x011D2B23 File Offset: 0x011D0D23
		public virtual void Perform(int type, [Nullable(2)] Vector pointLocation, Action finishCallback)
		{
			finishCallback();
		}

		// Token: 0x0603D8D6 RID: 252118 RVA: 0x011D2B2B File Offset: 0x011D0D2B
		public virtual void OnPreviousPerformStateChange(IStackableChessAgent agent, int type, bool isPerforming)
		{
		}

		// Token: 0x0603D8D7 RID: 252119 RVA: 0x011D2B2D File Offset: 0x011D0D2D
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

		// Token: 0x0603D8D8 RID: 252120 RVA: 0x011D2B40 File Offset: 0x011D0D40
		protected virtual FName? GetAttachSocketName()
		{
			return null;
		}

		// Token: 0x0603D8D9 RID: 252121 RVA: 0x011D2B58 File Offset: 0x011D0D58
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			StackableChessComponent stackableChessComponent = (StackableChessComponent)componentTemplate;
			if (stackableChessComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (stackableChessComponent.TargetVector == null)
			{
				this.TargetVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetVector), "TargetVector"))
			{
				return false;
			}
			if (stackableChessComponent.TargetRotator == null)
			{
				this.TargetRotator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetRotator), "TargetRotator"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170074D5 RID: 29909
		// (get) Token: 0x0603D8DA RID: 252122 RVA: 0x011D2BF9 File Offset: 0x011D0DF9
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A65 RID: 133733
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x04020A66 RID: 133734
		[Nullable(2)]
		private Vector TargetVector;

		// Token: 0x04020A67 RID: 133735
		[Nullable(2)]
		private Rotator TargetRotator;
	}
}
