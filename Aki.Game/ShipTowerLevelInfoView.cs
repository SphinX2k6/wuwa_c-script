using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F2C RID: 7980
public class ShipTowerLevelInfoView : UiViewBase
{
	// Token: 0x06013C2A RID: 80938 RVA: 0x005C4185 File Offset: 0x005C2385
	[NullableContext(1)]
	public ShipTowerLevelInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C2B RID: 80939 RVA: 0x005C4190 File Offset: 0x005C2390
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText))
		};
	}

	// Token: 0x06013C2C RID: 80940 RVA: 0x005C42CC File Offset: 0x005C24CC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerLevelInfoView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerLevelInfoView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C2D RID: 80941 RVA: 0x005C4310 File Offset: 0x005C2510
	protected override void OnBeforeShow()
	{
		IShipTowerScoreItemViewParams shipTowerScoreItemViewParams = this.OpenParam as IShipTowerScoreItemViewParams;
		if (shipTowerScoreItemViewParams == null)
		{
			return;
		}
		this.RefreshFeatureInfo();
		this.RefreshBuffInfo();
		this.RefreshBurningTideInfo();
		this.RefreshScoreInfo(shipTowerScoreItemViewParams.CurScore, shipTowerScoreItemViewParams.MaxScore);
	}

	// Token: 0x06013C2E RID: 80942 RVA: 0x005C4354 File Offset: 0x005C2554
	private void RefreshFeatureInfo()
	{
		ShipTowerStageData currentStage = ShipTowerModel.Instance.GetCurrentStage();
		ShipTowerTeamData shipTowerTeamData = (currentStage != null) ? currentStage.GetCurrentTeamData() : null;
		if (shipTowerTeamData == null)
		{
			return;
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew("GhostShipMonster_Text1");
		}
		InstanceDungeon? instanceDungeonCfg = shipTowerTeamData.GetInstanceDungeonCfg(null);
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(((instanceDungeonCfg != null) ? instanceDungeonCfg.GetValueOrDefault().DungeonDesc : null) ?? "");
	}

	// Token: 0x06013C2F RID: 80943 RVA: 0x005C43D8 File Offset: 0x005C25D8
	private void RefreshBuffInfo()
	{
		IBattleUiHoverTipsD inTheBattleBuffInfo = ShipTowerModel.Instance.GetInTheBattleBuffInfo();
		UUIText text = base.GetText(5);
		LguiUtil.Instance.SetLocalTextNew(text, inTheBattleBuffInfo.TitleKey, Array.Empty<object>());
		UUIText text2 = base.GetText(6);
		if (!string.IsNullOrEmpty(inTheBattleBuffInfo.SubTitleKey))
		{
			LguiUtil.Instance.SetLocalTextNew(text2, inTheBattleBuffInfo.SubTitleKey, Array.Empty<object>());
		}
		else if (text2 != null)
		{
			text2.SetText("", true);
		}
		if (!string.IsNullOrEmpty(inTheBattleBuffInfo.DescTitleKey))
		{
			UUIText text3 = base.GetText(7);
			if (text3 != null)
			{
				text3.ShowTextNew(inTheBattleBuffInfo.DescTitleKey);
			}
		}
		if (inTheBattleBuffInfo.DescInfoList != null && inTheBattleBuffInfo.DescInfoList.Count > 0)
		{
			UUIText text4 = base.GetText(8);
			if (text4 == null)
			{
				return;
			}
			text4.ShowTextNew(inTheBattleBuffInfo.DescInfoList[0].DescKey);
		}
	}

	// Token: 0x06013C30 RID: 80944 RVA: 0x005C44A8 File Offset: 0x005C26A8
	private void RefreshBurningTideInfo()
	{
		SlashAndTowerSeason? curSeasonCfg = ShipTowerModel.Instance.CurSeasonCfg;
		if (curSeasonCfg == null)
		{
			return;
		}
		UUIText text = base.GetText(11);
		if (text != null)
		{
			text.ShowTextNew(curSeasonCfg.Value.HotDesc ?? "");
		}
		UUIText text2 = base.GetText(12);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(curSeasonCfg.Value.BuringTideDesc ?? "");
	}

	// Token: 0x06013C31 RID: 80945 RVA: 0x005C451F File Offset: 0x005C271F
	private void RefreshScoreInfo(int curScore, int maxScore)
	{
		ShipTowerBurningTideItem shipTowerBurningTideItem = this.ShipTowerBurningTideItem;
		if (shipTowerBurningTideItem == null)
		{
			return;
		}
		shipTowerBurningTideItem.UpdateValue(curScore, maxScore);
	}

	// Token: 0x0400A8D7 RID: 43223
	[Nullable(2)]
	private ShipTowerBurningTideItem ShipTowerBurningTideItem;

	// Token: 0x0200820F RID: 33295
	private static class EChildType
	{
		// Token: 0x0402A00E RID: 172046
		public const int CaptionItem = 0;

		// Token: 0x0402A00F RID: 172047
		public const int LevelFeatureItem = 1;

		// Token: 0x0402A010 RID: 172048
		public const int LevelFeatureTitleText = 2;

		// Token: 0x0402A011 RID: 172049
		public const int LevelFeatureText = 3;

		// Token: 0x0402A012 RID: 172050
		public const int BuffItem = 4;

		// Token: 0x0402A013 RID: 172051
		public const int BuffNameText = 5;

		// Token: 0x0402A014 RID: 172052
		public const int BuffLevelText = 6;

		// Token: 0x0402A015 RID: 172053
		public const int BuffDescTitleText = 7;

		// Token: 0x0402A016 RID: 172054
		public const int BuffDescText = 8;

		// Token: 0x0402A017 RID: 172055
		public const int BurningTideInfoPanel = 9;

		// Token: 0x0402A018 RID: 172056
		public const int BurningTideItem = 10;

		// Token: 0x0402A019 RID: 172057
		public const int HotEffectDesc = 11;

		// Token: 0x0402A01A RID: 172058
		public const int BurningTideDesc = 12;
	}
}
