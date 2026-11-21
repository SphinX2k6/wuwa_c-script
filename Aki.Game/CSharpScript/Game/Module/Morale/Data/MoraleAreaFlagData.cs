using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay;

namespace CSharpScript.Game.Module.Morale.Data
{
	// Token: 0x020043A3 RID: 17315
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaFlagData
	{
		// Token: 0x17005781 RID: 22401
		// (get) Token: 0x0602BBBA RID: 179130 RVA: 0x00C46071 File Offset: 0x00C44271
		public bool IsGetBox
		{
			get
			{
				return this.BoxTotalCount > 0 && this.BoxReceivedCount >= this.BoxTotalCount;
			}
		}

		// Token: 0x0602BBBB RID: 179131 RVA: 0x00C4608F File Offset: 0x00C4428F
		public static MoraleAreaFlagData Create(FlagArea config)
		{
			MoraleAreaFlagData moraleAreaFlagData = new MoraleAreaFlagData(config);
			moraleAreaFlagData.Init();
			return moraleAreaFlagData;
		}

		// Token: 0x0602BBBC RID: 179132 RVA: 0x00C460A0 File Offset: 0x00C442A0
		private MoraleAreaFlagData(FlagArea config)
		{
			this.Id = config.Id;
			this.AreaId = config.FlagAreaId;
			this.Config = config;
			this.TypeConfig = MoraleConfig.Instance.GetFlagTypeConfig(config.FlagType);
			this.HasBox = (config.BoxRewardId > 0);
			this.BoxTotalCount = config.TreasureBoxEntitysLength;
		}

		// Token: 0x0602BBBD RID: 179133 RVA: 0x00C4611E File Offset: 0x00C4431E
		private void Init()
		{
			this.InitPlotData();
		}

		// Token: 0x0602BBBE RID: 179134 RVA: 0x00C46128 File Offset: 0x00C44328
		private void InitPlotData()
		{
			if (this.TypeConfig == null || this.TypeConfig.Value.ShowUiMap == 0)
			{
				return;
			}
			int[] flagPlotListArray = this.Config.GetFlagPlotListArray();
			if (flagPlotListArray == null)
			{
				return;
			}
			foreach (int num in flagPlotListArray)
			{
				MoraleAreaPlotData moraleAreaPlotData = new MoraleAreaPlotData
				{
					Id = num,
					FlagId = this.Id,
					AreaId = this.AreaId
				};
				this.AreaPlotDataMap[num] = moraleAreaPlotData;
				this.AreaPlotDataList.Add(moraleAreaPlotData);
			}
		}

		// Token: 0x0602BBBF RID: 179135 RVA: 0x00C461BB File Offset: 0x00C443BB
		public void SetActiveState(bool isActive)
		{
			this.IsActive = isActive;
		}

		// Token: 0x0602BBC0 RID: 179136 RVA: 0x00C461C4 File Offset: 0x00C443C4
		public void SetBoxReceivedCount(int count)
		{
			this.BoxReceivedCount = count;
		}

		// Token: 0x0602BBC1 RID: 179137 RVA: 0x00C461CD File Offset: 0x00C443CD
		public bool HasBoxCanGet()
		{
			return this.HasBox && this.IsActive && !this.IsGetBox && this.BoxTotalCount > 0;
		}

		// Token: 0x0602BBC2 RID: 179138 RVA: 0x00C461F6 File Offset: 0x00C443F6
		public void SetSelectState(bool isSelect)
		{
			this.IsSelect = isSelect;
		}

		// Token: 0x0602BBC3 RID: 179139 RVA: 0x00C46200 File Offset: 0x00C44400
		public bool IsFlagType(EMoraleFlagType flagType)
		{
			return this.TypeConfig != null && this.TypeConfig.Value.TypeId == (int)flagType;
		}

		// Token: 0x0602BBC4 RID: 179140 RVA: 0x00C46232 File Offset: 0x00C44432
		public bool IsHighDifficultyChallenge()
		{
			return this.IsFlagType(EMoraleFlagType.HighDifficulty);
		}

		// Token: 0x0602BBC5 RID: 179141 RVA: 0x00C4623C File Offset: 0x00C4443C
		public IMapMoraleLvItemData GetMapMoraleLvItemData()
		{
			int maxMonsterLv = this.Config.MaxMonsterLv;
			EMoraleLevelDiffType moraleLevelDiffType = MoraleBattleModel.Instance.GetMoraleLevelDiffType(maxMonsterLv, null);
			string lvColor = "";
			string bgColor = "";
			switch (moraleLevelDiffType)
			{
			case EMoraleLevelDiffType.Easy:
				lvColor = "#494A4AFF";
				bgColor = "#A1A0A0FF";
				break;
			case EMoraleLevelDiffType.Normal:
				lvColor = "#5C4421FF";
				bgColor = "#B09A58FF";
				break;
			case EMoraleLevelDiffType.Hard:
				lvColor = "#6A3838FF";
				bgColor = "#C38484FF";
				break;
			}
			return new MapMoraleLvItemData
			{
				TitleId = "Morale_title_13",
				Lv = maxMonsterLv,
				LvColor = lvColor,
				BgColor = bgColor
			};
		}

		// Token: 0x0602BBC6 RID: 179142 RVA: 0x00C462D8 File Offset: 0x00C444D8
		public bool IsLowMoraleLv()
		{
			if (MoraleModel.Instance.IsRichTargetMoraleLv(this.Config.MaxMonsterLv))
			{
				return false;
			}
			int moraleMaxLevel = MoraleBattleModel.Instance.GetMoraleMaxLevel();
			return MoraleModel.Instance.GetSumMoraleLv() < moraleMaxLevel;
		}

		// Token: 0x0602BBC7 RID: 179143 RVA: 0x00C46316 File Offset: 0x00C44516
		public void SetNewUnlockState(bool isNewUnlock)
		{
			this.IsNewUnlock = isNewUnlock;
		}

		// Token: 0x04017923 RID: 96547
		public int Id;

		// Token: 0x04017924 RID: 96548
		public int AreaId;

		// Token: 0x04017925 RID: 96549
		public List<MoraleAreaPlotData> AreaPlotDataList = new List<MoraleAreaPlotData>();

		// Token: 0x04017926 RID: 96550
		public Dictionary<int, MoraleAreaPlotData> AreaPlotDataMap = new Dictionary<int, MoraleAreaPlotData>();

		// Token: 0x04017927 RID: 96551
		public bool IsActive;

		// Token: 0x04017928 RID: 96552
		public bool HasBox;

		// Token: 0x04017929 RID: 96553
		public int BoxReceivedCount;

		// Token: 0x0401792A RID: 96554
		public int BoxTotalCount;

		// Token: 0x0401792B RID: 96555
		public FlagArea Config;

		// Token: 0x0401792C RID: 96556
		public MoraleFlagType? TypeConfig;

		// Token: 0x0401792D RID: 96557
		public bool IsSelect;

		// Token: 0x0401792E RID: 96558
		public bool IsNewUnlock;
	}
}
