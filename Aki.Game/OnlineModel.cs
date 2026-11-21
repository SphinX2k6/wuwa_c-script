using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x020017CC RID: 6092
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class OnlineModel : ModelBase
{
	// Token: 0x0600EDF7 RID: 60919 RVA: 0x0045C490 File Offset: 0x0045A690
	protected override bool OnInit()
	{
		this.StrangerWorldList = new List<OnlineHallData>();
		this.FriendWorldList = new List<OnlineHallData>();
		this.SearchResultList = new List<OnlineHallData>();
		this.ApplyMap = new Dictionary<int, OnlineApplyData>();
		this.OnlineTeamMap = new Dictionary<int, OnlineTeamData>();
		this.Apply = -1;
		this.TeamOwnerId = -1;
		this.ApplyCdTime = ConfigCommonParamById.GetIntConfig("apply_valid_time").Value;
		this.WorldEnterDiff = ConfigCommonParamById.GetIntConfig("world_level_enter_diff").Value;
		this.DisableOnlineSource = new Dictionary<DisableOnlineSource, EDisableOnlineType>();
		return true;
	}

	// Token: 0x0600EDF8 RID: 60920 RVA: 0x0045C520 File Offset: 0x0045A720
	protected override bool OnClear()
	{
		if (this.StrangerWorldList != null)
		{
			this.StrangerWorldList.Clear();
			this.StrangerWorldList = null;
		}
		if (this.FriendWorldList != null)
		{
			this.FriendWorldList.Clear();
			this.FriendWorldList = null;
		}
		if (this.SearchResultList != null)
		{
			this.SearchResultList.Clear();
			this.SearchResultList = null;
		}
		if (this.ApplyMap != null)
		{
			this.ApplyMap.Clear();
			this.ApplyMap = null;
		}
		if (this.OnlineTeamMap != null)
		{
			this.OnlineTeamMap.Clear();
			this.OnlineTeamMap = null;
		}
		this.Apply = 0;
		this.ApplyCdTime = 0;
		this.WorldEnterDiff = 0;
		Dictionary<DisableOnlineSource, EDisableOnlineType> disableOnlineSource = this.DisableOnlineSource;
		if (disableOnlineSource != null)
		{
			disableOnlineSource.Clear();
		}
		this.DisableOnlineSource = null;
		this.ContinuingChallengeConfirmState.Clear();
		this.PlayerTeleportState.Clear();
		this.InitiateChallengeApplyPlayerId = -1;
		this.NextAllowInitiateTime = -1.0;
		this.CanInitiate = true;
		return true;
	}

	// Token: 0x0600EDF9 RID: 60921 RVA: 0x0045C610 File Offset: 0x0045A810
	protected override bool OnLeaveLevel()
	{
		this.ContinuingChallengeConfirmState.Clear();
		this.InitiateChallengeApplyPlayerId = -1;
		this.NextAllowInitiateTime = -1.0;
		this.CanInitiate = true;
		this.PlayerEntityDisableHandleMap.Clear();
		return true;
	}

	// Token: 0x0600EDFA RID: 60922 RVA: 0x0045C646 File Offset: 0x0045A846
	protected override bool OnChangeMode()
	{
		this.PlayerEntityDisableHandleMap.Clear();
		return true;
	}

	// Token: 0x0600EDFB RID: 60923 RVA: 0x0045C654 File Offset: 0x0045A854
	public void ClearOnlineTeamMap()
	{
		if (this.OnlineTeamMap != null)
		{
			this.OnlineTeamMap.Clear();
		}
	}

	// Token: 0x170016CE RID: 5838
	// (get) Token: 0x0600EDFC RID: 60924 RVA: 0x0045C669 File Offset: 0x0045A869
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<OnlineHallData> StrangerWorld
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.StrangerWorldList;
		}
	}

	// Token: 0x170016CF RID: 5839
	// (get) Token: 0x0600EDFD RID: 60925 RVA: 0x0045C671 File Offset: 0x0045A871
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<OnlineHallData> FriendWorld
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.FriendWorldList;
		}
	}

	// Token: 0x170016D0 RID: 5840
	// (get) Token: 0x0600EDFE RID: 60926 RVA: 0x0045C679 File Offset: 0x0045A879
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<OnlineHallData> SearchResult
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.SearchResultList;
		}
	}

	// Token: 0x170016D1 RID: 5841
	// (get) Token: 0x0600EDFF RID: 60927 RVA: 0x0045C681 File Offset: 0x0045A881
	public WorldEnterPermission CurrentPermissionsSetting
	{
		get
		{
			return this.PermissionsSetting;
		}
	}

	// Token: 0x170016D2 RID: 5842
	// (get) Token: 0x0600EE00 RID: 60928 RVA: 0x0045C689 File Offset: 0x0045A889
	[Nullable(2)]
	public OnlineApplyData CurrentApply
	{
		[NullableContext(2)]
		get
		{
			if (!this.ApplyMap.ContainsKey(this.Apply))
			{
				return null;
			}
			return this.ApplyMap[this.Apply];
		}
	}

	// Token: 0x170016D3 RID: 5843
	// (get) Token: 0x0600EE01 RID: 60929 RVA: 0x0045C6B1 File Offset: 0x0045A8B1
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, OnlineApplyData> CurrentApplyList
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.ApplyMap;
		}
	}

	// Token: 0x170016D4 RID: 5844
	// (get) Token: 0x0600EE02 RID: 60930 RVA: 0x0045C6B9 File Offset: 0x0045A8B9
	public int ApplyCd
	{
		get
		{
			return this.ApplyCdTime;
		}
	}

	// Token: 0x170016D5 RID: 5845
	// (get) Token: 0x0600EE03 RID: 60931 RVA: 0x0045C6C1 File Offset: 0x0045A8C1
	public int EnterDiff
	{
		get
		{
			return this.WorldEnterDiff;
		}
	}

	// Token: 0x170016D6 RID: 5846
	// (get) Token: 0x0600EE04 RID: 60932 RVA: 0x0045C6C9 File Offset: 0x0045A8C9
	public int OwnerId
	{
		get
		{
			return this.TeamOwnerId;
		}
	}

	// Token: 0x170016D7 RID: 5847
	// (get) Token: 0x0600EE05 RID: 60933 RVA: 0x0045C6D1 File Offset: 0x0045A8D1
	public int TeamMaxSize
	{
		get
		{
			return this.OnlineTeamMaxSize;
		}
	}

	// Token: 0x170016D8 RID: 5848
	// (get) Token: 0x0600EE06 RID: 60934 RVA: 0x0045C6D9 File Offset: 0x0045A8D9
	public bool ShowCanJoin
	{
		get
		{
			return this.HallShowCanJoin;
		}
	}

	// Token: 0x170016D9 RID: 5849
	// (get) Token: 0x0600EE07 RID: 60935 RVA: 0x0045C6E1 File Offset: 0x0045A8E1
	public bool ShowFriend
	{
		get
		{
			return this.HallShowFriend;
		}
	}

	// Token: 0x170016DA RID: 5850
	// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x0045C6E9 File Offset: 0x0045A8E9
	public int ChallengeApplyPlayerId
	{
		get
		{
			return this.InitiateChallengeApplyPlayerId;
		}
	}

	// Token: 0x170016DB RID: 5851
	// (get) Token: 0x0600EE09 RID: 60937 RVA: 0x0045C6F1 File Offset: 0x0045A8F1
	public double NextInitiateTime
	{
		get
		{
			return this.NextAllowInitiateTime;
		}
	}

	// Token: 0x170016DC RID: 5852
	// (get) Token: 0x0600EE0A RID: 60938 RVA: 0x0045C6F9 File Offset: 0x0045A8F9
	public double NextInitiateLeftTime
	{
		get
		{
			return this.NextAllowInitiateTime - TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x170016DD RID: 5853
	// (get) Token: 0x0600EE0B RID: 60939 RVA: 0x0045C70C File Offset: 0x0045A90C
	public bool AllowInitiate
	{
		get
		{
			return this.CanInitiate;
		}
	}

	// Token: 0x0600EE0C RID: 60940 RVA: 0x0045C714 File Offset: 0x0045A914
	public void SetHallShowCanJoin(bool isShow)
	{
		this.HallShowCanJoin = isShow;
	}

	// Token: 0x0600EE0D RID: 60941 RVA: 0x0045C71D File Offset: 0x0045A91D
	public void SetHallShowFriend(bool isShow)
	{
		this.HallShowFriend = isShow;
	}

	// Token: 0x0600EE0E RID: 60942 RVA: 0x0045C726 File Offset: 0x0045A926
	public void SetTeamOwnerId(int teamOwnerId)
	{
		this.TeamOwnerId = teamOwnerId;
	}

	// Token: 0x0600EE0F RID: 60943 RVA: 0x0045C730 File Offset: 0x0045A930
	public void SetPermissionsSetting(WorldEnterPermission type)
	{
		this.PermissionsSetting = type;
		if (GameModeModel.Instance.IsMulti && this.GetIsMyTeam())
		{
			EPlayStationJoinAble gameJoinTypeToPlayStationJoinType = this.GetGameJoinTypeToPlayStationJoinType();
			PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.SetPlayerSessionJoinAbleUserType((int)gameJoinTypeToPlayStationJoinType);
		}
	}

	// Token: 0x0600EE10 RID: 60944 RVA: 0x0045C774 File Offset: 0x0045A974
	public void CleanSearchResultList()
	{
		List<OnlineHallData> searchResultList = this.SearchResultList;
		if (searchResultList == null)
		{
			return;
		}
		searchResultList.Clear();
	}

	// Token: 0x0600EE11 RID: 60945 RVA: 0x0045C786 File Offset: 0x0045A986
	public void CleanFriendWorldList()
	{
		List<OnlineHallData> friendWorldList = this.FriendWorldList;
		if (friendWorldList == null)
		{
			return;
		}
		friendWorldList.Clear();
	}

	// Token: 0x0600EE12 RID: 60946 RVA: 0x0045C798 File Offset: 0x0045A998
	public void CleanStrangerWorldList()
	{
		List<OnlineHallData> strangerWorldList = this.StrangerWorldList;
		if (strangerWorldList == null)
		{
			return;
		}
		strangerWorldList.Clear();
	}

	// Token: 0x0600EE13 RID: 60947 RVA: 0x0045C7AA File Offset: 0x0045A9AA
	public void CleanCurrentApply()
	{
		this.ApplyMap.Remove(this.Apply);
		this.Apply = -1;
	}

	// Token: 0x0600EE14 RID: 60948 RVA: 0x0045C7C5 File Offset: 0x0045A9C5
	public void PushSearchResultList(OnlineHallData data)
	{
		this.SearchResultList.Add(data);
	}

	// Token: 0x0600EE15 RID: 60949 RVA: 0x0045C7D3 File Offset: 0x0045A9D3
	public void PushFriendWorldList(OnlineHallData data)
	{
		this.FriendWorldList.Add(data);
	}

	// Token: 0x0600EE16 RID: 60950 RVA: 0x0045C7E1 File Offset: 0x0045A9E1
	public void PushStrangerWorldList(OnlineHallData data)
	{
		this.StrangerWorldList.Add(data);
	}

	// Token: 0x0600EE17 RID: 60951 RVA: 0x0045C7EF File Offset: 0x0045A9EF
	public void SortWorldList(bool isFriend)
	{
		if (isFriend)
		{
			List<OnlineHallData> friendWorldList = this.FriendWorldList;
			if (friendWorldList == null)
			{
				return;
			}
			friendWorldList.Sort(new Comparison<OnlineHallData>(this.WorldListSortFunction));
			return;
		}
		else
		{
			List<OnlineHallData> strangerWorldList = this.StrangerWorldList;
			if (strangerWorldList == null)
			{
				return;
			}
			strangerWorldList.Sort(new Comparison<OnlineHallData>(this.WorldListSortFunction));
			return;
		}
	}

	// Token: 0x0600EE18 RID: 60952 RVA: 0x0045C830 File Offset: 0x0045AA30
	private int WorldListSortFunction(OnlineHallData a, OnlineHallData b)
	{
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		if ((a.PlayerOriginWorldLevel > originWorldLevel && b.PlayerOriginWorldLevel > originWorldLevel) || (a.PlayerOriginWorldLevel <= originWorldLevel && b.PlayerOriginWorldLevel <= originWorldLevel))
		{
			return b.PlayerLastOfflineTime.CompareTo(a.PlayerLastOfflineTime);
		}
		return a.PlayerOriginWorldLevel - b.PlayerOriginWorldLevel;
	}

	// Token: 0x0600EE19 RID: 60953 RVA: 0x0045C88E File Offset: 0x0045AA8E
	public void PushCurrentApplyList(OnlineApplyData data)
	{
		this.ApplyMap[data.PlayerId] = data;
		if (this.Apply == -1)
		{
			this.Apply = data.PlayerId;
		}
	}

	// Token: 0x0600EE1A RID: 60954 RVA: 0x0045C8B7 File Offset: 0x0045AAB7
	public void PushCurrentTeamList(OnlineTeamData data)
	{
		this.OnlineTeamMap[data.PlayerId] = data;
		KuroSdkModel.Instance.RefreshPlayerChatPermissionByPlayerDetails(data.PlayerDetails);
	}

	// Token: 0x0600EE1B RID: 60955 RVA: 0x0045C8DC File Offset: 0x0045AADC
	public void DeleteCurrentApplyListById(int id)
	{
		this.ApplyMap.Remove(id);
		if (this.ApplyMap.Count < 1)
		{
			this.Apply = -1;
			return;
		}
		double num = (double)this.ApplyCdTime;
		foreach (KeyValuePair<int, OnlineApplyData> keyValuePair in this.ApplyMap)
		{
			OnlineApplyData value = keyValuePair.Value;
			if (value.ApplyTimeLeftTime <= num)
			{
				num = value.ApplyTimeLeftTime;
				this.Apply = keyValuePair.Key;
			}
		}
	}

	// Token: 0x0600EE1C RID: 60956 RVA: 0x0045C978 File Offset: 0x0045AB78
	public void DeleteCurrentTeamListById(int id)
	{
		this.OnlineTeamMap.Remove(id);
	}

	// Token: 0x0600EE1D RID: 60957 RVA: 0x0045C988 File Offset: 0x0045AB88
	public void ResetTeamDataPlayer(int deletePlayerNumber)
	{
		foreach (KeyValuePair<int, OnlineTeamData> keyValuePair in this.OnlineTeamMap)
		{
			OnlineTeamData value = keyValuePair.Value;
			if (value.PlayerNumber > deletePlayerNumber)
			{
				OnlineTeamData onlineTeamData = value;
				int playerNumber = onlineTeamData.PlayerNumber;
				onlineTeamData.PlayerNumber = playerNumber - 1;
			}
		}
	}

	// Token: 0x0600EE1E RID: 60958 RVA: 0x0045C9F8 File Offset: 0x0045ABF8
	[NullableContext(2)]
	public OnlineApplyData GetCurrentApplyListById(int id)
	{
		if (!this.ApplyMap.ContainsKey(id))
		{
			return null;
		}
		return this.ApplyMap[id];
	}

	// Token: 0x0600EE1F RID: 60959 RVA: 0x0045CA16 File Offset: 0x0045AC16
	[NullableContext(2)]
	public OnlineTeamData GetCurrentTeamListById(int id)
	{
		if (!this.OnlineTeamMap.ContainsKey(id))
		{
			return null;
		}
		return this.OnlineTeamMap[id];
	}

	// Token: 0x0600EE20 RID: 60960 RVA: 0x0045CA34 File Offset: 0x0045AC34
	public OnlineApplyData[] GetCurrentApplyList()
	{
		List<OnlineApplyData> list = new List<OnlineApplyData>();
		foreach (KeyValuePair<int, OnlineApplyData> keyValuePair in this.ApplyMap)
		{
			if (keyValuePair.Key > 0)
			{
				list.Add(keyValuePair.Value);
			}
		}
		list.Sort((OnlineApplyData a, OnlineApplyData b) => a.ApplyTimeLeftTime.CompareTo(b.ApplyTimeLeftTime));
		return list.ToArray();
	}

	// Token: 0x0600EE21 RID: 60961 RVA: 0x0045CAC8 File Offset: 0x0045ACC8
	public int GetCurrentApplySize()
	{
		return this.ApplyMap.Count;
	}

	// Token: 0x0600EE22 RID: 60962 RVA: 0x0045CAD5 File Offset: 0x0045ACD5
	public int GetCurrentTeamSize()
	{
		return this.OnlineTeamMap.Count;
	}

	// Token: 0x0600EE23 RID: 60963 RVA: 0x0045CAE2 File Offset: 0x0045ACE2
	public bool GetIsTeamModel()
	{
		return this.TeamOwnerId != -1;
	}

	// Token: 0x0600EE24 RID: 60964 RVA: 0x0045CAF0 File Offset: 0x0045ACF0
	public bool GetIsMyTeam()
	{
		int ownerId = this.OwnerId;
		int? id = PlayerInfoModel.Instance.GetId();
		return ownerId == id.GetValueOrDefault() & id != null;
	}

	// Token: 0x0600EE25 RID: 60965 RVA: 0x0045CB1F File Offset: 0x0045AD1F
	public bool GetExistOnlineTeam()
	{
		return this.OwnerId != -1;
	}

	// Token: 0x0600EE26 RID: 60966 RVA: 0x0045CB30 File Offset: 0x0045AD30
	public List<OnlineHallData> GetCanJoinFormStranger()
	{
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		List<OnlineHallData> list = new List<OnlineHallData>();
		foreach (OnlineHallData onlineHallData in this.StrangerWorldList)
		{
			if (onlineHallData.WorldLevel <= curWorldLevel + this.EnterDiff)
			{
				list.Add(onlineHallData);
			}
		}
		return list;
	}

	// Token: 0x0600EE27 RID: 60967 RVA: 0x0045CBA8 File Offset: 0x0045ADA8
	public List<OnlineHallData> GetCanJoinFormFriend()
	{
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		List<OnlineHallData> list = new List<OnlineHallData>();
		foreach (OnlineHallData onlineHallData in this.FriendWorldList)
		{
			if (this.CanJoinOtherWorld(curWorldLevel, onlineHallData.WorldLevel))
			{
				list.Add(onlineHallData);
			}
		}
		return list;
	}

	// Token: 0x0600EE28 RID: 60968 RVA: 0x0045CC1C File Offset: 0x0045AE1C
	public bool CanJoinOtherWorld(int myWorldLevel, int otherWorldLevel)
	{
		return myWorldLevel + this.EnterDiff >= otherWorldLevel;
	}

	// Token: 0x0600EE29 RID: 60969 RVA: 0x0045CC2C File Offset: 0x0045AE2C
	public List<OnlineTeamData> GetTeamList()
	{
		List<OnlineTeamData> list = new List<OnlineTeamData>();
		foreach (KeyValuePair<int, OnlineTeamData> keyValuePair in this.OnlineTeamMap)
		{
			list.Add(keyValuePair.Value);
		}
		list.Sort((OnlineTeamData a, OnlineTeamData b) => a.PlayerNumber - b.PlayerNumber);
		return list;
	}

	// Token: 0x0600EE2A RID: 60970 RVA: 0x0045CCB4 File Offset: 0x0045AEB4
	public void DisableOnline(EDisableOnlineType type, bool enable, int treeId = 0, int nodeId = 0)
	{
		if (enable)
		{
			bool flag = false;
			foreach (KeyValuePair<DisableOnlineSource, EDisableOnlineType> keyValuePair in this.DisableOnlineSource)
			{
				DisableOnlineSource key = keyValuePair.Key;
				if (key.TreeId == treeId && key.NodeId == nodeId && key.Type == type)
				{
					this.DisableOnlineSource[key] = type;
					flag = true;
				}
			}
			if (!flag)
			{
				DisableOnlineSource key2 = new DisableOnlineSource
				{
					Type = type,
					TreeId = treeId,
					NodeId = nodeId
				};
				this.DisableOnlineSource[key2] = type;
			}
		}
		else
		{
			List<DisableOnlineSource> list = new List<DisableOnlineSource>();
			foreach (KeyValuePair<DisableOnlineSource, EDisableOnlineType> keyValuePair2 in this.DisableOnlineSource)
			{
				DisableOnlineSource key3 = keyValuePair2.Key;
				if (key3.TreeId == treeId && key3.NodeId == nodeId && key3.Type == type)
				{
					list.Add(key3);
				}
			}
			foreach (DisableOnlineSource key4 in list)
			{
				this.DisableOnlineSource.Remove(key4);
			}
		}
		EventSystem.Instance.Emit(EEventName.OnlineDisableStateChange);
	}

	// Token: 0x0600EE2B RID: 60971 RVA: 0x0045CE3C File Offset: 0x0045B03C
	public bool IsOnlineDisabled()
	{
		return this.DisableOnlineSource != null && this.DisableOnlineSource.Count > 0;
	}

	// Token: 0x0600EE2C RID: 60972 RVA: 0x0045CE56 File Offset: 0x0045B056
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyDictionary<DisableOnlineSource, EDisableOnlineType> GetOnlineDisabledSource()
	{
		return this.DisableOnlineSource;
	}

	// Token: 0x0600EE2D RID: 60973 RVA: 0x0045CE5E File Offset: 0x0045B05E
	public void ClearWorldTeamPlayerFightInfo()
	{
		this.WorldTeamPlayerFightInfo.Clear();
	}

	// Token: 0x0600EE2E RID: 60974 RVA: 0x0045CE6C File Offset: 0x0045B06C
	public void DeleteWorldTeamPlayerFightInfo(int playerId)
	{
		for (int i = this.WorldTeamPlayerFightInfo.Count - 1; i >= 0; i--)
		{
			if (this.WorldTeamPlayerFightInfo[i].PlayerId == playerId)
			{
				this.WorldTeamPlayerFightInfo.RemoveAt(i);
			}
		}
	}

	// Token: 0x0600EE2F RID: 60975 RVA: 0x0045CEB1 File Offset: 0x0045B0B1
	public void PushWorldTeamPlayerFightInfo(global::WorldTeamPlayerFightInfo playerInfo)
	{
		this.WorldTeamPlayerFightInfo.Add(playerInfo);
	}

	// Token: 0x0600EE30 RID: 60976 RVA: 0x0045CEC0 File Offset: 0x0045B0C0
	[NullableContext(2)]
	public global::WorldTeamPlayerFightInfo GetWorldTeamPlayerFightInfo(int playerId)
	{
		foreach (global::WorldTeamPlayerFightInfo worldTeamPlayerFightInfo in this.WorldTeamPlayerFightInfo)
		{
			if (worldTeamPlayerFightInfo.PlayerId == playerId)
			{
				return worldTeamPlayerFightInfo;
			}
		}
		return null;
	}

	// Token: 0x0600EE31 RID: 60977 RVA: 0x0045CF1C File Offset: 0x0045B11C
	public int[] GetAllWorldTeamPlayer()
	{
		int[] array = new int[this.WorldTeamPlayerFightInfo.Count];
		for (int i = 0; i < this.WorldTeamPlayerFightInfo.Count; i++)
		{
			array[i] = this.WorldTeamPlayerFightInfo[i].PlayerId;
		}
		return array;
	}

	// Token: 0x0600EE32 RID: 60978 RVA: 0x0045CF65 File Offset: 0x0045B165
	public int GetAllWorldTeamPlayerLength()
	{
		return this.WorldTeamPlayerFightInfo.Count;
	}

	// Token: 0x0600EE33 RID: 60979 RVA: 0x0045CF74 File Offset: 0x0045B174
	public void RefreshWorldTeamRoleInfo(IList<PlayerFightFormations> playersFormations)
	{
		foreach (PlayerFightFormations playerFightFormations in playersFormations)
		{
			global::WorldTeamPlayerFightInfo worldTeamPlayerFightInfo = this.GetWorldTeamPlayerFightInfo(playerFightFormations.PlayerId);
			if (worldTeamPlayerFightInfo != null)
			{
				foreach (FightFormationNotifyInfo fightFormationNotifyInfo in playerFightFormations.Formations)
				{
					if (fightFormationNotifyInfo.FormationId == -1)
					{
						List<global::WorldTeamRoleInfo> list = new List<global::WorldTeamRoleInfo>();
						foreach (Aki.Protocol.FormationRoleInfo formationRoleInfo in fightFormationNotifyInfo.RoleInfos)
						{
							list.Add(new global::WorldTeamRoleInfo(formationRoleInfo.RoleId, formationRoleInfo.RoleSkinId, formationRoleInfo.Level));
						}
						worldTeamPlayerFightInfo.RoleInfos = list;
					}
				}
			}
		}
	}

	// Token: 0x0600EE34 RID: 60980 RVA: 0x0045D07C File Offset: 0x0045B27C
	public void ResetContinuingChallengeConfirmState()
	{
		this.ContinuingChallengeConfirmState.Clear();
		foreach (ScenePlayerData scenePlayerData in CreatureModel.Instance.GetAllScenePlayers())
		{
			int playerId = scenePlayerData.GetPlayerId();
			this.ContinuingChallengeConfirmState[playerId] = EContinuingChallenge.Pending;
		}
	}

	// Token: 0x0600EE35 RID: 60981 RVA: 0x0045D0EC File Offset: 0x0045B2EC
	public void SetContinuingChallengeConfirmState(int playerId, EContinuingChallenge bConfirm)
	{
		this.ContinuingChallengeConfirmState[playerId] = bConfirm;
	}

	// Token: 0x0600EE36 RID: 60982 RVA: 0x0045D0FC File Offset: 0x0045B2FC
	public EContinuingChallenge? GetContinuingChallengeConfirmState(int playerId)
	{
		if (!this.ContinuingChallengeConfirmState.ContainsKey(playerId))
		{
			return null;
		}
		return new EContinuingChallenge?(this.ContinuingChallengeConfirmState[playerId]);
	}

	// Token: 0x0600EE37 RID: 60983 RVA: 0x0045D132 File Offset: 0x0045B332
	public void SetChallengeApplyPlayerId(int playerId)
	{
		this.InitiateChallengeApplyPlayerId = playerId;
	}

	// Token: 0x0600EE38 RID: 60984 RVA: 0x0045D13B File Offset: 0x0045B33B
	public void RefreshInitiateTime()
	{
		this.NextAllowInitiateTime = TimeUtil.Instance.GetServerTime() + (double)this.ApplyCd;
	}

	// Token: 0x0600EE39 RID: 60985 RVA: 0x0045D155 File Offset: 0x0045B355
	public void SetAllowInitiate(bool allow)
	{
		this.CanInitiate = allow;
	}

	// Token: 0x0600EE3A RID: 60986 RVA: 0x0045D15E File Offset: 0x0045B35E
	public void SetPlayerTeleportState(int playerId, EPlayerTeleportState state)
	{
		this.PlayerTeleportState[playerId] = state;
	}

	// Token: 0x0600EE3B RID: 60987 RVA: 0x0045D170 File Offset: 0x0045B370
	public EPlayerTeleportState? GetPlayerTeleportState(int playerId)
	{
		if (!this.PlayerTeleportState.ContainsKey(playerId))
		{
			return null;
		}
		return new EPlayerTeleportState?(this.PlayerTeleportState[playerId]);
	}

	// Token: 0x0600EE3C RID: 60988 RVA: 0x0045D1A6 File Offset: 0x0045B3A6
	public void DeletePlayerTeleportState(int playerId)
	{
		this.PlayerTeleportState.Remove(playerId);
	}

	// Token: 0x0600EE3D RID: 60989 RVA: 0x0045D1B5 File Offset: 0x0045B3B5
	public void ClearPlayerTeleportState()
	{
		this.PlayerTeleportState.Clear();
	}

	// Token: 0x0600EE3E RID: 60990 RVA: 0x0045D1C4 File Offset: 0x0045B3C4
	public void SetRoleActivated(int playerId, bool bActivated)
	{
		HashSet<int> hashSet = this.PlayerEntityDisableHandleMap.ContainsKey(playerId) ? this.PlayerEntityDisableHandleMap[playerId] : null;
		if (bActivated)
		{
			if (hashSet != null)
			{
				foreach (int entityId in hashSet)
				{
					EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
					WorldEntity worldEntity = (entityById != null) ? entityById.Entity : null;
					if (worldEntity != null && worldEntity.Valid)
					{
						worldEntity.EnableByKey(EEntityDisableKey.Teleport, true);
					}
				}
				this.PlayerEntityDisableHandleMap.Remove(playerId);
			}
			return;
		}
		Entity entity = null;
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)playerId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.PlayerId,
			IsControl = new bool?(true)
		});
		if (teamItem != null)
		{
			EntityHandle entity2 = CreatureModel.Instance.GetEntity(teamItem.GetCreatureDataId());
			entity = ((entity2 != null) ? entity2.Entity : null);
		}
		if (entity == null || !entity.Valid)
		{
			return;
		}
		if (hashSet == null)
		{
			hashSet = new HashSet<int>();
			this.PlayerEntityDisableHandleMap[playerId] = hashSet;
		}
		if (hashSet.Contains(entity.Id))
		{
			return;
		}
		entity.DisableByKey(EEntityDisableKey.Teleport, true);
		hashSet.Add(entity.Id);
	}

	// Token: 0x0600EE3F RID: 60991 RVA: 0x0045D304 File Offset: 0x0045B504
	public void RemovePlayerDisableHandles(int playerId)
	{
		this.PlayerEntityDisableHandleMap.Remove(playerId);
	}

	// Token: 0x0600EE40 RID: 60992 RVA: 0x0045D314 File Offset: 0x0045B514
	public EPlayStationJoinAble GetGameJoinTypeToPlayStationJoinType()
	{
		EPlayStationJoinAble result;
		switch (OnlineModel.Instance.CurrentPermissionsSetting)
		{
		case WorldEnterPermission.ConfirmJoin:
		case WorldEnterPermission.DirectJoin:
			result = EPlayStationJoinAble.Anyone;
			break;
		case WorldEnterPermission.ForbidJoin:
			result = EPlayStationJoinAble.NoOne;
			break;
		case WorldEnterPermission.OnlyFriendJoin:
			result = EPlayStationJoinAble.Friends;
			break;
		default:
			result = EPlayStationJoinAble.NotSet;
			break;
		}
		return result;
	}

	// Token: 0x0600EE41 RID: 60993 RVA: 0x0045D355 File Offset: 0x0045B555
	public void ClearOtherScenePlayerDataList()
	{
		this.OtherScenePlayerDataList.Clear();
	}

	// Token: 0x0600EE42 RID: 60994 RVA: 0x0045D364 File Offset: 0x0045B564
	public void DeleteOtherScenePlayerDataList(int playerId)
	{
		List<OtherScenePlayerData> list = new List<OtherScenePlayerData>();
		foreach (OtherScenePlayerData otherScenePlayerData in this.OtherScenePlayerDataList)
		{
			if (otherScenePlayerData.PlayerId != playerId)
			{
				list.Add(otherScenePlayerData);
			}
		}
		this.OtherScenePlayerDataList = list;
	}

	// Token: 0x0600EE43 RID: 60995 RVA: 0x0045D3D0 File Offset: 0x0045B5D0
	public void PushOtherScenePlayerDataList(OtherScenePlayerData playerInfo)
	{
		this.OtherScenePlayerDataList.Add(playerInfo);
		EventSystem.Instance.Emit(EEventName.ScenePlayerChanged);
	}

	// Token: 0x0600EE44 RID: 60996 RVA: 0x0045D3F0 File Offset: 0x0045B5F0
	[NullableContext(2)]
	public OtherScenePlayerData GetOtherScenePlayerDataByPlayerId(int playerId)
	{
		foreach (OtherScenePlayerData otherScenePlayerData in this.OtherScenePlayerDataList)
		{
			if (otherScenePlayerData.PlayerId == playerId)
			{
				return otherScenePlayerData;
			}
		}
		return null;
	}

	// Token: 0x0600EE45 RID: 60997 RVA: 0x0045D44C File Offset: 0x0045B64C
	[NullableContext(2)]
	public void SetPlayerGravityIsNormal(IVector gravity)
	{
		if (gravity == null)
		{
			this.IsNormalGravity = true;
		}
		else if (gravity.X != 0.0 || gravity.Y != 0.0 || gravity.Z != -1.0)
		{
			this.IsNormalGravity = false;
		}
		else
		{
			this.IsNormalGravity = true;
		}
		this.DisableOnline(EDisableOnlineType.Gravity, !this.IsNormalGravity, 0, 0);
	}

	// Token: 0x0600EE46 RID: 60998 RVA: 0x0045D4BC File Offset: 0x0045B6BC
	public string GetMultiInstanceRecommendLevelText(int instanceDungeonId)
	{
		string result = "";
		int ownerId = this.OwnerId;
		int worldLevel = this.GetCurrentTeamListById(ownerId).WorldLevel;
		int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceDungeonId, worldLevel);
		if (recommendLevel > 0)
		{
			result = "-" + StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RecommendLevel", null) ?? "", new string[]
			{
				recommendLevel.ToString()
			});
		}
		return result;
	}

	// Token: 0x170016DE RID: 5854
	// (get) Token: 0x0600EE47 RID: 60999 RVA: 0x0045D529 File Offset: 0x0045B729
	public static OnlineModel Instance
	{
		get
		{
			return OnlineModel._Instance;
		}
	}

	// Token: 0x0600EE48 RID: 61000 RVA: 0x0045D530 File Offset: 0x0045B730
	public static OnlineModel GetOrCreateInstance()
	{
		if (OnlineModel._Instance == null)
		{
			OnlineModel.CreateInstance();
		}
		return OnlineModel._Instance;
	}

	// Token: 0x0600EE49 RID: 61001 RVA: 0x0045D544 File Offset: 0x0045B744
	public static bool CreateInstance()
	{
		if (OnlineModel._Instance != null)
		{
			return true;
		}
		OnlineModel._Instance = new OnlineModel();
		return true;
	}

	// Token: 0x0600EE4A RID: 61002 RVA: 0x0045D55A File Offset: 0x0045B75A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EE4B RID: 61003 RVA: 0x0045D55C File Offset: 0x0045B75C
	public static void ResetStaticDefaultValue()
	{
		OnlineModel._Instance = null;
	}

	// Token: 0x0600EE4C RID: 61004 RVA: 0x0045D564 File Offset: 0x0045B764
	static OnlineModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(OnlineModel.CreateStaticDefaultValue), new Action(OnlineModel.ResetStaticDefaultValue));
	}

	// Token: 0x040086CF RID: 34511
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<OnlineHallData> StrangerWorldList;

	// Token: 0x040086D0 RID: 34512
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<OnlineHallData> FriendWorldList;

	// Token: 0x040086D1 RID: 34513
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<OnlineHallData> SearchResultList;

	// Token: 0x040086D2 RID: 34514
	public List<global::WorldTeamPlayerFightInfo> WorldTeamPlayerFightInfo = new List<global::WorldTeamPlayerFightInfo>();

	// Token: 0x040086D3 RID: 34515
	private WorldEnterPermission PermissionsSetting;

	// Token: 0x040086D4 RID: 34516
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, OnlineApplyData> ApplyMap;

	// Token: 0x040086D5 RID: 34517
	private int Apply;

	// Token: 0x040086D6 RID: 34518
	private int ApplyCdTime;

	// Token: 0x040086D7 RID: 34519
	private int WorldEnterDiff;

	// Token: 0x040086D8 RID: 34520
	private int TeamOwnerId;

	// Token: 0x040086D9 RID: 34521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, OnlineTeamData> OnlineTeamMap;

	// Token: 0x040086DA RID: 34522
	private readonly int OnlineTeamMaxSize = 3;

	// Token: 0x040086DB RID: 34523
	private bool HallShowFriend;

	// Token: 0x040086DC RID: 34524
	private bool HallShowCanJoin;

	// Token: 0x040086DD RID: 34525
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<DisableOnlineSource, EDisableOnlineType> DisableOnlineSource;

	// Token: 0x040086DE RID: 34526
	private readonly Dictionary<int, EContinuingChallenge> ContinuingChallengeConfirmState = new Dictionary<int, EContinuingChallenge>();

	// Token: 0x040086DF RID: 34527
	private int InitiateChallengeApplyPlayerId = -1;

	// Token: 0x040086E0 RID: 34528
	private double NextAllowInitiateTime = -1.0;

	// Token: 0x040086E1 RID: 34529
	private bool CanInitiate = true;

	// Token: 0x040086E2 RID: 34530
	private readonly Dictionary<int, EPlayerTeleportState> PlayerTeleportState = new Dictionary<int, EPlayerTeleportState>();

	// Token: 0x040086E3 RID: 34531
	[Nullable(2)]
	public IOnlinePlayerData CachePlayerData;

	// Token: 0x040086E4 RID: 34532
	public bool SingleTipsOpen;

	// Token: 0x040086E5 RID: 34533
	private readonly Dictionary<int, HashSet<int>> PlayerEntityDisableHandleMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x040086E6 RID: 34534
	public List<OtherScenePlayerData> OtherScenePlayerDataList = new List<OtherScenePlayerData>();

	// Token: 0x040086E7 RID: 34535
	private bool IsNormalGravity = true;

	// Token: 0x040086E8 RID: 34536
	public bool HallViewIsShowSearching;

	// Token: 0x040086E9 RID: 34537
	[Nullable(2)]
	private static OnlineModel _Instance;
}
