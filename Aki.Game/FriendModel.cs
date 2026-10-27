using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C35 RID: 7221
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FriendModel : ModelBase
{
	// Token: 0x0600D933 RID: 55603 RVA: 0x003251D8 File Offset: 0x003233D8
	protected override bool OnInit()
	{
		this.ApplyCdTime = ConfigCommonParamById.GetIntConfig("apply_valid_time").Value;
		return base.OnInit();
	}

	// Token: 0x0600D934 RID: 55604 RVA: 0x00325204 File Offset: 0x00323404
	protected override bool OnClear()
	{
		this.CurrentSelectedPlayerId = null;
		this.FriendFilterState = null;
		this.CurrentlyShowingView = null;
		this.FriendSearchResults.Clear();
		this.CurrentApplyFriendList.Clear();
		this.CurrentApproveFriendList.Clear();
		this.CurrentRefuseFriendList.Clear();
		this.SaveLocalFriendApplication();
		return true;
	}

	// Token: 0x0600D935 RID: 55605 RVA: 0x00325268 File Offset: 0x00323468
	public void LoadLocalFriendApplication()
	{
		Dictionary<int, LocalFriendApplication> dictionary = LocalStorage.GetPlayer<Dictionary<int, LocalFriendApplication>>(ELocalStoragePlayerKey.LocalFriendApplication, null) ?? new Dictionary<int, LocalFriendApplication>();
		foreach (FriendApplyData friendApplyData in this.MyFriendApplyList.Values)
		{
			LocalFriendApplication localFriendApplication;
			if (dictionary.TryGetValue(friendApplyData.ApplyPlayerData.PlayerId, out localFriendApplication) && localFriendApplication.CreatedTime == friendApplyData.ApplyCreatedTime)
			{
				friendApplyData.Fresh = localFriendApplication.Fresh;
				if (!friendApplyData.Fresh)
				{
					this.FreshFriendApplicationIds.Remove(friendApplyData.ApplyPlayerData.PlayerId);
				}
			}
		}
	}

	// Token: 0x0600D936 RID: 55606 RVA: 0x0032531C File Offset: 0x0032351C
	private void SaveLocalFriendApplication()
	{
		if (!LocalStorage.HasPlayerId())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Friend;
			ELogAuthor author = ELogAuthor.LJ;
			string message = "尚未获取到playerId，跳过好友申请本地缓存";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("申请数", this.MyFriendApplyList.Count);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Dictionary<int, LocalFriendApplication> dictionary = new Dictionary<int, LocalFriendApplication>();
		foreach (int key in this.MyFriendApplyList.Keys)
		{
			dictionary[key] = new LocalFriendApplication
			{
				Fresh = this.MyFriendApplyList[key].Fresh,
				CreatedTime = this.MyFriendApplyList[key].ApplyCreatedTime
			};
		}
		LocalStorage.SetPlayer<Dictionary<int, LocalFriendApplication>>(ELocalStoragePlayerKey.LocalFriendApplication, dictionary);
	}

	// Token: 0x0600D937 RID: 55607 RVA: 0x00325400 File Offset: 0x00323600
	public int GetFriendListCount()
	{
		return this.MyFriends.Count;
	}

	// Token: 0x0600D938 RID: 55608 RVA: 0x00325410 File Offset: 0x00323610
	public List<int> GetFriendSortedListIds()
	{
		List<int> list = new List<int>();
		foreach (FriendData friendData in this.MyFriends.Values)
		{
			if (friendData.CanShowInFriendList())
			{
				list.Add(friendData.PlayerId);
			}
		}
		return FriendController.Instance.GetSortedFriendListByRules(list, new Func<int, int, int>(FriendController.Instance.FriendListSortHook));
	}

	// Token: 0x0600D939 RID: 55609 RVA: 0x00325498 File Offset: 0x00323698
	public List<int> GetFriendApplyListIds()
	{
		List<int> list = new List<int>();
		foreach (FriendApplyData friendApplyData in this.MyFriendApplyList.Values)
		{
			if (friendApplyData.ApplyPlayerData != null && friendApplyData.ApplyPlayerData.CanShowInFriendList())
			{
				list.Add(friendApplyData.ApplyPlayerData.PlayerId);
			}
		}
		return FriendController.Instance.GetSortedBlackOrApplyList(list);
	}

	// Token: 0x0600D93A RID: 55610 RVA: 0x00325520 File Offset: 0x00323720
	public List<int> GetRecentlyTeamIds()
	{
		List<int> list = new List<int>();
		foreach (RecentlyTeamData recentlyTeamData in this.RecentlyTeamList.Values)
		{
			if (recentlyTeamData.PlayerData != null && recentlyTeamData.PlayerData.CanShowInFriendList())
			{
				list.Add(recentlyTeamData.PlayerData.PlayerId);
			}
		}
		list.Sort(delegate(int a, int b)
		{
			RecentlyTeamData recentlyTeamData2 = this.GetRecentlyTeamData(a);
			RecentlyTeamData recentlyTeamData3 = this.GetRecentlyTeamData(b);
			return recentlyTeamData2.TeamTime.CompareTo(recentlyTeamData3.TeamTime);
		});
		return list;
	}

	// Token: 0x0600D93B RID: 55611 RVA: 0x003255B0 File Offset: 0x003237B0
	public bool HasNewFriendApplication()
	{
		return this.FreshFriendApplicationIds.Count > 0;
	}

	// Token: 0x0600D93C RID: 55612 RVA: 0x003255C0 File Offset: 0x003237C0
	public List<int> GetFriendSearchResultListIds()
	{
		List<int> list = new List<int>();
		foreach (FriendData friendData in this.FriendSearchResults.Values)
		{
			list.Add(friendData.PlayerId);
		}
		list.Sort(delegate(int a, int b)
		{
			FriendData friendById = this.GetFriendById(a);
			FriendData friendById2 = this.GetFriendById(b);
			return friendById.PlayerId - friendById2.PlayerId;
		});
		return list;
	}

	// Token: 0x0600D93D RID: 55613 RVA: 0x00325638 File Offset: 0x00323838
	public List<int> GetBlackListIds()
	{
		List<int> list = new List<int>();
		foreach (int item in this.MyBlackList.Keys)
		{
			list.Add(item);
		}
		return FriendController.Instance.GetSortedBlackOrApplyList(list);
	}

	// Token: 0x0600D93E RID: 55614 RVA: 0x003256A4 File Offset: 0x003238A4
	[NullableContext(2)]
	public FriendData GetFriendById(int friendId)
	{
		if (friendId == 0)
		{
			Log.Instance.Error(ELogModule.Friend, ELogAuthor.YZY, "获取选中玩家时id不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (!this.MyFriends.ContainsKey(friendId))
		{
			return null;
		}
		return this.MyFriends[friendId];
	}

	// Token: 0x0600D93F RID: 55615 RVA: 0x003256F1 File Offset: 0x003238F1
	[NullableContext(2)]
	public FriendData GetFriendDataInApplicationById(int playerId)
	{
		if (this.MyFriendApplyList.ContainsKey(playerId))
		{
			return this.MyFriendApplyList[playerId].ApplyPlayerData;
		}
		return null;
	}

	// Token: 0x0600D940 RID: 55616 RVA: 0x00325714 File Offset: 0x00323914
	[NullableContext(2)]
	public FriendBlackListData GetBlockedPlayerById(int playerId)
	{
		if (!this.MyBlackList.ContainsKey(playerId))
		{
			return null;
		}
		return this.MyBlackList[playerId];
	}

	// Token: 0x0600D941 RID: 55617 RVA: 0x00325732 File Offset: 0x00323932
	[NullableContext(2)]
	public FriendData GetFriendSearchResultById(int playerId)
	{
		if (!this.FriendSearchResults.ContainsKey(playerId))
		{
			return null;
		}
		return this.FriendSearchResults[playerId];
	}

	// Token: 0x0600D942 RID: 55618 RVA: 0x00325750 File Offset: 0x00323950
	public void AddFriend(FriendData friend)
	{
		this.MyFriends.TryAdd(friend.PlayerId, friend);
	}

	// Token: 0x0600D943 RID: 55619 RVA: 0x00325765 File Offset: 0x00323965
	public bool HasFriend(int id)
	{
		return this.MyFriends.ContainsKey(id);
	}

	// Token: 0x0600D944 RID: 55620 RVA: 0x00325773 File Offset: 0x00323973
	public void DeleteFriend(int id)
	{
		if (this.MyFriends.ContainsKey(id))
		{
			this.MyFriends.Remove(id);
			EventSystem.Instance.Emit<int>(EEventName.OnRemoveFriend, id);
		}
		EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
	}

	// Token: 0x0600D945 RID: 55621 RVA: 0x003257B1 File Offset: 0x003239B1
	public bool IsMyFriend(int id)
	{
		return this.MyFriends.ContainsKey(id);
	}

	// Token: 0x0600D946 RID: 55622 RVA: 0x003257BF File Offset: 0x003239BF
	public void AddFriendApplication(FriendApplyData friendApply)
	{
		this.MyFriendApplyList[friendApply.ApplyPlayerData.PlayerId] = friendApply;
		if (friendApply.ApplyPlayerData.CanShowInFriendList())
		{
			this.FreshFriendApplicationIds.Add(friendApply.ApplyPlayerData.PlayerId);
		}
	}

	// Token: 0x0600D947 RID: 55623 RVA: 0x003257FC File Offset: 0x003239FC
	public bool HasFriendApplication(int id)
	{
		return this.MyFriendApplyList.ContainsKey(id);
	}

	// Token: 0x0600D948 RID: 55624 RVA: 0x0032580C File Offset: 0x00323A0C
	public void DeleteFriendApplication(int id)
	{
		if (this.MyFriendApplyList.ContainsKey(id))
		{
			this.MyFriendApplyList.Remove(id);
			if (this.FreshFriendApplicationIds.Contains(id))
			{
				this.FreshFriendApplicationIds.Remove(id);
			}
		}
		EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
	}

	// Token: 0x0600D949 RID: 55625 RVA: 0x00325860 File Offset: 0x00323A60
	public void MarkDirtyNewApplications()
	{
		foreach (FriendApplyData friendApplyData in this.MyFriendApplyList.Values)
		{
			friendApplyData.Fresh = false;
			this.FreshFriendApplicationIds.Remove(friendApplyData.ApplyPlayerData.PlayerId);
		}
	}

	// Token: 0x0600D94A RID: 55626 RVA: 0x003258D0 File Offset: 0x00323AD0
	public void AddFriendSearchResults(FriendData playerResult)
	{
		this.FriendSearchResults[playerResult.PlayerId] = playerResult;
	}

	// Token: 0x0600D94B RID: 55627 RVA: 0x003258E4 File Offset: 0x00323AE4
	public void ClearFriendSearchResults()
	{
		this.FriendSearchResults.Clear();
	}

	// Token: 0x0600D94C RID: 55628 RVA: 0x003258F1 File Offset: 0x00323AF1
	public void AddToBlackList(FriendBlackListData playerInfo)
	{
		this.MyBlackList[playerInfo.GetBlockedPlayerData.PlayerId] = playerInfo;
	}

	// Token: 0x0600D94D RID: 55629 RVA: 0x0032590A File Offset: 0x00323B0A
	public bool HasBlockedPlayer(int id)
	{
		return this.MyBlackList.ContainsKey(id);
	}

	// Token: 0x0600D94E RID: 55630 RVA: 0x00325918 File Offset: 0x00323B18
	public void DeleteBlockedPlayer(int playerId)
	{
		this.MyBlackList.Remove(playerId);
	}

	// Token: 0x0600D94F RID: 55631 RVA: 0x00325928 File Offset: 0x00323B28
	[NullableContext(2)]
	public FriendData GetSelectedPlayerOrItemInstance(int? id = null, EUiViewName? sourceView = null)
	{
		int? num = id;
		int? num2 = (num != null) ? num : this.CurrentSelectedPlayerId;
		EUiViewName? euiViewName = sourceView;
		EUiViewName? euiViewName2 = (euiViewName != null) ? euiViewName : this.ShowingView;
		if (euiViewName2 == null)
		{
			return null;
		}
		if (euiViewName2 == EUiViewName.FriendView)
		{
			if (this.FilterState.GetValueOrDefault() == EFriendFilter.FriendList)
			{
				return this.GetFriendById(num2.Value);
			}
			if (this.FilterState.GetValueOrDefault() == EFriendFilter.FriendRequest)
			{
				return this.GetFriendDataInApplicationById(num2.Value);
			}
			if (this.FilterState.GetValueOrDefault() == EFriendFilter.RecentMultiple)
			{
				return this.GetRecentlyTeamData(num2.Value).PlayerData;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Friend;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "所属页签错误！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("页签filter", this.FilterState);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		else if (euiViewName2 == EUiViewName.FriendSearchView)
		{
			if (this.IsMyFriend(num2.Value))
			{
				return this.GetFriendById(num2.Value);
			}
			return this.GetFriendSearchResultById(num2.Value);
		}
		else
		{
			if (euiViewName2 == EUiViewName.FriendBlackListView)
			{
				return this.GetBlockedPlayerById(num2.Value).GetBlockedPlayerData;
			}
			if (euiViewName2 == EUiViewName.OnlineWorldHallView)
			{
				return this.GetFriendById(num2.Value);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Friend;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "当前展示View错误！";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("view名", euiViewName2);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
	}

	// Token: 0x0600D950 RID: 55632 RVA: 0x00325B20 File Offset: 0x00323D20
	public void ResetShowingView()
	{
		this.ShowingView = new EUiViewName?(EUiViewName.FriendView);
	}

	// Token: 0x0600D951 RID: 55633 RVA: 0x00325B34 File Offset: 0x00323D34
	public void ClearTestFriendData()
	{
		if (!this.TestDataLoaded)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int num in this.MyFriends.Keys)
		{
			if (this.MyFriends[num].Debug)
			{
				list.Add(num);
			}
		}
		foreach (int key in list)
		{
			this.MyFriends.Remove(key);
		}
		list.Clear();
		foreach (int num2 in this.MyFriendApplyList.Keys)
		{
			if (this.MyFriendApplyList[num2].ApplyPlayerData.Debug)
			{
				list.Add(num2);
			}
		}
		foreach (int num3 in list)
		{
			this.MyFriendApplyList.Remove(num3);
			if (this.FreshFriendApplicationIds.Contains(num3))
			{
				this.FreshFriendApplicationIds.Remove(num3);
			}
		}
		list.Clear();
		foreach (int num4 in this.MyBlackList.Keys)
		{
			if (this.MyBlackList[num4].GetBlockedPlayerData.Debug)
			{
				list.Add(num4);
			}
		}
		foreach (int key2 in list)
		{
			this.MyBlackList.Remove(key2);
		}
		list.Clear();
		foreach (int num5 in this.FriendSearchResults.Keys)
		{
			if (this.FriendSearchResults[num5].Debug)
			{
				list.Add(num5);
			}
		}
		foreach (int key3 in list)
		{
			this.FriendSearchResults.Remove(key3);
		}
		this.TestDataLoaded = false;
	}

	// Token: 0x0600D952 RID: 55634 RVA: 0x00325E1C File Offset: 0x0032401C
	public bool CurrentApplyFriendListHasPlayer(int playerId)
	{
		return this.CurrentApplyFriendList.Contains(playerId);
	}

	// Token: 0x0600D953 RID: 55635 RVA: 0x00325E2A File Offset: 0x0032402A
	public void AddPlayerToApplyFriendList(int playerId)
	{
		if (!this.CurrentApplyFriendList.Contains(playerId))
		{
			this.CurrentApplyFriendList.Add(playerId);
		}
	}

	// Token: 0x0600D954 RID: 55636 RVA: 0x00325E47 File Offset: 0x00324047
	public void ClearApplyFriendList()
	{
		this.CurrentApplyFriendList.Clear();
	}

	// Token: 0x0600D955 RID: 55637 RVA: 0x00325E54 File Offset: 0x00324054
	public bool CurrentApproveFriendListHasPlayer(int playerId)
	{
		return this.CurrentApproveFriendList.Contains(playerId);
	}

	// Token: 0x0600D956 RID: 55638 RVA: 0x00325E62 File Offset: 0x00324062
	public void AddPlayerToApproveFriendList(int playerId)
	{
		if (!this.CurrentApproveFriendList.Contains(playerId))
		{
			this.CurrentApproveFriendList.Add(playerId);
		}
	}

	// Token: 0x0600D957 RID: 55639 RVA: 0x00325E7F File Offset: 0x0032407F
	public void ClearApproveFriendList()
	{
		this.CurrentApproveFriendList.Clear();
	}

	// Token: 0x0600D958 RID: 55640 RVA: 0x00325E8C File Offset: 0x0032408C
	public bool CurrentRefuseFriendListHasPlayer(int playerId)
	{
		return this.CurrentRefuseFriendList.Contains(playerId);
	}

	// Token: 0x0600D959 RID: 55641 RVA: 0x00325E9A File Offset: 0x0032409A
	public void AddPlayerToRefuseFriendList(int playerId)
	{
		if (!this.CurrentRefuseFriendList.Contains(playerId))
		{
			this.CurrentRefuseFriendList.Add(playerId);
		}
	}

	// Token: 0x0600D95A RID: 55642 RVA: 0x00325EB8 File Offset: 0x003240B8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public static ValueTuple<string, int> GetOfflineStrAndGap(long offlineTimeStamp)
	{
		int num = TimeUtil.Instance.CalculateDayTimeStampGapBetweenNow((double)offlineTimeStamp, false);
		string item = "FriendOfflineToday";
		if (num <= 1)
		{
			item = "FriendOfflineToday";
		}
		else if (num > 1 && num <= 30)
		{
			item = "FriendOfflineSomeDay";
		}
		else if (num > 30)
		{
			item = "FriendOfflineOverMonth";
		}
		return new ValueTuple<string, int>(item, num);
	}

	// Token: 0x0600D95B RID: 55643 RVA: 0x00325F08 File Offset: 0x00324108
	public UniTask InitRecentlyTeamDataByResponse(RecentlyTeamInfo[] responseInfo)
	{
		FriendModel.<InitRecentlyTeamDataByResponse>d__56 <InitRecentlyTeamDataByResponse>d__;
		<InitRecentlyTeamDataByResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRecentlyTeamDataByResponse>d__.<>4__this = this;
		<InitRecentlyTeamDataByResponse>d__.responseInfo = responseInfo;
		<InitRecentlyTeamDataByResponse>d__.<>1__state = -1;
		<InitRecentlyTeamDataByResponse>d__.<>t__builder.Start<FriendModel.<InitRecentlyTeamDataByResponse>d__56>(ref <InitRecentlyTeamDataByResponse>d__);
		return <InitRecentlyTeamDataByResponse>d__.<>t__builder.Task;
	}

	// Token: 0x0600D95C RID: 55644 RVA: 0x00325F53 File Offset: 0x00324153
	[NullableContext(2)]
	public RecentlyTeamData GetRecentlyTeamData(int playerId)
	{
		if (!this.RecentlyTeamList.ContainsKey(playerId))
		{
			return null;
		}
		return this.RecentlyTeamList[playerId];
	}

	// Token: 0x0600D95D RID: 55645 RVA: 0x00325F71 File Offset: 0x00324171
	public void ClearRefuseFriendList()
	{
		this.CurrentRefuseFriendList.Clear();
	}

	// Token: 0x0600D95E RID: 55646 RVA: 0x00325F80 File Offset: 0x00324180
	public List<FriendApplyData> GetApplyViewDataList([Nullable(2)] List<int> playerIdFilterList = null)
	{
		List<FriendApplyData> list = new List<FriendApplyData>();
		if (playerIdFilterList != null)
		{
			using (List<int>.Enumerator enumerator = playerIdFilterList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int key = enumerator.Current;
					if (this.MyFriendApplyList.ContainsKey(key))
					{
						list.Add(this.MyFriendApplyList[key]);
					}
				}
				return list;
			}
		}
		foreach (FriendApplyData item in this.MyFriendApplyList.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x170011CB RID: 4555
	// (get) Token: 0x0600D95F RID: 55647 RVA: 0x0032603C File Offset: 0x0032423C
	// (set) Token: 0x0600D960 RID: 55648 RVA: 0x00326044 File Offset: 0x00324244
	public int? SelectedPlayerId
	{
		get
		{
			return this.CurrentSelectedPlayerId;
		}
		set
		{
			this.CurrentSelectedPlayerId = value;
			EventSystem.Instance.Emit<int>(EEventName.CsSyncSelectedPlayerId, value.GetValueOrDefault());
		}
	}

	// Token: 0x170011CC RID: 4556
	// (get) Token: 0x0600D961 RID: 55649 RVA: 0x00326064 File Offset: 0x00324264
	// (set) Token: 0x0600D962 RID: 55650 RVA: 0x0032606C File Offset: 0x0032426C
	public EFriendFilter? FilterState
	{
		get
		{
			return this.FriendFilterState;
		}
		set
		{
			this.FriendFilterState = value;
		}
	}

	// Token: 0x170011CD RID: 4557
	// (get) Token: 0x0600D963 RID: 55651 RVA: 0x00326075 File Offset: 0x00324275
	// (set) Token: 0x0600D964 RID: 55652 RVA: 0x0032607D File Offset: 0x0032427D
	public EUiViewName? ShowingView
	{
		get
		{
			return this.CurrentlyShowingView;
		}
		set
		{
			this.CurrentlyShowingView = value;
		}
	}

	// Token: 0x0600D965 RID: 55653 RVA: 0x00326086 File Offset: 0x00324286
	public void SetCurrentOperationPlayerId(int playerId)
	{
		this.CurrentOperationPlayerId = new int?(playerId);
	}

	// Token: 0x0600D966 RID: 55654 RVA: 0x00326094 File Offset: 0x00324294
	public int? GetCurrentOperationPlayerId()
	{
		return this.CurrentOperationPlayerId;
	}

	// Token: 0x170011CE RID: 4558
	// (get) Token: 0x0600D967 RID: 55655 RVA: 0x0032609C File Offset: 0x0032429C
	public static FriendModel Instance
	{
		get
		{
			return FriendModel._Instance;
		}
	}

	// Token: 0x0600D968 RID: 55656 RVA: 0x003260A3 File Offset: 0x003242A3
	public static FriendModel GetOrCreateInstance()
	{
		if (FriendModel._Instance == null)
		{
			FriendModel.CreateInstance();
		}
		return FriendModel._Instance;
	}

	// Token: 0x0600D969 RID: 55657 RVA: 0x003260B7 File Offset: 0x003242B7
	public static bool CreateInstance()
	{
		if (FriendModel._Instance != null)
		{
			return true;
		}
		FriendModel._Instance = new FriendModel();
		return true;
	}

	// Token: 0x0600D96A RID: 55658 RVA: 0x003260CD File Offset: 0x003242CD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D96B RID: 55659 RVA: 0x003260CF File Offset: 0x003242CF
	public static void ResetStaticDefaultValue()
	{
		FriendModel._Instance = null;
	}

	// Token: 0x0600D96C RID: 55660 RVA: 0x003260D7 File Offset: 0x003242D7
	static FriendModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FriendModel.CreateStaticDefaultValue), new Action(FriendModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400630C RID: 25356
	private readonly Dictionary<int, FriendData> MyFriends = new Dictionary<int, FriendData>();

	// Token: 0x0400630D RID: 25357
	private readonly Dictionary<int, FriendApplyData> MyFriendApplyList = new Dictionary<int, FriendApplyData>();

	// Token: 0x0400630E RID: 25358
	private readonly Dictionary<int, FriendData> FriendSearchResults = new Dictionary<int, FriendData>();

	// Token: 0x0400630F RID: 25359
	private readonly Dictionary<int, FriendBlackListData> MyBlackList = new Dictionary<int, FriendBlackListData>();

	// Token: 0x04006310 RID: 25360
	public readonly HashSet<int> FreshFriendApplicationIds = new HashSet<int>();

	// Token: 0x04006311 RID: 25361
	public Dictionary<int, RecentlyTeamData> RecentlyTeamList = new Dictionary<int, RecentlyTeamData>();

	// Token: 0x04006312 RID: 25362
	private int? CurrentSelectedPlayerId;

	// Token: 0x04006313 RID: 25363
	private int? CurrentOperationPlayerId;

	// Token: 0x04006314 RID: 25364
	private EFriendFilter? FriendFilterState;

	// Token: 0x04006315 RID: 25365
	private EUiViewName? CurrentlyShowingView;

	// Token: 0x04006316 RID: 25366
	public bool TestDataLoaded;

	// Token: 0x04006317 RID: 25367
	[Nullable(2)]
	public FriendData CachePlayerData;

	// Token: 0x04006318 RID: 25368
	private readonly HashSet<int> CurrentApplyFriendList = new HashSet<int>();

	// Token: 0x04006319 RID: 25369
	private readonly HashSet<int> CurrentApproveFriendList = new HashSet<int>();

	// Token: 0x0400631A RID: 25370
	private readonly HashSet<int> CurrentRefuseFriendList = new HashSet<int>();

	// Token: 0x0400631B RID: 25371
	public int ApplyCdTime;

	// Token: 0x0400631C RID: 25372
	[Nullable(2)]
	private static FriendModel _Instance;
}
