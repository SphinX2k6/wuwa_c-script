using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.ExploreLevel;

// Token: 0x02001A92 RID: 6802
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ExploreLevelModel : ModelBase
{
	// Token: 0x0600C8CD RID: 51405 RVA: 0x002DCBA4 File Offset: 0x002DADA4
	protected override bool OnInit()
	{
		foreach (Country country in InfluenceConfig.Instance.GetCountryList())
		{
			this.AddCountryExploreLevelData(country.Id);
		}
		IEnumerable<ExploreScore> exploreScoreConfigList = ExploreLevelConfig.Instance.GetExploreScoreConfigList();
		AreaConfig instance = AreaConfig.Instance;
		foreach (ExploreScore exploreScore in exploreScoreConfigList)
		{
			int area = exploreScore.Area;
			int countryId = instance.GetAreaInfo(area).Value.CountryId;
			CountryExploreLevelData countryExploreLevelData = this.GetCountryExploreLevelData(countryId);
			int lastProgress = 0;
			for (int i = 0; i < exploreScore.ScoreLength; i++)
			{
				DicIntInt value = exploreScore.Score(i).Value;
				int key = value.Key;
				int value2 = value.Value;
				countryExploreLevelData.AddExploreScoreData(area, key, lastProgress, value2);
				lastProgress = key;
			}
		}
		this.ExploreScoreItemTexturePath = UiResourceConfig.Instance.GetResourcePath("T_IconA_currency_5_UI");
		return true;
	}

	// Token: 0x0600C8CE RID: 51406 RVA: 0x002DCCE0 File Offset: 0x002DAEE0
	protected override bool OnClear()
	{
		this.CountryExploreLevelDataMap.Clear();
		return true;
	}

	// Token: 0x0600C8CF RID: 51407 RVA: 0x002DCCF0 File Offset: 0x002DAEF0
	public CountryExploreLevelData AddCountryExploreLevelData(int countryId)
	{
		IReadOnlyList<ExploreReward> exploreRewardListByCountry = ExploreLevelConfig.Instance.GetExploreRewardListByCountry(countryId);
		CountryExploreLevelData countryExploreLevelData = new CountryExploreLevelData();
		countryExploreLevelData.Initialize(countryId, exploreRewardListByCountry);
		this.CountryExploreLevelDataMap[countryId] = countryExploreLevelData;
		return countryExploreLevelData;
	}

	// Token: 0x0600C8D0 RID: 51408 RVA: 0x002DCD28 File Offset: 0x002DAF28
	[NullableContext(2)]
	public CountryExploreLevelData GetCountryExploreLevelData(int countryId)
	{
		CountryExploreLevelData result;
		this.CountryExploreLevelDataMap.TryGetValue(countryId, out result);
		return result;
	}

	// Token: 0x0600C8D1 RID: 51409 RVA: 0x002DCD48 File Offset: 0x002DAF48
	[NullableContext(2)]
	public CountryExploreLevelData GetCurrentCountryExploreLevelData()
	{
		return this.GetCountryExploreLevelData(AreaModel.Instance.GetAreaCountryId().Value);
	}

	// Token: 0x0600C8D2 RID: 51410 RVA: 0x002DCD70 File Offset: 0x002DAF70
	public void SetCountryExploreLevel(int countryId, int countryExploreLevel)
	{
		CountryExploreLevelData countryExploreLevelData = this.GetCountryExploreLevelData(countryId);
		if (countryExploreLevelData == null)
		{
			return;
		}
		countryExploreLevelData.SetExploreLevel(countryExploreLevel);
	}

	// Token: 0x0600C8D3 RID: 51411 RVA: 0x002DCD90 File Offset: 0x002DAF90
	public void SetCountryExploreScore(int countryId, int exploreScore)
	{
		CountryExploreLevelData countryExploreLevelData = this.GetCountryExploreLevelData(countryId);
		if (countryExploreLevelData == null)
		{
			return;
		}
		countryExploreLevelData.SetExploreScore(exploreScore);
	}

	// Token: 0x0600C8D4 RID: 51412 RVA: 0x002DCDB0 File Offset: 0x002DAFB0
	public void SetCountryExploreScoreReceived(int areaId, int progress, bool bReceived)
	{
		Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
		if (areaInfo == null)
		{
			return;
		}
		int countryId = areaInfo.Value.CountryId;
		CountryExploreLevelData countryExploreLevelData = this.GetCountryExploreLevelData(countryId);
		if (countryExploreLevelData == null)
		{
			return;
		}
		countryExploreLevelData.SetExploreScoreDataReceived(areaId, progress, bReceived);
	}

	// Token: 0x17001076 RID: 4214
	// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x002DCDF7 File Offset: 0x002DAFF7
	public static ExploreLevelModel Instance
	{
		get
		{
			return ExploreLevelModel._Instance;
		}
	}

	// Token: 0x0600C8D6 RID: 51414 RVA: 0x002DCDFE File Offset: 0x002DAFFE
	public static ExploreLevelModel GetOrCreateInstance()
	{
		if (ExploreLevelModel._Instance == null)
		{
			ExploreLevelModel.CreateInstance();
		}
		return ExploreLevelModel._Instance;
	}

	// Token: 0x0600C8D7 RID: 51415 RVA: 0x002DCE12 File Offset: 0x002DB012
	public static bool CreateInstance()
	{
		if (ExploreLevelModel._Instance != null)
		{
			return true;
		}
		ExploreLevelModel._Instance = new ExploreLevelModel();
		return true;
	}

	// Token: 0x0600C8D8 RID: 51416 RVA: 0x002DCE28 File Offset: 0x002DB028
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C8D9 RID: 51417 RVA: 0x002DCE2A File Offset: 0x002DB02A
	public static void ResetStaticDefaultValue()
	{
		ExploreLevelModel._Instance = null;
	}

	// Token: 0x0600C8DA RID: 51418 RVA: 0x002DCE32 File Offset: 0x002DB032
	static ExploreLevelModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreLevelModel.CreateStaticDefaultValue), new Action(ExploreLevelModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005C80 RID: 23680
	private Dictionary<int, CountryExploreLevelData> CountryExploreLevelDataMap = new Dictionary<int, CountryExploreLevelData>();

	// Token: 0x04005C81 RID: 23681
	public string ExploreScoreItemTexturePath = "";

	// Token: 0x04005C82 RID: 23682
	[Nullable(2)]
	private static ExploreLevelModel _Instance;
}
