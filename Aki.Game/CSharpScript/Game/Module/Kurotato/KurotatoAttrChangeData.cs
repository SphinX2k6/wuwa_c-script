using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046E8 RID: 18152
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrChangeData : IKurotatoAttrChangeData
	{
		// Token: 0x17005C16 RID: 23574
		// (get) Token: 0x0602D99A RID: 186778 RVA: 0x00CBEF33 File Offset: 0x00CBD133
		// (set) Token: 0x0602D99B RID: 186779 RVA: 0x00CBEF3B File Offset: 0x00CBD13B
		public string Text { get; set; }

		// Token: 0x17005C17 RID: 23575
		// (get) Token: 0x0602D99C RID: 186780 RVA: 0x00CBEF44 File Offset: 0x00CBD144
		// (set) Token: 0x0602D99D RID: 186781 RVA: 0x00CBEF4C File Offset: 0x00CBD14C
		public string IconPath { get; set; }
	}
}
