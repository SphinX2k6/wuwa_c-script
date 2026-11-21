using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Dialogue
{
	// Token: 0x02004A9F RID: 19103
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DialogueOption
	{
		// Token: 0x17005FF9 RID: 24569
		// (get) Token: 0x0602FCCA RID: 195786 RVA: 0x00D560D4 File Offset: 0x00D542D4
		public int Index { get; }

		// Token: 0x17005FFA RID: 24570
		// (get) Token: 0x0602FCCB RID: 195787 RVA: 0x00D560DC File Offset: 0x00D542DC
		public ITalkOption Config { get; }

		// Token: 0x17005FFB RID: 24571
		// (get) Token: 0x0602FCCC RID: 195788 RVA: 0x00D560E4 File Offset: 0x00D542E4
		public DialogueJump? Jump { get; }

		// Token: 0x0602FCCD RID: 195789 RVA: 0x00D560EC File Offset: 0x00D542EC
		public DialogueOption(int index, ITalkOption config)
		{
			this.Index = index;
			this.Config = config;
			this.Jump = DialogueJump.From(config.Actions);
		}
	}
}
