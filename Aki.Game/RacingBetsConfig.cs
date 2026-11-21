using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001BCB RID: 7115
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class RacingBetsConfig : ConfigBase
{
	// Token: 0x06011B86 RID: 72582 RVA: 0x0053905C File Offset: 0x0053725C
	public RacingBetsSeason? GetRacingBetsSeasonConfig(int seasonId)
	{
		RacingBetsSeason? config = ConfigRacingBetsSeasonById.GetConfig(seasonId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsSeason表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SeasonId", seasonId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B87 RID: 72583 RVA: 0x005390B4 File Offset: 0x005372B4
	public RacingBetsGroupMatch? GetRacingBetsGroupMatch(int matchId)
	{
		RacingBetsGroupMatch? config = ConfigRacingBetsGroupMatchById.GetConfig(matchId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsGroupMatch表无效MatchId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MatchId", matchId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B88 RID: 72584 RVA: 0x0053910C File Offset: 0x0053730C
	public RacingBetsLegMatches? GetRacingBetsLegMatches(int id)
	{
		RacingBetsLegMatches? config = ConfigRacingBetsLegMatchesById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsLegMatches表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B89 RID: 72585 RVA: 0x00539164 File Offset: 0x00537364
	public IReadOnlyList<RacingBetsReward> GetRacingBetsRewardList(int seasonId)
	{
		IReadOnlyList<RacingBetsReward> configList = ConfigRacingBetsRewardBySeasonId.GetConfigList(seasonId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsReward表无效seasonId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("seasonId", seasonId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x06011B8A RID: 72586 RVA: 0x005391B0 File Offset: 0x005373B0
	public RacingBetsReward? GetRacingBetsReward(int id)
	{
		RacingBetsReward? config = ConfigRacingBetsRewardById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsReward表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B8B RID: 72587 RVA: 0x00539208 File Offset: 0x00537408
	public RacingBetsBulletScreen? GetRacingBetsBulletScreen(int bulletScreenId)
	{
		RacingBetsBulletScreen? config = ConfigRacingBetsBulletScreenById.GetConfig(bulletScreenId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsBulletScreen表无效bulletScreenId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bulletScreenId", bulletScreenId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B8C RID: 72588 RVA: 0x00539260 File Offset: 0x00537460
	public IReadOnlyList<RacingBetsBulletScreen> GetRacingBetsBulletScreenList(int seasonId)
	{
		IReadOnlyList<RacingBetsBulletScreen> configList = ConfigRacingBetsBulletScreenBySeasonId.GetConfigList(seasonId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsBulletScreen表无效seasonId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("seasonId", seasonId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x06011B8D RID: 72589 RVA: 0x005392AC File Offset: 0x005374AC
	public IReadOnlyList<RacingBettingGear> GetRacingBettingGearList(int seasonId)
	{
		IReadOnlyList<RacingBettingGear> configList = ConfigRacingBettingGearBySeasonId.GetConfigList(seasonId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBettingGear表无效seasonId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("seasonId", seasonId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x06011B8E RID: 72590 RVA: 0x005392F8 File Offset: 0x005374F8
	public IReadOnlyList<RacingBetConversionRate> GetRacingBetConversionRateList(int seasonId)
	{
		IReadOnlyList<RacingBetConversionRate> configList = ConfigRacingBetConversionRateBySeasonId.GetConfigList(seasonId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetConversionRate表无效seasonId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("seasonId", seasonId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x06011B8F RID: 72591 RVA: 0x00539344 File Offset: 0x00537544
	public RacingBetMapPoint? GetRacingBetMapPointConfig(int pointId)
	{
		RacingBetMapPoint? config = ConfigRacingBetMapPointById.GetConfig(pointId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "RacingBetMapPoint表无效pointId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pointId", pointId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B90 RID: 72592 RVA: 0x0053939C File Offset: 0x0053759C
	public IReadOnlyList<RacingBetMapPoint> GetRacingBetMapPointList(int seasonId)
	{
		IReadOnlyList<RacingBetMapPoint> configList = ConfigRacingBetMapPointBySeasonId.GetConfigList(seasonId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetMapPoint表无效seasonId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("seasonId", seasonId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x06011B91 RID: 72593 RVA: 0x005393E8 File Offset: 0x005375E8
	public RacingBetRankOpenTime? GetRacingBetRankOpenTime(int legMatchId)
	{
		RacingBetRankOpenTime? config = ConfigRacingBetRankOpenTimeById.GetConfig(legMatchId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetRankOpenTime表无效legMatchId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("legMatchId", legMatchId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B92 RID: 72594 RVA: 0x00539440 File Offset: 0x00537640
	public DangoBroadcast? GetRacingBetsDangoBroadcast(int dangoId)
	{
		DangoBroadcast? config = ConfigDangoBroadcastById.GetConfig(dangoId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "DangoBroadcast表无效dangoId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dangoId", dangoId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B93 RID: 72595 RVA: 0x00539498 File Offset: 0x00537698
	public int GetRacingBetConversionRate(int rank)
	{
		RacingBetConversionRate? config = ConfigRacingBetConversionRateById.GetConfig(rank, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "RacingBetConversionRate表无效rank";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rank", rank);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		return config.Value.ConversionRate;
	}

	// Token: 0x06011B94 RID: 72596 RVA: 0x005394F8 File Offset: 0x005376F8
	public unsafe int? GetPointIdBySortId(int seasonId, int sortId)
	{
		if (!this.SortIdToPointIdCache.ContainsKey(seasonId))
		{
			IReadOnlyList<RacingBetMapPoint> racingBetMapPointList = this.GetRacingBetMapPointList(seasonId);
			if (racingBetMapPointList == null)
			{
				return null;
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (RacingBetMapPoint racingBetMapPoint in racingBetMapPointList)
			{
				dictionary[racingBetMapPoint.SortId] = racingBetMapPoint.Id;
			}
			this.SortIdToPointIdCache[seasonId] = dictionary;
		}
		int value;
		if (!this.SortIdToPointIdCache[seasonId].TryGetValue(sortId, out value))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GetPointIdBySortId pointId is undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("seasonId", seasonId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sortId", sortId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return new int?(value);
	}

	// Token: 0x06011B95 RID: 72597 RVA: 0x00539614 File Offset: 0x00537814
	public int GetPointTotal(int seasonId)
	{
		if (this.PointTotalNum != 0)
		{
			return this.PointTotalNum;
		}
		IReadOnlyList<RacingBetMapPoint> racingBetMapPointList = this.GetRacingBetMapPointList(seasonId);
		if (racingBetMapPointList == null)
		{
			return 0;
		}
		this.PointTotalNum = racingBetMapPointList.Count;
		return this.PointTotalNum;
	}

	// Token: 0x06011B96 RID: 72598 RVA: 0x0053964F File Offset: 0x0053784F
	public IReadOnlyList<RacingBetsRuleTextPool> GetRandomRuleTextPool(int seasonId)
	{
		return ConfigRacingBetsRuleTextPoolBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x06011B97 RID: 72599 RVA: 0x00539658 File Offset: 0x00537858
	[NullableContext(1)]
	public string GetRandomRuleText(int seasonId)
	{
		IReadOnlyList<RacingBetsRuleTextPool> configList = ConfigRacingBetsRuleTextPoolBySeasonId.GetConfigList(seasonId, true);
		if (configList == null || configList.Count == 0)
		{
			return string.Empty;
		}
		int index = new Random().Next(configList.Count);
		return configList[index].RuleText;
	}

	// Token: 0x06011B98 RID: 72600 RVA: 0x005396A0 File Offset: 0x005378A0
	public float GetRuleRate()
	{
		return ConfigCommonParamById.GetFloatConfig("RacingBetsBroadcastRuleRate").GetValueOrDefault();
	}

	// Token: 0x06011B99 RID: 72601 RVA: 0x005396BF File Offset: 0x005378BF
	public IReadOnlyList<RacingBetsMatch> GetMatchTableConfigBySeasonId(int seasonId)
	{
		return ConfigRacingBetsMatchBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x06011B9A RID: 72602 RVA: 0x005396C8 File Offset: 0x005378C8
	public RacingBetsMatch? GetMatchTableConfigById(int id)
	{
		return ConfigRacingBetsMatchById.GetConfig(id, true);
	}

	// Token: 0x06011B9B RID: 72603 RVA: 0x005396D4 File Offset: 0x005378D4
	public Dictionary<int, int> GetLegMatchOrganMap(int seasonId, int legMatchId)
	{
		RacingBetsLegMatches? racingBetsLegMatches = this.GetRacingBetsLegMatches(legMatchId);
		if (racingBetsLegMatches == null)
		{
			return null;
		}
		int organListLength = racingBetsLegMatches.Value.OrganListLength;
		List<string> list = new List<string>(organListLength);
		for (int i = 0; i < organListLength; i++)
		{
			list.Add(racingBetsLegMatches.Value.OrganList(i));
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		int pointTotal = this.GetPointTotal(seasonId);
		if (pointTotal == 0)
		{
			return dictionary;
		}
		foreach (string text in list)
		{
			string[] array = text.Split(':', StringSplitOptions.None);
			int num;
			int value;
			if (array.Length >= 2 && int.TryParse(array[0], out num) && int.TryParse(array[1], out value))
			{
				int sortId = ((num - 1) % pointTotal + pointTotal) % pointTotal + 1;
				int? pointIdBySortId = this.GetPointIdBySortId(seasonId, sortId);
				if (pointIdBySortId != null)
				{
					dictionary[pointIdBySortId.Value] = value;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06011B9C RID: 72604 RVA: 0x005397E4 File Offset: 0x005379E4
	public RacingBetsOrgan? GetOrganConfig(int organId)
	{
		RacingBetsOrgan? config = ConfigRacingBetsOrganById.GetConfig(organId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "RacingBetsOrgan表无效organId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("organId", organId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011B9D RID: 72605 RVA: 0x0053983C File Offset: 0x00537A3C
	[NullableContext(1)]
	public List<int> GetDangoIdByType(ERacingBetsDangoType type)
	{
		IReadOnlyList<Dango> configList = ConfigDangoByType.GetConfigList((int)type, true);
		if (configList == null)
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		foreach (Dango dango in configList)
		{
			list.Add(dango.Id);
		}
		return list;
	}

	// Token: 0x17001AC8 RID: 6856
	// (get) Token: 0x06011B9E RID: 72606 RVA: 0x005398A4 File Offset: 0x00537AA4
	[Nullable(1)]
	public static RacingBetsConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RacingBetsConfig._Instance;
		}
	}

	// Token: 0x06011B9F RID: 72607 RVA: 0x005398AB File Offset: 0x00537AAB
	[NullableContext(1)]
	public static RacingBetsConfig GetOrCreateInstance()
	{
		if (RacingBetsConfig._Instance == null)
		{
			RacingBetsConfig.CreateInstance();
		}
		return RacingBetsConfig._Instance;
	}

	// Token: 0x06011BA0 RID: 72608 RVA: 0x005398BF File Offset: 0x00537ABF
	public static bool CreateInstance()
	{
		if (RacingBetsConfig._Instance != null)
		{
			return true;
		}
		RacingBetsConfig._Instance = new RacingBetsConfig();
		return true;
	}

	// Token: 0x06011BA1 RID: 72609 RVA: 0x005398D5 File Offset: 0x00537AD5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011BA2 RID: 72610 RVA: 0x005398D7 File Offset: 0x00537AD7
	public static void ResetStaticDefaultValue()
	{
		RacingBetsConfig._Instance = null;
	}

	// Token: 0x06011BA3 RID: 72611 RVA: 0x005398DF File Offset: 0x00537ADF
	static RacingBetsConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsConfig.CreateStaticDefaultValue), new Action(RacingBetsConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009ABB RID: 39611
	[Nullable(1)]
	private readonly Dictionary<int, Dictionary<int, int>> SortIdToPointIdCache = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x04009ABC RID: 39612
	private int PointTotalNum;

	// Token: 0x04009ABD RID: 39613
	private static RacingBetsConfig _Instance;
}
