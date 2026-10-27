using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020013B1 RID: 5041
[NullableContext(2)]
[Nullable(0)]
public class ActivityNewPlayerSupportActivityV2Data : ActivityBaseData
{
	// Token: 0x17000BE8 RID: 3048
	// (get) Token: 0x06008DBF RID: 36287 RVA: 0x001E8F71 File Offset: 0x001E7171
	public TrialRoleGroupData CurUseTrialRoleData
	{
		get
		{
			return TrialRoleModel.Instance.GetCurUseTrialRole(ETrialRoleType.NewbieSupportTrialV2);
		}
	}

	// Token: 0x17000BE9 RID: 3049
	// (get) Token: 0x06008DC0 RID: 36288 RVA: 0x001E8F7E File Offset: 0x001E717E
	public long NbWeekCardEndShowTime
	{
		get
		{
			NewPlayerSupportActivityV2Pb v2Data = this.V2Data;
			if (v2Data == null)
			{
				return 0L;
			}
			return v2Data.NbWeekCardEndShowTime;
		}
	}

	// Token: 0x17000BEA RID: 3050
	// (get) Token: 0x06008DC1 RID: 36289 RVA: 0x001E8F92 File Offset: 0x001E7192
	public long NbGiftPackEndShowTime
	{
		get
		{
			NewPlayerSupportActivityV2Pb v2Data = this.V2Data;
			if (v2Data == null)
			{
				return 0L;
			}
			return v2Data.NbGiftPackEndShowTime;
		}
	}

	// Token: 0x17000BEB RID: 3051
	// (get) Token: 0x06008DC2 RID: 36290 RVA: 0x001E8FA6 File Offset: 0x001E71A6
	public long NbGachaEndShowTime
	{
		get
		{
			NewPlayerSupportActivityV2Pb v2Data = this.V2Data;
			if (v2Data == null)
			{
				return 0L;
			}
			return v2Data.NbGachaEndShowTime;
		}
	}

	// Token: 0x17000BEC RID: 3052
	// (get) Token: 0x06008DC3 RID: 36291 RVA: 0x001E8FBA File Offset: 0x001E71BA
	public long NbLivenessEndShowTime
	{
		get
		{
			NewPlayerSupportActivityV2Pb v2Data = this.V2Data;
			if (v2Data == null)
			{
				return 0L;
			}
			return v2Data.NbLivenessEndShowTime;
		}
	}

	// Token: 0x17000BED RID: 3053
	// (get) Token: 0x06008DC4 RID: 36292 RVA: 0x001E8FCE File Offset: 0x001E71CE
	public int NewPlayerPoolFinalGachaRoleId
	{
		get
		{
			NewPlayerSupportActivityV2Pb v2Data = this.V2Data;
			if (v2Data == null)
			{
				return 0;
			}
			return v2Data.NewPlayerPoolFinalGachaRoleId;
		}
	}

