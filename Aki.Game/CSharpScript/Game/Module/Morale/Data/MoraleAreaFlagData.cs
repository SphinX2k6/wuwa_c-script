using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay;

namespace CSharpScript.Game.Module.Morale.Data
{
	// Token: 0x020053C0 RID: 21440
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaFlagData
	{
		// Token: 0x170083B5 RID: 33717
		// (get) Token: 0x06036C74 RID: 224372 RVA: 0x00CF6FC9 File Offset: 0x00CF51C9
		public bool IsGetBox
		{
			get
			{
				return this.BoxTotalCount > 0 && this.BoxReceivedCount >= this.BoxTotalCount;
			}
		}

		// Token: 0x06036C75 RID: 224373 RVA: 0x00CF6FE7 File Offset: 0x00CF51E7
		public static MoraleAreaFlagData Create(FlagArea config)
		{
			MoraleAreaFlagData moraleAreaFlagData = new MoraleAreaFlagData(config);
			moraleAreaFlagData.Init();
			return moraleAreaFlagData;
		}

		// Token: 0x06036C76 RID: 224374 RVA: 0x00CF6FF8 File Offset: 0x00CF51F8
		private MoraleAreaFlagData(FlagArea config)
		{
			this.Id = config.Id;
			this.AreaId = config.FlagAreaId;
			this.Config = config;
			this.TypeConfig = MoraleConfig.Instance.GetFlagTypeConfig(config.FlagType);
			this.HasBox = (config.BoxRewardId > 0);
			this.BoxTotalCount = config.TreasureBoxEntitysLength;
		}

		// Token: 0x06036C77 RID: 224375 RVA: 0x00CF7076 File Offset: 0x00CF5276
		private void Init()
		{
			this.InitPlotData();
		}

		// Token: 0x06036C78 RID: 224376 RVA: 0x00CF7080 File Offset: 0x00CF5280
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

		// Token: 0x06036C79 RID: 224377 RVA: 0x00CF7113 File Offset: 0x00CF5313
		public void SetActiveState(bool isActive)
		{
			this.IsActive = isActive;
		}

		// Token: 0x06036C7A RID: 224378 RVA: 0x00CF711C File Offset: 0x00CF531C
		public void SetBoxReceivedCount(int count)
		{
			this.BoxReceivedCount = count;
		}

		// Token: 0x06036C7B RID: 224379 RVA: 0x00CF7125 File Offset: 0x00CF5325
		public bool HasBoxCanGet()
		{
			return this.HasBox && this.IsActive && !this.IsGetBox && this.BoxTotalCount > 0;
		}

		// Token: 0x06036C7C RID: 224380 RVA: 0x00CF714E File Offset: 0x00CF534E
		public void SetSelectState(bool isSelect)
		{
			this.IsSelect = isSelect;
		}

		// Token: 0x06036C7D RID: 224381 RVA: 0x00CF7158 File Offset: 0x00CF5358
		public bool IsFlagType(EMoraleFlagType flagType)
		{
			return this.TypeConfig != null && this.TypeConfig.Value.TypeId == (int)flagType;
		}

		// Token: 0x06036C7E RID: 224382 RVA: 0x00CF718A File Offset: 0x00CF538A
		public bool IsHighDifficultyChallenge()
		{
			return this.IsFlagType(EMoraleFlagType.HighDifficulty);
		}

		// Token: 0x06036C7F RID: 224383 RVA: 0x00CF7194 File Offset: 0x00CF5394
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

		// Token: 0x06036C80 RID: 224384 RVA: 0x00CF7230 File Offset: 0x00CF5430
		public bool IsLowMoraleLv()
		{
			if (MoraleModel.Instance.IsRichTargetMoraleLv(this.Config.MaxMonsterLv))
			{
				return false;
			}
			int moraleMaxLevel = MoraleBattleModel.Instance.GetMoraleMaxLevel();
			return MoraleModel.Instance.GetSumMoraleLv() < moraleMaxLevel;
		}

		// Token: 0x06036C81 RID: 224385 RVA: 0x00CF726E File Offset: 0x00CF546E
		public void SetNewUnlockState(bool isNewUnlock)
		{
			this.IsNewUnlock = isNewUnlock;
		}

		// Token: 0x0401CE8B RID: 118411
		public int Id;

		// Token: 0x0401CE8C RID: 118412
		public int AreaId;

		// Token: 0x0401CE8D RID: 118413
		public List<MoraleAreaPlotData> AreaPlotDataList = new List<MoraleAreaPlotData>();

		// Token: 0x0401CE8E RID: 118414
		public Dictionary<int, MoraleAreaPlotData> AreaPlotDataMap = new Dictionary<int, MoraleAreaPlotData>();

		// Token: 0x0401CE8F RID: 118415
		public bool IsActive;

		// Token: 0x0401CE90 RID: 118416
		public bool HasBox;

		// Token: 0x0401CE91 RID: 118417
		public int BoxReceivedCount;

		// Token: 0x0401CE92 RID: 118418
		public int BoxTotalCount;

		// Token: 0x0401CE93 RID: 118419
		public FlagArea Config;

		// Token: 0x0401CE94 RID: 118420
		public MoraleFlagType? TypeConfig;

		// Token: 0x0401CE95 RID: 118421
		public bool IsSelect;

		// Token: 0x0401CE96 RID: 118422
		public bool IsNewUnlock;
	}
}
