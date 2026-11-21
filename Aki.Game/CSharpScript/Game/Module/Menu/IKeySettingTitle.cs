using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043D1 RID: 17361
	[NullableContext(1)]
	public interface IKeySettingTitle
	{
		// Token: 0x170057C2 RID: 22466
		// (get) Token: 0x0602BE2F RID: 179759
		// (set) Token: 0x0602BE30 RID: 179760
		int TypeId { get; set; }

		// Token: 0x170057C3 RID: 22467
		// (get) Token: 0x0602BE31 RID: 179761
		// (set) Token: 0x0602BE32 RID: 179762
		string TitleNameId { get; set; }

		// Token: 0x170057C4 RID: 22468
		// (get) Token: 0x0602BE33 RID: 179763
		// (set) Token: 0x0602BE34 RID: 179764
		string TitleSpriteSprite { get; set; }
	}
}
