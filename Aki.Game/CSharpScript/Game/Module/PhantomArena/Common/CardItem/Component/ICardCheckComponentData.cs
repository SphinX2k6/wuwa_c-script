using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051E0 RID: 20960
	[NullableContext(1)]
	public interface ICardCheckComponentData
	{
		// Token: 0x170081BE RID: 33214
		// (get) Token: 0x06035A1B RID: 219675
		// (set) Token: 0x06035A1C RID: 219676
		int LeftCount { get; set; }

		// Token: 0x170081BF RID: 33215
		// (get) Token: 0x06035A1D RID: 219677
		// (set) Token: 0x06035A1E RID: 219678
		int MaxCount { get; set; }

		// Token: 0x170081C0 RID: 33216
		// (get) Token: 0x06035A1F RID: 219679
		// (set) Token: 0x06035A20 RID: 219680
		Action OnCheckBtnClick { get; set; }
	}
}
