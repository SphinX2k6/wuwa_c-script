using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050A9 RID: 20649
	[NullableContext(2)]
	[Nullable(0)]
	public class FlowActionBase
	{
		// Token: 0x06034E9D RID: 216733 RVA: 0x00C885C0 File Offset: 0x00C867C0
		[NullableContext(1)]
		public virtual void Execute(ActionInfo actionInfo, FlowContext context, bool isAutoFinish)
		{
			this.Context = context;
			this.ActionInfo = actionInfo;
			if (context.IsBackground)
			{
				this.OnBackgroundExecute();
			}
			else
			{
				this.OnExecute();
			}
			if (isAutoFinish)
			{
				this.FinishExecute(true, true);
			}
		}

		// Token: 0x06034E9E RID: 216734 RVA: 0x00C885F1 File Offset: 0x00C867F1
		protected virtual void OnExecute()
		{
		}

		// Token: 0x06034E9F RID: 216735 RVA: 0x00C885F3 File Offset: 0x00C867F3
		protected virtual void OnBackgroundExecute()
		{
			this.FinishExecute(true, true);
		}

		// Token: 0x06034EA0 RID: 216736 RVA: 0x00C885FD File Offset: 0x00C867FD
		public void InterruptExecute()
		{
			this.OnInterruptExecute();
		}

		// Token: 0x06034EA1 RID: 216737 RVA: 0x00C88605 File Offset: 0x00C86805
		protected virtual void OnInterruptExecute()
		{
		}

		// Token: 0x06034EA2 RID: 216738 RVA: 0x00C88608 File Offset: 0x00C86808
		protected void RecordAction(ActionRecord actionRecord = null)
		{
			if (this.Context == null)
			{
				return;
			}
			if (actionRecord == null)
			{
				this.Context.RollbackRecord.Add(new ActionRecord
				{
					ActionInfo = this.ActionInfo
				});
				return;
			}
			this.Context.RollbackRecord.Add(actionRecord);
		}

		// Token: 0x06034EA3 RID: 216739 RVA: 0x00C88654 File Offset: 0x00C86854
		[NullableContext(1)]
		public unsafe void Rollback(ActionRecord actionRecord, FlowContext context)
		{
			ActionInfo actionInfo = actionRecord.ActionInfo;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "剧情行为回退";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", actionInfo.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionId", actionInfo.ActionId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.OnRollback(actionRecord, context);
		}

		// Token: 0x06034EA4 RID: 216740 RVA: 0x00C886D7 File Offset: 0x00C868D7
		[NullableContext(1)]
		protected virtual void OnRollback(ActionRecord actionInfo, FlowContext context)
		{
		}

		// Token: 0x06034EA5 RID: 216741 RVA: 0x00C886DC File Offset: 0x00C868DC
		protected void FinishExecute(bool isSuccess, bool isContinue = true)
		{
			if (this.ActionInfo == null || this.Runner == null)
			{
				return;
			}
			this.ActionInfo = null;
			this.Runner = null;
			this.Context = null;
			if (this.Callback != null)
			{
				Action<bool, bool> callback = this.Callback;
				this.Callback = null;
				callback(isSuccess, isContinue);
			}
		}

		// Token: 0x06034EA6 RID: 216742 RVA: 0x00C8872B File Offset: 0x00C8692B
		public void Recycle()
		{
			FlowAction owner = this.Owner;
			if (owner == null)
			{
				return;
			}
			owner.RecycleAction(this);
		}

		// Token: 0x0401C300 RID: 115456
		public EAction Type;

		// Token: 0x0401C301 RID: 115457
		protected ActionInfo ActionInfo;

		// Token: 0x0401C302 RID: 115458
		public Action<bool, bool> Callback;

		// Token: 0x0401C303 RID: 115459
		public FlowActionRunner Runner;

		// Token: 0x0401C304 RID: 115460
		public FlowAction Owner;

		// Token: 0x0401C305 RID: 115461
		public FlowContext Context;
	}
}
