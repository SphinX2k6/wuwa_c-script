using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200356D RID: 13677
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewInfoForTimeDilation : IUiViewInfoForTimeDilation
	{
		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x06022D15 RID: 142613 RVA: 0x009E3EFC File Offset: 0x009E20FC
		// (set) Token: 0x06022D16 RID: 142614 RVA: 0x009E3F04 File Offset: 0x009E2104
		public float TimeDilation { get; set; }

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x06022D17 RID: 142615 RVA: 0x009E3F0D File Offset: 0x009E210D
		// (set) Token: 0x06022D18 RID: 142616 RVA: 0x009E3F15 File Offset: 0x009E2115
		public int ViewId { get; set; }

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x06022D19 RID: 142617 RVA: 0x009E3F1E File Offset: 0x009E211E
		// (set) Token: 0x06022D1A RID: 142618 RVA: 0x009E3F26 File Offset: 0x009E2126
		public EUiViewName? DebugName { get; set; }

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x06022D1B RID: 142619 RVA: 0x009E3F2F File Offset: 0x009E212F
		// (set) Token: 0x06022D1C RID: 142620 RVA: 0x009E3F37 File Offset: 0x009E2137
		public string Reason { get; set; }
	}
}
