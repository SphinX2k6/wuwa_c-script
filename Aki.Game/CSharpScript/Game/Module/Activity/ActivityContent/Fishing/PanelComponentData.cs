using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005533 RID: 21811
	[NullableContext(1)]
	[Nullable(0)]
	public class PanelComponentData : IPanelComponentData
	{
		// Token: 0x170068E4 RID: 26852
		// (get) Token: 0x060361A6 RID: 221606 RVA: 0x00F1ADD8 File Offset: 0x00F18FD8
		// (set) Token: 0x060361A7 RID: 221607 RVA: 0x00F1ADE0 File Offset: 0x00F18FE0
		public string TitleText { get; set; } = "";

		// Token: 0x170068E5 RID: 26853
		// (get) Token: 0x060361A8 RID: 221608 RVA: 0x00F1ADE9 File Offset: 0x00F18FE9
		// (set) Token: 0x060361A9 RID: 221609 RVA: 0x00F1ADF1 File Offset: 0x00F18FF1
		public Func<string> GetCountText { get; set; }

		// Token: 0x170068E6 RID: 26854
		// (get) Token: 0x060361AA RID: 221610 RVA: 0x00F1ADFA File Offset: 0x00F18FFA
		// (set) Token: 0x060361AB RID: 221611 RVA: 0x00F1AE02 File Offset: 0x00F19002
		public int HelpBtnId { get; set; }

		// Token: 0x170068E7 RID: 26855
		// (get) Token: 0x060361AC RID: 221612 RVA: 0x00F1AE0B File Offset: 0x00F1900B
		// (set) Token: 0x060361AD RID: 221613 RVA: 0x00F1AE13 File Offset: 0x00F19013
		public string TimeText { get; set; } = "";
	}
}
