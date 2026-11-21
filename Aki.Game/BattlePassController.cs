using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001804 RID: 6148
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BattlePassController : UiControllerBase
{
	// Token: 0x0600F117 RID: 61719 RVA: 0x0046D28E File Offset: 0x0046B48E
	protected override bool OnInit()
	{
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.BattlePassMainView, new Action(this.RegisterOpenView));
		InputManager.Instance.RegisterCloseViewFunc(EUiViewName.BattlePassMainView, new Action(this.RegisterCloseView));
		return true;
	}

	// Token: 0x0600F118 RID: 61720 RVA: 0x0046D2C7 File Offset: 0x0046B4C7
	protected override bool OnClear()
	{
		this.StopBattlePassTimer();
		return true;
	}

	// Token: 0x0600F119 RID: 61721 RVA: 0x0046D2D0 File Offset: 0x0046B4D0
	private void RegisterOpenView()
	{
		this.OpenBattlePassView();
	}

	// Token: 0x0600F11A RID: 61722 RVA: 0x0046D2D8 File Offset: 0x0046B4D8
	private void RegisterCloseView()
	{
		this.CloseView();
	}

	// Token: 0x0600F11B RID: 61723 RVA: 0x0046D2E0 File Offset: 0x0046B4E0
	public void RequestBattlePassDataForTask()
	{
		BattlePassRequest message = BattlePassRequest.Create();
		Net.Instance.Call(ERequestMessageId.BattlePassRequest, message, new Action<IMessage, Net.CallbackStatus>(this.<RequestBattlePassDataForTask>g__Response|5_0), 0);
	}

	// Token: 0x0600F11C RID: 61724 RVA: 0x0046D310 File Offset: 0x0046B510
	public void OpenBattlePassView()
	{
		if (BattlePassModel.Instance.IsRequiringViewData || UiManager.Instance.IsViewOpen(EUiViewName.BattlePassMainView) || UiManager.Instance.IsViewOpen(EUiViewName.BattlePassFirstOpenView))
		{
			return;
		}
		this.DoOpenBattlePassView().ContinueWith(delegate()
		{
			BattlePassModel.Instance.IsRequiringViewData = false;
		}).Forget();
	}

	// Token: 0x0600F11D RID: 61725 RVA: 0x0046D37C File Offset: 0x0046B57C
	private UniTask DoOpenBattlePassView()
	{
		BattlePassController.<DoOpenBattlePassView>d__7 <DoOpenBattlePassView>d__;
		<DoOpenBattlePassView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DoOpenBattlePassView>d__.<>1__state = -1;
		<DoOpenBattlePassView>d__.<>t__builder.Start<BattlePassController.<DoOpenBattlePassView>d__7>(ref <DoOpenBattlePassView>d__);
		return <DoOpenBattlePassView>d__.<>t__builder.Task;
	}

	// Token: 0x0600F11E RID: 61726 RVA: 0x0046D3B8 File Offset: 0x0046B5B8
	public void SetBattlePassEnter()
	{
		BattlePassEnterPush message = BattlePassEnterPush.Create();
		Net.Instance.Send(EPushMessageId.BattlePassEnterPush, message);
		BattlePassModel.Instance.HadEnter = true;
	}

	// Token: 0x0600F11F RID: 61727 RVA: 0x0046D3E8 File Offset: 0x0046B5E8
	public void RequestTakeBattlePassReward(BattlePassType battlePassType, int level, int itemId, int gridIndex)
	{
		BattlePassController.<>c__DisplayClass9_0 CS$<>8__locals1 = new BattlePassController.<>c__DisplayClass9_0();
		CS$<>8__locals1.battlePassType = battlePassType;
		CS$<>8__locals1.level = level;
		CS$<>8__locals1.itemId = itemId;
		CS$<>8__locals1.gridIndex = gridIndex;
		BattlePassTakeRewardRequest battlePassTakeRewardRequest = BattlePassTakeRewardRequest.Create();
		battlePassTakeRewardRequest.Type = CS$<>8__locals1.battlePassType;
		battlePassTakeRewardRequest.Level = CS$<>8__locals1.level;
		battlePassTakeRewardRequest.ItemId = CS$<>8__locals1.itemId;
		Net.Instance.Call(ERequestMessageId.BattlePassTakeRewardRequest, battlePassTakeRewardRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestTakeBattlePassReward>g__ResponseAction|0), 0);
		BattlePassModel instance = BattlePassModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.TryAssignRemindLevel(new int?(CS$<>8__locals1.level));
	}

	// Token: 0x0600F120 RID: 61728 RVA: 0x0046D47C File Offset: 0x0046B67C
	public void RequestTakeAllRewardResponse()
	{
		BattlePassTakeAllRewardRequest message = BattlePassTakeAllRewardRequest.Create();
		Net.Instance.Call(ERequestMessageId.BattlePassTakeAllRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			BattlePassController.<RequestTakeAllRewardResponse>g__ResponseAction|10_0((BattlePassTakeAllRewardResponse)msg, status);
		}, 0);
		BattlePassModel instance = BattlePassModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.TryAssignRemindLevel(null);
	}

	// Token: 0x0600F121 RID: 61729 RVA: 0x0046D4D8 File Offset: 0x0046B6D8
	public void RequestBattlePassTask()
	{
		BattlePassTaskRequest message = BattlePassTaskRequest.Create();
		Net.Instance.Call(ERequestMessageId.BattlePassTaskRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			BattlePassController.<RequestBattlePassTask>g__ResponseAction|11_0((BattlePassTaskResponse)msg, status);
		}, 0);
	}

	// Token: 0x0600F122 RID: 61730 RVA: 0x0046D51B File Offset: 0x0046B71B
	public void TryRequestTaskList(List<int> taskIdList)
	{
		BattlePassModel.Instance.TryRequestTaskList(taskIdList);
	}

	// Token: 0x0600F123 RID: 61731 RVA: 0x0046D528 File Offset: 0x0046B728
	public void RequestBattlePassTaskTake(List<int> taskIdList)
	{
		BattlePassTaskTakeRequest battlePassTaskTakeRequest = BattlePassTaskTakeRequest.Create();
		battlePassTaskTakeRequest.Ids.AddRange(taskIdList);
		Net.Instance.Call(ERequestMessageId.BattlePassTaskTakeRequest, battlePassTaskTakeRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			BattlePassController.<RequestBattlePassTaskTake>g__ResponseAction|13_0((BattlePassTaskTakeResponse)msg, status);
		}, 0);
	}

	// Token: 0x0600F124 RID: 61732 RVA: 0x0046D578 File Offset: 0x0046B778
	public void RequestBuyBattlePassLevel(int level)
	{
		BattlePassLevelUpRequest battlePassLevelUpRequest = BattlePassLevelUpRequest.Create();
		battlePassLevelUpRequest.Level = level;
		Net.Instance.Call(ERequestMessageId.BattlePassLevelUpRequest, battlePassLevelUpRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x0600F125 RID: 61733 RVA: 0x0046D5C4 File Offset: 0x0046B7C4
	[NullableContext(2)]
	private void OnReceiveBattlePassTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (PbBattlePassTask task in ((BattlePassTaskUpdateNotify)msg).Tasks)
		{
			BattlePassModel.Instance.AddTaskDataFromProtocol(task);
		}
		EventSystem.Instance.Emit(EEventName.UpdateBattlePassTaskEvent);
	}

	// Token: 0x0600F126 RID: 61734 RVA: 0x0046D62C File Offset: 0x0046B82C
	[NullableContext(2)]
	private void OnReceiveBattlePassExpUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		BattlePassExpUpdateNotify battlePassExpUpdateNotify = (BattlePassExpUpdateNotify)msg;
		BattlePassModel.Instance.UpdateExpDataFromBattlePassExpUpdateNotify(battlePassExpUpdateNotify.Level, battlePassExpUpdateNotify.Exp, battlePassExpUpdateNotify.WeeklyTotalExp);
	}

	// Token: 0x0600F127 RID: 61735 RVA: 0x0046D65C File Offset: 0x0046B85C
	[NullableContext(2)]
	private void OnReceiveBattlePassPaidNotify(IMessage msg, Net.CallbackStatus status)
	{
		BattlePassPaidNotify battlePassPaidNotify = (BattlePassPaidNotify)msg;
		if (!BattlePassModel.Instance.GetInTimeRange())
		{
			return;
		}
		BattlePassPayStatus payType = BattlePassModel.Instance.PayType;
		BattlePassModel.Instance.PayType = battlePassPaidNotify.PayStatus;
		EBattlePassUnlockType ebattlePassUnlockType = (battlePassPaidNotify.PayStatus == BattlePassPayStatus.Paid) ? EBattlePassUnlockType.Primary : EBattlePassUnlockType.Upgrade;
		if (payType == BattlePassPayStatus.NoPaid && payType != battlePassPaidNotify.PayStatus)
		{
			BattlePassModel.Instance.UpdateRewardDataFormFreeToPay();
			ebattlePassUnlockType = ((ebattlePassUnlockType == EBattlePassUnlockType.Upgrade) ? EBattlePassUnlockType.High : ebattlePassUnlockType);
		}
		EventSystem.Instance.Emit(EEventName.ReceiveBattlePassDataEvent);
		EventSystem.Instance.Emit(EEventName.OnReceiveBattlePassPaid);
		UiManager.Instance.OpenView(EUiViewName.BattlePassUnlockView, ebattlePassUnlockType, null);
	}

	// Token: 0x0600F128 RID: 61736 RVA: 0x0046D6FC File Offset: 0x0046B8FC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BattlePassTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveBattlePassTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.BattlePassExpUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveBattlePassExpUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.BattlePassPaidNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveBattlePassPaidNotify));
	}

	// Token: 0x0600F129 RID: 61737 RVA: 0x0046D75D File Offset: 0x0046B95D
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BattlePassTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BattlePassExpUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BattlePassPaidNotify);
	}

	// Token: 0x0600F12A RID: 61738 RVA: 0x0046D78F File Offset: 0x0046B98F
	private void OnFunctionUnlock(EFunctionType functionType, bool isOpen)
	{
		if (functionType == EFunctionType.BattlePass && isOpen)
		{
			this.RequestBattlePassDataForTask();
		}
	}

	// Token: 0x0600F12B RID: 61739 RVA: 0x0046D7A3 File Offset: 0x0046B9A3
	private void OnEnterGameSuccess()
	{
		if (!FunctionModel.Instance.IsOpen(10040))
		{
			return;
		}
		this.RequestBattlePassDataForTask();
	}

	// Token: 0x0600F12C RID: 61740 RVA: 0x0046D7BD File Offset: 0x0046B9BD
	private void OnDayCross()
	{
		if (!FunctionModel.Instance.IsOpen(10040) || !BattlePassModel.Instance.GetInTimeRange())
		{
			return;
		}
		this.RequestBattlePassTask();
	}

	// Token: 0x0600F12D RID: 61741 RVA: 0x0046D7E3 File Offset: 0x0046B9E3
	private void StartBattlePassTimer()
	{
		if (this.BattlePassTimer != null)
		{
			return;
		}
		this.BattlePassTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			if (TimeUtil.Instance.GetServerTime() >= (double)BattlePassModel.Instance.GetBattlePassEndTime())
			{
				BattlePassModel.Instance.SetInTimeRange(false);
				EventSystem.Instance.Emit<bool>(EEventName.ReceiveBattlePassTaskEvent, false);
				EventSystem.Instance.Emit(EEventName.ReceiveBattlePassDataEvent);
				EventSystem.Instance.Emit(EEventName.BattlePassHadEnterUpdate);
				EventSystem.Instance.Emit(EEventName.OnBattlePassExpireEvent);
				this.StopBattlePassTimer();
			}
		}, 500f, 1f, null, null, true);
	}

	// Token: 0x0600F12E RID: 61742 RVA: 0x0046D818 File Offset: 0x0046BA18
	public void ShowTimePassConfirm()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattlePassExpireTip);
		confirmBoxDataNew.SetCloseFunction(delegate
		{
			UiManager.Instance.ResetToBattleView(null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600F12F RID: 61743 RVA: 0x0046D861 File Offset: 0x0046BA61
	private void StopBattlePassTimer()
	{
		if (this.BattlePassTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.BattlePassTimer);
			this.BattlePassTimer = null;
		}
	}

	// Token: 0x0600F130 RID: 61744 RVA: 0x0046D884 File Offset: 0x0046BA84
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionUnlock));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnDayCross));
	}

	// Token: 0x0600F131 RID: 61745 RVA: 0x0046D8E8 File Offset: 0x0046BAE8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionUnlock));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnDayCross));
	}

	// Token: 0x0600F132 RID: 61746 RVA: 0x0046D94C File Offset: 0x0046BB4C
	public bool TryShowUpLevelView(bool firstBuy)
	{
		if (BattlePassModel.Instance.IncreasedLevelToShow <= 0 || UiManager.Instance.IsViewOpen(EUiViewName.BattlePassUnlockView))
		{
			return false;
		}
		BattlePassUpLevelViewData param = new BattlePassUpLevelViewData
		{
			IncreasedLevel = BattlePassModel.Instance.IncreasedLevelToShow,
			FirstUnlockPass = firstBuy
		};
		UiManager.Instance.OpenView(EUiViewName.BattlePassUpLevelView, param, null);
		return true;
	}

	// Token: 0x0600F133 RID: 61747 RVA: 0x0046D9A8 File Offset: 0x0046BBA8
	public void PopHighUnlockReward()
	{
		int value = ConfigCommonParamById.GetIntConfig("PrimaryBattlePassGiftPack").Value;
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (KeyValuePair<int, int> keyValuePair in GiftPackageConfig.Instance.GetGiftPackageConfig(value).Value.Content())
		{
			list.Add(new RewardItemData(keyValuePair.Key, keyValuePair.Value, null, EDropItemType.Normal));
		}
		ItemRewardController.Instance.OpenCommonRewardView(1009, list, delegate
		{
			this.TryShowUpLevelView(true);
		});
	}

	// Token: 0x0600F134 RID: 61748 RVA: 0x0046DA64 File Offset: 0x0046BC64
	public void PayPrimaryBattlePass()
	{
		if (FeatureRestrictionTemplate.TemplateForPioneerClient.Check())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BetaDisableCharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		int primaryBattlePassGoodsId = BattlePassModel.Instance.GetPrimaryBattlePassGoodsId();
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(primaryBattlePassGoodsId);
		if (payShopGoodsById == null || !payShopGoodsById.InSellTime())
		{
			GenericPromptController.Instance.ShowPromptByCode("BattlePassShopNotInTime", Array.Empty<object>());
			return;
		}
		if (this.PayInWarningTime(primaryBattlePassGoodsId))
		{
			return;
		}
		PayGiftController.Instance.SdkPay(payShopGoodsById.GetGoodsData().Id);
	}

	// Token: 0x0600F135 RID: 61749 RVA: 0x0046DAEC File Offset: 0x0046BCEC
	public void PayHighBattlePass()
	{
		if (FeatureRestrictionTemplate.TemplateForPioneerClient.Check())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BetaDisableCharge);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		BattlePassPayStatus payType = BattlePassModel.Instance.PayType;
		if (payType != BattlePassPayStatus.NoPaid)
		{
			if (payType == BattlePassPayStatus.Paid)
			{
				int supplyBattlePassGoodsId = BattlePassModel.Instance.GetSupplyBattlePassGoodsId();
				PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(supplyBattlePassGoodsId);
				if (payShopGoodsById == null || !payShopGoodsById.InSellTime())
				{
					GenericPromptController.Instance.ShowPromptByCode("BattlePassShopNotInTime", Array.Empty<object>());
					return;
				}
				PayGiftController.Instance.SdkPay(supplyBattlePassGoodsId);
			}
			return;
		}
		int highBattlePassGoodsId = BattlePassModel.Instance.GetHighBattlePassGoodsId();
		PayShopGoods payShopGoodsById2 = PayGiftModel.Instance.GetPayShopGoodsById(highBattlePassGoodsId);
		if (payShopGoodsById2 == null || !payShopGoodsById2.InSellTime())
		{
			GenericPromptController.Instance.ShowPromptByCode("BattlePassShopNotInTime", Array.Empty<object>());
			return;
		}
		if (this.PayInWarningTime(highBattlePassGoodsId))
		{
			return;
		}
		PayGiftController.Instance.SdkPay(highBattlePassGoodsId);
	}

	// Token: 0x0600F136 RID: 61750 RVA: 0x0046DBC4 File Offset: 0x0046BDC4
	private bool PayInWarningTime(int id)
	{
		BattlePassController.<>c__DisplayClass32_0 CS$<>8__locals1 = new BattlePassController.<>c__DisplayClass32_0();
		CS$<>8__locals1.id = id;
		if (BattlePassModel.Instance.InBattlePassInWarningTime())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattlePassTimeWarning);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<PayInWarningTime>g__ConfirmCallback|0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return true;
		}
		return false;
	}

	// Token: 0x0600F137 RID: 61751 RVA: 0x0046DC1C File Offset: 0x0046BE1C
	public void CloseView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.BattlePassFirstOpenView))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.BattlePassMainView, null);
	}

	// Token: 0x0600F138 RID: 61752 RVA: 0x0046DC40 File Offset: 0x0046BE40
	public RewardData<IBattlePassExtraRewardInfo> BuildExtraRewardData(List<RewardItemData> rewardItemDataList)
	{
		RewardItemData[] extraRewardItems = BattlePassModel.Instance.GetExtraRewardItems();
		BattlePassExtraRewardInfo battlePassExtraRewardInfo = new BattlePassExtraRewardInfo();
		battlePassExtraRewardInfo.Type = ERewardInfoType.BattlePassExtra;
		battlePassExtraRewardInfo.ViewName = EUiViewName.BattlePassExtraRewardView;
		battlePassExtraRewardInfo.CommonItems = rewardItemDataList;
		battlePassExtraRewardInfo.ExtraItems = new List<RewardItemData>(extraRewardItems);
		battlePassExtraRewardInfo.LeftAction = delegate()
		{
			EventSystem.Instance.Emit(EEventName.NotifyBattlePassToBuyEvent);
		};
		battlePassExtraRewardInfo.RightAction = delegate()
		{
		};
		return new RewardData<IBattlePassExtraRewardInfo>(battlePassExtraRewardInfo, null);
	}

	// Token: 0x0600F139 RID: 61753 RVA: 0x0046DCD4 File Offset: 0x0046BED4
	public bool IsNeedExtraRewardView()
	{
		BattlePassModel instance = BattlePassModel.Instance;
		return instance != null && instance.RemindLevel != null;
	}

	// Token: 0x170016EF RID: 5871
	// (get) Token: 0x0600F13A RID: 61754 RVA: 0x0046DCF9 File Offset: 0x0046BEF9
	public static BattlePassController Instance
	{
		get
		{
			return BattlePassController._Instance;
		}
	}

	// Token: 0x0600F13B RID: 61755 RVA: 0x0046DD00 File Offset: 0x0046BF00
	public static BattlePassController GetOrCreateInstance()
	{
		if (BattlePassController._Instance == null)
		{
			BattlePassController.CreateInstance();
		}
		return BattlePassController._Instance;
	}

	// Token: 0x0600F13C RID: 61756 RVA: 0x0046DD14 File Offset: 0x0046BF14
	public static bool CreateInstance()
	{
		if (BattlePassController._Instance != null)
		{
			return true;
		}
		BattlePassController._Instance = new BattlePassController();
		return true;
	}

	// Token: 0x0600F13D RID: 61757 RVA: 0x0046DD2A File Offset: 0x0046BF2A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F13E RID: 61758 RVA: 0x0046DD2C File Offset: 0x0046BF2C
	public static void ResetStaticDefaultValue()
	{
		BattlePassController._Instance = null;
	}

	// Token: 0x0600F13F RID: 61759 RVA: 0x0046DD34 File Offset: 0x0046BF34
	static BattlePassController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattlePassController.CreateStaticDefaultValue), new Action(BattlePassController.ResetStaticDefaultValue));
	}

	// Token: 0x0600F141 RID: 61761 RVA: 0x0046DD5C File Offset: 0x0046BF5C
	[NullableContext(2)]
	[CompilerGenerated]
	private void <RequestBattlePassDataForTask>g__Response|5_0(IMessage msg, Net.CallbackStatus _)
	{
		BattlePassResponse battlePassResponse = (BattlePassResponse)msg;
		if (battlePassResponse == null)
		{
			return;
		}
		if (battlePassResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			BattlePassModel.Instance.SetDataFromBattlePassResponse(battlePassResponse);
			if (BattlePassModel.Instance.GetInTimeRange())
			{
				this.RequestBattlePassTask();
			}
			this.StartBattlePassTimer();
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(battlePassResponse.ErrorCode, 26557, null, true, true);
	}

	// Token: 0x0600F142 RID: 61762 RVA: 0x0046DDB8 File Offset: 0x0046BFB8
	[CompilerGenerated]
	internal static void <RequestTakeAllRewardResponse>g__ResponseAction|10_0(BattlePassTakeAllRewardResponse response, [Nullable(2)] Net.CallbackStatus _)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			BattlePassModel.Instance.UpdateRewardDataFromBattlePassTakeAllRewardResponse(response);
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 27259, null, true, true);
	}

	// Token: 0x0600F143 RID: 61763 RVA: 0x0046DDEC File Offset: 0x0046BFEC
	[CompilerGenerated]
	internal static void <RequestBattlePassTask>g__ResponseAction|11_0(BattlePassTaskResponse response, [Nullable(2)] Net.CallbackStatus _)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			BattlePassModel.Instance.BattlePassTaskMap.Clear();
			foreach (PbBattlePassTask task in response.Tasks)
			{
				BattlePassModel.Instance.AddTaskDataFromProtocol(task);
			}
			bool p = BattlePassModel.Instance.GetWeekEndTime() != response.WeekEnd;
			BattlePassModel.Instance.SetWeekEndTime(response.WeekEnd);
			BattlePassModel.Instance.SetDayEndTime(response.DayEnd);
			EventSystem.Instance.Emit<bool>(EEventName.ReceiveBattlePassTaskEvent, p);
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 27662, null, true, true);
	}

	// Token: 0x0600F144 RID: 61764 RVA: 0x0046DEBC File Offset: 0x0046C0BC
	[CompilerGenerated]
	internal static void <RequestBattlePassTaskTake>g__ResponseAction|13_0(BattlePassTaskTakeResponse response, [Nullable(2)] Net.CallbackStatus _)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			BattlePassModel.Instance.UpdateTaskDataFromBattlePassTaskTakeResponse(response.Ids);
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 17148, null, true, true);
	}

	// Token: 0x0400881C RID: 34844
	[Nullable(2)]
	private TimerHandle BattlePassTimer;

	// Token: 0x0400881D RID: 34845
	[Nullable(2)]
	private static BattlePassController _Instance;
}
