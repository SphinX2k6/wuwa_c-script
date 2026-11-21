using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007718 RID: 30488
	public class ISelfClientEventT
	{
		// Token: 0x1700DF93 RID: 57235
		// (get) Token: 0x060357E5 RID: 219109 RVA: 0x0072BFEA File Offset: 0x0072A1EA
		// (set) Token: 0x060357E6 RID: 219110 RVA: 0x0072BFF2 File Offset: 0x0072A1F2
		public EClientEventTarget Type { get; set; }

		// Token: 0x060357E7 RID: 219111 RVA: 0x0072BFFB File Offset: 0x0072A1FB
		public ISelfClientEventT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
