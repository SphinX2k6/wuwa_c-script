using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02005024 RID: 20516
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteLongPress : SequenceQteHandleBase<CommonQteLongPressContext>
	{
		// Token: 0x0603482D RID: 215085 RVA: 0x00C5EFE3 File Offset: 0x00C5D1E3
		public SequenceQteLongPress(SequenceQteManager qteManager, CommonQteLongPressContext context) : base(qteManager, context)
		{
		}

		// Token: 0x0603482E RID: 215086 RVA: 0x00C5EFED File Offset: 0x00C5D1ED
		public override void OnBegin()
		{
			base.OnBegin();
			this.MarkSequenceQtePending = true;
		}

		// Token: 0x0603482F RID: 215087 RVA: 0x00C5EFFC File Offset: 0x00C5D1FC
		protected override void OnReceiveTick(float delta)
		{
			this.Progress = MathUtils.Instance.Clamp(this.Context.CurrentProgress * 0.01f, 0f, 1f);
		}
	}
}
