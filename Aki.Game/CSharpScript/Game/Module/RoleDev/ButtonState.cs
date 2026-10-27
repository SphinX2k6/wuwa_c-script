using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CCF RID: 19663
	[NullableContext(1)]
	[Nullable(0)]
	public class ButtonState : IButtonState
	{
		// Token: 0x17007D75 RID: 32117
		// (get) Token: 0x06032C35 RID: 207925 RVA: 0x00BD540C File Offset: 0x00BD360C
		// (set) Token: 0x06032C36 RID: 207926 RVA: 0x00BD5414 File Offset: 0x00BD3614
		public string Text { get; set; }

		// Token: 0x17007D76 RID: 32118
		// (get) Token: 0x06032C37 RID: 207927 RVA: 0x00BD541D File Offset: 0x00BD361D
		// (set) Token: 0x06032C38 RID: 207928 RVA: 0x00BD5425 File Offset: 0x00BD3625
		public bool IsHighlight { get; set; }
	}
}
