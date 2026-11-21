using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003611 RID: 13841
	[NullableContext(1)]
	public interface IUiTabViewTsInfo
	{
		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x060233EF RID: 144367
		TCreateUiTabViewBase CreateUiTabView { get; }

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x060233F0 RID: 144368
		string ResourceId { get; }
	}
}
