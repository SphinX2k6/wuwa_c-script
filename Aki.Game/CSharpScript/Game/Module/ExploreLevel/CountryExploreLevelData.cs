using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ExploreLevel
{
	// Token: 0x02004A67 RID: 19047
	[NullableContext(1)]
	[Nullable(0)]
	public class CountryExploreLevelData
	{
		// Token: 0x0602FA94 RID: 195220 RVA: 0x00D4C528 File Offset: 0x00D4A728
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

		// Token: 0x0602FA95 RID: 195221 RVA: 0x00D4C5CC File Offset: 0x00D4A7CC
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

		// Token: 0x0602FA96 RID: 195222 RVA: 0x00D4C628 File Offset: 0x00D4A828
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

		// Token: 0x0602FA97 RID: 195223 RVA: 0x00D4C652 File Offset: 0x00D4A852
		public List<CountryExploreScoreData> GetAllExploreScoreData()
		{
			return this.CountryExploreScoreDataList;
		}

		// Token: 0x0602FA98 RID: 195224 RVA: 0x00D4C65C File Offset: 0x00D4A85C
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

		// Token: 0x0602FA99 RID: 195225 RVA: 0x00D4C760 File Offset: 0x00D4A960
		public void SetExploreScoreDataReceived(int areaId, int progress, bool bReceived)
		{
			CountryExploreScoreData exploreScoreData = this.GetExploreScoreData(areaId, progress);
			if (exploreScoreData == null)
			{
				return;
			}
			exploreScoreData.SetReceived(bReceived);
		}

		// Token: 0x0602FA9A RID: 195226 RVA: 0x00D4C775 File Offset: 0x00D4A975
		public int GetCountryId()
		{
			return this.CountryId;
		}

		// Token: 0x0602FA9B RID: 195227 RVA: 0x00D4C77D File Offset: 0x00D4A97D
		public void SetExploreLevel(int exploreLevel)
		{
			this.ExploreLevel = exploreLevel;
		}

		// Token: 0x0602FA9C RID: 195228 RVA: 0x00D4C786 File Offset: 0x00D4A986
		public int GetExploreLevel()
		{
			return this.ExploreLevel;
		}

		// Token: 0x0602FA9D RID: 195229 RVA: 0x00D4C78E File Offset: 0x00D4A98E
		public void SetExploreScore(int exploreScore)
		{
			this.ExploreScore = exploreScore;
		}

		// Token: 0x0602FA9E RID: 195230 RVA: 0x00D4C797 File Offset: 0x00D4A997
		public int GetExploreScore()
		{
			return this.ExploreScore;
		}

		// Token: 0x0602FA9F RID: 195231 RVA: 0x00D4C7A0 File Offset: 0x00D4A9A0
		[NullableContext(2)]
		public CountryExploreLevelRewardData GetExploreLevelRewardData(int exploreLevel)
		{
			CountryExploreLevelRewardData result;
			this.ExploreLevelRewardDataMap.TryGetValue(exploreLevel, out result);
			return result;
		}

		// Token: 0x0602FAA0 RID: 195232 RVA: 0x00D4C7BD File Offset: 0x00D4A9BD
		public Dictionary<int, CountryExploreLevelRewardData> GetExploreLevelRewardDataMap()
		{
			return this.ExploreLevelRewardDataMap;
		}

		// Token: 0x0602FAA1 RID: 195233 RVA: 0x00D4C7C5 File Offset: 0x00D4A9C5
		[NullableContext(2)]
		public CountryExploreLevelRewardData GetCurrentExploreLevelRewardData()
		{
			return this.GetExploreLevelRewardData(this.ExploreLevel);
		}

		// Token: 0x0602FAA2 RID: 195234 RVA: 0x00D4C7D3 File Offset: 0x00D4A9D3
		public List<CountryExploreLevelRewardData> GetAllExploreLevelRewardData()
		{
			return this.ExploreLevelRewardDataList;
		}

		// Token: 0x0602FAA3 RID: 195235 RVA: 0x00D4C7DB File Offset: 0x00D4A9DB
		public List<CountryExploreLevelRewardData> GetUnlockFunctionExploreLevelRewardDataList()
		{
			return this.UnlockFunctionExploreLevelRewardDataList;
		}

		// Token: 0x0602FAA4 RID: 195236 RVA: 0x00D4C7E3 File Offset: 0x00D4A9E3
		public int GetMaxExploreLevel()
		{
			return this.MaxExploreLevel;
		}

		// Token: 0x0602FAA5 RID: 195237 RVA: 0x00D4C7EC File Offset: 0x00D4A9EC
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

		// Token: 0x040194ED RID: 103661
		private int CountryId;

		// Token: 0x040194EE RID: 103662
		private int ExploreLevel;

		// Token: 0x040194EF RID: 103663
		private int ExploreScore;

		// Token: 0x040194F0 RID: 103664
		private Dictionary<int, CountryExploreLevelRewardData> ExploreLevelRewardDataMap = new Dictionary<int, CountryExploreLevelRewardData>();

		// Token: 0x040194F1 RID: 103665
		private List<CountryExploreLevelRewardData> ExploreLevelRewardDataList = new List<CountryExploreLevelRewardData>();

		// Token: 0x040194F2 RID: 103666
		private List<CountryExploreLevelRewardData> UnlockFunctionExploreLevelRewardDataList = new List<CountryExploreLevelRewardData>();

		// Token: 0x040194F3 RID: 103667
		private Dictionary<int, Dictionary<int, CountryExploreScoreData>> CountryExploreScoreDataAreaMap = new Dictionary<int, Dictionary<int, CountryExploreScoreData>>();

		// Token: 0x040194F4 RID: 103668
		private List<CountryExploreScoreData> CountryExploreScoreDataList = new List<CountryExploreScoreData>();

		// Token: 0x040194F5 RID: 103669
		private int MaxExploreLevel;
	}
}
