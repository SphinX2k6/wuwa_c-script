using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A28 RID: 23080
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeStrongholdData
	{
		// Token: 0x17008BD9 RID: 35801
		// (get) Token: 0x0603A8F9 RID: 239865 RVA: 0x00DF00D0 File Offset: 0x00DEE2D0
		public bool IsPass
		{
			get
			{
				return this.IsPassIntl;
			}
		}

		// Token: 0x0603A8FA RID: 239866 RVA: 0x00DF00D8 File Offset: 0x00DEE2D8
		public FlagChallengeStrongholdData(int id)
		{
			this.Id = id;
			this.StrongholdConfig = FlagChallengeConfig.Instance.GetStrongholdConfig(id).Value;
		}

		// Token: 0x0603A8FB RID: 239867 RVA: 0x00DF010B File Offset: 0x00DEE30B
		public void Refresh(FlagStrongholdInfo strongholdData)
		{
			this.IsPassIntl = strongholdData.IsPass;
		}

		// Token: 0x0603A8FC RID: 239868 RVA: 0x00DF0119 File Offset: 0x00DEE319
		public EFlagChallengeStrongholdType GetStrongholdType()
		{
			return (EFlagChallengeStrongholdType)this.StrongholdConfig.Type;
		}

		// Token: 0x0603A8FD RID: 239869 RVA: 0x00DF0126 File Offset: 0x00DEE326
		public bool IsBossStronghold()
		{
			return this.GetStrongholdType() == EFlagChallengeStrongholdType.Boss;
		}

		// Token: 0x0603A8FE RID: 239870 RVA: 0x00DF0134 File Offset: 0x00DEE334
		public unsafe FVector GetUiRelativePos()
		{
			Span<int> uiRelativePosBytes = this.StrongholdConfig.GetUiRelativePosBytes();
			return new FVector((float)(*uiRelativePosBytes[0]), (float)(*uiRelativePosBytes[1]), 0f);
		}

		// Token: 0x0603A8FF RID: 239871 RVA: 0x00DF016B File Offset: 0x00DEE36B
		public int GetIndex()
		{
			return this.StrongholdConfig.Index;
		}

		// Token: 0x0603A900 RID: 239872 RVA: 0x00DF0178 File Offset: 0x00DEE378
		public IMapMoraleLvItemData GetMapFlagChallengeLvItemData()
		{
			int monsterLevel = this.StrongholdConfig.MonsterLevel;
			int strongholdActivityId = FlagChallengeUtils.GetStrongholdActivityId(this.Id);
			EFlagChallengeLevelDiffType levelDiffType = FlagChallengeModel.Instance.GetLevelDiffType(strongholdActivityId, monsterLevel, null);
			string lvColor = "";
			string bgColor = "";
			switch (levelDiffType)
			{
			case EFlagChallengeLevelDiffType.Easy:
				lvColor = "#494A4AFF";
				bgColor = "#A1A0A0FF";
				break;
			case EFlagChallengeLevelDiffType.Normal:
				lvColor = "#5C4421FF";
				bgColor = "#B09A58FF";
				break;
			case EFlagChallengeLevelDiffType.Hard:
				lvColor = "#6A3838FF";
				bgColor = "#C38484FF";
				break;
			}
			return new MapMoraleLvItemData
			{
				TitleId = "Morale_32_MapIcon_EnemyLv_Title",
				Lv = monsterLevel,
				LvColor = lvColor,
				BgColor = bgColor
			};
		}

		// Token: 0x0603A901 RID: 239873 RVA: 0x00DF0228 File Offset: 0x00DEE428
		public bool IsLowLevel()
		{
			if (this.IsPassIntl)
			{
				return false;
			}
			FlagChallengeModel instance = FlagChallengeModel.Instance;
			int strongholdActivityId = FlagChallengeUtils.GetStrongholdActivityId(this.Id);
			return !instance.IsReachTargetLevel(strongholdActivityId, this.StrongholdConfig.RecommendLevel) && instance.GetTotalLevel(strongholdActivityId) < instance.GetMaxLevel(strongholdActivityId);
		}

		// Token: 0x0603A902 RID: 239874 RVA: 0x00DF0277 File Offset: 0x00DEE477
		public int GetMarkId()
		{
			return this.StrongholdConfig.MarkId;
		}

		// Token: 0x0603A903 RID: 239875 RVA: 0x00DF0284 File Offset: 0x00DEE484
		public bool CanTeleport()
		{
			int markId = this.GetMarkId();
			if (markId == 0)
			{
				return false;
			}
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(configMark.Value.EntityConfigId);
			if (entityByPbDataId == null)
			{
				return false;
			}
			WorldEntity entity = entityByPbDataId.Entity;
			bool flag;
			if (entity == null)
			{
				flag = true;
			}
			else
			{
				SceneItemStateComponent component = entity.GetComponent<SceneItemStateComponent>();
				flag = (((component != null) ? new SceneItemStateComponent.ESceneItemState?(component.State) : null).GetValueOrDefault() != SceneItemStateComponent.ESceneItemState.Active);
			}
			return !flag;
		}

		// Token: 0x0603A904 RID: 239876 RVA: 0x00DF0308 File Offset: 0x00DEE508
		public bool IsUnlocked()
		{
			return FlagChallengeModel.Instance.IsTeleportUnlock(this.GetMarkId());
		}

		// Token: 0x0401E7DB RID: 124891
		public readonly int Id;

		// Token: 0x0401E7DC RID: 124892
		public FlagStronghold StrongholdConfig;

		// Token: 0x0401E7DD RID: 124893
		private bool IsPassIntl;
	}
}
