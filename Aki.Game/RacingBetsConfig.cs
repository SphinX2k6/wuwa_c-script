using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020026E0 RID: 9952
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class RacingBetsConfig : ConfigBase
{
	// Token: 0x060146A4 RID: 83620 RVA: 0x0052A340 File Offset: 0x00528540
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

	// Token: 0x060146A5 RID: 83621 RVA: 0x0052A398 File Offset: 0x00528598
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

	// Token: 0x060146A6 RID: 83622 RVA: 0x0052A3F0 File Offset: 0x005285F0
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

	// Token: 0x060146A7 RID: 83623 RVA: 0x0052A448 File Offset: 0x00528648
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

	// Token: 0x060146A8 RID: 83624 RVA: 0x0052A494 File Offset: 0x00528694
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

	// Token: 0x060146A9 RID: 83625 RVA: 0x0052A4EC File Offset: 0x005286EC
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

	// Token: 0x060146AA RID: 83626 RVA: 0x0052A544 File Offset: 0x00528744
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

	// Token: 0x060146AB RID: 83627 RVA: 0x0052A590 File Offset: 0x00528790
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

	// Token: 0x060146AC RID: 83628 RVA: 0x0052A5DC File Offset: 0x005287DC
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

	// Token: 0x060146AD RID: 83629 RVA: 0x0052A628 File Offset: 0x00528828
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

	// Token: 0x060146AE RID: 83630 RVA: 0x0052A680 File Offset: 0x00528880
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

	// Token: 0x060146AF RID: 83631 RVA: 0x0052A6CC File Offset: 0x005288CC
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

	// Token: 0x060146B0 RID: 83632 RVA: 0x0052A724 File Offset: 0x00528924
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

	// Token: 0x060146B1 RID: 83633 RVA: 0x0052A77C File Offset: 0x0052897C
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

	// Token: 0x060146B2 RID: 83634 RVA: 0x0052A7DC File Offset: 0x005289DC
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

	// Token: 0x060146B3 RID: 83635 RVA: 0x0052A8F8 File Offset: 0x00528AF8
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

	// Token: 0x060146B4 RID: 83636 RVA: 0x0052A933 File Offset: 0x00528B33
	public IReadOnlyList<RacingBetsRuleTextPool> GetRandomRuleTextPool(int seasonId)
	{
		return ConfigRacingBetsRuleTextPoolBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x060146B5 RID: 83637 RVA: 0x0052A93C File Offset: 0x00528B3C
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

	// Token: 0x060146B6 RID: 83638 RVA: 0x0052A984 File Offset: 0x00528B84
	public float GetRuleRate()
	{
		return ConfigCommonParamById.GetFloatConfig("RacingBetsBroadcastRuleRate").GetValueOrDefault();
	}

	// Token: 0x060146B7 RID: 83639 RVA: 0x0052A9A3 File Offset: 0x00528BA3
	public IReadOnlyList<RacingBetsMatch> GetMatchTableConfigBySeasonId(int seasonId)
	{
		return ConfigRacingBetsMatchBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x060146B8 RID: 83640 RVA: 0x0052A9AC File Offset: 0x00528BAC
	public RacingBetsMatch? GetMatchTableConfigById(int id)
	{
		return ConfigRacingBetsMatchById.GetConfig(id, true);
	}

	// Token: 0x060146B9 RID: 83641 RVA: 0x0052A9B8 File Offset: 0x00528BB8
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

	// Token: 0x060146BA RID: 83642 RVA: 0x0052AAC8 File Offset: 0x00528CC8
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

	// Token: 0x060146BB RID: 83643 RVA: 0x0052AB20 File Offset: 0x00528D20
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

	// Token: 0x17001A90 RID: 6800
	// (get) Token: 0x060146BC RID: 83644 RVA: 0x0052AB88 File Offset: 0x00528D88
	[Nullable(1)]
	public static RacingBetsConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RacingBetsConfig._Instance;
		}
	}

	// Token: 0x060146BD RID: 83645 RVA: 0x0052AB8F File Offset: 0x00528D8F
	[NullableContext(1)]
	public static RacingBetsConfig GetOrCreateInstance()
	{
		if (RacingBetsConfig._Instance == null)
		{
			RacingBetsConfig.CreateInstance();
		}
		return RacingBetsConfig._Instance;
	}

	// Token: 0x060146BE RID: 83646 RVA: 0x0052ABA3 File Offset: 0x00528DA3
	public static bool CreateInstance()
	{
		if (RacingBetsConfig._Instance != null)
		{
			return true;
		}
		RacingBetsConfig._Instance = new RacingBetsConfig();
		return true;
	}

	// Token: 0x060146BF RID: 83647 RVA: 0x0052ABB9 File Offset: 0x00528DB9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060146C0 RID: 83648 RVA: 0x0052ABBB File Offset: 0x00528DBB
	public static void ResetStaticDefaultValue()
	{
		RacingBetsConfig._Instance = null;
	}

	// Token: 0x060146C1 RID: 83649 RVA: 0x0052ABC3 File Offset: 0x00528DC3
	static RacingBetsConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsConfig.CreateStaticDefaultValue), new Action(RacingBetsConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009963 RID: 39267
	[Nullable(1)]
	private readonly Dictionary<int, Dictionary<int, int>> SortIdToPointIdCache = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x04009964 RID: 39268
	private int PointTotalNum;

	// Token: 0x04009965 RID: 39269
	private static RacingBetsConfig _Instance;
}
