using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020003CD RID: 973
[NullableContext(1)]
[Nullable(0)]
public class AchievementModel : ModelBase
{
	// Token: 0x0600352F RID: 13615 RVA: 0x00138E8C File Offset: 0x0013708C
	private void InitAchievementGroupMapData(int group)
	{
		List<AchievementData> list = new List<AchievementData>();
		foreach (Achievement achievement in AchievementConfig.Instance.GetAchievementGroupAchievementList(group))
		{
			AchievementData achievementData = this.GetAchievementData(achievement.Id);
			list.Add(achievementData);
		}
		this.AchievementGroupMap[group] = list;
	}

	// Token: 0x06003530 RID: 13616 RVA: 0x00138F00 File Offset: 0x00137100
	private void InitAchievementCategoryGroupData(int categoryId)
	{
		IEnumerable<AchievementGroup> achievementCategoryGroups = AchievementConfig.Instance.GetAchievementCategoryGroups(categoryId);
		List<AchievementGroupData> list = new List<AchievementGroupData>();
		foreach (AchievementGroup achievementGroup in achievementCategoryGroups)
		{
			AchievementGroupData achievementGroupData = this.GetAchievementGroupData(new int?(achievementGroup.Id));
			list.Add(achievementGroupData);
		}
		this.AchievementCategoryGroupMap[categoryId] = list;
	}

	// Token: 0x06003531 RID: 13617 RVA: 0x00138F78 File Offset: 0x00137178
	private void InitAchievementCategoryData()
	{
		this.AchievementCategoryArray = new List<AchievementCategoryData>();
		foreach (AchievementCategory achievementCategory in AchievementConfig.Instance.GetAllAchievementCategory())
		{
			AchievementCategoryData item = new AchievementCategoryData(achievementCategory.Id);
			if (Array.IndexOf<int>(this.showFunctionList, achievementCategory.FunctionType) >= 0)
			{
				this.AchievementCategoryArray.Add(item);
			}
		}
	}

	// Token: 0x06003532 RID: 13618 RVA: 0x00138FFC File Offset: 0x001371FC
	private void AddDataToCanGetArray(AchievementData data)
	{
		if (!this.CanGetRewardAchievements.Contains(data))
		{
			this.CanGetRewardAchievements.Add(data);
		}
	}

	// Token: 0x06003533 RID: 13619 RVA: 0x00139018 File Offset: 0x00137218
	private void AddDataToHasGetArray(AchievementData data)
	{
		if (!this.HasGetRewardAchievements.Contains(data))
		{
			this.HasGetRewardAchievements.Add(data);
		}
	}

	// Token: 0x06003534 RID: 13620 RVA: 0x00139034 File Offset: 0x00137234
	private void ClearCacheIds(AchievementData data)
	{
		int num = this.CanGetRewardAchievements.IndexOf(data);
		if (num >= 0)
		{
			this.CanGetRewardAchievements.RemoveAt(num);
		}
		int num2 = this.HasGetRewardAchievements.IndexOf(data);
		if (num2 >= 0)
		{
			this.HasGetRewardAchievements.RemoveAt(num2);
		}
	}

	// Token: 0x06003535 RID: 13621 RVA: 0x0013907B File Offset: 0x0013727B
	private void SortCanGetRewardAchievements()
	{
		this.CanGetRewardAchievements.Sort(this.SortFunc);
	}

	// Token: 0x06003536 RID: 13622 RVA: 0x0013908E File Offset: 0x0013728E
	private void SortHasGetRewardAchievements()
	{
		this.HasGetRewardAchievements.Sort(this.SortFunc);
	}

	// Token: 0x06003537 RID: 13623 RVA: 0x001390A4 File Offset: 0x001372A4
	private void InitAchievementData(int id)
	{
		AchievementData achievementData = new AchievementData(id);
		if (!achievementData.IfSingleAchievement())
		{
			int nextLink = achievementData.GetNextLink();
			if (nextLink > 0)
			{
				this.GetAchievementData(nextLink).SetLastLink(id);
			}
		}
		this.AchievementMap[id] = achievementData;
	}

