using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D7 RID: 18135
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrDisplay : IKurotatoAttrDisplay
	{
		// Token: 0x17005BF3 RID: 23539
		// (get) Token: 0x0602D950 RID: 186704 RVA: 0x00CBEDE1 File Offset: 0x00CBCFE1
		// (set) Token: 0x0602D951 RID: 186705 RVA: 0x00CBEDE9 File Offset: 0x00CBCFE9
		public string Icon { get; set; }

		// Token: 0x17005BF4 RID: 23540
		// (get) Token: 0x0602D952 RID: 186706 RVA: 0x00CBEDF2 File Offset: 0x00CBCFF2
		// (set) Token: 0x0602D953 RID: 186707 RVA: 0x00CBEDFA File Offset: 0x00CBCFFA
		public string Text { get; set; }

		// Token: 0x17005BF5 RID: 23541
		// (get) Token: 0x0602D954 RID: 186708 RVA: 0x00CBEE03 File Offset: 0x00CBD003
		// (set) Token: 0x0602D955 RID: 186709 RVA: 0x00CBEE0B File Offset: 0x00CBD00B
		public int PropertyId { get; set; }
	}
}
