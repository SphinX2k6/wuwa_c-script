using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.LevelLoading;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x020050A1 RID: 20641
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowServerNotifyCenter : ControllerAssistantBase
	{
		// Token: 0x06034E66 RID: 216678 RVA: 0x00C87012 File Offset: 0x00C85212
		protected override void OnDestroy()
		{
		}

		// Token: 0x06034E67 RID: 216679 RVA: 0x00C87014 File Offset: 0x00C85214
		public void HandleFlowStartNotify(FlowStartNotify notify)
		{
			long flowIncId = notify.FlowIncId;
			GeneralContext context = LevelGeneralContextUtil.CreateByServerContext(notify.GameCtx);
			GameCtxPb gameCtx = notify.GameCtx;
			if (gameCtx != null && gameCtx.CtxType == GameCtxType.GmPlayFlow)
			{
				PlotModel.Instance.PlotConfig.IsGmPlayPlotOnce = true;
			}
			global::Vector pos = null;
			if (notify.HasPlotPos)
			{
				if (notify.PlotPos == null)
				{
					FlowController instance = FlowController.Instance;
					string text = "未配置剧情坐标点";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("incId", flowIncId);
					instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					pos = global::Vector.Create((double)notify.PlotPos.X, (double)notify.PlotPos.Y, (double)notify.PlotPos.Z);
				}
			}
			FlowController.Instance.StartFlow(notify.FlowListName, notify.FlowId, notify.StateId, context, flowIncId, true, notify.Async, notify.IsSkip, pos);
		}

		// Token: 0x06034E68 RID: 216680 RVA: 0x00C870F0 File Offset: 0x00C852F0
		public void HandleFlowEndNotify(FlowEndNotify notify)
		{
			long value = MathUtils.Instance.LongToNumber(notify.FlowIncId);
			FlowController.Instance.FinishFlow("服务器剧情通知打断剧情", new long?(value), true);
		}

		// Token: 0x06034E69 RID: 216681 RVA: 0x00C87124 File Offset: 0x00C85324
		[NullableContext(2)]
		public unsafe void HandleFlowSkipBlackScreenNotify(FlowServerSkipNotify notify)
		{
			if (notify == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "服务器跳过剧情，检查是否有黑幕";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", notify.FlowListName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", notify.FlowId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", notify.StateId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("FadeOutScreen", notify.FadeOutScreen);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			LevelLoadingController instance2 = LevelLoadingController.Instance;
			ELoadingReason reason = ELoadingReason.Common;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
			defaultInterpolatedStringHandler.AppendLiteral("ServerNotifySkipFlow_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(notify.FlowId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(notify.StateId);
			instance2.CloseLoading(reason, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
		}
	}
}
