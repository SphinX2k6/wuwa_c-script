using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityAction
{
	// Token: 0x02005A95 RID: 23189
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityActionExecuteHandler
	{
		// Token: 0x06039278 RID: 234104 RVA: 0x010015D0 File Offset: 0x00FFF7D0
		internal ActivityActionExecuteHandler()
		{
		}

		// Token: 0x17006CD0 RID: 27856
		// (get) Token: 0x06039279 RID: 234105 RVA: 0x010015E4 File Offset: 0x00FFF7E4
		public bool IsDisposed
		{
			get
			{
				return this.Disposed;
			}
		}

		// Token: 0x17006CD1 RID: 27857
		// (get) Token: 0x0603927A RID: 234106 RVA: 0x010015EC File Offset: 0x00FFF7EC
		public bool HasWork
		{
			get
			{
				return this.Current != null || !this.Pending.Empty;
			}
		}

		// Token: 0x0603927B RID: 234107 RVA: 0x01001606 File Offset: 0x00FFF806
		[NullableContext(2)]
		public void SetWorkFinishedCallback(Action onWorkFinished)
		{
			this.WorkFinishedCallback = onWorkFinished;
		}

		// Token: 0x0603927C RID: 234108 RVA: 0x0100160F File Offset: 0x00FFF80F
		public ActivityActionExecuteHandler Push(ActivityActionBase action)
		{
			if (this.Disposed || action == null)
			{
				return this;
			}
			this.Pending.Push(action);
			return this;
		}

		// Token: 0x0603927D RID: 234109 RVA: 0x0100162B File Offset: 0x00FFF82B
		public ActivityActionExecuteHandler PushSequence(List<ActivityActionBase> actions)
		{
			if (this.Disposed || actions == null || actions.Count == 0)
			{
				return this;
			}
			this.Pending.Push(new SequenceAction(actions));
			return this;
		}

		// Token: 0x0603927E RID: 234110 RVA: 0x01001654 File Offset: 0x00FFF854
		public ActivityActionExecuteHandler PushParallel(List<ActivityActionBase> actions)
		{
			if (this.Disposed || actions == null || actions.Count == 0)
			{
				return this;
			}
			this.Pending.Push(new ParallelAction(actions));
			return this;
		}

		// Token: 0x0603927F RID: 234111 RVA: 0x01001680 File Offset: 0x00FFF880
		public ActivityActionExecuteHandler Push(EActivityActionType type, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] IReadOnlyDictionary<string, string> parameters = null)
		{
			if (this.Disposed)
			{
				return this;
			}
			ActivityActionBase activityActionBase = ActivityActionFactory.Instance.Create(type, parameters);
			if (activityActionBase != null)
			{
				this.Pending.Push(activityActionBase);
			}
			return this;
		}

		// Token: 0x06039280 RID: 234112 RVA: 0x010016B4 File Offset: 0x00FFF8B4
		internal unsafe void Tick(float delta)
		{
			if (this.Disposed)
			{
				return;
			}
			if (this.Current == null && !this.TryStartNext())
			{
				return;
			}
			ActivityActionBase current = this.Current;
			current.Tick(delta);
			if (!current.IsDone())
			{
				return;
			}
			bool flag = current.IsFailed();
			current.Finish();
			this.Current = null;
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ActivityActionExecuteHandler action 执行失败，中断队列后续条目";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Uid", current.Uid);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionId", current.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Type", current.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("DroppedPending", this.Pending.Size);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				this.ClearPending();
				this.NotifyWorkFinished();
				return;
			}
			if (!this.TryStartNext())
			{
				this.NotifyWorkFinished();
			}
		}

		// Token: 0x06039281 RID: 234113 RVA: 0x010017D8 File Offset: 0x00FFF9D8
		private void NotifyWorkFinished()
		{
			if (this.Disposed || this.HasWork)
			{
				return;
			}
			Action workFinishedCallback = this.WorkFinishedCallback;
			if (workFinishedCallback == null)
			{
				return;
			}
			workFinishedCallback();
		}

		// Token: 0x06039282 RID: 234114 RVA: 0x010017FC File Offset: 0x00FFF9FC
		private bool TryStartNext()
		{
			if (this.Pending.Empty)
			{
				return false;
			}
			this.Current = this.Pending.Pop();
			ActivityActionBase current = this.Current;
			if (current != null)
			{
				current.Start();
			}
			return !this.Disposed && this.Current != null;
		}

		// Token: 0x06039283 RID: 234115 RVA: 0x01001850 File Offset: 0x00FFFA50
		private void ClearPending()
		{
			while (!this.Pending.Empty)
			{
				ActivityActionBase activityActionBase = this.Pending.Pop();
				if (activityActionBase != null && !activityActionBase.IsDone())
				{
					activityActionBase.Delete();
				}
			}
		}

		// Token: 0x06039284 RID: 234116 RVA: 0x0100188C File Offset: 0x00FFFA8C
		public void Dispose()
		{
			if (this.Disposed)
			{
				return;
			}
			this.Disposed = true;
			this.WorkFinishedCallback = null;
			if (this.Current != null)
			{
				if (!this.Current.IsDone())
				{
					this.Current.Delete();
				}
				this.Current = null;
			}
			this.ClearPending();
			ActivityActionModel.Instance.Release(this);
		}

		// Token: 0x0401E116 RID: 123158
		private readonly Queue<ActivityActionBase> Pending = new Queue<ActivityActionBase>(4);

		// Token: 0x0401E117 RID: 123159
		[Nullable(2)]
		private ActivityActionBase Current;

		// Token: 0x0401E118 RID: 123160
		private bool Disposed;

		// Token: 0x0401E119 RID: 123161
		[Nullable(2)]
		private Action WorkFinishedCallback;
	}
}
