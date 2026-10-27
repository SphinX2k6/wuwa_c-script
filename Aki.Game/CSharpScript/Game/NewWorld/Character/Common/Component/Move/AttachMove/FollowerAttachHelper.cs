using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x02007105 RID: 28933
	[NullableContext(2)]
	[Nullable(0)]
	public class FollowerAttachHelper
	{
		// Token: 0x06046A2B RID: 289323 RVA: 0x011C71A0 File Offset: 0x011C53A0
		[NullableContext(1)]
		public void Init(Entity entity)
		{
			this.ActorComp = entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = entity.GetComponent<BaseMoveComponent>();
			this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
			this.UeMovementComp = entity.GetComponent<UeMovementTickManageComponent>();
		}

		// Token: 0x06046A2C RID: 289324 RVA: 0x011C71D2 File Offset: 0x011C53D2
		public bool IsAttached()
		{
			return this.Attached;
		}

		// Token: 0x06046A2D RID: 289325 RVA: 0x011C71DA File Offset: 0x011C53DA
		public CharacterActorComponent GetLeader()
		{
			return this.Leader;
		}

		// Token: 0x06046A2E RID: 289326 RVA: 0x011C71E4 File Offset: 0x011C53E4
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

		// Token: 0x06046A2F RID: 289327 RVA: 0x011C7350 File Offset: 0x011C5550
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

		// Token: 0x06046A30 RID: 289328 RVA: 0x011C73A3 File Offset: 0x011C55A3
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

		// Token: 0x06046A31 RID: 289329 RVA: 0x011C73D0 File Offset: 0x011C55D0
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

		// Token: 0x06046A32 RID: 289330 RVA: 0x011C7520 File Offset: 0x011C5720
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

		// Token: 0x06046A33 RID: 289331 RVA: 0x011C7588 File Offset: 0x011C5788
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

		// Token: 0x06046A34 RID: 289332 RVA: 0x011C75F4 File Offset: 0x011C57F4
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

		// Token: 0x0402513B RID: 151867
		private CharacterActorComponent ActorComp;

		// Token: 0x0402513C RID: 151868
		private BaseMoveComponent MoveComp;

		// Token: 0x0402513D RID: 151869
		private CharacterAnimationComponent AnimComp;

		// Token: 0x0402513E RID: 151870
		private UeMovementTickManageComponent UeMovementComp;

		// Token: 0x0402513F RID: 151871
		private CharacterActorComponent Leader;

		// Token: 0x04025140 RID: 151872
		private int UeMovementCompDisableHandle;

		// Token: 0x04025141 RID: 151873
		private bool Attached;

		// Token: 0x04025142 RID: 151874
		private EMovementMode? MovementModeBeforeAttach;

		// Token: 0x04025143 RID: 151875
		private byte CustomMovementModeBeforeAttach;
	}
}
