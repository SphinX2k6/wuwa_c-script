using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B4 RID: 26036
	[NullableContext(1)]
	public interface IPanelComponentData
	{
		// Token: 0x1700957E RID: 38270
		// (get) Token: 0x060414D9 RID: 267481
		// (set) Token: 0x060414DA RID: 267482
		string TitleText { get; set; }

		// Token: 0x1700957F RID: 38271
		// (get) Token: 0x060414DB RID: 267483
		// (set) Token: 0x060414DC RID: 267484
		Func<string> GetCountText { get; set; }

		// Token: 0x17009580 RID: 38272
		// (get) Token: 0x060414DD RID: 267485
		// (set) Token: 0x060414DE RID: 267486
		int HelpBtnId { get; set; }

		// Token: 0x17009581 RID: 38273
		// (get) Token: 0x060414DF RID: 267487
		// (set) Token: 0x060414E0 RID: 267488
		string TimeText { get; set; }
	}
}
