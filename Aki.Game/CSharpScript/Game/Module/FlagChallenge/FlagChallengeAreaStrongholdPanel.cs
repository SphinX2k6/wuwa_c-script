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
	// Token: 0x02005A50 RID: 23120
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaStrongholdPanel : UiPanelBase
	{
		// Token: 0x0603A9EF RID: 240111 RVA: 0x00DF45E2 File Offset: 0x00DF27E2
		public FlagChallengeAreaStrongholdPanel(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0603A9F0 RID: 240112 RVA: 0x00DF45F4 File Offset: 0x00DF27F4
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

		// Token: 0x0603A9F1 RID: 240113 RVA: 0x00DF46D4 File Offset: 0x00DF28D4
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeAreaStrongholdPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeAreaStrongholdPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A9F2 RID: 240114 RVA: 0x00DF4718 File Offset: 0x00DF2918
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

		// Token: 0x0603A9F3 RID: 240115 RVA: 0x00DF4884 File Offset: 0x00DF2A84
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

		// Token: 0x0603A9F4 RID: 240116 RVA: 0x00DF48D8 File Offset: 0x00DF2AD8
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

		// Token: 0x0401E8D8 RID: 125144
		[Nullable(2)]
		private FlagChallengeStrongholdData Data;

		// Token: 0x0401E8D9 RID: 125145
		private readonly int ActivityId;

		// Token: 0x0401E8DA RID: 125146
		[Nullable(2)]
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401E8DB RID: 125147
		private ButtonItem FunctionButton;

		// Token: 0x0401E8DC RID: 125148
		private FlagChallengeLockItem LockItem;

		// Token: 0x0401E8DD RID: 125149
		private FlagChallengeCompleteItem CompleteItem;
	}
}
