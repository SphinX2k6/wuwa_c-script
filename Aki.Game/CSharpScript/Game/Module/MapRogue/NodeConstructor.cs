using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200459B RID: 17819
	[NullableContext(1)]
	[Nullable(0)]
	public class NodeConstructor : INodeConstructor
	{
		// Token: 0x17005AA9 RID: 23209
		// (get) Token: 0x0602CE78 RID: 183928 RVA: 0x00C9017D File Offset: 0x00C8E37D
		// (set) Token: 0x0602CE79 RID: 183929 RVA: 0x00C90185 File Offset: 0x00C8E385
		public int GridId { get; set; }

		// Token: 0x17005AAA RID: 23210
		// (get) Token: 0x0602CE7A RID: 183930 RVA: 0x00C9018E File Offset: 0x00C8E38E
		// (set) Token: 0x0602CE7B RID: 183931 RVA: 0x00C90196 File Offset: 0x00C8E396
		public IPos Position { get; set; }

		// Token: 0x17005AAB RID: 23211
		// (get) Token: 0x0602CE7C RID: 183932 RVA: 0x00C9019F File Offset: 0x00C8E39F
		// (set) Token: 0x0602CE7D RID: 183933 RVA: 0x00C901A7 File Offset: 0x00C8E3A7
		public int Cost { get; set; }

		// Token: 0x17005AAC RID: 23212
		// (get) Token: 0x0602CE7E RID: 183934 RVA: 0x00C901B0 File Offset: 0x00C8E3B0
		// (set) Token: 0x0602CE7F RID: 183935 RVA: 0x00C901B8 File Offset: 0x00C8E3B8
		public bool Walkable { get; set; }
	}
}
