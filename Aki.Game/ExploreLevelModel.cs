using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.ExploreLevel;

// Token: 0x02000F51 RID: 3921
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ExploreLevelModel : ModelBase
{
	// Token: 0x06009CDE RID: 40158 RVA: 0x002E7CD8 File Offset: 0x002E5ED8
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

	// Token: 0x06009CDF RID: 40159 RVA: 0x002E7E14 File Offset: 0x002E6014
	protected override bool OnClear()
	{
		this.CountryExploreLevelDataMap.Clear();
		return true;
	}

	// Token: 0x06009CE0 RID: 40160 RVA: 0x002E7E24 File Offset: 0x002E6024
	public CountryExploreLevelData AddCountryExploreLevelData(int countryId)
	{
		IReadOnlyList<ExploreReward> exploreRewardListByCountry = ExploreLevelConfig.Instance.GetExploreRewardListByCountry(countryId);
		CountryExploreLevelData countryExploreLevelData = new CountryExploreLevelData();
		countryExploreLevelData.Initialize(countryId, exploreRewardListByCountry);
		this.CountryExploreLevelDataMap[countryId] = countryExploreLevelData;
		return countryExploreLevelData;
	}

	// Token: 0x06009CE1 RID: 40161 RVA: 0x002E7E5C File Offset: 0x002E605C
	[NullableContext(2)]
	public CountryExploreLevelData GetCountryExploreLevelData(int countryId)
	{
		CountryExploreLevelData result;
		this.CountryExploreLevelDataMap.TryGetValue(countryId, out result);
		return result;
	}

	// Token: 0x06009CE2 RID: 40162 RVA: 0x002E7E7C File Offset: 0x002E607C
	[NullableContext(2)]
	public CountryExploreLevelData GetCurrentCountryExploreLevelData()
	{
		return this.GetCountryExploreLevelData(AreaModel.Instance.GetAreaCountryId().Value);
	}

	// Token: 0x06009CE3 RID: 40163 RVA: 0x002E7EA4 File Offset: 0x002E60A4
	public void SetCountryExploreLevel(int countryId, int countryExploreLevel)
	{
		CountryExploreLevelData countryExploreLevelData = this.GetCountryExploreLevelData(countryId);
		if (countryExploreLevelData == null)
		{
			return;
		}
		countryExploreLevelData.SetExploreLevel(countryExploreLevel);
	}

	// Token: 0x06009CE4 RID: 40164 RVA: 0x002E7EC4 File Offset: 0x002E60C4
	public void SetCountryExploreScore(int countryId, int exploreScore)
	{
		CountryExploreLevelData countryExploreLevelData = this.GetCountryExploreLevelData(countryId);
		if (countryExploreLevelData == null)
		{
			return;
		}
		countryExploreLevelData.SetExploreScore(exploreScore);
	}

	// Token: 0x06009CE5 RID: 40165 RVA: 0x002E7EE4 File Offset: 0x002E60E4
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

	// Token: 0x1700109B RID: 4251
	// (get) Token: 0x06009CE6 RID: 40166 RVA: 0x002E7F2B File Offset: 0x002E612B
	public static ExploreLevelModel Instance
	{
		get
		{
			return ExploreLevelModel._Instance;
		}
	}

	// Token: 0x06009CE7 RID: 40167 RVA: 0x002E7F32 File Offset: 0x002E6132
	public static ExploreLevelModel GetOrCreateInstance()
	{
		if (ExploreLevelModel._Instance == null)
		{
			ExploreLevelModel.CreateInstance();
		}
		return ExploreLevelModel._Instance;
	}

	// Token: 0x06009CE8 RID: 40168 RVA: 0x002E7F46 File Offset: 0x002E6146
	public static bool CreateInstance()
	{
		if (ExploreLevelModel._Instance != null)
		{
			return true;
		}
		ExploreLevelModel._Instance = new ExploreLevelModel();
		return true;
	}

	// Token: 0x06009CE9 RID: 40169 RVA: 0x002E7F5C File Offset: 0x002E615C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009CEA RID: 40170 RVA: 0x002E7F5E File Offset: 0x002E615E
	public static void ResetStaticDefaultValue()
	{
		ExploreLevelModel._Instance = null;
	}

	// Token: 0x06009CEB RID: 40171 RVA: 0x002E7F66 File Offset: 0x002E6166
	static ExploreLevelModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreLevelModel.CreateStaticDefaultValue), new Action(ExploreLevelModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005D4F RID: 23887
	private Dictionary<int, CountryExploreLevelData> CountryExploreLevelDataMap = new Dictionary<int, CountryExploreLevelData>();

	// Token: 0x04005D50 RID: 23888
	public string ExploreScoreItemTexturePath = "";

	// Token: 0x04005D51 RID: 23889
	[Nullable(2)]
	private static ExploreLevelModel _Instance;
}
