using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FE5 RID: 16357
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteContinuousClick : SequenceQteHandleBase<CommonQteContinuousClickContext>
	{
		// Token: 0x0602966B RID: 169579 RVA: 0x00BA866E File Offset: 0x00BA686E
		public SequenceQteContinuousClick(SequenceQteManager qteManager, CommonQteContinuousClickContext context) : base(qteManager, context)
		{
		}

		// Token: 0x0602966C RID: 169580 RVA: 0x00BA8678 File Offset: 0x00BA6878
		public override void OnBegin()
		{
			base.OnBegin();
			this.MarkSequenceQtePending = true;
			if (this.Context.EnergyInterpSpeedPerMs > 0f)
			{
				this.TickInterval = 0f;
				return;
			}
			this.TickInterval = 200f;
		}

		// Token: 0x0602966D RID: 169581 RVA: 0x00BA86B0 File Offset: 0x00BA68B0
		protected override void OnReceiveTick(float delta)
		{
			this.Progress = MathUtils.Instance.Clamp(this.Context.CurrentEnergyPercent * 0.01f, 0f, 1f);
		}
	}
}
