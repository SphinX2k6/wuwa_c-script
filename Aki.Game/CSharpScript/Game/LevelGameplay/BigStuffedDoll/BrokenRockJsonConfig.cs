using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F4B RID: 28491
	[NullableContext(1)]
	[Nullable(0)]
	public class BrokenRockJsonConfig : IBrokenRockJsonConfig
	{
		// Token: 0x17009B59 RID: 39769
		// (get) Token: 0x060454FC RID: 283900 RVA: 0x01125F1B File Offset: 0x0112411B
		// (set) Token: 0x060454FD RID: 283901 RVA: 0x01125F23 File Offset: 0x01124123
		public BrokenRockConfig[] Config { get; set; }

		// Token: 0x17009B5A RID: 39770
		// (get) Token: 0x060454FE RID: 283902 RVA: 0x01125F2C File Offset: 0x0112412C
		// (set) Token: 0x060454FF RID: 283903 RVA: 0x01125F34 File Offset: 0x01124134
		public BrokenRockRingConfig[] Rings { get; set; }
	}
}
