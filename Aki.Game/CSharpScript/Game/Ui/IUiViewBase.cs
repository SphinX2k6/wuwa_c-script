using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003588 RID: 13704
	[NullableContext(1)]
	public interface IUiViewBase
	{
		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x06022F08 RID: 143112
		// (set) Token: 0x06022F09 RID: 143113
		UiViewBase ViewBase { get; set; }

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x06022F0A RID: 143114
		// (set) Token: 0x06022F0B RID: 143115
		int Priority { get; set; }

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x06022F0C RID: 143116
		// (set) Token: 0x06022F0D RID: 143117
		bool OnlyShowInMain { get; set; }
	}
}
