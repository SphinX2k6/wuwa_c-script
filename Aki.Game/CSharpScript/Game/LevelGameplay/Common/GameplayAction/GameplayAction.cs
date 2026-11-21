using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x020060A3 RID: 24739
	public abstract class GameplayAction
	{
		// Token: 0x1700704B RID: 28747
		// (get) Token: 0x0603B564 RID: 243044 RVA: 0x010CBC3A File Offset: 0x010C9E3A
		protected virtual bool NeedTickInner
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0603B565 RID: 243045 RVA: 0x010CBC3D File Offset: 0x010C9E3D
		[NullableContext(1)]
		public void ExecuteAction(Action onFinish)
		{
			this.OnActionFinish = onFinish;
			this.OnExecuteAction();
		}

		// Token: 0x0603B566 RID: 243046 RVA: 0x010CBC4C File Offset: 0x010C9E4C
		public bool IsFinish()
		{
			return this.IsFinishInner;
		}

		// Token: 0x0603B567 RID: 243047 RVA: 0x010CBC54 File Offset: 0x010C9E54
		public bool IsLoop()
		{
			return this.IsLoopInner;
		}

		// Token: 0x0603B568 RID: 243048 RVA: 0x010CBC5C File Offset: 0x010C9E5C
		public bool NeedTick()
		{
			return this.NeedTickInner;
		}

		// Token: 0x0603B569 RID: 243049 RVA: 0x010CBC64 File Offset: 0x010C9E64
		public virtual void TickAction(float delta)
		{
		}

		// Token: 0x0603B56A RID: 243050 RVA: 0x010CBC66 File Offset: 0x010C9E66
		public void InterruptAction()
		{
			this.OnInterruptAction();
			this.IsFinishInner = true;
		}

		// Token: 0x0603B56B RID: 243051
		protected abstract void OnExecuteAction();

		// Token: 0x0603B56C RID: 243052
		protected abstract void OnInterruptAction();

		// Token: 0x0603B56D RID: 243053 RVA: 0x010CBC75 File Offset: 0x010C9E75
		protected void FinishExecute()
		{
			this.IsFinishInner = true;
			Action onActionFinish = this.OnActionFinish;
			if (onActionFinish == null)
			{
				return;
			}
			onActionFinish();
		}

		// Token: 0x0401F43E RID: 128062
		protected bool IsLoopInner;

		// Token: 0x0401F43F RID: 128063
		private bool IsFinishInner;

		// Token: 0x0401F440 RID: 128064
		[Nullable(2)]
		private Action OnActionFinish;
	}
}
