using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001217 RID: 4631
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssActivityController : ActivityControllerBase
{
	// Token: 0x06007C0E RID: 31758 RVA: 0x001A34F5 File Offset: 0x001A16F5
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007C0F RID: 31759 RVA: 0x001A34F7 File Offset: 0x001A16F7
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiView_CelebrationGuideMain";
	}

	// Token: 0x06007C10 RID: 31760 RVA: 0x001A34FE File Offset: 0x001A16FE
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new DangoAbyssSubView();
	}

	// Token: 0x06007C11 RID: 31761 RVA: 0x001A3505 File Offset: 0x001A1705
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new DangoAbyssActivityData();
	}

	// Token: 0x06007C12 RID: 31762 RVA: 0x001A350C File Offset: 0x001A170C
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007C13 RID: 31763 RVA: 0x001A3510 File Offset: 0x001A1710
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AbyssRoleInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleInfoUpdate));
		Net.Instance.Register(ENotifyMessageId.AbyssRoleAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleAdd));
		Net.Instance.Register(ENotifyMessageId.AbyssPluginItemInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPluginInfoUpdate));
		Net.Instance.Register(ENotifyMessageId.AbyssPluginItemRemoveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPluginRemove));
		Net.Instance.Register(ENotifyMessageId.AbyssRewardsUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRewardStateUpdate));
		Net.Instance.Register(ENotifyMessageId.AbyssPluginItemAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPluginAdd));
	}

	// Token: 0x06007C14 RID: 31764 RVA: 0x001A35C8 File Offset: 0x001A17C8
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AbyssRoleInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssRoleAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssPluginItemInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssPluginItemRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssRewardsUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssPluginItemAddNotify);
	}

	// Token: 0x06007C15 RID: 31765 RVA: 0x001A3638 File Offset: 0x001A1838
	[NullableContext(2)]
	private DangoAbyssActivityData GetCurrentOpenAbyssActivityData()
	{
		foreach (KeyValuePair<int, ActivityBaseData> keyValuePair in ActivityModel.Instance.GetAllActivityMap())
		{
			if (keyValuePair.Value.Type == ActivityType.Abyss)
			{
				return keyValuePair.Value as DangoAbyssActivityData;
			}
		}
		return null;
	}

	// Token: 0x06007C16 RID: 31766 RVA: 0x001A36AC File Offset: 0x001A18AC
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssActivityOpen, null, null);
	}

	// Token: 0x06007C17 RID: 31767 RVA: 0x001A36C0 File Offset: 0x001A18C0
	public void OpenCurrentRoleUpView()
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		DangoRootViewData dangoRootViewData = new DangoRootViewData();
		dangoRootViewData.ActivityId = currentOpenAbyssActivityData.Id;
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssRootView, dangoRootViewData, null);
	}

	// Token: 0x06007C18 RID: 31768 RVA: 0x001A371C File Offset: 0x001A191C
	[NullableContext(2)]
	private void OnRoleInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		AbyssRoleInfoUpdateNotify notify = (AbyssRoleInfoUpdateNotify)msg;
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		currentOpenAbyssActivityData.OnRoleInfoUpdate(notify);
		EventSystem.Instance.Emit(EEventName.OnAbyssRoleInfoUpdate);
	}

	// Token: 0x06007C19 RID: 31769 RVA: 0x001A3774 File Offset: 0x001A1974
	[NullableContext(2)]
	private void OnRoleAdd(IMessage msg, Net.CallbackStatus status)
	{
		AbyssRoleAddNotify abyssRoleAddNotify = (AbyssRoleAddNotify)msg;
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		currentOpenAbyssActivityData.OnAddRoleInfo(abyssRoleAddNotify);
		EventSystem.Instance.Emit(EEventName.OnAbyssAddRole);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (AbyssRoleInfo abyssRoleInfo in abyssRoleAddNotify.RoleList)
		{
			dictionary[abyssRoleInfo.Id] = abyssRoleInfo.Level;
		}
		DangoAbyssController.Instance.OpenGetDangoView(dictionary);
	}

	// Token: 0x06007C1A RID: 31770 RVA: 0x001A3830 File Offset: 0x001A1A30
	[NullableContext(2)]
	private void OnPluginInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		AbyssPluginItemInfoUpdateNotify notify = (AbyssPluginItemInfoUpdateNotify)msg;
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		currentOpenAbyssActivityData.OnPluginInfoUpdate(notify);
		EventSystem.Instance.Emit(EEventName.OnAbyssPluginInfoUpdate);
	}

	// Token: 0x06007C1B RID: 31771 RVA: 0x001A3888 File Offset: 0x001A1A88
	[NullableContext(2)]
	private void OnPluginRemove(IMessage msg, Net.CallbackStatus status)
	{
		AbyssPluginItemRemoveNotify notify = (AbyssPluginItemRemoveNotify)msg;
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		currentOpenAbyssActivityData.OnPluginRemove(notify);
		EventSystem.Instance.Emit(EEventName.OnAbyssPluginInfoUpdate);
	}

	// Token: 0x06007C1C RID: 31772 RVA: 0x001A38E0 File Offset: 0x001A1AE0
	[NullableContext(2)]
	private void OnPluginAdd(IMessage msg, Net.CallbackStatus status)
	{
		AbyssPluginItemAddNotify abyssPluginItemAddNotify = (AbyssPluginItemAddNotify)msg;
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		currentOpenAbyssActivityData.OnPluginAdd(abyssPluginItemAddNotify);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (Aki.Protocol.AbyssPluginItemInfo abyssPluginItemInfo in abyssPluginItemAddNotify.PluginItems)
		{
			dictionary[abyssPluginItemInfo.ItemId] = abyssPluginItemInfo.Count;
		}
		ItemHintController.Instance.AddAbyssItemList(dictionary);
		EventSystem.Instance.Emit(EEventName.OnAbyssPluginInfoUpdate);
	}

	// Token: 0x06007C1D RID: 31773 RVA: 0x001A399C File Offset: 0x001A1B9C
	[NullableContext(2)]
	private void OnRewardStateUpdate(IMessage msg, Net.CallbackStatus status)
	{
		AbyssRewardsUpdateNotify notify = (AbyssRewardsUpdateNotify)msg;
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		currentOpenAbyssActivityData.OnUpdateRewardIdList(notify);
		EventSystem.Instance.Emit(EEventName.OnAbyssRewardStateUpdate);
		int id = currentOpenAbyssActivityData.Id;
		EventSystem.Instance.Emit<int>(EEventName.RefreshAbyssRewardRedDot, id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, id);
	}

	// Token: 0x06007C1E RID: 31774 RVA: 0x001A3A1C File Offset: 0x001A1C1C
	public void RequestGetAbyssRewardList(int[] rewardIdList)
	{
		AbyssRewardRequest abyssRewardRequest = AbyssRewardRequest.Create();
		abyssRewardRequest.Ids.AddRange(rewardIdList);
		Net.Instance.Call(ERequestMessageId.AbyssRewardRequest, abyssRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AbyssRewardResponse abyssRewardResponse = (AbyssRewardResponse)msg;
			if (abyssRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssRewardResponse.ErrorCode, 15163, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06007C1F RID: 31775 RVA: 0x001A3A6C File Offset: 0x001A1C6C
	public void RequestAbyssDangoLevelUp(int dangoId, int level)
	{
		AbyssLittleRoleLevelUpRequest abyssLittleRoleLevelUpRequest = AbyssLittleRoleLevelUpRequest.Create();
		abyssLittleRoleLevelUpRequest.Id = dangoId;
		abyssLittleRoleLevelUpRequest.Level = level;
		Net.Instance.Call(ERequestMessageId.AbyssLittleRoleLevelUpRequest, abyssLittleRoleLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AbyssLittleRoleLevelUpResponse abyssLittleRoleLevelUpResponse = (AbyssLittleRoleLevelUpResponse)msg;
			if (abyssLittleRoleLevelUpResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssLittleRoleLevelUpResponse.ErrorCode, 15774, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<int, int>(EEventName.OnAbyssDangoLevelUp, dangoId, level);
		}, 0);
	}

	// Token: 0x06007C20 RID: 31776 RVA: 0x001A3AC8 File Offset: 0x001A1CC8
	public void RequestPutPluginOnDango(int dangoId, int[] equipIds, DangoAbyssDefine.EAbyssItemTipsState state)
	{
		AbyssPluginPutRequest abyssPluginPutRequest = AbyssPluginPutRequest.Create();
		abyssPluginPutRequest.LittleRoleId = dangoId;
		abyssPluginPutRequest.EquipItems.AddRange(equipIds);
		Net.Instance.Call(ERequestMessageId.AbyssPluginPutRequest, abyssPluginPutRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AbyssPluginPutResponse abyssPluginPutResponse = (AbyssPluginPutResponse)msg;
			if (abyssPluginPutResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssPluginPutResponse.ErrorCode, 27879, null, true, true);
				return;
			}
			this.ShowEquipTipsByState(state);
		}, 0);
	}

	// Token: 0x06007C21 RID: 31777 RVA: 0x001A3B20 File Offset: 0x001A1D20
	public void RequestPluginRecovery(List<int> incIdList)
	{
		AbyssPluginSynthesisRequest abyssPluginSynthesisRequest = AbyssPluginSynthesisRequest.Create();
		abyssPluginSynthesisRequest.PluginItemIncrId.AddRange(incIdList);
		Net.Instance.Call(ERequestMessageId.AbyssPluginSynthesisRequest, abyssPluginSynthesisRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AbyssPluginSynthesisResponse abyssPluginSynthesisResponse = (AbyssPluginSynthesisResponse)msg;
			if (abyssPluginSynthesisResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssPluginSynthesisResponse.ErrorCode, 19445, null, true, true);
				return;
			}
			RepeatedField<AddCountItemInfo> outputItems = abyssPluginSynthesisResponse.OutputItems;
			EventSystem.Instance.Emit<IReadOnlyList<AddCountItemInfo>>(EEventName.OnAbyssPluginRecovery, outputItems);
		}, 0);
	}

	// Token: 0x06007C22 RID: 31778 RVA: 0x001A3B70 File Offset: 0x001A1D70
	public AbyssChallengeData[] GetAbyssChallengeByActivityId(int activityId)
	{
		DangoAbyssActivityData dangoAbyssActivityData = ActivityModel.Instance.GetActivityById(activityId) as DangoAbyssActivityData;
		if (dangoAbyssActivityData == null)
		{
			return new AbyssChallengeData[0];
		}
		return dangoAbyssActivityData.GetAbyssChallengeDataList();
	}

	// Token: 0x06007C23 RID: 31779 RVA: 0x001A3BA0 File Offset: 0x001A1DA0
	public AbyssChallengeData[] GetAbyssChallengeRankListByActivityId(int activityId)
	{
		DangoAbyssActivityData dangoAbyssActivityData = ActivityModel.Instance.GetActivityById(activityId) as DangoAbyssActivityData;
		if (dangoAbyssActivityData == null)
		{
			return new AbyssChallengeData[0];
		}
		return dangoAbyssActivityData.GetAbyssChallengeRankList();
	}

	// Token: 0x06007C24 RID: 31780 RVA: 0x001A3BD0 File Offset: 0x001A1DD0
	public void ShowEquipTipsByState(DangoAbyssDefine.EAbyssItemTipsState state)
	{
		switch (state)
		{
		case DangoAbyssDefine.EAbyssItemTipsState.DiffDango:
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_DangoEquipSuccessSwitch_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.TakeOff:
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_DangoEquipSuccessTakeOff_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.Switch:
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_DangoEquipSuccessSwitch_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.Move:
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_DangoEquipSuccessPutOn_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.Replace:
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_DangoEquipSuccessSwitch_Text", Array.Empty<object>());
			return;
		case DangoAbyssDefine.EAbyssItemTipsState.PutOn:
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_DangoEquipSuccessPutOn_Text", Array.Empty<object>());
			return;
		default:
			return;
		}
	}

	// Token: 0x17000A91 RID: 2705
	// (get) Token: 0x06007C25 RID: 31781 RVA: 0x001A3C7B File Offset: 0x001A1E7B
	public static DangoAbyssActivityController Instance
	{
		get
		{
			return DangoAbyssActivityController._Instance;
		}
	}

	// Token: 0x06007C26 RID: 31782 RVA: 0x001A3C82 File Offset: 0x001A1E82
	public static DangoAbyssActivityController GetOrCreateInstance()
	{
		if (DangoAbyssActivityController._Instance == null)
		{
			DangoAbyssActivityController.CreateInstance();
		}
		return DangoAbyssActivityController._Instance;
	}

	// Token: 0x06007C27 RID: 31783 RVA: 0x001A3C96 File Offset: 0x001A1E96
	public static bool CreateInstance()
	{
		if (DangoAbyssActivityController._Instance != null)
		{
			return true;
		}
		DangoAbyssActivityController._Instance = new DangoAbyssActivityController();
		return true;
	}

	// Token: 0x06007C28 RID: 31784 RVA: 0x001A3CAC File Offset: 0x001A1EAC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007C29 RID: 31785 RVA: 0x001A3CAE File Offset: 0x001A1EAE
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssActivityController._Instance = null;
	}

	// Token: 0x06007C2A RID: 31786 RVA: 0x001A3CB6 File Offset: 0x001A1EB6
	static DangoAbyssActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssActivityController.CreateStaticDefaultValue), new Action(DangoAbyssActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x040038CF RID: 14543
	[Nullable(2)]
	private static DangoAbyssActivityController _Instance;
}
