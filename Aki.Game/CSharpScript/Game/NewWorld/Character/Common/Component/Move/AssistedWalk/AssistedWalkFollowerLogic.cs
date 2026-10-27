using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk
{
	// Token: 0x0200710D RID: 28941
	[NullableContext(2)]
	[Nullable(0)]
	public class AssistedWalkFollowerLogic : AttachMoveLogic
	{
		// Token: 0x17009D0E RID: 40206
		// (get) Token: 0x06046A7F RID: 289407 RVA: 0x011C93F6 File Offset: 0x011C75F6
		// (set) Token: 0x06046A80 RID: 289408 RVA: 0x011C9403 File Offset: 0x011C7603
		protected new AssistedWalkParams Params
		{
			get
			{
				return this.Params as AssistedWalkParams;
			}
			set
			{
				this.Params = value;
			}
		}

		// Token: 0x06046A81 RID: 289409 RVA: 0x011C940C File Offset: 0x011C760C
		public override bool IsMoving()
		{
			return this.InState;
		}

		// Token: 0x06046A82 RID: 289410 RVA: 0x011C9414 File Offset: 0x011C7614
		public override void StopMove()
		{
			Action exitCallback = this.ExitCallback;
			this.ExitCallback = null;
			if (!this.InState)
			{
				this.ClearFollowerAssistedWalkTag();
				this.ClearFollowerComponents();
				if (exitCallback != null)
				{
					exitCallback();
				}
				return;
			}
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ClearInput(false, true);
			}
			if (this.ArePartnerComponentsAlive())
			{
				this.ResetFollowerState();
				this.WriteFollowerAnimLogicParams(false, true);
			}
			this.AnimInstance = null;
			AssistedWalkUtils.Instance.RestoreSightLockMode(this.ActorComp, this.LastSightLockMode);
			CharacterCustomActionComponent leaderActionComp = this.LeaderActionComp;
			if (leaderActionComp != null)
			{
				leaderActionComp.AddCustomSetPlayerControl(false, null);
			}
			this.LeaderActionComp = null;
			this.ClearFollowerAssistedWalkTag();
			base.StopMove();
			this.ClearFollowerComponents();
			if (exitCallback != null)
			{
				exitCallback();
			}
		}

		// Token: 0x06046A83 RID: 289411 RVA: 0x011C94C8 File Offset: 0x011C76C8
		public override void Dispose()
		{
			this.StopMove();
		}

		// Token: 0x06046A84 RID: 289412 RVA: 0x011C94D0 File Offset: 0x011C76D0
		[NullableContext(1)]
		public void StartHelpedAssistedWalkWithData(Entity entity, CharacterActorComponent leader, BP_AssistedWalkConfig_C data, [Nullable(2)] Action endCallback = null, bool waitAnim = true)
		{
			if (this.InState)
			{
				this.StopMove();
			}
			this.InitComponents(entity);
			if (this.MoveComp == null || this.AnimComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove][AssistedWalk][Follower] Start 组件无效";
				string item = "PbDataId";
				CharacterActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			base.PrepareAttachMove(entity, data, endCallback);
			if (!this.InState)
			{
				return;
			}
			this.Params = new AssistedWalkParams(data);
			base.AddTags(this.TagComp, this.Params.GameplayTagList);
			this.AnimInstance = (this.AnimComp.MainAnimInstance as UKuroAnimInstanceChar);
			this.WriteFollowerAnimLogicParams(true, waitAnim);
			this.ApplyFollowerEnterState(leader);
			Entity entity2 = leader.Entity;
			this.LeaderActionComp = ((entity2 != null) ? entity2.GetComponent<CharacterCustomActionComponent>() : null);
			this.AssistedWalkTagId = GameplayTagDefine.EGameplayTagId["角色.Common.地区运动状态.搀扶行走.被搀扶"];
			base.SetOnlyTag(this.TagComp, this.AssistedWalkTagId, true, "[AttachMove][AssistedWalk][Follower] Start");
			this.LastSightLockMode = AssistedWalkUtils.Instance.SaveAndDisableSightLockMode(this.ActorComp);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[AttachMove][AssistedWalk][Follower] StartMove";
			string item2 = "PbDataId";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x06046A85 RID: 289413 RVA: 0x011C9658 File Offset: 0x011C7858
		[NullableContext(1)]
		private void ApplyFollowerEnterState(CharacterActorComponent leader)
		{
			if (leader == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove][AssistedWalk][Follower] ApplyFollowerEnterState 缺少 Leader";
				string item = "PbDataId";
				CharacterActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				BaseMoveComponent moveComp = actorComp2.MoveComp;
				if (moveComp != null)
				{
					moveComp.MoveController.EnableAutoSync(30, 0.01f);
				}
			}
			this.MoveComp.IsRegionMoveMode = true;
			this.AnimComp.DisableHumanIk = true;
			CharacterLinkedAnimInstComponent component = this.Entity.GetComponent<CharacterLinkedAnimInstComponent>();
			if (component == null)
			{
				return;
			}
			component.SyncLinkGameplayAnimBlueprint(EGameplayABPType.AssistedWalk);
		}

		// Token: 0x06046A86 RID: 289414 RVA: 0x011C9710 File Offset: 0x011C7910
		private void ResetFollowerState()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				BaseMoveComponent moveComp = actorComp.MoveComp;
				if (moveComp != null)
				{
					moveComp.MoveController.DisableAutoSync();
				}
			}
			if (this.MoveComp != null)
			{
				this.MoveComp.IsRegionMoveMode = false;
			}
			if (this.AnimComp != null)
			{
				this.AnimComp.DisableHumanIk = false;
			}
			Entity entity = this.Entity;
			CharacterLinkedAnimInstComponent characterLinkedAnimInstComponent = (entity != null) ? entity.GetComponent<CharacterLinkedAnimInstComponent>() : null;
			if (characterLinkedAnimInstComponent == null)
			{
				return;
			}
			characterLinkedAnimInstComponent.SyncLinkGameplayAnimBlueprint(EGameplayABPType.None);
		}

		// Token: 0x06046A87 RID: 289415 RVA: 0x011C9784 File Offset: 0x011C7984
		private void WriteFollowerAnimLogicParams(bool entering, bool waitAnim = true)
		{
			UKuroAnimInstanceChar animInstance = this.AnimInstance;
			UAbpLogicParams uabpLogicParams = (animInstance != null) ? animInstance.LogicParams : null;
			if (uabpLogicParams == null)
			{
				return;
			}
			uabpLogicParams.bHelpedAssistedWalk = entering;
			uabpLogicParams.bSkipEnterAssistedWalkAnim = (entering && !waitAnim);
			uabpLogicParams.AssistedWalkAnimRate = 1f;
			uabpLogicParams.bInAssistedWalking = false;
		}

		// Token: 0x06046A88 RID: 289416 RVA: 0x011C97D4 File Offset: 0x011C79D4
		[NullableContext(1)]
		private void InitComponents(Entity entity)
		{
			this.Entity = entity;
			this.ActorComp = entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = entity.GetComponent<BaseMoveComponent>();
			this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
			this.TagComp = entity.GetComponent<BaseTagComponent>();
			this.UeMovementComp = entity.GetComponent<UeMovementTickManageComponent>();
		}

		// Token: 0x06046A89 RID: 289417 RVA: 0x011C9824 File Offset: 0x011C7A24
		private void ClearFollowerAssistedWalkTag()
		{
			if (this.AssistedWalkTagId == 0)
			{
				return;
			}
			base.SetOnlyTag(this.TagComp, this.AssistedWalkTagId, false, "[AttachMove][AssistedWalk][Follower] StopMove");
			this.AssistedWalkTagId = 0;
		}

		// Token: 0x06046A8A RID: 289418 RVA: 0x011C984E File Offset: 0x011C7A4E
		private void ClearFollowerComponents()
		{
			this.Entity = null;
			this.ActorComp = null;
			this.MoveComp = null;
			this.AnimComp = null;
			this.UeMovementComp = null;
			this.AnimInstance = null;
			this.LeaderActionComp = null;
		}

		// Token: 0x06046A8B RID: 289419 RVA: 0x011C9884 File Offset: 0x011C7A84
		private bool ArePartnerComponentsAlive()
		{
			AssistedWalkUtils instance = AssistedWalkUtils.Instance;
			string logTag = "[AttachMove][AssistedWalk][Follower] 兄弟组件已销毁，跳过状态恢复";
			CharacterActorComponent actorComp = this.ActorComp;
			bool[] array = new bool[4];
			int num = 0;
			UeMovementTickManageComponent ueMovementComp = this.UeMovementComp;
			array[num] = (ueMovementComp == null || ueMovementComp.Valid);
			int num2 = 1;
			BaseMoveComponent moveComp = this.MoveComp;
			array[num2] = (moveComp == null || moveComp.Valid);
			int num3 = 2;
			CharacterAnimationComponent animComp = this.AnimComp;
			array[num3] = (animComp == null || animComp.Valid);
			int num4 = 3;
			BaseTagComponent tagComp = this.TagComp;
			array[num4] = (tagComp == null || tagComp.Valid);
			return instance.ArePartnerComponentsAlive(logTag, actorComp, array);
		}

		// Token: 0x0402517D RID: 151933
		private Entity Entity;

		// Token: 0x0402517E RID: 151934
		private CharacterActorComponent ActorComp;

		// Token: 0x0402517F RID: 151935
		private BaseMoveComponent MoveComp;

		// Token: 0x04025180 RID: 151936
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04025181 RID: 151937
		private UeMovementTickManageComponent UeMovementComp;

		// Token: 0x04025182 RID: 151938
		private UKuroAnimInstanceChar AnimInstance;

		// Token: 0x04025183 RID: 151939
		private int AssistedWalkTagId;

		// Token: 0x04025184 RID: 151940
		private CharacterCustomActionComponent LeaderActionComp;

		// Token: 0x04025185 RID: 151941
		private SightLockMode LastSightLockMode;
	}
}
