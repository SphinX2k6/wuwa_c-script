using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FE6 RID: 16358
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteDrag : SequenceQteHandleBase<CommonQteDragContext>
	{
		// Token: 0x0602966E RID: 169582 RVA: 0x00BA86DD File Offset: 0x00BA68DD
		public SequenceQteDrag(SequenceQteManager qteManager, CommonQteDragContext context) : base(qteManager, context)
		{
		}

		// Token: 0x0602966F RID: 169583 RVA: 0x00BA86E8 File Offset: 0x00BA68E8
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

		// Token: 0x06029670 RID: 169584 RVA: 0x00BA8739 File Offset: 0x00BA6939
		protected override void OnReceiveTick(float delta)
		{
			if (this.HasCommonQteFinished)
			{
				this.Progress = this.Context.GetSequenceResultProgress(!this.Context.IsFail());
				return;
			}
			this.Progress = this.Context.GetProgress();
		}

		// Token: 0x06029671 RID: 169585 RVA: 0x00BA8775 File Offset: 0x00BA6975
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
