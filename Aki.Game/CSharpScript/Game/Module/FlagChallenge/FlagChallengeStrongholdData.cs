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
	// Token: 0x02004A04 RID: 18948
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeStrongholdData
	{
		// Token: 0x17005FA7 RID: 24487
		// (get) Token: 0x0602F842 RID: 194626 RVA: 0x00D40654 File Offset: 0x00D3E854
		public bool IsPass
		{
			get
			{
				return this.IsPassIntl;
			}
		}

		// Token: 0x0602F843 RID: 194627 RVA: 0x00D4065C File Offset: 0x00D3E85C
		public FlagChallengeStrongholdData(int id)
		{
			this.Id = id;
			this.StrongholdConfig = FlagChallengeConfig.Instance.GetStrongholdConfig(id).Value;
		}

		// Token: 0x0602F844 RID: 194628 RVA: 0x00D4068F File Offset: 0x00D3E88F
		public void Refresh(FlagStrongholdInfo strongholdData)
		{
			this.IsPassIntl = strongholdData.IsPass;
		}

		// Token: 0x0602F845 RID: 194629 RVA: 0x00D4069D File Offset: 0x00D3E89D
		public EFlagChallengeStrongholdType GetStrongholdType()
		{
			return (EFlagChallengeStrongholdType)this.StrongholdConfig.Type;
		}

		// Token: 0x0602F846 RID: 194630 RVA: 0x00D406AA File Offset: 0x00D3E8AA
		public bool IsBossStronghold()
		{
			return this.GetStrongholdType() == EFlagChallengeStrongholdType.Boss;
		}

		// Token: 0x0602F847 RID: 194631 RVA: 0x00D406B8 File Offset: 0x00D3E8B8
		public unsafe FVector GetUiRelativePos()
		{
			Span<int> uiRelativePosBytes = this.StrongholdConfig.GetUiRelativePosBytes();
			return new FVector((float)(*uiRelativePosBytes[0]), (float)(*uiRelativePosBytes[1]), 0f);
		}

		// Token: 0x0602F848 RID: 194632 RVA: 0x00D406EF File Offset: 0x00D3E8EF
		public int GetIndex()
		{
			return this.StrongholdConfig.Index;
		}

		// Token: 0x0602F849 RID: 194633 RVA: 0x00D406FC File Offset: 0x00D3E8FC
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

		// Token: 0x0602F84A RID: 194634 RVA: 0x00D407AC File Offset: 0x00D3E9AC
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

		// Token: 0x0602F84B RID: 194635 RVA: 0x00D407FB File Offset: 0x00D3E9FB
		public int GetMarkId()
		{
			return this.StrongholdConfig.MarkId;
		}

		// Token: 0x0602F84C RID: 194636 RVA: 0x00D40808 File Offset: 0x00D3EA08
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

		// Token: 0x0602F84D RID: 194637 RVA: 0x00D4088C File Offset: 0x00D3EA8C
		public bool IsUnlocked()
		{
			return FlagChallengeModel.Instance.IsTeleportUnlock(this.GetMarkId());
		}

		// Token: 0x04019282 RID: 103042
		public readonly int Id;

		// Token: 0x04019283 RID: 103043
		public FlagStronghold StrongholdConfig;

		// Token: 0x04019284 RID: 103044
		private bool IsPassIntl;
	}
}
