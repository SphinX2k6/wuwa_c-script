using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053EF RID: 21487
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingTitle : IKeySettingTitle
	{
		// Token: 0x170083F9 RID: 33785
		// (get) Token: 0x06036EED RID: 225005 RVA: 0x00D04D44 File Offset: 0x00D02F44
		// (set) Token: 0x06036EEE RID: 225006 RVA: 0x00D04D4C File Offset: 0x00D02F4C
		public int TypeId { get; set; }

		// Token: 0x170083FA RID: 33786
		// (get) Token: 0x06036EEF RID: 225007 RVA: 0x00D04D55 File Offset: 0x00D02F55
		// (set) Token: 0x06036EF0 RID: 225008 RVA: 0x00D04D5D File Offset: 0x00D02F5D
		public string TitleNameId { get; set; } = "";

		// Token: 0x170083FB RID: 33787
		// (get) Token: 0x06036EF1 RID: 225009 RVA: 0x00D04D66 File Offset: 0x00D02F66
		// (set) Token: 0x06036EF2 RID: 225010 RVA: 0x00D04D6E File Offset: 0x00D02F6E
		public string TitleSpriteSprite { get; set; } = "";
	}
}
