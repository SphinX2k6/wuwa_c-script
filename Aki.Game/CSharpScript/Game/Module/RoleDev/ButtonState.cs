using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C80 RID: 15488
	[NullableContext(1)]
	[Nullable(0)]
	public class ButtonState : IButtonState
	{
		// Token: 0x1700511F RID: 20767
		// (get) Token: 0x060279E9 RID: 162281 RVA: 0x00B1A1A4 File Offset: 0x00B183A4
		// (set) Token: 0x060279EA RID: 162282 RVA: 0x00B1A1AC File Offset: 0x00B183AC
		public string Text { get; set; }

		// Token: 0x17005120 RID: 20768
		// (get) Token: 0x060279EB RID: 162283 RVA: 0x00B1A1B5 File Offset: 0x00B183B5
		// (set) Token: 0x060279EC RID: 162284 RVA: 0x00B1A1BD File Offset: 0x00B183BD
		public bool IsHighlight { get; set; }
	}
}
