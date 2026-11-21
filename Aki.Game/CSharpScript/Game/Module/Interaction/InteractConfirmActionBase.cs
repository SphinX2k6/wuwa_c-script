using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004827 RID: 18471
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InteractConfirmActionBase
	{
		// Token: 0x0602E690 RID: 190096 RVA: 0x00CF3210 File Offset: 0x00CF1410
		public bool Execute(InteractSecondConfirmContext context)
		{
			this.Context = context;
			return this.OnExecute(context);
		}

		// Token: 0x0602E691 RID: 190097 RVA: 0x00CF3220 File Offset: 0x00CF1420
		public void Cancel()
		{
			this.OnCancel();
			this.Clear();
		}

		// Token: 0x0602E692 RID: 190098 RVA: 0x00CF322E File Offset: 0x00CF142E
		public void Clear()
		{
			this.Context = null;
			this.OnClear();
		}

		// Token: 0x0602E693 RID: 190099 RVA: 0x00CF323D File Offset: 0x00CF143D
		protected virtual bool OnExecute(InteractSecondConfirmContext context)
		{
			return true;
		}

		// Token: 0x0602E694 RID: 190100 RVA: 0x00CF3240 File Offset: 0x00CF1440
		protected virtual void OnCancel()
		{
		}

		// Token: 0x0602E695 RID: 190101 RVA: 0x00CF3242 File Offset: 0x00CF1442
		protected virtual void OnClear()
		{
		}

		// Token: 0x0602E696 RID: 190102 RVA: 0x00CF3244 File Offset: 0x00CF1444
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

		// Token: 0x04018B76 RID: 101238
		[Nullable(2)]
		protected InteractSecondConfirmContext Context;
	}
}
