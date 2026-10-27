using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02005026 RID: 20518
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteSelectOption : SequenceQteHandleBase<CommonQteSelectOptionContext>
	{
		// Token: 0x06034848 RID: 215112 RVA: 0x00C5FC28 File Offset: 0x00C5DE28
		public SequenceQteSelectOption(SequenceQteManager qteManager, CommonQteSelectOptionContext context) : base(qteManager, context)
		{
		}

		// Token: 0x06034849 RID: 215113 RVA: 0x00C5FC32 File Offset: 0x00C5DE32
		protected override void OnCommonQteFinished()
		{
			base.OptionIndex = this.Context.SelectOption;
			base.OnCommonQteFinished();
		}
	}
}
