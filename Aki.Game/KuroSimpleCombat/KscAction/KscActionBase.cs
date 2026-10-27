using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x020044E1 RID: 17633
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class KscActionBase
	{
		// Token: 0x0602D6CC RID: 186060 RVA: 0x00A40B1B File Offset: 0x00A3ED1B
		public KscActionBase(long entityId)
		{
			this.EntityId = entityId;
			this.KscCtrl = KuroSimpleCombatController.Instance;
		}

		// Token: 0x170073AA RID: 29610
		// (get) Token: 0x0602D6CD RID: 186061 RVA: 0x00A40B38 File Offset: 0x00A3ED38
		public string Name
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("KscAction_[");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.EntityId);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x0602D6CE RID: 186062 RVA: 0x00A40B7C File Offset: 0x00A3ED7C
		public UniTask Run()
		{
			KscActionBase.<Run>d__8 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<KscActionBase.<Run>d__8>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6CF RID: 186063 RVA: 0x00A40BBF File Offset: 0x00A3EDBF
		public void Cancel()
		{
			this.IsCancel = true;
			this.CancelContent();
		}

		// Token: 0x0602D6D0 RID: 186064 RVA: 0x00A40BCE File Offset: 0x00A3EDCE
		protected void SetResult()
		{
			UniTaskCompletionSource promiseInternal = this.PromiseInternal;
			if (promiseInternal == null)
			{
				return;
			}
			promiseInternal.TrySetResult();
		}

		// Token: 0x170073AB RID: 29611
		// (get) Token: 0x0602D6D1 RID: 186065 RVA: 0x00A40BE1 File Offset: 0x00A3EDE1
		public UiAsyncTask Task
		{
			get
			{
				if (this.TaskInternal == null)
				{
					this.TaskInternal = new UiAsyncTask(this.Name, new Func<UniTask>(this.Run), new Action(this.Cancel));
				}
				return this.TaskInternal;
			}
		}

		// Token: 0x0602D6D2 RID: 186066 RVA: 0x00A40C1C File Offset: 0x00A3EE1C
		public string LogInfo()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendFormatted(base.GetType().Name);
			defaultInterpolatedStringHandler.AppendLiteral("[S: ");
			UiAsyncTask taskInternal = this.TaskInternal;
			defaultInterpolatedStringHandler.AppendFormatted<EUiAsyncTaskStatus?>((taskInternal != null) ? new EUiAsyncTaskStatus?(taskInternal.Status) : null);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602D6D3 RID: 186067 RVA: 0x00A40C89 File Offset: 0x00A3EE89
		[Conditional("DEBUG")]
		protected void Debug(KscLog.EModule flag, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0602D6D4 RID: 186068 RVA: 0x00A40C8B File Offset: 0x00A3EE8B
		protected void Info(KscLog.EModule flag, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			KscLog.Info(flag, ELogAuthor.CX, KscEnv.Instance.KscWorld, log, pairs);
		}

		// Token: 0x0602D6D5 RID: 186069 RVA: 0x00A40CA1 File Offset: 0x00A3EEA1
		protected void Warn(KscLog.EModule flag, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			KscLog.Warn(flag, ELogAuthor.CX, KscEnv.Instance.KscWorld, log, pairs);
		}

		// Token: 0x0602D6D6 RID: 186070 RVA: 0x00A40CB7 File Offset: 0x00A3EEB7
		protected void Error(KscLog.EModule flag, string log, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			KscLog.Error(flag, ELogAuthor.CX, KscEnv.Instance.KscWorld, log, pairs);
		}

		// Token: 0x0602D6D7 RID: 186071
		protected abstract UniTask RunContent();

		// Token: 0x0602D6D8 RID: 186072 RVA: 0x00A40CCD File Offset: 0x00A3EECD
		protected virtual void CancelContent()
		{
		}

		// Token: 0x040184A8 RID: 99496
		public long EntityId;

		// Token: 0x040184A9 RID: 99497
		[Nullable(2)]
		protected UniTaskCompletionSource PromiseInternal;

		// Token: 0x040184AA RID: 99498
		protected bool IsCancel;

		// Token: 0x040184AB RID: 99499
		[Nullable(2)]
		protected UiAsyncTask TaskInternal;

		// Token: 0x040184AC RID: 99500
		protected KuroSimpleCombatController KscCtrl;
	}
}
