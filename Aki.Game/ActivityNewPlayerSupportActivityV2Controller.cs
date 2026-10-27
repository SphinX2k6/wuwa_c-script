using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020013B0 RID: 5040
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewPlayerSupportActivityV2Controller : ActivityControllerBase
{
	// Token: 0x17000BE6 RID: 3046
	// (get) Token: 0x06008D9B RID: 36251 RVA: 0x001E8605 File Offset: 0x001E6805
	[Nullable(2)]
	public ActivityNewPlayerSupportActivityV2Data ActivityData
	{
		[NullableContext(2)]
		get
		{
			return this.ActivityDataInternal;
		}
	}

	// Token: 0x06008D9C RID: 36252 RVA: 0x001E8610 File Offset: 0x001E6810
	public static void ReportEntranceClick(ENewPlayerSupportEntrance entrance)
	{
		NewPlayerSupportEntranceClickLogEvent newPlayerSupportEntranceClickLogEvent = new NewPlayerSupportEntranceClickLogEvent();
		newPlayerSupportEntranceClickLogEvent.i_entrance_id = (int)entrance;
		LogReportController.Instance.LogReport(newPlayerSupportEntranceClickLogEvent);
	}

	// Token: 0x06008D9D RID: 36253 RVA: 0x001E8638 File Offset: 0x001E6838
	public static PayShopJumpParam ResolveWeekCardShopJumpParam()
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList(PayShopDefine.EPayShopTabType.NewPlayerShop, true);
		if (payShopTabIdList.Count == 0)
		{
			return new PayShopJumpParam
			{
				PayShopId = PayShopDefine.EPayShopTabType.Recommend,
				SwitchId = 0
			};
		}
		return new PayShopJumpParam
		{
			PayShopId = PayShopDefine.EPayShopTabType.NewPlayerShop,
			SwitchId = ((payShopTabIdList.Count > 0) ? payShopTabIdList[0] : 1)
		};
	}

	// Token: 0x06008D9E RID: 36254 RVA: 0x001E8693 File Offset: 0x001E6893
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateV2Notify, new Action<IMessage, Net.CallbackStatus>(this.OnTrialRoleUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportV2GachaRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaRoleUpdateNotify));
	}

	// Token: 0x06008D9F RID: 36255 RVA: 0x001E86CD File Offset: 0x001E68CD
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateV2Notify);
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportV2GachaRoleUpdateNotify);
	}

	// Token: 0x06008DA0 RID: 36256 RVA: 0x001E86EF File Offset: 0x001E68EF
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008DA1 RID: 36257 RVA: 0x001E86F1 File Offset: 0x001E68F1
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewcomerPrivilege";
	}

	// Token: 0x06008DA2 RID: 36258 RVA: 0x001E86F8 File Offset: 0x001E68F8
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNewPlayerSupportActivityV2();
	}

	// Token: 0x06008DA3 RID: 36259 RVA: 0x001E86FF File Offset: 0x001E68FF
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityDataInternal = new ActivityNewPlayerSupportActivityV2Data();
		return this.ActivityDataInternal;
	}

	// Token: 0x06008DA4 RID: 36260 RVA: 0x001E8712 File Offset: 0x001E6912
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.ActivityNewPlayerSupportTrialRoleView);
	}

	// Token: 0x06008DA5 RID: 36261 RVA: 0x001E8724 File Offset: 0x001E6924
	public void RequestTrialRoleLvUp(int trialRoleId)
	{
		NewPlayerSupportTrialRoleLvUpV2Request newPlayerSupportTrialRoleLvUpV2Request = NewPlayerSupportTrialRoleLvUpV2Request.Create();
		newPlayerSupportTrialRoleLvUpV2Request.TrialRoleId = trialRoleId;
		Net.Instance.Call(ERequestMessageId.NewPlayerSupportTrialRoleLvUpV2Request, newPlayerSupportTrialRoleLvUpV2Request, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewPlayerSupportTrialRoleLvUpV2Response newPlayerSupportTrialRoleLvUpV2Response = (NewPlayerSupportTrialRoleLvUpV2Response)msg;
			if (newPlayerSupportTrialRoleLvUpV2Response == null)
			{
				return;
			}
			if (newPlayerSupportTrialRoleLvUpV2Response.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportTrialRoleLvUpV2Response.Code, 18194, null, true, true);
				return;
			}
			ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateActivatedTrialRole(newPlayerSupportTrialRoleLvUpV2Response.RoleId, newPlayerSupportTrialRoleLvUpV2Response.CurUseRoleInfo);
		}, 0);
	}

	// Token: 0x06008DA6 RID: 36262 RVA: 0x001E875C File Offset: 0x001E695C
	public void RequestSetCurUseTrialRole(int trialRoleId, Action<int> callback)
	{
		NewPlayerSupportSetCurUseTrialRoleV2Request newPlayerSupportSetCurUseTrialRoleV2Request = NewPlayerSupportSetCurUseTrialRoleV2Request.Create();
		newPlayerSupportSetCurUseTrialRoleV2Request.TrialRoleId = trialRoleId;
		Net.Instance.Call(ERequestMessageId.NewPlayerSupportSetCurUseTrialRoleV2Request, newPlayerSupportSetCurUseTrialRoleV2Request, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewPlayerSupportSetCurUseTrialRoleV2Response newPlayerSupportSetCurUseTrialRoleV2Response = (NewPlayerSupportSetCurUseTrialRoleV2Response)msg;
			if (newPlayerSupportSetCurUseTrialRoleV2Response == null)
			{
				return;
			}
			if (newPlayerSupportSetCurUseTrialRoleV2Response.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportSetCurUseTrialRoleV2Response.Code, 28224, null, true, true);
				return;
			}
			ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.UpdateCurUseTrialRole(newPlayerSupportSetCurUseTrialRoleV2Response.RoleId, newPlayerSupportSetCurUseTrialRoleV2Response.CurUseRoleInfo);
			}
			callback(newPlayerSupportSetCurUseTrialRoleV2Response.RoleId);
		}, 0);
	}

	// Token: 0x06008DA7 RID: 36263 RVA: 0x001E87A8 File Offset: 0x001E69A8
	public void OpenTrialRoleView(int? selectedGroupId = null)
	{
		NewPlayerSupportTrialRoleViewModel newPlayerSupportTrialRoleViewModel = new NewPlayerSupportTrialRoleViewModel(ETrialRoleType.NewbieSupportTrialV2, ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleIcon") ?? "", ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleTitle") ?? "", 465, selectedGroupId);
		newPlayerSupportTrialRoleViewModel.SetRequestTrialRoleLvUpFunc(new Action<int>(this.RequestTrialRoleLvUp));
		newPlayerSupportTrialRoleViewModel.SetRequestSetCurUseTrialRoleFunc(new Action<int, Action<int>>(this.RequestSetCurUseTrialRole));
		newPlayerSupportTrialRoleViewModel.SetTrialRoleGroupUnlockDesc(this.GetTrialRoleUnlockDesc());
		UiManager.Instance.OpenView(EUiViewName.ActivityNewPlayerSupportTrialRoleView, newPlayerSupportTrialRoleViewModel, null);
	}

	// Token: 0x06008DA8 RID: 36264 RVA: 0x001E882C File Offset: 0x001E6A2C
	public void OpenAdventureV2View()
	{
		INewPlayerAdventureV2ViewOpenData param = new INewPlayerAdventureV2ViewOpenData
		{
			RoleIdList = this.CollectAdventureV2RoleIds()
		};
		UiManager.Instance.OpenView(EUiViewName.NewPlayerAdventureV2View, param, null);
	}

	// Token: 0x06008DA9 RID: 36265 RVA: 0x001E885C File Offset: 0x001E6A5C
	public List<int> GetGachaPoolUpRoleForPanel()
	{
		return this.GetGachaPoolUpRole();
	}

	// Token: 0x06008DAA RID: 36266 RVA: 0x001E8864 File Offset: 0x001E6A64
	public List<int> CollectAdventureV2RoleIds()
	{
		HashSet<int> hashSet = new HashSet<int>();
		List<int> list = new List<int>();
		FormationModel instance = FormationModel.Instance;
		List<int> list2;
		if (instance == null)
		{
			list2 = null;
		}
		else
		{
			FormationData currentFormationData = instance.CurrentFormationData;
			list2 = ((currentFormationData != null) ? currentFormationData.RoleIdList : null);
		}
		List<int> sourceRoleIds = list2 ?? new List<int>();
		this.AppendUniqueAdventureRoleIds(sourceRoleIds, list, hashSet);
		List<int> list3 = new List<int>();
		this.AppendUniqueAdventureRoleIds(this.GetGachaPoolUpRole(), list3, hashSet);
		List<int> list4 = new List<int>();
		RoleModel instance2 = RoleModel.Instance;
		RoleInstance[] array = ((instance2 != null) ? instance2.GetRoleListWithoutMainRole() : null) ?? Array.Empty<RoleInstance>();
		for (int i = 0; i < array.Length; i++)
		{
			int roleId = array[i].GetRoleId();
			if (!this.IsInvalidAdventureRoleId(roleId) && !hashSet.Contains(roleId))
			{
				hashSet.Add(roleId);
				list4.Add(roleId);
			}
		}
		list4.Sort(new Comparison<int>(this.SortByLevelQualityId));
		List<int> list5 = new List<int>();
		list5.AddRange(list3);
		list5.AddRange(list);
		list5.AddRange(list4);
		return list5;
	}

	// Token: 0x06008DAB RID: 36267 RVA: 0x001E8958 File Offset: 0x001E6B58
	private void AppendUniqueAdventureRoleIds(IEnumerable<int> sourceRoleIds, List<int> targetBucket, HashSet<int> seenRoleIds)
	{
		foreach (int num in sourceRoleIds)
		{
			if (!this.IsInvalidAdventureRoleId(num) && !seenRoleIds.Contains(num))
			{
				seenRoleIds.Add(num);
				targetBucket.Add(num);
			}
		}
	}

	// Token: 0x06008DAC RID: 36268 RVA: 0x001E89BC File Offset: 0x001E6BBC
	private bool IsInvalidAdventureRoleId(int roleId)
	{
		if (roleId <= 0)
		{
			return true;
		}
		RoleModel instance = RoleModel.Instance;
		return (instance != null && instance.IsMainRole(roleId)) || RoleUtils.IsTrialRole(roleId);
	}

	// Token: 0x06008DAD RID: 36269 RVA: 0x001E89E0 File Offset: 0x001E6BE0
	private int SortByLevelQualityId(int roleIdA, int roleIdB)
	{
		int adventureRoleLevel = this.GetAdventureRoleLevel(roleIdA);
		int adventureRoleLevel2 = this.GetAdventureRoleLevel(roleIdB);
		if (adventureRoleLevel != adventureRoleLevel2)
		{
			return adventureRoleLevel2 - adventureRoleLevel;
		}
		int adventureRoleQualityId = this.GetAdventureRoleQualityId(roleIdA);
		int adventureRoleQualityId2 = this.GetAdventureRoleQualityId(roleIdB);
		if (adventureRoleQualityId != adventureRoleQualityId2)
		{
			return adventureRoleQualityId2 - adventureRoleQualityId;
		}
		return roleIdA - roleIdB;
	}

	// Token: 0x06008DAE RID: 36270 RVA: 0x001E8A20 File Offset: 0x001E6C20
	private int GetAdventureRoleLevel(int roleId)
	{
		RoleModel instance = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(roleId, true) : null;
		if (roleDataBase == null)
		{
			return 0;
		}
		return roleDataBase.GetLevelData().GetLevel();
	}

	// Token: 0x06008DAF RID: 36271 RVA: 0x001E8A54 File Offset: 0x001E6C54
	private int GetAdventureRoleQualityId(int roleId)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return 0;
		}
		return roleConfig.Value.QualityId;
	}

	// Token: 0x06008DB0 RID: 36272 RVA: 0x001E8A88 File Offset: 0x001E6C88
	private List<int> GetGachaPoolUpRole()
	{
		Dictionary<GachaDefine.EGachaViewType, List<int>> dictionary = this.CreateGachaPoolUpRoleBucketMap();
		ProtoGachaInfo[] gachaInfoArray = GachaModel.Instance.GachaInfoArray;
		if (gachaInfoArray == null || gachaInfoArray.Length == 0)
		{
			return new List<int>();
		}
		ProtoGachaInfo[] array = gachaInfoArray;
		for (int i = 0; i < array.Length; i++)
		{
			foreach (ProtoGachaPoolInfo protoGachaPoolInfo in array[i].GetValidPoolList() ?? Array.Empty<ProtoGachaPoolInfo>())
			{
				this.TryCollectGachaPoolUpRole(protoGachaPoolInfo.Id, dictionary);
			}
		}
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int num = (activityData != null) ? activityData.NewPlayerPoolFinalGachaRoleId : 0;
		List<int> list;
		if (num > 0 && dictionary.TryGetValue(GachaDefine.EGachaViewType.NewPlayerCustom, out list))
		{
			list.Add(num);
		}
		return this.GetSortedGachaPoolUpRoleList(dictionary);
	}

	// Token: 0x06008DB1 RID: 36273 RVA: 0x001E8B38 File Offset: 0x001E6D38
	private Dictionary<GachaDefine.EGachaViewType, List<int>> CreateGachaPoolUpRoleBucketMap()
	{
		Dictionary<GachaDefine.EGachaViewType, List<int>> dictionary = new Dictionary<GachaDefine.EGachaViewType, List<int>>();
		foreach (GachaDefine.EGachaViewType key in ActivityNewPlayerSupportActivityV2Controller.GachaPoolUpRoleCollectViewTypeList)
		{
			dictionary[key] = new List<int>();
		}
		return dictionary;
	}

	// Token: 0x06008DB2 RID: 36274 RVA: 0x001E8B70 File Offset: 0x001E6D70
	private void TryCollectGachaPoolUpRole(int poolId, Dictionary<GachaDefine.EGachaViewType, List<int>> roleBucketMap)
	{
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(poolId);
		if (gachaViewInfo == null)
		{
			return;
		}
		GachaDefine.EGachaViewType type = (GachaDefine.EGachaViewType)gachaViewInfo.Value.Type;
		List<int> list;
		if (!roleBucketMap.TryGetValue(type, out list))
		{
			return;
		}
		GachaPool? gachaPoolConfig = GachaConfig.Instance.GetGachaPoolConfig(poolId);
		if (gachaPoolConfig == null)
		{
			return;
		}
		ProtoGachaPoolInfo validGachaPool = ActivityRegressModel.Instance.GetValidGachaPool(gachaPoolConfig.Value.GachaId);
		int num = (((validGachaPool != null) ? validGachaPool.PreviewIdList.Length : 0) > 0) ? validGachaPool.PreviewIdList[0] : 0;
		if (num <= 0)
		{
			return;
		}
		list.Add(num);
	}

	// Token: 0x06008DB3 RID: 36275 RVA: 0x001E8C14 File Offset: 0x001E6E14
	private List<int> GetSortedGachaPoolUpRoleList(Dictionary<GachaDefine.EGachaViewType, List<int>> roleBucketMap)
	{
		List<int> list = new List<int>();
		HashSet<int> seenRoleIds = new HashSet<int>();
		foreach (GachaDefine.EGachaViewType key in ActivityNewPlayerSupportActivityV2Controller.GachaPoolUpRoleCollectViewTypeList)
		{
			List<int> list2;
			if (roleBucketMap.TryGetValue(key, out list2) && list2.Count > 0)
			{
				list2.Sort(new Comparison<int>(this.SortByLevelQualityId));
				this.AppendUniqueAdventureRoleIds(list2, list, seenRoleIds);
			}
		}
		return list;
	}

	// Token: 0x06008DB4 RID: 36276 RVA: 0x001E8C7C File Offset: 0x001E6E7C
	private Dictionary<int, string> GetTrialRoleUnlockDesc()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int num = (activityData != null) ? activityData.Id : 0;
		if (num > 0)
		{
			foreach (NewPlayerSupV2Trial newPlayerSupV2Trial in (ConfigNewPlayerSupV2TrialByActivityId.GetConfigList(num, true) ?? Array.Empty<NewPlayerSupV2Trial>()))
			{
				ConditionGroup? conditionGroup;
				string value = (ConditionConfig.Instance.GetConditionGroupConfig(newPlayerSupV2Trial.ConditionGroup) != null) ? conditionGroup.GetValueOrDefault().HintText : null;
				if (!string.IsNullOrEmpty(value))
				{
					dictionary[newPlayerSupV2Trial.TrialRoleGroupId] = value;
				}
			}
		}
		if (dictionary.Count <= 0)
		{
			return ActivityNewPlayerSupportConfig.Instance.GetTrialRoleUnlockDesc();
		}
		return dictionary;
	}

	// Token: 0x06008DB5 RID: 36277 RVA: 0x001E8D48 File Offset: 0x001E6F48
	[NullableContext(2)]
	private void OnTrialRoleUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		NewPlayerSupportActivityTrialRoleUpdateV2Notify newPlayerSupportActivityTrialRoleUpdateV2Notify = (NewPlayerSupportActivityTrialRoleUpdateV2Notify)msg;
		int activityId = newPlayerSupportActivityTrialRoleUpdateV2Notify.ActivityId;
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		foreach (int num2 in newPlayerSupportActivityTrialRoleUpdateV2Notify.TrialRoleId)
		{
			if (newPlayerSupportActivityTrialRoleUpdateV2Notify.CurUseRoleInfo != null && newPlayerSupportActivityTrialRoleUpdateV2Notify.CurUseRoleInfo.RoleId == num2)
			{
				ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
				if (activityData2 != null)
				{
					activityData2.UpdateActivatedTrialRole(num2, newPlayerSupportActivityTrialRoleUpdateV2Notify.CurUseRoleInfo);
				}
			}
			else
			{
				ActivityNewPlayerSupportActivityV2Data activityData3 = this.ActivityData;
				if (activityData3 != null)
				{
					activityData3.UpdateActivatedTrialRole(num2, null);
				}
			}
		}
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.RefreshCommonActivityRedDot;
		ActivityNewPlayerSupportActivityV2Data activityData4 = this.ActivityData;
		instance.Emit<int>(name, (activityData4 != null) ? activityData4.Id : 0);
	}

	// Token: 0x06008DB6 RID: 36278 RVA: 0x001E8E38 File Offset: 0x001E7038
	[NullableContext(2)]
	private void OnGachaRoleUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		NewPlayerSupportV2GachaRoleUpdateNotify newPlayerSupportV2GachaRoleUpdateNotify = (NewPlayerSupportV2GachaRoleUpdateNotify)msg;
		int activityId = newPlayerSupportV2GachaRoleUpdateNotify.ActivityId;
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
		if (activityData2 == null)
		{
			return;
		}
		activityData2.UpdateDeduplicateGachaRoleIds(newPlayerSupportV2GachaRoleUpdateNotify.DeduplicateGachaRoleIds.ToArray<int>());
	}

	// Token: 0x17000BE7 RID: 3047
	// (get) Token: 0x06008DB7 RID: 36279 RVA: 0x001E8EA1 File Offset: 0x001E70A1
	public static ActivityNewPlayerSupportActivityV2Controller Instance
	{
		get
		{
			return ActivityNewPlayerSupportActivityV2Controller._Instance;
		}
	}

	// Token: 0x06008DB8 RID: 36280 RVA: 0x001E8EA8 File Offset: 0x001E70A8
	public static ActivityNewPlayerSupportActivityV2Controller GetOrCreateInstance()
	{
		if (ActivityNewPlayerSupportActivityV2Controller._Instance == null)
		{
			ActivityNewPlayerSupportActivityV2Controller.CreateInstance();
		}
		return ActivityNewPlayerSupportActivityV2Controller._Instance;
	}

	// Token: 0x06008DB9 RID: 36281 RVA: 0x001E8EBC File Offset: 0x001E70BC
	public static bool CreateInstance()
	{
		if (ActivityNewPlayerSupportActivityV2Controller._Instance != null)
		{
			return true;
		}
		ActivityNewPlayerSupportActivityV2Controller._Instance = new ActivityNewPlayerSupportActivityV2Controller();
		return true;
	}

	// Token: 0x06008DBA RID: 36282 RVA: 0x001E8ED2 File Offset: 0x001E70D2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008DBB RID: 36283 RVA: 0x001E8ED4 File Offset: 0x001E70D4
	public static void ResetStaticDefaultValue()
	{
		ActivityNewPlayerSupportActivityV2Controller._Instance = null;
	}

	// Token: 0x06008DBC RID: 36284 RVA: 0x001E8EDC File Offset: 0x001E70DC
	static ActivityNewPlayerSupportActivityV2Controller()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewPlayerSupportActivityV2Controller.CreateStaticDefaultValue), new Action(ActivityNewPlayerSupportActivityV2Controller.ResetStaticDefaultValue));
	}

	// Token: 0x04003EE4 RID: 16100
	private const int TrialRoleHelpId = 465;

	// Token: 0x04003EE5 RID: 16101
	[Nullable(2)]
	private ActivityNewPlayerSupportActivityV2Data ActivityDataInternal;

	// Token: 0x04003EE6 RID: 16102
	[StaticVariableRuleIgnore]
	private static readonly GachaDefine.EGachaViewType[] GachaPoolUpRoleCollectViewTypeList = new GachaDefine.EGachaViewType[]
	{
		GachaDefine.EGachaViewType.RoleUp,
		GachaDefine.EGachaViewType.CarnivalRole,
		GachaDefine.EGachaViewType.CyberRole,
		GachaDefine.EGachaViewType.OldCarnivalRole
	};

	// Token: 0x04003EE7 RID: 16103
	[Nullable(2)]
	private static ActivityNewPlayerSupportActivityV2Controller _Instance;
}
