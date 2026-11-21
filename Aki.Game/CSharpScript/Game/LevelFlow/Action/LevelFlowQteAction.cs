using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006117 RID: 24855
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowQteAction : LevelFlowActionBase
	{
		// Token: 0x0603B8FB RID: 243963 RVA: 0x010E41B7 File Offset: 0x010E23B7
		[return: Nullable(1)]
		public LevelFlowQteAction Init(int qteId, LevelFlowActionBase successSequenceAction, LevelFlowActionBase failSequenceAction)
		{
			this.QteId = qteId;
			this.SuccessSequenceAction = successSequenceAction;
			this.FailSequenceAction = failSequenceAction;
			return this;
		}

		// Token: 0x0603B8FC RID: 243964 RVA: 0x010E41D0 File Offset: 0x010E23D0
		protected override void OnExecute()
		{
			CommonQteContextBase activeQteContext = this.ActiveQteContext;
			if (activeQteContext != null && activeQteContext.IsActive())
			{
				CommonQteController.Instance.StopQte(this.ActiveQteContext.HandleId);
			}
			this.IsQteFinished = false;
			this.IsQteSuccess = false;
			this.ActiveQteContext = CommonQteController.Instance.StartQte(this.QteId, new TCommonQteCallback(this.OnQteSuccess), new TCommonQteCallback(this.OnQteFailed), EQteSource.Level, null);
		}

		// Token: 0x0603B8FD RID: 243965 RVA: 0x010E4244 File Offset: 0x010E2444
		protected override void OnTick(float deltaTime)
		{
			if (!this.IsQteFinished)
			{
				return;
			}
			if (this.IsQteSuccess)
			{
				if (this.SuccessSequenceAction != null)
				{
					this.SuccessSequenceAction.Tick(deltaTime);
					return;
				}
			}
			else if (this.FailSequenceAction != null)
			{
				this.FailSequenceAction.Tick(deltaTime);
			}
		}

		// Token: 0x0603B8FE RID: 243966 RVA: 0x010E4280 File Offset: 0x010E2480
		protected override void OnComplete(bool isSuccess)
		{
			this.IsQteFinished = false;
			this.IsQteSuccess = false;
			this.ActiveQteContext = null;
		}

		// Token: 0x0603B8FF RID: 243967 RVA: 0x010E4298 File Offset: 0x010E2498
		private void OnQteSuccess(CommonQteContextBase context)
		{
			Log.Instance.Info(ELogModule.LevelFlow, ELogAuthor.BB, "Qte成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsQteFinished = true;
			this.IsQteSuccess = true;
			this.ActiveQteContext = null;
			if (this.SuccessSequenceAction != null)
			{
				this.SuccessSequenceAction.BindCompleteCallBack(new Action<LevelFlowActionBase, bool>(this.OnSuccessActionComplete));
				this.SuccessSequenceAction.Execute();
				return;
			}
			base.FinishExecute(true);
		}

		// Token: 0x0603B900 RID: 243968 RVA: 0x010E430C File Offset: 0x010E250C
		private void OnQteFailed(CommonQteContextBase context)
		{
			Log.Instance.Info(ELogModule.LevelFlow, ELogAuthor.BB, "Qte失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsQteFinished = true;
			this.IsQteSuccess = false;
			this.ActiveQteContext = null;
			if (this.FailSequenceAction != null)
			{
				this.FailSequenceAction.BindCompleteCallBack(new Action<LevelFlowActionBase, bool>(this.OnFailActionComplete));
				this.FailSequenceAction.Execute();
				return;
			}
			base.FinishExecute(true);
		}

		// Token: 0x0603B901 RID: 243969 RVA: 0x010E437F File Offset: 0x010E257F
		protected override void OnReset()
		{
			LevelFlowActionBase successSequenceAction = this.SuccessSequenceAction;
			if (successSequenceAction != null)
			{
				successSequenceAction.Reset();
			}
			LevelFlowActionBase failSequenceAction = this.FailSequenceAction;
			if (failSequenceAction == null)
			{
				return;
			}
			failSequenceAction.Reset();
		}

		// Token: 0x0603B902 RID: 243970 RVA: 0x010E43A2 File Offset: 0x010E25A2
		[NullableContext(1)]
		private void OnSuccessActionComplete(LevelFlowActionBase section, bool isSuccess)
		{
			base.FinishExecute(isSuccess);
		}

		// Token: 0x0603B903 RID: 243971 RVA: 0x010E43AB File Offset: 0x010E25AB
		[NullableContext(1)]
		private void OnFailActionComplete(LevelFlowActionBase section, bool isSuccess)
		{
			base.FinishExecute(isSuccess);
		}

		// Token: 0x0401F691 RID: 128657
		private int QteId;

		// Token: 0x0401F692 RID: 128658
		private bool IsQteFinished;

		// Token: 0x0401F693 RID: 128659
		private bool IsQteSuccess;

		// Token: 0x0401F694 RID: 128660
		private CommonQteContextBase ActiveQteContext;

		// Token: 0x0401F695 RID: 128661
		private LevelFlowActionBase SuccessSequenceAction;

		// Token: 0x0401F696 RID: 128662
		private LevelFlowActionBase FailSequenceAction;
	}
}
