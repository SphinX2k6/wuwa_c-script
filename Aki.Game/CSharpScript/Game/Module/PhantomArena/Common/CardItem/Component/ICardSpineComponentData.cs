using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C2 RID: 16834
	[NullableContext(1)]
	public interface ICardSpineComponentData
	{
		// Token: 0x17005596 RID: 21910
		// (get) Token: 0x0602A980 RID: 174464
		// (set) Token: 0x0602A981 RID: 174465
		CardSpineData CardSpineData { get; set; }

		// Token: 0x17005597 RID: 21911
		// (get) Token: 0x0602A982 RID: 174466
		// (set) Token: 0x0602A983 RID: 174467
		bool ShowSpine { get; set; }
	}
}
