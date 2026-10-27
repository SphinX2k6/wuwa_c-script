using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Custom;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200717D RID: 29053
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemGravityComponent : EntityComponent
	{
		// Token: 0x06046FD1 RID: 290769 RVA: 0x011F82AC File Offset: 0x011F64AC
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TrampleComponent trampleComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemGravityComponent>() as TrampleComponent;
			if (trampleComponent == null)
			{
				return false;
			}
			this.CreatureDataComp = base.Entity.CheckGetComponent<CreatureDataComponent>();
			this.CompConfig = trampleComponent;
			this.AnimConfigMsTime = this.CompConfig.DownTime / 0.001f;
			if (this.CompConfig.UpTime != null)
			{
				this.UpAnimConfigMsTime = ((this.CompConfig.UpTime.Value > 0f) ? (this.CompConfig.UpTime.Value / 0.001f) : 0f);
			}
			else
			{
				this.UpAnimConfigMsTime = this.AnimConfigMsTime;
			}
			if (this.CompConfig.ShowLandTipRadius != null)
			{
				this.ShowLandTipRange = (float)this.CompConfig.ShowLandTipRadius.EnterRadius;
				this.HideLandTipRange = (float)this.CompConfig.ShowLandTipRadius.LeaveRadius;
			}
			return true;
		}

		// Token: 0x06046FD2 RID: 290770 RVA: 0x011F83A0 File Offset: 0x011F65A0
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<SceneItemActorComponent>();
			this.TagComp = base.Entity.CheckGetComponent<LevelTagComponent>();
			this.StateComp = base.Entity.CheckGetComponent<SceneItemStateComponent>();
			this.PropComp = base.Entity.CheckGetComponent<SceneItemPropertyComponent>();
			if (!EventSystem.Instance.HasWithTarget<bool, EntityHandle>(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal)))
			{
				EventSystem.Instance.AddWithTarget<bool, EntityHandle>(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal));
			}
			if (!RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new TMessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.RegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new TMessageRegisterCallback(this.OnServerMessageEmit));
			}
			return true;
		}

		// Token: 0x06046FD3 RID: 290771 RVA: 0x011F8478 File Offset: 0x011F6678
		protected override void OnActivate()
		{
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange)))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Temp;
				ELogAuthor author = ELogAuthor.CH;
				string message = "SceneItemGravityComponent.OnActivate: 重复添加事件";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			}
			EventSystem.Instance.AddWithTarget<bool>(base.Entity, EEventName.OnSceneItemLockPropChange, new Action<bool>(this.OnSceneItemLockPropChange));
			if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted)))
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			if (this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				this.OnSceneInteractionLoadCompleted();
			}
			TrampleComponent compConfig = this.CompConfig;
			if (((compConfig != null) ? compConfig.ShowLandTipRadius : null) != null)
			{
				this.CheckDistanceTimerHandle = TimerSystem.Instance.Forever(delegate(float _)
				{
					this.CheckPlayerDistance();
				}, 100f, 1f, null, null, true);
			}
		}

		// Token: 0x06046FD4 RID: 290772 RVA: 0x011F85CC File Offset: 0x011F67CC
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.HasWithTarget<bool, EntityHandle>(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal)))
			{
				EventSystem.Instance.RemoveWithTarget<bool, EntityHandle>(base.Entity, EEventName.OnEntityInOutRangeLocal, new Action<bool, EntityHandle>(this.OnEntityInOutRangeLocal));
			}
			if (EventSystem.Instance.HasWithTarget<bool>(base.Entity, EEventName.OnSceneItemLockPropChange, new Action<bool>(this.OnSceneItemLockPropChange)))
			{
				EventSystem.Instance.RemoveWithTarget<bool>(base.Entity, EEventName.OnSceneItemLockPropChange, new Action<bool>(this.OnSceneItemLockPropChange));
			}
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			if (RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new TMessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.UnRegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new TMessageRegisterCallback(this.OnServerMessageEmit));
			}
			if (this.CheckDistanceTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.CheckDistanceTimerHandle);
				this.CheckDistanceTimerHandle = null;
			}
			this.CloseCountDownTip();
			return true;
		}

		// Token: 0x06046FD5 RID: 290773 RVA: 0x011F8752 File Offset: 0x011F6952
		protected override void OnTick(float delta)
		{
			this.TickState(delta * this.CustomTimeDilation);
		}

		// Token: 0x06046FD6 RID: 290774 RVA: 0x011F8764 File Offset: 0x011F6964
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
			this.CustomTimeDilation = ((component != null) ? (timeDilation * component.CurrentTimeScale) : 1f);
		}

		// Token: 0x06046FD7 RID: 290775 RVA: 0x011F8795 File Offset: 0x011F6995
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			this.OnSceneItemStateChange();
		}

		// Token: 0x06046FD8 RID: 290776 RVA: 0x011F879D File Offset: 0x011F699D
		private void OnSceneItemStateChange()
		{
			this.HandleServerChangedState();
		}

		// Token: 0x06046FD9 RID: 290777 RVA: 0x011F87A5 File Offset: 0x011F69A5
		private void OnSceneItemLockPropChange(bool bLock)
		{
			this.EnableStateTick("[SceneItemGravityComponent] 锁定属性改变");
		}

		// Token: 0x06046FDA RID: 290778 RVA: 0x011F87B2 File Offset: 0x011F69B2
		private void OnSceneInteractionLoadCompleted()
		{
			this.EnableStateTick("[SceneItemGravityComponent] 场景交互物加载完毕");
			if (this.StateComp.State != SceneItemStateComponent.ESceneItemState.Born)
			{
				this.OnSceneItemStateChange();
			}
		}

		// Token: 0x06046FDB RID: 290779 RVA: 0x011F87D4 File Offset: 0x011F69D4
		private void HandleServerChangedState()
		{
			switch (this.StateComp.State)
			{
			case SceneItemStateComponent.ESceneItemState.Normal:
				this.ChangeTransition(true);
				return;
			case SceneItemStateComponent.ESceneItemState.Active:
				this.ChangeAnimState(SceneItemGravityComponent.ESceneItemGravityState.AtBottom);
				return;
			case SceneItemStateComponent.ESceneItemState.Destroy:
				break;
			case SceneItemStateComponent.ESceneItemState.Completed:
				this.CloseCountDownTip();
				this.DisableStateTick("[SceneItemGravityComponent] 重力机关处于完成态");
				return;
			case SceneItemStateComponent.ESceneItemState.Custom:
			{
				LevelTagComponent tagComp = this.TagComp;
				if (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.静默"]))
				{
					this.CloseCountDownTip();
					this.DisableStateTick("[SceneItemGravityComponent] 重力机关处于静默态");
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06046FDC RID: 290780 RVA: 0x011F8860 File Offset: 0x011F6A60
		public void ChangeTransition(bool isUp)
		{
			switch (this.AnimState)
			{
			case SceneItemGravityComponent.ESceneItemGravityState.AtTop:
			case SceneItemGravityComponent.ESceneItemGravityState.Rising:
				if (!isUp)
				{
					this.ChangeAnimState(SceneItemGravityComponent.ESceneItemGravityState.Falling);
					return;
				}
				break;
			case SceneItemGravityComponent.ESceneItemGravityState.AtBottom:
			case SceneItemGravityComponent.ESceneItemGravityState.Falling:
				if (isUp)
				{
					this.ChangeAnimState(SceneItemGravityComponent.ESceneItemGravityState.Rising);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06046FDD RID: 290781 RVA: 0x011F88A0 File Offset: 0x011F6AA0
		private unsafe void ChangeAnimState(SceneItemGravityComponent.ESceneItemGravityState targetAnimState)
		{
			if (!this.GetIsLoadComplete())
			{
				return;
			}
			if (this.AnimState == targetAnimState)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SceneItemGravityComponent] ChangeAnimState";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FromAnimState", this.AnimState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ToAnimState", targetAnimState);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (targetAnimState == SceneItemGravityComponent.ESceneItemGravityState.Rising && this.UpAnimConfigMsTime <= 0f)
			{
				this.CloseCountDownTip();
				this.ChangePerformTagByState(this.AnimState, SceneItemGravityComponent.ESceneItemGravityState.AtTop);
				this.AnimState = SceneItemGravityComponent.ESceneItemGravityState.AtTop;
				this.TickState(0f);
				return;
			}
			if (targetAnimState == SceneItemGravityComponent.ESceneItemGravityState.Falling)
			{
				this.OpenCountDownTip();
			}
			if (targetAnimState == SceneItemGravityComponent.ESceneItemGravityState.Rising)
			{
				this.CloseCountDownTip();
			}
			this.ChangePerformTagByState(this.AnimState, targetAnimState);
			this.AnimState = targetAnimState;
			this.TickState(0f);
		}

		// Token: 0x06046FDE RID: 290782 RVA: 0x011F89C8 File Offset: 0x011F6BC8
		private void TickState(float delta = 0f)
		{
			if (!this.GetIsLoadComplete())
			{
				this.DisableStateTick("[SceneItemGravityComponent] 场景交互物未初始化");
				return;
			}
			if (!this.GetIsSelfEnable())
			{
				this.DisableStateTick("[SceneItemGravityComponent] 重力机关被停用(完成态或被锁定或静默)");
				return;
			}
			switch (this.AnimState)
			{
			case SceneItemGravityComponent.ESceneItemGravityState.AtTop:
				this.TickAtTop(delta);
				return;
			case SceneItemGravityComponent.ESceneItemGravityState.AtBottom:
				this.TickAtBottom(delta);
				return;
			case SceneItemGravityComponent.ESceneItemGravityState.Rising:
				this.TickRising(delta);
				return;
			case SceneItemGravityComponent.ESceneItemGravityState.Falling:
				this.TickFalling(delta);
				return;
			default:
				return;
			}
		}

		// Token: 0x06046FDF RID: 290783 RVA: 0x011F8A3A File Offset: 0x011F6C3A
		private void TickAtTop(float delta)
		{
			this.DownAnimPlayedMsTime = 0f;
			this.CloseCountDownTip();
			this.DisableStateTick("[SceneItemGravityComponent] 到达顶部");
		}

		// Token: 0x06046FE0 RID: 290784 RVA: 0x011F8A58 File Offset: 0x011F6C58
		private void TickAtBottom(float delta)
		{
			this.DownAnimPlayedMsTime = this.AnimConfigMsTime;
			if (this.IsCountDownTipOpen)
			{
				EventSystem.Instance.Emit<float>(EEventName.OnUnOpenedAreaCountDownUpdate, 0f);
				this.IsCountDownTipOpen = false;
			}
			this.DisableStateTick("[SceneItemGravityComponent] 到达底部");
		}

		// Token: 0x06046FE1 RID: 290785 RVA: 0x011F8A98 File Offset: 0x011F6C98
		private void TickRising(float delta)
		{
			float num = (this.AnimConfigMsTime > 0f) ? (delta * (this.AnimConfigMsTime / this.UpAnimConfigMsTime)) : delta;
			this.DownAnimPlayedMsTime = MathUtils.Instance.Clamp(this.DownAnimPlayedMsTime - num, 0f, this.AnimConfigMsTime);
			this.EnableStateTick("[SceneItemGravityComponent] 上升中");
			if (this.DownAnimPlayedMsTime <= 0f)
			{
				this.ChangeAnimState(SceneItemGravityComponent.ESceneItemGravityState.AtTop);
			}
		}

		// Token: 0x06046FE2 RID: 290786 RVA: 0x011F8B07 File Offset: 0x011F6D07
		private void TickFalling(float delta)
		{
			this.DownAnimPlayedMsTime = MathUtils.Instance.Clamp(this.DownAnimPlayedMsTime + delta, 0f, this.AnimConfigMsTime);
			this.UpdateCountDownTip();
			this.EnableStateTick("[SceneItemGravityComponent] 下降中");
		}

		// Token: 0x06046FE3 RID: 290787 RVA: 0x011F8B3D File Offset: 0x011F6D3D
		private void ChangePerformTagByState(SceneItemGravityComponent.ESceneItemGravityState fromState, SceneItemGravityComponent.ESceneItemGravityState toState)
		{
			this.ChangeRiseAndFallPerformByState(toState);
			this.ChangeInOutTopAndBottomPerformTagByState(fromState, toState);
		}

		// Token: 0x06046FE4 RID: 290788 RVA: 0x011F8B50 File Offset: 0x011F6D50
		private void ChangeRiseAndFallPerformByState(SceneItemGravityComponent.ESceneItemGravityState toState)
		{
			if (this.TagComp == null)
			{
				return;
			}
			int? tagId = null;
			int? tagId2 = null;
			if (toState > SceneItemGravityComponent.ESceneItemGravityState.AtBottom)
			{
				if (toState - SceneItemGravityComponent.ESceneItemGravityState.Rising <= 1)
				{
					if (toState == SceneItemGravityComponent.ESceneItemGravityState.Falling)
					{
						tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.上升"]);
						tagId = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.下降"]);
					}
					else
					{
						tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.下降"]);
						tagId = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.上升"]);
					}
					bool flag = this.TagComp.HasTag(tagId2.Value);
					bool flag2 = !this.TagComp.HasTag(tagId.Value);
					if (flag || flag2)
					{
						float? num = null;
						if (flag)
						{
							num = this.ActorComp.GetActiveTagSequencePlaybackProgress(GameplayTagUtils.GetGameplayTagById(tagId2.Value).Value);
							this.TagComp.RemoveTag(tagId2);
						}
						if (flag2)
						{
							this.TagComp.AddTag(tagId);
							if (num != null && num.GetValueOrDefault() != 0f)
							{
								float? num2 = num;
								float num3 = (float)1;
								if (num2.GetValueOrDefault() < num3 & num2 != null)
								{
									float progress = MathUtils.Instance.Clamp(1f - num.Value, 0f, 1f);
									this.ActorComp.SetActiveTagSequencePlaybackProgress(GameplayTagUtils.GetGameplayTagById(tagId.Value).Value, progress);
								}
							}
							float durationSecond = (toState == SceneItemGravityComponent.ESceneItemGravityState.Rising) ? this.GetUpTimeSec() : this.CompConfig.DownTime;
							this.ActorComp.SetActiveTagSequenceDurationTime(GameplayTagUtils.GetGameplayTagById(tagId.Value).Value, durationSecond);
							return;
						}
					}
				}
			}
			else
			{
				if (toState == SceneItemGravityComponent.ESceneItemGravityState.AtTop)
				{
					tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.上升"]);
				}
				else
				{
					tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.下降"]);
				}
				if (this.TagComp.HasTag(tagId2.Value))
				{
					this.ActorComp.SetActiveTagSequencePlaybackProgress(GameplayTagUtils.GetGameplayTagById(tagId2.Value).Value, 1f);
					this.TagComp.RemoveTag(tagId2);
					return;
				}
				foreach (int num4 in new int[]
				{
					GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.上升"],
					GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.下降"]
				})
				{
					if (this.TagComp.HasTag(num4))
					{
						this.TagComp.RemoveTag(new int?(num4));
					}
				}
				this.TagComp.AddTag(tagId2);
				this.ActorComp.SetActiveTagSequencePlaybackProgress(GameplayTagUtils.GetGameplayTagById(tagId2.Value).Value, 1f);
				this.TagComp.RemoveTag(tagId2);
			}
		}

		// Token: 0x06046FE5 RID: 290789 RVA: 0x011F8E35 File Offset: 0x011F7035
		[NullableContext(1)]
		private void OnServerMessageEmit(AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, Entity otherEntity, ErrorCode errorCode)
		{
			if (errorCode == ErrorCode.ErrOnlineInteractNotOpen || errorCode == ErrorCode.ErrOnlineInteractNoPermission || errorCode == ErrorCode.ErrInteractMultiGameMode)
			{
				LevelGamePlayController.Instance.ShowFakeErrorCodeTips(600064);
			}
		}

		// Token: 0x06046FE6 RID: 290790 RVA: 0x011F8E64 File Offset: 0x011F7064
		private void ChangeInOutTopAndBottomPerformTagByState(SceneItemGravityComponent.ESceneItemGravityState fromState, SceneItemGravityComponent.ESceneItemGravityState toState)
		{
			if (this.TagComp == null)
			{
				return;
			}
			int? tagId = null;
			int? tagId2 = null;
			switch (fromState)
			{
			case SceneItemGravityComponent.ESceneItemGravityState.AtTop:
				tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.上升到顶"]);
				if (toState == SceneItemGravityComponent.ESceneItemGravityState.Falling)
				{
					tagId = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.顶部下降"]);
				}
				break;
			case SceneItemGravityComponent.ESceneItemGravityState.AtBottom:
				tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.下降到底"]);
				if (toState == SceneItemGravityComponent.ESceneItemGravityState.Rising)
				{
					tagId = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.底部上升"]);
				}
				break;
			case SceneItemGravityComponent.ESceneItemGravityState.Rising:
				tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.底部上升"]);
				if (toState == SceneItemGravityComponent.ESceneItemGravityState.AtTop)
				{
					tagId = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.上升到顶"]);
				}
				break;
			case SceneItemGravityComponent.ESceneItemGravityState.Falling:
				tagId2 = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.顶部下降"]);
				if (toState == SceneItemGravityComponent.ESceneItemGravityState.AtBottom)
				{
					tagId = new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.踩踏机关.下降到底"]);
				}
				break;
			}
			if (tagId2 != null && this.TagComp.HasTag(tagId2.Value))
			{
				this.TagComp.RemoveTag(tagId2);
			}
			if (tagId != null && !this.TagComp.HasTag(tagId.Value))
			{
				this.TagComp.AddTag(tagId);
			}
		}

		// Token: 0x06046FE7 RID: 290791 RVA: 0x011F8FC3 File Offset: 0x011F71C3
		private bool GetIsLoadComplete()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			return actorComp != null && actorComp.GetIsSceneInteractionLoadCompleted();
		}

		// Token: 0x06046FE8 RID: 290792 RVA: 0x011F8FD8 File Offset: 0x011F71D8
		private bool GetIsSelfEnable()
		{
			return this.StateComp != null && this.PropComp != null && this.TagComp != null && !this.StateComp.IsInState(SceneItemStateComponent.ESceneItemState.Completed) && !this.PropComp.IsLocked && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.静默"]);
		}

		// Token: 0x06046FE9 RID: 290793 RVA: 0x011F9038 File Offset: 0x011F7238
		private float GetUpTimeSec()
		{
			if (this.CompConfig.UpTime == null)
			{
				return this.CompConfig.DownTime;
			}
			if (this.CompConfig.UpTime.Value <= 0f)
			{
				return 0f;
			}
			return this.CompConfig.UpTime.Value;
		}

		// Token: 0x06046FEA RID: 290794 RVA: 0x011F909C File Offset: 0x011F729C
		[NullableContext(1)]
		private void OnEntityInOutRangeLocal(bool isEnter, EntityHandle handle)
		{
			WorldEntity entity = handle.Entity;
			if (((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null) == null && !isEnter)
			{
				return;
			}
			bool? stopTeleControlMove = this.CompConfig.StopTeleControlMove;
			bool flag = false;
			if (stopTeleControlMove.GetValueOrDefault() == flag & stopTeleControlMove != null)
			{
				return;
			}
			SceneItemManipulatableComponent sceneItemManipulatableComponent = (entity != null) ? entity.GetComponent<SceneItemManipulatableComponent>() : null;
			SceneItemActorComponent sceneItemActorComponent = (entity != null) ? entity.GetComponent<SceneItemActorComponent>() : null;
			if (sceneItemManipulatableComponent != null && sceneItemActorComponent != null && sceneItemActorComponent.IsAutonomousProxy)
			{
				sceneItemManipulatableComponent.ForceStopDropping();
			}
		}

		// Token: 0x06046FEB RID: 290795 RVA: 0x011F9115 File Offset: 0x011F7315
		private bool IsStateTickEnabled()
		{
			return this.TickDisableHandle == null;
		}

		// Token: 0x06046FEC RID: 290796 RVA: 0x011F9125 File Offset: 0x011F7325
		[NullableContext(1)]
		private void EnableStateTick(string reason)
		{
			if (!this.IsStateTickEnabled() && base.Enable(this.TickDisableHandle, reason))
			{
				this.TickDisableHandle = null;
			}
		}

		// Token: 0x06046FED RID: 290797 RVA: 0x011F914A File Offset: 0x011F734A
		[NullableContext(1)]
		private void DisableStateTick(string reason)
		{
			if (this.IsStateTickEnabled())
			{
				this.TickDisableHandle = new int?(base.Disable(reason));
			}
		}

		// Token: 0x06046FEE RID: 290798 RVA: 0x011F9168 File Offset: 0x011F7368
		private void CheckPlayerDistance()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			AActor aactor = baseCharacter;
			SceneItemActorComponent actorComp = this.ActorComp;
			float distanceTo = aactor.GetDistanceTo((actorComp != null) ? actorComp.Owner : null);
			if (!this.ShowingLandTip || distanceTo <= this.HideLandTipRange)
			{
				if (!this.ShowingLandTip && distanceTo < this.ShowLandTipRange)
				{
					this.ShowingLandTip = true;
					ManipulaterModel instance = ManipulaterModel.Instance;
					if (instance == null)
					{
						return;
					}
					instance.AddShowLandTipsCount(base.Entity);
				}
				return;
			}
			this.ShowingLandTip = false;
			ManipulaterModel instance2 = ManipulaterModel.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.RemoveShowLandTipsCount(base.Entity);
		}

		// Token: 0x06046FEF RID: 290799 RVA: 0x011F91F4 File Offset: 0x011F73F4
		private void OpenCountDownTip()
		{
			TrampleComponent compConfig = this.CompConfig;
			ICountDownTextTip countDownTextTip = (compConfig != null) ? compConfig.TrampleTipOption : null;
			if (countDownTextTip == null)
			{
				return;
			}
			if (countDownTextTip.Type != ETrampleTipType.CountDownTextTip)
			{
				return;
			}
			if (this.IsCountDownTipOpen)
			{
				return;
			}
			ICountDownTextTip countDownTextTip2 = countDownTextTip;
			UnOpenedAreaCountDownFloatTipsParam param = new UnOpenedAreaCountDownFloatTipsParam
			{
				TidCountDownTip = countDownTextTip2.TidCountDownTip
			};
			UiManager.Instance.OpenView(EUiViewName.UnOpenedAreaCountDownFloatTips, param, null);
			this.IsCountDownTipOpen = true;
		}

		// Token: 0x06046FF0 RID: 290800 RVA: 0x011F9256 File Offset: 0x011F7456
		private void CloseCountDownTip()
		{
			if (!this.IsCountDownTipOpen)
			{
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.UnOpenedAreaCountDownFloatTips, null);
			this.IsCountDownTipOpen = false;
		}

		// Token: 0x06046FF1 RID: 290801 RVA: 0x011F9278 File Offset: 0x011F7478
		private void UpdateCountDownTip()
		{
			if (!this.IsCountDownTipOpen)
			{
				return;
			}
			float p = (this.AnimConfigMsTime - this.DownAnimPlayedMsTime) * 0.001f;
			EventSystem.Instance.Emit<float>(EEventName.OnUnOpenedAreaCountDownUpdate, p);
		}

		// Token: 0x17009D78 RID: 40312
		// (get) Token: 0x06046FF2 RID: 290802 RVA: 0x011F92B3 File Offset: 0x011F74B3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ActivateActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				TrampleComponent compConfig = this.CompConfig;
				if (compConfig == null)
				{
					return null;
				}
				return compConfig.EnterActions;
			}
		}

		// Token: 0x17009D79 RID: 40313
		// (get) Token: 0x06046FF3 RID: 290803 RVA: 0x011F92C6 File Offset: 0x011F74C6
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> DeactivateActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				TrampleComponent compConfig = this.CompConfig;
				if (compConfig == null)
				{
					return null;
				}
				return compConfig.ExitActions;
			}
		}

		// Token: 0x06046FF4 RID: 290804 RVA: 0x011F92DC File Offset: 0x011F74DC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemGravityComponent sceneItemGravityComponent = (SceneItemGravityComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (sceneItemGravityComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemGravityComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (sceneItemGravityComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StateComp"))
			{
				if (sceneItemGravityComponent.StateComp == null)
				{
					this.StateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemStateComponent>(this.StateComp), "StateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PropComp"))
			{
				if (sceneItemGravityComponent.PropComp == null)
				{
					this.PropComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemPropertyComponent>(this.PropComp), "PropComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CompConfig"))
			{
				if (sceneItemGravityComponent.CompConfig == null)
				{
					this.CompConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TrampleComponent>(this.CompConfig), "CompConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AnimState"))
			{
				this.AnimState = sceneItemGravityComponent.AnimState;
			}
			if (base.CanResetComponentProperty("AnimConfigMsTime"))
			{
				this.AnimConfigMsTime = sceneItemGravityComponent.AnimConfigMsTime;
			}
			if (base.CanResetComponentProperty("UpAnimConfigMsTime"))
			{
				this.UpAnimConfigMsTime = sceneItemGravityComponent.UpAnimConfigMsTime;
			}
			if (base.CanResetComponentProperty("DownAnimPlayedMsTime"))
			{
				this.DownAnimPlayedMsTime = sceneItemGravityComponent.DownAnimPlayedMsTime;
			}
			if (base.CanResetComponentProperty("TickDisableHandle"))
			{
				this.TickDisableHandle = sceneItemGravityComponent.TickDisableHandle;
			}
			if (base.CanResetComponentProperty("CustomTimeDilation"))
			{
				this.CustomTimeDilation = sceneItemGravityComponent.CustomTimeDilation;
			}
			if (base.CanResetComponentProperty("IsCountDownTipOpen"))
			{
				this.IsCountDownTipOpen = sceneItemGravityComponent.IsCountDownTipOpen;
			}
			if (base.CanResetComponentProperty("ShowLandTipRange"))
			{
				this.ShowLandTipRange = sceneItemGravityComponent.ShowLandTipRange;
			}
			if (base.CanResetComponentProperty("HideLandTipRange"))
			{
				this.HideLandTipRange = sceneItemGravityComponent.HideLandTipRange;
			}
			if (base.CanResetComponentProperty("ShowingLandTip"))
			{
				this.ShowingLandTip = sceneItemGravityComponent.ShowingLandTip;
			}
			if (base.CanResetComponentProperty("CheckDistanceTimerHandle"))
			{
				if (sceneItemGravityComponent.CheckDistanceTimerHandle == null)
				{
					this.CheckDistanceTimerHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.CheckDistanceTimerHandle), "CheckDistanceTimerHandle"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040254D1 RID: 152785
		private const int CHECK_DISTANCE_INTERVAL = 100;

		// Token: 0x040254D2 RID: 152786
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040254D3 RID: 152787
		private SceneItemActorComponent ActorComp;

		// Token: 0x040254D4 RID: 152788
		private LevelTagComponent TagComp;

		// Token: 0x040254D5 RID: 152789
		private SceneItemStateComponent StateComp;

		// Token: 0x040254D6 RID: 152790
		private SceneItemPropertyComponent PropComp;

		// Token: 0x040254D7 RID: 152791
		private TrampleComponent CompConfig;

		// Token: 0x040254D8 RID: 152792
		private SceneItemGravityComponent.ESceneItemGravityState AnimState;

		// Token: 0x040254D9 RID: 152793
		private float AnimConfigMsTime;

		// Token: 0x040254DA RID: 152794
		private float UpAnimConfigMsTime;

		// Token: 0x040254DB RID: 152795
		private float DownAnimPlayedMsTime;

		// Token: 0x040254DC RID: 152796
		private int? TickDisableHandle;

		// Token: 0x040254DD RID: 152797
		private float CustomTimeDilation = 1f;

		// Token: 0x040254DE RID: 152798
		private bool IsCountDownTipOpen;

		// Token: 0x040254DF RID: 152799
		private float ShowLandTipRange = -1f;

		// Token: 0x040254E0 RID: 152800
		private float HideLandTipRange = -1f;

		// Token: 0x040254E1 RID: 152801
		private bool ShowingLandTip;

		// Token: 0x040254E2 RID: 152802
		private TimerHandle CheckDistanceTimerHandle;

		// Token: 0x0200CEC2 RID: 52930
		[NullableContext(0)]
		private enum ESceneItemGravityState
		{
			// Token: 0x0403E36B RID: 254827
			AtTop,
			// Token: 0x0403E36C RID: 254828
			AtBottom,
			// Token: 0x0403E36D RID: 254829
			Rising,
			// Token: 0x0403E36E RID: 254830
			Falling
		}
	}
}
