using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02000864 RID: 2148
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewPlayerSupportActivityV2Controller : ActivityControllerBase
{
	// Token: 0x17000C06 RID: 3078
	// (get) Token: 0x06006131 RID: 24881 RVA: 0x001F1259 File Offset: 0x001EF459
	[Nullable(2)]
	public ActivityNewPlayerSupportActivityV2Data ActivityData
	{
		[NullableContext(2)]
		get
		{
			return this.ActivityDataInternal;
		}
	}

	// Token: 0x06006132 RID: 24882 RVA: 0x001F1264 File Offset: 0x001EF464
	public static void ReportEntranceClick(ENewPlayerSupportEntrance entrance)
	{
		NewPlayerSupportEntranceClickLogEvent newPlayerSupportEntranceClickLogEvent = new NewPlayerSupportEntranceClickLogEvent();
		newPlayerSupportEntranceClickLogEvent.i_entrance_id = (int)entrance;
		LogReportController.Instance.LogReport(newPlayerSupportEntranceClickLogEvent);
	}

	// Token: 0x06006133 RID: 24883 RVA: 0x001F128C File Offset: 0x001EF48C
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

	// Token: 0x06006134 RID: 24884 RVA: 0x001F12E7 File Offset: 0x001EF4E7
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateV2Notify, new Action<IMessage, Net.CallbackStatus>(this.OnTrialRoleUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportV2GachaRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaRoleUpdateNotify));
	}

	// Token: 0x06006135 RID: 24885 RVA: 0x001F1321 File Offset: 0x001EF521
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateV2Notify);
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportV2GachaRoleUpdateNotify);
	}

	// Token: 0x06006136 RID: 24886 RVA: 0x001F1343 File Offset: 0x001EF543
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006137 RID: 24887 RVA: 0x001F1345 File Offset: 0x001EF545
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewcomerPrivilege";
	}

	// Token: 0x06006138 RID: 24888 RVA: 0x001F134C File Offset: 0x001EF54C
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNewPlayerSupportActivityV2();
	}

	// Token: 0x06006139 RID: 24889 RVA: 0x001F1353 File Offset: 0x001EF553
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityDataInternal = new ActivityNewPlayerSupportActivityV2Data();
		return this.ActivityDataInternal;
	}

	// Token: 0x0600613A RID: 24890 RVA: 0x001F1366 File Offset: 0x001EF566
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.ActivityNewPlayerSupportTrialRoleView);
	}

	// Token: 0x0600613B RID: 24891 RVA: 0x001F1378 File Offset: 0x001EF578
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportTrialRoleLvUpV2Response.Code, 25380, null, true, true);
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

	// Token: 0x0600613C RID: 24892 RVA: 0x001F13B0 File Offset: 0x001EF5B0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportSetCurUseTrialRoleV2Response.Code, 19230, null, true, true);
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

	// Token: 0x0600613D RID: 24893 RVA: 0x001F13FC File Offset: 0x001EF5FC
	public void OpenTrialRoleView(int? selectedGroupId = null)
	{
		NewPlayerSupportTrialRoleViewModel newPlayerSupportTrialRoleViewModel = new NewPlayerSupportTrialRoleViewModel(ETrialRoleType.NewbieSupportTrialV2, ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleIcon") ?? "", ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleTitle") ?? "", 465, selectedGroupId);
		newPlayerSupportTrialRoleViewModel.SetRequestTrialRoleLvUpFunc(new Action<int>(this.RequestTrialRoleLvUp));
		newPlayerSupportTrialRoleViewModel.SetRequestSetCurUseTrialRoleFunc(new Action<int, Action<int>>(this.RequestSetCurUseTrialRole));
		newPlayerSupportTrialRoleViewModel.SetTrialRoleGroupUnlockDesc(this.GetTrialRoleUnlockDesc());
		UiManager.Instance.OpenView(EUiViewName.ActivityNewPlayerSupportTrialRoleView, newPlayerSupportTrialRoleViewModel, null);
	}

	// Token: 0x0600613E RID: 24894 RVA: 0x001F1480 File Offset: 0x001EF680
	public void OpenAdventureV2View()
	{
		INewPlayerAdventureV2ViewOpenData param = new INewPlayerAdventureV2ViewOpenData
		{
			RoleIdList = this.CollectAdventureV2RoleIds()
		};
		UiManager.Instance.OpenView(EUiViewName.NewPlayerAdventureV2View, param, null);
	}

	// Token: 0x0600613F RID: 24895 RVA: 0x001F14B0 File Offset: 0x001EF6B0
	public List<int> GetGachaPoolUpRoleForPanel()
	{
		return this.GetGachaPoolUpRole();
	}

	// Token: 0x06006140 RID: 24896 RVA: 0x001F14B8 File Offset: 0x001EF6B8
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

	// Token: 0x06006141 RID: 24897 RVA: 0x001F15AC File Offset: 0x001EF7AC
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

	// Token: 0x06006142 RID: 24898 RVA: 0x001F1610 File Offset: 0x001EF810
	private bool IsInvalidAdventureRoleId(int roleId)
	{
		if (roleId <= 0)
		{
			return true;
		}
		RoleModel instance = RoleModel.Instance;
		return (instance != null && instance.IsMainRole(roleId)) || RoleUtils.IsTrialRole(roleId);
	}

	// Token: 0x06006143 RID: 24899 RVA: 0x001F1634 File Offset: 0x001EF834
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

	// Token: 0x06006144 RID: 24900 RVA: 0x001F1674 File Offset: 0x001EF874
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

	// Token: 0x06006145 RID: 24901 RVA: 0x001F16A8 File Offset: 0x001EF8A8
	private int GetAdventureRoleQualityId(int roleId)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return 0;
		}
		return roleConfig.Value.QualityId;
	}

	// Token: 0x06006146 RID: 24902 RVA: 0x001F16DC File Offset: 0x001EF8DC
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

	// Token: 0x06006147 RID: 24903 RVA: 0x001F178C File Offset: 0x001EF98C
	private Dictionary<GachaDefine.EGachaViewType, List<int>> CreateGachaPoolUpRoleBucketMap()
	{
		Dictionary<GachaDefine.EGachaViewType, List<int>> dictionary = new Dictionary<GachaDefine.EGachaViewType, List<int>>();
		foreach (GachaDefine.EGachaViewType key in ActivityNewPlayerSupportActivityV2Controller.GachaPoolUpRoleCollectViewTypeList)
		{
			dictionary[key] = new List<int>();
		}
		return dictionary;
	}

	// Token: 0x06006148 RID: 24904 RVA: 0x001F17C4 File Offset: 0x001EF9C4
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

	// Token: 0x06006149 RID: 24905 RVA: 0x001F1868 File Offset: 0x001EFA68
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

	// Token: 0x0600614A RID: 24906 RVA: 0x001F18D0 File Offset: 0x001EFAD0
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

	// Token: 0x0600614B RID: 24907 RVA: 0x001F199C File Offset: 0x001EFB9C
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

	// Token: 0x0600614C RID: 24908 RVA: 0x001F1A8C File Offset: 0x001EFC8C
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
		activityData2.UpdateDeduplicateGachaRoleIds(newPlayerSupportV2GachaRoleUpdateNotify.DeduplicateGachaRoleIds);
	}

	// Token: 0x17000C07 RID: 3079
	// (get) Token: 0x0600614D RID: 24909 RVA: 0x001F1AF0 File Offset: 0x001EFCF0
	public static ActivityNewPlayerSupportActivityV2Controller Instance
	{
		get
		{
			return ActivityNewPlayerSupportActivityV2Controller._Instance;
		}
	}

	// Token: 0x0600614E RID: 24910 RVA: 0x001F1AF7 File Offset: 0x001EFCF7
	public static ActivityNewPlayerSupportActivityV2Controller GetOrCreateInstance()
	{
		if (ActivityNewPlayerSupportActivityV2Controller._Instance == null)
		{
			ActivityNewPlayerSupportActivityV2Controller.CreateInstance();
		}
		return ActivityNewPlayerSupportActivityV2Controller._Instance;
	}

	// Token: 0x0600614F RID: 24911 RVA: 0x001F1B0B File Offset: 0x001EFD0B
	public static bool CreateInstance()
	{
		if (ActivityNewPlayerSupportActivityV2Controller._Instance != null)
		{
			return true;
		}
		ActivityNewPlayerSupportActivityV2Controller._Instance = new ActivityNewPlayerSupportActivityV2Controller();
		return true;
	}

	// Token: 0x06006150 RID: 24912 RVA: 0x001F1B21 File Offset: 0x001EFD21
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006151 RID: 24913 RVA: 0x001F1B23 File Offset: 0x001EFD23
	public static void ResetStaticDefaultValue()
	{
		ActivityNewPlayerSupportActivityV2Controller._Instance = null;
	}

	// Token: 0x06006152 RID: 24914 RVA: 0x001F1B2B File Offset: 0x001EFD2B
	static ActivityNewPlayerSupportActivityV2Controller()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewPlayerSupportActivityV2Controller.CreateStaticDefaultValue), new Action(ActivityNewPlayerSupportActivityV2Controller.ResetStaticDefaultValue));
	}

	// Token: 0x04003F7C RID: 16252
	private const int TrialRoleHelpId = 465;

	// Token: 0x04003F7D RID: 16253
	[Nullable(2)]
	private ActivityNewPlayerSupportActivityV2Data ActivityDataInternal;

	// Token: 0x04003F7E RID: 16254
	[StaticVariableRuleIgnore]
	private static readonly GachaDefine.EGachaViewType[] GachaPoolUpRoleCollectViewTypeList = new GachaDefine.EGachaViewType[]
	{
		GachaDefine.EGachaViewType.RoleUp,
		GachaDefine.EGachaViewType.CarnivalRole,
		GachaDefine.EGachaViewType.CyberRole,
		GachaDefine.EGachaViewType.OldCarnivalRole
	};

	// Token: 0x04003F7F RID: 16255
	[Nullable(2)]
	private static ActivityNewPlayerSupportActivityV2Controller _Instance;
}
