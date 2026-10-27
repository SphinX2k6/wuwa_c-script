using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x0200501C RID: 20508
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteDrag : SequenceQteHandleBase<CommonQteDragContext>
	{
		// Token: 0x060347CB RID: 214987 RVA: 0x00C5D191 File Offset: 0x00C5B391
		public SequenceQteDrag(SequenceQteManager qteManager, CommonQteDragContext context) : base(qteManager, context)
		{
		}

		// Token: 0x060347CC RID: 214988 RVA: 0x00C5D19C File Offset: 0x00C5B39C
		protected override void OnCommonQteFinished()
		{
			if (this.Context.IsCheckByRealInput)
			{
				bool isSuccess = this.Context.IsSuccess();
				this.Progress = this.Context.GetSequenceResultProgress(isSuccess);
				this.ProgressLerpSpeed = (float)this.Context.GetSequenceResultLerpSpeedInProgress(isSuccess);
			}
			base.OnCommonQteFinished();
		}

		// Token: 0x060347CD RID: 214989 RVA: 0x00C5D1ED File Offset: 0x00C5B3ED
		protected override void OnReceiveTick(float delta)
		{
			if (this.HasCommonQteFinished)
			{
				this.Progress = this.Context.GetSequenceResultProgress(!this.Context.IsFail());
				return;
			}
			this.Progress = this.Context.GetProgress();
		}

		// Token: 0x060347CE RID: 214990 RVA: 0x00C5D229 File Offset: 0x00C5B429
		protected override void UpdateSequenceQte(float delta)
		{
			base.UpdateSequenceQte(delta);
			if (this.HasCommonQteFinished && this.Context.GetSequenceResultProgress(!this.Context.IsFail()) <= 0f && base.CheckProgressFinish())
			{
				this.MarkSequenceQtePending = false;
			}
		}
	}
}
