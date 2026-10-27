using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FarmGold
{
	// Token: 0x0200664C RID: 26188
	[NullableContext(1)]
	[Nullable(0)]
	public class FarmGoldLevelData
	{
		// Token: 0x06041A0A RID: 268810 RVA: 0x00FEB427 File Offset: 0x00FE9627
		public int GetInstId()
		{
			return this.InstId;
		}

		// Token: 0x06041A0B RID: 268811 RVA: 0x00FEB42F File Offset: 0x00FE962F
		public int GetStartTime()
		{
			return this.StartTime;
		}

		// Token: 0x06041A0C RID: 268812 RVA: 0x00FEB438 File Offset: 0x00FE9638
		public bool GetIsOpen()
		{
			int preLevel = this.GetConfig().PreLevel;
			bool flag = true;
			if (preLevel > 0)
			{
				FarmGoldData farmGoldData = ActivityModel.Instance.GetActivityById(this.ActivityId) as FarmGoldData;
				FarmGoldLevelData farmGoldLevelData = (farmGoldData != null) ? farmGoldData.GetLevelInfoByInstId(preLevel) : null;
				if (farmGoldLevelData != null)
				{
					flag = farmGoldLevelData.GetIfPassLevel();
				}
			}
			return TimeUtil.Instance.GetServerTime() >= (double)this.StartTime && flag;
		}

		// Token: 0x06041A0D RID: 268813 RVA: 0x00FEB4A0 File Offset: 0x00FE96A0
		public bool GetIfPassLevel()
		{
			return this.Point >= this.GetConfig().PassScore;
		}

		// Token: 0x06041A0E RID: 268814 RVA: 0x00FEB4C6 File Offset: 0x00FE96C6
		public int GetPoint()
		{
			return this.Point;
		}

		// Token: 0x06041A0F RID: 268815 RVA: 0x00FEB4CE File Offset: 0x00FE96CE
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x06041A10 RID: 268816 RVA: 0x00FEB4D6 File Offset: 0x00FE96D6
		public bool GetHasGetLevelReward()
		{
			return this.HasGetLevelReward;
		}

		// Token: 0x06041A11 RID: 268817 RVA: 0x00FEB4DE File Offset: 0x00FE96DE
		public FarmGoldActivity GetConfig()
		{
			return FarmGoldConfig.Instance.GetFarmGoldConfigByActivityIdAndInstId(this.ActivityId, this.InstId);
		}

		// Token: 0x06041A12 RID: 268818 RVA: 0x00FEB4F8 File Offset: 0x00FE96F8
		public int GetRecommendLevel()
		{
			return this.GetDifficultConfig().RecommendedLevel;
		}

		// Token: 0x06041A13 RID: 268819 RVA: 0x00FEB513 File Offset: 0x00FE9713
		public bool GetFinishState()
		{
			return this.GetIfPassLevel();
		}

		// Token: 0x06041A14 RID: 268820 RVA: 0x00FEB51B File Offset: 0x00FE971B
		public bool GetRedDotState()
		{
			return this.GetNewOpenState();
		}

		// Token: 0x06041A15 RID: 268821 RVA: 0x00FEB524 File Offset: 0x00FE9724
		public int GetSelectDifficultIndex()
		{
			if (this.CurrentSelectDifficult != null)
			{
				IReadOnlyList<FarmGoldDifficulty> farmGoldDifficultList = FarmGoldConfig.Instance.GetFarmGoldDifficultList(this.ActivityId, this.InstId);
				for (int i = 0; i < farmGoldDifficultList.Count; i++)
				{
					if (farmGoldDifficultList[i].Id == this.CurrentSelectDifficult.Value)
					{
						return i;
					}
				}
				return 0;
			}
			if (this.Index > 0)
			{
				FarmGoldData farmGoldData = ActivityModel.Instance.GetActivityById(this.ActivityId) as FarmGoldData;
				FarmGoldLevelData farmGoldLevelData = (farmGoldData != null) ? farmGoldData.GetLevelDataByIndex(this.Index - 1) : null;
				if (farmGoldLevelData != null)
				{
					return farmGoldLevelData.GetSelectDifficultIndex();
				}
			}
			return 0;
		}

		// Token: 0x06041A16 RID: 268822 RVA: 0x00FEB5C4 File Offset: 0x00FE97C4
		public void SaveDifficultyState()
		{
			ActivityModel.Instance.SaveActivityData(this.ActivityId, this.InstId, 1, 0, this.CurrentSelectDifficult.GetValueOrDefault(1));
		}

		// Token: 0x06041A17 RID: 268823 RVA: 0x00FEB5EC File Offset: 0x00FE97EC
		private void LoadDifficultyState()
		{
			int defualDifficultyId = this.GetDefualDifficultyId();
			int activityCacheData = ActivityModel.Instance.GetActivityCacheData(this.ActivityId, defualDifficultyId, this.InstId, 1, 0);
			if (activityCacheData != 0)
			{
				this.CurrentSelectDifficult = new int?(activityCacheData);
			}
		}

		// Token: 0x06041A18 RID: 268824 RVA: 0x00FEB62C File Offset: 0x00FE982C
		private int GetDefualDifficultyId()
		{
			return FarmGoldConfig.Instance.GetFarmGoldConfigByActivityIdAndInstId(this.ActivityId, this.InstId).GetDifficultyOptionsArray()[0];
		}

		// Token: 0x06041A19 RID: 268825 RVA: 0x00FEB65C File Offset: 0x00FE985C
		public string GetInstanceBg()
		{
			return this.GetInstanceConfig().BannerPath;
		}

		// Token: 0x17009617 RID: 38423
		// (get) Token: 0x06041A1A RID: 268826 RVA: 0x00FEB677 File Offset: 0x00FE9877
		public bool HasSelectDifficult
		{
			get
			{
				return this.CurrentSelectDifficult != null;
			}
		}

		// Token: 0x06041A1B RID: 268827 RVA: 0x00FEB684 File Offset: 0x00FE9884
		public int GetSelectDifficult()
		{
			if (this.CurrentSelectDifficult != null)
			{
				return this.CurrentSelectDifficult.Value;
			}
			if (this.Index > 0)
			{
				FarmGoldData farmGoldData = ActivityModel.Instance.GetActivityById(this.ActivityId) as FarmGoldData;
				FarmGoldLevelData farmGoldLevelData = (farmGoldData != null) ? farmGoldData.GetLevelDataByIndex(this.Index - 1) : null;
				if (farmGoldLevelData != null)
				{
					return farmGoldLevelData.GetSelectDifficult();
				}
			}
			return 1;
		}

		// Token: 0x06041A1C RID: 268828 RVA: 0x00FEB6E8 File Offset: 0x00FE98E8
		public FarmGoldDifficulty GetDifficultConfig()
		{
			return FarmGoldConfig.Instance.GetFarmGoldDifficultById(this.GetSelectDifficult());
		}

		// Token: 0x06041A1D RID: 268829 RVA: 0x00FEB6FA File Offset: 0x00FE98FA
		public void SetDifficult(int difficult)
		{
			this.CurrentSelectDifficult = new int?(difficult);
			this.SaveDifficultyState();
		}

		// Token: 0x06041A1E RID: 268830 RVA: 0x00FEB70E File Offset: 0x00FE990E
		public bool GetNewOpenState()
		{
			return ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, this.InstId, 0, 0) == 0 && this.GetIsOpen();
		}

		// Token: 0x06041A1F RID: 268831 RVA: 0x00FEB734 File Offset: 0x00FE9934
		public string GetUnlockTimeText()
		{
			if (TimeUtil.Instance.GetServerTime() < (double)this.StartTime)
			{
				CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((double)this.StartTime - TimeUtil.Instance.GetServerTime());
				return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("FarmGoldUnLockTime", null), new string[]
				{
					remainTimeDataFormat.CountDownText
				});
			}
			return ConfigMultiTextLang.GetLocalTextNew("FarmGoldUnlockCondition", null);
		}

		// Token: 0x06041A20 RID: 268832 RVA: 0x00FEB79C File Offset: 0x00FE999C
		public void SaveOpenState()
		{
			if (this.GetIsOpen())
			{
				ActivityModel.Instance.SaveActivityData(this.ActivityId, this.InstId, 0, 0, 1);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}
		}

		// Token: 0x06041A21 RID: 268833 RVA: 0x00FEB7D8 File Offset: 0x00FE99D8
		public string GetNameText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetInstanceConfig().MapName, null);
		}

		// Token: 0x06041A22 RID: 268834 RVA: 0x00FEB7FC File Offset: 0x00FE99FC
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetInstanceConfig().DungeonDesc, null);
		}

		// Token: 0x06041A23 RID: 268835 RVA: 0x00FEB81D File Offset: 0x00FE9A1D
		public string GetSubTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew("Activity_103300004_DungeonGrade", null);
		}

		// Token: 0x06041A24 RID: 268836 RVA: 0x00FEB82C File Offset: 0x00FE9A2C
		public string GetSubTitleValueText(bool isSelected)
		{
			string text = this.Point.ToString();
			if (isSelected)
			{
				text = "<color=#8e6826>" + text + "</color>";
			}
			else
			{
				text = "<color=#a18145>" + text + "</color>";
			}
			return text;
		}

		// Token: 0x06041A25 RID: 268837 RVA: 0x00FEB870 File Offset: 0x00FE9A70
		public List<int> GetRecommendElement()
		{
			InstanceDungeon instanceConfig = this.GetInstanceConfig();
			List<int> list = new List<int>();
			for (int i = 0; i < instanceConfig.RecommendElementLength; i++)
			{
				list.Add(instanceConfig.RecommendElement(i));
			}
			return list;
		}

		// Token: 0x06041A26 RID: 268838 RVA: 0x00FEB8AC File Offset: 0x00FE9AAC
		public List<FarmGoldRecommendTag> GetRecommendTagConfigList()
		{
			FarmGoldActivity config = this.GetConfig();
			List<FarmGoldRecommendTag> list = new List<FarmGoldRecommendTag>();
			for (int i = 0; i < config.RecommendTagIdsLength; i++)
			{
				list.Add(ConfigFarmGoldRecommendTagById.GetConfig(config.RecommendTagIds(i), true).Value);
			}
			return list;
		}

		// Token: 0x06041A27 RID: 268839 RVA: 0x00FEB8F8 File Offset: 0x00FE9AF8
		public InstanceDungeon GetInstanceConfig()
		{
			return ConfigInstanceDungeonById.GetConfig(this.InstId, true).Value;
		}

		// Token: 0x06041A28 RID: 268840 RVA: 0x00FEB91C File Offset: 0x00FE9B1C
		public int GetInstanceEntranceId()
		{
			return this.GetConfig().EntranceId;
		}

		// Token: 0x06041A29 RID: 268841 RVA: 0x00FEB937 File Offset: 0x00FE9B37
		public void FinishLevelReward()
		{
			this.HasGetLevelReward = true;
		}

		// Token: 0x06041A2A RID: 268842 RVA: 0x00FEB940 File Offset: 0x00FE9B40
		public string GetMonsterTips()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetInstanceConfig().MonsterTips, null);
		}

		// Token: 0x06041A2B RID: 268843 RVA: 0x00FEB964 File Offset: 0x00FE9B64
		public bool GetMonsterPreviewState()
		{
			return this.GetInstanceConfig().MonsterPreviewLength > 0;
		}

		// Token: 0x06041A2C RID: 268844 RVA: 0x00FEB984 File Offset: 0x00FE9B84
		public void Phrase(int activityId, FarmGoldLevelPlayInfo data, int index)
		{
			this.Index = index;
			this.ActivityId = activityId;
			this.InstId = data.InstId;
			this.StartTime = data.StartTime;
			this.IsOpen = data.IsOpen;
			this.Point = data.Point;
			this.HasGetLevelReward = data.LevelRewardGet;
			this.LoadDifficultyState();
		}

		// Token: 0x0402227D RID: 139901
		private int ActivityId;

		// Token: 0x0402227E RID: 139902
		private int InstId;

		// Token: 0x0402227F RID: 139903
		private int StartTime;

		// Token: 0x04022280 RID: 139904
		protected bool IsOpen;

		// Token: 0x04022281 RID: 139905
		private int Point;

		// Token: 0x04022282 RID: 139906
		private bool HasGetLevelReward;

		// Token: 0x04022283 RID: 139907
		private int? CurrentSelectDifficult;

		// Token: 0x04022284 RID: 139908
		private int Index;
	}
}
