using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004079 RID: 16505
	[NullableContext(2)]
	[Nullable(0)]
	public class FlowActionBase
	{
		// Token: 0x06029D96 RID: 171414 RVA: 0x00BD5840 File Offset: 0x00BD3A40
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

		// Token: 0x06029D97 RID: 171415 RVA: 0x00BD5871 File Offset: 0x00BD3A71
		protected virtual void OnExecute()
		{
		}

		// Token: 0x06029D98 RID: 171416 RVA: 0x00BD5873 File Offset: 0x00BD3A73
		protected virtual void OnBackgroundExecute()
		{
			this.FinishExecute(true, true);
		}

		// Token: 0x06029D99 RID: 171417 RVA: 0x00BD587D File Offset: 0x00BD3A7D
		public void InterruptExecute()
		{
			this.OnInterruptExecute();
		}

		// Token: 0x06029D9A RID: 171418 RVA: 0x00BD5885 File Offset: 0x00BD3A85
		protected virtual void OnInterruptExecute()
		{
		}

		// Token: 0x06029D9B RID: 171419 RVA: 0x00BD5888 File Offset: 0x00BD3A88
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

		// Token: 0x06029D9C RID: 171420 RVA: 0x00BD58D4 File Offset: 0x00BD3AD4
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

		// Token: 0x06029D9D RID: 171421 RVA: 0x00BD5957 File Offset: 0x00BD3B57
		[NullableContext(1)]
		protected virtual void OnRollback(ActionRecord actionInfo, FlowContext context)
		{
		}

		// Token: 0x06029D9E RID: 171422 RVA: 0x00BD595C File Offset: 0x00BD3B5C
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

		// Token: 0x06029D9F RID: 171423 RVA: 0x00BD59AB File Offset: 0x00BD3BAB
		public void Recycle()
		{
			FlowAction owner = this.Owner;
			if (owner == null)
			{
				return;
			}
			owner.RecycleAction(this);
		}

		// Token: 0x04016D31 RID: 93489
		public EAction Type;

		// Token: 0x04016D32 RID: 93490
		protected ActionInfo ActionInfo;

		// Token: 0x04016D33 RID: 93491
		public Action<bool, bool> Callback;

		// Token: 0x04016D34 RID: 93492
		public FlowActionRunner Runner;

		// Token: 0x04016D35 RID: 93493
		public FlowAction Owner;

		// Token: 0x04016D36 RID: 93494
		public FlowContext Context;
	}
}
