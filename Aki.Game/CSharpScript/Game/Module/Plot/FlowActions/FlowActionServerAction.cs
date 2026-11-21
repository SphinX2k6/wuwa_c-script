using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200409C RID: 16540
	public class FlowActionServerAction : FlowActionBase
	{
		// Token: 0x06029E15 RID: 171541 RVA: 0x00BD77AC File Offset: 0x00BD59AC
		[NullableContext(1)]
		public unsafe override void Execute(ActionInfo actionInfo, FlowContext context, bool isAutoFinish)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "===>服务器剧情行为开始";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", actionInfo.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionId", actionInfo.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("background", context.IsBackground);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.Context = context;
			this.ActionInfo = actionInfo;
			this.IsAutoFinish = isAutoFinish;
			if (!this.Context.IsServerNotify)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "非服务器触发的剧情无法使用服务器行为！", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, true);
				return;
			}
			if (context.IsBackground)
			{
				this.OnBackgroundExecute();
			}
			else
			{
				this.OnExecute();
			}
			if (this.IsAutoFinish)
			{
				base.FinishExecute(true, true);
			}
		}

		// Token: 0x06029E16 RID: 171542 RVA: 0x00BD78AF File Offset: 0x00BD5AAF
		protected override void OnExecute()
		{
			this.RequestServerAction(!this.IsAutoFinish, null);
		}

		// Token: 0x06029E17 RID: 171543 RVA: 0x00BD78C1 File Offset: 0x00BD5AC1
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06029E18 RID: 171544 RVA: 0x00BD78CC File Offset: 0x00BD5ACC
		[NullableContext(2)]
		protected unsafe void RequestServerAction(bool endWhenResponse = false, Action<ErrorCode> callback = null)
		{
			FlowContext context = this.Context;
			long? num = (context != null) ? new long?(context.FlowIncId) : null;
			ActionInfo actionInfo = this.ActionInfo;
			int? num2 = (actionInfo != null) ? actionInfo.ActionId : null;
			if (num == null || num2 == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.CK;
				string message = "服务器行为请求参数异常！";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Context", this.Context);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionInfo", this.ActionInfo);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			FlowNetworks.RequestAction(num.Value, num2.Value, delegate(ErrorCode code)
			{
				Action<ErrorCode> callback2 = callback;
				if (callback2 != null)
				{
					callback2(code);
				}
				if (endWhenResponse)
				{
					this.FinishExecute(true, true);
				}
			});
		}

		// Token: 0x04016D3B RID: 93499
		private bool IsAutoFinish;
	}
}
