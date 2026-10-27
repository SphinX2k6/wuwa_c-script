using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C0D RID: 11277
public class TowerVariationShareView : UiPanelBase
{
	// Token: 0x060176A3 RID: 95907 RVA: 0x005F6554 File Offset: 0x005F4754
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x060176A4 RID: 95908 RVA: 0x005F6664 File Offset: 0x005F4864
	protected override UniTask OnBeforeStartAsync()
	{
		TowerVariationShareView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerVariationShareView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060176A5 RID: 95909 RVA: 0x005F66A8 File Offset: 0x005F48A8
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "InstanceDungeonTitle_31_CommonText", Array.Empty<object>());
		int difficultyMaxStars = TowerModel.Instance.GetDifficultyMaxStars(3, false);
		int difficultyAllStars = TowerModel.Instance.GetDifficultyAllStars(3, false);
		base.GetText(2).SetText(difficultyMaxStars.ToString(), true);
		base.GetText(3).SetText("/" + difficultyAllStars.ToString(), true);
		int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(3, false);
		int num = 0;
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(difficultyAllAreaFirstFloor[num]);
		int areaStars = TowerModel.Instance.GetAreaStars(towerInfo.Value.Difficulty, towerInfo.Value.AreaNum, false);
		base.GetText(4).SetText(areaStars.ToString(), true);
		int[] difficultyAreaAllFloor = TowerModel.Instance.GetDifficultyAreaAllFloor(towerInfo.Value.Difficulty, towerInfo.Value.AreaNum);
		this.TowerOneTeamItem.Refresh(difficultyAreaAllFloor[difficultyAreaAllFloor.Length - 1], true, 0);
		int num2 = 2;
		TowerConfig? towerInfo2 = TowerClimbConfig.Instance.GetTowerInfo(difficultyAllAreaFirstFloor[num2]);
		int areaStars2 = TowerModel.Instance.GetAreaStars(towerInfo2.Value.Difficulty, towerInfo2.Value.AreaNum, false);
		base.GetText(6).SetText(areaStars2.ToString(), true);
		int[] difficultyAreaAllFloor2 = TowerModel.Instance.GetDifficultyAreaAllFloor(towerInfo2.Value.Difficulty, towerInfo2.Value.AreaNum);
		this.TowerTwoTeamItem.Refresh(difficultyAreaAllFloor2[difficultyAreaAllFloor2.Length - 1], true, 0);
		int num3 = 1;
		TowerConfig? towerInfo3 = TowerClimbConfig.Instance.GetTowerInfo(difficultyAllAreaFirstFloor[num3]);
		int areaStars3 = TowerModel.Instance.GetAreaStars(towerInfo3.Value.Difficulty, towerInfo3.Value.AreaNum, false);
		base.GetText(8).SetText(areaStars3.ToString(), true);
		this.TowerThreeTeamsLayout = new GenericLayout<TowerVariationShareTeamItem, int>(base.GetVerticalLayout(9), new Func<TowerVariationShareTeamItem>(this.InitTowerThreeTeamItem), null, false, true);
		int[] difficultyAreaAllFloor3 = TowerModel.Instance.GetDifficultyAreaAllFloor(towerInfo3.Value.Difficulty, towerInfo3.Value.AreaNum);
		this.TowerThreeTeamsLayout.RefreshByData(difficultyAreaAllFloor3, null, false);
		bool flag = true;
		foreach (int towerId in difficultyAreaAllFloor3)
		{
			if (TowerModel.Instance.GetFloorFormation(towerId).Count > 0)
			{
				flag = false;
				break;
			}
		}
		this.TowerThreeTeamsLayout.GetRootUiItem().SetUIActive(!flag);
		base.GetItem(11).SetUIActive(flag);
	}

	// Token: 0x060176A6 RID: 95910 RVA: 0x005F6962 File Offset: 0x005F4B62
	[NullableContext(1)]
	private TowerVariationShareTeamItem InitTowerThreeTeamItem()
	{
		return new TowerVariationShareTeamItem();
	}

	// Token: 0x0400AF19 RID: 44825
	[Nullable(2)]
	private TowerVariationShareTeamItem TowerOneTeamItem;

	// Token: 0x0400AF1A RID: 44826
	[Nullable(2)]
	private TowerVariationShareTeamItem TowerTwoTeamItem;

	// Token: 0x0400AF1B RID: 44827
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerVariationShareTeamItem, int> TowerThreeTeamsLayout;

	// Token: 0x020091D8 RID: 37336
	private enum EComponents
	{
		// Token: 0x0402F2F6 RID: 193270
		Icon,
		// Token: 0x0402F2F7 RID: 193271
		TitleText,
		// Token: 0x0402F2F8 RID: 193272
		StarNumText,
		// Token: 0x0402F2F9 RID: 193273
		StarMaxNumText,
		// Token: 0x0402F2FA RID: 193274
		TowerOneStarNumText,
		// Token: 0x0402F2FB RID: 193275
		TowerOneTeamItem,
		// Token: 0x0402F2FC RID: 193276
		TowerTwoStarNumText,
		// Token: 0x0402F2FD RID: 193277
		TowerTwoTeamItem,
		// Token: 0x0402F2FE RID: 193278
		TowerThreeStarNumText,
		// Token: 0x0402F2FF RID: 193279
		TowerThreeTeamsLayout,
		// Token: 0x0402F300 RID: 193280
		TowerThreeTeamItem,
		// Token: 0x0402F301 RID: 193281
		TowerThreeEmptyItem
	}
}
