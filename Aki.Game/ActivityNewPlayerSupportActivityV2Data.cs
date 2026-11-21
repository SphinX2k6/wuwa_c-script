using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02000865 RID: 2149
[NullableContext(2)]
[Nullable(0)]
public class ActivityNewPlayerSupportActivityV2Data : ActivityBaseData
{
	// Token: 0x17000C08 RID: 3080
	// (get) Token: 0x06006155 RID: 24917 RVA: 0x001F1BBD File Offset: 0x001EFDBD
	public TrialRoleGroupData CurUseTrialRoleData
	{
		get
		{
			return TrialRoleModel.Instance.GetCurUseTrialRole(ETrialRoleType.NewbieSupportTrialV2);
		}
	}

	// Token: 0x17000C09 RID: 3081
	// (get) Token: 0x06006156 RID: 24918 RVA: 0x001F1BCA File Offset: 0x001EFDCA
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

	// Token: 0x17000C0A RID: 3082
	// (get) Token: 0x06006157 RID: 24919 RVA: 0x001F1BDE File Offset: 0x001EFDDE
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

	// Token: 0x17000C0B RID: 3083
	// (get) Token: 0x06006158 RID: 24920 RVA: 0x001F1BF2 File Offset: 0x001EFDF2
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

	// Token: 0x17000C0C RID: 3084
	// (get) Token: 0x06006159 RID: 24921 RVA: 0x001F1C06 File Offset: 0x001EFE06
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

	// Token: 0x17000C0D RID: 3085
	// (get) Token: 0x0600615A RID: 24922 RVA: 0x001F1C1A File Offset: 0x001EFE1A
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

