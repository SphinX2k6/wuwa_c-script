using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004657 RID: 18007
	[NullableContext(1)]
	public interface IUiViewBase
	{
		// Token: 0x17007601 RID: 30209
		// (get) Token: 0x0602E7BE RID: 190398
		// (set) Token: 0x0602E7BF RID: 190399
		UiViewBase ViewBase { get; set; }

		// Token: 0x17007602 RID: 30210
		// (get) Token: 0x0602E7C0 RID: 190400
		// (set) Token: 0x0602E7C1 RID: 190401
		int Priority { get; set; }

		// Token: 0x17007603 RID: 30211
		// (get) Token: 0x0602E7C2 RID: 190402
		// (set) Token: 0x0602E7C3 RID: 190403
		bool OnlyShowInMain { get; set; }
	}
}
