using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029B1 RID: 10673
public class ShipTowerLevelInfoView : UiViewBase
{
	// Token: 0x06016224 RID: 90660 RVA: 0x005991F9 File Offset: 0x005973F9
	[NullableContext(1)]
	public ShipTowerLevelInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016225 RID: 90661 RVA: 0x00599204 File Offset: 0x00597404
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

	// Token: 0x06016226 RID: 90662 RVA: 0x00599340 File Offset: 0x00597540
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerLevelInfoView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerLevelInfoView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016227 RID: 90663 RVA: 0x00599384 File Offset: 0x00597584
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

	// Token: 0x06016228 RID: 90664 RVA: 0x005993C8 File Offset: 0x005975C8
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

	// Token: 0x06016229 RID: 90665 RVA: 0x0059944C File Offset: 0x0059764C
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

	// Token: 0x0601622A RID: 90666 RVA: 0x0059951C File Offset: 0x0059771C
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

	// Token: 0x0601622B RID: 90667 RVA: 0x00599593 File Offset: 0x00597793
	private void RefreshScoreInfo(int curScore, int maxScore)
	{
		ShipTowerBurningTideItem shipTowerBurningTideItem = this.ShipTowerBurningTideItem;
		if (shipTowerBurningTideItem == null)
		{
			return;
		}
		shipTowerBurningTideItem.UpdateValue(curScore, maxScore);
	}

	// Token: 0x0400A4ED RID: 42221
	[Nullable(2)]
	private ShipTowerBurningTideItem ShipTowerBurningTideItem;

	// Token: 0x02008FC7 RID: 36807
	private static class EChildType
	{
		// Token: 0x0402E911 RID: 190737
		public const int CaptionItem = 0;

		// Token: 0x0402E912 RID: 190738
		public const int LevelFeatureItem = 1;

		// Token: 0x0402E913 RID: 190739
		public const int LevelFeatureTitleText = 2;

		// Token: 0x0402E914 RID: 190740
		public const int LevelFeatureText = 3;

		// Token: 0x0402E915 RID: 190741
		public const int BuffItem = 4;

		// Token: 0x0402E916 RID: 190742
		public const int BuffNameText = 5;

		// Token: 0x0402E917 RID: 190743
		public const int BuffLevelText = 6;

		// Token: 0x0402E918 RID: 190744
		public const int BuffDescTitleText = 7;

		// Token: 0x0402E919 RID: 190745
		public const int BuffDescText = 8;

		// Token: 0x0402E91A RID: 190746
		public const int BurningTideInfoPanel = 9;

		// Token: 0x0402E91B RID: 190747
		public const int BurningTideItem = 10;

		// Token: 0x0402E91C RID: 190748
		public const int HotEffectDesc = 11;

		// Token: 0x0402E91D RID: 190749
		public const int BurningTideDesc = 12;
	}
}
