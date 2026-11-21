using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Game.NewWorld.Character.Custom.Components.Range;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006231 RID: 25137
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemGravityComponent : EntityComponent
	{
		// Token: 0x0603C85F RID: 247903 RVA: 0x01152C8C File Offset: 0x01150E8C
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

		// Token: 0x0603C860 RID: 247904 RVA: 0x01152D80 File Offset: 0x01150F80
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
			if (!RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new MessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.RegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new MessageRegisterCallback(this.OnServerMessageEmit));
			}
			return true;
		}

		// Token: 0x0603C861 RID: 247905 RVA: 0x01152E58 File Offset: 0x01151058
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

		// Token: 0x0603C862 RID: 247906 RVA: 0x01152FAC File Offset: 0x011511AC
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
			if (RangeComponentMessageManager.Instance.HasMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new MessageRegisterCallback(this.OnServerMessageEmit)))
			{
				RangeComponentMessageManager.Instance.UnRegisterMessage(base.Entity, AccessRangeType.RangeEnter, AccessRangeResultType.Trample, new MessageRegisterCallback(this.OnServerMessageEmit));
			}
			if (this.CheckDistanceTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.CheckDistanceTimerHandle);
				this.CheckDistanceTimerHandle = null;
			}
			this.CloseCountDownTip();
			return true;
		}

		// Token: 0x0603C863 RID: 247907 RVA: 0x01153132 File Offset: 0x01151332
		protected override void OnTick(float delta)
		{
			this.TickState(delta * this.CustomTimeDilation);
		}

		// Token: 0x0603C864 RID: 247908 RVA: 0x01153144 File Offset: 0x01151344
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
			this.CustomTimeDilation = ((component != null) ? (timeDilation * component.CurrentTimeScale) : 1f);
		}

		// Token: 0x0603C865 RID: 247909 RVA: 0x01153175 File Offset: 0x01151375
		private void OnSceneItemStateChange(int stateId, bool isReady)
		{
			this.OnSceneItemStateChange();
		}

		// Token: 0x0603C866 RID: 247910 RVA: 0x0115317D File Offset: 0x0115137D
		private void OnSceneItemStateChange()
		{
			this.HandleServerChangedState();
		}

		// Token: 0x0603C867 RID: 247911 RVA: 0x01153185 File Offset: 0x01151385
		private void OnSceneItemLockPropChange(bool bLock)
		{
			this.EnableStateTick("[SceneItemGravityComponent] 锁定属性改变");
		}

		// Token: 0x0603C868 RID: 247912 RVA: 0x01153192 File Offset: 0x01151392
		private void OnSceneInteractionLoadCompleted()
		{
			this.EnableStateTick("[SceneItemGravityComponent] 场景交互物加载完毕");
			if (this.StateComp.State != SceneItemStateComponent.ESceneItemState.Born)
			{
				this.OnSceneItemStateChange();
			}
		}

		// Token: 0x0603C869 RID: 247913 RVA: 0x011531B4 File Offset: 0x011513B4
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

		// Token: 0x0603C86A RID: 247914 RVA: 0x01153240 File Offset: 0x01151440
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

		// Token: 0x0603C86B RID: 247915 RVA: 0x01153280 File Offset: 0x01151480
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

		// Token: 0x0603C86C RID: 247916 RVA: 0x011533A8 File Offset: 0x011515A8
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

		// Token: 0x0603C86D RID: 247917 RVA: 0x0115341A File Offset: 0x0115161A
		private void TickAtTop(float delta)
		{
			this.DownAnimPlayedMsTime = 0f;
			this.CloseCountDownTip();
			this.DisableStateTick("[SceneItemGravityComponent] 到达顶部");
		}

		// Token: 0x0603C86E RID: 247918 RVA: 0x01153438 File Offset: 0x01151638
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

		// Token: 0x0603C86F RID: 247919 RVA: 0x01153478 File Offset: 0x01151678
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

		// Token: 0x0603C870 RID: 247920 RVA: 0x011534E7 File Offset: 0x011516E7
		private void TickFalling(float delta)
		{
			this.DownAnimPlayedMsTime = MathUtils.Instance.Clamp(this.DownAnimPlayedMsTime + delta, 0f, this.AnimConfigMsTime);
			this.UpdateCountDownTip();
			this.EnableStateTick("[SceneItemGravityComponent] 下降中");
		}

		// Token: 0x0603C871 RID: 247921 RVA: 0x0115351D File Offset: 0x0115171D
		private void ChangePerformTagByState(SceneItemGravityComponent.ESceneItemGravityState fromState, SceneItemGravityComponent.ESceneItemGravityState toState)
		{
			this.ChangeRiseAndFallPerformByState(toState);
			this.ChangeInOutTopAndBottomPerformTagByState(fromState, toState);
		}

		// Token: 0x0603C872 RID: 247922 RVA: 0x01153530 File Offset: 0x01151730
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

		// Token: 0x0603C873 RID: 247923 RVA: 0x01153815 File Offset: 0x01151A15
		[NullableContext(1)]
		private void OnServerMessageEmit(AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, Entity otherEntity, ErrorCode errorCode)
		{
			if (errorCode == ErrorCode.ErrOnlineInteractNotOpen || errorCode == ErrorCode.ErrOnlineInteractNoPermission || errorCode == ErrorCode.ErrInteractMultiGameMode)
			{
				LevelGamePlayController.Instance.ShowFakeErrorCodeTips(600064);
			}
		}

		// Token: 0x0603C874 RID: 247924 RVA: 0x01153844 File Offset: 0x01151A44
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

		// Token: 0x0603C875 RID: 247925 RVA: 0x011539A3 File Offset: 0x01151BA3
		private bool GetIsLoadComplete()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			return actorComp != null && actorComp.GetIsSceneInteractionLoadCompleted();
		}

		// Token: 0x0603C876 RID: 247926 RVA: 0x011539B8 File Offset: 0x01151BB8
		private bool GetIsSelfEnable()
		{
			return this.StateComp != null && this.PropComp != null && this.TagComp != null && !this.StateComp.IsInState(SceneItemStateComponent.ESceneItemState.Completed) && !this.PropComp.IsLocked && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.静默"]);
		}

		// Token: 0x0603C877 RID: 247927 RVA: 0x01153A18 File Offset: 0x01151C18
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

		// Token: 0x0603C878 RID: 247928 RVA: 0x01153A7C File Offset: 0x01151C7C
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

		// Token: 0x0603C879 RID: 247929 RVA: 0x01153AF5 File Offset: 0x01151CF5
		private bool IsStateTickEnabled()
		{
			return this.TickDisableHandle == null;
		}

		// Token: 0x0603C87A RID: 247930 RVA: 0x01153B05 File Offset: 0x01151D05
		[NullableContext(1)]
		private void EnableStateTick(string reason)
		{
			if (!this.IsStateTickEnabled() && base.Enable(this.TickDisableHandle, reason))
			{
				this.TickDisableHandle = null;
			}
		}

		// Token: 0x0603C87B RID: 247931 RVA: 0x01153B2A File Offset: 0x01151D2A
		[NullableContext(1)]
		private void DisableStateTick(string reason)
		{
			if (this.IsStateTickEnabled())
			{
				this.TickDisableHandle = new int?(base.Disable(reason));
			}
		}

		// Token: 0x0603C87C RID: 247932 RVA: 0x01153B48 File Offset: 0x01151D48
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

		// Token: 0x0603C87D RID: 247933 RVA: 0x01153BD4 File Offset: 0x01151DD4
		private void OpenCountDownTip()
		{
			TrampleComponent compConfig = this.CompConfig;
			ITrampleTipType trampleTipType = (compConfig != null) ? compConfig.TrampleTipOption : null;
			if (trampleTipType == null)
			{
				return;
			}
			if (trampleTipType.Type != ETrampleTipType.CountDownTextTip)
			{
				return;
			}
			if (this.IsCountDownTipOpen)
			{
				return;
			}
			ICountDownTextTip countDownTextTip = trampleTipType as ICountDownTextTip;
			float remainSec = (this.AnimConfigMsTime - this.DownAnimPlayedMsTime) * 0.001f;
			UnOpenedAreaCountDownFloatTipsParam param = new UnOpenedAreaCountDownFloatTipsParam
			{
				TidCountDownTip = countDownTextTip.TidCountDownTip,
				RemainSec = remainSec
			};
			UiManager.Instance.OpenView(EUiViewName.UnOpenedAreaCountDownFloatTips, param, null);
			this.IsCountDownTipOpen = true;
		}

		// Token: 0x0603C87E RID: 247934 RVA: 0x01153C56 File Offset: 0x01151E56
		private void CloseCountDownTip()
		{
			if (!this.IsCountDownTipOpen)
			{
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.UnOpenedAreaCountDownFloatTips, null);
			this.IsCountDownTipOpen = false;
		}

		// Token: 0x0603C87F RID: 247935 RVA: 0x01153C78 File Offset: 0x01151E78
		private void UpdateCountDownTip()
		{
			if (!this.IsCountDownTipOpen)
			{
				return;
			}
			float p = (this.AnimConfigMsTime - this.DownAnimPlayedMsTime) * 0.001f;
			EventSystem.Instance.Emit<float>(EEventName.OnUnOpenedAreaCountDownUpdate, p);
		}

		// Token: 0x17007266 RID: 29286
		// (get) Token: 0x0603C880 RID: 247936 RVA: 0x01153CB3 File Offset: 0x01151EB3
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

		// Token: 0x17007267 RID: 29287
		// (get) Token: 0x0603C881 RID: 247937 RVA: 0x01153CC6 File Offset: 0x01151EC6
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

		// Token: 0x0603C882 RID: 247938 RVA: 0x01153CDC File Offset: 0x01151EDC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemGravityComponent sceneItemGravityComponent = (SceneItemGravityComponent)componentTemplate;
			if (sceneItemGravityComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemGravityComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemGravityComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (sceneItemGravityComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (sceneItemGravityComponent.PropComp == null)
			{
				this.PropComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PropComp), "PropComp"))
			{
				return false;
			}
			if (sceneItemGravityComponent.CompConfig == null)
			{
				this.CompConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CompConfig), "CompConfig"))
			{
				return false;
			}
			this.AnimState = sceneItemGravityComponent.AnimState;
			this.AnimConfigMsTime = sceneItemGravityComponent.AnimConfigMsTime;
			this.UpAnimConfigMsTime = sceneItemGravityComponent.UpAnimConfigMsTime;
			this.DownAnimPlayedMsTime = sceneItemGravityComponent.DownAnimPlayedMsTime;
			this.TickDisableHandle = sceneItemGravityComponent.TickDisableHandle;
			this.CustomTimeDilation = sceneItemGravityComponent.CustomTimeDilation;
			this.IsCountDownTipOpen = sceneItemGravityComponent.IsCountDownTipOpen;
			this.ShowLandTipRange = sceneItemGravityComponent.ShowLandTipRange;
			this.HideLandTipRange = sceneItemGravityComponent.HideLandTipRange;
			this.ShowingLandTip = sceneItemGravityComponent.ShowingLandTip;
			if (sceneItemGravityComponent.CheckDistanceTimerHandle == null)
			{
				this.CheckDistanceTimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CheckDistanceTimerHandle), "CheckDistanceTimerHandle"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007268 RID: 29288
		// (get) Token: 0x0603C883 RID: 247939 RVA: 0x01153EA1 File Offset: 0x011520A1
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007269 RID: 29289
		// (get) Token: 0x0603C884 RID: 247940 RVA: 0x01153EA4 File Offset: 0x011520A4
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700726A RID: 29290
		// (get) Token: 0x0603C885 RID: 247941 RVA: 0x01153EA7 File Offset: 0x011520A7
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700726B RID: 29291
		// (get) Token: 0x0603C886 RID: 247942 RVA: 0x01153EAA File Offset: 0x011520AA
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700726C RID: 29292
		// (get) Token: 0x0603C887 RID: 247943 RVA: 0x01153EAD File Offset: 0x011520AD
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020138 RID: 131384
		private const int CHECK_DISTANCE_INTERVAL = 100;

		// Token: 0x04020139 RID: 131385
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0402013A RID: 131386
		private SceneItemActorComponent ActorComp;

		// Token: 0x0402013B RID: 131387
		private LevelTagComponent TagComp;

		// Token: 0x0402013C RID: 131388
		private SceneItemStateComponent StateComp;

		// Token: 0x0402013D RID: 131389
		private SceneItemPropertyComponent PropComp;

		// Token: 0x0402013E RID: 131390
		private TrampleComponent CompConfig;

		// Token: 0x0402013F RID: 131391
		private SceneItemGravityComponent.ESceneItemGravityState AnimState;

		// Token: 0x04020140 RID: 131392
		private float AnimConfigMsTime;

		// Token: 0x04020141 RID: 131393
		private float UpAnimConfigMsTime;

		// Token: 0x04020142 RID: 131394
		private float DownAnimPlayedMsTime;

		// Token: 0x04020143 RID: 131395
		private int? TickDisableHandle;

		// Token: 0x04020144 RID: 131396
		private float CustomTimeDilation = 1f;

		// Token: 0x04020145 RID: 131397
		private bool IsCountDownTipOpen;

		// Token: 0x04020146 RID: 131398
		private float ShowLandTipRange = -1f;

		// Token: 0x04020147 RID: 131399
		private float HideLandTipRange = -1f;

		// Token: 0x04020148 RID: 131400
		private bool ShowingLandTip;

		// Token: 0x04020149 RID: 131401
		private TimerHandle CheckDistanceTimerHandle;

		// Token: 0x0200BA58 RID: 47704
		[NullableContext(0)]
		private enum ESceneItemGravityState
		{
			// Token: 0x04039691 RID: 235153
			AtTop,
			// Token: 0x04039692 RID: 235154
			AtBottom,
			// Token: 0x04039693 RID: 235155
			Rising,
			// Token: 0x04039694 RID: 235156
			Falling
		}
	}
}
