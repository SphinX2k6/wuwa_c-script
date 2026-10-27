using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2B RID: 27691
	public class IOpenSimpleGameplayT
	{
		// Token: 0x1700CDF9 RID: 52729
		// (get) Token: 0x06030B77 RID: 199543 RVA: 0x0069D632 File Offset: 0x0069B832
		// (set) Token: 0x06030B78 RID: 199544 RVA: 0x0069D63A File Offset: 0x0069B83A
		public TUiGameUnion GameplayConfig { get; set; }

		// Token: 0x1700CDFA RID: 52730
		// (get) Token: 0x06030B79 RID: 199545 RVA: 0x0069D643 File Offset: 0x0069B843
		// (set) Token: 0x06030B7A RID: 199546 RVA: 0x0069D64B File Offset: 0x0069B84B
		public string FinishSendSelfEvent { get; set; }

		// Token: 0x1700CDFB RID: 52731
		// (get) Token: 0x06030B7B RID: 199547 RVA: 0x0069D654 File Offset: 0x0069B854
		// (set) Token: 0x06030B7C RID: 199548 RVA: 0x0069D65C File Offset: 0x0069B85C
		public string FailSendSelfEvent { get; set; }

		// Token: 0x06030B7D RID: 199549 RVA: 0x0069D665 File Offset: 0x0069B865
		public IOpenSimpleGameplayT()
		{
			this.GameplayConfig = null;
			this.FinishSendSelfEvent = null;
			this.FailSendSelfEvent = null;
		}
	}
}
