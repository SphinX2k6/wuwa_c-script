using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002047 RID: 8263
internal class KingShipPlotItem : UiPanelBase
{
	// Token: 0x060103B7 RID: 66487 RVA: 0x003F5D6C File Offset: 0x003F3F6C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIScrollViewComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUISliderComponent))
		};
	}

	// Token: 0x060103B8 RID: 66488 RVA: 0x003F5EA8 File Offset: 0x003F40A8
	protected override UniTask OnBeforeStartAsync()
	{
		KingShipPlotItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KingShipPlotItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060103B9 RID: 66489 RVA: 0x003F5EEC File Offset: 0x003F40EC
	[NullableContext(1)]
	public void RefreshPlot(List<string> flowId)
	{
		this.PlotDataList.Clear();
		this.CurrentShowPlotIndex = 0;
		List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flowId[0], int.Parse(flowId[1]), int.Parse(flowId[2]));
		if (flowStateActions != null)
		{
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					foreach (ITalkItem item in ((ShowTalk)actionInfo.Params).TalkItems)
					{
						this.PlotDataList.Add(item);
					}
				}
			}
		}
		this.ShowPlot();
	}

	// Token: 0x060103BA RID: 66490 RVA: 0x003F5FD8 File Offset: 0x003F41D8
	public void ShowPlot()
	{
		int count = this.PlotDataList.Count;
		if (this.CurrentShowPlotIndex >= count)
		{
			DynamicMaskButton maskButton = this.MaskButton;
			if (maskButton != null)
			{
				maskButton.SetUiActive(false);
			}
			UiManager.Instance.CloseView(EUiViewName.KingShipPlotView, null);
			return;
		}
		ITalkItem inPlotSubtitleInfo = this.PlotDataList[this.CurrentShowPlotIndex];
		PlotTextCommonLogic commonLogic = this.CommonLogic;
		if (commonLogic == null)
		{
			return;
		}
		commonLogic.UpdatePlotSubtitle(inPlotSubtitleInfo);
	}

	// Token: 0x060103BB RID: 66491 RVA: 0x003F6040 File Offset: 0x003F4240
	private void OnMaskBtnClick()
	{
		this.CurrentShowPlotIndex++;
		this.ShowPlot();
		AudioSystem.Instance.PostEvent("play_ui_ia_com_confirm");
	}

	// Token: 0x060103BC RID: 66492 RVA: 0x003F6066 File Offset: 0x003F4266
	protected override void OnBeforeDestroy()
	{
		DynamicMaskButton maskButton = this.MaskButton;
		if (maskButton != null)
		{
			maskButton.Destroy(null);
		}
		PlotTextCommonLogic commonLogic = this.CommonLogic;
		if (commonLogic == null)
		{
			return;
		}
		commonLogic.Clear();
	}

	// Token: 0x060103BD RID: 66493 RVA: 0x003F608C File Offset: 0x003F428C
	public UniTask DestroyPortraitItem()
	{
		KingShipPlotItem.<DestroyPortraitItem>d__11 <DestroyPortraitItem>d__;
		<DestroyPortraitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DestroyPortraitItem>d__.<>4__this = this;
		<DestroyPortraitItem>d__.<>1__state = -1;
		<DestroyPortraitItem>d__.<>t__builder.Start<KingShipPlotItem.<DestroyPortraitItem>d__11>(ref <DestroyPortraitItem>d__);
		return <DestroyPortraitItem>d__.<>t__builder.Task;
	}

	// Token: 0x04007819 RID: 30745
	[Nullable(1)]
	private List<ITalkItem> PlotDataList = new List<ITalkItem>();

	// Token: 0x0400781A RID: 30746
	private int CurrentShowPlotIndex;

	// Token: 0x0400781B RID: 30747
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x0400781C RID: 30748
	[Nullable(2)]
	private PlotTextCommonLogic CommonLogic;

	// Token: 0x02008640 RID: 34368
	private class EKingShipPlotItemDefine
	{
		// Token: 0x0402BB10 RID: 178960
		public const int NpcName = 0;

		// Token: 0x0402BB11 RID: 178961
		public const int NpcTitle = 1;

		// Token: 0x0402BB12 RID: 178962
		public const int Content = 2;

		// Token: 0x0402BB13 RID: 178963
		public const int LineItem = 3;

		// Token: 0x0402BB14 RID: 178964
		public const int PlotItem = 4;

		// Token: 0x0402BB15 RID: 178965
		public const int LeftPoint = 5;

		// Token: 0x0402BB16 RID: 178966
		public const int RightPoint = 6;

		// Token: 0x0402BB17 RID: 178967
		public const int CenterPoint = 7;

		// Token: 0x0402BB18 RID: 178968
		public const int TextScrollView = 8;

		// Token: 0x0402BB19 RID: 178969
		public const int OptionPanel = 9;

		// Token: 0x0402BB1A RID: 178970
		public const int OptionLayout = 10;

		// Token: 0x0402BB1B RID: 178971
		public const int OptionItem = 11;

		// Token: 0x0402BB1C RID: 178972
		public const int OptionLimitBar = 12;
	}
}
