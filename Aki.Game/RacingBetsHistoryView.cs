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

// Token: 0x02002733 RID: 10035
public class RacingBetsHistoryView : UiViewBase
{
	// Token: 0x0601493B RID: 84283 RVA: 0x00533C5F File Offset: 0x00531E5F
	[NullableContext(1)]
	public RacingBetsHistoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601493C RID: 84284 RVA: 0x00533C68 File Offset: 0x00531E68
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

	// Token: 0x0601493D RID: 84285 RVA: 0x00533D11 File Offset: 0x00531F11
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshView));
	}

	// Token: 0x0601493E RID: 84286 RVA: 0x00533D2F File Offset: 0x00531F2F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshView));
	}

	// Token: 0x0601493F RID: 84287 RVA: 0x00533D50 File Offset: 0x00531F50
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsHistoryView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsHistoryView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014940 RID: 84288 RVA: 0x00533D94 File Offset: 0x00531F94
	protected override void OnStart()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetScrollViewWithScrollbar(0).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x06014941 RID: 84289 RVA: 0x00533DDC File Offset: 0x00531FDC
	private void RefreshLoopView()
	{
		List<RacingBetsLegMatchData> racingBetsHistoryData = RacingBetsModel.Instance.GetRacingBetsHistoryData();
		this.RefreshPanelVisible(racingBetsHistoryData);
		if (racingBetsHistoryData != null && racingBetsHistoryData.Count > 0)
		{
			this.HistoryLoopView.RefreshByData(racingBetsHistoryData, null, false);
		}
	}

	// Token: 0x06014942 RID: 84290 RVA: 0x00533E18 File Offset: 0x00532018
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

	// Token: 0x06014943 RID: 84291 RVA: 0x00533E67 File Offset: 0x00532067
	private void RefreshView()
	{
		this.RefreshLoopView();
	}

	// Token: 0x06014944 RID: 84292 RVA: 0x00533E6F File Offset: 0x0053206F
	[NullableContext(1)]
	private RacingBetsHistoryItem CreateHistoryItem()
	{
		return new RacingBetsHistoryItem();
	}

	// Token: 0x06014945 RID: 84293 RVA: 0x00533E76 File Offset: 0x00532076
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009AA6 RID: 39590
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RacingBetsHistoryItem, RacingBetsLegMatchData> HistoryLoopView;

	// Token: 0x02008D9A RID: 36250
	private class EComponent
	{
		// Token: 0x0402DF61 RID: 188257
		public const int HistoryLoopView = 0;

		// Token: 0x0402DF62 RID: 188258
		public const int LoopViewContent = 1;

		// Token: 0x0402DF63 RID: 188259
		public const int HistoryViewItem = 2;

		// Token: 0x0402DF64 RID: 188260
		public const int PanelEmpty = 3;

		// Token: 0x0402DF65 RID: 188261
		public const int CloseBtn = 4;
	}
}
