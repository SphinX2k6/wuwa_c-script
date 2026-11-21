using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FF0 RID: 16368
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteSelectOption : SequenceQteHandleBase<CommonQteSelectOptionContext>
	{
		// Token: 0x060296EB RID: 169707 RVA: 0x00BAB1A0 File Offset: 0x00BA93A0
		public SequenceQteSelectOption(SequenceQteManager qteManager, CommonQteSelectOptionContext context) : base(qteManager, context)
		{
		}

		// Token: 0x060296EC RID: 169708 RVA: 0x00BAB1AA File Offset: 0x00BA93AA
		protected override void OnCommonQteFinished()
		{
			base.OptionIndex = this.Context.SelectOption;
			base.OnCommonQteFinished();
		}
	}
}