	// Token: 0x0600615B RID: 24923 RVA: 0x001F1C30 File Offset: 0x001EFE30
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		NewPlayerSupportActivityV2? config = ConfigNewPlayerSupportActivityV2ById.GetConfig(base.Id, true);
		if (config == null)
		{
			IReadOnlyList<NewPlayerSupportActivityV2> configList = ConfigNewPlayerSupportActivityV2All.GetConfigList(true);
			if (configList != null && configList.Count > 0)
			{
				config = new NewPlayerSupportActivityV2?(configList[0]);
			}
		}
		this.ActivityConfig = config;
		this.InitTrialDisplayConfig();
		this.V2Data = data.NewPlayerSupportActivityV2Pb;
		if (this.V2Data == null)
		{
			return;
		}
		this.ParseTrialRoles(this.V2Data.TrialRoleInfoList);
		this.ParseCurUseTrialRole(this.V2Data.CurUseTrialRoleId, this.V2Data.CurUseRoleInfo);
	}

	// Token: 0x0600615C RID: 24924 RVA: 0x001F1CC3 File Offset: 0x001EFEC3
	public void UpdateCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600615D RID: 24925 RVA: 0x001F1CE7 File Offset: 0x001EFEE7
	public void UpdateActivatedTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SaveTrialRoleUnlockRedDotById(trialRoleId, true);
		TrialRoleModel.Instance.SetGroupTrialRoleId(trialRoleId, trialRoleInfo);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600615E RID: 24926 RVA: 0x001F1D18 File Offset: 0x001EFF18
	[NullableContext(1)]
	public void UpdateDeduplicateGachaRoleIds(IReadOnlyList<int> roleIds)
	{
		if (this.V2Data == null)
		{
			return;
		}
		this.V2Data.DeduplicateGachaRoleIds.Clear();
		this.V2Data.DeduplicateGachaRoleIds.AddRange(roleIds);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600615F RID: 24927 RVA: 0x001F1D65 File Offset: 0x001EFF65
	public void MarkWeekCardEntranceClicked()
	{
		this.SaveEntranceClicked(1);
	}

	// Token: 0x06006160 RID: 24928 RVA: 0x001F1D6E File Offset: 0x001EFF6E
	public void MarkGiftPackEntranceClicked()
	{
		this.SaveEntranceClicked(2);
	}

	// Token: 0x06006161 RID: 24929 RVA: 0x001F1D77 File Offset: 0x001EFF77
	public void MarkGachaEntranceClicked()
	{
		this.SaveEntranceClicked(3);
	}

	// Token: 0x06006162 RID: 24930 RVA: 0x001F1D80 File Offset: 0x001EFF80
	public void MarkLivenessEntranceClicked()
	{
		this.SaveEntranceClicked(4);
	}

	// Token: 0x06006163 RID: 24931 RVA: 0x001F1D89 File Offset: 0x001EFF89
	public long GetDisplayRemainEndTime()
	{
		return Math.Max(Math.Max(Math.Max(this.NbWeekCardEndShowTime, this.NbGiftPackEndShowTime), Math.Max(this.NbGachaEndShowTime, this.NbLivenessEndShowTime)), base.EndShowTime);
	}

	// Token: 0x06006164 RID: 24932 RVA: 0x001F1DC0 File Offset: 0x001EFFC0
	[NullableContext(1)]
	public int[] GetConfiguredGachaIds()
	{
		return ((this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetGachaIdsArray() : null) ?? Array.Empty<int>();
	}

	// Token: 0x06006165 RID: 24933 RVA: 0x001F1DF8 File Offset: 0x001EFFF8
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

	// Token: 0x06006166 RID: 24934 RVA: 0x001F1E64 File Offset: 0x001F0064
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

	// Token: 0x06006167 RID: 24935 RVA: 0x001F1EE9 File Offset: 0x001F00E9
	public bool GetTrialRoleEntranceRedDotState()
	{
		return this.IsTrialRoleEntranceRedDot();
	}

	// Token: 0x06006168 RID: 24936 RVA: 0x001F1EF1 File Offset: 0x001F00F1
	public bool GetWeekCardEntranceRedDotState()
	{
		return this.IsWeekCardEntranceRedDot();
	}

	// Token: 0x06006169 RID: 24937 RVA: 0x001F1EF9 File Offset: 0x001F00F9
	public bool GetGiftPackEntranceRedDotState()
	{
		return this.IsGiftPackEntranceRedDot();
	}

	// Token: 0x0600616A RID: 24938 RVA: 0x001F1F01 File Offset: 0x001F0101
	public bool GetGachaEntranceRedDotState()
	{
		return this.IsGachaEntranceRedDot();
	}

	// Token: 0x0600616B RID: 24939 RVA: 0x001F1F09 File Offset: 0x001F0109
	public bool GetLivenessEntranceRedDotState()
	{
		return this.IsLivenessEntranceRedDot();
	}

	// Token: 0x0600616C RID: 24940 RVA: 0x001F1F11 File Offset: 0x001F0111
	public override bool GetExDataRedPointShowState()
	{
		return this.IsTrialRoleEntranceRedDot();
	}

	// Token: 0x0600616D RID: 24941 RVA: 0x001F1F19 File Offset: 0x001F0119
	protected override bool GetExDataFinishShowState()
	{
		return false;
	}

	// Token: 0x0600616E RID: 24942 RVA: 0x001F1F1C File Offset: 0x001F011C
	private void ParseCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		if (!RoleUtils.IsTrialRole(trialRoleId))
		{
			return;
		}
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
	}

	// Token: 0x0600616F RID: 24943 RVA: 0x001F1F34 File Offset: 0x001F0134
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

	// Token: 0x06006170 RID: 24944 RVA: 0x001F2084 File Offset: 0x001F0284
	private bool IsTrialRoleEntranceRedDot()
	{
		return TrialRoleModel.Instance.GetDataListByType(ETrialRoleType.NewbieSupportTrialV2).Exists((TrialRoleGroupData role) => TrialRoleModel.Instance.GetTrialRoleUnlockRedDotById(role.TrialRoleGroupId));
	}

	// Token: 0x06006171 RID: 24945 RVA: 0x001F20B5 File Offset: 0x001F02B5
	private bool IsLivenessEntranceRedDot()
	{
		return this.IsLivenessEntranceUnlocked() && !this.IsEntranceClicked(4);
	}

	// Token: 0x06006172 RID: 24946 RVA: 0x001F20CB File Offset: 0x001F02CB
	private bool IsLivenessEntranceUnlocked()
	{
		return FunctionModel.Instance.IsOpen(10023005);
	}

	// Token: 0x06006173 RID: 24947 RVA: 0x001F20DC File Offset: 0x001F02DC
	private bool IsWeekCardEntranceRedDot()
	{
		return this.IsEntranceAvailable((this.ActivityConfig != null) ? new int?(this.ActivityConfig.GetValueOrDefault().WeekCardContinueDays) : null, (this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetWeekCardIdsArray() : null, this.NbWeekCardEndShowTime > 0L) && !this.IsEntranceClicked(1);
	}

	// Token: 0x06006174 RID: 24948 RVA: 0x001F2154 File Offset: 0x001F0354
	private bool IsGiftPackEntranceRedDot()
	{
		return this.IsEntranceAvailable((this.ActivityConfig != null) ? new int?(this.ActivityConfig.GetValueOrDefault().PayGiftsContinueDays) : null, (this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetPayGiftsArray() : null, this.NbGiftPackEndShowTime > 0L) && !this.IsEntranceClicked(2);
	}

	// Token: 0x06006175 RID: 24949 RVA: 0x001F21CC File Offset: 0x001F03CC
	private bool IsGachaEntranceRedDot()
	{
		return this.IsEntranceAvailable((this.ActivityConfig != null) ? new int?(this.ActivityConfig.GetValueOrDefault().GachaContinueDays) : null, (this.ActivityConfig != null) ? this.ActivityConfig.GetValueOrDefault().GetGachaIdsArray() : null, this.NbGachaEndShowTime > 0L) && !this.IsEntranceClicked(3);
	}

	// Token: 0x06006176 RID: 24950 RVA: 0x001F2242 File Offset: 0x001F0442
	private void SaveEntranceClicked(int cacheKey)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, cacheKey, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06006177 RID: 24951 RVA: 0x001F226E File Offset: 0x001F046E
	private bool IsEntranceClicked(int cacheKey)
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, cacheKey, 0, 0) == 1;
	}

	// Token: 0x06006178 RID: 24952 RVA: 0x001F2287 File Offset: 0x001F0487
	private bool IsEntranceAvailable(int? continueDays, int[] ids, bool serverUnlocked)
	{
		return this.CheckIfInShowTime() && (serverUnlocked || (continueDays != null && ids != null && ids.Length != 0 && this.GetOpenedDays() >= Math.Max(continueDays.Value, 1)));
	}

	// Token: 0x06006179 RID: 24953 RVA: 0x001F22C2 File Offset: 0x001F04C2
	private int GetOpenedDays()
	{
		if (base.BeginShowTime <= 0L)
		{
			return 0;
		}
		return (int)(Math.Max(TimeUtil.Instance.GetServerTime() - (double)base.BeginShowTime, 0.0) / (double)TimeUtil.Instance.OneDaySeconds) + 1;
	}

	// Token: 0x0600617A RID: 24954 RVA: 0x001F2300 File Offset: 0x001F0500
	private void InitTrialDisplayConfig()
	{
		this.TrialDisplayConfigMap.Clear();
		foreach (NewPlayerSupV2Trial value in (ConfigNewPlayerSupV2TrialByActivityId.GetConfigList(base.Id, true) ?? Array.Empty<NewPlayerSupV2Trial>()))
		{
			this.TrialDisplayConfigMap[value.TrialRoleGroupId] = value;
		}
	}

	// Token: 0x04003F80 RID: 16256
	private const int CacheKeyWeekCardClicked = 1;

	// Token: 0x04003F81 RID: 16257
	private const int CacheKeyGiftPackClicked = 2;

	// Token: 0x04003F82 RID: 16258
	private const int CacheKeyGachaClicked = 3;

	// Token: 0x04003F83 RID: 16259
	private const int CacheKeyLivenessClicked = 4;

	// Token: 0x04003F84 RID: 16260
	private NewPlayerSupportActivityV2? ActivityConfig;

	// Token: 0x04003F85 RID: 16261
	private NewPlayerSupportActivityV2Pb V2Data;

	// Token: 0x04003F86 RID: 16262
	[Nullable(1)]
	private readonly Dictionary<int, NewPlayerSupV2Trial> TrialDisplayConfigMap = new Dictionary<int, NewPlayerSupV2Trial>();
}
