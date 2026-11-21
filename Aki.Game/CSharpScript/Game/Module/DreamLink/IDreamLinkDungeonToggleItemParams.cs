using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A75 RID: 19061
	[NullableContext(1)]
	public interface IDreamLinkDungeonToggleItemParams
	{
		// Token: 0x17005FD4 RID: 24532
		// (get) Token: 0x0602FB5D RID: 195421
		// (set) Token: 0x0602FB5E RID: 195422
		string TextureBgPath { get; set; }

		// Token: 0x17005FD5 RID: 24533
		// (get) Token: 0x0602FB5F RID: 195423
		// (set) Token: 0x0602FB60 RID: 195424
		string TextureLightPath { get; set; }

		// Token: 0x17005FD6 RID: 24534
		// (get) Token: 0x0602FB61 RID: 195425
		// (set) Token: 0x0602FB62 RID: 195426
		string EffectColor { get; set; }
	}
}
