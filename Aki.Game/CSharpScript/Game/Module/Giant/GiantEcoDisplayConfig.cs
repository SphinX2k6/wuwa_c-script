using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200596B RID: 22891
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantEcoDisplayConfig : IGiantEcoDisplayConfig
	{
		// Token: 0x17008B37 RID: 35639
		// (get) Token: 0x0603A137 RID: 237879 RVA: 0x00DCD88C File Offset: 0x00DCBA8C
		// (set) Token: 0x0603A138 RID: 237880 RVA: 0x00DCD894 File Offset: 0x00DCBA94
		public string OutlineColorHex { get; set; }

		// Token: 0x17008B38 RID: 35640
		// (get) Token: 0x0603A139 RID: 237881 RVA: 0x00DCD89D File Offset: 0x00DCBA9D
		// (set) Token: 0x0603A13A RID: 237882 RVA: 0x00DCD8A5 File Offset: 0x00DCBAA5
		public string IconSpriteNormal { get; set; }

		// Token: 0x17008B39 RID: 35641
		// (get) Token: 0x0603A13B RID: 237883 RVA: 0x00DCD8AE File Offset: 0x00DCBAAE
		// (set) Token: 0x0603A13C RID: 237884 RVA: 0x00DCD8B6 File Offset: 0x00DCBAB6
		public string IconSpriteActive { get; set; }

		// Token: 0x17008B3A RID: 35642
		// (get) Token: 0x0603A13D RID: 237885 RVA: 0x00DCD8BF File Offset: 0x00DCBABF
		// (set) Token: 0x0603A13E RID: 237886 RVA: 0x00DCD8C7 File Offset: 0x00DCBAC7
		public string MindsetNameKey { get; set; }

		// Token: 0x17008B3B RID: 35643
		// (get) Token: 0x0603A13F RID: 237887 RVA: 0x00DCD8D0 File Offset: 0x00DCBAD0
		// (set) Token: 0x0603A140 RID: 237888 RVA: 0x00DCD8D8 File Offset: 0x00DCBAD8
		public string PortraitTexture { get; set; }
	}
}
