using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000F18 RID: 3864
[NullableContext(1)]
[Nullable(0)]
public class AchievementModel : ModelBase
{
	// Token: 0x06006197 RID: 24983 RVA: 0x00130568 File Offset: 0x0012E768
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

	// Token: 0x06006198 RID: 24984 RVA: 0x001305DC File Offset: 0x0012E7DC
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

	// Token: 0x06006199 RID: 24985 RVA: 0x00130654 File Offset: 0x0012E854
	private void InitAchievementCategoryData()
	{
		this.AchievementCategoryArray = new List<AchievementCategoryData>();
		foreach (AchievementCategory achievementCategory in AchievementConfig.Instance.GetAllAchievementCategory())
		{
			AchievementCategoryData item = new AchievementCategoryData(achievementCategory.Id);
			if (this.showFunctionList.Contains(achievementCategory.FunctionType))
			{
				this.AchievementCategoryArray.Add(item);
			}
		}
	}

	// Token: 0x0600619A RID: 24986 RVA: 0x001306D8 File Offset: 0x0012E8D8
	private void AddDataToCanGetArray(AchievementData data)
	{
		if (!this.CanGetRewardAchievements.Contains(data))
		{
			this.CanGetRewardAchievements.Add(data);
		}
	}

	// Token: 0x0600619B RID: 24987 RVA: 0x001306F4 File Offset: 0x0012E8F4
	private void AddDataToHasGetArray(AchievementData data)
	{
		if (!this.HasGetRewardAchievements.Contains(data))
		{
			this.HasGetRewardAchievements.Add(data);
		}
	}

	// Token: 0x0600619C RID: 24988 RVA: 0x00130710 File Offset: 0x0012E910
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

	// Token: 0x0600619D RID: 24989 RVA: 0x00130757 File Offset: 0x0012E957
	private void SortCanGetRewardAchievements()
	{
		this.CanGetRewardAchievements.Sort(this.SortFunc);
	}

	// Token: 0x0600619E RID: 24990 RVA: 0x0013076A File Offset: 0x0012E96A
	private void SortHasGetRewardAchievements()
	{
		this.HasGetRewardAchievements.Sort(this.SortFunc);
	}

	// Token: 0x0600619F RID: 24991 RVA: 0x00130780 File Offset: 0x0012E980
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

	// Token: 0x060061A0 RID: 24992 RVA: 0x001307C4 File Offset: 0x0012E9C4
	private void InitAchievementGroupData(int groupId)
	{
		AchievementGroupData value = new AchievementGroupData(groupId);
		this.AllAchievementGroupMap[groupId] = value;
	}

	// Token: 0x060061A1 RID: 24993 RVA: 0x001307E8 File Offset: 0x0012E9E8
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

	// Token: 0x060061A2 RID: 24994 RVA: 0x0013094C File Offset: 0x0012EB4C
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

	// Token: 0x060061A3 RID: 24995 RVA: 0x00130A90 File Offset: 0x0012EC90
	public void PhraseUpdateData(AchievementUpdateResponse response)
	{
		foreach (AchievementEntry achievementEntry in response.AchievementEntryList)
		{
			this.GetAchievementData(achievementEntry.Id).Phrase(achievementEntry);
		}
	}

	// Token: 0x060061A4 RID: 24996 RVA: 0x00130AE8 File Offset: 0x0012ECE8
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

	// Token: 0x060061A5 RID: 24997 RVA: 0x00130BF8 File Offset: 0x0012EDF8
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

	// Token: 0x060061A6 RID: 24998 RVA: 0x00130CC5 File Offset: 0x0012EEC5
	public void OnAchievementCountChangeNotify(AchievementCountChangeNotify message)
	{
		this.AchieveFinishCount = message.FinishCount;
		this.AchieveStarCount = message.StarCount;
	}

	// Token: 0x060061A7 RID: 24999 RVA: 0x00130CE0 File Offset: 0x0012EEE0
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

	// Token: 0x060061A8 RID: 25000 RVA: 0x00130D49 File Offset: 0x0012EF49
	public bool GetGroupAchievementsIsRedDot(int group)
	{
		return this.GetGroupAchievements(group, false).Any((AchievementData data) => data.RedPoint());
	}

	// Token: 0x060061A9 RID: 25001 RVA: 0x00130D78 File Offset: 0x0012EF78
	public int GetAchievementCategoryIndex(AchievementCategoryData categoryData)
	{
		return this.GetAchievementCategoryArray().FindIndex((AchievementCategoryData data) => data.GetId() == categoryData.GetId());
	}

