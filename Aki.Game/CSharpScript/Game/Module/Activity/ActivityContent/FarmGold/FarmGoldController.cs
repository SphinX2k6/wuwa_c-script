using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.View.InstanceEntrance;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FarmGold
{
	// Token: 0x020055C8 RID: 21960
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class FarmGoldController : ActivityControllerBase
	{
		// Token: 0x17006977 RID: 26999
		// (get) Token: 0x060366AE RID: 222894 RVA: 0x00F318A6 File Offset: 0x00F2FAA6
		public int InitLevelIndex
		{
			get
			{
				int initLevelIndexInternal = this.InitLevelIndexInternal;
				this.InitLevelIndexInternal = 0;
				return initLevelIndexInternal;
			}
		}

		// Token: 0x060366AF RID: 222895 RVA: 0x00F318B5 File Offset: 0x00F2FAB5
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060366B0 RID: 222896 RVA: 0x00F318B7 File Offset: 0x00F2FAB7
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_FarmGoldMain";
		}

		// Token: 0x060366B1 RID: 222897 RVA: 0x00F318BE File Offset: 0x00F2FABE
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new FarmGoldSubView();
		}

		// Token: 0x060366B2 RID: 222898 RVA: 0x00F318C5 File Offset: 0x00F2FAC5
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new FarmGoldData();
		}

		// Token: 0x060366B3 RID: 222899 RVA: 0x00F318CC File Offset: 0x00F2FACC
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060366B4 RID: 222900 RVA: 0x00F318CF File Offset: 0x00F2FACF
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		}

		// Token: 0x060366B5 RID: 222901 RVA: 0x00F318ED File Offset: 0x00F2FAED
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		}

		// Token: 0x060366B6 RID: 222902 RVA: 0x00F3190B File Offset: 0x00F2FB0B
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.FarmGoldLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.FarmGoldLevelNotify));
			Net.Instance.Register(ENotifyMessageId.FarmGoldResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFarmGoldResultNotify));
		}

		// Token: 0x060366B7 RID: 222903 RVA: 0x00F31945 File Offset: 0x00F2FB45
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FarmGoldLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FarmGoldResultNotify);
		}

		// Token: 0x060366B8 RID: 222904 RVA: 0x00F31967 File Offset: 0x00F2FB67
		private void OnLeaveInstanceDungeonConfirm()
		{
			if (InstanceDungeonEntranceModel.Instance.IsFarmGoldInstanceDungeon())
			{
				this.RequestExitDungeon();
			}
		}

		// Token: 0x060366B9 RID: 222905 RVA: 0x00F3197C File Offset: 0x00F2FB7C
		public void RequestExitDungeon()
		{
			FarmGoldResultRequest message = new FarmGoldResultRequest();
			Net.Instance.Call(ERequestMessageId.FarmGoldResultRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if ((FarmGoldResultResponse)msg == null)
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
				}
			}, 0);
		}

		// Token: 0x060366BA RID: 222906 RVA: 0x00F319C0 File Offset: 0x00F2FBC0
		public void RequestSetDifficulty(int activityId, int insId, int diff)
		{
			FarmGoldLevelDiffRequest farmGoldLevelDiffRequest = FarmGoldLevelDiffRequest.Create();
			farmGoldLevelDiffRequest.ActivityId = activityId;
			farmGoldLevelDiffRequest.InstId = insId;
			farmGoldLevelDiffRequest.Diff = diff;
			Net.Instance.Call(ERequestMessageId.FarmGoldLevelDiffRequest, farmGoldLevelDiffRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FarmGoldLevelDiffResponse farmGoldLevelDiffResponse = (FarmGoldLevelDiffResponse)msg;
				if (farmGoldLevelDiffResponse != null && farmGoldLevelDiffResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(farmGoldLevelDiffResponse.ErrorCode, 26415, null, true, true);
				}
				FarmGoldData farmGoldData = ActivityModel.Instance.GetActivityById(activityId) as FarmGoldData;
				if (farmGoldData != null)
				{
					farmGoldData.SetInsDifficult(insId, diff);
				}
				EventSystem.Instance.Emit(EEventName.OnRefreshInstancedRecommendLevel);
			}, 0);
		}

		// Token: 0x060366BB RID: 222907 RVA: 0x00F31A30 File Offset: 0x00F2FC30
		[NullableContext(2)]
		private void FarmGoldLevelNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			FarmGoldLevelNotify farmGoldLevelNotify = (FarmGoldLevelNotify)msg;
			FarmGoldData farmGoldData = ActivityModel.Instance.GetActivityById(farmGoldLevelNotify.ActivityId) as FarmGoldData;
			if (farmGoldData == null)
			{
				return;
			}
			if (farmGoldLevelNotify.LevelPlayTasks != null)
			{
				farmGoldData.RefreshLevelData(farmGoldLevelNotify.LevelPlayTasks);
			}
			farmGoldData.PhraseRewardInfo();
			if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
			{
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, farmGoldData.GetRewardViewData());
			}
			EventSystem.Instance.Emit<int>(EEventName.FarmGoldRefreshRewardRedDot, farmGoldLevelNotify.ActivityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, farmGoldLevelNotify.ActivityId);
		}

		// Token: 0x060366BC RID: 222908 RVA: 0x00F31ACC File Offset: 0x00F2FCCC
		public void RequestFarmGoldPoint(int activityId, List<int> ids)
		{
			if (ids == null || ids.Count <= 0)
			{
				return;
			}
			FarmGoldPointRepeatedRequest farmGoldPointRepeatedRequest = FarmGoldPointRepeatedRequest.Create();
			farmGoldPointRepeatedRequest.ActivityId = activityId;
			farmGoldPointRepeatedRequest.Ids.AddRange(ids);
			Net.Instance.Call(ERequestMessageId.FarmGoldPointRepeatedRequest, farmGoldPointRepeatedRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FarmGoldPointRepeatedResponse farmGoldPointRepeatedResponse = (FarmGoldPointRepeatedResponse)msg;
				if (farmGoldPointRepeatedResponse != null && farmGoldPointRepeatedResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(farmGoldPointRepeatedResponse.ErrorCode, 18879, null, true, true);
					return;
				}
				if (farmGoldPointRepeatedResponse != null && farmGoldPointRepeatedResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					FarmGoldData farmGoldData = ActivityModel.Instance.GetActivityById(activityId) as FarmGoldData;
					if (farmGoldData != null)
					{
						farmGoldData.AddFinishPointId(ids);
					}
					if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
					{
						EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, farmGoldData.GetRewardPopUpViewData());
					}
					EventSystem.Instance.Emit<int>(EEventName.FarmGoldRefreshRewardRedDot, activityId);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
				}
			}, 0);
		}

		// Token: 0x060366BD RID: 222909 RVA: 0x00F31B44 File Offset: 0x00F2FD44
		public void RequestFarmGoldLevelPlay(int activityId, List<int> instIds)
		{
			if (instIds == null || instIds.Count <= 0)
			{
				return;
			}
			FarmGoldLevelPlayRepeatedRequest farmGoldLevelPlayRepeatedRequest = FarmGoldLevelPlayRepeatedRequest.Create();
			farmGoldLevelPlayRepeatedRequest.ActivityId = activityId;
			farmGoldLevelPlayRepeatedRequest.InstIdList.AddRange(instIds);
			Net.Instance.Call(ERequestMessageId.FarmGoldLevelPlayRepeatedRequest, farmGoldLevelPlayRepeatedRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FarmGoldLevelPlayRepeatedResponse farmGoldLevelPlayRepeatedResponse = (FarmGoldLevelPlayRepeatedResponse)msg;
				if (farmGoldLevelPlayRepeatedResponse != null && farmGoldLevelPlayRepeatedResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(farmGoldLevelPlayRepeatedResponse.ErrorCode, 16947, null, true, true);
					return;
				}
				if (farmGoldLevelPlayRepeatedResponse != null && farmGoldLevelPlayRepeatedResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					FarmGoldData farmGoldData = ActivityModel.Instance.GetActivityById(activityId) as FarmGoldData;
					if (farmGoldData != null)
					{
						farmGoldData.FinishLevelReward(instIds);
					}
					if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
					{
						EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, farmGoldData.GetRewardPopUpViewData());
					}
					EventSystem.Instance.Emit<int>(EEventName.FarmGoldRefreshRewardRedDot, activityId);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
				}
			}, 0);
		}

		// Token: 0x060366BE RID: 222910 RVA: 0x00F31BBC File Offset: 0x00F2FDBC
		[NullableContext(2)]
		private void OnFarmGoldResultNotify(IMessage msg, Net.CallbackStatus status = null)
		{
			FarmGoldResultNotify farmGoldResultNotify = (FarmGoldResultNotify)msg;
			bool flag = farmGoldResultNotify.ErrorCode > Aki.Protocol.ErrorCode.Success;
			if (flag)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(farmGoldResultNotify.ErrorCode, 20566, null, true, true);
			}
			Action onClickQuit = delegate()
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
			};
			RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_217_ButtonText_0",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					onClickQuit();
				}
			};
			Action onClickFight = delegate()
			{
				InstanceDungeonController.Instance.SingleInstReChallengeRequest(false);
			};
			RewardExploreConfirmButtonData item2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_217_ButtonText_1",
				DescriptionTextId = "FarmGoldHighestPoint",
				DescriptionArgs = new List<object>
				{
					farmGoldResultNotify.HisPoint.ToString()
				},
				IsTimeDownCloseView = false,
				IsClickedCloseView = false,
				OnClickedCallback = delegate(int _)
				{
					onClickFight();
				}
			};
			Action onClickBack = delegate()
			{
				FarmGoldData currentActivityData = this.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
					return;
				}
				this.IfLeaveInstanceDungeonWhenMainViewClose = true;
				this.InitLevelIndexInternal = this.EnterInstanceLevelIndex;
				int entranceId = FarmGoldConfig.Instance.GetFarmGoldMarkByActivityId(currentActivityData.Id).EntranceId;
				InstanceDungeonEntranceController.Instance.EnterEntrance(entranceId, 0, null).Forget<bool>();
			};
			RewardExploreConfirmButtonData item3 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Activity_103300004_DungeonEndButton",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					onClickBack();
				}
			};
			RewardExploreRecordData rewardExploreRecordData = new RewardExploreRecordData
			{
				TitleTextId = "FarmGoldCurrentPoint",
				Record = farmGoldResultNotify.CurPoint.ToString(),
				IsNewRecord = (farmGoldResultNotify.CurPoint >= farmGoldResultNotify.HisPoint)
			};
			ItemRewardController instance = ItemRewardController.Instance;
			int configId = flag ? 3021 : 3022;
			bool isSuccess = !flag && farmGoldResultNotify.Succ;
			List<RewardItemData> rewardItemDataList = null;
			IRewardExploreRecord exploreRecordInfo = flag ? null : rewardExploreRecordData;
			List<IRewardExploreBar> exploreBarDataList = null;
			List<IRewardExploreConfirmButton> buttonInfoList;
			if (!flag)
			{
				List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
				list.Add(item2);
				buttonInfoList = list;
				list.Add(item3);
			}
			else
			{
				(buttonInfoList = new List<IRewardExploreConfirmButton>()).Add(item);
			}
			instance.OpenExploreRewardView(configId, isSuccess, rewardItemDataList, exploreRecordInfo, exploreBarDataList, buttonInfoList, null, null, null, null, null, null, null, null, null, null, null);
		}

		// Token: 0x060366BF RID: 222911 RVA: 0x00F31DE0 File Offset: 0x00F2FFE0
		[NullableContext(0)]
		public UniTask<bool> OpenDefaultFarmGoldView()
		{
			FarmGoldController.<OpenDefaultFarmGoldView>d__21 <OpenDefaultFarmGoldView>d__;
			<OpenDefaultFarmGoldView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenDefaultFarmGoldView>d__.<>4__this = this;
			<OpenDefaultFarmGoldView>d__.<>1__state = -1;
			<OpenDefaultFarmGoldView>d__.<>t__builder.Start<FarmGoldController.<OpenDefaultFarmGoldView>d__21>(ref <OpenDefaultFarmGoldView>d__);
			return <OpenDefaultFarmGoldView>d__.<>t__builder.Task;
		}

		// Token: 0x060366C0 RID: 222912 RVA: 0x00F31E24 File Offset: 0x00F30024
		[NullableContext(0)]
		public UniTask<bool> OpenFarmGoldEntranceView(int activityId)
		{
			FarmGoldController.<OpenFarmGoldEntranceView>d__22 <OpenFarmGoldEntranceView>d__;
			<OpenFarmGoldEntranceView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenFarmGoldEntranceView>d__.activityId = activityId;
			<OpenFarmGoldEntranceView>d__.<>1__state = -1;
			<OpenFarmGoldEntranceView>d__.<>t__builder.Start<FarmGoldController.<OpenFarmGoldEntranceView>d__22>(ref <OpenFarmGoldEntranceView>d__);
			return <OpenFarmGoldEntranceView>d__.<>t__builder.Task;
		}

		// Token: 0x060366C1 RID: 222913 RVA: 0x00F31E68 File Offset: 0x00F30068
		public void OpenTempFarmGoldEntranceView()
		{
			FarmGoldData activityData = this.CreateTempActivityData();
			ActivityInstanceEntranceData param = this.CreateViewData(activityData);
			UiManager.Instance.OpenView(EUiViewName.ActivityInstanceEntranceView, param, null);
		}

		// Token: 0x060366C2 RID: 222914 RVA: 0x00F31E98 File Offset: 0x00F30098
		private FarmGoldData CreateTempActivityData()
		{
			FarmGoldData farmGoldData = new FarmGoldData();
			ActivityData activityData = new ActivityData
			{
				Id = 100805001,
				Type = ActivityType.FarmGold
			};
			activityData.FarmGoldInfo = new FarmGoldInfo();
			foreach (FarmGoldActivity farmGoldActivity in FarmGoldConfig.Instance.GetAllFarmGoldActivity())
			{
				FarmGoldLevelPlayInfo item = new FarmGoldLevelPlayInfo
				{
					InstId = farmGoldActivity.InstId,
					Point = 0,
					StartTime = 0,
					IsOpen = true,
					LevelRewardGet = false,
					Difficulty = 1
				};
				activityData.FarmGoldInfo.LevelPlayTasks.Add(item);
			}
			farmGoldData.Init(activityData);
			farmGoldData.Phrase(activityData);
			return farmGoldData;
		}

		// Token: 0x060366C3 RID: 222915 RVA: 0x00F31F64 File Offset: 0x00F30164
		private ActivityInstanceEntranceData CreateViewData(FarmGoldData activityData)
		{
			ActivityEntrancePointData activityEntrancePointData = ActivityEntrancePointData.Create(activityData.GetCurrentFullScore(), 0, new ERedDotName?(ERedDotName.FarmGoldReward), activityData.Id, activityData.GetRewardViewData(), new Func<string>(activityData.GetScoreDesc), delegate
			{
				UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, activityData.GetRewardPopUpViewData(), delegate(bool success, int viewId)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.ActivityInstanceEntranceView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				});
			});
			ActivityEntranceDescInfoData activityEntranceDescInfoData = ActivityEntranceDescInfoData.Create(new Func<int, string>(activityData.GetLevelNameTextByIndex), new Func<int, string>(activityData.GetLevelDescTextByIndex), new Func<int, List<int>>(activityData.GetLevelRecommendElementByIndex));
			string farmGoldEntranceName = FarmGoldConfig.Instance.GetFarmGoldEntranceName();
			string farmGoldEntranceSpritePath = FarmGoldConfig.Instance.GetFarmGoldEntranceSpritePath();
			int farmGoldEntranceHelpId = FarmGoldConfig.Instance.GetFarmGoldEntranceHelpId();
			ActivityEntranceCaptionItemData activityEntranceCaptionItemData = ActivityEntranceCaptionItemData.Create(farmGoldEntranceName, farmGoldEntranceSpritePath, farmGoldEntranceHelpId);
			List<ActivityEntranceSelectItemBaseData> list = new List<ActivityEntranceSelectItemBaseData>();
			List<FarmGoldLevelData> allLevelData = activityData.GetAllLevelData();
			Action<int> <>9__7;
			for (int i = 0; i < allLevelData.Count; i++)
			{
				int num = i;
				ActivityEntranceSelectItemSubData[] subData = null;
				Func<int, string> getNameFunc = new Func<int, string>(activityData.GetLevelNameTextByIndex);
				Func<int, string> getDescFunc = new Func<int, string>(activityData.GetLevelDescTextByIndex);
				Func<int, string> getSubTitleFunc = new Func<int, string>(activityData.GetLevelSubTitleTextByIndex);
				Func<int, bool> getLockStateFunc = new Func<int, bool>(activityData.GetLevelLockStateByIndex);
				Func<int, int> getInstanceDungeonIdFunc = new Func<int, int>(activityData.GetLevelInstanceDungeonIdByIndex);
				Func<int, string> getUnlockDescFunc = new Func<int, string>(activityData.GetLevelUnlockTextByIndex);
				Func<int, bool> getFinishStateFunc = new Func<int, bool>(activityData.GetLevelFinishStateByIndex);
				Func<int, int> getRecommendLevelFunc = new Func<int, int>(activityData.GetLevelRecommendLevelByIndex);
				Func<int, int> getDefaultDifficultIndex = new Func<int, int>(activityData.GetLevelDifficultIndexByIndex);
				Func<int, string> getBgPathFunc = new Func<int, string>(activityData.GetLevelBgByIndex);
				Action<int> clickCallBack;
				if ((clickCallBack = <>9__7) == null)
				{
					clickCallBack = (<>9__7 = delegate(int dataIndex)
					{
						FarmGoldLevelData levelDataByIndex = activityData.GetLevelDataByIndex(dataIndex);
						if (levelDataByIndex == null)
						{
							return;
						}
						levelDataByIndex.SaveOpenState();
					});
				}
				ActivityEntranceSelectItemBaseData item = ActivityEntranceSelectItemBaseData.Create(num, num, subData, getNameFunc, getDescFunc, getSubTitleFunc, getLockStateFunc, getInstanceDungeonIdFunc, getUnlockDescFunc, getFinishStateFunc, getRecommendLevelFunc, getDefaultDifficultIndex, getBgPathFunc, clickCallBack, new Func<int, bool>(activityData.GetLevelRedDotStateByIndex));
				list.Add(item);
			}
			ActivityEntranceSelectItemData selectData = ActivityEntranceSelectItemData.Create(list);
			IReadOnlyList<FarmGoldDifficulty> allDifficultData = FarmGoldConfig.Instance.GetFarmGoldAllDifficult();
			List<ActivityEntranceDropDownContentData> list2 = new List<ActivityEntranceDropDownContentData>();
			Func<int, string> <>9__8;
			Func<int, string> <>9__9;
			Func<int, int> <>9__10;
			Action<ActivityInstanceEntranceData, int> <>9__11;
			for (int j = 0; j < allDifficultData.Count; j++)
			{
				int dataIndex2 = j;
				Func<int, string> getTogOptionTextFunc;
				if ((getTogOptionTextFunc = <>9__8) == null)
				{
					getTogOptionTextFunc = (<>9__8 = delegate(int dataIndex)
					{
						int id = allDifficultData[dataIndex].Id;
						return activityData.GetDifficultTogText(id);
					});
				}
				Func<int, string> getDropDownTextFunc;
				if ((getDropDownTextFunc = <>9__9) == null)
				{
					getDropDownTextFunc = (<>9__9 = delegate(int dataIndex)
					{
						int id = allDifficultData[dataIndex].Id;
						return activityData.GetDifficultTitle(id);
					});
				}
				Func<int, int> getRecommendLevelFunc2;
				if ((getRecommendLevelFunc2 = <>9__10) == null)
				{
					getRecommendLevelFunc2 = (<>9__10 = delegate(int dataIndex)
					{
						int id = allDifficultData[dataIndex].Id;
						return activityData.GetDifficultRecommendLevel(id);
					});
				}
				Action<ActivityInstanceEntranceData, int> getOnSelectCallBack;
				if ((getOnSelectCallBack = <>9__11) == null)
				{
					getOnSelectCallBack = (<>9__11 = delegate(ActivityInstanceEntranceData entranceData, int dataIndex)
					{
						int id = allDifficultData[dataIndex].Id;
						ActivityEntranceSelectItemData activityEntranceSelectItemData = entranceData.GetActivityEntranceSelectItemData();
						int? num2;
						if (activityEntranceSelectItemData == null)
						{
							num2 = null;
						}
						else
						{
							ActivityEntranceItemData currentSelectData2 = activityEntranceSelectItemData.GetCurrentSelectData();
							num2 = ((currentSelectData2 != null) ? new int?(currentSelectData2.GetInstanceDungeonId()) : null);
						}
						int? num3 = num2;
						int valueOrDefault = num3.GetValueOrDefault();
						this.RequestSetDifficulty(activityData.Id, valueOrDefault, id);
					});
				}
				ActivityEntranceDropDownContentData item2 = ActivityEntranceDropDownContentData.Create(dataIndex2, getTogOptionTextFunc, getDropDownTextFunc, getRecommendLevelFunc2, getOnSelectCallBack);
				list2.Add(item2);
			}
			ActivityEntranceItemData currentSelectData = selectData.GetCurrentSelectData();
			int instId = (currentSelectData != null) ? currentSelectData.GetInstanceDungeonId() : 0;
			FarmGoldLevelData levelInfoByInstId = activityData.GetLevelInfoByInstId(instId);
			ActivityEntranceDropDownData activityEntranceDropDownData = ActivityEntranceDropDownData.Create(list2.ToArray(), (levelInfoByInstId != null) ? levelInfoByInstId.GetSelectDifficultIndex() : 0);
			ActivityEntranceMonsterPreviewData activityEntranceMonsterPreviewData = ActivityEntranceMonsterPreviewData.Create(delegate(int dataIndex)
			{
				FarmGoldLevelData levelDataByIndex = activityData.GetLevelDataByIndex(dataIndex);
				return ((levelDataByIndex != null) ? levelDataByIndex.GetMonsterTips() : null) ?? "";
			}, delegate(int dataIndex)
			{
				FarmGoldLevelData levelDataByIndex = activityData.GetLevelDataByIndex(dataIndex);
				return levelDataByIndex != null && levelDataByIndex.GetMonsterPreviewState();
			}, delegate(int dataIndex)
			{
				FarmGoldLevelData levelDataByIndex = activityData.GetLevelDataByIndex(dataIndex);
				if (levelDataByIndex == null)
				{
					return 0;
				}
				return levelDataByIndex.GetInstId();
			}, delegate(int dataIndex)
			{
				UiManager instance = UiManager.Instance;
				EUiViewName instanceDungeonMonsterPreView = EUiViewName.InstanceDungeonMonsterPreView;
				FarmGoldLevelData levelDataByIndex = activityData.GetLevelDataByIndex(dataIndex);
				instance.OpenView(instanceDungeonMonsterPreView, (levelDataByIndex != null) ? new int?(levelDataByIndex.GetInstId()) : null, null);
			});
			return ActivityInstanceEntranceData.Create(activityEntrancePointData, activityEntranceDescInfoData, selectData, activityEntranceCaptionItemData, activityEntranceDropDownData, activityEntranceMonsterPreviewData, delegate
			{
				ActivityEntranceItemData currentSelectData2 = selectData.GetCurrentSelectData();
				if (currentSelectData2 != null)
				{
					FarmGoldLevelData levelDataByIndex = activityData.GetLevelDataByIndex(currentSelectData2.GetSelectDataIndex());
					if (levelDataByIndex != null)
					{
						this.HandleDoubleConfirmSoloEnterDungeon(levelDataByIndex);
					}
				}
			});
		}

		// Token: 0x060366C4 RID: 222916 RVA: 0x00F322CC File Offset: 0x00F304CC
		public void HandleDoubleConfirmSoloEnterDungeon(FarmGoldLevelData levelData)
		{
			InstanceDungeonModel.Instance.InstanceContinue = false;
			int instId = levelData.GetInstId();
			if (InstanceDungeonEntranceModel.Instance.IsDungeonArchiveActivate(instId) && InstanceDungeonEntranceModel.Instance.HasDungeonArchive(instId))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DungeonContinuePlayConfirm);
				Action value = delegate()
				{
					InstanceDungeonModel.Instance.InstanceContinue = true;
					this.HandleSoloEnterDungeon(levelData);
				};
				Action value2 = delegate()
				{
					this.HandleSoloEnterDungeon(levelData);
				};
				Action value3 = delegate()
				{
					ConfirmBoxController.Instance.CloseConfirmBoxView();
				};
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[2] = value;
				confirmBoxDataNew.FunctionMap[1] = value2;
				confirmBoxDataNew.FunctionMap[-1] = value3;
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.HandleSoloEnterDungeon(levelData);
		}

		// Token: 0x060366C5 RID: 222917 RVA: 0x00F323B4 File Offset: 0x00F305B4
		private void HandleSoloEnterDungeon(FarmGoldLevelData levelData)
		{
			this.EnterInstanceLevelIndex = levelData.GetIndex();
			int instId = levelData.GetInstId();
			InstanceDungeonEntranceModel.Instance.InstanceId = instId;
			FarmGoldData.CurrentSelectEntranceId = levelData.GetInstanceEntranceId();
			InstanceDungeonEntranceModel.Instance.EntranceId = levelData.GetInstanceEntranceId();
			InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
		}

		// Token: 0x060366C6 RID: 222918 RVA: 0x00F32404 File Offset: 0x00F30604
		public bool CheckInFarmGold()
		{
			InstanceDungeon? config = ConfigInstanceDungeonById.GetConfig(CreatureModel.Instance.GetInstanceId(), true);
			return config != null && config.Value.InstSubType == 25 && GameModeController.Instance.IsInInstance();
		}

		// Token: 0x060366C7 RID: 222919 RVA: 0x00F3244C File Offset: 0x00F3064C
		[NullableContext(2)]
		public FarmGoldData GetCurrentActivityData()
		{
			List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(33);
			if (activitiesByType.Count <= 0)
			{
				return null;
			}
			return activitiesByType[0] as FarmGoldData;
		}

		// Token: 0x17006978 RID: 27000
		// (get) Token: 0x060366C8 RID: 222920 RVA: 0x00F3247D File Offset: 0x00F3067D
		public static FarmGoldController Instance
		{
			get
			{
				return FarmGoldController._Instance;
			}
		}

		// Token: 0x060366C9 RID: 222921 RVA: 0x00F32484 File Offset: 0x00F30684
		public static FarmGoldController GetOrCreateInstance()
		{
			if (FarmGoldController._Instance == null)
			{
				FarmGoldController.CreateInstance();
			}
			return FarmGoldController._Instance;
		}

		// Token: 0x060366CA RID: 222922 RVA: 0x00F32498 File Offset: 0x00F30698
		public static bool CreateInstance()
		{
			if (FarmGoldController._Instance != null)
			{
				return true;
			}
			FarmGoldController._Instance = new FarmGoldController();
			return true;
		}

		// Token: 0x060366CB RID: 222923 RVA: 0x00F324AE File Offset: 0x00F306AE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060366CC RID: 222924 RVA: 0x00F324B0 File Offset: 0x00F306B0
		public static void ResetStaticDefaultValue()
		{
			FarmGoldController._Instance = null;
		}

		// Token: 0x060366CD RID: 222925 RVA: 0x00F324B8 File Offset: 0x00F306B8
		static FarmGoldController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FarmGoldController.CreateStaticDefaultValue), new Action(FarmGoldController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CBA6 RID: 117670
		public bool IfLeaveInstanceDungeonWhenMainViewClose;

		// Token: 0x0401CBA7 RID: 117671
		private int EnterInstanceLevelIndex;

		// Token: 0x0401CBA8 RID: 117672
		private int InitLevelIndexInternal;

		// Token: 0x0401CBA9 RID: 117673
		[Nullable(2)]
		private static FarmGoldController _Instance;
	}
}
