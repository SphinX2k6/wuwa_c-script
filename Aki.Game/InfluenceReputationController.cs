using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001438 RID: 5176
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class InfluenceReputationController : UiControllerBase
{
	// Token: 0x0600CE06 RID: 52742 RVA: 0x003D4AAC File Offset: 0x003D2CAC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.RequestInfluenceInfo));
	}

	// Token: 0x0600CE07 RID: 52743 RVA: 0x003D4ACA File Offset: 0x003D2CCA
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.RequestInfluenceInfo));
	}

	// Token: 0x0600CE08 RID: 52744 RVA: 0x003D4AE8 File Offset: 0x003D2CE8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.InfluenceInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.NotifyInfluenceInfoUpdate));
	}

	// Token: 0x0600CE09 RID: 52745 RVA: 0x003D4B06 File Offset: 0x003D2D06
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.InfluenceInfoUpdateNotify);
	}

	// Token: 0x0600CE0A RID: 52746 RVA: 0x003D4B18 File Offset: 0x003D2D18
	[NullableContext(2)]
	private void NotifyInfluenceInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<OneInfluenceInfo> influenceInfos = ((InfluenceInfoUpdateNotify)msg).InfluenceInfos;
		InfluenceReputationModel.Instance.SetInfluenceInfoList(influenceInfos);
	}

	// Token: 0x0600CE0B RID: 52747 RVA: 0x003D4B3C File Offset: 0x003D2D3C
	public void RequestInfluenceInfo()
	{
		InfluenceInfoRequest message = InfluenceInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.InfluenceInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RepeatedField<OneInfluenceInfo> influenceInfos = ((InfluenceInfoResponse)msg).InfluenceInfos;
			InfluenceReputationModel.Instance.SetInfluenceInfoList(influenceInfos);
		}, 0);
	}

	// Token: 0x0600CE0C RID: 52748 RVA: 0x003D4B80 File Offset: 0x003D2D80
	public void RequestInfluenceReward(int influenceId)
	{
		InfluenceRewardRequest influenceRewardRequest = InfluenceRewardRequest.Create();
		influenceRewardRequest.InfluenceId = influenceId;
		Net.Instance.Call(ERequestMessageId.InfluenceRewardRequest, influenceRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			InfluenceRewardResponse influenceRewardResponse = (InfluenceRewardResponse)msg;
			if (influenceRewardResponse.Code != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(influenceRewardResponse.Code, 21130, null, true, true);
				return;
			}
			if (InfluenceReputationModel.Instance.UpdateInfluenceRewardIndex(influenceRewardResponse.InfluenceId, influenceRewardResponse.RewardIndex))
			{
				this.ShowReward(influenceRewardResponse.RewardItems);
				EventSystem.Instance.Emit(EEventName.ReceiveReputationReward);
			}
		}, 0);
	}

	// Token: 0x0600CE0D RID: 52749 RVA: 0x003D4BB8 File Offset: 0x003D2DB8
	private void ShowReward(IDictionary<int, int> itemList)
	{
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (KeyValuePair<int, int> keyValuePair in itemList)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			RewardItemData item = new RewardItemData(key, value, null, EDropItemType.Normal);
			list.Add(item);
		}
		ItemRewardController.Instance.OpenCommonRewardView(1009, list, null);
	}

	// Token: 0x0600CE0E RID: 52750 RVA: 0x003D4C3C File Offset: 0x003D2E3C
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.InfluenceReputationView, new Func<EUiViewName, object, bool>(this.CanOpenView), "InfluenceReputationController.CanOpenView");
	}

	// Token: 0x0600CE0F RID: 52751 RVA: 0x003D4C5E File Offset: 0x003D2E5E
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.InfluenceReputationView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x0600CE10 RID: 52752 RVA: 0x003D4C7B File Offset: 0x003D2E7B
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		return FunctionModel.Instance.IsOpen(10029);
	}

	// Token: 0x17001366 RID: 4966
	// (get) Token: 0x0600CE11 RID: 52753 RVA: 0x003D4C8C File Offset: 0x003D2E8C
	public static InfluenceReputationController Instance
	{
		get
		{
			return InfluenceReputationController._Instance;
		}
	}

	// Token: 0x0600CE12 RID: 52754 RVA: 0x003D4C93 File Offset: 0x003D2E93
	public static InfluenceReputationController GetOrCreateInstance()
	{
		if (InfluenceReputationController._Instance == null)
		{
			InfluenceReputationController.CreateInstance();
		}
		return InfluenceReputationController._Instance;
	}

	// Token: 0x0600CE13 RID: 52755 RVA: 0x003D4CA7 File Offset: 0x003D2EA7
	public static bool CreateInstance()
	{
		if (InfluenceReputationController._Instance != null)
		{
			return true;
		}
		InfluenceReputationController._Instance = new InfluenceReputationController();
		return true;
	}

	// Token: 0x0600CE14 RID: 52756 RVA: 0x003D4CBD File Offset: 0x003D2EBD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CE15 RID: 52757 RVA: 0x003D4CBF File Offset: 0x003D2EBF
	public static void ResetStaticDefaultValue()
	{
		InfluenceReputationController._Instance = null;
	}

	// Token: 0x0600CE16 RID: 52758 RVA: 0x003D4CC7 File Offset: 0x003D2EC7
	static InfluenceReputationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceReputationController.CreateStaticDefaultValue), new Action(InfluenceReputationController.ResetStaticDefaultValue));
	}

	// Token: 0x04007559 RID: 30041
	[Nullable(2)]
	private static InfluenceReputationController _Instance;
}
