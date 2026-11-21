using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Skin.Skip
{
	// Token: 0x02003BA3 RID: 15267
	[NullableContext(1)]
	public interface ISkinSkipData
	{
		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x060271FC RID: 160252
		// (set) Token: 0x060271FD RID: 160253
		int Id { get; set; }

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x060271FE RID: 160254
		// (set) Token: 0x060271FF RID: 160255
		int ConfigId { get; set; }

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x06027200 RID: 160256
		// (set) Token: 0x06027201 RID: 160257
		ESkinSkipType Type { get; set; }

		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x06027202 RID: 160258
		// (set) Token: 0x06027203 RID: 160259
		string Text { get; set; }

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x06027204 RID: 160260
		// (set) Token: 0x06027205 RID: 160261
		int SortIndex { get; set; }
	}
}
