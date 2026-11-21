using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007392 RID: 29586
	public class IOpenSimpleGameplayT
	{
		// Token: 0x1700D914 RID: 55572
		// (get) Token: 0x06033ACE RID: 211662 RVA: 0x006F7A42 File Offset: 0x006F5C42
		// (set) Token: 0x06033ACF RID: 211663 RVA: 0x006F7A4A File Offset: 0x006F5C4A
		public TUiGameUnion GameplayConfig { get; set; }

		// Token: 0x1700D915 RID: 55573
		// (get) Token: 0x06033AD0 RID: 211664 RVA: 0x006F7A53 File Offset: 0x006F5C53
		// (set) Token: 0x06033AD1 RID: 211665 RVA: 0x006F7A5B File Offset: 0x006F5C5B
		public string FinishSendSelfEvent { get; set; }

		// Token: 0x1700D916 RID: 55574
		// (get) Token: 0x06033AD2 RID: 211666 RVA: 0x006F7A64 File Offset: 0x006F5C64
		// (set) Token: 0x06033AD3 RID: 211667 RVA: 0x006F7A6C File Offset: 0x006F5C6C
		public string FailSendSelfEvent { get; set; }

		// Token: 0x06033AD4 RID: 211668 RVA: 0x006F7A75 File Offset: 0x006F5C75
		public IOpenSimpleGameplayT()
		{
			this.GameplayConfig = null;
			this.FinishSendSelfEvent = null;
			this.FailSendSelfEvent = null;
		}
	}
}
