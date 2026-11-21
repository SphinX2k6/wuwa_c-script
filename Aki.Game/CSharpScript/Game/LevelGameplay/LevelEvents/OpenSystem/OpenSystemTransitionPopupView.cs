using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D9F RID: 23967
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTransitionPopupView : OpenSystemBase
	{
		// Token: 0x0603A5DF RID: 239071 RVA: 0x0107CBAB File Offset: 0x0107ADAB
		public OpenSystemTransitionPopupView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5E0 RID: 239072 RVA: 0x0107CBB4 File Offset: 0x0107ADB4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTransitionPopupView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>4__this = this;
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTransitionPopupView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5E1 RID: 239073 RVA: 0x0107CC08 File Offset: 0x0107AE08
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			if (inParams.TransitionPopupConfig != null)
			{
				return this.GetViewNameByPopupConfig(inParams.TransitionPopupConfig);
			}
			TransitionPopup? config = ConfigTransitionPopupById.GetConfig(inParams.BoardId, true);
			if (config == null)
			{
				return null;
			}
			return new EUiViewName?(this.GetViewNameByConfig(config.Value));
		}

		// Token: 0x0603A5E2 RID: 239074 RVA: 0x0107CC6C File Offset: 0x0107AE6C
		private EUiViewName? GetViewNameByPopupConfig(ITransitionPopupConfig popupConfig)
		{
			switch (popupConfig.PopupStyle.Type)
			{
			case ETransitionPopupStyleType.LeftTopTip:
				return new EUiViewName?(EUiViewName.PlotHintView);
			case ETransitionPopupStyleType.LeftBottomTransition:
				return new EUiViewName?(EUiViewName.TransitionPopupView);
			case ETransitionPopupStyleType.ArtText:
				return new EUiViewName?(EUiViewName.PlotWordArtView);
			default:
				return null;
			}
		}

		// Token: 0x0603A5E3 RID: 239075 RVA: 0x0107CCC4 File Offset: 0x0107AEC4
		private object BuildViewParams(EUiViewName viewName, ITransitionPopupConfig popupConfig, bool inPlot)
		{
			ITransitionPopupStyle popupStyle = popupConfig.PopupStyle;
			if (popupStyle.Type == ETransitionPopupStyleType.ArtText)
			{
				return new PlotWordArtViewParams
				{
					Config = ((ITransitionPopupArtText)popupStyle).ArtTextType,
					Duration = popupConfig.Duration
				};
			}
			return new TransitionPopupViewParams
			{
				Style = popupStyle,
				InPlot = inPlot,
				Duration = popupConfig.Duration
			};
		}

		// Token: 0x0603A5E4 RID: 239076 RVA: 0x0107CD23 File Offset: 0x0107AF23
		private EUiViewName GetViewNameByConfig(TransitionPopup config)
		{
			if (config.Style == 2)
			{
				return EUiViewName.PlotHintView;
			}
			return EUiViewName.TransitionPopupView;
		}
	}
}
