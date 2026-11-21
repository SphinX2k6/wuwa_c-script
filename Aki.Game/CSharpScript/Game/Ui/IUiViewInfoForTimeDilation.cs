using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200356C RID: 13676
	[NullableContext(1)]
	public interface IUiViewInfoForTimeDilation
	{
		// Token: 0x170048A5 RID: 18597
		// (get) Token: 0x06022D0D RID: 142605
		// (set) Token: 0x06022D0E RID: 142606
		float TimeDilation { get; set; }

		// Token: 0x170048A6 RID: 18598
		// (get) Token: 0x06022D0F RID: 142607
		// (set) Token: 0x06022D10 RID: 142608
		int ViewId { get; set; }

		// Token: 0x170048A7 RID: 18599
		// (get) Token: 0x06022D11 RID: 142609
		// (set) Token: 0x06022D12 RID: 142610
		EUiViewName? DebugName { get; set; }

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x06022D13 RID: 142611
		// (set) Token: 0x06022D14 RID: 142612
		string Reason { get; set; }
	}
}
