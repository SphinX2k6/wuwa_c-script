using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001F76 RID: 8054
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class InfluenceReputationController : UiControllerBase
{
	// Token: 0x0600F9E7 RID: 63975 RVA: 0x003C8F88 File Offset: 0x003C7188
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.RequestInfluenceInfo));
	}

	// Token: 0x0600F9E8 RID: 63976 RVA: 0x003C8FA6 File Offset: 0x003C71A6
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.RequestInfluenceInfo));
	}

	// Token: 0x0600F9E9 RID: 63977 RVA: 0x003C8FC4 File Offset: 0x003C71C4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.InfluenceInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.NotifyInfluenceInfoUpdate));
	}

	// Token: 0x0600F9EA RID: 63978 RVA: 0x003C8FE2 File Offset: 0x003C71E2
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.InfluenceInfoUpdateNotify);
	}

	// Token: 0x0600F9EB RID: 63979 RVA: 0x003C8FF4 File Offset: 0x003C71F4
	[NullableContext(2)]
	private void NotifyInfluenceInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<OneInfluenceInfo> influenceInfos = ((InfluenceInfoUpdateNotify)msg).InfluenceInfos;
		InfluenceReputationModel.Instance.SetInfluenceInfoList(influenceInfos.ToArray<OneInfluenceInfo>());
	}

	// Token: 0x0600F9EC RID: 63980 RVA: 0x003C9020 File Offset: 0x003C7220
	public void RequestInfluenceInfo()
	{
		InfluenceInfoRequest message = InfluenceInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.InfluenceInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RepeatedField<OneInfluenceInfo> influenceInfos = ((InfluenceInfoResponse)msg).InfluenceInfos;
			InfluenceReputationModel.Instance.SetInfluenceInfoList(influenceInfos.ToArray<OneInfluenceInfo>());
		}, 0);
	}

	// Token: 0x0600F9ED RID: 63981 RVA: 0x003C9064 File Offset: 0x003C7264
	public void RequestInfluenceReward(int influenceId)
	{
		InfluenceRewardRequest influenceRewardRequest = InfluenceRewardRequest.Create();
		influenceRewardRequest.InfluenceId = influenceId;
		Net.Instance.Call(ERequestMessageId.InfluenceRewardRequest, influenceRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			InfluenceRewardResponse influenceRewardResponse = (InfluenceRewardResponse)msg;
			if (influenceRewardResponse.Code != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(influenceRewardResponse.Code, 26210, null, true, true);
				return;
			}
			if (InfluenceReputationModel.Instance.UpdateInfluenceRewardIndex(influenceRewardResponse.InfluenceId, influenceRewardResponse.RewardIndex))
			{
				this.ShowReward(influenceRewardResponse.RewardItems);
				EventSystem.Instance.Emit(EEventName.ReceiveReputationReward);
			}
		}, 0);
	}

	// Token: 0x0600F9EE RID: 63982 RVA: 0x003C909C File Offset: 0x003C729C
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

	// Token: 0x0600F9EF RID: 63983 RVA: 0x003C9120 File Offset: 0x003C7320
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.InfluenceReputationView, new Func<EUiViewName, object, bool>(this.CanOpenView), "InfluenceReputationController.CanOpenView");
	}

	// Token: 0x0600F9F0 RID: 63984 RVA: 0x003C9142 File Offset: 0x003C7342
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.InfluenceReputationView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x0600F9F1 RID: 63985 RVA: 0x003C915F File Offset: 0x003C735F
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		return FunctionModel.Instance.IsOpen(10029);
	}

	// Token: 0x1700133C RID: 4924
	// (get) Token: 0x0600F9F2 RID: 63986 RVA: 0x003C9170 File Offset: 0x003C7370
	public static InfluenceReputationController Instance
	{
		get
		{
			return InfluenceReputationController._Instance;
		}
	}

	// Token: 0x0600F9F3 RID: 63987 RVA: 0x003C9177 File Offset: 0x003C7377
	public static InfluenceReputationController GetOrCreateInstance()
	{
		if (InfluenceReputationController._Instance == null)
		{
			InfluenceReputationController.CreateInstance();
		}
		return InfluenceReputationController._Instance;
	}

	// Token: 0x0600F9F4 RID: 63988 RVA: 0x003C918B File Offset: 0x003C738B
	public static bool CreateInstance()
	{
		if (InfluenceReputationController._Instance != null)
		{
			return true;
		}
		InfluenceReputationController._Instance = new InfluenceReputationController();
		return true;
	}

	// Token: 0x0600F9F5 RID: 63989 RVA: 0x003C91A1 File Offset: 0x003C73A1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F9F6 RID: 63990 RVA: 0x003C91A3 File Offset: 0x003C73A3
	public static void ResetStaticDefaultValue()
	{
		InfluenceReputationController._Instance = null;
	}

	// Token: 0x0600F9F7 RID: 63991 RVA: 0x003C91AB File Offset: 0x003C73AB
	static InfluenceReputationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceReputationController.CreateStaticDefaultValue), new Action(InfluenceReputationController.ResetStaticDefaultValue));
	}

	// Token: 0x04007478 RID: 29816
	[Nullable(2)]
	private static InfluenceReputationController _Instance;
}