	// Token: 0x060061AA RID: 25002 RVA: 0x00130DAC File Offset: 0x0012EFAC
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

	// Token: 0x060061AB RID: 25003 RVA: 0x00130E60 File Offset: 0x0012F060
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

	// Token: 0x060061AC RID: 25004 RVA: 0x00130ED8 File Offset: 0x0012F0D8
	public Dictionary<int, AchievementData> GetAllAchievementData()
	{
		return this.AchievementMap;
	}

	// Token: 0x060061AD RID: 25005 RVA: 0x00130EE0 File Offset: 0x0012F0E0
	public List<AchievementCategoryData> GetAchievementCategoryArray()
	{
		if (this.AchievementCategoryArray.Count == 0)
		{
			this.InitAchievementCategoryData();
		}
		return this.AchievementCategoryArray;
	}

	// Token: 0x060061AE RID: 25006 RVA: 0x00130EFC File Offset: 0x0012F0FC
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

	// Token: 0x060061AF RID: 25007 RVA: 0x00130F3B File Offset: 0x0012F13B
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

	// Token: 0x060061B0 RID: 25008 RVA: 0x00130F7B File Offset: 0x0012F17B
	public Dictionary<int, AchievementGroupData> GetAllAchievementGroupData()
	{
		return this.AllAchievementGroupMap;
	}

