using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053EE RID: 21486
	[NullableContext(1)]
	public interface IKeySettingTitle
	{
		// Token: 0x170083F6 RID: 33782
		// (get) Token: 0x06036EE7 RID: 224999
		// (set) Token: 0x06036EE8 RID: 225000
		int TypeId { get; set; }

		// Token: 0x170083F7 RID: 33783
		// (get) Token: 0x06036EE9 RID: 225001
		// (set) Token: 0x06036EEA RID: 225002
		string TitleNameId { get; set; }

		// Token: 0x170083F8 RID: 33784
		// (get) Token: 0x06036EEB RID: 225003
		// (set) Token: 0x06036EEC RID: 225004
		string TitleSpriteSprite { get; set; }
	}
}
