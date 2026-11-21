using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020021AA RID: 8618
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TutorialModel : ModelBase
{
	// Token: 0x0601532D RID: 86829 RVA: 0x00629E14 File Offset: 0x00628014
	protected override bool OnInit()
	{
		foreach (object obj in Enum.GetValues(typeof(ETutorialType)))
		{
			int key = (int)obj;
			this.TutorialTotalData.Add((ETutorialType)key, new Dictionary<int, TutorialSaveData>());
		}
		return true;
	}

	// Token: 0x0601532E RID: 86830 RVA: 0x00629E84 File Offset: 0x00628084
	public void InitTutorialTotalData()
	{
		foreach (TutorialSaveData tutorialSaveData in new List<TutorialSaveData>(this.TutorialSaveDataMap.Values))
		{
			TutorialSaveData tutorialSaveData2 = new TutorialSaveData();
			tutorialSaveData2.TimeStamp = tutorialSaveData.TimeStamp;
			tutorialSaveData2.TutorialId = tutorialSaveData.TutorialId;
			tutorialSaveData2.HasRedDot = tutorialSaveData.HasRedDot;
			int tutorialType = tutorialSaveData2.TutorialData.Value.TutorialType;
			int id = tutorialSaveData2.TutorialData.Value.Id;
			this.TutorialTotalData[(ETutorialType)tutorialType][id] = tutorialSaveData2;
			this.TutorialTotalData[ETutorialType.All][id] = tutorialSaveData2;
			this.TutorialSaveDataMap[id] = tutorialSaveData2;
		}
	}

	// Token: 0x0601532F RID: 86831 RVA: 0x00629F74 File Offset: 0x00628174
	protected override bool OnClear()
	{
		foreach (Dictionary<int, TutorialSaveData> dictionary in this.TutorialTotalData.Values)
		{
			dictionary.Clear();
		}
		this.TutorialTotalData.Clear();
		return true;
	}

	// Token: 0x06015330 RID: 86832 RVA: 0x00629FD8 File Offset: 0x006281D8
	public void InitUnlockTutorials(IReadOnlyList<TutorialInfo> tutorialInfos)
	{
		foreach (TutorialInfo tutorialInfo in tutorialInfos)
		{
			TutorialSaveData tutorialSaveData = new TutorialSaveData();
			tutorialSaveData.TimeStamp = (int)tutorialInfo.CreateTime;
			tutorialSaveData.TutorialId = tutorialInfo.Id;
			tutorialSaveData.HasRedDot = !tutorialInfo.GetAward;
			int tutorialType = tutorialSaveData.TutorialData.Value.TutorialType;
			if (Enum.IsDefined(typeof(ETutorialType), tutorialType))
			{
				if (!this.TutorialTotalData[(ETutorialType)tutorialType].ContainsKey(tutorialSaveData.TutorialId))
				{
					this.TutorialTotalData[(ETutorialType)tutorialType].Add(tutorialSaveData.TutorialId, tutorialSaveData);
					this.TutorialSaveDataMap.Add(tutorialSaveData.TutorialId, tutorialSaveData);
				}
				this.InvokeTutorialRedDot(tutorialSaveData);
			}
		}
	}

	// Token: 0x06015331 RID: 86833 RVA: 0x0062A0C8 File Offset: 0x006282C8
	public void InitDefaultUnlockTutorials()
	{
		foreach (GuideTutorial guideTutorial in GuideConfig.Instance.GetAllTutorial())
		{
			if (guideTutorial.DefaultUnlock)
			{
				TutorialSaveData tutorialSaveData = new TutorialSaveData();
				tutorialSaveData.TimeStamp = 0;
				tutorialSaveData.TutorialId = guideTutorial.Id;
				tutorialSaveData.HasRedDot = false;
				int tutorialType = guideTutorial.TutorialType;
				if (Enum.IsDefined(typeof(ETutorialType), tutorialType))
				{
					this.TutorialTotalData[(ETutorialType)tutorialType].Add(tutorialSaveData.TutorialId, tutorialSaveData);
					this.TutorialSaveDataMap.Add(tutorialSaveData.TutorialId, tutorialSaveData);
				}
			}
		}
	}

	// Token: 0x06015332 RID: 86834 RVA: 0x0062A188 File Offset: 0x00628388
	public void UpdateUnlockTutorials(TutorialInfo tutorialInfo)
	{
		TutorialSaveData tutorialSaveData = new TutorialSaveData();
		tutorialSaveData.TimeStamp = (int)tutorialInfo.CreateTime;
		tutorialSaveData.TutorialId = tutorialInfo.Id;
		tutorialSaveData.HasRedDot = !tutorialInfo.GetAward;
		int tutorialType = tutorialSaveData.TutorialData.Value.TutorialType;
		if (!Enum.IsDefined(typeof(ETutorialType), tutorialType))
		{
			return;
		}
		if (this.TutorialTotalData[(ETutorialType)tutorialType].ContainsKey(tutorialSaveData.TutorialId))
		{
			return;
		}
		this.TutorialTotalData[(ETutorialType)tutorialType].Add(tutorialSaveData.TutorialId, tutorialSaveData);
		this.TutorialTotalData[ETutorialType.All].Add(tutorialSaveData.TutorialId, tutorialSaveData);
		this.TutorialSaveDataMap.Add(tutorialSaveData.TutorialId, tutorialSaveData);
		this.InvokeUpdateTutorials();
		this.InvokeTutorialRedDot(tutorialSaveData);
	}

	// Token: 0x06015333 RID: 86835 RVA: 0x0062A25C File Offset: 0x0062845C
	public List<TutorialItemData> GetUnlockedTutorialDataByType(ETutorialType tType, EExclusiveTutorialType exclusiveType = EExclusiveTutorialType.None)
	{
		Dictionary<int, TutorialSaveData> dictionary = this.TutorialTotalData[tType];
		List<TutorialItemData> list = new List<TutorialItemData>();
		foreach (TutorialSaveData tutorialSaveData in dictionary.Values)
		{
			if (!tutorialSaveData.IsExcludedFromWiki)
			{
				GuideTutorial? tutorialData = tutorialSaveData.TutorialData;
				int? num = (tutorialData != null) ? new int?(tutorialData.GetValueOrDefault().ExclusiveType) : null;
				if (num.GetValueOrDefault() == (int)exclusiveType & num != null)
				{
					TutorialItemData tutorialItemData = new TutorialItemData();
					tutorialItemData.IsTypeTitle = false;
					tutorialData = tutorialSaveData.TutorialData;
					tutorialItemData.TextId = tutorialData.Value.GroupName;
					tutorialItemData.SavedData = tutorialSaveData;
					tutorialItemData.OwnerType = new ETutorialType?(tType);
					TutorialItemData item = tutorialItemData;
					if (tutorialSaveData.HasRedDot)
					{
						this.InvokeTutorialRedDot(tutorialSaveData);
					}
					list.Add(item);
				}
			}
		}
		list.Sort(delegate(TutorialItemData d1, TutorialItemData d2)
		{
			if (d1.SavedData.HasRedDot && !d2.SavedData.HasRedDot)
			{
				return -1;
			}
			if (!d1.SavedData.HasRedDot && d2.SavedData.HasRedDot)
			{
				return 1;
			}
			if (d1.SavedData.HasRedDot && d2.SavedData.HasRedDot)
			{
				return d2.SavedData.TimeStamp - d1.SavedData.TimeStamp;
			}
			if (tType == ETutorialType.All)
			{
				return d2.SavedData.TimeStamp - d1.SavedData.TimeStamp;
			}
			GuideTutorial value = d1.SavedData.TutorialData.Value;
			GuideTutorial value2 = d2.SavedData.TutorialData.Value;
			if (d1.SavedData.TimeStamp != d2.SavedData.TimeStamp)
			{
				return d1.SavedData.TimeStamp - d2.SavedData.TimeStamp;
			}
			if (value.TutorialOrder != value2.TutorialOrder)
			{
				return value.TutorialOrder - value2.TutorialOrder;
			}
			return value.Id - value2.Id;
		});
		bool flag = tType > ETutorialType.All;
		bool flag2 = exclusiveType > EExclusiveTutorialType.None;
		if (flag || flag2)
		{
			return list;
		}
		int val = list.Count;
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].SavedData.HasRedDot)
			{
				val = i + TutorialUtils.MaxLatestTutorial.Value;
				break;
			}
		}
		return list.GetRange(0, Math.Min(val, list.Count));
	}

	// Token: 0x06015334 RID: 86836 RVA: 0x0062A408 File Offset: 0x00628608
	public void RemoveRedDotTutorialId(int tutorialId)
	{
		if (!this.TutorialSaveDataMap.ContainsKey(tutorialId))
		{
			return;
		}
		TutorialSaveData tutorialSaveData = this.TutorialSaveDataMap[tutorialId];
		tutorialSaveData.HasRedDot = false;
		this.InvokeTutorialRedDot(tutorialSaveData);
	}

	// Token: 0x06015335 RID: 86837 RVA: 0x0062A440 File Offset: 0x00628640
	public bool RedDotCheckIsNewTutorial(int tutorialId)
	{
		TutorialSaveData tutorialSaveData;
		return this.TutorialSaveDataMap.TryGetValue(tutorialId, out tutorialSaveData) && tutorialSaveData.HasRedDot;
	}

	// Token: 0x06015336 RID: 86838 RVA: 0x0062A465 File Offset: 0x00628665
	public void InvokeUpdateTutorials()
	{
		EventSystem.Instance.Emit(EEventName.OnTutorialUpdate);
	}

	// Token: 0x06015337 RID: 86839 RVA: 0x0062A478 File Offset: 0x00628678
	[NullableContext(2)]
	public void InvokeTutorialRedDot(TutorialSaveData saveData = null)
	{
		int p = (saveData != null) ? saveData.TutorialId : 0;
		EventSystem.Instance.Emit<int>(EEventName.RedDotNewTutorial, p);
		if (saveData != null)
		{
			EventSystem.Instance.Emit<ETutorialType>(EEventName.RedDotNewTutorialType, ETutorialType.All);
		}
	}

	// Token: 0x06015338 RID: 86840 RVA: 0x0062A4B8 File Offset: 0x006286B8
	public bool RedDotCheckIsNewTutorialType(ETutorialType tType)
	{
		if (!this.TutorialTotalData.ContainsKey(tType))
		{
			return false;
		}
		foreach (TutorialSaveData tutorialSaveData in this.TutorialTotalData[tType].Values)
		{
			GuideTutorial? guideTutorial;
			int? num = (tutorialSaveData.TutorialData != null) ? new int?(guideTutorial.GetValueOrDefault().ExclusiveType) : null;
			int currentExclusiveType = (int)this.CurrentExclusiveType;
			if ((num.GetValueOrDefault() == currentExclusiveType & num != null) && tutorialSaveData.HasRedDot && !tutorialSaveData.IsExcludedFromWiki)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06015339 RID: 86841 RVA: 0x0062A588 File Offset: 0x00628788
	[return: TupleElementNames(new string[]
	{
		"ItemData",
		"HasTutorial"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<List<TutorialItemData>, bool> MakeSearchList(string searchText, ETutorialType? currentType, EExclusiveTutorialType exclusiveType = EExclusiveTutorialType.None)
	{
		Regex regex = null;
		List<TutorialItemData> list = new List<TutorialItemData>();
		try
		{
			regex = new Regex(searchText, RegexOptions.IgnoreCase);
		}
		catch
		{
			return new ValueTuple<List<TutorialItemData>, bool>(list, false);
		}
		bool item = false;
		List<ETutorialType> list2 = new List<ETutorialType>();
		if (currentType != null && this.TutorialTotalData.ContainsKey(currentType.Value))
		{
			list2.Add(currentType.Value);
		}
		foreach (ETutorialType etutorialType in this.TutorialTotalData.Keys)
		{
			if (currentType == null || etutorialType != currentType.Value)
			{
				list2.Add(etutorialType);
			}
		}
		foreach (ETutorialType etutorialType2 in list2)
		{
			if (etutorialType2 != ETutorialType.All)
			{
				List<TutorialItemData> list3 = new List<TutorialItemData>();
				foreach (TutorialSaveData tutorialSaveData in this.TutorialTotalData[etutorialType2].Values)
				{
					if (!tutorialSaveData.IsExcludedFromWiki)
					{
						GuideTutorial? tutorialData = tutorialSaveData.TutorialData;
						int? num = (tutorialData != null) ? new int?(tutorialData.GetValueOrDefault().ExclusiveType) : null;
						if (num.GetValueOrDefault() == (int)exclusiveType & num != null)
						{
							string tutorialTitle = tutorialSaveData.GetTutorialTitle();
							if (regex.Match(tutorialTitle).Success)
							{
								TutorialItemData tutorialItemData = new TutorialItemData();
								tutorialItemData.IsTypeTitle = false;
								tutorialData = tutorialSaveData.TutorialData;
								tutorialItemData.TextId = tutorialData.Value.GroupName;
								tutorialItemData.SavedData = tutorialSaveData;
								tutorialItemData.Text = tutorialTitle.Replace(searchText, TutorialUtils.AddSearchHighlight(searchText));
								TutorialItemData item2 = tutorialItemData;
								item = true;
								list3.Add(item2);
							}
						}
					}
				}
				ETutorialType? etutorialType3 = currentType;
				ETutorialType etutorialType4 = ETutorialType.All;
				if (etutorialType3.GetValueOrDefault() == etutorialType4 & etutorialType3 != null)
				{
					list.AddRange(list3);
				}
				else if (list3.Count > 0)
				{
					list.Add(new TutorialItemData
					{
						IsTypeTitle = true,
						TextId = TutorialUtils.GetTutorialTypeTxt(etutorialType2)
					});
					list.AddRange(list3);
				}
			}
		}
		return new ValueTuple<List<TutorialItemData>, bool>(list, item);
	}

	// Token: 0x0601533A RID: 86842 RVA: 0x0062A848 File Offset: 0x00628A48
	[NullableContext(2)]
	public TutorialSaveData GetSavedDataById(int tId)
	{
		TutorialSaveData result;
		if (this.TutorialSaveDataMap.TryGetValue(tId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x1700201C RID: 8220
	// (get) Token: 0x0601533B RID: 86843 RVA: 0x0062A868 File Offset: 0x00628A68
	public static TutorialModel Instance
	{
		get
		{
			return TutorialModel._Instance;
		}
	}

	// Token: 0x0601533C RID: 86844 RVA: 0x0062A86F File Offset: 0x00628A6F
	public static TutorialModel GetOrCreateInstance()
	{
		if (TutorialModel._Instance == null)
		{
			TutorialModel.CreateInstance();
		}
		return TutorialModel._Instance;
	}

	// Token: 0x0601533D RID: 86845 RVA: 0x0062A883 File Offset: 0x00628A83
	public static bool CreateInstance()
	{
		if (TutorialModel._Instance != null)
		{
			return true;
		}
		TutorialModel._Instance = new TutorialModel();
		return true;
	}

	// Token: 0x0601533E RID: 86846 RVA: 0x0062A899 File Offset: 0x00628A99
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601533F RID: 86847 RVA: 0x0062A89B File Offset: 0x00628A9B
	public static void ResetStaticDefaultValue()
	{
		TutorialModel._Instance = null;
	}

	// Token: 0x06015340 RID: 86848 RVA: 0x0062A8A3 File Offset: 0x00628AA3
	static TutorialModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TutorialModel.CreateStaticDefaultValue), new Action(TutorialModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B3CA RID: 46026
	[Nullable(2)]
	public ItemRewardNotify RewardInfo;

	// Token: 0x0400B3CB RID: 46027
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public List<ValueTuple<int, int>> RewardList = new List<ValueTuple<int, int>>();

	// Token: 0x0400B3CC RID: 46028
	public EExclusiveTutorialType CurrentExclusiveType;

	// Token: 0x0400B3CD RID: 46029
	private readonly Dictionary<ETutorialType, Dictionary<int, TutorialSaveData>> TutorialTotalData = new Dictionary<ETutorialType, Dictionary<int, TutorialSaveData>>();

	// Token: 0x0400B3CE RID: 46030
	private readonly Dictionary<int, TutorialSaveData> TutorialSaveDataMap = new Dictionary<int, TutorialSaveData>();

	// Token: 0x0400B3CF RID: 46031
	[Nullable(2)]
	private static TutorialModel _Instance;
}
