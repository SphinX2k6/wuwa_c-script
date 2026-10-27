using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ExploreLevel
{
	// Token: 0x02005A8B RID: 23179
	[NullableContext(1)]
	[Nullable(0)]
	public class CountryExploreLevelData
	{
		// Token: 0x0603AB4B RID: 240459 RVA: 0x00DFBF94 File Offset: 0x00DFA194
		public void Initialize(int countryId, IReadOnlyList<ExploreReward> rewardConfigList)
		{
			this.CountryId = countryId;
			this.MaxExploreLevel = 0;
			foreach (ExploreReward exploreRewardConfig in rewardConfigList)
			{
				CountryExploreLevelRewardData countryExploreLevelRewardData = new CountryExploreLevelRewardData();
				countryExploreLevelRewardData.Initialize(exploreRewardConfig);
				int exploreLevel = exploreRewardConfig.ExploreLevel;
				this.ExploreLevelRewardDataMap[exploreLevel] = countryExploreLevelRewardData;
				this.ExploreLevelRewardDataList.Add(countryExploreLevelRewardData);
				if (exploreRewardConfig.Show)
				{
					this.UnlockFunctionExploreLevelRewardDataList.Add(countryExploreLevelRewardData);
				}
				if (this.MaxExploreLevel < exploreLevel)
				{
					this.MaxExploreLevel = exploreLevel;
				}
			}
		}

		// Token: 0x0603AB4C RID: 240460 RVA: 0x00DFC038 File Offset: 0x00DFA238
		public void AddExploreScoreData(int areaId, int progress, int lastProgress, int score)
		{
			CountryExploreScoreData countryExploreScoreData = new CountryExploreScoreData();
			countryExploreScoreData.Initialize(this.CountryId, areaId, progress, lastProgress, score);
			Dictionary<int, CountryExploreScoreData> dictionary;
			if (!this.CountryExploreScoreDataAreaMap.TryGetValue(areaId, out dictionary))
			{
				dictionary = new Dictionary<int, CountryExploreScoreData>();
				this.CountryExploreScoreDataAreaMap[areaId] = dictionary;
			}
			dictionary[progress] = countryExploreScoreData;
			this.CountryExploreScoreDataList.Add(countryExploreScoreData);
		}

		// Token: 0x0603AB4D RID: 240461 RVA: 0x00DFC094 File Offset: 0x00DFA294
		[NullableContext(2)]
		public CountryExploreScoreData GetExploreScoreData(int areaId, int progress)
		{
			Dictionary<int, CountryExploreScoreData> dictionary;
			if (this.CountryExploreScoreDataAreaMap.TryGetValue(areaId, out dictionary))
			{
				CountryExploreScoreData result;
				dictionary.TryGetValue(progress, out result);
				return result;
			}
			return null;
		}

		// Token: 0x0603AB4E RID: 240462 RVA: 0x00DFC0BE File Offset: 0x00DFA2BE
		public List<CountryExploreScoreData> GetAllExploreScoreData()
		{
			return this.CountryExploreScoreDataList;
		}

		// Token: 0x0603AB4F RID: 240463 RVA: 0x00DFC0C8 File Offset: 0x00DFA2C8
		public List<CountryExploreScoreData> GetVisibleExploreScoreDataList()
		{
			List<CountryExploreScoreData> list = new List<CountryExploreScoreData>();
			foreach (Dictionary<int, CountryExploreScoreData> dictionary in this.CountryExploreScoreDataAreaMap.Values)
			{
				foreach (KeyValuePair<int, CountryExploreScoreData> keyValuePair in dictionary)
				{
					int num;
					CountryExploreScoreData countryExploreScoreData;
					keyValuePair.Deconstruct(out num, out countryExploreScoreData);
					int num2 = num;
					CountryExploreScoreData countryExploreScoreData2 = countryExploreScoreData;
					int lastProgress = countryExploreScoreData2.LastProgress;
					CountryExploreScoreData countryExploreScoreData3;
					dictionary.TryGetValue(lastProgress, out countryExploreScoreData3);
					if (countryExploreScoreData3 == null || countryExploreScoreData3.GetIsReceived())
					{
						if (countryExploreScoreData2.CanReceive())
						{
							list.Add(countryExploreScoreData2);
						}
						else if (countryExploreScoreData2.GetIsReceived())
						{
							list.Add(countryExploreScoreData2);
						}
						else if (num2 > countryExploreScoreData2.GetAreaProgress())
						{
							list.Add(countryExploreScoreData2);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0603AB50 RID: 240464 RVA: 0x00DFC1CC File Offset: 0x00DFA3CC
		public void SetExploreScoreDataReceived(int areaId, int progress, bool bReceived)
		{
			CountryExploreScoreData exploreScoreData = this.GetExploreScoreData(areaId, progress);
			if (exploreScoreData == null)
			{
				return;
			}
			exploreScoreData.SetReceived(bReceived);
		}

		// Token: 0x0603AB51 RID: 240465 RVA: 0x00DFC1E1 File Offset: 0x00DFA3E1
		public int GetCountryId()
		{
			return this.CountryId;
		}

		// Token: 0x0603AB52 RID: 240466 RVA: 0x00DFC1E9 File Offset: 0x00DFA3E9
		public void SetExploreLevel(int exploreLevel)
		{
			this.ExploreLevel = exploreLevel;
		}

		// Token: 0x0603AB53 RID: 240467 RVA: 0x00DFC1F2 File Offset: 0x00DFA3F2
		public int GetExploreLevel()
		{
			return this.ExploreLevel;
		}

		// Token: 0x0603AB54 RID: 240468 RVA: 0x00DFC1FA File Offset: 0x00DFA3FA
		public void SetExploreScore(int exploreScore)
		{
			this.ExploreScore = exploreScore;
		}

		// Token: 0x0603AB55 RID: 240469 RVA: 0x00DFC203 File Offset: 0x00DFA403
		public int GetExploreScore()
		{
			return this.ExploreScore;
		}

		// Token: 0x0603AB56 RID: 240470 RVA: 0x00DFC20C File Offset: 0x00DFA40C
		[NullableContext(2)]
		public CountryExploreLevelRewardData GetExploreLevelRewardData(int exploreLevel)
		{
			CountryExploreLevelRewardData result;
			this.ExploreLevelRewardDataMap.TryGetValue(exploreLevel, out result);
			return result;
		}

		// Token: 0x0603AB57 RID: 240471 RVA: 0x00DFC229 File Offset: 0x00DFA429
		public Dictionary<int, CountryExploreLevelRewardData> GetExploreLevelRewardDataMap()
		{
			return this.ExploreLevelRewardDataMap;
		}

		// Token: 0x0603AB58 RID: 240472 RVA: 0x00DFC231 File Offset: 0x00DFA431
		[NullableContext(2)]
		public CountryExploreLevelRewardData GetCurrentExploreLevelRewardData()
		{
			return this.GetExploreLevelRewardData(this.ExploreLevel);
		}

		// Token: 0x0603AB59 RID: 240473 RVA: 0x00DFC23F File Offset: 0x00DFA43F
		public List<CountryExploreLevelRewardData> GetAllExploreLevelRewardData()
		{
			return this.ExploreLevelRewardDataList;
		}

		// Token: 0x0603AB5A RID: 240474 RVA: 0x00DFC247 File Offset: 0x00DFA447
		public List<CountryExploreLevelRewardData> GetUnlockFunctionExploreLevelRewardDataList()
		{
			return this.UnlockFunctionExploreLevelRewardDataList;
		}

		// Token: 0x0603AB5B RID: 240475 RVA: 0x00DFC24F File Offset: 0x00DFA44F
		public int GetMaxExploreLevel()
		{
			return this.MaxExploreLevel;
		}

		// Token: 0x0603AB5C RID: 240476 RVA: 0x00DFC258 File Offset: 0x00DFA458
		public bool CanLevelUp()
		{
			int num = 0;
			foreach (CountryExploreScoreData countryExploreScoreData in this.CountryExploreScoreDataList)
			{
				if (countryExploreScoreData.CanReceive())
				{
					num += countryExploreScoreData.Score;
				}
			}
			CountryExploreLevelRewardData currentExploreLevelRewardData = this.GetCurrentExploreLevelRewardData();
			return num != 0 && this.ExploreScore < currentExploreLevelRewardData.GetMaxExploreScore() && this.ExploreScore + num >= currentExploreLevelRewardData.GetMaxExploreScore();
		}

		// Token: 0x0401EA46 RID: 125510
		private int CountryId;

		// Token: 0x0401EA47 RID: 125511
		private int ExploreLevel;

		// Token: 0x0401EA48 RID: 125512
		private int ExploreScore;

		// Token: 0x0401EA49 RID: 125513
		private Dictionary<int, CountryExploreLevelRewardData> ExploreLevelRewardDataMap = new Dictionary<int, CountryExploreLevelRewardData>();

		// Token: 0x0401EA4A RID: 125514
		private List<CountryExploreLevelRewardData> ExploreLevelRewardDataList = new List<CountryExploreLevelRewardData>();

		// Token: 0x0401EA4B RID: 125515
		private List<CountryExploreLevelRewardData> UnlockFunctionExploreLevelRewardDataList = new List<CountryExploreLevelRewardData>();

		// Token: 0x0401EA4C RID: 125516
		private Dictionary<int, Dictionary<int, CountryExploreScoreData>> CountryExploreScoreDataAreaMap = new Dictionary<int, Dictionary<int, CountryExploreScoreData>>();

		// Token: 0x0401EA4D RID: 125517
		private List<CountryExploreScoreData> CountryExploreScoreDataList = new List<CountryExploreScoreData>();

		// Token: 0x0401EA4E RID: 125518
		private int MaxExploreLevel;
	}
}
