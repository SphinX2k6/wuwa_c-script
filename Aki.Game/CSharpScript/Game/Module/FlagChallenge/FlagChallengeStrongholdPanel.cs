using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A7B RID: 23163
	public class FlagChallengeStrongholdPanel : UiPanelBase
	{
		// Token: 0x0603AAD5 RID: 240341 RVA: 0x00DF9655 File Offset: 0x00DF7855
		public FlagChallengeStrongholdPanel(int activityId, int strongholdId)
		{
			this.ActivityId = activityId;
			this.StrongholdId = strongholdId;
		}

		// Token: 0x0603AAD6 RID: 240342 RVA: 0x00DF966C File Offset: 0x00DF786C
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

		// Token: 0x0603AAD7 RID: 240343 RVA: 0x00DF96DC File Offset: 0x00DF78DC
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

		// Token: 0x0603AAD8 RID: 240344 RVA: 0x00DF97AC File Offset: 0x00DF79AC
		[NullableContext(1)]
		private void SetDiffIcon(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}

		// Token: 0x0401E9F0 RID: 125424
		private readonly int ActivityId;

		// Token: 0x0401E9F1 RID: 125425
		private readonly int StrongholdId;
	}
}
