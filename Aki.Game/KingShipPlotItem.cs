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

// Token: 0x0200151A RID: 5402
internal class KingShipPlotItem : UiPanelBase
{
	// Token: 0x0600D81F RID: 55327 RVA: 0x00402364 File Offset: 0x00400564
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

	// Token: 0x0600D820 RID: 55328 RVA: 0x004024A0 File Offset: 0x004006A0
	protected override UniTask OnBeforeStartAsync()
	{
		KingShipPlotItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KingShipPlotItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D821 RID: 55329 RVA: 0x004024E4 File Offset: 0x004006E4
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

	// Token: 0x0600D822 RID: 55330 RVA: 0x004025D0 File Offset: 0x004007D0
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

	// Token: 0x0600D823 RID: 55331 RVA: 0x00402638 File Offset: 0x00400838
	private void OnMaskBtnClick()
	{
		this.CurrentShowPlotIndex++;
		this.ShowPlot();
		AudioSystem.Instance.PostEvent("play_ui_ia_com_confirm");
	}

	// Token: 0x0600D824 RID: 55332 RVA: 0x0040265E File Offset: 0x0040085E
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

	// Token: 0x0600D825 RID: 55333 RVA: 0x00402684 File Offset: 0x00400884
	public UniTask DestroyPortraitItem()
	{
		KingShipPlotItem.<DestroyPortraitItem>d__11 <DestroyPortraitItem>d__;
		<DestroyPortraitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DestroyPortraitItem>d__.<>4__this = this;
		<DestroyPortraitItem>d__.<>1__state = -1;
		<DestroyPortraitItem>d__.<>t__builder.Start<KingShipPlotItem.<DestroyPortraitItem>d__11>(ref <DestroyPortraitItem>d__);
		return <DestroyPortraitItem>d__.<>t__builder.Task;
	}

	// Token: 0x04007902 RID: 30978
	[Nullable(1)]
	private List<ITalkItem> PlotDataList = new List<ITalkItem>();

	// Token: 0x04007903 RID: 30979
	private int CurrentShowPlotIndex;

	// Token: 0x04007904 RID: 30980
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x04007905 RID: 30981
	[Nullable(2)]
	private PlotTextCommonLogic CommonLogic;

	// Token: 0x020077C7 RID: 30663
	private class EKingShipPlotItemDefine
	{
		// Token: 0x04026E1F RID: 159263
		public const int NpcName = 0;

		// Token: 0x04026E20 RID: 159264
		public const int NpcTitle = 1;

		// Token: 0x04026E21 RID: 159265
		public const int Content = 2;

		// Token: 0x04026E22 RID: 159266
		public const int LineItem = 3;

		// Token: 0x04026E23 RID: 159267
		public const int PlotItem = 4;

		// Token: 0x04026E24 RID: 159268
		public const int LeftPoint = 5;

		// Token: 0x04026E25 RID: 159269
		public const int RightPoint = 6;

		// Token: 0x04026E26 RID: 159270
		public const int CenterPoint = 7;

		// Token: 0x04026E27 RID: 159271
		public const int TextScrollView = 8;

		// Token: 0x04026E28 RID: 159272
		public const int OptionPanel = 9;

		// Token: 0x04026E29 RID: 159273
		public const int OptionLayout = 10;

		// Token: 0x04026E2A RID: 159274
		public const int OptionItem = 11;

		// Token: 0x04026E2B RID: 159275
		public const int OptionLimitBar = 12;
	}
}
