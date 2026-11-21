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

// Token: 0x02001C0E RID: 7182
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsActivityRewardView : UiViewBase
{
	// Token: 0x06011D62 RID: 73058 RVA: 0x0053DE9A File Offset: 0x0053C09A
	public RacingBetsActivityRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06011D63 RID: 73059 RVA: 0x0053DEA4 File Offset: 0x0053C0A4
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

	// Token: 0x06011D64 RID: 73060 RVA: 0x0053DF91 File Offset: 0x0053C191
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x06011D65 RID: 73061 RVA: 0x0053DFCB File Offset: 0x0053C1CB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshView));
		EventSystem.Instance.Remove<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.RefreshView));
	}

	// Token: 0x06011D66 RID: 73062 RVA: 0x0053E008 File Offset: 0x0053C208
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsActivityRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsActivityRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D67 RID: 73063 RVA: 0x0053E04B File Offset: 0x0053C24B
	private void RefreshView()
	{
		this.RefreshView(null);
	}

	// Token: 0x06011D68 RID: 73064 RVA: 0x0053E054 File Offset: 0x0053C254
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

	// Token: 0x06011D69 RID: 73065 RVA: 0x0053E0CC File Offset: 0x0053C2CC
	private RacingBetsActivityRewardItem RewardItemProxyCreate()
	{
		return new RacingBetsActivityRewardItem();
	}

	// Token: 0x06011D6A RID: 73066 RVA: 0x0053E0D3 File Offset: 0x0053C2D3
	private RacingBetsRewardTabItem TabItemProxyCreate()
	{
		RacingBetsRewardTabItem racingBetsRewardTabItem = new RacingBetsRewardTabItem();
		racingBetsRewardTabItem.BindClickToggleCallBack(new Action<RacingBetsGroupRewardData>(this.OnClickTabToggle));
		return racingBetsRewardTabItem;
	}

	// Token: 0x06011D6B RID: 73067 RVA: 0x0053E0EC File Offset: 0x0053C2EC
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

	// Token: 0x06011D6C RID: 73068 RVA: 0x0053E160 File Offset: 0x0053C360
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009BBD RID: 39869
	[Nullable(2)]
	private RacingBetsGroupRewardData CurGroupRewardData;

	// Token: 0x04009BBE RID: 39870
	private List<RacingBetsGroupRewardData> GroupDataList;

	// Token: 0x04009BBF RID: 39871
	private GenericLayout<RacingBetsRewardTabItem, RacingBetsGroupRewardData> TabLayout;

	// Token: 0x04009BC0 RID: 39872
	private GenericLayout<RacingBetsActivityRewardItem, RacingBetsRewardData> RewardLayout;

	// Token: 0x02007F01 RID: 32513
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029183 RID: 168323
		public const int CloseBtn = 0;

		// Token: 0x04029184 RID: 168324
		public const int TogLayout = 1;

		// Token: 0x04029185 RID: 168325
		public const int RewardLayout = 2;

		// Token: 0x04029186 RID: 168326
		public const int ContentItem = 3;

		// Token: 0x04029187 RID: 168327
		public const int TimeText = 4;

		// Token: 0x04029188 RID: 168328
		public const int MaskButton = 5;

		// Token: 0x04029189 RID: 168329
		public const int TitleText = 6;
	}
}