	// Token: 0x06008DC5 RID: 36293 RVA: 0x001E8FE4 File Offset: 0x001E71E4
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		NewPlayerSupportActivityV2? config = ConfigNewPlayerSupportActivityV2ById.GetConfig(base.Id, true);
		NewPlayerSupportActivityV2? activityConfig;
		if (config == null)
		{
			IReadOnlyList<NewPlayerSupportActivityV2> configList = ConfigNewPlayerSupportActivityV2All.GetConfigList(true);
			activityConfig = ((configList != null) ? new NewPlayerSupportActivityV2?(configList.FirstOrDefault<NewPlayerSupportActivityV2>()) : null);
		}
		else
		{
			activityConfig = config;
		}
		this.ActivityConfig = activityConfig;
		this.InitTrialDisplayConfig();
		this.V2Data = data.NewPlayerSupportActivityV2Pb;
		if (this.V2Data == null)
		{
			return;
		}
		this.ParseTrialRoles(this.V2Data.TrialRoleInfoList);
		this.ParseCurUseTrialRole(this.V2Data.CurUseTrialRoleId, this.V2Data.CurUseRoleInfo);
	}

	// Token: 0x06008DC6 RID: 36294 RVA: 0x001E9077 File Offset: 0x001E7277
	public void UpdateCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008DC7 RID: 36295 RVA: 0x001E909B File Offset: 0x001E729B
	public void UpdateActivatedTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SaveTrialRoleUnlockRedDotById(trialRoleId, true);
		TrialRoleModel.Instance.SetGroupTrialRoleId(trialRoleId, trialRoleInfo);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008DC8 RID: 36296 RVA: 0x001E90CC File Offset: 0x001E72CC
	[NullableContext(1)]
	public void UpdateDeduplicateGachaRoleIds(int[] roleIds)
	{
		if (this.V2Data == null)
		{
			return;
		}
		this.V2Data.DeduplicateGachaRoleIds.Clear();
		this.V2Data.DeduplicateGachaRoleIds.AddRange(roleIds);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008DC9 RID: 36297 RVA: 0x001E9119 File Offset: 0x001E7319
	public void MarkWeekCardEntranceClicked()
	{
		this.SaveEntranceClicked(1);
	}

	// Token: 0x06008DCA RID: 36298 RVA: 0x001E9122 File Offset: 0x001E7322
	public void MarkGiftPackEntranceClicked()
	{
		this.SaveEntranceClicked(2);
	}

	// Token: 0x06008DCB RID: 36299 RVA: 0x001E912B File Offset: 0x001E732B
	public void MarkGachaEntranceClicked()
	{
		this.SaveEntranceClicked(3);
	}

	// Token: 0x06008DCC RID: 36300 RVA: 0x001E9134 File Offset: 0x001E7334
	public void MarkLivenessEntranceClicked()
	{
		this.SaveEntranceClicked(4);
	}

	// Token: 0x06008DCD RID: 36301 RVA: 0x001E913D File Offset: 0x001E733D
	public long GetDisplayRemainEndTime()
	{
		return Math.Max(Math.Max(Math.Max(this.NbWeekCardEndShowTime, this.NbGiftPackEndShowTime), Math.Max(this.NbGachaEndShowTime, this.NbLivenessEndShowTime)), base.EndShowTime);
	}

	// Token: 0x06008DCE RID: 36302 RVA: 0x001E9174 File Offset: 0x001E7374
	[NullableContext(1)]
	public int[] GetConfiguredGachaIds()
	{
		return ((this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetGachaIdsArray() : null) ?? Array.Empty<int>();
	}

	// Token: 0x06008DCF RID: 36303 RVA: 0x001E91AC File Offset: 0x001E73AC
	public int? GetGachaOpenTabIdOrDefault()
	{
		int[] configuredGachaIds = this.GetConfiguredGachaIds();
		if (configuredGachaIds.Length == 0)
		{
			return null;
		}
		if (configuredGachaIds.Length >= 2)
		{
			int num = configuredGachaIds[0];
			int num2 = configuredGachaIds[1];
			bool flag = GachaModel.Instance.GetGachaInfo(num) != null;
			bool flag2 = GachaModel.Instance.GetGachaInfo(num2) != null;
			if (flag)
			{
				return new int?(num);
			}
			if (flag2)
			{
				return new int?(num2);
			}
		}
		return new int?(configuredGachaIds[0]);
	}

	// Token: 0x06008DD0 RID: 36304 RVA: 0x001E9218 File Offset: 0x001E7418
	[return: TupleElementNames(new string[]
	{
		"RolePathResourceId",
		"BgPathResourceId"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<string, string>? GetCurrentTrialRoleDisplayResourceIds()
	{
		TrialRoleGroupData curUseTrialRoleData = this.CurUseTrialRoleData;
		bool flag = curUseTrialRoleData != null && curUseTrialRoleData.TrialRoleId != 0;
		TrialRoleGroupData curUseTrialRoleData2 = this.CurUseTrialRoleData;
		int num = (curUseTrialRoleData2 != null) ? curUseTrialRoleData2.TrialRoleGroupId : 0;
		if (!flag || num == 0)
		{
			return null;
		}
		NewPlayerSupV2Trial newPlayerSupV2Trial;
		if (!this.TrialDisplayConfigMap.TryGetValue(num, out newPlayerSupV2Trial))
		{
			return null;
		}
		return new ValueTuple<string, string>?(new ValueTuple<string, string>(newPlayerSupV2Trial.RolePathMale ?? string.Empty, newPlayerSupV2Trial.RoleBgPathMale ?? string.Empty));
	}

	// Token: 0x06008DD1 RID: 36305 RVA: 0x001E929D File Offset: 0x001E749D
	public bool GetTrialRoleEntranceRedDotState()
	{
		return this.IsTrialRoleEntranceRedDot();
	}

	// Token: 0x06008DD2 RID: 36306 RVA: 0x001E92A5 File Offset: 0x001E74A5
	public bool GetWeekCardEntranceRedDotState()
	{
		return this.IsWeekCardEntranceRedDot();
	}

	// Token: 0x06008DD3 RID: 36307 RVA: 0x001E92AD File Offset: 0x001E74AD
	public bool GetGiftPackEntranceRedDotState()
	{
		return this.IsGiftPackEntranceRedDot();
	}

	// Token: 0x06008DD4 RID: 36308 RVA: 0x001E92B5 File Offset: 0x001E74B5
	public bool GetGachaEntranceRedDotState()
	{
		return this.IsGachaEntranceRedDot();
	}

	// Token: 0x06008DD5 RID: 36309 RVA: 0x001E92BD File Offset: 0x001E74BD
	public bool GetLivenessEntranceRedDotState()
	{
		return this.IsLivenessEntranceRedDot();
	}

	// Token: 0x06008DD6 RID: 36310 RVA: 0x001E92C5 File Offset: 0x001E74C5
	public override bool GetExDataRedPointShowState()
	{
		return this.IsTrialRoleEntranceRedDot();
	}

	// Token: 0x06008DD7 RID: 36311 RVA: 0x001E92CD File Offset: 0x001E74CD
	protected override bool GetExDataFinishShowState()
	{
		return false;
	}

	// Token: 0x06008DD8 RID: 36312 RVA: 0x001E92D0 File Offset: 0x001E74D0
	private void ParseCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		if (!RoleUtils.IsTrialRole(trialRoleId))
		{
			return;
		}
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
	}

	// Token: 0x06008DD9 RID: 36313 RVA: 0x001E92E8 File Offset: 0x001E74E8
	[NullableContext(1)]
	private void ParseTrialRoles(IEnumerable<NewTrialRoleInfo> roleList)
	{
		List<ITrialRoleCreateData> list = new List<ITrialRoleCreateData>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (NewTrialRoleInfo newTrialRoleInfo in roleList)
		{
			list.Add(new TrialRoleCreateData
			{
				TrialRoleId = newTrialRoleInfo.TrialRoleId,
				IsUnlocked = true
			});
			TrialRoleConfig instance = TrialRoleConfig.Instance;
			int? num = (instance != null) ? instance.GetTrialRoleGroupId(newTrialRoleInfo.TrialRoleId) : null;
			if (num != null)
			{
				hashSet.Add(num.Value);
			}
		}
		TrialRoleConfig instance2 = TrialRoleConfig.Instance;
		Dictionary<int, List<TrialRoleInfo>> dictionary = (instance2 != null) ? instance2.GetTrialRoleAllConfigByType(ETrialRoleType.NewbieSupportTrialV2) : null;
		if (dictionary != null)
		{
			foreach (KeyValuePair<int, List<TrialRoleInfo>> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				List<TrialRoleInfo> value = keyValuePair.Value;
				if (!hashSet.Contains(key) && value.Count > 0)
				{
					list.Add(new TrialRoleCreateData
					{
						TrialRoleId = value[0].Id,
						IsUnlocked = false
					});
				}
			}
		}
		TrialRoleModel.Instance.AddTrialRoles(list);
	}

	// Token: 0x06008DDA RID: 36314 RVA: 0x001E9438 File Offset: 0x001E7638
	private bool IsTrialRoleEntranceRedDot()
	{
		return TrialRoleModel.Instance.GetDataListByType(ETrialRoleType.NewbieSupportTrialV2).Exists((TrialRoleGroupData role) => TrialRoleModel.Instance.GetTrialRoleUnlockRedDotById(role.TrialRoleGroupId));
	}

	// Token: 0x06008DDB RID: 36315 RVA: 0x001E9469 File Offset: 0x001E7669
	private bool IsLivenessEntranceRedDot()
	{
		return this.IsLivenessEntranceUnlocked() && !this.IsEntranceClicked(4);
	}

	// Token: 0x06008DDC RID: 36316 RVA: 0x001E947F File Offset: 0x001E767F
	private bool IsLivenessEntranceUnlocked()
	{
		return FunctionModel.Instance.IsOpen(10023005);
	}

	// Token: 0x06008DDD RID: 36317 RVA: 0x001E9490 File Offset: 0x001E7690
	private bool IsWeekCardEntranceRedDot()
	{
		return this.IsEntranceAvailable((this.ActivityConfig != null) ? new int?(this.ActivityConfig.GetValueOrDefault().WeekCardContinueDays) : null, (this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetWeekCardIdsArray() : null, this.NbWeekCardEndShowTime > 0L) && !this.IsEntranceClicked(1);
	}

	// Token: 0x06008DDE RID: 36318 RVA: 0x001E9508 File Offset: 0x001E7708
	private bool IsGiftPackEntranceRedDot()
	{
		return this.IsEntranceAvailable((this.ActivityConfig != null) ? new int?(this.ActivityConfig.GetValueOrDefault().PayGiftsContinueDays) : null, (this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetPayGiftsArray() : null, this.NbGiftPackEndShowTime > 0L) && !this.IsEntranceClicked(2);
	}

	// Token: 0x06008DDF RID: 36319 RVA: 0x001E9580 File Offset: 0x001E7780
	private bool IsGachaEntranceRedDot()
	{
		return this.IsEntranceAvailable((this.ActivityConfig != null) ? new int?(this.ActivityConfig.GetValueOrDefault().GachaContinueDays) : null, (this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetGachaIdsArray() : null, this.NbGachaEndShowTime > 0L) && !this.IsEntranceClicked(3);
	}

	// Token: 0x06008DE0 RID: 36320 RVA: 0x001E95F6 File Offset: 0x001E77F6
	private void SaveEntranceClicked(int cacheKey)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, cacheKey, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008DE1 RID: 36321 RVA: 0x001E9622 File Offset: 0x001E7822
	private bool IsEntranceClicked(int cacheKey)
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, cacheKey, 0, 0) == 1;
	}

	// Token: 0x06008DE2 RID: 36322 RVA: 0x001E963B File Offset: 0x001E783B
	private bool IsEntranceAvailable(int? continueDays, int[] ids, bool serverUnlocked)
	{
		return this.CheckIfInShowTime() && (serverUnlocked || (continueDays != null && ids != null && ids.Length != 0 && this.GetOpenedDays() >= Math.Max(continueDays.Value, 1)));
	}

	// Token: 0x06008DE3 RID: 36323 RVA: 0x001E9676 File Offset: 0x001E7876
	private int GetOpenedDays()
	{
		if (base.BeginShowTime <= 0L)
		{
			return 0;
		}
		return (int)(Math.Max(TimeUtil.Instance.GetServerTime() - (double)base.BeginShowTime, 0.0) / (double)TimeUtil.Instance.OneDaySeconds) + 1;
	}

	// Token: 0x06008DE4 RID: 36324 RVA: 0x001E96B4 File Offset: 0x001E78B4
	private void InitTrialDisplayConfig()
	{
		this.TrialDisplayConfigMap.Clear();
		foreach (NewPlayerSupV2Trial value in (ConfigNewPlayerSupV2TrialByActivityId.GetConfigList(base.Id, true) ?? Array.Empty<NewPlayerSupV2Trial>()))
		{
			this.TrialDisplayConfigMap[value.TrialRoleGroupId] = value;
		}
	}

	// Token: 0x04003EE8 RID: 16104
	private const int CacheKeyWeekCardClicked = 1;

	// Token: 0x04003EE9 RID: 16105
	private const int CacheKeyGiftPackClicked = 2;

	// Token: 0x04003EEA RID: 16106
	private const int CacheKeyGachaClicked = 3;

	// Token: 0x04003EEB RID: 16107
	private const int CacheKeyLivenessClicked = 4;

	// Token: 0x04003EEC RID: 16108
	private NewPlayerSupportActivityV2? ActivityConfig;

	// Token: 0x04003EED RID: 16109
	private NewPlayerSupportActivityV2Pb V2Data;

	// Token: 0x04003EEE RID: 16110
	[Nullable(1)]
	private readonly Dictionary<int, NewPlayerSupV2Trial> TrialDisplayConfigMap = new Dictionary<int, NewPlayerSupV2Trial>();
}
