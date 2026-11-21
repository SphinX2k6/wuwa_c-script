using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x02004710 RID: 18192
	[NullableContext(1)]
	public interface IInfoItemData
	{
		// Token: 0x17005C2C RID: 23596
		// (get) Token: 0x0602DB5C RID: 187228
		// (set) Token: 0x0602DB5D RID: 187229
		int Level { get; set; }

		// Token: 0x17005C2D RID: 23597
		// (get) Token: 0x0602DB5E RID: 187230
		// (set) Token: 0x0602DB5F RID: 187231
		string Description { get; set; }

		// Token: 0x17005C2E RID: 23598
		// (get) Token: 0x0602DB60 RID: 187232
		// (set) Token: 0x0602DB61 RID: 187233
		int BuildLevel { get; set; }

		// Token: 0x17005C2F RID: 23599
		// (get) Token: 0x0602DB62 RID: 187234
		// (set) Token: 0x0602DB63 RID: 187235
		bool IsArrowLevel { get; set; }
	}
}
