using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065F5 RID: 26101
	public interface IPanelPosRange
	{
		// Token: 0x170095BE RID: 38334
		// (get) Token: 0x060416CE RID: 267982
		// (set) Token: 0x060416CF RID: 267983
		int RowStartIndex { get; set; }

		// Token: 0x170095BF RID: 38335
		// (get) Token: 0x060416D0 RID: 267984
		// (set) Token: 0x060416D1 RID: 267985
		int RowEndIndex { get; set; }

		// Token: 0x170095C0 RID: 38336
		// (get) Token: 0x060416D2 RID: 267986
		// (set) Token: 0x060416D3 RID: 267987
		int ColStartIndex { get; set; }

		// Token: 0x170095C1 RID: 38337
		// (get) Token: 0x060416D4 RID: 267988
		// (set) Token: 0x060416D5 RID: 267989
		int ColEndIndex { get; set; }
	}
}
