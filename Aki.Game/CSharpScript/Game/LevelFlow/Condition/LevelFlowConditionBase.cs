using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x020060F5 RID: 24821
	public class LevelFlowConditionBase
	{
		// Token: 0x0603B837 RID: 243767 RVA: 0x010DE54D File Offset: 0x010DC74D
		public void Enter()
		{
			this.IsFinished = false;
			this.OnEnter();
		}

		// Token: 0x0603B838 RID: 243768 RVA: 0x010DE55C File Offset: 0x010DC75C
		public void Exit()
		{
			this.OnExit();
			this.IsFinished = true;
		}

		// Token: 0x0603B839 RID: 243769 RVA: 0x010DE56B File Offset: 0x010DC76B
		public void Tick(float delta)
		{
			if (this.IsFinished)
			{
				return;
			}
			this.OnTick(delta);
		}

		// Token: 0x0603B83A RID: 243770 RVA: 0x010DE57D File Offset: 0x010DC77D
		public void Reset()
		{
			this.IsFinished = false;
			this.OnReset();
		}

		// Token: 0x0603B83B RID: 243771 RVA: 0x010DE58C File Offset: 0x010DC78C
		protected void FinishExecute(bool isSuccess)
		{
			this.Exit();
			this.CompleteCallBack(isSuccess);
		}

		// Token: 0x0603B83C RID: 243772 RVA: 0x010DE5A0 File Offset: 0x010DC7A0
		[NullableContext(1)]
		public void BindCompleteCallBack(Action<bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x0603B83D RID: 243773 RVA: 0x010DE5A9 File Offset: 0x010DC7A9
		protected virtual void OnEnter()
		{
		}

		// Token: 0x0603B83E RID: 243774 RVA: 0x010DE5AB File Offset: 0x010DC7AB
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x0603B83F RID: 243775 RVA: 0x010DE5AD File Offset: 0x010DC7AD
		protected virtual void OnExit()
		{
		}

		// Token: 0x0603B840 RID: 243776 RVA: 0x010DE5AF File Offset: 0x010DC7AF
		protected virtual void OnReset()
		{
		}

		// Token: 0x0401F639 RID: 128569
		private bool IsFinished;

		// Token: 0x0401F63A RID: 128570
		[Nullable(2)]
		private Action<bool> CompleteCallBack;
	}
}
