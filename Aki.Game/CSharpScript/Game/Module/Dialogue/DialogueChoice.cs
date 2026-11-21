using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Dialogue
{
	// Token: 0x02004A9C RID: 19100
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct DialogueChoice
	{
		// Token: 0x17005FF0 RID: 24560
		// (get) Token: 0x0602FCBC RID: 195772 RVA: 0x00D55EFC File Offset: 0x00D540FC
		public DialogueItem Item { get; }

		// Token: 0x17005FF1 RID: 24561
		// (get) Token: 0x0602FCBD RID: 195773 RVA: 0x00D55F04 File Offset: 0x00D54104
		public DialogueOption Option { get; }

		// Token: 0x0602FCBE RID: 195774 RVA: 0x00D55F0C File Offset: 0x00D5410C
		public DialogueChoice(DialogueItem item, DialogueOption option)
		{
			this.Item = item;
			this.Option = option;
		}
	}
}
