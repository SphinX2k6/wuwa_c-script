using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F96 RID: 28566
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowQteAction : LevelFlowActionBase
	{
		// Token: 0x0604574D RID: 284493 RVA: 0x0113A3B3 File Offset: 0x011385B3
		[return: Nullable(1)]
		public LevelFlowQteAction Init(int qteId, LevelFlowActionBase successSequenceAction, LevelFlowActionBase failSequenceAction)
		{
			this.QteId = qteId;
			this.SuccessSequenceAction = successSequenceAction;
			this.FailSequenceAction = failSequenceAction;
			return this;
		}

		// Token: 0x0604574E RID: 284494 RVA: 0x0113A3CC File Offset: 0x011385CC
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

		// Token: 0x0604574F RID: 284495 RVA: 0x0113A440 File Offset: 0x01138640
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

		// Token: 0x06045750 RID: 284496 RVA: 0x0113A47C File Offset: 0x0113867C
		protected override void OnComplete(bool isSuccess)
		{
			this.IsQteFinished = false;
			this.IsQteSuccess = false;
			this.ActiveQteContext = null;
		}

		// Token: 0x06045751 RID: 284497 RVA: 0x0113A494 File Offset: 0x01138694
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

		// Token: 0x06045752 RID: 284498 RVA: 0x0113A508 File Offset: 0x01138708
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

		// Token: 0x06045753 RID: 284499 RVA: 0x0113A57B File Offset: 0x0113877B
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

		// Token: 0x06045754 RID: 284500 RVA: 0x0113A59E File Offset: 0x0113879E
		[NullableContext(1)]
		private void OnSuccessActionComplete(LevelFlowActionBase section, bool isSuccess)
		{
			base.FinishExecute(isSuccess);
		}

		// Token: 0x06045755 RID: 284501 RVA: 0x0113A5A7 File Offset: 0x011387A7
		[NullableContext(1)]
		private void OnFailActionComplete(LevelFlowActionBase section, bool isSuccess)
		{
			base.FinishExecute(isSuccess);
		}

		// Token: 0x040243DC RID: 148444
		private int QteId;

		// Token: 0x040243DD RID: 148445
		private bool IsQteFinished;

		// Token: 0x040243DE RID: 148446
		private bool IsQteSuccess;

		// Token: 0x040243DF RID: 148447
		private CommonQteContextBase ActiveQteContext;

		// Token: 0x040243E0 RID: 148448
		private LevelFlowActionBase SuccessSequenceAction;

		// Token: 0x040243E1 RID: 148449
		private LevelFlowActionBase FailSequenceAction;
	}
}