	// Token: 0x06003538 RID: 13624 RVA: 0x001390E8 File Offset: 0x001372E8
	private void InitAchievementGroupData(int groupId)
	{
		AchievementGroupData value = new AchievementGroupData(groupId);
		this.AllAchievementGroupMap[groupId] = value;
	}

	// Token: 0x06003539 RID: 13625 RVA: 0x0013910C File Offset: 0x0013730C
	public void PhraseBaseData(AchievementInfoResponse response)
	{
		Log.Instance.Info(ELogModule.Achievement, ELogAuthor.YZY, "Achievement PhraseBaseData response", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.CanGetRewardAchievements = new List<AchievementData>();
		this.HasGetRewardAchievements = new List<AchievementData>();
		this.AchievementMap.Clear();
		this.AchievementGroupMap.Clear();
		foreach (AchievementGroupInfo achievementGroupInfo in response.AchievementGroupInfoList)
		{
			this.GetAchievementGroupData(new int?(achievementGroupInfo.AchievementGroupEntry.Id)).Phrase(achievementGroupInfo.AchievementGroupEntry);
			foreach (AchievementEntry achievementEntry in achievementGroupInfo.AchievementEntryList)
			{
				AchievementData achievementData = this.GetAchievementData(achievementEntry.Id);
				achievementData.Phrase(achievementEntry);
				if (achievementData.GetFinishState() == EAchievementStateEnum.CanGetReward)
				{
					this.AddDataToCanGetArray(achievementData);
				}
				else if (achievementData.GetFinishState() == EAchievementStateEnum.HaveGetReward)
				{
					this.AddDataToHasGetArray(achievementData);
				}
			}
		}
		this.AchieveStarCount = response.StarCount;
		this.AchieveFinishCount = response.FinishCount;
		EventSystem.Instance.Emit(EEventName.OnAchievementDataNotify);
		EventSystem.Instance.Emit(EEventName.RefreshAchievementRedPoint);
	}

	// Token: 0x0600353A RID: 13626 RVA: 0x00139270 File Offset: 0x00137470
	public void OnTsDataReady(IReadOnlyList<int> categoryIds, IReadOnlyList<int> groupIds, IReadOnlyList<int> achievementIds, int startCount, int finishCount)
	{
		this.CanGetRewardAchievements = new List<AchievementData>();
		this.HasGetRewardAchievements = new List<AchievementData>();
		this.AchievementMap.Clear();
		this.AchievementGroupMap.Clear();
		this.InitAchievementCategoryData();
		foreach (int groupId in groupIds)
		{
			this.InitAchievementGroupData(groupId);
		}
		foreach (int id in achievementIds)
		{
			this.InitAchievementData(id);
		}
		foreach (int id2 in achievementIds)
		{
			AchievementData achievementData = this.GetAchievementData(id2);
			if (achievementData != null)
			{
				if (achievementData.GetFinishState() == EAchievementStateEnum.CanGetReward)
				{
					this.AddDataToCanGetArray(achievementData);
				}
				else if (achievementData.GetFinishState() == EAchievementStateEnum.HaveGetReward)
				{
					this.AddDataToHasGetArray(achievementData);
				}
			}
		}
		this.AchieveStarCount = startCount;
		this.AchieveFinishCount = finishCount;
		EventSystem.Instance.Emit(EEventName.OnAchievementDataNotify);
		EventSystem.Instance.Emit(EEventName.RefreshAchievementRedPoint);
	}

	// Token: 0x0600353B RID: 13627 RVA: 0x001393B4 File Offset: 0x001375B4
	public void PhraseUpdateData(AchievementUpdateResponse response)
	{
		foreach (AchievementEntry achievementEntry in response.AchievementEntryList)
		{
			this.GetAchievementData(achievementEntry.Id).Phrase(achievementEntry);
		}
	}

	// Token: 0x0600353C RID: 13628 RVA: 0x0013940C File Offset: 0x0013760C
	public unsafe void OnAchievementProgressNotify(AchievementEntry message)
	{
		AchievementData achievementData = this.GetAchievementData(message.Id);
		EAchievementStateEnum finishState = achievementData.GetFinishState();
		achievementData.Phrase(message);
		EAchievementStateEnum finishState2 = achievementData.GetFinishState();
		if (finishState2 != finishState)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Achievement;
			ELogAuthor author = ELogAuthor.YZY;
			string message2 = "OnAchievementGroupProgressNotify";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", achievementData.GetId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentState", finishState2);
			instance.Info(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit(EEventName.RefreshAchievementRedPoint);
		}
		this.ClearCacheIds(achievementData);
		if (achievementData.GetFinishState() == EAchievementStateEnum.CanGetReward)
		{
			this.AddDataToCanGetArray(achievementData);
		}
		else if (achievementData.GetFinishState() == EAchievementStateEnum.HaveGetReward)
		{
			this.AddDataToHasGetArray(achievementData);
		}
		EventSystem.Instance.Emit(EEventName.OnAchievementDataNotify);
		EventSystem.Instance.Emit<int>(EEventName.OnAchievementDataWithIdNotify, achievementData.GetId());
		EventSystem.Instance.Emit<int>(EEventName.OnAchievementGroupDataNotify, achievementData.GetGroupId());
	}

