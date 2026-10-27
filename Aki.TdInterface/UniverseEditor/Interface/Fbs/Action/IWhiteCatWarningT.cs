using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007605 RID: 30213
	public class IWhiteCatWarningT
	{
		// Token: 0x1700E582 RID: 58754
		// (get) Token: 0x0603709C RID: 225436 RVA: 0x007777EB File Offset: 0x007759EB
		// (set) Token: 0x0603709D RID: 225437 RVA: 0x007777F3 File Offset: 0x007759F3
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E583 RID: 58755
		// (get) Token: 0x0603709E RID: 225438 RVA: 0x007777FC File Offset: 0x007759FC
		// (set) Token: 0x0603709F RID: 225439 RVA: 0x00777804 File Offset: 0x00775A04
		public string WarningText { get; set; }

		// Token: 0x060370A0 RID: 225440 RVA: 0x0077780D File Offset: 0x00775A0D
		public IWhiteCatWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
