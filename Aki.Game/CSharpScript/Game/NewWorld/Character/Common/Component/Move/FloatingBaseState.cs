using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070DE RID: 28894
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class FloatingBaseState : StateBase<CharacterFloatingComponent, EFloatingMovementType>
	{
		// Token: 0x0604682F RID: 288815 RVA: 0x011B8A89 File Offset: 0x011B6C89
		public FloatingBaseState(CharacterFloatingComponent owner, EFloatingMovementType state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CharacterFloatingComponent, EFloatingMovementType> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06046830 RID: 288816 RVA: 0x011B8A94 File Offset: 0x011B6C94
		protected override void OnEnter(EFloatingMovementType? lastState)
		{
			base.OnEnter(lastState);
			this.OnEnterInternal();
		}

		// Token: 0x06046831 RID: 288817 RVA: 0x011B8AA3 File Offset: 0x011B6CA3
		protected override void OnReEnter()
		{
			base.OnReEnter();
			this.OnEnterInternal();
		}

		// Token: 0x06046832 RID: 288818 RVA: 0x011B8AB1 File Offset: 0x011B6CB1
		public override bool CanReEnter()
		{
			return true;
		}

		// Token: 0x06046833 RID: 288819 RVA: 0x011B8AB4 File Offset: 0x011B6CB4
		protected virtual bool CanContinueState()
		{
			return !this.Owner.TagComp.HasAnyTag(this.GetBannedStateConfigTagList());
		}

		// Token: 0x06046834 RID: 288820 RVA: 0x011B8ACF File Offset: 0x011B6CCF
		public override bool CanChangeFrom(EFloatingMovementType fromState)
		{
			return base.CanChangeFrom(fromState) && this.CanContinueState();
		}

		// Token: 0x06046835 RID: 288821 RVA: 0x011B8AE2 File Offset: 0x011B6CE2
		protected virtual void OnEnterInternal()
		{
			this.Owner.FloatingMoveType = this.State;
			this.SetMoveState();
			this.AddTagList();
			bool debug = CharacterFloatingComponent.Debug;
		}

		// Token: 0x06046836 RID: 288822 RVA: 0x011B8B07 File Offset: 0x011B6D07
		protected virtual void SetMoveState()
		{
			this.Owner.StateComp.SetMoveState(this.GetMoveState());
		}

		// Token: 0x06046837 RID: 288823 RVA: 0x011B8B1F File Offset: 0x011B6D1F
		protected virtual ECharMoveState GetMoveState()
		{
			return ECharMoveState.Other;
		}

		// Token: 0x06046838 RID: 288824 RVA: 0x011B8B24 File Offset: 0x011B6D24
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

		// Token: 0x06046839 RID: 288825 RVA: 0x011B8D1A File Offset: 0x011B6F1A
		protected virtual void PostUpdate()
		{
		}

		// Token: 0x0604683A RID: 288826 RVA: 0x011B8D1C File Offset: 0x011B6F1C
		protected override void OnExit(EFloatingMovementType nextState)
		{
			base.OnExit(nextState);
			this.OnExitInternal();
		}

		// Token: 0x0604683B RID: 288827 RVA: 0x011B8D2B File Offset: 0x011B6F2B
		protected void OnExitInternal()
		{
			this.RemoveTagList();
			this.RemoveMovementTagList();
		}

		// Token: 0x0604683C RID: 288828 RVA: 0x011B8D39 File Offset: 0x011B6F39
		protected virtual List<int> GetInStateConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x0604683D RID: 288829 RVA: 0x011B8D40 File Offset: 0x011B6F40
		protected virtual List<int> GetBannedStateConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x0604683E RID: 288830 RVA: 0x011B8D47 File Offset: 0x011B6F47
		protected virtual List<int> GetMoveConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x0604683F RID: 288831 RVA: 0x011B8D4E File Offset: 0x011B6F4E
		protected virtual List<int> GetStandConfigTagList()
		{
			return CharacterFloatingComponent.EmptyArray;
		}

		// Token: 0x06046840 RID: 288832 RVA: 0x011B8D55 File Offset: 0x011B6F55
		protected void UpdateActorRotation(float deltaSeconds)
		{
		}

		// Token: 0x06046841 RID: 288833 RVA: 0x011B8D58 File Offset: 0x011B6F58
		protected virtual void UpdateActorLocation(float deltaSeconds)
		{
			this.Owner.UpdateMove(deltaSeconds, this.Owner.MoveDelta);
			this.Owner.CloseToGround(deltaSeconds);
			if (!this.Owner.MoveDelta.IsNearlyZero(9.999999747378752E-05))
			{
				this.Owner.MoveComp.MoveCharacter(this.Owner.MoveDelta, deltaSeconds * 1000f, "CharacterFloatingComponent.Move");
			}
		}

		// Token: 0x06046842 RID: 288834 RVA: 0x011B8DCC File Offset: 0x011B6FCC
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

		// Token: 0x06046843 RID: 288835 RVA: 0x011B8E3C File Offset: 0x011B703C
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

		// Token: 0x06046844 RID: 288836 RVA: 0x011B8EAC File Offset: 0x011B70AC
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

		// Token: 0x06046845 RID: 288837 RVA: 0x011B8F1C File Offset: 0x011B711C
		private void RemoveMovementTagList()
		{
			this.UpdateMoveTagList(false);
			this.UpdateStandTagList(false);
			this.IsMoved = null;
		}

		// Token: 0x06046846 RID: 288838 RVA: 0x011B8F38 File Offset: 0x011B7138
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

		// Token: 0x06046847 RID: 288839 RVA: 0x011B8FC4 File Offset: 0x011B71C4
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

		// Token: 0x04024FBF RID: 151487
		protected bool? IsMoved;
	}
}
