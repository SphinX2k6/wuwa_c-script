using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200584F RID: 22607
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InteractConfirmActionBase
	{
		// Token: 0x06039774 RID: 235380 RVA: 0x00DA4550 File Offset: 0x00DA2750
		public bool Execute(InteractSecondConfirmContext context)
		{
			this.Context = context;
			return this.OnExecute(context);
		}

		// Token: 0x06039775 RID: 235381 RVA: 0x00DA4560 File Offset: 0x00DA2760
		public void Cancel()
		{
			this.OnCancel();
			this.Clear();
		}

		// Token: 0x06039776 RID: 235382 RVA: 0x00DA456E File Offset: 0x00DA276E
		public void Clear()
		{
			this.Context = null;
			this.OnClear();
		}

		// Token: 0x06039777 RID: 235383 RVA: 0x00DA457D File Offset: 0x00DA277D
		protected virtual bool OnExecute(InteractSecondConfirmContext context)
		{
			return true;
		}

		// Token: 0x06039778 RID: 235384 RVA: 0x00DA4580 File Offset: 0x00DA2780
		protected virtual void OnCancel()
		{
		}

		// Token: 0x06039779 RID: 235385 RVA: 0x00DA4582 File Offset: 0x00DA2782
		protected virtual void OnClear()
		{
		}

		// Token: 0x0603977A RID: 235386 RVA: 0x00DA4584 File Offset: 0x00DA2784
		protected void ExecuteFinish(bool confirmResult)
		{
			if (this.Context == null)
			{
				return;
			}
			if (this.Context.ConfirmCallback != null)
			{
				this.Context.ConfirmCallback(this.Context.Handle, confirmResult, this.Context.Option);
			}
			this.Clear();
		}

		// Token: 0x0401E0D9 RID: 123097
		[Nullable(2)]
		protected InteractSecondConfirmContext Context;
	}
}
