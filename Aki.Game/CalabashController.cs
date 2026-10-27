using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001720 RID: 5920
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CalabashController : UiControllerBase
{
	// Token: 0x0600AB04 RID: 43780 RVA: 0x00266E02 File Offset: 0x00265002
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.ActiveBattleView, this.OnShowUnlockItemView);
		EventSystem.Instance.Add(EEventName.OnVisionRefineSubNeedAck, new Action(this.OnVisionRefineSubNeedAck));
	}

	// Token: 0x0600AB05 RID: 43781 RVA: 0x00266E36 File Offset: 0x00265036
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, this.OnShowUnlockItemView);
		EventSystem.Instance.Remove(EEventName.OnVisionRefineSubNeedAck, new Action(this.OnVisionRefineSubNeedAck));
	}

	// Token: 0x0600AB06 RID: 43782 RVA: 0x00266E6A File Offset: 0x0026506A
	public void OpenCalabashUpgradeSuccessView(ICalabashUpgradeSuccessViedData data)
	{
		UiManager.Instance.OpenView(EUiViewName.CalabashUpgradeSuccessView, data, null);
	}

	// Token: 0x0600AB07 RID: 43783 RVA: 0x00266E80 File Offset: 0x00265080
	private void OnVisionRefineSubNeedAck()
	{
		CalabashController.<>c__DisplayClass4_0 CS$<>8__locals1 = new CalabashController.<>c__DisplayClass4_0();
		Dictionary<int, PhantomBattleData> phantomBattleDataMap = PhantomBattleModel.Instance.GetPhantomBattleDataMap();
		if (phantomBattleDataMap == null)
		{
			return;
		}
		CS$<>8__locals1.uid = null;
		List<Aki.Protocol.PhantomPropInfo> list = null;
		List<int> list2 = null;
		foreach (KeyValuePair<int, PhantomBattleData> keyValuePair in phantomBattleDataMap)
		{
			List<Aki.Protocol.PhantomPropInfo> unAckSubProp = keyValuePair.Value.GetUnAckSubProp();
			if (unAckSubProp.Count > 0)
			{
				CS$<>8__locals1.uid = new int?(keyValuePair.Key);
				list = unAckSubProp;
				list2 = keyValuePair.Value.GetLockSubPropIndices();
				break;
			}
		}
		if (CS$<>8__locals1.uid == null || list == null || list2 == null)
		{
			return;
		}
		VisionRefineBatchResultViewData visionRefineBatchResultViewData = new VisionRefineBatchResultViewData();
		HashSet<int> lockSet = new HashSet<int>(list2);
		visionRefineBatchResultViewData.LeftAttrList = this.BuildRefineSubVerticalLeftDataByUid(CS$<>8__locals1.uid, lockSet, null);
		visionRefineBatchResultViewData.RightAttrList = this.BuildRefineSubVerticalRightDataByUid(CS$<>8__locals1.uid, list, lockSet, null);
		visionRefineBatchResultViewData.OnClickCancel = delegate()
		{
			CalabashController.<>c__DisplayClass4_0.<<OnVisionRefineSubNeedAck>b__0>d <<OnVisionRefineSubNeedAck>b__0>d;
			<<OnVisionRefineSubNeedAck>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnVisionRefineSubNeedAck>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnVisionRefineSubNeedAck>b__0>d.<>1__state = -1;
			<<OnVisionRefineSubNeedAck>b__0>d.<>t__builder.Start<CalabashController.<>c__DisplayClass4_0.<<OnVisionRefineSubNeedAck>b__0>d>(ref <<OnVisionRefineSubNeedAck>b__0>d);
			return <<OnVisionRefineSubNeedAck>b__0>d.<>t__builder.Task;
		};
		visionRefineBatchResultViewData.OnClickConfirm = delegate()
		{
			CalabashController.<>c__DisplayClass4_0.<<OnVisionRefineSubNeedAck>b__1>d <<OnVisionRefineSubNeedAck>b__1>d;
			<<OnVisionRefineSubNeedAck>b__1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnVisionRefineSubNeedAck>b__1>d.<>4__this = CS$<>8__locals1;
			<<OnVisionRefineSubNeedAck>b__1>d.<>1__state = -1;
			<<OnVisionRefineSubNeedAck>b__1>d.<>t__builder.Start<CalabashController.<>c__DisplayClass4_0.<<OnVisionRefineSubNeedAck>b__1>d>(ref <<OnVisionRefineSubNeedAck>b__1>d);
			return <<OnVisionRefineSubNeedAck>b__1>d.<>t__builder.Task;
		};
		visionRefineBatchResultViewData.UniqueId = CS$<>8__locals1.uid;
		visionRefineBatchResultViewData.ConfirmTipTextId = "Text_UnconfirmedResultTips_Text";
		UiManager.Instance.OpenView(EUiViewName.VisionRefineSubResultView, visionRefineBatchResultViewData, null);
	}

	// Token: 0x0600AB08 RID: 43784 RVA: 0x00266FCC File Offset: 0x002651CC
	public VisionRefineAttributeItemData[] BuildRefineSubVerticalLeftDataByUid(int? uid, HashSet<int> lockSet, [Nullable(new byte[]
	{
		2,
		1
	})] List<AttrRecommendInfo> recommendList)
	{
		List<VisionRefineAttributeItemData> list = new List<VisionRefineAttributeItemData>();
		for (int i = 0; i < 5; i++)
		{
			VisionRefineAttributeItemData visionRefineAttributeItemData = new VisionRefineAttributeItemData();
			if (uid != null)
			{
				PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uid.Value);
				List<VisionSubPropData> list2 = (phantomDataBase != null) ? phantomDataBase.GetEquipmentViewPreviewData() : null;
				if (list2 != null && list2.Count > i)
				{
					visionRefineAttributeItemData.NameTextId = list2[i].GetSubPropName();
					visionRefineAttributeItemData.NumberText = list2[i].GetAttributeValueString();
					visionRefineAttributeItemData.IsChosen = lockSet.Contains(i);
					visionRefineAttributeItemData.CanInteractive = false;
					int phantomPropId = list2[i].PhantomSubProp.PhantomPropId;
					PhantomSubProperty subConfig = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropId);
					visionRefineAttributeItemData.IsRecommend = (recommendList != null && recommendList.Exists((AttrRecommendInfo value) => value.GetAttrId() == subConfig.PropId && value.GetAddType() == subConfig.AddType));
				}
				else
				{
					visionRefineAttributeItemData.NameTextId = "Text_VisionRefineSubAttriLocked_Text";
					visionRefineAttributeItemData.CanInteractive = false;
				}
			}
			else
			{
				visionRefineAttributeItemData.NameTextId = "ErrorCode_200347_Text";
				visionRefineAttributeItemData.CanInteractive = false;
			}
			list.Add(visionRefineAttributeItemData);
		}
		return list.ToArray();
	}

	// Token: 0x0600AB09 RID: 43785 RVA: 0x002670EC File Offset: 0x002652EC
	public VisionRefineAttributeItemData[] BuildRefineSubVerticalRightDataByUid(int? uid, List<Aki.Protocol.PhantomPropInfo> unAckInfo, HashSet<int> lockSet, [Nullable(new byte[]
	{
		2,
		1
	})] List<AttrRecommendInfo> recommendList)
	{
		List<VisionRefineAttributeItemData> list = new List<VisionRefineAttributeItemData>();
		for (int i = 0; i < 5; i++)
		{
			VisionRefineAttributeItemData visionRefineAttributeItemData = new VisionRefineAttributeItemData();
			if (uid != null)
			{
				PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uid.Value);
				bool flag = lockSet.Contains(i);
				List<VisionSubPropData> list2 = (phantomDataBase != null) ? phantomDataBase.GetEquipmentViewPreviewData() : null;
				if (list2 != null && list2.Count > i && unAckInfo.Count > i)
				{
					VisionSubPropData visionSubPropData = list2[i];
					int phantomPropId = unAckInfo[i].PhantomPropId;
					PhantomSubProperty subConfig = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropId);
					visionRefineAttributeItemData.NameTextId = visionSubPropData.GetSubPropNameByPropId(phantomPropId);
					visionRefineAttributeItemData.NumberText = visionSubPropData.GetAttributeValueStringByPropId(phantomPropId, unAckInfo[i].Value);
					visionRefineAttributeItemData.ForceCheckboxActive = new bool?(false);
					visionRefineAttributeItemData.HasNewIcon = new bool?(!flag);
					visionRefineAttributeItemData.IsChosen = flag;
					visionRefineAttributeItemData.CanInteractive = false;
					visionRefineAttributeItemData.IsRecommend = (recommendList != null && recommendList.Exists((AttrRecommendInfo value) => value.GetAttrId() == subConfig.PropId && value.GetAddType() == subConfig.AddType));
				}
				else
				{
					visionRefineAttributeItemData.NameTextId = "Text_VisionRefineSubAttriLocked_Text";
					visionRefineAttributeItemData.CanInteractive = false;
				}
			}
			else
			{
				visionRefineAttributeItemData.NameTextId = "ErrorCode_200347_Text";
				visionRefineAttributeItemData.CanInteractive = false;
			}
			list.Add(visionRefineAttributeItemData);
		}
		return list.ToArray();
	}

	// Token: 0x0600AB0A RID: 43786 RVA: 0x00267248 File Offset: 0x00265448
	private void DoShowUnlockItemView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.CalabashUnlockItemView) && UiManager.Instance.IsViewShow(EUiViewName.BattleView) && !SundryModel.Instance.IsBlockTips)
		{
			List<VisionUnlockQualityData> calabashUnlockTipsList = CalabashModel.Instance.CalabashUnlockTipsList;
			object param = null;
			if (calabashUnlockTipsList.Count > 0)
			{
				param = calabashUnlockTipsList[0];
				calabashUnlockTipsList.RemoveAt(0);
			}
			UiManager.Instance.OpenView(EUiViewName.CalabashUnlockItemView, param, null);
		}
	}

	// Token: 0x0600AB0B RID: 43787 RVA: 0x002672BC File Offset: 0x002654BC
	protected override void OnRegisterNetEvent()
	{
		Net instance = Net.Instance;
		ENotifyMessageId id = ENotifyMessageId.CalabashMsgNotify;
		Action<IMessage, Net.CallbackStatus> callback;
		if ((callback = CalabashController.<>O.<0>__CalabashMsgNotify) == null)
		{
			callback = (CalabashController.<>O.<0>__CalabashMsgNotify = new Action<IMessage, Net.CallbackStatus>(CalabashController.CalabashMsgNotify));
		}
		instance.Register(id, callback);
		Net instance2 = Net.Instance;
		ENotifyMessageId id2 = ENotifyMessageId.CalabashExpAddNotify;
		Action<IMessage, Net.CallbackStatus> callback2;
		if ((callback2 = CalabashController.<>O.<1>__CalabashExpAddNotify) == null)
		{
			callback2 = (CalabashController.<>O.<1>__CalabashExpAddNotify = new Action<IMessage, Net.CallbackStatus>(CalabashController.CalabashExpAddNotify));
		}
		instance2.Register(id2, callback2);
		Net instance3 = Net.Instance;
		ENotifyMessageId id3 = ENotifyMessageId.CalabashDevelopRewardUnlockNotify;
		Action<IMessage, Net.CallbackStatus> callback3;
		if ((callback3 = CalabashController.<>O.<2>__CalabashDevelopRewardUnlockNotify) == null)
		{
			callback3 = (CalabashController.<>O.<2>__CalabashDevelopRewardUnlockNotify = new Action<IMessage, Net.CallbackStatus>(CalabashController.CalabashDevelopRewardUnlockNotify));
		}
		instance3.Register(id3, callback3);
		Net instance4 = Net.Instance;
		ENotifyMessageId id4 = ENotifyMessageId.CalabashLevelsRewardNotify;
		Action<IMessage, Net.CallbackStatus> callback4;
		if ((callback4 = CalabashController.<>O.<3>__CalabashLevelsRewardNotify) == null)
		{
			callback4 = (CalabashController.<>O.<3>__CalabashLevelsRewardNotify = new Action<IMessage, Net.CallbackStatus>(CalabashController.CalabashLevelsRewardNotify));
		}
		instance4.Register(id4, callback4);
		Net instance5 = Net.Instance;
		ENotifyMessageId id5 = ENotifyMessageId.PhantomDirectRefiningWeeklyResetNotify;
		Action<IMessage, Net.CallbackStatus> callback5;
		if ((callback5 = CalabashController.<>O.<4>__PhantomDirectRefiningWeeklyResetNotify) == null)
		{
			callback5 = (CalabashController.<>O.<4>__PhantomDirectRefiningWeeklyResetNotify = new Action<IMessage, Net.CallbackStatus>(CalabashController.PhantomDirectRefiningWeeklyResetNotify));
		}
		instance5.Register(id5, callback5);
	}

	// Token: 0x0600AB0C RID: 43788 RVA: 0x002673A0 File Offset: 0x002655A0
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.CalabashMsgNotify);
		Net.Instance.UnRegister(ENotifyMessageId.CalabashExpAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.CalabashDevelopRewardUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.CalabashLevelsRewardNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomDirectRefiningWeeklyResetNotify);
	}

	// Token: 0x0600AB0D RID: 43789 RVA: 0x00267400 File Offset: 0x00265600
	[NullableContext(2)]
	private static void CalabashMsgNotify(IMessage msg, Net.CallbackStatus _)
	{
		CalabashMsgNotify calabashMsgNotify = (CalabashMsgNotify)msg;
		Log.Instance.Info(ELogModule.Calabash, ELogAuthor.XXJ, "服务端推送吸收器信息", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (CalabashModel.Instance.CalabashInstance != null)
		{
			int currentExp = CalabashModel.Instance.GetCurrentExp();
			if (CalabashModel.Instance.GetCalabashLevel() != calabashMsgNotify.CalabashMsg.Level)
			{
				CalabashUpgradeSuccessViedData data = new CalabashUpgradeSuccessViedData
				{
					AddExp = false,
					PreLevel = CalabashModel.Instance.GetCalabashLevel(),
					PreExp = currentExp,
					CurLevel = calabashMsgNotify.CalabashMsg.Level,
					CurExp = currentExp
				};
				CalabashController.Instance.OpenCalabashUpgradeSuccessView(data);
			}
		}
		CalabashModel.Instance.SetCalabashInstanceBaseInfo(calabashMsgNotify.CalabashMsg);
		CalabashModel.Instance.SetCalabashInstanceConfigInfo(calabashMsgNotify.CalabashCfg);
		CalabashModel.Instance.UpdateCalabashDevelopRewardData();
	}

	// Token: 0x0600AB0E RID: 43790 RVA: 0x002674D4 File Offset: 0x002656D4
	[NullableContext(2)]
	private static void CalabashExpAddNotify(IMessage msg, Net.CallbackStatus _)
	{
		CalabashExpAddNotify calabashExpAddNotify = (CalabashExpAddNotify)msg;
		Log.Instance.Info(ELogModule.Calabash, ELogAuthor.XXJ, "服务端推送吸收器经验变化信息", default(ReadOnlySpan<ValueTuple<string, object>>));
		int curLevel = calabashExpAddNotify.CurLevel;
		int curExp = calabashExpAddNotify.CurExp;
		int currentExp = CalabashModel.Instance.GetCurrentExp();
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		CalabashUpgradeSuccessViedData data = new CalabashUpgradeSuccessViedData
		{
			AddExp = true,
			PreLevel = calabashLevel,
			PreExp = currentExp,
			CurLevel = curLevel,
			CurExp = curExp
		};
		CalabashModel.Instance.SetCurrentExp(curExp);
		CalabashModel.Instance.SetCalabashLevel(curLevel);
		CalabashModel.Instance.SetCalabashInstanceConfigInfo(calabashExpAddNotify.CalabashCfg);
		CalabashModel.Instance.UpdateCalabashDevelopRewardData();
		CalabashController.Instance.OpenCalabashUpgradeSuccessView(data);
		if (calabashLevel < curLevel)
		{
			EventSystem.Instance.Emit(EEventName.RedDotRefreshCalabash);
		}
	}

	// Token: 0x0600AB0F RID: 43791 RVA: 0x002675AC File Offset: 0x002657AC
	[NullableContext(2)]
	private static void CalabashDevelopRewardUnlockNotify(IMessage msg, Net.CallbackStatus _)
	{
		CalabashDevelopRewardUnlockNotify calabashDevelopRewardUnlockNotify = (CalabashDevelopRewardUnlockNotify)msg;
		Log.Instance.Info(ELogModule.Calabash, ELogAuthor.XXJ, "服务端更新的葫芦经验图谱信息", default(ReadOnlySpan<ValueTuple<string, object>>));
		CalabashModel.Instance.SetUnlockCalabashDevelopReward(calabashDevelopRewardUnlockNotify.UnlockedDevelopReward);
		CalabashModel.Instance.UpdateCalabashDevelopRewardData();
	}

	// Token: 0x0600AB10 RID: 43792 RVA: 0x002675FC File Offset: 0x002657FC
	[NullableContext(2)]
	private static void CalabashLevelsRewardNotify(IMessage msg, Net.CallbackStatus _)
	{
		CalabashLevelsRewardNotify calabashLevelsRewardNotify = (CalabashLevelsRewardNotify)msg;
		Log.Instance.Info(ELogModule.Calabash, ELogAuthor.XXJ, "服务端更新的葫芦已获得奖励等级列表数据", default(ReadOnlySpan<ValueTuple<string, object>>));
		CalabashModel.Instance.SetCalabashLevelsReward(calabashLevelsRewardNotify.RewardedLevels.ToList<int>());
	}

	// Token: 0x0600AB11 RID: 43793 RVA: 0x00267644 File Offset: 0x00265844
	[NullableContext(2)]
	public static void PhantomDirectRefiningWeeklyResetNotify(IMessage msg, Net.CallbackStatus _)
	{
		PhantomDirectRefiningWeeklyResetNotify phantomDirectRefiningWeeklyResetNotify = (PhantomDirectRefiningWeeklyResetNotify)msg;
		Log.Instance.Info(ELogModule.Calabash, ELogAuthor.LJQ, "服务端更新定向融合次数", default(ReadOnlySpan<ValueTuple<string, object>>));
		CalabashModel.Instance.DirectionalFusionTime = phantomDirectRefiningWeeklyResetNotify.DirectRefineWeekTimes;
		if (UiManager.Instance.IsViewOpen(EUiViewName.CalabashRootView) && (UiManager.Instance.GetViewByName(EUiViewName.CalabashRootView) as CalabashRootView).GetIsVisionRecoveryTabViewOpen())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomDirectRefiningWeeklyConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				EventSystem.Instance.Emit(EEventName.PhantomDirectRefiningWeeklyReset);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x0600AB12 RID: 43794 RVA: 0x002676F4 File Offset: 0x002658F4
	public void RequestMultiCalabashLevelReward(int[] levels)
	{
		Log.Instance.Info(ELogModule.Calabash, ELogAuthor.XXJ, "请求领取幻象等级奖励", default(ReadOnlySpan<ValueTuple<string, object>>));
		MulCalabashLevelRewardRequest mulCalabashLevelRewardRequest = MulCalabashLevelRewardRequest.Create();
		mulCalabashLevelRewardRequest.Level.AddRange(levels);
		Net.Instance.Call(ERequestMessageId.MulCalabashLevelRewardRequest, mulCalabashLevelRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MulCalabashLevelRewardResponse mulCalabashLevelRewardResponse = (MulCalabashLevelRewardResponse)msg;
			if (mulCalabashLevelRewardResponse == null)
			{
				return;
			}
			if (mulCalabashLevelRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulCalabashLevelRewardResponse.ErrorCode, 17924, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600AB13 RID: 43795 RVA: 0x00267764 File Offset: 0x00265964
	private List<PhantomStackConsumeEntry> BuildPhantomStackConsumeEntries(ISelectedData[] dataList)
	{
		List<PhantomStackConsumeEntry> list = new List<PhantomStackConsumeEntry>();
		foreach (ISelectedData selectedData in dataList)
		{
			PhantomStackConsumeEntry phantomStackConsumeEntry = PhantomStackConsumeEntry.Create();
			phantomStackConsumeEntry.IncrId = selectedData.IncId;
			phantomStackConsumeEntry.Count = PhantomStackUtil.GetUnitCount(selectedData);
			list.Add(phantomStackConsumeEntry);
		}
		return list;
	}

	// Token: 0x0600AB14 RID: 43796 RVA: 0x002677B8 File Offset: 0x002659B8
	public void RequestPhantomRefiningRequest(ISelectedData[] dataList)
	{
		PhantomRefiningRequest phantomRefiningRequest = PhantomRefiningRequest.Create();
		phantomRefiningRequest.StackEntries.AddRange(this.BuildPhantomStackConsumeEntries(dataList));
		Net.Instance.Call(ERequestMessageId.PhantomRefiningRequest, phantomRefiningRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomRefiningResponse phantomRefiningResponse = (PhantomRefiningResponse)msg;
			if (phantomRefiningResponse == null)
			{
				return;
			}
			if (phantomRefiningResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomRefiningResponse.ErrorCode, 29840, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>>(EEventName.OnVisionRecoveryResult, new OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse>(phantomRefiningResponse));
		}, 0);
	}

	// Token: 0x0600AB15 RID: 43797 RVA: 0x00267810 File Offset: 0x00265A10
	public void PhantomBatchDirectRefiningRequest(ISelectedData[] dataList)
	{
		PhantomBatchDirectRefiningRequest phantomBatchDirectRefiningRequest = Aki.Protocol.PhantomBatchDirectRefiningRequest.Create();
		phantomBatchDirectRefiningRequest.StackEntries.AddRange(this.BuildPhantomStackConsumeEntries(dataList));
		phantomBatchDirectRefiningRequest.TargetFetterGroupId = CalabashModel.Instance.DirectionalFusionTargetFetterGroup;
		Net.Instance.Call(ERequestMessageId.PhantomBatchDirectRefiningRequest, phantomBatchDirectRefiningRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomBatchDirectRefiningResponse phantomBatchDirectRefiningResponse = (PhantomBatchDirectRefiningResponse)msg;
			if (phantomBatchDirectRefiningResponse == null)
			{
				return;
			}
			if (phantomBatchDirectRefiningResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBatchDirectRefiningResponse.ErrorCode, 29320, null, true, true);
				return;
			}
			CalabashModel.Instance.DirectionalFusionTime = phantomBatchDirectRefiningResponse.DirectRefineWeekTimes;
			EventSystem.Instance.Emit<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(EEventName.OnVisionRecoveryBatchResult, new OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>(phantomBatchDirectRefiningResponse));
		}, 0);
	}

	// Token: 0x0600AB16 RID: 43798 RVA: 0x00267878 File Offset: 0x00265A78
	public void RequestBatchRefiningRequest(ISelectedData[] dataList)
	{
		PhantomBatchRefiningRequest phantomBatchRefiningRequest = PhantomBatchRefiningRequest.Create();
		phantomBatchRefiningRequest.StackEntries.AddRange(this.BuildPhantomStackConsumeEntries(dataList));
		Net.Instance.Call(ERequestMessageId.PhantomBatchRefiningRequest, phantomBatchRefiningRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomBatchRefiningResponse phantomBatchRefiningResponse = (PhantomBatchRefiningResponse)msg;
			if (phantomBatchRefiningResponse == null)
			{
				return;
			}
			if (phantomBatchRefiningResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBatchRefiningResponse.ErrorCode, 22170, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>>(EEventName.OnVisionRecoveryBatchResult, new OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse>(phantomBatchRefiningResponse));
		}, 0);
	}

	// Token: 0x0600AB17 RID: 43799 RVA: 0x002678D0 File Offset: 0x00265AD0
	public void JumpToCalabashCollectTabView(int monsterId)
	{
		CalabashCollectViewData param = new CalabashCollectViewData
		{
			MonsterId = monsterId
		};
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.CalabashCollectTabView, param);
	}

	// Token: 0x0600AB18 RID: 43800 RVA: 0x002678FC File Offset: 0x00265AFC
	public void JumpToCalabashCollectTabViewOnlyShow(int monsterId, bool onlyShow)
	{
		CalabashCollectViewData param = new CalabashCollectViewData
		{
			MonsterId = monsterId,
			OnlyShow = new bool?(onlyShow)
		};
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.CalabashCollectTabView, param);
	}

	// Token: 0x0600AB19 RID: 43801 RVA: 0x00267934 File Offset: 0x00265B34
	[NullableContext(2)]
	public void JumpToCalabashRootView(EUiTabViewName tabViewName, object param = null)
	{
		EFunctionType functionId = EFunctionType.Calabash;
		if (tabViewName == EUiTabViewName.VisionRecoveryTabView)
		{
			functionId = EFunctionType.VisionRecovery;
		}
		else if (tabViewName == EUiTabViewName.VisionRefineTabView)
		{
			functionId = EFunctionType.VisionRefine;
		}
		if (!FunctionModel.Instance.IsOpen((int)functionId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_UnlockNotice_Text", Array.Empty<object>());
			return;
		}
		CalabashRootViewData param2 = new CalabashRootViewData
		{
			TabViewName = tabViewName,
			Param = param
		};
		UiManager.Instance.OpenView(EUiViewName.CalabashRootView, param2, null);
	}

	// Token: 0x0600AB1A RID: 43802 RVA: 0x002679B8 File Offset: 0x00265BB8
	public unsafe void RequestPhantomPolishRequest(int incId, int propItemId)
	{
		PhantomPolishRequest phantomPolishRequest = PhantomPolishRequest.Create();
		phantomPolishRequest.IncrId = incId;
		phantomPolishRequest.PhantomMainPropItemId = propItemId;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Calabash;
		ELogAuthor author = ELogAuthor.WDX;
		string message = "RequestPhantomPolishRequest";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", incId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("propItemId", propItemId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		Net.Instance.Call(ERequestMessageId.PhantomPolishRequest, phantomPolishRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomPolishResponse phantomPolishResponse = (PhantomPolishResponse)msg;
			if (phantomPolishResponse == null || phantomPolishResponse.UpdateInfo == null)
			{
				return;
			}
			if (phantomPolishResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				if (phantomPolishResponse.StackSplitInfo != null || phantomPolishResponse.StackMergeInfos != null)
				{
					InventoryController instance2 = InventoryController.Instance;
					object splitInfos;
					if (phantomPolishResponse.StackSplitInfo == null)
					{
						splitInfos = null;
					}
					else
					{
						(splitInfos = new PhantomStackSplitInfo[1])[0] = phantomPolishResponse.StackSplitInfo;
					}
					object mergeInfos;
					if (phantomPolishResponse.StackMergeInfos == null)
					{
						mergeInfos = null;
					}
					else
					{
						(mergeInfos = new PhantomStackMergeInfo[1])[0] = phantomPolishResponse.StackMergeInfos;
					}
					instance2.ApplyPhantomStackSplitAndMerge(splitInfos, mergeInfos, "PhantomPolish");
				}
				InventoryModel.Instance.UpdatePhantomItemData(phantomPolishResponse.UpdateInfo, "PhantomPolish");
				PhantomBattleModel.Instance.UpdatePhantomBattleData(phantomPolishResponse.UpdateInfo);
				EventSystem.Instance.Emit<PhantomPolishResponse>(EEventName.OnVisionRefineResult, phantomPolishResponse);
				return;
			}
			if (phantomPolishResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrPhantomPkgFull)
			{
				ErrorCodeController.Instance.OpenErrorCodeScrollingTipsView(phantomPolishResponse.ErrorCode, Array.Empty<string>());
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(phantomPolishResponse.ErrorCode, 16484, null, true, true);
		}, 0);
	}

	// Token: 0x0600AB1B RID: 43803 RVA: 0x00267A6C File Offset: 0x00265C6C
	public UniTask RequestPhantomBatchPolishRequest(ISelectedData[] dataList, int propItemId)
	{
		CalabashController.<RequestPhantomBatchPolishRequest>d__24 <RequestPhantomBatchPolishRequest>d__;
		<RequestPhantomBatchPolishRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestPhantomBatchPolishRequest>d__.<>4__this = this;
		<RequestPhantomBatchPolishRequest>d__.dataList = dataList;
		<RequestPhantomBatchPolishRequest>d__.propItemId = propItemId;
		<RequestPhantomBatchPolishRequest>d__.<>1__state = -1;
		<RequestPhantomBatchPolishRequest>d__.<>t__builder.Start<CalabashController.<RequestPhantomBatchPolishRequest>d__24>(ref <RequestPhantomBatchPolishRequest>d__);
		return <RequestPhantomBatchPolishRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600AB1C RID: 43804 RVA: 0x00267AC0 File Offset: 0x00265CC0
	public UniTask RequestPhantomVicePolishRequest(int incId, int[] propLockIndexList)
	{
		CalabashController.<RequestPhantomVicePolishRequest>d__25 <RequestPhantomVicePolishRequest>d__;
		<RequestPhantomVicePolishRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestPhantomVicePolishRequest>d__.incId = incId;
		<RequestPhantomVicePolishRequest>d__.propLockIndexList = propLockIndexList;
		<RequestPhantomVicePolishRequest>d__.<>1__state = -1;
		<RequestPhantomVicePolishRequest>d__.<>t__builder.Start<CalabashController.<RequestPhantomVicePolishRequest>d__25>(ref <RequestPhantomVicePolishRequest>d__);
		return <RequestPhantomVicePolishRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600AB1D RID: 43805 RVA: 0x00267B0C File Offset: 0x00265D0C
	public UniTask RequestPhantomVicePolishAckRequest(int incId, bool ack)
	{
		CalabashController.<RequestPhantomVicePolishAckRequest>d__26 <RequestPhantomVicePolishAckRequest>d__;
		<RequestPhantomVicePolishAckRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestPhantomVicePolishAckRequest>d__.incId = incId;
		<RequestPhantomVicePolishAckRequest>d__.ack = ack;
		<RequestPhantomVicePolishAckRequest>d__.<>1__state = -1;
		<RequestPhantomVicePolishAckRequest>d__.<>t__builder.Start<CalabashController.<RequestPhantomVicePolishAckRequest>d__26>(ref <RequestPhantomVicePolishAckRequest>d__);
		return <RequestPhantomVicePolishAckRequest>d__.<>t__builder.Task;
	}

	// Token: 0x17000E0F RID: 3599
	// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x00267B57 File Offset: 0x00265D57
	public static CalabashController Instance
	{
		get
		{
			return CalabashController._Instance;
		}
	}

	// Token: 0x0600AB1F RID: 43807 RVA: 0x00267B5E File Offset: 0x00265D5E
	public static CalabashController GetOrCreateInstance()
	{
		if (CalabashController._Instance == null)
		{
			CalabashController.CreateInstance();
		}
		return CalabashController._Instance;
	}

	// Token: 0x0600AB20 RID: 43808 RVA: 0x00267B72 File Offset: 0x00265D72
	public static bool CreateInstance()
	{
		if (CalabashController._Instance != null)
		{
			return true;
		}
		CalabashController._Instance = new CalabashController();
		return true;
	}

	// Token: 0x0600AB21 RID: 43809 RVA: 0x00267B88 File Offset: 0x00265D88
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AB22 RID: 43810 RVA: 0x00267B8A File Offset: 0x00265D8A
	public static void ResetStaticDefaultValue()
	{
		CalabashController._Instance = null;
	}

	// Token: 0x0600AB23 RID: 43811 RVA: 0x00267B92 File Offset: 0x00265D92
	static CalabashController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashController.CreateStaticDefaultValue), new Action(CalabashController.ResetStaticDefaultValue));
	}

	// Token: 0x04004D8F RID: 19855
	private readonly Action OnShowUnlockItemView = delegate()
	{
		if (CalabashModel.Instance.CalabashUnlockTipsList.Count == 0)
		{
			return;
		}
		CalabashController.Instance.DoShowUnlockItemView();
	};

	// Token: 0x04004D90 RID: 19856
	[Nullable(2)]
	private static CalabashController _Instance;

	// Token: 0x02007D1E RID: 32030
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04028F9A RID: 167834
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__CalabashMsgNotify;

		// Token: 0x04028F9B RID: 167835
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <1>__CalabashExpAddNotify;

		// Token: 0x04028F9C RID: 167836
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <2>__CalabashDevelopRewardUnlockNotify;

		// Token: 0x04028F9D RID: 167837
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <3>__CalabashLevelsRewardNotify;

		// Token: 0x04028F9E RID: 167838
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <4>__PhantomDirectRefiningWeeklyResetNotify;
	}
}
