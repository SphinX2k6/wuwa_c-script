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

// Token: 0x020010F4 RID: 4340
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FriendModel : ModelBase
{
	// Token: 0x0600AD49 RID: 44361 RVA: 0x003305D8 File Offset: 0x0032E7D8
	protected override bool OnInit()
	{
		this.ApplyCdTime = ConfigCommonParamById.GetIntConfig("apply_valid_time").Value;
		return base.OnInit();
	}

	// Token: 0x0600AD4A RID: 44362 RVA: 0x00330604 File Offset: 0x0032E804
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

	// Token: 0x0600AD4B RID: 44363 RVA: 0x00330668 File Offset: 0x0032E868
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

	// Token: 0x0600AD4C RID: 44364 RVA: 0x0033071C File Offset: 0x0032E91C
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

	// Token: 0x0600AD4D RID: 44365 RVA: 0x00330800 File Offset: 0x0032EA00
	public int GetFriendListCount()
	{
		return this.MyFriends.Count;
	}

	// Token: 0x0600AD4E RID: 44366 RVA: 0x00330810 File Offset: 0x0032EA10
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

	// Token: 0x0600AD4F RID: 44367 RVA: 0x00330898 File Offset: 0x0032EA98
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

	// Token: 0x0600AD50 RID: 44368 RVA: 0x00330920 File Offset: 0x0032EB20
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

	// Token: 0x0600AD51 RID: 44369 RVA: 0x003309B0 File Offset: 0x0032EBB0
	public bool HasNewFriendApplication()
	{
		return this.FreshFriendApplicationIds.Count > 0;
	}

	// Token: 0x0600AD52 RID: 44370 RVA: 0x003309C0 File Offset: 0x0032EBC0
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

	// Token: 0x0600AD53 RID: 44371 RVA: 0x00330A38 File Offset: 0x0032EC38
	public List<int> GetBlackListIds()
	{
		List<int> list = new List<int>();
		foreach (int item in this.MyBlackList.Keys)
		{
			list.Add(item);
		}
		return FriendController.Instance.GetSortedBlackOrApplyList(list);
	}

	// Token: 0x0600AD54 RID: 44372 RVA: 0x00330AA4 File Offset: 0x0032ECA4
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

	// Token: 0x0600AD55 RID: 44373 RVA: 0x00330AF1 File Offset: 0x0032ECF1
	[NullableContext(2)]
	public FriendData GetFriendDataInApplicationById(int playerId)
	{
		if (this.MyFriendApplyList.ContainsKey(playerId))
		{
			return this.MyFriendApplyList[playerId].ApplyPlayerData;
		}
		return null;
	}

	// Token: 0x0600AD56 RID: 44374 RVA: 0x00330B14 File Offset: 0x0032ED14
	[NullableContext(2)]
	public FriendBlackListData GetBlockedPlayerById(int playerId)
	{
		if (!this.MyBlackList.ContainsKey(playerId))
		{
			return null;
		}
		return this.MyBlackList[playerId];
	}

	// Token: 0x0600AD57 RID: 44375 RVA: 0x00330B32 File Offset: 0x0032ED32
	[NullableContext(2)]
	public FriendData GetFriendSearchResultById(int playerId)
	{
		if (!this.FriendSearchResults.ContainsKey(playerId))
		{
			return null;
		}
		return this.FriendSearchResults[playerId];
	}

	// Token: 0x0600AD58 RID: 44376 RVA: 0x00330B50 File Offset: 0x0032ED50
	public void AddFriend(FriendData friend)
	{
		this.MyFriends.TryAdd(friend.PlayerId, friend);
	}

	// Token: 0x0600AD59 RID: 44377 RVA: 0x00330B65 File Offset: 0x0032ED65
	public bool HasFriend(int id)
	{
		return this.MyFriends.ContainsKey(id);
	}

	// Token: 0x0600AD5A RID: 44378 RVA: 0x00330B73 File Offset: 0x0032ED73
	public void DeleteFriend(int id)
	{
		if (this.MyFriends.ContainsKey(id))
		{
			this.MyFriends.Remove(id);
			EventSystem.Instance.Emit<int>(EEventName.OnRemoveFriend, id);
		}
		EventSystem.Instance.Emit(EEventName.UpdateFriendViewShow);
	}

	// Token: 0x0600AD5B RID: 44379 RVA: 0x00330BB1 File Offset: 0x0032EDB1
	public bool IsMyFriend(int id)
	{
		return this.MyFriends.ContainsKey(id);
	}

	// Token: 0x0600AD5C RID: 44380 RVA: 0x00330BBF File Offset: 0x0032EDBF
	public void AddFriendApplication(FriendApplyData friendApply)
	{
		this.MyFriendApplyList[friendApply.ApplyPlayerData.PlayerId] = friendApply;
		if (friendApply.ApplyPlayerData.CanShowInFriendList())
		{
			this.FreshFriendApplicationIds.Add(friendApply.ApplyPlayerData.PlayerId);
		}
	}

	// Token: 0x0600AD5D RID: 44381 RVA: 0x00330BFC File Offset: 0x0032EDFC
	public bool HasFriendApplication(int id)
	{
		return this.MyFriendApplyList.ContainsKey(id);
	}

	// Token: 0x0600AD5E RID: 44382 RVA: 0x00330C0C File Offset: 0x0032EE0C
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

	// Token: 0x0600AD5F RID: 44383 RVA: 0x00330C60 File Offset: 0x0032EE60
	public void MarkDirtyNewApplications()
	{
		foreach (FriendApplyData friendApplyData in this.MyFriendApplyList.Values)
		{
			friendApplyData.Fresh = false;
			this.FreshFriendApplicationIds.Remove(friendApplyData.ApplyPlayerData.PlayerId);
		}
	}

	// Token: 0x0600AD60 RID: 44384 RVA: 0x00330CD0 File Offset: 0x0032EED0
	public void AddFriendSearchResults(FriendData playerResult)
	{
		this.FriendSearchResults[playerResult.PlayerId] = playerResult;
	}

	// Token: 0x0600AD61 RID: 44385 RVA: 0x00330CE4 File Offset: 0x0032EEE4
	public void ClearFriendSearchResults()
	{
		this.FriendSearchResults.Clear();
	}

	// Token: 0x0600AD62 RID: 44386 RVA: 0x00330CF1 File Offset: 0x0032EEF1
	public void AddToBlackList(FriendBlackListData playerInfo)
	{
		this.MyBlackList[playerInfo.GetBlockedPlayerData.PlayerId] = playerInfo;
	}

	// Token: 0x0600AD63 RID: 44387 RVA: 0x00330D0A File Offset: 0x0032EF0A
	public bool HasBlockedPlayer(int id)
	{
		return this.MyBlackList.ContainsKey(id);
	}

	// Token: 0x0600AD64 RID: 44388 RVA: 0x00330D18 File Offset: 0x0032EF18
	public void DeleteBlockedPlayer(int playerId)
	{
		this.MyBlackList.Remove(playerId);
	}

	// Token: 0x0600AD65 RID: 44389 RVA: 0x00330D28 File Offset: 0x0032EF28
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

	// Token: 0x0600AD66 RID: 44390 RVA: 0x00330F20 File Offset: 0x0032F120
	public void ResetShowingView()
	{
		this.ShowingView = new EUiViewName?(EUiViewName.FriendView);
	}

	// Token: 0x0600AD67 RID: 44391 RVA: 0x00330F34 File Offset: 0x0032F134
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

	// Token: 0x0600AD68 RID: 44392 RVA: 0x0033121C File Offset: 0x0032F41C
	public bool CurrentApplyFriendListHasPlayer(int playerId)
	{
		return this.CurrentApplyFriendList.Contains(playerId);
	}

	// Token: 0x0600AD69 RID: 44393 RVA: 0x0033122A File Offset: 0x0032F42A
	public void AddPlayerToApplyFriendList(int playerId)
	{
		if (!this.CurrentApplyFriendList.Contains(playerId))
		{
			this.CurrentApplyFriendList.Add(playerId);
		}
	}

	// Token: 0x0600AD6A RID: 44394 RVA: 0x00331247 File Offset: 0x0032F447
	public void ClearApplyFriendList()
	{
		this.CurrentApplyFriendList.Clear();
	}

	// Token: 0x0600AD6B RID: 44395 RVA: 0x00331254 File Offset: 0x0032F454
	public bool CurrentApproveFriendListHasPlayer(int playerId)
	{
		return this.CurrentApproveFriendList.Contains(playerId);
	}

	// Token: 0x0600AD6C RID: 44396 RVA: 0x00331262 File Offset: 0x0032F462
	public void AddPlayerToApproveFriendList(int playerId)
	{
		if (!this.CurrentApproveFriendList.Contains(playerId))
		{
			this.CurrentApproveFriendList.Add(playerId);
		}
	}

	// Token: 0x0600AD6D RID: 44397 RVA: 0x0033127F File Offset: 0x0032F47F
	public void ClearApproveFriendList()
	{
		this.CurrentApproveFriendList.Clear();
	}

	// Token: 0x0600AD6E RID: 44398 RVA: 0x0033128C File Offset: 0x0032F48C
	public bool CurrentRefuseFriendListHasPlayer(int playerId)
	{
		return this.CurrentRefuseFriendList.Contains(playerId);
	}

	// Token: 0x0600AD6F RID: 44399 RVA: 0x0033129A File Offset: 0x0032F49A
	public void AddPlayerToRefuseFriendList(int playerId)
	{
		if (!this.CurrentRefuseFriendList.Contains(playerId))
		{
			this.CurrentRefuseFriendList.Add(playerId);
		}
	}

	// Token: 0x0600AD70 RID: 44400 RVA: 0x003312B8 File Offset: 0x0032F4B8
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

	// Token: 0x0600AD71 RID: 44401 RVA: 0x00331308 File Offset: 0x0032F508
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

	// Token: 0x0600AD72 RID: 44402 RVA: 0x00331353 File Offset: 0x0032F553
	[NullableContext(2)]
	public RecentlyTeamData GetRecentlyTeamData(int playerId)
	{
		if (!this.RecentlyTeamList.ContainsKey(playerId))
		{
			return null;
		}
		return this.RecentlyTeamList[playerId];
	}

	// Token: 0x0600AD73 RID: 44403 RVA: 0x00331371 File Offset: 0x0032F571
	public void ClearRefuseFriendList()
	{
		this.CurrentRefuseFriendList.Clear();
	}

	// Token: 0x0600AD74 RID: 44404 RVA: 0x00331380 File Offset: 0x0032F580
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

	// Token: 0x170011F1 RID: 4593
	// (get) Token: 0x0600AD75 RID: 44405 RVA: 0x0033143C File Offset: 0x0032F63C
	// (set) Token: 0x0600AD76 RID: 44406 RVA: 0x00331444 File Offset: 0x0032F644
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

	// Token: 0x170011F2 RID: 4594
	// (get) Token: 0x0600AD77 RID: 44407 RVA: 0x00331464 File Offset: 0x0032F664
	// (set) Token: 0x0600AD78 RID: 44408 RVA: 0x0033146C File Offset: 0x0032F66C
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

	// Token: 0x170011F3 RID: 4595
	// (get) Token: 0x0600AD79 RID: 44409 RVA: 0x00331475 File Offset: 0x0032F675
	// (set) Token: 0x0600AD7A RID: 44410 RVA: 0x0033147D File Offset: 0x0032F67D
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

	// Token: 0x0600AD7B RID: 44411 RVA: 0x00331486 File Offset: 0x0032F686
	public void SetCurrentOperationPlayerId(int playerId)
	{
		this.CurrentOperationPlayerId = new int?(playerId);
	}

	// Token: 0x0600AD7C RID: 44412 RVA: 0x00331494 File Offset: 0x0032F694
	public int? GetCurrentOperationPlayerId()
	{
		return this.CurrentOperationPlayerId;
	}

	// Token: 0x170011F4 RID: 4596
	// (get) Token: 0x0600AD7D RID: 44413 RVA: 0x0033149C File Offset: 0x0032F69C
	public static FriendModel Instance
	{
		get
		{
			return FriendModel._Instance;
		}
	}

	// Token: 0x0600AD7E RID: 44414 RVA: 0x003314A3 File Offset: 0x0032F6A3
	public static FriendModel GetOrCreateInstance()
	{
		if (FriendModel._Instance == null)
		{
			FriendModel.CreateInstance();
		}
		return FriendModel._Instance;
	}

	// Token: 0x0600AD7F RID: 44415 RVA: 0x003314B7 File Offset: 0x0032F6B7
	public static bool CreateInstance()
	{
		if (FriendModel._Instance != null)
		{
			return true;
		}
		FriendModel._Instance = new FriendModel();
		return true;
	}

	// Token: 0x0600AD80 RID: 44416 RVA: 0x003314CD File Offset: 0x0032F6CD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AD81 RID: 44417 RVA: 0x003314CF File Offset: 0x0032F6CF
	public static void ResetStaticDefaultValue()
	{
		FriendModel._Instance = null;
	}

	// Token: 0x0600AD82 RID: 44418 RVA: 0x003314D7 File Offset: 0x0032F6D7
	static FriendModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FriendModel.CreateStaticDefaultValue), new Action(FriendModel.ResetStaticDefaultValue));
	}

	// Token: 0x040063DE RID: 25566
	private readonly Dictionary<int, FriendData> MyFriends = new Dictionary<int, FriendData>();

	// Token: 0x040063DF RID: 25567
	private readonly Dictionary<int, FriendApplyData> MyFriendApplyList = new Dictionary<int, FriendApplyData>();

	// Token: 0x040063E0 RID: 25568
	private readonly Dictionary<int, FriendData> FriendSearchResults = new Dictionary<int, FriendData>();

	// Token: 0x040063E1 RID: 25569
	private readonly Dictionary<int, FriendBlackListData> MyBlackList = new Dictionary<int, FriendBlackListData>();

	// Token: 0x040063E2 RID: 25570
	public readonly HashSet<int> FreshFriendApplicationIds = new HashSet<int>();

	// Token: 0x040063E3 RID: 25571
	public Dictionary<int, RecentlyTeamData> RecentlyTeamList = new Dictionary<int, RecentlyTeamData>();

	// Token: 0x040063E4 RID: 25572
	private int? CurrentSelectedPlayerId;

	// Token: 0x040063E5 RID: 25573
	private int? CurrentOperationPlayerId;

	// Token: 0x040063E6 RID: 25574
	private EFriendFilter? FriendFilterState;

	// Token: 0x040063E7 RID: 25575
	private EUiViewName? CurrentlyShowingView;

	// Token: 0x040063E8 RID: 25576
	public bool TestDataLoaded;

	// Token: 0x040063E9 RID: 25577
	[Nullable(2)]
	public FriendData CachePlayerData;

	// Token: 0x040063EA RID: 25578
	private readonly HashSet<int> CurrentApplyFriendList = new HashSet<int>();

	// Token: 0x040063EB RID: 25579
	private readonly HashSet<int> CurrentApproveFriendList = new HashSet<int>();

	// Token: 0x040063EC RID: 25580
	private readonly HashSet<int> CurrentRefuseFriendList = new HashSet<int>();

	// Token: 0x040063ED RID: 25581
	public int ApplyCdTime;

	// Token: 0x040063EE RID: 25582
	[Nullable(2)]
	private static FriendModel _Instance;
}
