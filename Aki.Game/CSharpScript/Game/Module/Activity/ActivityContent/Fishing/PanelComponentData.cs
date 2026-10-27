using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B5 RID: 26037
	[NullableContext(1)]
	[Nullable(0)]
	public class PanelComponentData : IPanelComponentData
	{
		// Token: 0x17009582 RID: 38274
		// (get) Token: 0x060414E1 RID: 267489 RVA: 0x00FD3DD4 File Offset: 0x00FD1FD4
		// (set) Token: 0x060414E2 RID: 267490 RVA: 0x00FD3DDC File Offset: 0x00FD1FDC
		public string TitleText { get; set; } = "";

		// Token: 0x17009583 RID: 38275
		// (get) Token: 0x060414E3 RID: 267491 RVA: 0x00FD3DE5 File Offset: 0x00FD1FE5
		// (set) Token: 0x060414E4 RID: 267492 RVA: 0x00FD3DED File Offset: 0x00FD1FED
		public Func<string> GetCountText { get; set; }

		// Token: 0x17009584 RID: 38276
		// (get) Token: 0x060414E5 RID: 267493 RVA: 0x00FD3DF6 File Offset: 0x00FD1FF6
		// (set) Token: 0x060414E6 RID: 267494 RVA: 0x00FD3DFE File Offset: 0x00FD1FFE
		public int HelpBtnId { get; set; }

		// Token: 0x17009585 RID: 38277
		// (get) Token: 0x060414E7 RID: 267495 RVA: 0x00FD3E07 File Offset: 0x00FD2007
		// (set) Token: 0x060414E8 RID: 267496 RVA: 0x00FD3E0F File Offset: 0x00FD200F
		public string TimeText { get; set; } = "";
	}
}
