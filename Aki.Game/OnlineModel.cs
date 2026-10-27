using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x020022E8 RID: 8936
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class OnlineModel : ModelBase
{
	// Token: 0x0601195F RID: 72031 RVA: 0x0044F7C4 File Offset: 0x0044D9C4
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

	// Token: 0x06011960 RID: 72032 RVA: 0x0044F854 File Offset: 0x0044DA54
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

	// Token: 0x06011961 RID: 72033 RVA: 0x0044F944 File Offset: 0x0044DB44
	protected override bool OnLeaveLevel()
	{
		this.ContinuingChallengeConfirmState.Clear();
		this.InitiateChallengeApplyPlayerId = -1;
		this.NextAllowInitiateTime = -1.0;
		this.CanInitiate = true;
		this.PlayerEntityDisableHandleMap.Clear();
		return true;
	}

	// Token: 0x06011962 RID: 72034 RVA: 0x0044F97A File Offset: 0x0044DB7A
	protected override bool OnChangeMode()
	{
		this.PlayerEntityDisableHandleMap.Clear();
		return true;
	}

	// Token: 0x06011963 RID: 72035 RVA: 0x0044F988 File Offset: 0x0044DB88
	public void ClearOnlineTeamMap()
	{
		if (this.OnlineTeamMap != null)
		{
			this.OnlineTeamMap.Clear();
		}
	}

	// Token: 0x17001697 RID: 5783
	// (get) Token: 0x06011964 RID: 72036 RVA: 0x0044F99D File Offset: 0x0044DB9D
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

	// Token: 0x17001698 RID: 5784
	// (get) Token: 0x06011965 RID: 72037 RVA: 0x0044F9A5 File Offset: 0x0044DBA5
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

	// Token: 0x17001699 RID: 5785
	// (get) Token: 0x06011966 RID: 72038 RVA: 0x0044F9AD File Offset: 0x0044DBAD
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

	// Token: 0x1700169A RID: 5786
	// (get) Token: 0x06011967 RID: 72039 RVA: 0x0044F9B5 File Offset: 0x0044DBB5
	public WorldEnterPermission CurrentPermissionsSetting
	{
		get
		{
			return this.PermissionsSetting;
		}
	}

	// Token: 0x1700169B RID: 5787
	// (get) Token: 0x06011968 RID: 72040 RVA: 0x0044F9BD File Offset: 0x0044DBBD
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

	// Token: 0x1700169C RID: 5788
	// (get) Token: 0x06011969 RID: 72041 RVA: 0x0044F9E5 File Offset: 0x0044DBE5
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

	// Token: 0x1700169D RID: 5789
	// (get) Token: 0x0601196A RID: 72042 RVA: 0x0044F9ED File Offset: 0x0044DBED
	public int ApplyCd
	{
		get
		{
			return this.ApplyCdTime;
		}
	}

	// Token: 0x1700169E RID: 5790
	// (get) Token: 0x0601196B RID: 72043 RVA: 0x0044F9F5 File Offset: 0x0044DBF5
	public int EnterDiff
	{
		get
		{
			return this.WorldEnterDiff;
		}
	}

	// Token: 0x1700169F RID: 5791
	// (get) Token: 0x0601196C RID: 72044 RVA: 0x0044F9FD File Offset: 0x0044DBFD
	public int OwnerId
	{
		get
		{
			return this.TeamOwnerId;
		}
	}

	// Token: 0x170016A0 RID: 5792
	// (get) Token: 0x0601196D RID: 72045 RVA: 0x0044FA05 File Offset: 0x0044DC05
	public int TeamMaxSize
	{
		get
		{
			return this.OnlineTeamMaxSize;
		}
	}

	// Token: 0x170016A1 RID: 5793
	// (get) Token: 0x0601196E RID: 72046 RVA: 0x0044FA0D File Offset: 0x0044DC0D
	public bool ShowCanJoin
	{
		get
		{
			return this.HallShowCanJoin;
		}
	}

	// Token: 0x170016A2 RID: 5794
	// (get) Token: 0x0601196F RID: 72047 RVA: 0x0044FA15 File Offset: 0x0044DC15
	public bool ShowFriend
	{
		get
		{
			return this.HallShowFriend;
		}
	}

	// Token: 0x170016A3 RID: 5795
	// (get) Token: 0x06011970 RID: 72048 RVA: 0x0044FA1D File Offset: 0x0044DC1D
	public int ChallengeApplyPlayerId
	{
		get
		{
			return this.InitiateChallengeApplyPlayerId;
		}
	}

	// Token: 0x170016A4 RID: 5796
	// (get) Token: 0x06011971 RID: 72049 RVA: 0x0044FA25 File Offset: 0x0044DC25
	public double NextInitiateTime
	{
		get
		{
			return this.NextAllowInitiateTime;
		}
	}

	// Token: 0x170016A5 RID: 5797
	// (get) Token: 0x06011972 RID: 72050 RVA: 0x0044FA2D File Offset: 0x0044DC2D
	public double NextInitiateLeftTime
	{
		get
		{
			return this.NextAllowInitiateTime - TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x170016A6 RID: 5798
	// (get) Token: 0x06011973 RID: 72051 RVA: 0x0044FA40 File Offset: 0x0044DC40
	public bool AllowInitiate
	{
		get
		{
			return this.CanInitiate;
		}
	}

	// Token: 0x06011974 RID: 72052 RVA: 0x0044FA48 File Offset: 0x0044DC48
	public void SetHallShowCanJoin(bool isShow)
	{
		this.HallShowCanJoin = isShow;
	}

	// Token: 0x06011975 RID: 72053 RVA: 0x0044FA51 File Offset: 0x0044DC51
	public void SetHallShowFriend(bool isShow)
	{
		this.HallShowFriend = isShow;
	}

	// Token: 0x06011976 RID: 72054 RVA: 0x0044FA5A File Offset: 0x0044DC5A
	public void SetTeamOwnerId(int teamOwnerId)
	{
		this.TeamOwnerId = teamOwnerId;
	}

	// Token: 0x06011977 RID: 72055 RVA: 0x0044FA64 File Offset: 0x0044DC64
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

	// Token: 0x06011978 RID: 72056 RVA: 0x0044FAA8 File Offset: 0x0044DCA8
	public void CleanSearchResultList()
	{
		List<OnlineHallData> searchResultList = this.SearchResultList;
		if (searchResultList == null)
		{
			return;
		}
		searchResultList.Clear();
	}

	// Token: 0x06011979 RID: 72057 RVA: 0x0044FABA File Offset: 0x0044DCBA
	public void CleanFriendWorldList()
	{
		List<OnlineHallData> friendWorldList = this.FriendWorldList;
		if (friendWorldList == null)
		{
			return;
		}
		friendWorldList.Clear();
	}

	// Token: 0x0601197A RID: 72058 RVA: 0x0044FACC File Offset: 0x0044DCCC
	public void CleanStrangerWorldList()
	{
		List<OnlineHallData> strangerWorldList = this.StrangerWorldList;
		if (strangerWorldList == null)
		{
			return;
		}
		strangerWorldList.Clear();
	}

	// Token: 0x0601197B RID: 72059 RVA: 0x0044FADE File Offset: 0x0044DCDE
	public void CleanCurrentApply()
	{
		this.ApplyMap.Remove(this.Apply);
		this.Apply = -1;
	}

	// Token: 0x0601197C RID: 72060 RVA: 0x0044FAF9 File Offset: 0x0044DCF9
	public void PushSearchResultList(OnlineHallData data)
	{
		this.SearchResultList.Add(data);
	}

	// Token: 0x0601197D RID: 72061 RVA: 0x0044FB07 File Offset: 0x0044DD07
	public void PushFriendWorldList(OnlineHallData data)
	{
		this.FriendWorldList.Add(data);
	}

	// Token: 0x0601197E RID: 72062 RVA: 0x0044FB15 File Offset: 0x0044DD15
	public void PushStrangerWorldList(OnlineHallData data)
	{
		this.StrangerWorldList.Add(data);
	}

	// Token: 0x0601197F RID: 72063 RVA: 0x0044FB23 File Offset: 0x0044DD23
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

	// Token: 0x06011980 RID: 72064 RVA: 0x0044FB64 File Offset: 0x0044DD64
	private int WorldListSortFunction(OnlineHallData a, OnlineHallData b)
	{
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		if ((a.PlayerOriginWorldLevel > originWorldLevel && b.PlayerOriginWorldLevel > originWorldLevel) || (a.PlayerOriginWorldLevel <= originWorldLevel && b.PlayerOriginWorldLevel <= originWorldLevel))
		{
			return b.PlayerLastOfflineTime.CompareTo(a.PlayerLastOfflineTime);
		}
		return a.PlayerOriginWorldLevel - b.PlayerOriginWorldLevel;
	}

	// Token: 0x06011981 RID: 72065 RVA: 0x0044FBC2 File Offset: 0x0044DDC2
	public void PushCurrentApplyList(OnlineApplyData data)
	{
		this.ApplyMap[data.PlayerId] = data;
		if (this.Apply == -1)
		{
			this.Apply = data.PlayerId;
		}
	}

	// Token: 0x06011982 RID: 72066 RVA: 0x0044FBEB File Offset: 0x0044DDEB
	public void PushCurrentTeamList(OnlineTeamData data)
	{
		this.OnlineTeamMap[data.PlayerId] = data;
		KuroSdkModel.Instance.RefreshPlayerChatPermissionByPlayerDetails(data.PlayerDetails);
	}

	// Token: 0x06011983 RID: 72067 RVA: 0x0044FC10 File Offset: 0x0044DE10
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

	// Token: 0x06011984 RID: 72068 RVA: 0x0044FCAC File Offset: 0x0044DEAC
	public void DeleteCurrentTeamListById(int id)
	{
		this.OnlineTeamMap.Remove(id);
	}

	// Token: 0x06011985 RID: 72069 RVA: 0x0044FCBC File Offset: 0x0044DEBC
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

	// Token: 0x06011986 RID: 72070 RVA: 0x0044FD2C File Offset: 0x0044DF2C
	[NullableContext(2)]
	public OnlineApplyData GetCurrentApplyListById(int id)
	{
		if (!this.ApplyMap.ContainsKey(id))
		{
			return null;
		}
		return this.ApplyMap[id];
	}

	// Token: 0x06011987 RID: 72071 RVA: 0x0044FD4A File Offset: 0x0044DF4A
	[NullableContext(2)]
	public OnlineTeamData GetCurrentTeamListById(int id)
	{
		if (!this.OnlineTeamMap.ContainsKey(id))
		{
			return null;
		}
		return this.OnlineTeamMap[id];
	}

	// Token: 0x06011988 RID: 72072 RVA: 0x0044FD68 File Offset: 0x0044DF68
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

	// Token: 0x06011989 RID: 72073 RVA: 0x0044FDFC File Offset: 0x0044DFFC
	public int GetCurrentApplySize()
	{
		return this.ApplyMap.Count;
	}

	// Token: 0x0601198A RID: 72074 RVA: 0x0044FE09 File Offset: 0x0044E009
	public int GetCurrentTeamSize()
	{
		return this.OnlineTeamMap.Count;
	}

	// Token: 0x0601198B RID: 72075 RVA: 0x0044FE16 File Offset: 0x0044E016
	public bool GetIsTeamModel()
	{
		return this.TeamOwnerId != -1;
	}

	// Token: 0x0601198C RID: 72076 RVA: 0x0044FE24 File Offset: 0x0044E024
	public bool GetIsMyTeam()
	{
		int ownerId = this.OwnerId;
		int? id = PlayerInfoModel.Instance.GetId();
		return ownerId == id.GetValueOrDefault() & id != null;
	}

	// Token: 0x0601198D RID: 72077 RVA: 0x0044FE53 File Offset: 0x0044E053
	public bool GetExistOnlineTeam()
	{
		return this.OwnerId != -1;
	}

	// Token: 0x0601198E RID: 72078 RVA: 0x0044FE64 File Offset: 0x0044E064
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

	// Token: 0x0601198F RID: 72079 RVA: 0x0044FEDC File Offset: 0x0044E0DC
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

	// Token: 0x06011990 RID: 72080 RVA: 0x0044FF50 File Offset: 0x0044E150
	public bool CanJoinOtherWorld(int myWorldLevel, int otherWorldLevel)
	{
		return myWorldLevel + this.EnterDiff >= otherWorldLevel;
	}

	// Token: 0x06011991 RID: 72081 RVA: 0x0044FF60 File Offset: 0x0044E160
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

	// Token: 0x06011992 RID: 72082 RVA: 0x0044FFE8 File Offset: 0x0044E1E8
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

	// Token: 0x06011993 RID: 72083 RVA: 0x00450170 File Offset: 0x0044E370
	public bool IsOnlineDisabled()
	{
		return this.DisableOnlineSource != null && this.DisableOnlineSource.Count > 0;
	}

	// Token: 0x06011994 RID: 72084 RVA: 0x0045018A File Offset: 0x0044E38A
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyDictionary<DisableOnlineSource, EDisableOnlineType> GetOnlineDisabledSource()
	{
		return this.DisableOnlineSource;
	}

	// Token: 0x06011995 RID: 72085 RVA: 0x00450192 File Offset: 0x0044E392
	public void ClearWorldTeamPlayerFightInfo()
	{
		this.WorldTeamPlayerFightInfo.Clear();
	}

	// Token: 0x06011996 RID: 72086 RVA: 0x004501A0 File Offset: 0x0044E3A0
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

	// Token: 0x06011997 RID: 72087 RVA: 0x004501E5 File Offset: 0x0044E3E5
	public void PushWorldTeamPlayerFightInfo(global::WorldTeamPlayerFightInfo playerInfo)
	{
		this.WorldTeamPlayerFightInfo.Add(playerInfo);
	}

	// Token: 0x06011998 RID: 72088 RVA: 0x004501F4 File Offset: 0x0044E3F4
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

	// Token: 0x06011999 RID: 72089 RVA: 0x00450250 File Offset: 0x0044E450
	public int[] GetAllWorldTeamPlayer()
	{
		int[] array = new int[this.WorldTeamPlayerFightInfo.Count];
		for (int i = 0; i < this.WorldTeamPlayerFightInfo.Count; i++)
		{
			array[i] = this.WorldTeamPlayerFightInfo[i].PlayerId;
		}
		return array;
	}

	// Token: 0x0601199A RID: 72090 RVA: 0x00450299 File Offset: 0x0044E499
	public int GetAllWorldTeamPlayerLength()
	{
		return this.WorldTeamPlayerFightInfo.Count;
	}

	// Token: 0x0601199B RID: 72091 RVA: 0x004502A8 File Offset: 0x0044E4A8
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

	// Token: 0x0601199C RID: 72092 RVA: 0x004503B0 File Offset: 0x0044E5B0
	public void ResetContinuingChallengeConfirmState()
	{
		this.ContinuingChallengeConfirmState.Clear();
		foreach (ScenePlayerData scenePlayerData in CreatureModel.Instance.GetAllScenePlayers())
		{
			int playerId = scenePlayerData.GetPlayerId();
			this.ContinuingChallengeConfirmState[playerId] = EContinuingChallenge.Pending;
		}
	}

	// Token: 0x0601199D RID: 72093 RVA: 0x00450420 File Offset: 0x0044E620
	public void SetContinuingChallengeConfirmState(int playerId, EContinuingChallenge bConfirm)
	{
		this.ContinuingChallengeConfirmState[playerId] = bConfirm;
	}

	// Token: 0x0601199E RID: 72094 RVA: 0x00450430 File Offset: 0x0044E630
	public EContinuingChallenge? GetContinuingChallengeConfirmState(int playerId)
	{
		if (!this.ContinuingChallengeConfirmState.ContainsKey(playerId))
		{
			return null;
		}
		return new EContinuingChallenge?(this.ContinuingChallengeConfirmState[playerId]);
	}

	// Token: 0x0601199F RID: 72095 RVA: 0x00450466 File Offset: 0x0044E666
	public void SetChallengeApplyPlayerId(int playerId)
	{
		this.InitiateChallengeApplyPlayerId = playerId;
	}

	// Token: 0x060119A0 RID: 72096 RVA: 0x0045046F File Offset: 0x0044E66F
	public void RefreshInitiateTime()
	{
		this.NextAllowInitiateTime = TimeUtil.Instance.GetServerTime() + (double)this.ApplyCd;
	}

	// Token: 0x060119A1 RID: 72097 RVA: 0x00450489 File Offset: 0x0044E689
	public void SetAllowInitiate(bool allow)
	{
		this.CanInitiate = allow;
	}

	// Token: 0x060119A2 RID: 72098 RVA: 0x00450492 File Offset: 0x0044E692
	public void SetPlayerTeleportState(int playerId, EPlayerTeleportState state)
	{
		this.PlayerTeleportState[playerId] = state;
	}

	// Token: 0x060119A3 RID: 72099 RVA: 0x004504A4 File Offset: 0x0044E6A4
	public EPlayerTeleportState? GetPlayerTeleportState(int playerId)
	{
		if (!this.PlayerTeleportState.ContainsKey(playerId))
		{
			return null;
		}
		return new EPlayerTeleportState?(this.PlayerTeleportState[playerId]);
	}

	// Token: 0x060119A4 RID: 72100 RVA: 0x004504DA File Offset: 0x0044E6DA
	public void DeletePlayerTeleportState(int playerId)
	{
		this.PlayerTeleportState.Remove(playerId);
	}

	// Token: 0x060119A5 RID: 72101 RVA: 0x004504E9 File Offset: 0x0044E6E9
	public void ClearPlayerTeleportState()
	{
		this.PlayerTeleportState.Clear();
	}

	// Token: 0x060119A6 RID: 72102 RVA: 0x004504F8 File Offset: 0x0044E6F8
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

	// Token: 0x060119A7 RID: 72103 RVA: 0x00450638 File Offset: 0x0044E838
	public void RemovePlayerDisableHandles(int playerId)
	{
		this.PlayerEntityDisableHandleMap.Remove(playerId);
	}

	// Token: 0x060119A8 RID: 72104 RVA: 0x00450648 File Offset: 0x0044E848
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

	// Token: 0x060119A9 RID: 72105 RVA: 0x00450689 File Offset: 0x0044E889
	public void ClearOtherScenePlayerDataList()
	{
		this.OtherScenePlayerDataList.Clear();
	}

	// Token: 0x060119AA RID: 72106 RVA: 0x00450698 File Offset: 0x0044E898
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

	// Token: 0x060119AB RID: 72107 RVA: 0x00450704 File Offset: 0x0044E904
	public void PushOtherScenePlayerDataList(OtherScenePlayerData playerInfo)
	{
		this.OtherScenePlayerDataList.Add(playerInfo);
		EventSystem.Instance.Emit(EEventName.ScenePlayerChanged);
	}

	// Token: 0x060119AC RID: 72108 RVA: 0x00450724 File Offset: 0x0044E924
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

	// Token: 0x060119AD RID: 72109 RVA: 0x00450780 File Offset: 0x0044E980
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

	// Token: 0x060119AE RID: 72110 RVA: 0x004507F0 File Offset: 0x0044E9F0
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

	// Token: 0x170016A7 RID: 5799
	// (get) Token: 0x060119AF RID: 72111 RVA: 0x0045085D File Offset: 0x0044EA5D
	public static OnlineModel Instance
	{
		get
		{
			return OnlineModel._Instance;
		}
	}

	// Token: 0x060119B0 RID: 72112 RVA: 0x00450864 File Offset: 0x0044EA64
	public static OnlineModel GetOrCreateInstance()
	{
		if (OnlineModel._Instance == null)
		{
			OnlineModel.CreateInstance();
		}
		return OnlineModel._Instance;
	}

	// Token: 0x060119B1 RID: 72113 RVA: 0x00450878 File Offset: 0x0044EA78
	public static bool CreateInstance()
	{
		if (OnlineModel._Instance != null)
		{
			return true;
		}
		OnlineModel._Instance = new OnlineModel();
		return true;
	}

	// Token: 0x060119B2 RID: 72114 RVA: 0x0045088E File Offset: 0x0044EA8E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060119B3 RID: 72115 RVA: 0x00450890 File Offset: 0x0044EA90
	public static void ResetStaticDefaultValue()
	{
		OnlineModel._Instance = null;
	}

	// Token: 0x060119B4 RID: 72116 RVA: 0x00450898 File Offset: 0x0044EA98
	static OnlineModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(OnlineModel.CreateStaticDefaultValue), new Action(OnlineModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008591 RID: 34193
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<OnlineHallData> StrangerWorldList;

	// Token: 0x04008592 RID: 34194
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<OnlineHallData> FriendWorldList;

	// Token: 0x04008593 RID: 34195
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<OnlineHallData> SearchResultList;

	// Token: 0x04008594 RID: 34196
	public List<global::WorldTeamPlayerFightInfo> WorldTeamPlayerFightInfo = new List<global::WorldTeamPlayerFightInfo>();

	// Token: 0x04008595 RID: 34197
	private WorldEnterPermission PermissionsSetting;

	// Token: 0x04008596 RID: 34198
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, OnlineApplyData> ApplyMap;

	// Token: 0x04008597 RID: 34199
	private int Apply;

	// Token: 0x04008598 RID: 34200
	private int ApplyCdTime;

	// Token: 0x04008599 RID: 34201
	private int WorldEnterDiff;

	// Token: 0x0400859A RID: 34202
	private int TeamOwnerId;

	// Token: 0x0400859B RID: 34203
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, OnlineTeamData> OnlineTeamMap;

	// Token: 0x0400859C RID: 34204
	private readonly int OnlineTeamMaxSize = 3;

	// Token: 0x0400859D RID: 34205
	private bool HallShowFriend;

	// Token: 0x0400859E RID: 34206
	private bool HallShowCanJoin;

	// Token: 0x0400859F RID: 34207
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<DisableOnlineSource, EDisableOnlineType> DisableOnlineSource;

	// Token: 0x040085A0 RID: 34208
	private readonly Dictionary<int, EContinuingChallenge> ContinuingChallengeConfirmState = new Dictionary<int, EContinuingChallenge>();

	// Token: 0x040085A1 RID: 34209
	private int InitiateChallengeApplyPlayerId = -1;

	// Token: 0x040085A2 RID: 34210
	private double NextAllowInitiateTime = -1.0;

	// Token: 0x040085A3 RID: 34211
	private bool CanInitiate = true;

	// Token: 0x040085A4 RID: 34212
	private readonly Dictionary<int, EPlayerTeleportState> PlayerTeleportState = new Dictionary<int, EPlayerTeleportState>();

	// Token: 0x040085A5 RID: 34213
	[Nullable(2)]
	public IOnlinePlayerData CachePlayerData;

	// Token: 0x040085A6 RID: 34214
	public bool SingleTipsOpen;

	// Token: 0x040085A7 RID: 34215
	private readonly Dictionary<int, HashSet<int>> PlayerEntityDisableHandleMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x040085A8 RID: 34216
	public List<OtherScenePlayerData> OtherScenePlayerDataList = new List<OtherScenePlayerData>();

	// Token: 0x040085A9 RID: 34217
	private bool IsNormalGravity = true;

	// Token: 0x040085AA RID: 34218
	public bool HallViewIsShowSearching;

	// Token: 0x040085AB RID: 34219
	[Nullable(2)]
	private static OnlineModel _Instance;
}
