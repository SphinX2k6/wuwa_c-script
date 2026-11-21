using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A57 RID: 19031
	public class FlagChallengeStrongholdPanel : UiPanelBase
	{
		// Token: 0x0602FA1E RID: 195102 RVA: 0x00D49BE9 File Offset: 0x00D47DE9
		public FlagChallengeStrongholdPanel(int activityId, int strongholdId)
		{
			this.ActivityId = activityId;
			this.StrongholdId = strongholdId;
		}

		// Token: 0x0602FA1F RID: 195103 RVA: 0x00D49C00 File Offset: 0x00D47E00
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUISprite))
			};
		}

		// Token: 0x0602FA20 RID: 195104 RVA: 0x00D49C70 File Offset: 0x00D47E70
		protected override void OnStart()
		{
			FlagChallengeStrongholdData strongholdData = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetStrongholdData(this.StrongholdId);
			FlagStronghold strongholdConfig = strongholdData.StrongholdConfig;
			int monsterLevel = strongholdConfig.MonsterLevel;
			base.GetArtText(1).SetText(monsterLevel.ToString());
			base.SetTextureByPath(strongholdConfig.MonsterIconPath, base.GetTexture(2), null, null);
			base.GetSprite(3).SetUIActive(strongholdData.IsPass);
			switch (FlagChallengeModel.Instance.GetLevelDiffType(this.ActivityId, monsterLevel, null))
			{
			case EFlagChallengeLevelDiffType.Easy:
				this.SetDiffIcon("T_EnemyFlagChallengeLevelGreenBg");
				return;
			case EFlagChallengeLevelDiffType.Normal:
				this.SetDiffIcon("T_EnemyFlagChallengeLevelYellowBg");
				return;
			case EFlagChallengeLevelDiffType.Hard:
				this.SetDiffIcon("T_EnemyFlagChallengeLevelRedBg");
				return;
			default:
				return;
			}
		}

		// Token: 0x0602FA21 RID: 195105 RVA: 0x00D49D40 File Offset: 0x00D47F40
		[NullableContext(1)]
		private void SetDiffIcon(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}

		// Token: 0x04019497 RID: 103575
		private readonly int ActivityId;

		// Token: 0x04019498 RID: 103576
		private readonly int StrongholdId;
	}
}
