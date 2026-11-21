using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x020063B5 RID: 25525
	[NullableContext(2)]
	[Nullable(0)]
	public class FollowerAttachHelper
	{
		// Token: 0x0603DE2A RID: 253482 RVA: 0x011F61C0 File Offset: 0x011F43C0
		[NullableContext(1)]
		public void Init(Entity entity)
		{
			this.ActorComp = entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = entity.GetComponent<BaseMoveComponent>();
			this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
			this.UeMovementComp = entity.GetComponent<UeMovementTickManageComponent>();
		}

		// Token: 0x0603DE2B RID: 253483 RVA: 0x011F61F2 File Offset: 0x011F43F2
		public bool IsAttached()
		{
			return this.Attached;
		}

		// Token: 0x0603DE2C RID: 253484 RVA: 0x011F61FA File Offset: 0x011F43FA
		public CharacterActorComponent GetLeader()
		{
			return this.Leader;
		}

		// Token: 0x0603DE2D RID: 253485 RVA: 0x011F6204 File Offset: 0x011F4404
		[NullableContext(1)]
		public unsafe bool AttachToLeader(CharacterActorComponent leader, string attachSocket, Transform attachTransform)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = true;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
			}
			if (!flag)
			{
				bool flag2;
				if (leader == null)
				{
					flag2 = true;
				}
				else
				{
					USkeletalMeshComponent mesh = leader.Actor.Mesh;
					flag2 = !((mesh != null) ? new bool?(mesh.IsValid()) : null).GetValueOrDefault();
				}
				if (!flag2 && attachSocket.Length >= 1)
				{
					this.Leader = leader;
					this.EnableUeMovement(false, "[AttachMove] AttachToLeader");
					BaseMoveComponent moveComp = this.MoveComp;
					if (moveComp != null)
					{
						moveComp.SetLockedRotation(true);
					}
					if (!this.DoSocketAttach(leader, attachSocket, attachTransform))
					{
						this.RestoreMovementMode("[AttachMove] AttachToLeader rollback");
						BaseMoveComponent moveComp2 = this.MoveComp;
						if (moveComp2 != null)
						{
							moveComp2.SetLockedRotation(false);
						}
						this.EnableUeMovement(true, "[AttachMove] AttachToLeader rollback");
						this.Leader = null;
						return false;
					}
					this.Attached = true;
					return true;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove] AttachToLeader 失败：参数无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AttachSocket", attachSocket);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}

		// Token: 0x0603DE2E RID: 253486 RVA: 0x011F6370 File Offset: 0x011F4570
		public void DetachFromLeader()
		{
			if (!this.Attached)
			{
				return;
			}
			this.DoDetach();
			this.RestoreMovementMode("[AttachMove] DetachFromLeader");
			this.EnableUeMovement(true, "[AttachMove] DetachFromLeader");
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.SetLockedRotation(false);
			}
			this.Attached = false;
			this.Leader = null;
		}

		// Token: 0x0603DE2F RID: 253487 RVA: 0x011F63C3 File Offset: 0x011F45C3
		public void Dispose()
		{
			if (this.Attached)
			{
				this.DetachFromLeader();
			}
			this.ActorComp = null;
			this.MoveComp = null;
			this.AnimComp = null;
			this.UeMovementComp = null;
		}

		// Token: 0x0603DE30 RID: 253488 RVA: 0x011F63F0 File Offset: 0x011F45F0
		[NullableContext(1)]
		private bool DoSocketAttach(CharacterActorComponent leader, string attachSocket, Transform attachTransform)
		{
			if (leader.Actor.Mesh == null || !leader.Actor.Mesh.IsValid())
			{
				return false;
			}
			FName fname = new FName(attachSocket);
			FTransformDouble ftransformDouble = leader.Actor.Mesh.D_GetSocketTransform(fname, ERelativeTransformSpace.RTS_Actor);
			FTransformDouble actorTransform = leader.ActorTransform;
			FTransformDouble ftransformDouble2 = UKismetMathLibrary.D_ComposeTransforms(ftransformDouble, actorTransform);
			FTransformDouble ftransformDouble3 = attachTransform.ToUeTransform();
			FTransformDouble ftransformDouble4 = UKismetMathLibrary.D_ComposeTransforms(ftransformDouble3, ftransformDouble2);
			this.ActorComp.ActorTransform.GetTranslation();
			UCharacterMovementComponent characterMovement = this.ActorComp.Actor.CharacterMovement;
			if (characterMovement != null && characterMovement.IsValid())
			{
				this.MovementModeBeforeAttach = new EMovementMode?(characterMovement.MovementMode);
				this.CustomMovementModeBeforeAttach = characterMovement.CustomMovementMode;
				characterMovement.SetMovementMode(EMovementMode.MOVE_None, 0);
			}
			this.ActorComp.Actor.D_K2_SetActorTransformForce(ftransformDouble4, false, ref WorldGlobal.SweepHitResult, true);
			if (!AttachToActorController.Instance.AttachToComponent(this.ActorComp.Actor, leader.Actor.Mesh, EDetachType.DestroyExternal, "FollowerAttachHelper.DoSocketAttach", new FName?(fname), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true, false, false, false))
			{
				return false;
			}
			USceneComponent rootComponent = this.ActorComp.Actor.RootComponent;
			if (rootComponent != null && rootComponent.IsValid())
			{
				rootComponent.D_K2_SetRelativeTransform(ftransformDouble3, false, ref WorldGlobal.SweepHitResult, true);
			}
			return true;
		}

		// Token: 0x0603DE31 RID: 253489 RVA: 0x011F6540 File Offset: 0x011F4740
		private void DoDetach()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = true;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
			AttachToActorController.Instance.DetachActor(this.ActorComp.Actor, false, "FollowerAttachHelper.DoDetach", EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}

		// Token: 0x0603DE32 RID: 253490 RVA: 0x011F65A8 File Offset: 0x011F47A8
		[NullableContext(1)]
		private void RestoreMovementMode(string context)
		{
			EMovementMode? movementModeBeforeAttach = this.MovementModeBeforeAttach;
			if (movementModeBeforeAttach == null)
			{
				return;
			}
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = movementModeBeforeAttach.Value,
					CustomMode = this.CustomMovementModeBeforeAttach,
					Context = context
				});
			}
			this.MovementModeBeforeAttach = null;
			this.CustomMovementModeBeforeAttach = 0;
		}

		// Token: 0x0603DE33 RID: 253491 RVA: 0x011F6614 File Offset: 0x011F4814
		[NullableContext(1)]
		private void EnableUeMovement(bool enable, string reason)
		{
			if (this.UeMovementComp == null || !this.UeMovementComp.Valid)
			{
				return;
			}
			if (!enable || this.UeMovementCompDisableHandle == 0)
			{
				if (!enable && this.UeMovementCompDisableHandle == 0)
				{
					this.UeMovementCompDisableHandle = this.UeMovementComp.Disable(reason);
				}
				return;
			}
			this.UeMovementComp.Enable(new int?(this.UeMovementCompDisableHandle), reason);
			this.UeMovementCompDisableHandle = 0;
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null)
			{
				return;
			}
			animComp.ConsumeRootMotion();
		}

		// Token: 0x04020DD0 RID: 134608
		private CharacterActorComponent ActorComp;

		// Token: 0x04020DD1 RID: 134609
		private BaseMoveComponent MoveComp;

		// Token: 0x04020DD2 RID: 134610
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04020DD3 RID: 134611
		private UeMovementTickManageComponent UeMovementComp;

		// Token: 0x04020DD4 RID: 134612
		private CharacterActorComponent Leader;

		// Token: 0x04020DD5 RID: 134613
		private int UeMovementCompDisableHandle;

		// Token: 0x04020DD6 RID: 134614
		private bool Attached;

		// Token: 0x04020DD7 RID: 134615
		private EMovementMode? MovementModeBeforeAttach;

		// Token: 0x04020DD8 RID: 134616
		private byte CustomMovementModeBeforeAttach;
	}
}
