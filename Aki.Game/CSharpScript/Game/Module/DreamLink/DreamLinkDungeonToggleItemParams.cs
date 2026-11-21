using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A76 RID: 19062
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkDungeonToggleItemParams : IDreamLinkDungeonToggleItemParams
	{
		// Token: 0x17005FD7 RID: 24535
		// (get) Token: 0x0602FB63 RID: 195427 RVA: 0x00D4F443 File Offset: 0x00D4D643
		// (set) Token: 0x0602FB64 RID: 195428 RVA: 0x00D4F44B File Offset: 0x00D4D64B
		public string TextureBgPath { get; set; }

		// Token: 0x17005FD8 RID: 24536
		// (get) Token: 0x0602FB65 RID: 195429 RVA: 0x00D4F454 File Offset: 0x00D4D654
		// (set) Token: 0x0602FB66 RID: 195430 RVA: 0x00D4F45C File Offset: 0x00D4D65C
		public string TextureLightPath { get; set; }

		// Token: 0x17005FD9 RID: 24537
		// (get) Token: 0x0602FB67 RID: 195431 RVA: 0x00D4F465 File Offset: 0x00D4D665
		// (set) Token: 0x0602FB68 RID: 195432 RVA: 0x00D4F46D File Offset: 0x00D4D66D
		public string EffectColor { get; set; }
	}
}
