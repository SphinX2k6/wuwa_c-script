using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x0200231F RID: 8991
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BattlePassController : UiControllerBase
{
	// Token: 0x06011C67 RID: 72807 RVA: 0x004601E6 File Offset: 0x0045E3E6
	protected override bool OnInit()
	{
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.BattlePassMainView, new Action(this.RegisterOpenView));
		InputManager.Instance.RegisterCloseViewFunc(EUiViewName.BattlePassMainView, new Action(this.RegisterCloseView));
		return true;
	}

	// Token: 0x06011C68 RID: 72808 RVA: 0x0046021F File Offset: 0x0045E41F
	protected override bool OnClear()
	{
		this.StopBattlePassTimer();
		return true;
	}

	// Token: 0x06011C69 RID: 72809 RVA: 0x00460228 File Offset: 0x0045E428
	private void RegisterOpenView()
	{
		this.OpenBattlePassView();
	}

	// Token: 0x06011C6A RID: 72810 RVA: 0x00460230 File Offset: 0x0045E430
	private void RegisterCloseView()
	{
		this.CloseView();
	}

	// Token: 0x06011C6B RID: 72811 RVA: 0x00460238 File Offset: 0x0045E438
	public void RequestBattlePassDataForTask()
	{
		BattlePassRequest message = BattlePassRequest.Create();
		Net.Instance.Call(ERequestMessageId.BattlePassRequest, message, new Action<IMessage, Net.CallbackStatus>(this.<RequestBattlePassDataForTask>g__Response|5_0), 0);
	}

	// Token: 0x06011C6C RID: 72812 RVA: 0x00460268 File Offset: 0x0045E468
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

	// Token: 0x06011C6D RID: 72813 RVA: 0x004602D4 File Offset: 0x0045E4D4
	private UniTask DoOpenBattlePassView()
	{
		BattlePassController.<DoOpenBattlePassView>d__7 <DoOpenBattlePassView>d__;
		<DoOpenBattlePassView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DoOpenBattlePassView>d__.<>1__state = -1;
		<DoOpenBattlePassView>d__.<>t__builder.Start<BattlePassController.<DoOpenBattlePassView>d__7>(ref <DoOpenBattlePassView>d__);
		return <DoOpenBattlePassView>d__.<>t__builder.Task;
	}

	// Token: 0x06011C6E RID: 72814 RVA: 0x00460310 File Offset: 0x0045E510
	public void SetBattlePassEnter()
	{
		BattlePassEnterPush message = BattlePassEnterPush.Create();
		Net.Instance.Send(EPushMessageId.BattlePassEnterPush, message);
		BattlePassModel.Instance.HadEnter = true;
	}

	// Token: 0x06011C6F RID: 72815 RVA: 0x00460340 File Offset: 0x0045E540
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

	// Token: 0x06011C70 RID: 72816 RVA: 0x004603D4 File Offset: 0x0045E5D4
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

	// Token: 0x06011C71 RID: 72817 RVA: 0x00460430 File Offset: 0x0045E630
	public void RequestBattlePassTask()
	{
		BattlePassTaskRequest message = BattlePassTaskRequest.Create();
		Net.Instance.Call(ERequestMessageId.BattlePassTaskRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			BattlePassController.<RequestBattlePassTask>g__ResponseAction|11_0((BattlePassTaskResponse)msg, status);
		}, 0);
	}

	// Token: 0x06011C72 RID: 72818 RVA: 0x00460473 File Offset: 0x0045E673
	public void TryRequestTaskList(List<int> taskIdList)
	{
		BattlePassModel.Instance.TryRequestTaskList(taskIdList);
	}

	// Token: 0x06011C73 RID: 72819 RVA: 0x00460480 File Offset: 0x0045E680
	public void RequestBattlePassTaskTake(List<int> taskIdList)
	{
		BattlePassTaskTakeRequest battlePassTaskTakeRequest = BattlePassTaskTakeRequest.Create();
		battlePassTaskTakeRequest.Ids.AddRange(taskIdList);
		Net.Instance.Call(ERequestMessageId.BattlePassTaskTakeRequest, battlePassTaskTakeRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			BattlePassController.<RequestBattlePassTaskTake>g__ResponseAction|13_0((BattlePassTaskTakeResponse)msg, status);
		}, 0);
	}

	// Token: 0x06011C74 RID: 72820 RVA: 0x004604D0 File Offset: 0x0045E6D0
	public void RequestBuyBattlePassLevel(int level)
	{
		BattlePassLevelUpRequest battlePassLevelUpRequest = BattlePassLevelUpRequest.Create();
		battlePassLevelUpRequest.Level = level;
		Net.Instance.Call(ERequestMessageId.BattlePassLevelUpRequest, battlePassLevelUpRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x06011C75 RID: 72821 RVA: 0x0046051C File Offset: 0x0045E71C
	[NullableContext(2)]
	private void OnReceiveBattlePassTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (PbBattlePassTask task in ((BattlePassTaskUpdateNotify)msg).Tasks)
		{
			BattlePassModel.Instance.AddTaskDataFromProtocol(task);
		}
		EventSystem.Instance.Emit(EEventName.UpdateBattlePassTaskEvent);
	}

	// Token: 0x06011C76 RID: 72822 RVA: 0x00460584 File Offset: 0x0045E784
	[NullableContext(2)]
	private void OnReceiveBattlePassExpUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		BattlePassExpUpdateNotify battlePassExpUpdateNotify = (BattlePassExpUpdateNotify)msg;
		BattlePassModel.Instance.UpdateExpDataFromBattlePassExpUpdateNotify(battlePassExpUpdateNotify.Level, battlePassExpUpdateNotify.Exp, battlePassExpUpdateNotify.WeeklyTotalExp);
	}

	// Token: 0x06011C77 RID: 72823 RVA: 0x004605B4 File Offset: 0x0045E7B4
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

	// Token: 0x06011C78 RID: 72824 RVA: 0x00460654 File Offset: 0x0045E854
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BattlePassTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveBattlePassTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.BattlePassExpUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveBattlePassExpUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.BattlePassPaidNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveBattlePassPaidNotify));
	}

	// Token: 0x06011C79 RID: 72825 RVA: 0x004606B5 File Offset: 0x0045E8B5
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BattlePassTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BattlePassExpUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BattlePassPaidNotify);
	}

	// Token: 0x06011C7A RID: 72826 RVA: 0x004606E7 File Offset: 0x0045E8E7
	private void OnFunctionUnlock(EFunctionType functionType, bool isOpen)
	{
		if (functionType == EFunctionType.BattlePass && isOpen)
		{
			this.RequestBattlePassDataForTask();
		}
	}

	// Token: 0x06011C7B RID: 72827 RVA: 0x004606FB File Offset: 0x0045E8FB
	private void OnEnterGameSuccess()
	{
		if (!FunctionModel.Instance.IsOpen(10040))
		{
			return;
		}
		this.RequestBattlePassDataForTask();
	}

	// Token: 0x06011C7C RID: 72828 RVA: 0x00460715 File Offset: 0x0045E915
	private void OnDayCross()
	{
		if (!FunctionModel.Instance.IsOpen(10040) || !BattlePassModel.Instance.GetInTimeRange())
		{
			return;
		}
		this.RequestBattlePassTask();
	}

	// Token: 0x06011C7D RID: 72829 RVA: 0x0046073B File Offset: 0x0045E93B
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

	// Token: 0x06011C7E RID: 72830 RVA: 0x00460770 File Offset: 0x0045E970
	public void ShowTimePassConfirm()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattlePassExpireTip);
		confirmBoxDataNew.SetCloseFunction(delegate
		{
			UiManager.Instance.ResetToBattleView(null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06011C7F RID: 72831 RVA: 0x004607B9 File Offset: 0x0045E9B9
	private void StopBattlePassTimer()
	{
		if (this.BattlePassTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.BattlePassTimer);
			this.BattlePassTimer = null;
		}
	}

	// Token: 0x06011C80 RID: 72832 RVA: 0x004607DC File Offset: 0x0045E9DC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionUnlock));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnDayCross));
	}

	// Token: 0x06011C81 RID: 72833 RVA: 0x00460840 File Offset: 0x0045EA40
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnEnterGameSuccess));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionUnlock));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnDayCross));
	}

	// Token: 0x06011C82 RID: 72834 RVA: 0x004608A4 File Offset: 0x0045EAA4
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

	// Token: 0x06011C83 RID: 72835 RVA: 0x00460900 File Offset: 0x0045EB00
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

	// Token: 0x06011C84 RID: 72836 RVA: 0x004609BC File Offset: 0x0045EBBC
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

	// Token: 0x06011C85 RID: 72837 RVA: 0x00460A44 File Offset: 0x0045EC44
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

	// Token: 0x06011C86 RID: 72838 RVA: 0x00460B1C File Offset: 0x0045ED1C
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

	// Token: 0x06011C87 RID: 72839 RVA: 0x00460B74 File Offset: 0x0045ED74
	public void CloseView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.BattlePassFirstOpenView))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.BattlePassMainView, null);
	}

	// Token: 0x06011C88 RID: 72840 RVA: 0x00460B98 File Offset: 0x0045ED98
	public RewardData<IBattlePassExtraRewardInfo> BuildExtraRewardData(List<RewardItemData> rewardItemDataList)
	{
		RewardItemData[] extraRewardItems = BattlePassModel.Instance.GetExtraRewardItems();
		BattlePassExtraRewardInfo battlePassExtraRewardInfo = new BattlePassExtraRewardInfo();
		battlePassExtraRewardInfo.Type = ERewardInfoType.BattlePassExtra;
		battlePassExtraRewardInfo.ViewName = EUiViewName.BattlePassExtraRewardView;
		battlePassExtraRewardInfo.CommonItems = rewardItemDataList;
		battlePassExtraRewardInfo.ExtraItems = extraRewardItems.ToList<RewardItemData>();
		battlePassExtraRewardInfo.LeftAction = delegate()
		{
			EventSystem.Instance.Emit(EEventName.NotifyBattlePassToBuyEvent);
		};
		battlePassExtraRewardInfo.RightAction = delegate()
		{
		};
		return new RewardData<IBattlePassExtraRewardInfo>(battlePassExtraRewardInfo, null);
	}

	// Token: 0x06011C89 RID: 72841 RVA: 0x00460C2C File Offset: 0x0045EE2C
	public bool IsNeedExtraRewardView()
	{
		BattlePassModel instance = BattlePassModel.Instance;
		return instance != null && instance.RemindLevel != null;
	}

	// Token: 0x170016B5 RID: 5813
	// (get) Token: 0x06011C8A RID: 72842 RVA: 0x00460C51 File Offset: 0x0045EE51
	public static BattlePassController Instance
	{
		get
		{
			return BattlePassController._Instance;
		}
	}

	// Token: 0x06011C8B RID: 72843 RVA: 0x00460C58 File Offset: 0x0045EE58
	public static BattlePassController GetOrCreateInstance()
	{
		if (BattlePassController._Instance == null)
		{
			BattlePassController.CreateInstance();
		}
		return BattlePassController._Instance;
	}

	// Token: 0x06011C8C RID: 72844 RVA: 0x00460C6C File Offset: 0x0045EE6C
	public static bool CreateInstance()
	{
		if (BattlePassController._Instance != null)
		{
			return true;
		}
		BattlePassController._Instance = new BattlePassController();
		return true;
	}

	// Token: 0x06011C8D RID: 72845 RVA: 0x00460C82 File Offset: 0x0045EE82
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011C8E RID: 72846 RVA: 0x00460C84 File Offset: 0x0045EE84
	public static void ResetStaticDefaultValue()
	{
		BattlePassController._Instance = null;
	}

	// Token: 0x06011C8F RID: 72847 RVA: 0x00460C8C File Offset: 0x0045EE8C
	static BattlePassController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattlePassController.CreateStaticDefaultValue), new Action(BattlePassController.ResetStaticDefaultValue));
	}

	// Token: 0x06011C91 RID: 72849 RVA: 0x00460CB4 File Offset: 0x0045EEB4
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
		ErrorCodeController.Instance.OpenErrorCodeTipView(battlePassResponse.ErrorCode, 26818, null, true, true);
	}

	// Token: 0x06011C92 RID: 72850 RVA: 0x00460D10 File Offset: 0x0045EF10
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
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 28865, null, true, true);
	}

	// Token: 0x06011C93 RID: 72851 RVA: 0x00460D44 File Offset: 0x0045EF44
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
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 21675, null, true, true);
	}

	// Token: 0x06011C94 RID: 72852 RVA: 0x00460E14 File Offset: 0x0045F014
	[CompilerGenerated]
	internal static void <RequestBattlePassTaskTake>g__ResponseAction|13_0(BattlePassTaskTakeResponse response, [Nullable(2)] Net.CallbackStatus _)
	{
		if (response == null)
		{
			return;
		}
		if (response.ErrorCode == Aki.Protocol.ErrorCode.Success)
		{
			BattlePassModel.Instance.UpdateTaskDataFromBattlePassTaskTakeResponse(response.Ids.ToArray<int>());
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 16270, null, true, true);
	}

	// Token: 0x040086D9 RID: 34521
	[Nullable(2)]
	private TimerHandle BattlePassTimer;

	// Token: 0x040086DA RID: 34522
	[Nullable(2)]
	private static BattlePassController _Instance;
}
