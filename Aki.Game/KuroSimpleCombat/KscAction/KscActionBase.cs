using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x0200302D RID: 12333
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class KscActionBase
	{
		// Token: 0x0601D416 RID: 119830 RVA: 0x008EE9B3 File Offset: 0x008ECBB3
		public KscActionBase(long entityId)
		{
			this.EntityId = entityId;
			this.KscCtrl = KuroSimpleCombatController.Instance;
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0601D417 RID: 119831 RVA: 0x008EE9D0 File Offset: 0x008ECBD0
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

		// Token: 0x0601D418 RID: 119832 RVA: 0x008EEA14 File Offset: 0x008ECC14
		public UniTask Run()
		{
			KscActionBase.<Run>d__8 <Run>d__;
			<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<KscActionBase.<Run>d__8>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0601D419 RID: 119833 RVA: 0x008EEA57 File Offset: 0x008ECC57
		public void Cancel()
		{
			this.IsCancel = true;
			this.CancelContent();
		}

		// Token: 0x0601D41A RID: 119834 RVA: 0x008EEA66 File Offset: 0x008ECC66
		protected void SetResult()
		{
			UniTaskCompletionSource promiseInternal = this.PromiseInternal;
			if (promiseInternal == null)
			{
				return;
			}
			promiseInternal.TrySetResult();
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0601D41B RID: 119835 RVA: 0x008EEA79 File Offset: 0x008ECC79
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

		// Token: 0x0601D41C RID: 119836 RVA: 0x008EEAB4 File Offset: 0x008ECCB4
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

		// Token: 0x0601D41D RID: 119837 RVA: 0x008EEB21 File Offset: 0x008ECD21
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

		// Token: 0x0601D41E RID: 119838 RVA: 0x008EEB23 File Offset: 0x008ECD23
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

		// Token: 0x0601D41F RID: 119839 RVA: 0x008EEB39 File Offset: 0x008ECD39
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

		// Token: 0x0601D420 RID: 119840 RVA: 0x008EEB4F File Offset: 0x008ECD4F
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

		// Token: 0x0601D421 RID: 119841
		protected abstract UniTask RunContent();

		// Token: 0x0601D422 RID: 119842 RVA: 0x008EEB65 File Offset: 0x008ECD65
		protected virtual void CancelContent()
		{
		}

		// Token: 0x0400F673 RID: 63091
		public long EntityId;

		// Token: 0x0400F674 RID: 63092
		[Nullable(2)]
		protected UniTaskCompletionSource PromiseInternal;

		// Token: 0x0400F675 RID: 63093
		protected bool IsCancel;

		// Token: 0x0400F676 RID: 63094
		[Nullable(2)]
		protected UiAsyncTask TaskInternal;

		// Token: 0x0400F677 RID: 63095
		protected KuroSimpleCombatController KscCtrl;
	}
}
