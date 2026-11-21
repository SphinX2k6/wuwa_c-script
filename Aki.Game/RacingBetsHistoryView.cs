using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C1E RID: 7198
public class RacingBetsHistoryView : UiViewBase
{
	// Token: 0x06011E1D RID: 73245 RVA: 0x0054296F File Offset: 0x00540B6F
	[NullableContext(1)]
	public RacingBetsHistoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E1E RID: 73246 RVA: 0x00542978 File Offset: 0x00540B78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x06011E1F RID: 73247 RVA: 0x00542A21 File Offset: 0x00540C21
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshView));
	}

	// Token: 0x06011E20 RID: 73248 RVA: 0x00542A3F File Offset: 0x00540C3F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshView));
	}

	// Token: 0x06011E21 RID: 73249 RVA: 0x00542A60 File Offset: 0x00540C60
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsHistoryView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsHistoryView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011E22 RID: 73250 RVA: 0x00542AA4 File Offset: 0x00540CA4
	protected override void OnStart()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetScrollViewWithScrollbar(0).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x06011E23 RID: 73251 RVA: 0x00542AEC File Offset: 0x00540CEC
	private void RefreshLoopView()
	{
		List<RacingBetsLegMatchData> racingBetsHistoryData = RacingBetsModel.Instance.GetRacingBetsHistoryData();
		this.RefreshPanelVisible(racingBetsHistoryData);
		if (racingBetsHistoryData != null && racingBetsHistoryData.Count > 0)
		{
			this.HistoryLoopView.RefreshByData(racingBetsHistoryData, null, false);
		}
	}

	// Token: 0x06011E24 RID: 73252 RVA: 0x00542B28 File Offset: 0x00540D28
	private void RefreshPanelVisible([Nullable(new byte[]
	{
		2,
		1
	})] List<RacingBetsLegMatchData> historyDataList)
	{
		if (historyDataList == null)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			int count = historyDataList.Count;
			base.GetItem(3).SetUIActive(count == 0);
			UUIItem item2 = base.GetItem(0);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(count > 0);
			return;
		}
	}

	// Token: 0x06011E25 RID: 73253 RVA: 0x00542B77 File Offset: 0x00540D77
	private void RefreshView()
	{
		this.RefreshLoopView();
	}

	// Token: 0x06011E26 RID: 73254 RVA: 0x00542B7F File Offset: 0x00540D7F
	[NullableContext(1)]
	private RacingBetsHistoryItem CreateHistoryItem()
	{
		return new RacingBetsHistoryItem();
	}

	// Token: 0x06011E27 RID: 73255 RVA: 0x00542B86 File Offset: 0x00540D86
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009BFE RID: 39934
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RacingBetsHistoryItem, RacingBetsLegMatchData> HistoryLoopView;

	// Token: 0x02007F22 RID: 32546
	private class EComponent
	{
		// Token: 0x04029277 RID: 168567
		public const int HistoryLoopView = 0;

		// Token: 0x04029278 RID: 168568
		public const int LoopViewContent = 1;

		// Token: 0x04029279 RID: 168569
		public const int HistoryViewItem = 2;

		// Token: 0x0402927A RID: 168570
		public const int PanelEmpty = 3;

		// Token: 0x0402927B RID: 168571
		public const int CloseBtn = 4;
	}
}
