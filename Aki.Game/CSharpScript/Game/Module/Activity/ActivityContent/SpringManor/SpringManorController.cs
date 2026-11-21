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
	// Token: 0x02004FB4 RID: 20404
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SpringManorController : ActivityControllerBase
	{
		// Token: 0x0603320A RID: 209418 RVA: 0x00E542A9 File Offset: 0x00E524A9
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603320B RID: 209419 RVA: 0x00E542AB File Offset: 0x00E524AB
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_Spring26ActivityEntry";
		}

		// Token: 0x0603320C RID: 209420 RVA: 0x00E542B2 File Offset: 0x00E524B2
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new SpringManorSubView();
		}

		// Token: 0x0603320D RID: 209421 RVA: 0x00E542B9 File Offset: 0x00E524B9
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new SpringManorData();
		}

		// Token: 0x0603320E RID: 209422 RVA: 0x00E542C0 File Offset: 0x00E524C0
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603320F RID: 209423 RVA: 0x00E542C4 File Offset: 0x00E524C4
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

		// Token: 0x06033210 RID: 209424 RVA: 0x00E54314 File Offset: 0x00E52514
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SpringFestivalUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSpringFestivalUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.SpringFestivalAtmosphereUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAtmosphereUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.BookItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBookItemUpdateNotify));
		}

		// Token: 0x06033211 RID: 209425 RVA: 0x00E54375 File Offset: 0x00E52575
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SpringFestivalUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SpringFestivalAtmosphereUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.BookItemUpdateNotify);
		}

		// Token: 0x06033212 RID: 209426 RVA: 0x00E543A8 File Offset: 0x00E525A8
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

		// Token: 0x06033213 RID: 209427 RVA: 0x00E54524 File Offset: 0x00E52724
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

		// Token: 0x06033214 RID: 209428 RVA: 0x00E5458B File Offset: 0x00E5278B
		private void OnSkipEntryUpdateNotify(SpringSkipEntry skipEntry)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ActivityData.OnSkipEntryUpdateNotify(skipEntry);
		}

		// Token: 0x06033215 RID: 209429 RVA: 0x00E545A2 File Offset: 0x00E527A2
		private void OnJokerLevelUpdateNotify(GuessJokerLevelInfoArray jokerLevelInfos)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ActivityData.UpdateGuessJokerGameData(jokerLevelInfos.GuessJokerLevelInfos);
		}

		// Token: 0x06033216 RID: 209430 RVA: 0x00E545C0 File Offset: 0x00E527C0
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

		// Token: 0x06033217 RID: 209431 RVA: 0x00E54611 File Offset: 0x00E52811
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

		// Token: 0x06033218 RID: 209432 RVA: 0x00E54640 File Offset: 0x00E52840
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

		// Token: 0x06033219 RID: 209433 RVA: 0x00E546BC File Offset: 0x00E528BC
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

		// Token: 0x0603321A RID: 209434 RVA: 0x00E54734 File Offset: 0x00E52934
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

		// Token: 0x0603321B RID: 209435 RVA: 0x00E547A7 File Offset: 0x00E529A7
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

		// Token: 0x0603321C RID: 209436 RVA: 0x00E547D9 File Offset: 0x00E529D9
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603321D RID: 209437 RVA: 0x00E54813 File Offset: 0x00E52A13
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603321E RID: 209438 RVA: 0x00E5484D File Offset: 0x00E52A4D
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorActivityOpenView, null, null);
		}

		// Token: 0x0603321F RID: 209439 RVA: 0x00E54860 File Offset: 0x00E52A60
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			if (state != QuestState.Finish && state != QuestState.Delete)
			{
				return;
			}
			this.StopTrackSubQuest(questId);
		}

		// Token: 0x06033220 RID: 209440 RVA: 0x00E54872 File Offset: 0x00E52A72
		private void OnWorldDone()
		{
			if (SpringManorModel.Instance.CheckInInstance())
			{
				this.SetLimitTag(true);
			}
		}

		// Token: 0x06033221 RID: 209441 RVA: 0x00E54887 File Offset: 0x00E52A87
		public void LeaveInstanceDungeonRequest()
		{
			this.SetLimitTag(false);
			this.ClearCustomTrack();
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x06033222 RID: 209442 RVA: 0x00E548A4 File Offset: 0x00E52AA4
		private void SetLimitTag(bool enable)
		{
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止"], enable);
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止"], enable);
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止上墙"], enable);
			this.SetPlayerTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用探索工具轮盘"], enable);
		}

		// Token: 0x06033223 RID: 209443 RVA: 0x00E5490C File Offset: 0x00E52B0C
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

		// Token: 0x06033224 RID: 209444 RVA: 0x00E549D4 File Offset: 0x00E52BD4
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

		// Token: 0x06033225 RID: 209445 RVA: 0x00E54A28 File Offset: 0x00E52C28
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

		// Token: 0x06033226 RID: 209446 RVA: 0x00E54AA0 File Offset: 0x00E52CA0
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

		// Token: 0x06033227 RID: 209447 RVA: 0x00E54B30 File Offset: 0x00E52D30
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

		// Token: 0x06033228 RID: 209448 RVA: 0x00E54BEC File Offset: 0x00E52DEC
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

		// Token: 0x06033229 RID: 209449 RVA: 0x00E54CD0 File Offset: 0x00E52ED0
		private bool IsUnlockBrochureType(EBrochureType type)
		{
			if (type > EBrochureType.EasterEggBook)
			{
				return type == EBrochureType.Brochure && SpringManorModel.Instance.ActivityData.IsFunctionUnlocked(ESpringFunctionType.Publicity);
			}
			return SpringManorModel.Instance.ActivityData.IsFunctionUnlocked(ESpringFunctionType.Draw);
		}

		// Token: 0x0603322A RID: 209450 RVA: 0x00E54D00 File Offset: 0x00E52F00
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

		// Token: 0x0603322B RID: 209451 RVA: 0x00E54E24 File Offset: 0x00E53024
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

		// Token: 0x0603322C RID: 209452 RVA: 0x00E54E54 File Offset: 0x00E53054
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

		// Token: 0x0603322D RID: 209453 RVA: 0x00E54EBC File Offset: 0x00E530BC
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

		// Token: 0x0603322E RID: 209454 RVA: 0x00E5500C File Offset: 0x00E5320C
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

		// Token: 0x0603322F RID: 209455 RVA: 0x00E550EC File Offset: 0x00E532EC
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

		// Token: 0x06033230 RID: 209456 RVA: 0x00E55120 File Offset: 0x00E53320
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

		// Token: 0x06033231 RID: 209457 RVA: 0x00E5520C File Offset: 0x00E5340C
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

		// Token: 0x06033232 RID: 209458 RVA: 0x00E55240 File Offset: 0x00E53440
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

		// Token: 0x06033233 RID: 209459 RVA: 0x00E552A4 File Offset: 0x00E534A4
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

		// Token: 0x06033234 RID: 209460 RVA: 0x00E552F8 File Offset: 0x00E534F8
		public void StopCurrentTrackSubQuest()
		{
			int trackingSubQuestId = SpringManorModel.Instance.GetTrackingSubQuestId();
			this.StopTrackSubQuest(trackingSubQuestId);
		}

		// Token: 0x06033235 RID: 209461 RVA: 0x00E55318 File Offset: 0x00E53518
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

		// Token: 0x06033236 RID: 209462 RVA: 0x00E55348 File Offset: 0x00E53548
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

		// Token: 0x06033237 RID: 209463 RVA: 0x00E553C0 File Offset: 0x00E535C0
		private void EndShowSubQuestTrackIcon()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (!instance.CheckTrackingSubQuest())
			{
				return;
			}
			TrackController.Instance.EndTrack(ETrackSource.Quest, instance.GetTrackingSubQuestId());
		}

		// Token: 0x06033238 RID: 209464 RVA: 0x00E553F0 File Offset: 0x00E535F0
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

		// Token: 0x06033239 RID: 209465 RVA: 0x00E5544C File Offset: 0x00E5364C
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

		// Token: 0x0603323A RID: 209466 RVA: 0x00E5549C File Offset: 0x00E5369C
		public UniTask ChangeRoleRequest(int targetRoleId)
		{
			SpringManorController.<ChangeRoleRequest>d__51 <ChangeRoleRequest>d__;
			<ChangeRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeRoleRequest>d__.targetRoleId = targetRoleId;
			<ChangeRoleRequest>d__.<>1__state = -1;
			<ChangeRoleRequest>d__.<>t__builder.Start<SpringManorController.<ChangeRoleRequest>d__51>(ref <ChangeRoleRequest>d__);
			return <ChangeRoleRequest>d__.<>t__builder.Task;
		}

		// Token: 0x170063CF RID: 25551
		// (get) Token: 0x0603323B RID: 209467 RVA: 0x00E554DF File Offset: 0x00E536DF
		public static SpringManorController Instance
		{
			get
			{
				return SpringManorController._Instance;
			}
		}

		// Token: 0x0603323C RID: 209468 RVA: 0x00E554E6 File Offset: 0x00E536E6
		public static SpringManorController GetOrCreateInstance()
		{
			if (SpringManorController._Instance == null)
			{
				SpringManorController.CreateInstance();
			}
			return SpringManorController._Instance;
		}

		// Token: 0x0603323D RID: 209469 RVA: 0x00E554FA File Offset: 0x00E536FA
		public static bool CreateInstance()
		{
			if (SpringManorController._Instance != null)
			{
				return true;
			}
			SpringManorController._Instance = new SpringManorController();
			return true;
		}

		// Token: 0x0603323E RID: 209470 RVA: 0x00E55510 File Offset: 0x00E53710
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603323F RID: 209471 RVA: 0x00E55512 File Offset: 0x00E53712
		public static void ResetStaticDefaultValue()
		{
			SpringManorController._Instance = null;
		}

		// Token: 0x06033240 RID: 209472 RVA: 0x00E5551A File Offset: 0x00E5371A
		static SpringManorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorController.CreateStaticDefaultValue), new Action(SpringManorController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B239 RID: 111161
		public int LatestUnlockBookItemId;

		// Token: 0x0401B23A RID: 111162
		public int LatestUnlockBrochureId;

		// Token: 0x0401B23B RID: 111163
		[Nullable(2)]
		private TimerHandle TrackCheckTimerHandle;

		// Token: 0x0401B23C RID: 111164
		private const int AUTO_CHECK_TRACK_RANGE_INTERVAL = 500;

		// Token: 0x0401B23D RID: 111165
		private const int VECTOR_DIMENSION = 3;

		// Token: 0x0401B23E RID: 111166
		[Nullable(2)]
		private static SpringManorController _Instance;
	}
}
