using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B07 RID: 27399
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventClientPlayFlow : LevelEventBase
	{
		// Token: 0x0604405E RID: 278622 RVA: 0x010B6F22 File Offset: 0x010B5122
		public LevelEventClientPlayFlow(int id) : base(id)
		{
		}

		// Token: 0x0604405F RID: 278623 RVA: 0x010B6F2C File Offset: 0x010B512C
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.FlowInfo = (inParams as PlayFlow);
			if (this.FlowInfo == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			if (!FlowConfig.Instance.GetFlowIsClientFlow(this.FlowInfo.FlowListName, this.FlowInfo.FlowId, this.FlowInfo.StateId))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "LevelEventClientPlayFlow: 目标流程未标记为客户端剧情(IsClientFlow=false)";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Params", inParams);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Context", context);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.FinishExecute(true, false, true);
				return;
			}
			EGeneralContextType? type = context.Type;
			if (type != null)
			{
				EGeneralContextType valueOrDefault = type.GetValueOrDefault();
				if (valueOrDefault == EGeneralContextType.Entity)
				{
					this.DoStartFlow(context);
					return;
				}
				if (valueOrDefault == EGeneralContextType.Trigger)
				{
					if ((context as TriggerContext).IsClientTrigger)
					{
						this.DoStartFlow(context);
						return;
					}
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.LevelEvent;
					ELogAuthor author2 = ELogAuthor.YZH;
					string message2 = "非客户端触发器触发了客户端剧情(不播放)，请检查配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Params", inParams);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Context", context);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					base.FinishExecute(true, false, true);
					return;
				}
			}
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.LevelEvent;
			ELogAuthor author3 = ELogAuthor.YZH;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("ClientPlayFlow 没有支持的类型 ");
			defaultInterpolatedStringHandler.AppendFormatted<EGeneralContextType?>(context.Type);
			string message3 = defaultInterpolatedStringHandler.ToStringAndClear();
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Params", inParams);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Context", context);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044060 RID: 278624 RVA: 0x010B7100 File Offset: 0x010B5300
		private void DoStartFlow(GeneralContext context)
		{
			if (this.IsAsync)
			{
				FlowController.Instance.StartFlow(this.FlowInfo.FlowListName, this.FlowInfo.FlowId, this.FlowInfo.StateId, context, 0L, false, false, false, null);
				base.FinishExecute(true, false, true);
				return;
			}
			this.FlowIncId = new long?(FlowController.Instance.StartFlow(this.FlowInfo.FlowListName, this.FlowInfo.FlowId, this.FlowInfo.StateId, context, 0L, false, false, false, null));
			EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		}

		// Token: 0x06044061 RID: 278625 RVA: 0x010B71AC File Offset: 0x010B53AC
		private void OnPlotNetworkEnd(PlotResultInfo plotResult)
		{
			if (this.FlowInfo == null || this.FlowIncId == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			long? flowIncId = plotResult.FlowIncId;
			long value = this.FlowIncId.Value;
			if (!(flowIncId.GetValueOrDefault() == value & flowIncId != null))
			{
				return;
			}
			if (plotResult.FlowListName != this.FlowInfo.FlowListName)
			{
				return;
			}
			int? num = plotResult.StateId;
			int num2 = this.FlowInfo.StateId;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				return;
			}
			num = plotResult.FlowId;
			num2 = this.FlowInfo.FlowId;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				return;
			}
			EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044062 RID: 278626 RVA: 0x010B7290 File Offset: 0x010B5490
		protected override void OnReset()
		{
			this.FlowInfo = null;
			this.FlowIncId = null;
			if (EventSystem.Instance.Has<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd)))
			{
				EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
			}
		}

		// Token: 0x040238CA RID: 145610
		[Nullable(2)]
		private PlayFlow FlowInfo;

		// Token: 0x040238CB RID: 145611
		private long? FlowIncId;
	}
}
