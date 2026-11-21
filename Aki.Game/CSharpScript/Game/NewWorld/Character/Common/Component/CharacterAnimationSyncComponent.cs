using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Module.CombatMessage;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006326 RID: 25382
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterAnimationSyncComponent : EntityComponent, IStaticVariableResetter
	{
		// Token: 0x0603D72E RID: 251694 RVA: 0x011C5EBC File Offset: 0x011C40BC
		static CharacterAnimationSyncComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterAnimationSyncComponent.CreateStaticDefaultValue), new Action(CharacterAnimationSyncComponent.ResetStaticDefaultValue));
		}

		// Token: 0x1700748A RID: 29834
		// (get) Token: 0x0603D72F RID: 251695 RVA: 0x011C5FEC File Offset: 0x011C41EC
		protected UAnimInstance MainAnimInstance
		{
			get
			{
				if (this.MainAnimInstanceInternal == null)
				{
					BaseAnimationComponent component = base.Entity.GetComponent<BaseAnimationComponent>();
					this.MainAnimInstanceInternal = ((component != null) ? component.MainAnimInstance : null);
					if (this.MainAnimInstanceInternal == null)
					{
						VehicleAnimationComponent component2 = base.Entity.GetComponent<VehicleAnimationComponent>();
						this.MainAnimInstanceInternal = ((component2 != null) ? component2.MainAnimInstance : null);
					}
				}
				return this.MainAnimInstanceInternal;
			}
		}

		// Token: 0x1700748B RID: 29835
		// (get) Token: 0x0603D730 RID: 251696 RVA: 0x011C604C File Offset: 0x011C424C
		private UAnimInstance SpecialAnimInstance
		{
			get
			{
				if (this.SpecialAnimInstanceInternal == null)
				{
					BaseAnimationComponent component = base.Entity.GetComponent<BaseAnimationComponent>();
					this.SpecialAnimInstanceInternal = ((component != null) ? component.SpecialAnimInstance : null);
					if (this.SpecialAnimInstanceInternal == null)
					{
						VehicleAnimationComponent component2 = base.Entity.GetComponent<VehicleAnimationComponent>();
						this.SpecialAnimInstanceInternal = ((component2 != null) ? component2.SpecialAnimInstance : null);
					}
				}
				return this.SpecialAnimInstanceInternal;
			}
		}

		// Token: 0x0603D731 RID: 251697 RVA: 0x011C60AB File Offset: 0x011C42AB
		protected override bool OnEnd()
		{
			CombatMessageController.Instance.UnregisterAfterTick(this);
			return true;
		}

		// Token: 0x0603D732 RID: 251698 RVA: 0x011C60BC File Offset: 0x011C42BC
		protected override void OnActivate()
		{
			CombatMessageController.Instance.RegisterAfterTick(this, new Action<float>(this.AfterTickInternal));
			this.ActorComp = base.Entity.CheckGetComponent<BaseActorComponent>();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			CharacterMorphComponent component = base.Entity.GetComponent<CharacterMorphComponent>();
			if (component != null && component.IsEnableMorph())
			{
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				this.CheckModelId = ((creatureDataComp != null) ? creatureDataComp.GetModelConfig().ID : 0);
			}
			this.InitAnimationStates();
			if (this.TagComp != null)
			{
				foreach (int value in CharacterAnimationSyncComponent.animationTagList)
				{
					ITagTask item = this.TagComp.ListenForTagAddOrRemove(new int?(value), new BaseTagComponent.TTagSwitchedCallback(this.AnimationGameplayTagRequest), null);
					this.ListenTagChangedHandles.Add(item);
				}
			}
		}

		// Token: 0x0603D733 RID: 251699 RVA: 0x011C619A File Offset: 0x011C439A
		private void AfterTickInternal(float delta)
		{
			this.AfterTickInner(delta);
		}

		// Token: 0x0603D734 RID: 251700 RVA: 0x011C61A3 File Offset: 0x011C43A3
		protected virtual void AfterTickInner(float delta)
		{
			this.TryPushAnimationStateChanged();
		}

		// Token: 0x0603D735 RID: 251701 RVA: 0x011C61AC File Offset: 0x011C43AC
		protected override bool OnClear()
		{
			foreach (ITagTask tagTask in this.ListenTagChangedHandles)
			{
				tagTask.EndTask();
			}
			return true;
		}

		// Token: 0x0603D736 RID: 251702 RVA: 0x011C6200 File Offset: 0x011C4400
		private unsafe void InitAnimationStates()
		{
			if (this.MainAnimInstance == null || !this.MainAnimInstance.IsValid())
			{
				return;
			}
			EntityComponentPb valueOrDefault = base.Entity.GetComponent<CreatureDataComponent>().ComponentDataMap.GetValueOrDefault("AnimationStateComponent");
			RepeatedField<int> repeatedField = (valueOrDefault != null) ? valueOrDefault.AnimationStateComponent.AnimationStates : null;
			RepeatedField<int> repeatedField2 = (valueOrDefault != null) ? valueOrDefault.AnimationStateComponent.SpecialStates : null;
			int? num;
			if (valueOrDefault == null)
			{
				num = null;
			}
			else
			{
				AnimationStateComponentPb animationStateComponent = valueOrDefault.AnimationStateComponent;
				num = ((animationStateComponent != null) ? new int?(animationStateComponent.ModelId) : null);
			}
			int? num2 = num;
			if (this.ActorComp.IsMoveAutonomousProxy)
			{
				this.MainAnimInstance.SetStateMachineNetMode(false);
				this.AnimationStateInitPush();
			}
			else
			{
				this.MainAnimInstance.SetStateMachineNetMode(true);
				if (this.CheckModelId != 0)
				{
					int? num3 = num2;
					int checkModelId = this.CheckModelId;
					if (!(num3.GetValueOrDefault() == checkModelId & num3 != null))
					{
						CombatLog instance = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
						Entity entity = base.Entity;
						string message = "动画状态机初始化, ModelId不匹配";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NotifyModelId", num2);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CheckModelId", this.CheckModelId);
						instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						goto IL_1C0;
					}
				}
				if (repeatedField != null && repeatedField.Count > 0)
				{
					TArray<int> tarray = CharacterAnimationSyncComponent.animationStateListRef;
					WorldGlobal.ToUeInt32Array(repeatedField, tarray);
					this.MainAnimInstance.SetStateOrdersReceivePending(tarray);
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Animation;
					Entity entity2 = base.Entity;
					string message2 = "动画状态机初始化成功";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("v", CharacterAnimationSyncComponent.OrderToString(repeatedField));
					instance2.Info(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					CombatLog.Instance.Info(CombatLog.EDebugModule.Animation, base.Entity, "动画状态机初始化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				IL_1C0:
				if (repeatedField2 != null && repeatedField2.Count > 0)
				{
					TArray<int> tarray2 = CharacterAnimationSyncComponent.specialStateListRef;
					WorldGlobal.ToUeInt32Array(repeatedField2, tarray2);
					UAnimInstance specialAnimInstance = this.SpecialAnimInstance;
					if (specialAnimInstance != null)
					{
						specialAnimInstance.SetStateOrdersReceivePending(tarray2);
					}
				}
				RepeatedField<int> repeatedField3;
				if (valueOrDefault == null)
				{
					repeatedField3 = null;
				}
				else
				{
					AnimationStateComponentPb animationStateComponent2 = valueOrDefault.AnimationStateComponent;
					repeatedField3 = ((animationStateComponent2 != null) ? animationStateComponent2.AnimationTags : null);
				}
				RepeatedField<int> repeatedField4 = repeatedField3;
				if (repeatedField4 != null && repeatedField4.Count > 0)
				{
					foreach (int value in repeatedField4)
					{
						this.TagComp.AddTag(new int?(value));
					}
					CombatLog instance3 = CombatLog.Instance;
					CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Animation;
					Entity entity3 = base.Entity;
					string message3 = "AnimationTags";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("tags", string.Join<int>(",", repeatedField4));
					instance3.Info(flag3, entity3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			RepeatedField<BoneVisibleData> repeatedField5;
			if (valueOrDefault == null)
			{
				repeatedField5 = null;
			}
			else
			{
				AnimationStateComponentPb animationStateComponent3 = valueOrDefault.AnimationStateComponent;
				repeatedField5 = ((animationStateComponent3 != null) ? animationStateComponent3.BoneVisibleDatas : null);
			}
			RepeatedField<BoneVisibleData> repeatedField6 = repeatedField5;
			CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
			if (component != null && repeatedField6 != null && repeatedField6.Count > 0)
			{
				foreach (BoneVisibleData boneVisibleData in repeatedField6)
				{
					component.HideBone(FNameUtil.GetDynamicFName(boneVisibleData.BoneName).Value, !boneVisibleData.Visible, false);
				}
			}
		}

		// Token: 0x0603D737 RID: 251703 RVA: 0x011C653C File Offset: 0x011C473C
		private unsafe void TryPushAnimationStateChanged()
		{
			if (this.MainAnimInstance == null || !this.MainAnimInstance.IsValid())
			{
				return;
			}
			if (!GameModeModel.Instance.IsMulti)
			{
				if (Time.Instance.NowSeconds > this.LastCleanSendPendingTime + (double)this.CleanSendPendingInterval)
				{
					this.MainAnimInstance.ClearStateOrdersSendPending();
					UAnimInstance specialAnimInstance = this.SpecialAnimInstance;
					if (specialAnimInstance != null)
					{
						specialAnimInstance.ClearStateOrdersSendPending();
					}
					this.LastCleanSendPendingTime = Time.Instance.NowSeconds;
				}
				return;
			}
			if (!this.ActorComp.IsMoveAutonomousProxy)
			{
				return;
			}
			this.MainAnimInstance.GetStateOrdersSendPending(ref CharacterAnimationSyncComponent.animationStateListRef);
			TArray<int> tarray = CharacterAnimationSyncComponent.animationStateListRef;
			UAnimInstance specialAnimInstance2 = this.SpecialAnimInstance;
			if (specialAnimInstance2 != null)
			{
				specialAnimInstance2.GetStateOrdersSendPending(ref CharacterAnimationSyncComponent.specialStateListRef);
			}
			TArray<int> tarray2 = CharacterAnimationSyncComponent.specialStateListRef;
			if (tarray.Num() > 0 || (this.SpecialAnimInstance != null && tarray2.Num() > 0))
			{
				List<int> list = new List<int>();
				List<int> list2 = new List<int>();
				WorldGlobal.ToTsArray<int>(tarray, list);
				if (this.SpecialAnimInstance != null)
				{
					WorldGlobal.ToTsArray<int>(tarray2, list2);
				}
				if (list.Count > CharacterAnimationSyncComponent.MaxStatesLength || list2.Count > CharacterAnimationSyncComponent.MaxStatesLength)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
					Entity entity = base.Entity;
					string message = "状态机增量变化数组超长";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("v", CharacterAnimationSyncComponent.OrderToString(list));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("length", list.Count);
					instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.AnimationStateInitPush();
					return;
				}
				this.AnimationStateChangedPush(base.Entity, list, list2);
			}
		}

		// Token: 0x0603D738 RID: 251704 RVA: 0x011C66CE File Offset: 0x011C48CE
		public void ClearOrders()
		{
			UAnimInstance mainAnimInstance = this.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.ClearStateOrdersReceivePending();
			}
			UAnimInstance mainAnimInstance2 = this.MainAnimInstance;
			if (mainAnimInstance2 == null)
			{
				return;
			}
			mainAnimInstance2.ClearStateOrdersSendPending();
		}

		// Token: 0x0603D739 RID: 251705 RVA: 0x011C66F4 File Offset: 0x011C48F4
		private void AnimationGameplayTagRequest(int tagId, bool add)
		{
			if (!GameModeModel.Instance.IsMulti || !this.ActorComp.IsMoveAutonomousProxy)
			{
				return;
			}
			AnimationGameplayTagPush animationGameplayTagPush = AnimationGameplayTagPush.Create();
			animationGameplayTagPush.ChangedTagId = tagId;
			animationGameplayTagPush.IsAdd = add;
			CombatNet.Instance.Send(EPushMessageId.AnimationGameplayTagPush, base.Entity, animationGameplayTagPush, null, null, null);
		}

		// Token: 0x0603D73A RID: 251706 RVA: 0x011C6764 File Offset: 0x011C4964
		[NullableContext(1)]
		public void AnimationGameplayTagHandle(AnimationGameplayTagNotify data)
		{
			if (this.ActorComp.IsMoveAutonomousProxy || this.TagComp == null)
			{
				return;
			}
			if (data.IsAdd)
			{
				this.TagComp.AddTag(new int?(data.ChangedTagId));
				return;
			}
			this.TagComp.RemoveTag(new int?(data.ChangedTagId));
		}

		// Token: 0x0603D73B RID: 251707 RVA: 0x011C67BD File Offset: 0x011C49BD
		[CombatListen(ENotifyMessageId.AnimationGameplayTagNotify, true, false)]
		public static void AnimationGameplayTagNotify(Entity entity, [Nullable(1)] AnimationGameplayTagNotify data, CombatCommon combatCommon = null)
		{
			if (entity != null)
			{
				CharacterAnimationSyncComponent component = entity.GetComponent<CharacterAnimationSyncComponent>();
				if (component == null)
				{
					return;
				}
				component.AnimationGameplayTagHandle(data);
			}
		}

		// Token: 0x0603D73C RID: 251708 RVA: 0x011C67D4 File Offset: 0x011C49D4
		[NullableContext(1)]
		public unsafe void AnimationStateChangedPush(Entity entity, IList<int> states, IList<int> specialStates)
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				return;
			}
			AnimationStateChangedPush animationStateChangedPush = Aki.Protocol.AnimationStateChangedPush.Create();
			animationStateChangedPush.States.AddRange(states);
			animationStateChangedPush.SpecialStates.AddRange(specialStates);
			animationStateChangedPush.ModelId = this.CheckModelId;
			if (animationStateChangedPush.States.Count > 600 || animationStateChangedPush.SpecialStates.Count > 600)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
				string message = "状态机增量变化数组超长";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("States", CharacterAnimationSyncComponent.OrderToString(animationStateChangedPush.States));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SpecialStates", CharacterAnimationSyncComponent.OrderToString(animationStateChangedPush.SpecialStates));
				instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			CombatNet.Instance.Send(EPushMessageId.AnimationStateChangedPush, entity, animationStateChangedPush, null, null, null);
		}

		// Token: 0x0603D73D RID: 251709 RVA: 0x011C68D0 File Offset: 0x011C4AD0
		public unsafe void AnimationStateInitPush()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				return;
			}
			this.MainAnimInstance.GetOriginStates(ref CharacterAnimationSyncComponent.animationStateListRef);
			TArray<int> tarray = CharacterAnimationSyncComponent.animationStateListRef;
			UAnimInstance specialAnimInstance = this.SpecialAnimInstance;
			if (specialAnimInstance != null)
			{
				specialAnimInstance.GetOriginStates(ref CharacterAnimationSyncComponent.specialStateListRef);
			}
			TArray<int> tarray2 = CharacterAnimationSyncComponent.specialStateListRef;
			if (tarray.Num() > 0 || tarray2.Num() > 0)
			{
				List<int> list = new List<int>();
				List<int> list2 = new List<int>();
				WorldGlobal.ToTsArray<int>(tarray, list);
				WorldGlobal.ToTsArray<int>(tarray2, list2);
				AnimationStateInitPush animationStateInitPush = Aki.Protocol.AnimationStateInitPush.Create();
				animationStateInitPush.States.AddRange(list);
				animationStateInitPush.SpecialStates.AddRange(list2);
				animationStateInitPush.ModelId = this.CheckModelId;
				if (animationStateInitPush.States.Count > 600 || animationStateInitPush.SpecialStates.Count > 600)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
					Entity entity = base.Entity;
					string message = "状态机增量变化数组超长";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("States", CharacterAnimationSyncComponent.OrderToString(animationStateInitPush.States));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SpecialStates", CharacterAnimationSyncComponent.OrderToString(animationStateInitPush.SpecialStates));
					instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Animation;
				Entity entity2 = base.Entity;
				string message2 = "动画状态机初始化请求";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("v", CharacterAnimationSyncComponent.OrderToString(list));
				instance2.Info(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				CombatNet.Instance.Send(EPushMessageId.AnimationStateInitPush, base.Entity, animationStateInitPush, null, null, null);
			}
		}

		// Token: 0x0603D73E RID: 251710 RVA: 0x011C6A78 File Offset: 0x011C4C78
		[CombatListen(ENotifyMessageId.AnimationStateChangedNotify, true, false)]
		public unsafe static void AnimationStateChangedNotify(Entity entity, [Nullable(1)] AnimationStateChangedNotify data, CombatCommon combatCommon = null)
		{
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (entity == null || baseActorComponent == null || baseActorComponent.IsMoveAutonomousProxy)
			{
				return;
			}
			CharacterAnimationSyncComponent component = entity.GetComponent<CharacterAnimationSyncComponent>();
			if (component.CheckModelId != 0 && data.ModelId != component.CheckModelId)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
				string message = "动画状态机修改通知, ModelId不匹配";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NotifyModelId", data.ModelId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CheckModelId", component.CheckModelId);
				instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			WorldGlobal.ToUeInt32Array(data.States, CharacterAnimationSyncComponent.animationStates);
			WorldGlobal.ToUeInt32Array(data.SpecialStates, CharacterAnimationSyncComponent.specialAnimationStates);
			if (component != null)
			{
				UAnimInstance mainAnimInstance = component.MainAnimInstance;
				if (mainAnimInstance != null)
				{
					mainAnimInstance.SetStateOrdersReceivePending(CharacterAnimationSyncComponent.animationStates);
				}
			}
			if (component != null)
			{
				UAnimInstance specialAnimInstance = component.SpecialAnimInstance;
				if (specialAnimInstance == null)
				{
					return;
				}
				specialAnimInstance.SetStateOrdersReceivePending(CharacterAnimationSyncComponent.specialAnimationStates);
			}
		}

		// Token: 0x0603D73F RID: 251711 RVA: 0x011C6B78 File Offset: 0x011C4D78
		[CombatListen(ENotifyMessageId.PackAnimChangedNotify, false, false)]
		public unsafe static void PackAnimChangedNotify(Entity entity, [Nullable(1)] PackAnimChangedNotify info, CombatCommon combatCommon = null)
		{
			foreach (AnimStateChangeInfoList animStateChangeInfoList in info.EntityAnimState)
			{
				long entityId = animStateChangeInfoList.EntityId;
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(entityId);
				BaseActorComponent baseActorComponent;
				if (entity2 == null)
				{
					baseActorComponent = null;
				}
				else
				{
					WorldEntity entity3 = entity2.Entity;
					baseActorComponent = ((entity3 != null) ? entity3.GetComponent<BaseActorComponent>() : null);
				}
				BaseActorComponent baseActorComponent2 = baseActorComponent;
				CharacterAnimationSyncComponent characterAnimationSyncComponent;
				if (entity2 == null)
				{
					characterAnimationSyncComponent = null;
				}
				else
				{
					WorldEntity entity4 = entity2.Entity;
					characterAnimationSyncComponent = ((entity4 != null) ? entity4.GetComponent<CharacterAnimationSyncComponent>() : null);
				}
				CharacterAnimationSyncComponent characterAnimationSyncComponent2 = characterAnimationSyncComponent;
				if (baseActorComponent2 != null && characterAnimationSyncComponent2 != null && !baseActorComponent2.IsMoveAutonomousProxy)
				{
					foreach (AnimStateChangeInfo animStateChangeInfo in animStateChangeInfoList.AnimStateChangeInfos)
					{
						if (characterAnimationSyncComponent2.CheckModelId != 0 && animStateChangeInfo.ModelId != characterAnimationSyncComponent2.CheckModelId)
						{
							CombatLog instance = CombatLog.Instance;
							CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
							string message = "动画状态机修改通知, ModelId不匹配";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NotifyModelId", baseActorComponent2.Entity);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CheckModelId", characterAnimationSyncComponent2.CheckModelId);
							instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
						else
						{
							WorldGlobal.ToUeInt32Array(animStateChangeInfo.States, CharacterAnimationSyncComponent.animationStates);
							WorldGlobal.ToUeInt32Array(animStateChangeInfo.SpecialStates, CharacterAnimationSyncComponent.specialAnimationStates);
							if (characterAnimationSyncComponent2 != null)
							{
								UAnimInstance mainAnimInstance = characterAnimationSyncComponent2.MainAnimInstance;
								if (mainAnimInstance != null)
								{
									mainAnimInstance.SetStateOrdersReceivePending(CharacterAnimationSyncComponent.animationStates);
								}
							}
							if (characterAnimationSyncComponent2 != null)
							{
								UAnimInstance specialAnimInstance = characterAnimationSyncComponent2.SpecialAnimInstance;
								if (specialAnimInstance != null)
								{
									specialAnimInstance.SetStateOrdersReceivePending(CharacterAnimationSyncComponent.specialAnimationStates);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0603D740 RID: 251712 RVA: 0x011C6D54 File Offset: 0x011C4F54
		[CombatListen(ENotifyMessageId.AnimationStateInitNotify, false, false)]
		public unsafe static void AnimationStateInitNotify(Entity entity, [Nullable(1)] AnimationStateInitNotify data, CombatCommon combatCommon = null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
			string message = "动画状态机初始化通知";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("v", CharacterAnimationSyncComponent.OrderToString(data.States));
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			CharacterAnimationSyncComponent component = entity.GetComponent<CharacterAnimationSyncComponent>();
			if (component.CheckModelId != 0 && data.ModelId != component.CheckModelId)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Animation;
				string message2 = "动画状态机初始化通知, ModelId不匹配";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NotifyModelId", data.ModelId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CheckModelId", component.CheckModelId);
				instance2.Info(flag2, entity, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			TArray<int> tarray = new TArray<int>();
			WorldGlobal.ToUeInt32Array(data.States, tarray);
			UAnimInstance mainAnimInstance = component.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.SetStateOrdersReceivePending(tarray);
			}
			if (component.SpecialAnimInstance != null)
			{
				TArray<int> tarray2 = new TArray<int>();
				WorldGlobal.ToUeInt32Array(data.SpecialStates, tarray2);
				component.SpecialAnimInstance.SetStateOrdersReceivePending(tarray2);
			}
		}

		// Token: 0x0603D741 RID: 251713 RVA: 0x011C6E60 File Offset: 0x011C5060
		[NullableContext(1)]
		public static string OrderToString(IList<int> states)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = -1;
			while (num + 5 <= states.Count)
			{
				int value = states[++num];
				int num2 = states[++num];
				int num3 = num + num2;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("[");
				appendInterpolatedStringHandler.AppendFormatted<int>(value);
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
				while (num + 3 <= num3)
				{
					int value2 = states[++num];
					num++;
					int num4 = states[++num];
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("=>");
					appendInterpolatedStringHandler.AppendFormatted<int>(value2);
					stringBuilder4.Append(ref appendInterpolatedStringHandler);
					num += num4;
				}
				stringBuilder.Append("]");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0603D742 RID: 251714 RVA: 0x011C6F3C File Offset: 0x011C513C
		public void RebuildAnimationStates(bool needCheckModelId = true)
		{
			BaseAnimationComponent component = base.Entity.GetComponent<BaseAnimationComponent>();
			UAnimInstance uanimInstance = (component != null) ? component.MainAnimInstance : null;
			if (uanimInstance != null)
			{
				this.MainAnimInstanceInternal = uanimInstance;
				if (needCheckModelId)
				{
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					this.CheckModelId = ((creatureDataComp != null) ? creatureDataComp.GetModelConfig().ID : 0);
				}
				else
				{
					this.CheckModelId = 0;
				}
				this.InitAnimationStates();
				return;
			}
			this.MainAnimInstanceInternal = null;
		}

		// Token: 0x0603D743 RID: 251715 RVA: 0x011C6FA2 File Offset: 0x011C51A2
		public static void CreateStaticDefaultValue()
		{
			CharacterAnimationSyncComponent.animationStateListRef = new TArray<int>();
			CharacterAnimationSyncComponent.specialStateListRef = new TArray<int>();
			CharacterAnimationSyncComponent.animationStates = new TArray<int>();
			CharacterAnimationSyncComponent.specialAnimationStates = new TArray<int>();
		}

		// Token: 0x0603D744 RID: 251716 RVA: 0x011C6FCC File Offset: 0x011C51CC
		public static void ResetStaticDefaultValue()
		{
			CharacterAnimationSyncComponent.animationStateListRef = null;
			CharacterAnimationSyncComponent.specialStateListRef = null;
			CharacterAnimationSyncComponent.animationStates = null;
			CharacterAnimationSyncComponent.specialAnimationStates = null;
		}

		// Token: 0x0603D745 RID: 251717 RVA: 0x011C6FE8 File Offset: 0x011C51E8
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterAnimationSyncComponent characterAnimationSyncComponent = (CharacterAnimationSyncComponent)componentTemplate;
			if (characterAnimationSyncComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterAnimationSyncComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (characterAnimationSyncComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (characterAnimationSyncComponent.ListenTagChangedHandles != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ListenTagChangedHandles), "ListenTagChangedHandles"))
			{
				return false;
			}
			this.CheckModelId = characterAnimationSyncComponent.CheckModelId;
			if (characterAnimationSyncComponent.MainAnimInstanceInternal == null)
			{
				this.MainAnimInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainAnimInstanceInternal), "MainAnimInstanceInternal"))
			{
				return false;
			}
			if (characterAnimationSyncComponent.SpecialAnimInstanceInternal == null)
			{
				this.SpecialAnimInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpecialAnimInstanceInternal), "SpecialAnimInstanceInternal"))
			{
				return false;
			}
			this.LastCleanSendPendingTime = characterAnimationSyncComponent.LastCleanSendPendingTime;
			return true;
		}

		// Token: 0x1700748C RID: 29836
		// (get) Token: 0x0603D746 RID: 251718 RVA: 0x011C7119 File Offset: 0x011C5319
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700748D RID: 29837
		// (get) Token: 0x0603D747 RID: 251719 RVA: 0x011C711C File Offset: 0x011C531C
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700748E RID: 29838
		// (get) Token: 0x0603D748 RID: 251720 RVA: 0x011C711F File Offset: 0x011C531F
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402096F RID: 133487
		[Nullable(1)]
		private static TArray<int> animationStateListRef;

		// Token: 0x04020970 RID: 133488
		[Nullable(1)]
		private static TArray<int> specialStateListRef;

		// Token: 0x04020971 RID: 133489
		[Nullable(1)]
		private static TArray<int> animationStates;

		// Token: 0x04020972 RID: 133490
		[Nullable(1)]
		private static TArray<int> specialAnimationStates;

		// Token: 0x04020973 RID: 133491
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly int[] animationTagList = new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持.长按"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身右转融合"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.下半身通用融合"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.专属Special动作"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.动画控制下半身右转融入"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.动画控制下半身右转融出"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.开启全身计算"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.快速进入"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.融合.覆盖基础层动作"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.投掷"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.控物中"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.控物选取"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.进入投掷"]
		};

		// Token: 0x04020974 RID: 133492
		private const int MAX_ANIM_STATE_CHANGE_COUNT = 600;

		// Token: 0x04020975 RID: 133493
		private static readonly int MaxStatesLength = 600;

		// Token: 0x04020976 RID: 133494
		protected BaseActorComponent ActorComp;

		// Token: 0x04020977 RID: 133495
		private BaseTagComponent TagComp;

		// Token: 0x04020978 RID: 133496
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04020979 RID: 133497
		[Nullable(1)]
		private readonly List<ITagTask> ListenTagChangedHandles = new List<ITagTask>();

		// Token: 0x0402097A RID: 133498
		private int CheckModelId;

		// Token: 0x0402097B RID: 133499
		private UAnimInstance MainAnimInstanceInternal;

		// Token: 0x0402097C RID: 133500
		private UAnimInstance SpecialAnimInstanceInternal;

		// Token: 0x0402097D RID: 133501
		private double LastCleanSendPendingTime;

		// Token: 0x0402097E RID: 133502
		private readonly float CleanSendPendingInterval = 5f;
	}
}