	// Token: 0x0600353D RID: 13629 RVA: 0x0013951C File Offset: 0x0013771C
	public unsafe void OnAchievementGroupProgressNotify(AchievementGroupProgressNotify message)
	{
		AchievementGroupData achievementGroupData = this.GetAchievementGroupData(new int?(message.AchievementGroupEntry.Id));
		EAchievementStateEnum finishState = achievementGroupData.GetFinishState();
		achievementGroupData.Phrase(message.AchievementGroupEntry);
		EAchievementStateEnum finishState2 = achievementGroupData.GetFinishState();
		if (finishState2 != finishState)
		{
			EventSystem.Instance.Emit(EEventName.RefreshAchievementRedPoint);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Achievement;
			ELogAuthor author = ELogAuthor.YZY;
			string message2 = "OnAchievementGroupProgressNotify";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", achievementGroupData.GetId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentState", finishState2);
			instance.Info(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		EventSystem.Instance.Emit<int>(EEventName.OnAchievementGroupDataNotify, achievementGroupData.GetId());
	}

	// Token: 0x0600353E RID: 13630 RVA: 0x001395E9 File Offset: 0x001377E9
	public void OnAchievementCountChangeNotify(AchievementCountChangeNotify message)
	{
		this.AchieveFinishCount = message.FinishCount;
		this.AchieveStarCount = message.StarCount;
	}

	// Token: 0x0600353F RID: 13631 RVA: 0x00139604 File Offset: 0x00137804
	public List<AchievementData> GetGroupAchievements(int group, bool filterShowState = true)
	{
		List<AchievementData> list;
		if (!this.AchievementGroupMap.TryGetValue(group, out list))
		{
			this.InitAchievementGroupMapData(group);
			list = this.AchievementGroupMap[group];
		}
		if (!filterShowState)
		{
			return list;
		}
		List<AchievementData> list2 = new List<AchievementData>();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].GetShowState())
			{
				list2.Add(list[i]);
			}
		}
		return list2;
	}

	// Token: 0x06003540 RID: 13632 RVA: 0x0013966D File Offset: 0x0013786D
	public bool GetGroupAchievementsIsRedDot(int group)
	{
		return this.GetGroupAchievements(group, false).Exists((AchievementData data) => data.RedPoint());
	}

	// Token: 0x06003541 RID: 13633 RVA: 0x0013969C File Offset: 0x0013789C
	public int GetAchievementCategoryIndex(AchievementCategoryData categoryData)
	{
		return this.GetAchievementCategoryArray().FindIndex((AchievementCategoryData data) => data.GetId() == categoryData.GetId());
	}

	// Token: 0x06003542 RID: 13634 RVA: 0x001396D0 File Offset: 0x001378D0
	public List<AchievementGroupData> GetAchievementCategoryGroups(int categoryId, bool filterShowState = true)
	{
		List<AchievementGroupData> list;
		if (!this.AchievementCategoryGroupMap.TryGetValue(categoryId, out list))
		{
			this.InitAchievementCategoryGroupData(categoryId);
			list = this.AchievementCategoryGroupMap[categoryId];
		}
		if (!filterShowState)
		{
			return list ?? new List<AchievementGroupData>();
		}
		List<AchievementGroupData> list2 = new List<AchievementGroupData>();
		foreach (AchievementGroupData achievementGroupData in list)
		{
			if (achievementGroupData.GetShowState())
			{
				list2.Add(achievementGroupData);
			}
		}
		list2.Sort((AchievementGroupData a, AchievementGroupData b) => a.GetSort() - b.GetSort());
		return list2;
	}

	// Token: 0x06003543 RID: 13635 RVA: 0x00139784 File Offset: 0x00137984
	[NullableContext(2)]
	public AchievementData GetAchievementData(int id)
	{
		AchievementData achievementData;
		if (!this.AchievementMap.TryGetValue(id, out achievementData))
		{
			try
			{
				this.InitAchievementData(id);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Achievement;
				ELogAuthor author = ELogAuthor.BB;
				string message = "成就初始化异常";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return this.AchievementMap[id];
	}

	// Token: 0x06003544 RID: 13636 RVA: 0x001397FC File Offset: 0x001379FC
	public Dictionary<int, AchievementData> GetAllAchievementData()
	{
		return this.AchievementMap;
	}

	// Token: 0x06003545 RID: 13637 RVA: 0x00139804 File Offset: 0x00137A04
	public List<AchievementCategoryData> GetAchievementCategoryArray()
	{
		if (this.AchievementCategoryArray.Count == 0)
		{
			this.InitAchievementCategoryData();
		}
		return this.AchievementCategoryArray;
	}

	// Token: 0x06003546 RID: 13638 RVA: 0x00139820 File Offset: 0x00137A20
	[NullableContext(2)]
	public AchievementCategoryData GetCategory(int categoryId)
	{
		List<AchievementCategoryData> achievementCategoryArray = this.GetAchievementCategoryArray();
		AchievementCategoryData result = null;
		for (int i = 0; i < achievementCategoryArray.Count; i++)
		{
			if (achievementCategoryArray[i].GetId() == categoryId)
			{
				result = achievementCategoryArray[i];
			}
		}
		return result;
	}

	// Token: 0x06003547 RID: 13639 RVA: 0x0013985F File Offset: 0x00137A5F
	[NullableContext(2)]
	public AchievementGroupData GetAchievementGroupData(int? groupId)
	{
		if (groupId == null)
		{
			return null;
		}
		if (!this.AllAchievementGroupMap.ContainsKey(groupId.Value))
		{
			this.InitAchievementGroupData(groupId.Value);
		}
		return this.AllAchievementGroupMap[groupId.Value];
	}

	// Token: 0x06003548 RID: 13640 RVA: 0x0013989F File Offset: 0x00137A9F
	public Dictionary<int, AchievementGroupData> GetAllAchievementGroupData()
	{
		return this.AllAchievementGroupMap;
	}

	// Token: 0x06003549 RID: 13641 RVA: 0x001398A8 File Offset: 0x00137AA8
	public List<int> GetRecentFinishedAchievementList()
	{
		List<int> list = new List<int>();
		this.SortCanGetRewardAchievements();
		int num = 0;
		while (num < this.CanGetRewardAchievements.Count && list.Count < 5)
		{
			if (!list.Contains(this.CanGetRewardAchievements[num].GetId()) && this.CanGetRewardAchievements[num].GetShowState())
			{
				AchievementGroupData achievementGroupData = this.GetAchievementGroupData(new int?(this.CanGetRewardAchievements[num].GetGroupId()));
				int categoryFunctionType = AchievementConfig.Instance.GetCategoryFunctionType(achievementGroupData.GetCategory());
				if (Array.IndexOf<int>(this.showFunctionList, categoryFunctionType) >= 0)
				{
					list.Add(this.CanGetRewardAchievements[num].GetId());
				}
			}
			num++;
		}
		if (list.Count < 5)
		{
			this.SortHasGetRewardAchievements();
			int num2 = 0;
			while (num2 < this.HasGetRewardAchievements.Count && list.Count < 5)
			{
				if (!list.Contains(this.HasGetRewardAchievements[num2].GetId()) && this.HasGetRewardAchievements[num2].GetShowState())
				{
					AchievementGroupData achievementGroupData2 = this.GetAchievementGroupData(new int?(this.HasGetRewardAchievements[num2].GetGroupId()));
					int categoryFunctionType2 = AchievementConfig.Instance.GetCategoryFunctionType(achievementGroupData2.GetCategory());
					if (Array.IndexOf<int>(this.showFunctionList, categoryFunctionType2) >= 0)
					{
						list.Add(this.HasGetRewardAchievements[num2].GetId());
					}
				}
				num2++;
			}
		}
		return list;
	}

	// Token: 0x0600354A RID: 13642 RVA: 0x00139A30 File Offset: 0x00137C30
	public bool GetAchievementRedPointState()
	{
		return this.GetAchievementCategoryArray().Exists((AchievementCategoryData category) => this.GetCategoryRedPointState(category.GetId()));
	}

	// Token: 0x0600354B RID: 13643 RVA: 0x00139A49 File Offset: 0x00137C49
	public bool GetCategoryRedPointState(int categoryId)
	{
		return this.GetAchievementCategoryGroups(categoryId, false).Exists((AchievementGroupData group) => group.SmallItemRedPoint());
	}

	// Token: 0x0600354C RID: 13644 RVA: 0x00139A78 File Offset: 0x00137C78
	public int GetCategoryStarNum(int category)
	{
		List<AchievementGroupData> achievementCategoryGroups = this.GetAchievementCategoryGroups(category, true);
		int num = 0;
		foreach (AchievementGroupData achievementGroupData in achievementCategoryGroups)
		{
			foreach (AchievementData achievementData in this.GetGroupAchievements(achievementGroupData.GetId(), true))
			{
				num += achievementData.GetMaxStar();
			}
		}
		return num;
	}

	// Token: 0x0600354D RID: 13645 RVA: 0x00139B18 File Offset: 0x00137D18
	public int GetFinishedAchievementNum()
	{
		return this.AchieveFinishCount;
	}

	// Token: 0x0600354E RID: 13646 RVA: 0x00139B20 File Offset: 0x00137D20
	public int GetAchievementFinishedStar()
	{
		return this.AchieveStarCount;
	}

	// Token: 0x0600354F RID: 13647 RVA: 0x00139B28 File Offset: 0x00137D28
	public void RefreshSearchResult()
	{
		List<AchievementCategoryData> achievementCategoryArray = this.GetAchievementCategoryArray();
		this.SearchResult = new Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>>();
		foreach (AchievementCategoryData achievementCategoryData in achievementCategoryArray)
		{
			Dictionary<AchievementGroupData, AchievementData[]> categorySearchResult = this.GetCategorySearchResult(achievementCategoryData.GetId(), this.CurrentSearchText);
			if (categorySearchResult.Keys.Count > 0)
			{
				this.SearchResult[achievementCategoryData] = categorySearchResult;
			}
		}
	}

	// Token: 0x06003550 RID: 13648 RVA: 0x00139BB0 File Offset: 0x00137DB0
	public Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>> GetSearchResult()
	{
		return this.SearchResult;
	}

	// Token: 0x06003551 RID: 13649 RVA: 0x00139BB8 File Offset: 0x00137DB8
	public bool GetSearchResultIfNull()
	{
		Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>> searchResult = this.SearchResult;
		bool flag = true;
		foreach (Dictionary<AchievementGroupData, AchievementData[]> dictionary in searchResult.Values)
		{
			using (Dictionary<AchievementGroupData, AchievementData[]>.ValueCollection.Enumerator enumerator2 = dictionary.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.Length != 0)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				break;
			}
		}
		return flag;
	}

	// Token: 0x06003552 RID: 13650 RVA: 0x00139C50 File Offset: 0x00137E50
	private Dictionary<AchievementGroupData, AchievementData[]> GetCategorySearchResult(int category, string searchText)
	{
		Dictionary<AchievementGroupData, AchievementData[]> dictionary = new Dictionary<AchievementGroupData, AchievementData[]>();
		List<AchievementGroupData> achievementCategoryGroups = this.GetAchievementCategoryGroups(category, true);
		for (int i = 0; i < achievementCategoryGroups.Count; i++)
		{
			List<AchievementData> groupAchievements = this.GetGroupAchievements(achievementCategoryGroups[i].GetId(), true);
			List<AchievementData> list = new List<AchievementData>();
			foreach (AchievementData achievementData in groupAchievements)
			{
				if (!string.IsNullOrEmpty(achievementData.GetTitle()))
				{
					string.IsNullOrEmpty(achievementData.GetDesc());
				}
				string title = achievementData.GetTitle();
				if (title == null || !title.Contains(searchText))
				{
					string desc = achievementData.GetDesc();
					if (desc == null || !desc.Contains(searchText))
					{
						continue;
					}
				}
				list.Add(achievementData);
			}
			if (list.Count > 0)
			{
				dictionary[achievementCategoryGroups[i]] = list.ToArray();
			}
		}
		return dictionary;
	}

	// Token: 0x06003553 RID: 13651 RVA: 0x00139D44 File Offset: 0x00137F44
	public List<AchievementSearchData> GetSearchResultData(Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>> input)
	{
		List<AchievementSearchData> list = new List<AchievementSearchData>();
		foreach (AchievementCategoryData key in input.Keys)
		{
			foreach (KeyValuePair<AchievementGroupData, AchievementData[]> keyValuePair in input[key])
			{
				list.Add(new AchievementSearchData
				{
					AchievementSearchGroupData = new AchievementSearchGroupData(),
					AchievementSearchGroupData = 
					{
						AchievementGroupData = keyValuePair.Key,
						AchievementDataLength = keyValuePair.Value.Length
					}
				});
				foreach (AchievementData achievementData in keyValuePair.Value)
				{
					list.Add(new AchievementSearchData
					{
						AchievementData = achievementData
					});
				}
			}
		}
		return list;
	}

	// Token: 0x06003554 RID: 13652 RVA: 0x00139E60 File Offset: 0x00138060
	public bool IsHideAchievementGroup(int groupId)
	{
		AchievementGroupData achievementGroupData = this.GetAchievementGroupData(new int?(groupId));
		int? num = (achievementGroupData != null) ? new int?(achievementGroupData.GetCategory()) : null;
		int categoryFunctionType = AchievementConfig.Instance.GetCategoryFunctionType(num.Value);
		return Array.IndexOf<int>(this.showFunctionList, categoryFunctionType) < 0;
	}

	// Token: 0x06003555 RID: 13653 RVA: 0x00139EB4 File Offset: 0x001380B4
	public void GmClearData()
	{
		this.CurrentFinishAchievementArray.Clear();
	}

	// Token: 0x170007B9 RID: 1977
	// (get) Token: 0x06003556 RID: 13654 RVA: 0x00139EC1 File Offset: 0x001380C1
	public static AchievementModel Instance
	{
		get
		{
			return AchievementModel._Instance;
		}
	}

	// Token: 0x06003557 RID: 13655 RVA: 0x00139EC8 File Offset: 0x001380C8
	public static AchievementModel GetOrCreateInstance()
	{
		if (AchievementModel._Instance == null)
		{
			AchievementModel.CreateInstance();
		}
		return AchievementModel._Instance;
	}

	// Token: 0x06003558 RID: 13656 RVA: 0x00139EDC File Offset: 0x001380DC
	public static bool CreateInstance()
	{
		if (AchievementModel._Instance != null)
		{
			return true;
		}
		AchievementModel._Instance = new AchievementModel();
		return true;
	}

	// Token: 0x06003559 RID: 13657 RVA: 0x00139EF2 File Offset: 0x001380F2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600355A RID: 13658 RVA: 0x00139EF4 File Offset: 0x001380F4
	public static void ResetStaticDefaultValue()
	{
		AchievementModel._Instance = null;
	}

	// Token: 0x0600355B RID: 13659 RVA: 0x00139EFC File Offset: 0x001380FC
	static AchievementModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AchievementModel.CreateStaticDefaultValue), new Action(AchievementModel.ResetStaticDefaultValue));
	}

	// Token: 0x04002CF9 RID: 11513
	private const int RECENT_FINISHED_LIST_LENGTH = 5;

	// Token: 0x04002CFA RID: 11514
	private readonly int[] showFunctionList = new int[]
	{
		1
	};

	// Token: 0x04002CFB RID: 11515
	[Nullable(2)]
	public AchievementCategoryData CurrentSelectCategory;

	// Token: 0x04002CFC RID: 11516
	[Nullable(2)]
	public AchievementGroupData CurrentSelectGroup;

	// Token: 0x04002CFD RID: 11517
	public int CurrentSelectAchievementId;

	// Token: 0x04002CFE RID: 11518
	public bool AchievementSearchState;

	// Token: 0x04002CFF RID: 11519
	public string CurrentSearchText = "";

	// Token: 0x04002D00 RID: 11520
	public List<int> CurrentFinishAchievementArray = new List<int>();

	// Token: 0x04002D01 RID: 11521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<AchievementSearchData> CurrentCacheSearchData;

	// Token: 0x04002D02 RID: 11522
	private Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>> SearchResult = new Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>>();

	// Token: 0x04002D03 RID: 11523
	private readonly Dictionary<int, List<AchievementData>> AchievementGroupMap = new Dictionary<int, List<AchievementData>>();

	// Token: 0x04002D04 RID: 11524
	private List<AchievementCategoryData> AchievementCategoryArray = new List<AchievementCategoryData>();

	// Token: 0x04002D05 RID: 11525
	private readonly Dictionary<int, List<AchievementGroupData>> AchievementCategoryGroupMap = new Dictionary<int, List<AchievementGroupData>>();

	// Token: 0x04002D06 RID: 11526
	private readonly Dictionary<int, AchievementData> AchievementMap = new Dictionary<int, AchievementData>();

	// Token: 0x04002D07 RID: 11527
	private readonly Dictionary<int, AchievementGroupData> AllAchievementGroupMap = new Dictionary<int, AchievementGroupData>();

	// Token: 0x04002D08 RID: 11528
	private List<AchievementData> CanGetRewardAchievements = new List<AchievementData>();

	// Token: 0x04002D09 RID: 11529
	private List<AchievementData> HasGetRewardAchievements = new List<AchievementData>();

	// Token: 0x04002D0A RID: 11530
	private int AchieveStarCount;

	// Token: 0x04002D0B RID: 11531
	private int AchieveFinishCount;

	// Token: 0x04002D0C RID: 11532
	private readonly Comparison<AchievementData> SortFunc = (AchievementData a, AchievementData b) => (int)(b.GetFinishTime() - a.GetFinishTime()).Value;

	// Token: 0x04002D0D RID: 11533
	public readonly Comparison<AchievementData> SortByTabIndex = (AchievementData a, AchievementData b) => b.GetFinishSort() - a.GetFinishSort();

	// Token: 0x04002D0E RID: 11534
	[Nullable(2)]
	private static AchievementModel _Instance;
}
