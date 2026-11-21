using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FarmGold
{
	// Token: 0x020055CA RID: 21962
	[NullableContext(1)]
	[Nullable(0)]
	public class FarmGoldLevelData
	{
		// Token: 0x060366CF RID: 222927 RVA: 0x00F324DF File Offset: 0x00F306DF
		public int GetInstId()
		{
			return this.InstId;
		}

		// Token: 0x060366D0 RID: 222928 RVA: 0x00F324E7 File Offset: 0x00F306E7
		public int GetStartTime()
		{
			return this.StartTime;
		}

		// Token: 0x060366D1 RID: 222929 RVA: 0x00F324F0 File Offset: 0x00F306F0
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

		// Token: 0x060366D2 RID: 222930 RVA: 0x00F32558 File Offset: 0x00F30758
		public bool GetIfPassLevel()
		{
			return this.Point >= this.GetConfig().PassScore;
		}

		// Token: 0x060366D3 RID: 222931 RVA: 0x00F3257E File Offset: 0x00F3077E
		public int GetPoint()
		{
			return this.Point;
		}

		// Token: 0x060366D4 RID: 222932 RVA: 0x00F32586 File Offset: 0x00F30786
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x060366D5 RID: 222933 RVA: 0x00F3258E File Offset: 0x00F3078E
		public bool GetHasGetLevelReward()
		{
			return this.HasGetLevelReward;
		}

		// Token: 0x060366D6 RID: 222934 RVA: 0x00F32596 File Offset: 0x00F30796
		public FarmGoldActivity GetConfig()
		{
			return FarmGoldConfig.Instance.GetFarmGoldConfigByActivityIdAndInstId(this.ActivityId, this.InstId);
		}

		// Token: 0x060366D7 RID: 222935 RVA: 0x00F325B0 File Offset: 0x00F307B0
		public int GetRecommendLevel()
		{
			return this.GetDifficultConfig().RecommendedLevel;
		}

		// Token: 0x060366D8 RID: 222936 RVA: 0x00F325CB File Offset: 0x00F307CB
		public bool GetFinishState()
		{
			return this.GetIfPassLevel();
		}

		// Token: 0x060366D9 RID: 222937 RVA: 0x00F325D3 File Offset: 0x00F307D3
		public bool GetRedDotState()
		{
			return this.GetNewOpenState();
		}

		// Token: 0x060366DA RID: 222938 RVA: 0x00F325DC File Offset: 0x00F307DC
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

		// Token: 0x060366DB RID: 222939 RVA: 0x00F3267C File Offset: 0x00F3087C
		public void SaveDifficultyState()
		{
			ActivityModel.Instance.SaveActivityData(this.ActivityId, this.InstId, 1, 0, this.CurrentSelectDifficult.GetValueOrDefault(1));
		}

		// Token: 0x060366DC RID: 222940 RVA: 0x00F326A4 File Offset: 0x00F308A4
		private void LoadDifficultyState()
		{
			int defualDifficultyId = this.GetDefualDifficultyId();
			int activityCacheData = ActivityModel.Instance.GetActivityCacheData(this.ActivityId, defualDifficultyId, this.InstId, 1, 0);
			if (activityCacheData != 0)
			{
				this.CurrentSelectDifficult = new int?(activityCacheData);
			}
		}

		// Token: 0x060366DD RID: 222941 RVA: 0x00F326E4 File Offset: 0x00F308E4
		private int GetDefualDifficultyId()
		{
			return FarmGoldConfig.Instance.GetFarmGoldConfigByActivityIdAndInstId(this.ActivityId, this.InstId).GetDifficultyOptionsArray()[0];
		}

		// Token: 0x060366DE RID: 222942 RVA: 0x00F32714 File Offset: 0x00F30914
		public string GetInstanceBg()
		{
			return this.GetInstanceConfig().BannerPath;
		}

		// Token: 0x17006979 RID: 27001
		// (get) Token: 0x060366DF RID: 222943 RVA: 0x00F3272F File Offset: 0x00F3092F
		public bool HasSelectDifficult
		{
			get
			{
				return this.CurrentSelectDifficult != null;
			}
		}

		// Token: 0x060366E0 RID: 222944 RVA: 0x00F3273C File Offset: 0x00F3093C
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

		// Token: 0x060366E1 RID: 222945 RVA: 0x00F327A0 File Offset: 0x00F309A0
		public FarmGoldDifficulty GetDifficultConfig()
		{
			return FarmGoldConfig.Instance.GetFarmGoldDifficultById(this.GetSelectDifficult());
		}

		// Token: 0x060366E2 RID: 222946 RVA: 0x00F327B2 File Offset: 0x00F309B2
		public void SetDifficult(int difficult)
		{
			this.CurrentSelectDifficult = new int?(difficult);
			this.SaveDifficultyState();
		}

		// Token: 0x060366E3 RID: 222947 RVA: 0x00F327C6 File Offset: 0x00F309C6
		public bool GetNewOpenState()
		{
			return ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, this.InstId, 0, 0) == 0 && this.GetIsOpen();
		}

		// Token: 0x060366E4 RID: 222948 RVA: 0x00F327EC File Offset: 0x00F309EC
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

		// Token: 0x060366E5 RID: 222949 RVA: 0x00F32854 File Offset: 0x00F30A54
		public void SaveOpenState()
		{
			if (this.GetIsOpen())
			{
				ActivityModel.Instance.SaveActivityData(this.ActivityId, this.InstId, 0, 0, 1);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}
		}

		// Token: 0x060366E6 RID: 222950 RVA: 0x00F32890 File Offset: 0x00F30A90
		public string GetNameText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetInstanceConfig().MapName, null);
		}

		// Token: 0x060366E7 RID: 222951 RVA: 0x00F328B4 File Offset: 0x00F30AB4
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetInstanceConfig().DungeonDesc, null);
		}

		// Token: 0x060366E8 RID: 222952 RVA: 0x00F328D5 File Offset: 0x00F30AD5
		public string GetSubTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew("Activity_103300004_DungeonGrade", null);
		}

		// Token: 0x060366E9 RID: 222953 RVA: 0x00F328E4 File Offset: 0x00F30AE4
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

		// Token: 0x060366EA RID: 222954 RVA: 0x00F32928 File Offset: 0x00F30B28
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

		// Token: 0x060366EB RID: 222955 RVA: 0x00F32964 File Offset: 0x00F30B64
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

		// Token: 0x060366EC RID: 222956 RVA: 0x00F329B0 File Offset: 0x00F30BB0
		public InstanceDungeon GetInstanceConfig()
		{
			return ConfigInstanceDungeonById.GetConfig(this.InstId, true).Value;
		}

		// Token: 0x060366ED RID: 222957 RVA: 0x00F329D4 File Offset: 0x00F30BD4
		public int GetInstanceEntranceId()
		{
			return this.GetConfig().EntranceId;
		}

		// Token: 0x060366EE RID: 222958 RVA: 0x00F329EF File Offset: 0x00F30BEF
		public void FinishLevelReward()
		{
			this.HasGetLevelReward = true;
		}

		// Token: 0x060366EF RID: 222959 RVA: 0x00F329F8 File Offset: 0x00F30BF8
		public string GetMonsterTips()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetInstanceConfig().MonsterTips, null);
		}

		// Token: 0x060366F0 RID: 222960 RVA: 0x00F32A1C File Offset: 0x00F30C1C
		public bool GetMonsterPreviewState()
		{
			return this.GetInstanceConfig().MonsterPreviewLength > 0;
		}

		// Token: 0x060366F1 RID: 222961 RVA: 0x00F32A3C File Offset: 0x00F30C3C
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

		// Token: 0x0401CBAE RID: 117678
		private int ActivityId;

		// Token: 0x0401CBAF RID: 117679
		private int InstId;

		// Token: 0x0401CBB0 RID: 117680
		private int StartTime;

		// Token: 0x0401CBB1 RID: 117681
		protected bool IsOpen;

		// Token: 0x0401CBB2 RID: 117682
		private int Point;

		// Token: 0x0401CBB3 RID: 117683
		private bool HasGetLevelReward;

		// Token: 0x0401CBB4 RID: 117684
		private int? CurrentSelectDifficult;

		// Token: 0x0401CBB5 RID: 117685
		private int Index;
	}
}
