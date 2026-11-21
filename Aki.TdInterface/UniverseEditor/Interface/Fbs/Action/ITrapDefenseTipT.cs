using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C60 RID: 31840
	public class ITrapDefenseTipT
	{
		// Token: 0x1700EE54 RID: 61012
		// (get) Token: 0x06039647 RID: 235079 RVA: 0x007BF7B5 File Offset: 0x007BD9B5
		// (set) Token: 0x06039648 RID: 235080 RVA: 0x007BF7BD File Offset: 0x007BD9BD
		public ECommonTipType Type { get; set; }

		// Token: 0x1700EE55 RID: 61013
		// (get) Token: 0x06039649 RID: 235081 RVA: 0x007BF7C6 File Offset: 0x007BD9C6
		// (set) Token: 0x0603964A RID: 235082 RVA: 0x007BF7CE File Offset: 0x007BD9CE
		public string MainText { get; set; }

		// Token: 0x1700EE56 RID: 61014
		// (get) Token: 0x0603964B RID: 235083 RVA: 0x007BF7D7 File Offset: 0x007BD9D7
		// (set) Token: 0x0603964C RID: 235084 RVA: 0x007BF7DF File Offset: 0x007BD9DF
		public ETrapDefenseTipType TipType { get; set; }

		// Token: 0x0603964D RID: 235085 RVA: 0x007BF7E8 File Offset: 0x007BD9E8
		public ITrapDefenseTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MainText = null;
			this.TipType = ETrapDefenseTipType.OpenNewAreaTip;
		}
	}
}
