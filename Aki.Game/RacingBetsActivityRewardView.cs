using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002723 RID: 10019
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsActivityRewardView : UiViewBase
{
	// Token: 0x06014880 RID: 84096 RVA: 0x0052F17E File Offset: 0x0052D37E
	public RacingBetsActivityRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014881 RID: 84097 RVA: 0x0052F188 File Offset: 0x0052D388
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x06014882 RID: 84098 RVA: 0x0052F275 File Offset: 0x0052D475
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x06014883 RID: 84099 RVA: 0x0052F2AF File Offset: 0x0052D4AF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Remove<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x06014884 RID: 84100 RVA: 0x0052F2EC File Offset: 0x0052D4EC
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsActivityRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsActivityRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014885 RID: 84101 RVA: 0x0052F32F File Offset: 0x0052D52F
	private void RefreshView()
	{
		this.RefreshView(null);
	}

	// Token: 0x06014886 RID: 84102 RVA: 0x0052F338 File Offset: 0x0052D538
	private void RefreshView(RacingBetsSeasonData data)
	{
		if (this.CurGroupRewardData == null)
		{
			return;
		}
		foreach (RacingBetsRewardTabItem racingBetsRewardTabItem in this.TabLayout.GetLayoutItemList())
		{
			racingBetsRewardTabItem.RefreshItem();
		}
		List<RacingBetsRewardData> rewardDataList = this.CurGroupRewardData.GetRewardDataList();
		this.RewardLayout.RefreshByData(rewardDataList, null, false);
	}

	// Token: 0x06014887 RID: 84103 RVA: 0x0052F3B0 File Offset: 0x0052D5B0
	private RacingBetsActivityRewardItem RewardItemProxyCreate()
	{
		return new RacingBetsActivityRewardItem();
	}

	// Token: 0x06014888 RID: 84104 RVA: 0x0052F3B7 File Offset: 0x0052D5B7
	private RacingBetsRewardTabItem TabItemProxyCreate()
	{
		RacingBetsRewardTabItem racingBetsRewardTabItem = new RacingBetsRewardTabItem();
		racingBetsRewardTabItem.BindClickToggleCallBack(new Action<RacingBetsGroupRewardData>(this.OnClickTabToggle));
		return racingBetsRewardTabItem;
	}

	// Token: 0x06014889 RID: 84105 RVA: 0x0052F3D0 File Offset: 0x0052D5D0
	private void OnClickTabToggle(RacingBetsGroupRewardData groupData)
	{
		if (this.CurGroupRewardData == groupData)
		{
			return;
		}
		this.CurGroupRewardData = groupData;
		int gridIndex = this.GroupDataList.FindIndex((RacingBetsGroupRewardData data) => data == groupData);
		this.TabLayout.SelectGridProxy(gridIndex, false);
		List<RacingBetsRewardData> rewardDataList = groupData.GetRewardDataList();
		this.RewardLayout.RefreshByData(rewardDataList, null, false);
	}

	// Token: 0x0601488A RID: 84106 RVA: 0x0052F444 File Offset: 0x0052D644
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009A65 RID: 39525
	[Nullable(2)]
	private RacingBetsGroupRewardData CurGroupRewardData;

	// Token: 0x04009A66 RID: 39526
	private List<RacingBetsGroupRewardData> GroupDataList;

	// Token: 0x04009A67 RID: 39527
	private GenericLayout<RacingBetsRewardTabItem, RacingBetsGroupRewardData> TabLayout;

	// Token: 0x04009A68 RID: 39528
	private GenericLayout<RacingBetsActivityRewardItem, RacingBetsRewardData> RewardLayout;

	// Token: 0x02008D78 RID: 36216
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DE6C RID: 188012
		public const int CloseBtn = 0;

		// Token: 0x0402DE6D RID: 188013
		public const int TogLayout = 1;

		// Token: 0x0402DE6E RID: 188014
		public const int RewardLayout = 2;

		// Token: 0x0402DE6F RID: 188015
		public const int ContentItem = 3;

		// Token: 0x0402DE70 RID: 188016
		public const int TimeText = 4;

		// Token: 0x0402DE71 RID: 188017
		public const int MaskButton = 5;

		// Token: 0x0402DE72 RID: 188018
		public const int TitleText = 6;
	}
}
