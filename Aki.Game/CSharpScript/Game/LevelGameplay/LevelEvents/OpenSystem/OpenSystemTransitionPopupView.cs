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
	// Token: 0x02006C26 RID: 27686
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTransitionPopupView : OpenSystemBase
	{
		// Token: 0x06044487 RID: 279687 RVA: 0x010D2C57 File Offset: 0x010D0E57
		public OpenSystemTransitionPopupView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044488 RID: 279688 RVA: 0x010D2C60 File Offset: 0x010D0E60
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

		// Token: 0x06044489 RID: 279689 RVA: 0x010D2CB4 File Offset: 0x010D0EB4
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

		// Token: 0x0604448A RID: 279690 RVA: 0x010D2D18 File Offset: 0x010D0F18
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

		// Token: 0x0604448B RID: 279691 RVA: 0x010D2D70 File Offset: 0x010D0F70
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

		// Token: 0x0604448C RID: 279692 RVA: 0x010D2DCF File Offset: 0x010D0FCF
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
