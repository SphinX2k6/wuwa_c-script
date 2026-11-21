using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A2C RID: 18988
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaStrongholdPanel : UiPanelBase
	{
		// Token: 0x0602F938 RID: 194872 RVA: 0x00D44B66 File Offset: 0x00D42D66
		public FlagChallengeAreaStrongholdPanel(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0602F939 RID: 194873 RVA: 0x00D44B78 File Offset: 0x00D42D78
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
		}

		// Token: 0x0602F93A RID: 194874 RVA: 0x00D44C58 File Offset: 0x00D42E58
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeAreaStrongholdPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeAreaStrongholdPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F93B RID: 194875 RVA: 0x00D44C9C File Offset: 0x00D42E9C
		public void RefreshView(int id)
		{
			this.Data = FlagChallengeModel.Instance.GetStrongholdData(id);
			FlagStronghold strongholdConfig = this.Data.StrongholdConfig;
			UiResourceConfig instance = UiResourceConfig.Instance;
			base.SetTextureByPath(strongholdConfig.MonsterIconPath, base.GetTexture(5), null, null);
			base.GetArtText(1).SetText(strongholdConfig.MonsterLevel.ToString());
			string levelDiffBgRes = this.GetLevelDiffBgRes(strongholdConfig.MonsterLevel);
			base.SetTextureByPath(instance.GetResourcePath(levelDiffBgRes), base.GetTexture(0), null, null);
			this.DescriptionComponent.SetContentByTextId(strongholdConfig.MonsterDesc, Array.Empty<string>());
			base.GetSprite(2).SetUIActive(this.Data.IsPass);
			bool flag = this.Data.IsUnlocked();
			UUIButtonComponent button = base.GetButton(4);
			UUIItem item = base.GetItem(8);
			if (flag)
			{
				FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId);
				int challengeLevelId = this.Data.StrongholdConfig.ChallengeLevelId;
				bool flag2 = flagChallengeData.GetLevelData(challengeLevelId).IsCompleted();
				button.RootUIComp.Get().SetUIActive(!flag2);
				item.SetUIActive(flag2);
			}
			else
			{
				button.RootUIComp.Get().SetUIActive(false);
				item.SetUIActive(false);
			}
			base.GetItem(7).SetUIActive(!flag);
		}

		// Token: 0x0602F93C RID: 194876 RVA: 0x00D44E08 File Offset: 0x00D43008
		private string GetLevelDiffBgRes(int targetLevel)
		{
			switch (FlagChallengeModel.Instance.GetLevelDiffType(this.ActivityId, targetLevel, null))
			{
			case EFlagChallengeLevelDiffType.Easy:
				return "T_EnemyFlagChallengeLevelGreenBg";
			case EFlagChallengeLevelDiffType.Normal:
				return "T_EnemyFlagChallengeLevelYellowBg";
			case EFlagChallengeLevelDiffType.Hard:
				return "T_EnemyFlagChallengeLevelRedBg";
			default:
				return "T_EnemyFlagChallengeLevelGreenBg";
			}
		}

		// Token: 0x0602F93D RID: 194877 RVA: 0x00D44E5C File Offset: 0x00D4305C
		private void OnClickButton(int _)
		{
			int challengeLevelId = this.Data.StrongholdConfig.ChallengeLevelId;
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			if (!instance.IsInFlagChallengeDungeon || instance.LevelId != challengeLevelId)
			{
				FlagChallengeController.Instance.OpenFlagChallengeSelectRoleView(this.ActivityId, challengeLevelId, this.Data.Id);
				return;
			}
			WorldMapController.Instance.TryTeleportByEntityId(this.Data.GetMarkId(), null);
			UiManager.Instance.CloseView(EUiViewName.FlagChallengeAreaDetailView, null);
			if (UiManager.Instance.IsViewOpen(EUiViewName.FlagChallengePauseView))
			{
				UiManager.Instance.CloseView(EUiViewName.FlagChallengePauseView, null);
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.FlagChallengeSettleView))
			{
				UiManager.Instance.CloseView(EUiViewName.FlagChallengeSettleView, null);
			}
		}

		// Token: 0x0401937F RID: 103295
		[Nullable(2)]
		private FlagChallengeStrongholdData Data;

		// Token: 0x04019380 RID: 103296
		private readonly int ActivityId;

		// Token: 0x04019381 RID: 103297
		[Nullable(2)]
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04019382 RID: 103298
		private ButtonItem FunctionButton;

		// Token: 0x04019383 RID: 103299
		private FlagChallengeLockItem LockItem;

		// Token: 0x04019384 RID: 103300
		private FlagChallengeCompleteItem CompleteItem;
	}
}
