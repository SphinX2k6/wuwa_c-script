using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043D2 RID: 17362
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingTitle : IKeySettingTitle
	{
		// Token: 0x170057C5 RID: 22469
		// (get) Token: 0x0602BE35 RID: 179765 RVA: 0x00C54188 File Offset: 0x00C52388
		// (set) Token: 0x0602BE36 RID: 179766 RVA: 0x00C54190 File Offset: 0x00C52390
		public int TypeId { get; set; }

		// Token: 0x170057C6 RID: 22470
		// (get) Token: 0x0602BE37 RID: 179767 RVA: 0x00C54199 File Offset: 0x00C52399
		// (set) Token: 0x0602BE38 RID: 179768 RVA: 0x00C541A1 File Offset: 0x00C523A1
		public string TitleNameId { get; set; } = "";

		// Token: 0x170057C7 RID: 22471
		// (get) Token: 0x0602BE39 RID: 179769 RVA: 0x00C541AA File Offset: 0x00C523AA
		// (set) Token: 0x0602BE3A RID: 179770 RVA: 0x00C541B2 File Offset: 0x00C523B2
		public string TitleSpriteSprite { get; set; } = "";
	}
}
