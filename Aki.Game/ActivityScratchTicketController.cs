using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020014DF RID: 5343
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityScratchTicketController : ActivityControllerBase
{
	// Token: 0x0600982D RID: 38957 RVA: 0x0020E57C File Offset: 0x0020C77C
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600982E RID: 38958 RVA: 0x0020E57E File Offset: 0x0020C77E
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ScratchoffTicketMain";
	}

	// Token: 0x0600982F RID: 38959 RVA: 0x0020E585 File Offset: 0x0020C785
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ScratchTicketActivityView();
	}

	// Token: 0x06009830 RID: 38960 RVA: 0x0020E58C File Offset: 0x0020C78C
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		ScratchTicketData scratchTicketData = new ScratchTicketData();
		ActivityScratchTicketModel.Instance.SetScratchTicketData(scratchTicketData);
		return scratchTicketData;
	}

	// Token: 0x06009831 RID: 38961 RVA: 0x0020E5AB File Offset: 0x0020C7AB
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009832 RID: 38962 RVA: 0x0020E5B0 File Offset: 0x0020C7B0
	[NullableContext(0)]
	public static UniTask<bool> OpenScratchTicketMainView()
	{
		ActivityScratchTicketController.<OpenScratchTicketMainView>d__5 <OpenScratchTicketMainView>d__;
		<OpenScratchTicketMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenScratchTicketMainView>d__.<>1__state = -1;
		<OpenScratchTicketMainView>d__.<>t__builder.Start<ActivityScratchTicketController.<OpenScratchTicketMainView>d__5>(ref <OpenScratchTicketMainView>d__);
		return <OpenScratchTicketMainView>d__.<>t__builder.Task;
	}

	// Token: 0x06009833 RID: 38963 RVA: 0x0020E5EB File Offset: 0x0020C7EB
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ScratchCardCountInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnScratchCardCountInfoNotify));
	}

	// Token: 0x06009834 RID: 38964 RVA: 0x0020E609 File Offset: 0x0020C809
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ScratchCardCountInfoNotify);
	}

	// Token: 0x06009835 RID: 38965 RVA: 0x0020E61B File Offset: 0x0020C81B
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06009836 RID: 38966 RVA: 0x0020E639 File Offset: 0x0020C839
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06009837 RID: 38967 RVA: 0x0020E658 File Offset: 0x0020C858
	[NullableContext(2)]
	private void OnScratchCardCountInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		ScratchCardCountInfoNotify message = (ScratchCardCountInfoNotify)msg;
		ActivityScratchTicketModel.Instance.OnScratchCardCountInfoNotify(message);
	}

	// Token: 0x06009838 RID: 38968 RVA: 0x0020E678 File Offset: 0x0020C878
	public void SendScratchCardRewardRequest(int roundId, int index, Action<EScratchTicketRewardType, int, List<ScratchTicketRoundResult>, List<RewardItemData>> callback)
	{
		ScratchCardRewardRequest scratchCardRewardRequest = ScratchCardRewardRequest.Create();
		scratchCardRewardRequest.RoundId = roundId;
		scratchCardRewardRequest.Index = index;
		Net.Instance.Call(ERequestMessageId.ScratchCardRewardRequest, scratchCardRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ScratchCardRewardResponse scratchCardRewardResponse = (ScratchCardRewardResponse)msg;
			if (scratchCardRewardResponse == null)
			{
				return;
			}
			if (scratchCardRewardResponse.Error != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(scratchCardRewardResponse.Error, 18651, null, true, true);
				return;
			}
			ActivityScratchTicketModel.Instance.OnScratchCardRewardResponse(index, roundId, scratchCardRewardResponse, callback);
		}, 0);
	}

	// Token: 0x06009839 RID: 38969 RVA: 0x0020E6DC File Offset: 0x0020C8DC
	[NullableContext(0)]
	public UniTask<bool> SendScratchCardActivityInfoRequest()
	{
		ActivityScratchTicketController.<SendScratchCardActivityInfoRequest>d__12 <SendScratchCardActivityInfoRequest>d__;
		<SendScratchCardActivityInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendScratchCardActivityInfoRequest>d__.<>1__state = -1;
		<SendScratchCardActivityInfoRequest>d__.<>t__builder.Start<ActivityScratchTicketController.<SendScratchCardActivityInfoRequest>d__12>(ref <SendScratchCardActivityInfoRequest>d__);
		return <SendScratchCardActivityInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600983A RID: 38970 RVA: 0x0020E718 File Offset: 0x0020C918
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		ScratchTicketData scratchTicketData = ActivityScratchTicketModel.Instance.GetScratchTicketData();
		if (scratchTicketData == null)
		{
			return;
		}
		if (configId != scratchTicketData.GetCostItemId())
		{
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, scratchTicketData.Id);
	}

	// Token: 0x0600983B RID: 38971 RVA: 0x0020E754 File Offset: 0x0020C954
	public void ShowScratchTicketRewardTip(List<RewardItemData> rewardItemDataList)
	{
		if (rewardItemDataList.Count < 1)
		{
			return;
		}
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(rewardItemDataList[0].ConfigId);
		if (itemConfigData == null)
		{
			return;
		}
		string text = itemConfigData.IconSmall + "/";
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
		QualityInfo? itemQualityConfig = InventoryConfig.Instance.GetItemQualityConfig(itemConfigData.QualityId);
		GenericPromptController.Instance.ShowPromptByCode("ScratchCardRewardTips", new object[]
		{
			text,
			itemQualityConfig.Value.TextColor,
			localTextNew,
			rewardItemDataList[0].Count.ToString()
		});
	}

	// Token: 0x17000D1D RID: 3357
	// (get) Token: 0x0600983C RID: 38972 RVA: 0x0020E7F9 File Offset: 0x0020C9F9
	public static ActivityScratchTicketController Instance
	{
		get
		{
			return ActivityScratchTicketController._Instance;
		}
	}

	// Token: 0x0600983D RID: 38973 RVA: 0x0020E800 File Offset: 0x0020CA00
	public static ActivityScratchTicketController GetOrCreateInstance()
	{
		if (ActivityScratchTicketController._Instance == null)
		{
			ActivityScratchTicketController.CreateInstance();
		}
		return ActivityScratchTicketController._Instance;
	}

	// Token: 0x0600983E RID: 38974 RVA: 0x0020E814 File Offset: 0x0020CA14
	public static bool CreateInstance()
	{
		if (ActivityScratchTicketController._Instance != null)
		{
			return true;
		}
		ActivityScratchTicketController._Instance = new ActivityScratchTicketController();
		return true;
	}

	// Token: 0x0600983F RID: 38975 RVA: 0x0020E82A File Offset: 0x0020CA2A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009840 RID: 38976 RVA: 0x0020E82C File Offset: 0x0020CA2C
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketController._Instance = null;
	}

	// Token: 0x06009841 RID: 38977 RVA: 0x0020E834 File Offset: 0x0020CA34
	static ActivityScratchTicketController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketController.CreateStaticDefaultValue), new Action(ActivityScratchTicketController.ResetStaticDefaultValue));
	}

	// Token: 0x040042E9 RID: 17129
	[Nullable(2)]
	private static ActivityScratchTicketController _Instance;
}
