using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x02006F74 RID: 28532
	public class LevelFlowConditionBase
	{
		// Token: 0x06045689 RID: 284297 RVA: 0x01134749 File Offset: 0x01132949
		public void Enter()
		{
			this.IsFinished = false;
			this.OnEnter();
		}

		// Token: 0x0604568A RID: 284298 RVA: 0x01134758 File Offset: 0x01132958
		public void Exit()
		{
			this.OnExit();
			this.IsFinished = true;
		}

		// Token: 0x0604568B RID: 284299 RVA: 0x01134767 File Offset: 0x01132967
		public void Tick(float delta)
		{
			if (this.IsFinished)
			{
				return;
			}
			this.OnTick(delta);
		}

		// Token: 0x0604568C RID: 284300 RVA: 0x01134779 File Offset: 0x01132979
		public void Reset()
		{
			this.IsFinished = false;
			this.OnReset();
		}

		// Token: 0x0604568D RID: 284301 RVA: 0x01134788 File Offset: 0x01132988
		protected void FinishExecute(bool isSuccess)
		{
			this.Exit();
			this.CompleteCallBack(isSuccess);
		}

		// Token: 0x0604568E RID: 284302 RVA: 0x0113479C File Offset: 0x0113299C
		[NullableContext(1)]
		public void BindCompleteCallBack(Action<bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x0604568F RID: 284303 RVA: 0x011347A5 File Offset: 0x011329A5
		protected virtual void OnEnter()
		{
		}

		// Token: 0x06045690 RID: 284304 RVA: 0x011347A7 File Offset: 0x011329A7
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06045691 RID: 284305 RVA: 0x011347A9 File Offset: 0x011329A9
		protected virtual void OnExit()
		{
		}

		// Token: 0x06045692 RID: 284306 RVA: 0x011347AB File Offset: 0x011329AB
		protected virtual void OnReset()
		{
		}

		// Token: 0x04024384 RID: 148356
		private bool IsFinished;

		// Token: 0x04024385 RID: 148357
		[Nullable(2)]
		private Action<bool> CompleteCallBack;
	}
}
