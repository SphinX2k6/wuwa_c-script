using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005532 RID: 21810
	[NullableContext(1)]
	public interface IPanelComponentData
	{
		// Token: 0x170068E0 RID: 26848
		// (get) Token: 0x0603619E RID: 221598
		// (set) Token: 0x0603619F RID: 221599
		string TitleText { get; set; }

		// Token: 0x170068E1 RID: 26849
		// (get) Token: 0x060361A0 RID: 221600
		// (set) Token: 0x060361A1 RID: 221601
		Func<string> GetCountText { get; set; }

		// Token: 0x170068E2 RID: 26850
		// (get) Token: 0x060361A2 RID: 221602
		// (set) Token: 0x060361A3 RID: 221603
		int HelpBtnId { get; set; }

		// Token: 0x170068E3 RID: 26851
		// (get) Token: 0x060361A4 RID: 221604
		// (set) Token: 0x060361A5 RID: 221605
		string TimeText { get; set; }
	}
}
