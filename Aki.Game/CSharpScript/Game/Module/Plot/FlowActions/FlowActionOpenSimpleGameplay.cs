using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Hourglass;
using CSharpScript.Game.LevelGamePlay.ItemInspect;
using CSharpScript.Game.LevelGamePlay.SceneInspection;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C5 RID: 20677
	public class FlowActionOpenSimpleGameplay : FlowActionBase
	{
		// Token: 0x06034EFB RID: 216827 RVA: 0x00C89D8C File Offset: 0x00C87F8C
		protected override void OnExecute()
		{
			OpenSimpleGameplay openSimpleGameplay = this.ActionInfo.Params as OpenSimpleGameplay;
			if (openSimpleGameplay == null)
			{
				return;
			}
			ESimpleGameplayType type = openSimpleGameplay.GameplayConfig.Type;
			if (type > ESimpleGameplayType.DaemonHack)
			{
				if (type != ESimpleGameplayType.QteHourglass)
				{
					if (type == ESimpleGameplayType.SceneInspection)
					{
						long flowIncId = this.Context.FlowIncId;
						GeneralContext context = this.Context.Context;
						PlotContext context2 = PlotContext.Create(flowIncId, (context != null) ? context.SubType : null);
						CheckInteractionOpenParam param = new CheckInteractionOpenParam
						{
							Config = (ISceneInspection)openSimpleGameplay.GameplayConfig,
							Context = context2
						};
						UiManager.Instance.OpenViewByPlot(EUiViewName.CheckInteractionView, param, null);
						return;
					}
				}
				else
				{
					QteHourglassModel.Instance.OpenGameplay((IQteHourglass)openSimpleGameplay.GameplayConfig);
					base.FinishExecute(true, true);
				}
				return;
			}
			if (type == ESimpleGameplayType.ItemInspection)
			{
				ItemInspectController instance = ItemInspectController.Instance;
				IItemInspection config = (IItemInspection)openSimpleGameplay.GameplayConfig;
				Action<EUiViewName> onBeforeOpenView;
				if ((onBeforeOpenView = FlowActionOpenSimpleGameplay.<>O.<0>__RegisterOpenViewName) == null)
				{
					onBeforeOpenView = (FlowActionOpenSimpleGameplay.<>O.<0>__RegisterOpenViewName = new Action<EUiViewName>(TsInteractionUtils.RegisterOpenViewName));
				}
				instance.OpenItemInspect(config, onBeforeOpenView, delegate(bool _)
				{
					base.FinishExecute(true, true);
				});
				return;
			}
			if (type != ESimpleGameplayType.DaemonHack)
			{
				return;
			}
			IDaemonHack daemonHack = (IDaemonHack)openSimpleGameplay.GameplayConfig;
			GolemHackingController.Instance.OpenGameplayViewByPlot(daemonHack.Ids, delegate(bool result)
			{
				if (result)
				{
					base.FinishExecute(true, true);
				}
			}, daemonHack.FinishOnClose.GetValueOrDefault());
		}

		// Token: 0x06034EFC RID: 216828 RVA: 0x00C89ED4 File Offset: 0x00C880D4
		protected override void OnInterruptExecute()
		{
			if ((this.ActionInfo.Params as OpenSimpleGameplay).GameplayConfig.Type == ESimpleGameplayType.ItemInspection)
			{
				ItemInspectController.Instance.InterruptItemInspect();
			}
		}

		// Token: 0x0200B240 RID: 45632
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040360B0 RID: 221360
			public static Action<EUiViewName> <0>__RegisterOpenViewName;
		}
	}
}
