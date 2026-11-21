using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FEE RID: 16366
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteLongPress : SequenceQteHandleBase<CommonQteLongPressContext>
	{
		// Token: 0x060296D0 RID: 169680 RVA: 0x00BAA533 File Offset: 0x00BA8733
		public SequenceQteLongPress(SequenceQteManager qteManager, CommonQteLongPressContext context) : base(qteManager, context)
		{
		}

		// Token: 0x060296D1 RID: 169681 RVA: 0x00BAA53D File Offset: 0x00BA873D
		public override void OnBegin()
		{
			base.OnBegin();
			this.MarkSequenceQtePending = true;
		}

		// Token: 0x060296D2 RID: 169682 RVA: 0x00BAA54C File Offset: 0x00BA874C
		protected override void OnReceiveTick(float delta)
		{
			this.Progress = MathUtils.Instance.Clamp(this.Context.CurrentProgress * 0.01f, 0f, 1f);
		}
	}
}