	// Token: 0x060061B1 RID: 25009 RVA: 0x00130F84 File Offset: 0x0012F184
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
				if (this.showFunctionList.Contains(categoryFunctionType))
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
					if (this.showFunctionList.Contains(categoryFunctionType2))
					{
						list.Add(this.HasGetRewardAchievements[num2].GetId());
					}
				}
				num2++;
			}
		}
		return list;
	}

	// Token: 0x060061B2 RID: 25010 RVA: 0x0013110A File Offset: 0x0012F30A
	public bool GetAchievementRedPointState()
	{
		return this.GetAchievementCategoryArray().Any((AchievementCategoryData category) => this.GetCategoryRedPointState(category.GetId()));
	}

	// Token: 0x060061B3 RID: 25011 RVA: 0x00131123 File Offset: 0x0012F323
	public bool GetCategoryRedPointState(int categoryId)
	{
		return this.GetAchievementCategoryGroups(categoryId, false).Any((AchievementGroupData group) => group.SmallItemRedPoint());
	}

	// Token: 0x060061B4 RID: 25012 RVA: 0x00131154 File Offset: 0x0012F354
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

	// Token: 0x060061B5 RID: 25013 RVA: 0x001311F4 File Offset: 0x0012F3F4
	public int GetFinishedAchievementNum()
	{
		return this.AchieveFinishCount;
	}

	// Token: 0x060061B6 RID: 25014 RVA: 0x001311FC File Offset: 0x0012F3FC
	public int GetAchievementFinishedStar()
	{
		return this.AchieveStarCount;
	}

	// Token: 0x060061B7 RID: 25015 RVA: 0x00131204 File Offset: 0x0012F404
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

	// Token: 0x060061B8 RID: 25016 RVA: 0x0013128C File Offset: 0x0012F48C
	public Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>> GetSearchResult()
	{
		return this.SearchResult;
	}

	// Token: 0x060061B9 RID: 25017 RVA: 0x00131294 File Offset: 0x0012F494
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

	// Token: 0x060061BA RID: 25018 RVA: 0x0013132C File Offset: 0x0012F52C
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

	// Token: 0x060061BB RID: 25019 RVA: 0x00131420 File Offset: 0x0012F620
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

	// Token: 0x060061BC RID: 25020 RVA: 0x0013153C File Offset: 0x0012F73C
	public bool IsHideAchievementGroup(int groupId)
	{
		AchievementGroupData achievementGroupData = this.GetAchievementGroupData(new int?(groupId));
		int? num = (achievementGroupData != null) ? new int?(achievementGroupData.GetCategory()) : null;
		int categoryFunctionType = AchievementConfig.Instance.GetCategoryFunctionType(num.Value);
		return !this.showFunctionList.Contains(categoryFunctionType);
	}

	// Token: 0x060061BD RID: 25021 RVA: 0x00131590 File Offset: 0x0012F790
	public void GmClearData()
	{
		this.CurrentFinishAchievementArray.Clear();
	}

	// Token: 0x17000797 RID: 1943
	// (get) Token: 0x060061BE RID: 25022 RVA: 0x0013159D File Offset: 0x0012F79D
	public static AchievementModel Instance
	{
		get
		{
			return AchievementModel._Instance;
		}
	}

	// Token: 0x060061BF RID: 25023 RVA: 0x001315A4 File Offset: 0x0012F7A4
	public static AchievementModel GetOrCreateInstance()
	{
		if (AchievementModel._Instance == null)
		{
			AchievementModel.CreateInstance();
		}
		return AchievementModel._Instance;
	}

	// Token: 0x060061C0 RID: 25024 RVA: 0x001315B8 File Offset: 0x0012F7B8
	public static bool CreateInstance()
	{
		if (AchievementModel._Instance != null)
		{
			return true;
		}
		AchievementModel._Instance = new AchievementModel();
		return true;
	}

	// Token: 0x060061C1 RID: 25025 RVA: 0x001315CE File Offset: 0x0012F7CE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060061C2 RID: 25026 RVA: 0x001315D0 File Offset: 0x0012F7D0
	public static void ResetStaticDefaultValue()
	{
		AchievementModel._Instance = null;
	}

	// Token: 0x060061C3 RID: 25027 RVA: 0x001315D8 File Offset: 0x0012F7D8
	static AchievementModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AchievementModel.CreateStaticDefaultValue), new Action(AchievementModel.ResetStaticDefaultValue));
	}

	// Token: 0x04002C60 RID: 11360
	private const int RECENT_FINISHED_LIST_LENGTH = 5;

	// Token: 0x04002C61 RID: 11361
	private readonly int[] showFunctionList = new int[]
	{
		1
	};

	// Token: 0x04002C62 RID: 11362
	[Nullable(2)]
	public AchievementCategoryData CurrentSelectCategory;

	// Token: 0x04002C63 RID: 11363
	[Nullable(2)]
	public AchievementGroupData CurrentSelectGroup;

	// Token: 0x04002C64 RID: 11364
	public int CurrentSelectAchievementId;

	// Token: 0x04002C65 RID: 11365
	public bool AchievementSearchState;

	// Token: 0x04002C66 RID: 11366
	public string CurrentSearchText = "";

	// Token: 0x04002C67 RID: 11367
	public List<int> CurrentFinishAchievementArray = new List<int>();

	// Token: 0x04002C68 RID: 11368
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<AchievementSearchData> CurrentCacheSearchData;

	// Token: 0x04002C69 RID: 11369
	private Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>> SearchResult = new Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>>();

	// Token: 0x04002C6A RID: 11370
	private readonly Dictionary<int, List<AchievementData>> AchievementGroupMap = new Dictionary<int, List<AchievementData>>();

	// Token: 0x04002C6B RID: 11371
	private List<AchievementCategoryData> AchievementCategoryArray = new List<AchievementCategoryData>();

	// Token: 0x04002C6C RID: 11372
	private readonly Dictionary<int, List<AchievementGroupData>> AchievementCategoryGroupMap = new Dictionary<int, List<AchievementGroupData>>();

	// Token: 0x04002C6D RID: 11373
	private readonly Dictionary<int, AchievementData> AchievementMap = new Dictionary<int, AchievementData>();

	// Token: 0x04002C6E RID: 11374
	private readonly Dictionary<int, AchievementGroupData> AllAchievementGroupMap = new Dictionary<int, AchievementGroupData>();

	// Token: 0x04002C6F RID: 11375
	private List<AchievementData> CanGetRewardAchievements = new List<AchievementData>();

	// Token: 0x04002C70 RID: 11376
	private List<AchievementData> HasGetRewardAchievements = new List<AchievementData>();

	// Token: 0x04002C71 RID: 11377
	private int AchieveStarCount;

	// Token: 0x04002C72 RID: 11378
	private int AchieveFinishCount;

	// Token: 0x04002C73 RID: 11379
	private readonly Comparison<AchievementData> SortFunc = (AchievementData a, AchievementData b) => (int)(b.GetFinishTime() - a.GetFinishTime()).Value;

	// Token: 0x04002C74 RID: 11380
	public readonly Comparison<AchievementData> SortByTabIndex = (AchievementData a, AchievementData b) => b.GetFinishSort() - a.GetFinishSort();

	// Token: 0x04002C75 RID: 11381
	[Nullable(2)]
	private static AchievementModel _Instance;
}
