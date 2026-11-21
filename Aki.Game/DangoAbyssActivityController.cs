using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x020006CB RID: 1739
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssActivityController : ActivityControllerBase
{
	// Token: 0x06004FA4 RID: 20388 RVA: 0x001AC16D File Offset: 0x001AA36D
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004FA5 RID: 20389 RVA: 0x001AC16F File Offset: 0x001AA36F
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiView_CelebrationGuideMain";
	}

	// Token: 0x06004FA6 RID: 20390 RVA: 0x001AC176 File Offset: 0x001AA376
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new DangoAbyssSubView();
	}

	// Token: 0x06004FA7 RID: 20391 RVA: 0x001AC17D File Offset: 0x001AA37D
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new DangoAbyssActivityData();
	}

	// Token: 0x06004FA8 RID: 20392 RVA: 0x001AC184 File Offset: 0x001AA384
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004FA9 RID: 20393 RVA: 0x001AC188 File Offset: 0x001AA388
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AbyssRoleInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleInfoUpdate));
		Net.Instance.Register(ENotifyMessageId.AbyssRoleAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleAdd));
		Net.Instance.Register(ENotifyMessageId.AbyssPluginItemInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPluginInfoUpdate));
		Net.Instance.Register(ENotifyMessageId.AbyssPluginItemRemoveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPluginRemove));
		Net.Instance.Register(ENotifyMessageId.AbyssRewardsUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRewardStateUpdate));
		Net.Instance.Register(ENotifyMessageId.AbyssPluginItemAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPluginAdd));
	}

	// Token: 0x06004FAA RID: 20394 RVA: 0x001AC240 File Offset: 0x001AA440
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AbyssRoleInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssRoleAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssPluginItemInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssPluginItemRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssRewardsUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AbyssPluginItemAddNotify);
	}

	// Token: 0x06004FAB RID: 20395 RVA: 0x001AC2B0 File Offset: 0x001AA4B0
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

	// Token: 0x06004FAC RID: 20396 RVA: 0x001AC324 File Offset: 0x001AA524
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssActivityOpen, null, null);
	}

	// Token: 0x06004FAD RID: 20397 RVA: 0x001AC338 File Offset: 0x001AA538
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

	// Token: 0x06004FAE RID: 20398 RVA: 0x001AC394 File Offset: 0x001AA594
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

	// Token: 0x06004FAF RID: 20399 RVA: 0x001AC3EC File Offset: 0x001AA5EC
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

	// Token: 0x06004FB0 RID: 20400 RVA: 0x001AC4A8 File Offset: 0x001AA6A8
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

	// Token: 0x06004FB1 RID: 20401 RVA: 0x001AC500 File Offset: 0x001AA700
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

	// Token: 0x06004FB2 RID: 20402 RVA: 0x001AC558 File Offset: 0x001AA758
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

	// Token: 0x06004FB3 RID: 20403 RVA: 0x001AC614 File Offset: 0x001AA814
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

	// Token: 0x06004FB4 RID: 20404 RVA: 0x001AC694 File Offset: 0x001AA894
	public void RequestGetAbyssRewardList(int[] rewardIdList)
	{
		AbyssRewardRequest abyssRewardRequest = AbyssRewardRequest.Create();
		abyssRewardRequest.Ids.AddRange(rewardIdList);
		Net.Instance.Call(ERequestMessageId.AbyssRewardRequest, abyssRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AbyssRewardResponse abyssRewardResponse = (AbyssRewardResponse)msg;
			if (abyssRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssRewardResponse.ErrorCode, 26593, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06004FB5 RID: 20405 RVA: 0x001AC6E4 File Offset: 0x001AA8E4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssLittleRoleLevelUpResponse.ErrorCode, 22337, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<int, int>(EEventName.OnAbyssDangoLevelUp, dangoId, level);
		}, 0);
	}

	// Token: 0x06004FB6 RID: 20406 RVA: 0x001AC740 File Offset: 0x001AA940
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssPluginPutResponse.ErrorCode, 23547, null, true, true);
				return;
			}
			this.ShowEquipTipsByState(state);
		}, 0);
	}

	// Token: 0x06004FB7 RID: 20407 RVA: 0x001AC798 File Offset: 0x001AA998
	public void RequestPluginRecovery(List<int> incIdList)
	{
		AbyssPluginSynthesisRequest abyssPluginSynthesisRequest = AbyssPluginSynthesisRequest.Create();
		abyssPluginSynthesisRequest.PluginItemIncrId.AddRange(incIdList);
		Net.Instance.Call(ERequestMessageId.AbyssPluginSynthesisRequest, abyssPluginSynthesisRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AbyssPluginSynthesisResponse abyssPluginSynthesisResponse = (AbyssPluginSynthesisResponse)msg;
			if (abyssPluginSynthesisResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(abyssPluginSynthesisResponse.ErrorCode, 20432, null, true, true);
				return;
			}
			RepeatedField<AddCountItemInfo> outputItems = abyssPluginSynthesisResponse.OutputItems;
			EventSystem.Instance.Emit<IReadOnlyList<AddCountItemInfo>>(EEventName.OnAbyssPluginRecovery, outputItems);
		}, 0);
	}

	// Token: 0x06004FB8 RID: 20408 RVA: 0x001AC7E8 File Offset: 0x001AA9E8
	public AbyssChallengeData[] GetAbyssChallengeByActivityId(int activityId)
	{
		DangoAbyssActivityData dangoAbyssActivityData = ActivityModel.Instance.GetActivityById(activityId) as DangoAbyssActivityData;
		if (dangoAbyssActivityData == null)
		{
			return new AbyssChallengeData[0];
		}
		return dangoAbyssActivityData.GetAbyssChallengeDataList();
	}

	// Token: 0x06004FB9 RID: 20409 RVA: 0x001AC818 File Offset: 0x001AAA18
	public AbyssChallengeData[] GetAbyssChallengeRankListByActivityId(int activityId)
	{
		DangoAbyssActivityData dangoAbyssActivityData = ActivityModel.Instance.GetActivityById(activityId) as DangoAbyssActivityData;
		if (dangoAbyssActivityData == null)
		{
			return new AbyssChallengeData[0];
		}
		return dangoAbyssActivityData.GetAbyssChallengeRankList();
	}

	// Token: 0x06004FBA RID: 20410 RVA: 0x001AC848 File Offset: 0x001AAA48
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

	// Token: 0x17000AB1 RID: 2737
	// (get) Token: 0x06004FBB RID: 20411 RVA: 0x001AC8F3 File Offset: 0x001AAAF3
	public static DangoAbyssActivityController Instance
	{
		get
		{
			return DangoAbyssActivityController._Instance;
		}
	}

	// Token: 0x06004FBC RID: 20412 RVA: 0x001AC8FA File Offset: 0x001AAAFA
	public static DangoAbyssActivityController GetOrCreateInstance()
	{
		if (DangoAbyssActivityController._Instance == null)
		{
			DangoAbyssActivityController.CreateInstance();
		}
		return DangoAbyssActivityController._Instance;
	}

	// Token: 0x06004FBD RID: 20413 RVA: 0x001AC90E File Offset: 0x001AAB0E
	public static bool CreateInstance()
	{
		if (DangoAbyssActivityController._Instance != null)
		{
			return true;
		}
		DangoAbyssActivityController._Instance = new DangoAbyssActivityController();
		return true;
	}

	// Token: 0x06004FBE RID: 20414 RVA: 0x001AC924 File Offset: 0x001AAB24
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004FBF RID: 20415 RVA: 0x001AC926 File Offset: 0x001AAB26
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssActivityController._Instance = null;
	}

	// Token: 0x06004FC0 RID: 20416 RVA: 0x001AC92E File Offset: 0x001AAB2E
	static DangoAbyssActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssActivityController.CreateStaticDefaultValue), new Action(DangoAbyssActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04003968 RID: 14696
	[Nullable(2)]
	private static DangoAbyssActivityController _Instance;
}
