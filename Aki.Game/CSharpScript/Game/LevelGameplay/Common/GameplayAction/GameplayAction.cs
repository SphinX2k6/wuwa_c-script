using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction
{
	// Token: 0x02006F22 RID: 28450
	public abstract class GameplayAction
	{
		// Token: 0x17009B0C RID: 39692
		// (get) Token: 0x060453B6 RID: 283574 RVA: 0x01121C8E File Offset: 0x0111FE8E
		protected virtual bool NeedTickInner
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060453B7 RID: 283575 RVA: 0x01121C91 File Offset: 0x0111FE91
		[NullableContext(1)]
		public void ExecuteAction(Action onFinish)
		{
			this.OnActionFinish = onFinish;
			this.OnExecuteAction();
		}

		// Token: 0x060453B8 RID: 283576 RVA: 0x01121CA0 File Offset: 0x0111FEA0
		public bool IsFinish()
		{
			return this.IsFinishInner;
		}

		// Token: 0x060453B9 RID: 283577 RVA: 0x01121CA8 File Offset: 0x0111FEA8
		public bool IsLoop()
		{
			return this.IsLoopInner;
		}

		// Token: 0x060453BA RID: 283578 RVA: 0x01121CB0 File Offset: 0x0111FEB0
		public bool NeedTick()
		{
			return this.NeedTickInner;
		}

		// Token: 0x060453BB RID: 283579 RVA: 0x01121CB8 File Offset: 0x0111FEB8
		public virtual void TickAction(float delta)
		{
		}

		// Token: 0x060453BC RID: 283580 RVA: 0x01121CBA File Offset: 0x0111FEBA
		public void InterruptAction()
		{
			this.OnInterruptAction();
			this.IsFinishInner = true;
		}

		// Token: 0x060453BD RID: 283581
		protected abstract void OnExecuteAction();

		// Token: 0x060453BE RID: 283582
		protected abstract void OnInterruptAction();

		// Token: 0x060453BF RID: 283583 RVA: 0x01121CC9 File Offset: 0x0111FEC9
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

		// Token: 0x04024189 RID: 147849
		protected bool IsLoopInner;

		// Token: 0x0402418A RID: 147850
		private bool IsFinishInner;

		// Token: 0x0402418B RID: 147851
		[Nullable(2)]
		private Action OnActionFinish;
	}
}
