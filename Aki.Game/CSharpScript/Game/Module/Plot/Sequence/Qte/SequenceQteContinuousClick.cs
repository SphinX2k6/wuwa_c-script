using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x0200501B RID: 20507
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteContinuousClick : SequenceQteHandleBase<CommonQteContinuousClickContext>
	{
		// Token: 0x060347C8 RID: 214984 RVA: 0x00C5D122 File Offset: 0x00C5B322
		public SequenceQteContinuousClick(SequenceQteManager qteManager, CommonQteContinuousClickContext context) : base(qteManager, context)
		{
		}

		// Token: 0x060347C9 RID: 214985 RVA: 0x00C5D12C File Offset: 0x00C5B32C
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

		// Token: 0x060347CA RID: 214986 RVA: 0x00C5D164 File Offset: 0x00C5B364
		protected override void OnReceiveTick(float delta)
		{
			this.Progress = MathUtils.Instance.Clamp(this.Context.CurrentEnergyPercent * 0.01f, 0f, 1f);
		}
	}
}
