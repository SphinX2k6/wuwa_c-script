using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006036 RID: 24630
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SpringManorController : ActivityControllerBase
	{
		// Token: 0x0603E546 RID: 255302 RVA: 0x00F0D4E5 File Offset: 0x00F0B6E5
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603E547 RID: 255303 RVA: 0x00F0D4E7 File Offset: 0x00F0B6E7
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_Spring26ActivityEntry";
		}

		// Token: 0x0603E548 RID: 255304 RVA: 0x00F0D4EE File Offset: 0x00F0B6EE
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new SpringManorSubView();
		}

		// Token: 0x0603E549 RID: 255305 RVA: 0x00F0D4F5 File Offset: 0x00F0B6F5
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new SpringManorData();
		}

		// Token: 0x0603E54A RID: 255306 RVA: 0x00F0D4FC File Offset: 0x00F0B6FC
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603E54B RID: 255307 RVA: 0x00F0D500 File Offset: 0x00F0B700
		public void RequestExhibitionSave(List<EntityItemBundleInfo> bundleInfos)
		{
			ExhibitionItemSaveRequest exhibitionItemSaveRequest = ExhibitionItemSaveRequest.Create();
			exhibitionItemSaveRequest.EntityItemBundleInfos.AddRange(bundleInfos);
			Net.Instance.Call(ERequestMessageId.ExhibitionItemSaveRequest, exhibitionItemSaveRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ExhibitionItemSaveResponse exhibitionItemSaveResponse = (ExhibitionItemSaveResponse)msg;
				if (exhibitionItemSaveResponse == null)
				{
					return;
				}
				if (exhibitionItemSaveResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(exhibitionItemSaveResponse.ErrCode, EResponseMessageId.ExhibitionItemSaveResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603E54C RID: 255308 RVA: 0x00F0D550 File Offset: 0x00F0B750
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SpringFestivalUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSpringFestivalUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SpringFestivalAtmosphereUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAtmosphereUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.BookItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBookItemUpdateNotify));
		}

		// Token: 0x0603E54D RID: 255309 RVA: 0x00F0D5B1 File Offset: 0x00F0B7B1
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SpringFestivalUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SpringFestivalAtmosphereUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BookItemUpdateNotify);
		}

		// Token: 0x0603E54E RID: 255310 RVA: 0x00F0D5E4 File Offset: 0x00F0B7E4
		[NullableContext(2)]
		private void OnAtmosphereUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SpringFestivalAtmosphereUpdateNotify springFestivalAtmosphereUpdateNotify = (SpringFestivalAtmosphereUpdateNotify)msg;
			SpringManorModel instance = SpringManorModel.Instance;
			SpringManorData activityData = instance.ActivityData;
			int atmosphere = activityData.GetAtmosphere();
			int atmosphere2 = springFestivalAtmosphereUpdateNotify.Atmosphere;
			int atmosphereLevel = activityData.GetAtmosphereLevel();
			int atmosphereLevel2 = springFestivalAtmosphereUpdateNotify.AtmosphereLevel;
			int id = instance.IsMaxLevel(atmosphereLevel2) ? atmosphereLevel2 : (atmosphereLevel2 + 1);
			int atmosphereNeed = SpringManorConfig.Instance.GetLevelConfigById(id).Value.AtmosphereNeed;
			bool flag = instance.CheckInInstance();
			if (atmosphere < atmosphere2 && flag)
			{
				SpringManorAtmosphereLevelUpViewData param = new SpringManorAtmosphereLevelUpViewData
				{
					OldLevel = atmosphereLevel,
					NewLevel = atmosphereLevel2,
					OldAtmosphere = atmosphere,
					NewAtmosphere = atmosphere2,
					MaxAtmosphere = atmosphereNeed
				};
				UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelUpView, param, null);
				bool flag2 = SpringManorConfig.Instance.GetLevelConfigById(atmosphereLevel2).Value.UnlockFunctionLength > 0;
				if (atmosphereLevel2 > atmosphereLevel && flag2)
				{
					UiManager.Instance.OpenView(EUiViewName.SpringManorUnlockView, null, null);
				}
				int atmosphereLevelStage = instance.GetAtmosphereLevelStage(atmosphereLevel);
				int atmosphereLevelStage2 = instance.GetAtmosphereLevelStage(atmosphereLevel2);
				if (atmosphereLevelStage2 > atmosphereLevelStage)
				{
					AtmosphereStageUpParam atmosphereStageUpParam = new AtmosphereStageUpParam
					{
						OldAtmosphere = atmosphere,
						NewAtmosphere = atmosphere2,
						OldLevel = atmosphereLevel,
						NewLevel = atmosphereLevel2,
						Stage = atmosphereLevelStage2
					};
					instance.SetAtmosphereStageUpParam(atmosphereStageUpParam);
				}
			}
			SpringManorModel instance2 = SpringManorModel.Instance;
			if (instance2 != null)
			{
				instance2.ActivityData.OnAtmosphereUpdateNotify(atmosphere2, atmosphereLevel2);
			}
			EventSystem.Instance.Emit(EEventName.SpringManorAtmosphereUpdate);
		}

		// Token: 0x0603E54F RID: 255311 RVA: 0x00F0D760 File Offset: 0x00F0B960
		[NullableContext(2)]
		private void OnSpringFestivalUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SpringFestivalUpdateNotify springFestivalUpdateNotify = (SpringFestivalUpdateNotify)msg;
			if (springFestivalUpdateNotify.FunctionId != 0)
			{
				this.OnFunctionOpenNotify(springFestivalUpdateNotify.FunctionId);
				return;
			}
			if (springFestivalUpdateNotify.Task != null)
			{
				this.OnTaskUpdateNotify(springFestivalUpdateNotify.Task);
				return;
			}
			if (springFestivalUpdateNotify.SkipEntry != null)
			{
				this.OnSkipEntryUpdateNotify(springFestivalUpdateNotify.SkipEntry);
				return;
			}
			if (springFestivalUpdateNotify.JokerLevelInfos != null)
			{
				this.OnJokerLevelUpdateNotify(springFestivalUpdateNotify.JokerLevelInfos);
			}
		}

		// Token: 0x0603E550 RID: 255312 RVA: 0x00F0D7C7 File Offset: 0x00F0B9C7
		private void OnSkipEntryUpdateNotify(SpringSkipEntry skipEntry)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ActivityData.OnSkipEntryUpdateNotify(skipEntry);
		}

		// Token: 0x0603E551 RID: 255313 RVA: 0x00F0D7DE File Offset: 0x00F0B9DE
		private void OnJokerLevelUpdateNotify(GuessJokerLevelInfoArray jokerLevelInfos)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ActivityData.UpdateGuessJokerGameData(jokerLevelInfos.GuessJokerLevelInfos);
		}

		// Token: 0x0603E552 RID: 255314 RVA: 0x00F0D7FC File Offset: 0x00F0B9FC
		private void OnFunctionOpenNotify(int functionId)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance != null)
			{
				instance.ActivityData.OnFunctionUpdateNotify(functionId);
			}
			EventSystem.Instance.Emit(EEventName.SpringManorFunctionOpenNotify);
			if (SpringManorDefine.furnitureFunctionTypeList.Contains((ESpringFunctionType)functionId))
			{
				EventSystem.Instance.Emit<int>(EEventName.FurnitureFunctionOpenNotify, functionId);
			}
		}

		// Token: 0x0603E553 RID: 255315 RVA: 0x00F0D84D File Offset: 0x00F0BA4D
		private void OnTaskUpdateNotify(ConditionTask task)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance != null)
			{
				instance.ActivityData.OnTaskUpdateNotify(task);
			}
			this.UpdateRewardTrack();
			EventSystem.Instance.Emit(EEventName.SpringManorTaskUpdateNotify);
		}

		// Token: 0x0603E554 RID: 255316 RVA: 0x00F0D87C File Offset: 0x00F0BA7C
		[NullableContext(2)]
		public void RequestTaskRewardReceive(int tabId, Action finishCallback = null)
		{
			SpringFestivalTaskRewardRequest springFestivalTaskRewardRequest = SpringFestivalTaskRewardRequest.Create();
			springFestivalTaskRewardRequest.ActivityId = SpringManorModel.Instance.ActivityData.Id;
			List<int> canClaimedTaskIdList = SpringManorModel.Instance.ActivityData.GetTabCanClaimableTaskId(tabId);
			springFestivalTaskRewardRequest.TaskIds.AddRange(canClaimedTaskIdList);
			Net.Instance.Call(ERequestMessageId.SpringFestivalTaskRewardRequest, springFestivalTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SpringFestivalTaskRewardResponse springFestivalTaskRewardResponse = (SpringFestivalTaskRewardResponse)msg;
				if (springFestivalTaskRewardResponse == null)
				{
					return;
				}
				if (springFestivalTaskRewardResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(springFestivalTaskRewardResponse.ErrCode, EResponseMessageId.SpringFestivalTaskRewardResponse, null, true, true);
					return;
				}
				SpringManorModel instance = SpringManorModel.Instance;
				if (instance != null)
				{
					instance.ActivityData.OnRewardTaskClaimed(canClaimedTaskIdList);
				}
				Action finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			}, 0);
		}

		// Token: 0x0603E555 RID: 255317 RVA: 0x00F0D8F8 File Offset: 0x00F0BAF8
		[NullableContext(2)]
		public void RequestScoreRewardReceive(Action finishCallback = null)
		{
			SpringFestivalScoreRewardRequest springFestivalScoreRewardRequest = SpringFestivalScoreRewardRequest.Create();
			springFestivalScoreRewardRequest.ActivityId = SpringManorModel.Instance.ActivityData.Id;
			List<int> canClaimedScoreIdList = SpringManorModel.Instance.ActivityData.GetCanClaimedScoreRewardList();
			springFestivalScoreRewardRequest.ScoreIds.AddRange(canClaimedScoreIdList);
			Net.Instance.Call(ERequestMessageId.SpringFestivalScoreRewardRequest, springFestivalScoreRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SpringFestivalScoreRewardResponse springFestivalScoreRewardResponse = (SpringFestivalScoreRewardResponse)msg;
				if (springFestivalScoreRewardResponse == null)
				{
					return;
				}
				if (springFestivalScoreRewardResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(springFestivalScoreRewardResponse.ErrCode, EResponseMessageId.SpringFestivalScoreRewardResponse, null, true, true);
					return;
				}
				SpringManorModel instance = SpringManorModel.Instance;
				if (instance != null)
				{
					instance.ActivityData.OnScoreRewardClaimed(canClaimedScoreIdList);
				}
				Action finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			}, 0);
		}

		// Token: 0x0603E556 RID: 255318 RVA: 0x00F0D970 File Offset: 0x00F0BB70
		[NullableContext(2)]
		public void RequestAtmosphereRewardReceive(Action finishCallback = null)
		{
			SpringFestivalAtmosphereRewardRequest springFestivalAtmosphereRewardRequest = SpringFestivalAtmosphereRewardRequest.Create();
			springFestivalAtmosphereRewardRequest.ActivityId = SpringManorModel.Instance.ActivityData.Id;
			List<int> levelIdList = SpringManorModel.Instance.GetCanClaimedLevelIdList();
			springFestivalAtmosphereRewardRequest.LevelIds.AddRange(levelIdList);
			Net.Instance.Call(ERequestMessageId.SpringFestivalAtmosphereRewardRequest, springFestivalAtmosphereRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SpringFestivalAtmosphereRewardResponse springFestivalAtmosphereRewardResponse = (SpringFestivalAtmosphereRewardResponse)msg;
				if (springFestivalAtmosphereRewardResponse == null)
				{
					return;
				}
				if (springFestivalAtmosphereRewardResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(springFestivalAtmosphereRewardResponse.ErrCode, EResponseMessageId.SpringFestivalAtmosphereRewardResponse, null, true, true);
					return;
				}
				SpringManorModel instance = SpringManorModel.Instance;
				if (instance != null)
				{
					instance.ActivityData.OnAtmosphereLevelRewardUpdateNotify(levelIdList);
				}
				Action finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			}, 0);
		}

		// Token: 0x0603E557 RID: 255319 RVA: 0x00F0D9E3 File Offset: 0x00F0BBE3
		public void RequestTrackQuest(int questId, bool isTrack)
		{
			if (SpringManorModel.Instance.IsMainQuest(questId))
			{
				QuestNewController.Instance.RequestTrackQuest(questId, isTrack, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
				return;
			}
			if (isTrack)
			{
				this.TrackSubQuest(questId);
				return;
			}
			this.StopTrackSubQuest(questId);
		}

		// Token: 0x0603E558 RID: 255320 RVA: 0x00F0DA15 File Offset: 0x00F0BC15
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603E559 RID: 255321 RVA: 0x00F0DA4F File Offset: 0x00F0BC4F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603E55A RID: 255322 RVA: 0x00F0DA89 File Offset: 0x00F0BC89
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorActivityOpenView, null, null);
		}

		// Token: 0x0603E55B RID: 255323 RVA: 0x00F0DA9C File Offset: 0x00F0BC9C
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			if (state != QuestState.Finish && state != QuestState.Delete)
			{
				return;
			}
			this.StopTrackSubQuest(questId);
		}

		// Token: 0x0603E55C RID: 255324 RVA: 0x00F0DAAE File Offset: 0x00F0BCAE
		private void OnWorldDone()
		{
			if (SpringManorModel.Instance.CheckInInstance())
			{
				this.SetLimitTag(true);
			}
		}

		// Token: 0x0603E55D RID: 255325 RVA: 0x00F0DAC3 File Offset: 0x00F0BCC3
		public void LeaveInstanceDungeonRequest()
		{
			this.SetLimitTag(false);
			this.ClearCustomTrack();
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x0603E55E RID: 255326 RVA: 0x00F0DAE0 File Offset: 0x00F0BCE0
		private void SetLimitTag(bool enable)
		{
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止"], enable);
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止"], enable);
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止上墙"], enable);
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用探索工具轮盘"], enable);
		}

		// Token: 0x0603E55F RID: 255327 RVA: 0x00F0DB48 File Offset: 0x00F0BD48
		private unsafe void SetPlayerTag(int tagId, bool enable)
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.LJ;
				string message = "找不到当前玩家";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", playerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagName", GameplayTagUtils.GetNameByTagId(tagId));
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (enable)
			{
				if (!FormationDataController.Instance.HasPlayerTag(playerId, tagId, true))
				{
					FormationDataController.Instance.AddPlayerTag(playerId, new int?(tagId));
					return;
				}
			}
			else if (FormationDataController.Instance.HasPlayerTag(playerId, tagId, true))
			{
				FormationDataController.Instance.RemovePlayerTag(playerId, new int?(tagId));
			}
		}

		// Token: 0x0603E560 RID: 255328 RVA: 0x00F0DC10 File Offset: 0x00F0BE10
		public void EnterBigWorldInstRequestAndUnTrackQuest()
		{
			global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
			if (curTrackedQuest != null && !SpringManorModel.Instance.IsMainQuest(curTrackedQuest.Id))
			{
				QuestNewController.Instance.RequestTrackQuest(curTrackedQuest.Id, false, ERequestTrackOperate.Auto, ESetTrackReason.None, new Action(this.EnterBigWorldInstRequest));
				return;
			}
			this.EnterBigWorldInstRequest();
		}

		// Token: 0x0603E561 RID: 255329 RVA: 0x00F0DC64 File Offset: 0x00F0BE64
		public void EnterBigWorldInstRequest()
		{
			EnterBigWorldInstRequest enterBigWorldInstRequest = Aki.Protocol.EnterBigWorldInstRequest.Create();
			EnterBigWorldInstContext enterBigWorldInstContext = EnterBigWorldInstContext.Create();
			enterBigWorldInstContext.SpringFestivalCtx = SpringFestivalCtx.Create();
			enterBigWorldInstContext.SpringFestivalCtx.ActivityId = SpringManorModel.Instance.ActivityData.Id;
			enterBigWorldInstRequest.EnterBigWorldInstContext = enterBigWorldInstContext;
			Net.Instance.Call(ERequestMessageId.EnterBigWorldInstRequest, enterBigWorldInstRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EnterBigWorldInstResponse enterBigWorldInstResponse = (EnterBigWorldInstResponse)msg;
				if (enterBigWorldInstResponse == null)
				{
					return;
				}
				if (enterBigWorldInstResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(enterBigWorldInstResponse.ErrorCode, EResponseMessageId.EnterBigWorldInstResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603E562 RID: 255330 RVA: 0x00F0DCDC File Offset: 0x00F0BEDC
		public void SpringManorInputHandler(string actionName)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			SpringManorData springManorData = (instance != null) ? instance.ActivityData : null;
			if (springManorData == null)
			{
				return;
			}
			if (!(actionName == "切换角色1"))
			{
				if (!(actionName == "切换角色2"))
				{
					if (!(actionName == "切换角色3"))
					{
						return;
					}
					UiManager.Instance.OpenView(EUiViewName.SpringManorRewardView, null, null);
					return;
				}
				else
				{
					if (!springManorData.IsFunctionUnlocked(ESpringFunctionType.DIY))
					{
						return;
					}
					FurnitureController.Instance.OpenFurnitureAreaSelectView();
					return;
				}
			}
			else
			{
				if (!springManorData.IsFunctionUnlocked(ESpringFunctionType.Gameplay))
				{
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.SpringManorGameplayEntryView, null, null);
				return;
			}
		}

		// Token: 0x0603E563 RID: 255331 RVA: 0x00F0DD6C File Offset: 0x00F0BF6C
		[NullableContext(2)]
		private void OnBookItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			BookItemUpdateNotify bookItemUpdateNotify = (BookItemUpdateNotify)msg;
			if (bookItemUpdateNotify == null)
			{
				return;
			}
			SpringManorData activityData = SpringManorModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			int num = 0;
			foreach (BookItemInfo bookItemInfo in bookItemUpdateNotify.BookItems)
			{
				int bookItemId = bookItemInfo.BookItemId;
				EBrochureState bookItemStateById = activityData.GetBookItemStateById(bookItemId);
				if (activityData != null)
				{
					activityData.SetBookItemDataById(bookItemId, bookItemInfo);
				}
				if (bookItemStateById == EBrochureState.Lock && bookItemInfo.BookItemState == BookItemState.BookItemUnlock)
				{
					num = bookItemId;
				}
			}
			if (num > 0)
			{
				this.OpenPropView(bookItemUpdateNotify.ActivityId, bookItemUpdateNotify.BrochureId, num);
			}
			EventSystem.Instance.Emit(EEventName.OnBrochureBookItemStateUpdate);
		}

		// Token: 0x0603E564 RID: 255332 RVA: 0x00F0DE28 File Offset: 0x00F0C028
		private void OpenPropView(int activityId, int brochureId, int configId)
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureById(brochureId) : null;
			if (brochure == null)
			{
				return;
			}
			if (!this.IsUnlockBrochureType((EBrochureType)brochure.Value.Type))
			{
				return;
			}
			EBrochureType type = (EBrochureType)brochure.Value.Type;
			if (type > EBrochureType.EasterEggBook)
			{
				if (type != EBrochureType.Brochure)
				{
					return;
				}
				if (UiManager.Instance.IsViewOpen(EUiViewName.SpringManorBrochureCompletedView))
				{
					return;
				}
				SpringManorBrochureCompletedViewOpenParam param = new SpringManorBrochureCompletedViewOpenParam
				{
					ConfigId = configId
				};
				UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureCompletedView, param, null);
				return;
			}
			else
			{
				if (UiManager.Instance.IsViewOpen(EUiViewName.SpringManorAlbumPropView))
				{
					return;
				}
				this.LatestUnlockBookItemId = configId;
				this.LatestUnlockBrochureId = brochureId;
				SpringManorAlbumPropViewOpenParam param2 = new SpringManorAlbumPropViewOpenParam
				{
					ActivityId = activityId,
					ConfigId = configId,
					BrochureId = brochureId
				};
				UiManager.Instance.OpenView(EUiViewName.SpringManorAlbumPropView, param2, null);
				return;
			}
		}

		// Token: 0x0603E565 RID: 255333 RVA: 0x00F0DF0C File Offset: 0x00F0C10C
		private bool IsUnlockBrochureType(EBrochureType type)
		{
			if (type > EBrochureType.EasterEggBook)
			{
				return type == EBrochureType.Brochure && SpringManorModel.Instance.ActivityData.IsFunctionUnlocked(ESpringFunctionType.Publicity);
			}
			return SpringManorModel.Instance.ActivityData.IsFunctionUnlocked(ESpringFunctionType.Draw);
		}

		// Token: 0x0603E566 RID: 255334 RVA: 0x00F0DF3C File Offset: 0x00F0C13C
		public void RequestBrochureReward(int activityId, EBrochureType brochureType, int bookItemId, bool isAllReward = false)
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureByActivityAndType(activityId, brochureType) : null;
			if (brochure == null)
			{
				return;
			}
			SpringManorData activityData = SpringManorModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			BrochureRewardRequest brochureRewardRequest = BrochureRewardRequest.Create();
			brochureRewardRequest.ActivityId = activityId;
			brochureRewardRequest.BrochureId = brochure.Value.Id;
			List<int> bookItemIds = new List<int>();
			if (isAllReward)
			{
				for (int i = 0; i < brochure.Value.BookItemIdsLength; i++)
				{
					int num = brochure.Value.BookItemIds(i);
					SpringManorData activityData3 = activityData;
					BookItemInfo bookItemInfo = (activityData3 != null) ? activityData3.GetBookItemDataById(num) : null;
					if (bookItemInfo != null && bookItemInfo.BookItemState == BookItemState.BookItemUnlock)
					{
						bookItemIds.Add(num);
					}
				}
			}
			else
			{
				bookItemIds.Add(bookItemId);
			}
			brochureRewardRequest.BookItems.AddRange(bookItemIds);
			Net.Instance.Call(ERequestMessageId.BrochureRewardRequest, brochureRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				BrochureRewardResponse brochureRewardResponse = (BrochureRewardResponse)msg;
				if (brochureRewardResponse != null)
				{
					if (brochureRewardResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
					{
						foreach (int num2 in bookItemIds)
						{
							SpringManorData activityData2 = activityData;
							if (activityData2 != null)
							{
								activityData2.SetTargetBookItemState(num2, BookItemState.BookItemRewarded);
							}
							if (SpringManorController.Instance.LatestUnlockBookItemId == num2)
							{
								SpringManorController.Instance.LatestUnlockBookItemId = 0;
								SpringManorController.Instance.LatestUnlockBrochureId = 0;
							}
						}
						EventSystem.Instance.Emit(EEventName.OnBrochureBookItemStateUpdate);
						return;
					}
					ErrorCodeController.Instance.OpenErrorCodeTipView(brochureRewardResponse.ErrCode, EResponseMessageId.ArtemisNodeUpdateResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603E567 RID: 255335 RVA: 0x00F0E060 File Offset: 0x00F0C260
		public void ClearCustomTrack()
		{
			this.StopTrackRewardTask();
			this.StopTrackSkipEntry();
			this.StopCurrentTrackSubQuest();
			if (this.TrackCheckTimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TrackCheckTimerHandle);
			}
		}

		// Token: 0x0603E568 RID: 255336 RVA: 0x00F0E090 File Offset: 0x00F0C290
		public void TryStartTrackCheckTimer()
		{
			if (this.TrackCheckTimerHandle != null)
			{
				return;
			}
			SpringManorModel model = SpringManorModel.Instance;
			if (!model.HasAnyCanAutoEndTrack())
			{
				return;
			}
			this.TrackCheckTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				if (!model.HasAnyCanAutoEndTrack())
				{
					if (this.TrackCheckTimerHandle != null)
					{
						TimerSystem.GameplayTimeInstance.Remove(this.TrackCheckTimerHandle);
					}
					this.TrackCheckTimerHandle = null;
					return;
				}
				global::Vector currentTrackRewardPosition = model.GetCurrentTrackRewardPosition();
				if (currentTrackRewardPosition != null && model.CheckPositionIsInAutoEndRange(currentTrackRewardPosition))
				{
					this.StopTrackRewardTask();
				}
				global::Vector currentTrackGetWayPosition = model.GetCurrentTrackGetWayPosition();
				if (currentTrackGetWayPosition != null && model.CheckPositionIsInAutoEndRange(currentTrackGetWayPosition))
				{
					this.StopTrackSkipEntry();
				}
			}, 500f, 1f, null, null, true);
		}

		// Token: 0x0603E569 RID: 255337 RVA: 0x00F0E0F8 File Offset: 0x00F0C2F8
		[NullableContext(2)]
		public void ExecuteSkipEntry(int skipEntryId, Action onTrackPositionCallback = null)
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			SpringFestivalSkipEntry? springFestivalSkipEntry = (instance != null) ? instance.GetSkipEntryConfigById(skipEntryId) : null;
			if (springFestivalSkipEntry == null)
			{
				return;
			}
			if (springFestivalSkipEntry.Value.JumpId > 0)
			{
				SkipTaskManager.RunByConfigId(springFestivalSkipEntry.Value.JumpId, null);
				return;
			}
			if (!springFestivalSkipEntry.Value.IsTeleport)
			{
				SpringManorController instance2 = SpringManorController.Instance;
				if (instance2 != null)
				{
					instance2.TrackSkipEntry(skipEntryId);
				}
				if (onTrackPositionCallback != null)
				{
					onTrackPositionCallback();
				}
				return;
			}
			global::Vector vector = global::Vector.Create((double)springFestivalSkipEntry.Value.TrackPosition(0), (double)springFestivalSkipEntry.Value.TrackPosition(1), (double)springFestivalSkipEntry.Value.TrackPosition(2));
			global::Rotator rotator = global::Rotator.Create((float)springFestivalSkipEntry.Value.TrackPosition(3), (float)springFestivalSkipEntry.Value.TrackPosition(4), (float)springFestivalSkipEntry.Value.TrackPosition(5));
			TeleportController.Instance.TeleportPlayer(new ITeleportContextParam
			{
				ClientReason = "SpringManorSkipEntry",
				TargetPosition = vector.ToUeVector(false),
				TargetRotation = rotator.ToUeRotator(),
				TeleportMode = new ETeleportMode?(ETeleportMode.NoLoading)
			});
			if (onTrackPositionCallback != null)
			{
				onTrackPositionCallback();
			}
		}

		// Token: 0x0603E56A RID: 255338 RVA: 0x00F0E248 File Offset: 0x00F0C448
		public void TrackSkipEntry(int skipEntryId)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int currentTrackGetWayId = instance.GetCurrentTrackGetWayId();
			if (currentTrackGetWayId == skipEntryId)
			{
				return;
			}
			SpringFestivalSkipEntry? skipEntryConfigById = SpringManorConfig.Instance.GetSkipEntryConfigById(skipEntryId);
			if (skipEntryConfigById == null || skipEntryConfigById.Value.TrackPositionLength < 3)
			{
				return;
			}
			if (currentTrackGetWayId > 0)
			{
				this.StopTrackSkipEntry();
			}
			global::Vector vector = global::Vector.Create((double)skipEntryConfigById.Value.TrackPosition(0), (double)skipEntryConfigById.Value.TrackPosition(1), (double)skipEntryConfigById.Value.TrackPosition(2));
			TrackController.Instance.StartTrack(new TrackData
			{
				TrackSource = ETrackSource.None,
				Id = skipEntryId,
				TrackTarget = vector,
				IconPath = skipEntryConfigById.Value.TrackIconPath
			}, true);
			instance.SetCurrentTrackGetWayId(skipEntryId, vector);
			this.TryStartTrackCheckTimer();
		}

		// Token: 0x0603E56B RID: 255339 RVA: 0x00F0E328 File Offset: 0x00F0C528
		public void StopTrackSkipEntry()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int currentTrackGetWayId = instance.GetCurrentTrackGetWayId();
			if (currentTrackGetWayId == 0)
			{
				return;
			}
			instance.ClearCurrentTrackGetWayId();
			TrackController.Instance.EndTrack(ETrackSource.None, currentTrackGetWayId);
		}

		// Token: 0x0603E56C RID: 255340 RVA: 0x00F0E35C File Offset: 0x00F0C55C
		public void TrackRewardTask(int rewardTaskId)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int currentTrackRewardId = instance.GetCurrentTrackRewardId();
			if (currentTrackRewardId == rewardTaskId)
			{
				return;
			}
			SpringFestivalReward? rewardTaskConfigById = SpringManorConfig.Instance.GetRewardTaskConfigById(rewardTaskId);
			if (rewardTaskConfigById == null || rewardTaskConfigById.Value.SkipType != 2)
			{
				return;
			}
			if (currentTrackRewardId > 0)
			{
				this.StopTrackRewardTask();
			}
			global::Vector vector = global::Vector.Create((double)float.Parse(rewardTaskConfigById.Value.SkipParam(0)), (double)float.Parse(rewardTaskConfigById.Value.SkipParam(1)), (double)float.Parse(rewardTaskConfigById.Value.SkipParam(2)));
			SpringFestival activityConfig = instance.GetActivityConfig();
			TrackController.Instance.StartTrack(new TrackData
			{
				TrackSource = ETrackSource.None,
				Id = rewardTaskId,
				TrackTarget = vector,
				IconPath = activityConfig.TrackRewardIconPath
			}, true);
			instance.SetCurrentTrackRewardId(rewardTaskId, vector);
			this.TryStartTrackCheckTimer();
		}

		// Token: 0x0603E56D RID: 255341 RVA: 0x00F0E448 File Offset: 0x00F0C648
		public void StopTrackRewardTask()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int currentTrackRewardId = instance.GetCurrentTrackRewardId();
			if (currentTrackRewardId == 0)
			{
				return;
			}
			instance.ClearCurrentTrackRewardId();
			TrackController.Instance.EndTrack(ETrackSource.None, currentTrackRewardId);
		}

		// Token: 0x0603E56E RID: 255342 RVA: 0x00F0E47C File Offset: 0x00F0C67C
		public void UpdateRewardTrack()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int currentTrackRewardId = instance.GetCurrentTrackRewardId();
			if (currentTrackRewardId <= 0)
			{
				return;
			}
			SpringManorData activityData = instance.ActivityData;
			EActivityTaskState? eactivityTaskState;
			if (activityData == null)
			{
				eactivityTaskState = null;
			}
			else
			{
				ActivitySpringManorTaskData rewardTaskData = activityData.GetRewardTaskData(currentTrackRewardId);
				eactivityTaskState = ((rewardTaskData != null) ? new EActivityTaskState?(rewardTaskData.Status) : null);
			}
			EActivityTaskState? eactivityTaskState2 = eactivityTaskState;
			if (eactivityTaskState2.GetValueOrDefault() != EActivityTaskState.Active)
			{
				this.StopTrackRewardTask();
			}
		}

		// Token: 0x0603E56F RID: 255343 RVA: 0x00F0E4E0 File Offset: 0x00F0C6E0
		public void TrackSubQuest(int questId)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int trackingSubQuestId = instance.GetTrackingSubQuestId();
			if (trackingSubQuestId == questId)
			{
				return;
			}
			if (QuestNewModel.Instance.GetQuest(questId) == null)
			{
				return;
			}
			if (instance.CheckTrackingSubQuest())
			{
				this.StopTrackSubQuest(trackingSubQuestId);
			}
			this.StartShowTrackText(questId);
			this.StartShowSubQuestTrackIcon(questId);
			instance.SetTrackingSubQuestId(questId);
		}

		// Token: 0x0603E570 RID: 255344 RVA: 0x00F0E534 File Offset: 0x00F0C734
		public void StopCurrentTrackSubQuest()
		{
			int trackingSubQuestId = SpringManorModel.Instance.GetTrackingSubQuestId();
			this.StopTrackSubQuest(trackingSubQuestId);
		}

		// Token: 0x0603E571 RID: 255345 RVA: 0x00F0E554 File Offset: 0x00F0C754
		public void StopTrackSubQuest(int questId)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (!instance.IsTrackingSubQuest(questId))
			{
				return;
			}
			this.EndShowSubQuestTrackIcon();
			this.EndShowTrackText();
			instance.ClearTrackingSubQuest();
		}

		// Token: 0x0603E572 RID: 255346 RVA: 0x00F0E584 File Offset: 0x00F0C784
		private void StartShowSubQuestTrackIcon(int questId)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance.CheckTrackingSubQuest())
			{
				this.EndShowSubQuestTrackIcon();
			}
			global::Vector questTrackPosition = instance.GetQuestTrackPosition(questId);
			global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
			string questTypeMark = QuestNewConfig.Instance.GetQuestTypeMark(quest.QuestMarkId);
			TrackController.Instance.StartTrack(new TrackData
			{
				TrackSource = ETrackSource.Quest,
				Id = questId,
				TrackTarget = questTrackPosition,
				IconPath = questTypeMark
			}, true);
		}

		// Token: 0x0603E573 RID: 255347 RVA: 0x00F0E5FC File Offset: 0x00F0C7FC
		private void EndShowSubQuestTrackIcon()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (!instance.CheckTrackingSubQuest())
			{
				return;
			}
			TrackController.Instance.EndTrack(ETrackSource.Quest, instance.GetTrackingSubQuestId());
		}

		// Token: 0x0603E574 RID: 255348 RVA: 0x00F0E62C File Offset: 0x00F0C82C
		private void StartShowTrackText(int questId)
		{
			global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
			if (quest == null || !quest.HasBehaviorTree())
			{
				return;
			}
			BaseBehaviorTree tree = quest.Tree;
			BehaviorTreeViewShowData behaviorTreeViewShowData;
			if (tree == null)
			{
				behaviorTreeViewShowData = null;
			}
			else
			{
				Blackboard blackBoard = tree.GetBlackBoard();
				behaviorTreeViewShowData = ((blackBoard != null) ? blackBoard.CreateShowData(false) : null);
			}
			BehaviorTreeViewShowData behaviorTreeViewShowData2 = behaviorTreeViewShowData;
			if (behaviorTreeViewShowData2 == null)
			{
				return;
			}
			EventSystem.Instance.Emit<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeStartShowTrackText, behaviorTreeViewShowData2, ETreeTextExpressReason.None, false);
		}

		// Token: 0x0603E575 RID: 255349 RVA: 0x00F0E688 File Offset: 0x00F0C888
		private void EndShowTrackText()
		{
			int trackingSubQuestId = SpringManorModel.Instance.GetTrackingSubQuestId();
			global::Quest quest = QuestNewModel.Instance.GetQuest(trackingSubQuestId);
			if (quest == null || !quest.HasBehaviorTree())
			{
				return;
			}
			EventSystem.Instance.Emit<long, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeEndShowTrackText, quest.TreeId.Value, ETreeTextExpressReason.None, false);
		}

		// Token: 0x0603E576 RID: 255350 RVA: 0x00F0E6D8 File Offset: 0x00F0C8D8
		public UniTask ChangeRoleRequest(int targetRoleId)
		{
			SpringManorController.<ChangeRoleRequest>d__51 <ChangeRoleRequest>d__;
			<ChangeRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeRoleRequest>d__.targetRoleId = targetRoleId;
			<ChangeRoleRequest>d__.<>1__state = -1;
			<ChangeRoleRequest>d__.<>t__builder.Start<SpringManorController.<ChangeRoleRequest>d__51>(ref <ChangeRoleRequest>d__);
			return <ChangeRoleRequest>d__.<>t__builder.Task;
		}

		// Token: 0x1700906D RID: 36973
		// (get) Token: 0x0603E577 RID: 255351 RVA: 0x00F0E71B File Offset: 0x00F0C91B
		public static SpringManorController Instance
		{
			get
			{
				return SpringManorController._Instance;
			}
		}

		// Token: 0x0603E578 RID: 255352 RVA: 0x00F0E722 File Offset: 0x00F0C922
		public static SpringManorController GetOrCreateInstance()
		{
			if (SpringManorController._Instance == null)
			{
				SpringManorController.CreateInstance();
			}
			return SpringManorController._Instance;
		}

		// Token: 0x0603E579 RID: 255353 RVA: 0x00F0E736 File Offset: 0x00F0C936
		public static bool CreateInstance()
		{
			if (SpringManorController._Instance != null)
			{
				return true;
			}
			SpringManorController._Instance = new SpringManorController();
			return true;
		}

		// Token: 0x0603E57A RID: 255354 RVA: 0x00F0E74C File Offset: 0x00F0C94C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E57B RID: 255355 RVA: 0x00F0E74E File Offset: 0x00F0C94E
		public static void ResetStaticDefaultValue()
		{
			SpringManorController._Instance = null;
		}

		// Token: 0x0603E57C RID: 255356 RVA: 0x00F0E756 File Offset: 0x00F0C956
		static SpringManorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorController.CreateStaticDefaultValue), new Action(SpringManorController.ResetStaticDefaultValue));
		}

		// Token: 0x0402090C RID: 133388
		public int LatestUnlockBookItemId;

		// Token: 0x0402090D RID: 133389
		public int LatestUnlockBrochureId;

		// Token: 0x0402090E RID: 133390
		[Nullable(2)]
		private TimerHandle TrackCheckTimerHandle;

		// Token: 0x0402090F RID: 133391
		private const int AUTO_CHECK_TRACK_RANGE_INTERVAL = 500;

		// Token: 0x04020910 RID: 133392
		private const int VECTOR_DIMENSION = 3;

		// Token: 0x04020911 RID: 133393
		[Nullable(2)]
		private static SpringManorController _Instance;
	}
}
