using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004944 RID: 18756
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantEcoDisplayConfig : IGiantEcoDisplayConfig
	{
		// Token: 0x17005F04 RID: 24324
		// (get) Token: 0x0602F05B RID: 192603 RVA: 0x00D1CAF4 File Offset: 0x00D1ACF4
		// (set) Token: 0x0602F05C RID: 192604 RVA: 0x00D1CAFC File Offset: 0x00D1ACFC
		public string OutlineColorHex { get; set; }

		// Token: 0x17005F05 RID: 24325
		// (get) Token: 0x0602F05D RID: 192605 RVA: 0x00D1CB05 File Offset: 0x00D1AD05
		// (set) Token: 0x0602F05E RID: 192606 RVA: 0x00D1CB0D File Offset: 0x00D1AD0D
		public string IconSpriteNormal { get; set; }

		// Token: 0x17005F06 RID: 24326
		// (get) Token: 0x0602F05F RID: 192607 RVA: 0x00D1CB16 File Offset: 0x00D1AD16
		// (set) Token: 0x0602F060 RID: 192608 RVA: 0x00D1CB1E File Offset: 0x00D1AD1E
		public string IconSpriteActive { get; set; }

		// Token: 0x17005F07 RID: 24327
		// (get) Token: 0x0602F061 RID: 192609 RVA: 0x00D1CB27 File Offset: 0x00D1AD27
		// (set) Token: 0x0602F062 RID: 192610 RVA: 0x00D1CB2F File Offset: 0x00D1AD2F
		public string MindsetNameKey { get; set; }

		// Token: 0x17005F08 RID: 24328
		// (get) Token: 0x0602F063 RID: 192611 RVA: 0x00D1CB38 File Offset: 0x00D1AD38
		// (set) Token: 0x0602F064 RID: 192612 RVA: 0x00D1CB40 File Offset: 0x00D1AD40
		public string PortraitTexture { get; set; }
	}
}
