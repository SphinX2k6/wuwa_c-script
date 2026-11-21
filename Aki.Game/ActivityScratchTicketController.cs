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

// Token: 0x02000997 RID: 2455
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityScratchTicketController : ActivityControllerBase
{
	// Token: 0x06006C07 RID: 27655 RVA: 0x002182BC File Offset: 0x002164BC
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006C08 RID: 27656 RVA: 0x002182BE File Offset: 0x002164BE
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ScratchoffTicketMain";
	}

	// Token: 0x06006C09 RID: 27657 RVA: 0x002182C5 File Offset: 0x002164C5
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ScratchTicketActivityView();
	}

	// Token: 0x06006C0A RID: 27658 RVA: 0x002182CC File Offset: 0x002164CC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		ScratchTicketData scratchTicketData = new ScratchTicketData();
		ActivityScratchTicketModel.Instance.SetScratchTicketData(scratchTicketData);
		return scratchTicketData;
	}

	// Token: 0x06006C0B RID: 27659 RVA: 0x002182EB File Offset: 0x002164EB
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006C0C RID: 27660 RVA: 0x002182F0 File Offset: 0x002164F0
	[NullableContext(0)]
	public static UniTask<bool> OpenScratchTicketMainView()
	{
		ActivityScratchTicketController.<OpenScratchTicketMainView>d__5 <OpenScratchTicketMainView>d__;
		<OpenScratchTicketMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenScratchTicketMainView>d__.<>1__state = -1;
		<OpenScratchTicketMainView>d__.<>t__builder.Start<ActivityScratchTicketController.<OpenScratchTicketMainView>d__5>(ref <OpenScratchTicketMainView>d__);
		return <OpenScratchTicketMainView>d__.<>t__builder.Task;
	}

	// Token: 0x06006C0D RID: 27661 RVA: 0x0021832B File Offset: 0x0021652B
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ScratchCardCountInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnScratchCardCountInfoNotify));
	}

	// Token: 0x06006C0E RID: 27662 RVA: 0x00218349 File Offset: 0x00216549
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ScratchCardCountInfoNotify);
	}

	// Token: 0x06006C0F RID: 27663 RVA: 0x0021835B File Offset: 0x0021655B
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06006C10 RID: 27664 RVA: 0x00218379 File Offset: 0x00216579
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06006C11 RID: 27665 RVA: 0x00218398 File Offset: 0x00216598
	[NullableContext(2)]
	private void OnScratchCardCountInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		ScratchCardCountInfoNotify message = (ScratchCardCountInfoNotify)msg;
		ActivityScratchTicketModel.Instance.OnScratchCardCountInfoNotify(message);
	}

	// Token: 0x06006C12 RID: 27666 RVA: 0x002183B8 File Offset: 0x002165B8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(scratchCardRewardResponse.Error, 15806, null, true, true);
				return;
			}
			ActivityScratchTicketModel.Instance.OnScratchCardRewardResponse(index, roundId, scratchCardRewardResponse, callback);
		}, 0);
	}

	// Token: 0x06006C13 RID: 27667 RVA: 0x0021841C File Offset: 0x0021661C
	[NullableContext(0)]
	public UniTask<bool> SendScratchCardActivityInfoRequest()
	{
		ActivityScratchTicketController.<SendScratchCardActivityInfoRequest>d__12 <SendScratchCardActivityInfoRequest>d__;
		<SendScratchCardActivityInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendScratchCardActivityInfoRequest>d__.<>1__state = -1;
		<SendScratchCardActivityInfoRequest>d__.<>t__builder.Start<ActivityScratchTicketController.<SendScratchCardActivityInfoRequest>d__12>(ref <SendScratchCardActivityInfoRequest>d__);
		return <SendScratchCardActivityInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06006C14 RID: 27668 RVA: 0x00218458 File Offset: 0x00216658
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

	// Token: 0x06006C15 RID: 27669 RVA: 0x00218494 File Offset: 0x00216694
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

	// Token: 0x17000D3E RID: 3390
	// (get) Token: 0x06006C16 RID: 27670 RVA: 0x00218539 File Offset: 0x00216739
	public static ActivityScratchTicketController Instance
	{
		get
		{
			return ActivityScratchTicketController._Instance;
		}
	}

	// Token: 0x06006C17 RID: 27671 RVA: 0x00218540 File Offset: 0x00216740
	public static ActivityScratchTicketController GetOrCreateInstance()
	{
		if (ActivityScratchTicketController._Instance == null)
		{
			ActivityScratchTicketController.CreateInstance();
		}
		return ActivityScratchTicketController._Instance;
	}

	// Token: 0x06006C18 RID: 27672 RVA: 0x00218554 File Offset: 0x00216754
	public static bool CreateInstance()
	{
		if (ActivityScratchTicketController._Instance != null)
		{
			return true;
		}
		ActivityScratchTicketController._Instance = new ActivityScratchTicketController();
		return true;
	}

	// Token: 0x06006C19 RID: 27673 RVA: 0x0021856A File Offset: 0x0021676A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006C1A RID: 27674 RVA: 0x0021856C File Offset: 0x0021676C
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketController._Instance = null;
	}

	// Token: 0x06006C1B RID: 27675 RVA: 0x00218574 File Offset: 0x00216774
	static ActivityScratchTicketController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketController.CreateStaticDefaultValue), new Action(ActivityScratchTicketController.ResetStaticDefaultValue));
	}

	// Token: 0x0400438E RID: 17294
	[Nullable(2)]
	private static ActivityScratchTicketController _Instance;
}
