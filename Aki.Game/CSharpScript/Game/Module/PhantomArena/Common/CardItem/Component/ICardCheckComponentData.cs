using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B0 RID: 16816
	[NullableContext(1)]
	public interface ICardCheckComponentData
	{
		// Token: 0x1700557E RID: 21886
		// (get) Token: 0x0602A916 RID: 174358
		// (set) Token: 0x0602A917 RID: 174359
		int LeftCount { get; set; }

		// Token: 0x1700557F RID: 21887
		// (get) Token: 0x0602A918 RID: 174360
		// (set) Token: 0x0602A919 RID: 174361
		int MaxCount { get; set; }

		// Token: 0x17005580 RID: 21888
		// (get) Token: 0x0602A91A RID: 174362
		// (set) Token: 0x0602A91B RID: 174363
		Action OnCheckBtnClick { get; set; }
	}
}
