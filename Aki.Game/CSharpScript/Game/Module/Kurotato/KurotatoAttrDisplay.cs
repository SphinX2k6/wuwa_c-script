using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005700 RID: 22272
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrDisplay : IKurotatoAttrDisplay
	{
		// Token: 0x1700882B RID: 34859
		// (get) Token: 0x06038A40 RID: 232000 RVA: 0x00D707F9 File Offset: 0x00D6E9F9
		// (set) Token: 0x06038A41 RID: 232001 RVA: 0x00D70801 File Offset: 0x00D6EA01
		public string Icon { get; set; }

		// Token: 0x1700882C RID: 34860
		// (get) Token: 0x06038A42 RID: 232002 RVA: 0x00D7080A File Offset: 0x00D6EA0A
		// (set) Token: 0x06038A43 RID: 232003 RVA: 0x00D70812 File Offset: 0x00D6EA12
		public string Text { get; set; }

		// Token: 0x1700882D RID: 34861
		// (get) Token: 0x06038A44 RID: 232004 RVA: 0x00D7081B File Offset: 0x00D6EA1B
		// (set) Token: 0x06038A45 RID: 232005 RVA: 0x00D70823 File Offset: 0x00D6EA23
		public int PropertyId { get; set; }
	}
}
