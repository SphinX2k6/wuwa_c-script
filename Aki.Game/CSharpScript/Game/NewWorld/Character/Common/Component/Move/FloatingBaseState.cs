using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200638E RID: 25486
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class FloatingBaseState : StateBase<CharacterFloatingComponent, EFloatingMovementType>
	{
		// Token: 0x0603DC1C RID: 252956 RVA: 0x011E815D File Offset: 0x011E635D
		public FloatingBaseState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0603DC1D RID: 252957 RVA: 0x011E8168 File Offset: 0x011E6368
		protected override void OnEnter(EFloatingMovementType? lastState)
		{
			base.OnEnter(lastState);
			this.OnEnterInternal();
		}

		// Token: 0x0603DC1E RID: 252958 RVA: 0x011E8177 File Offset: 0x011E6377
		protected override void OnReEnter()
		{
			base.OnReEnter();
			this.OnEnterInternal();
		}

		// Token: 0x0603DC1F RID: 252959 RVA: 0x011E8185 File Offset: 0x011E6385
		public override bool CanReEnter()
		{
			return true;
		}

		// Token: 0x0603DC20 RID: 252960 RVA: 0x011E8188 File Offset: 0x011E6388
		protected virtual bool CanContinueState()
		{
			return !this.Owner.TagComp.HasAnyTag(this.GetBannedStateConfigTagList());
		}

		// Token: 0x0603DC21 RID: 252961 RVA: 0x011E81A3 File Offset: 0x011E63A3
		public override bool CanChangeFrom(EFloatingMovementType fromState)
		{
			return base.CanChangeFrom(fromState) && this.CanContinueState();
		}

		// Token: 0x0603DC22 RID: 252962 RVA: 0x011E81B6 File Offset: 0x011E63B6
		protected virtual void OnEnterInternal()
		{
			this.Owner.FloatingMoveType = this.State;
			this.SetMoveState();
			this.AddTagList();
			bool debug = CharacterFloatingComponent.Debug;
		}

		// Token: 0x0603DC23 RID: 252963 RVA: 0x011E81DB File Offset: 0x011E63DB
		protected virtual void SetMoveState()
		{
			this.Owner.StateComp.SetMoveState(this.GetMoveState());
		}

		// Token: 0x0603DC24 RID: 252964 RVA: 0x011E81F3 File Offset: 0x011E63F3
		protected virtual ECharMoveState GetMoveState()
		{
			return ECharMoveState.Other;
		}

		// Token: 0x0603DC25 RID: 252965 RVA: 0x011E81F8 File Offset: 0x011E63F8
		protected override void OnUpdate(float deltaSeconds)
		{
			base.OnUpdate(deltaSeconds);
			if (this.Owner.AnimComp.GetAnimInstance().HasKuroRootMotionAnim())
			{
				CharacterFloatingComponent owner = this.Owner;
				FVector fvector = this.Owner.ActorComp.ActorVelocity;
				owner.SpeedInternal = fvector.Size();
				this.Owner.FloatingMoveMixInternal = 0f;
				Vector moveDelta = this.Owner.MoveDelta;
				fvector = this.Owner.MoveComp.CharacterMovement.AnimRootMotionVelocity;
				FVectorDouble fvectorDouble = fvector;
				moveDelta.DeepCopy(fvectorDouble);
				this.Owner.MoveDelta.MultiplyEqual((double)deltaSeconds);
				this.Owner.CloseToGround(deltaSeconds);
				if (!this.Owner.MoveDelta.IsNearlyZero(9.999999747378752E-05))
				{
					this.Owner.MoveComp.MoveCharacter(this.Owner.MoveDelta, deltaSeconds, "CharacterFloatingComponent.Move");
				}
				this.UpdateMovementTagList(!this.Owner.MoveDelta.IsNearlyZero(9.999999747378752E-05));
				this.Owner.DetectFloor();
				this.Owner.CheckGround();
				this.Owner.ClearCacheInputDirect();
				return;
			}
			if (this.Owner.TagComp.HasAnyTag(this.Owner.Config.ForbidRotationTagList))
			{
				this.Owner.SpeedInternal = 0f;
				this.Owner.FloatingMoveMixInternal = 0f;
				this.UpdateMovementTagList(false);
				this.Owner.DetectFloor();
				this.Owner.CheckGround();
				this.Owner.ClearCacheInputDirect();
				return;
			}
			this.Owner.UpdateSpeed(deltaSeconds);
			this.UpdateActorRotation(deltaSeconds);
			this.UpdateActorLocation(deltaSeconds);
			this.UpdateMovementTagList(!this.Owner.MoveDelta.IsNearlyZero(9.999999747378752E-05));
			this.Owner.DetectFloor();
			this.Owner.CheckGround();
			this.PostUpdate();
		}

		// Token: 0x0603DC26 RID: 252966 RVA: 0x011E83EE File Offset: 0x011E65EE
		protected virtual void PostUpdate()
		{
		}

		// Token: 0x0603DC27 RID: 252967 RVA: 0x011E83F0 File Offset: 0x011E65F0
		protected override void OnExit(EFloatingMovementType nextState)
		{
			base.OnExit(nextState);
			this.OnExitInternal();
		}

		// Token: 0x0603DC28 RID: 252968 RVA: 0x011E83FF File Offset: 0x011E65FF
		protected void OnExitInternal()
		{
			this.RemoveTagList();
			this.RemoveMovementTagList();
		}

		// Token: 0x0603DC29 RID: 252969 RVA: 0x011E840D File Offset: 0x011E660D
		protected virtual List<int> GetInStateConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x0603DC2A RID: 252970 RVA: 0x011E8414 File Offset: 0x011E6614
		protected virtual List<int> GetBannedStateConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x0603DC2B RID: 252971 RVA: 0x011E841B File Offset: 0x011E661B
		protected virtual List<int> GetMoveConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x0603DC2C RID: 252972 RVA: 0x011E8422 File Offset: 0x011E6622
		protected virtual List<int> GetStandConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x0603DC2D RID: 252973 RVA: 0x011E8429 File Offset: 0x011E6629
		protected void UpdateActorRotation(float deltaSeconds)
		{
		}

		// Token: 0x0603DC2E RID: 252974 RVA: 0x011E842C File Offset: 0x011E662C
		protected virtual void UpdateActorLocation(float deltaSeconds)
		{
			this.Owner.UpdateMove(deltaSeconds, this.Owner.MoveDelta);
			this.Owner.CloseToGround(deltaSeconds);
			if (!this.Owner.MoveDelta.IsNearlyZero(9.999999747378752E-05))
			{
				this.Owner.MoveComp.MoveCharacter(this.Owner.MoveDelta, deltaSeconds * 1000f, "CharacterFloatingComponent.Move");
			}
		}

		// Token: 0x0603DC2F RID: 252975 RVA: 0x011E84A0 File Offset: 0x011E66A0
		protected void AddTagList()
		{
			List<int> inStateConfigTagList = this.GetInStateConfigTagList();
			if (inStateConfigTagList.Count <= 0)
			{
				return;
			}
			foreach (int value in inStateConfigTagList)
			{
				this.Owner.TagComp.AddTag(new int?(value));
			}
		}

		// Token: 0x0603DC30 RID: 252976 RVA: 0x011E8510 File Offset: 0x011E6710
		protected void RemoveTagList()
		{
			List<int> inStateConfigTagList = this.GetInStateConfigTagList();
			if (inStateConfigTagList.Count <= 0)
			{
				return;
			}
			foreach (int value in inStateConfigTagList)
			{
				this.Owner.TagComp.RemoveTag(new int?(value));
			}
		}

		// Token: 0x0603DC31 RID: 252977 RVA: 0x011E8580 File Offset: 0x011E6780
		private void UpdateMovementTagList(bool isMove)
		{
			if (this.Owner.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
			{
				this.RemoveMovementTagList();
				return;
			}
			bool? isMoved = this.IsMoved;
			if (isMoved.GetValueOrDefault() == isMove & isMoved != null)
			{
				return;
			}
			this.IsMoved = new bool?(isMove);
			this.UpdateMoveTagList(isMove);
			this.UpdateStandTagList(!isMove);
		}

		// Token: 0x0603DC32 RID: 252978 RVA: 0x011E85F0 File Offset: 0x011E67F0
		private void RemoveMovementTagList()
		{
			this.UpdateMoveTagList(false);
			this.UpdateStandTagList(false);
			this.IsMoved = null;
		}

		// Token: 0x0603DC33 RID: 252979 RVA: 0x011E860C File Offset: 0x011E680C
		private void UpdateMoveTagList(bool isAdd)
		{
			List<int> moveConfigTagList = this.GetMoveConfigTagList();
			if (moveConfigTagList.Count <= 0)
			{
				return;
			}
			foreach (int value in moveConfigTagList)
			{
				if (isAdd)
				{
					this.Owner.TagComp.AddTag(new int?(value));
				}
				else
				{
					this.Owner.TagComp.RemoveTag(new int?(value));
				}
			}
		}

		// Token: 0x0603DC34 RID: 252980 RVA: 0x011E8698 File Offset: 0x011E6898
		private void UpdateStandTagList(bool isAdd)
		{
			List<int> standConfigTagList = this.GetStandConfigTagList();
			if (standConfigTagList.Count <= 0)
			{
				return;
			}
			foreach (int value in standConfigTagList)
			{
				if (isAdd)
				{
					this.Owner.TagComp.AddTag(new int?(value));
				}
				else
				{
					this.Owner.TagComp.RemoveTag(new int?(value));
				}
			}
		}

		// Token: 0x04020C54 RID: 134228
		protected bool? IsMoved;
	}
}
