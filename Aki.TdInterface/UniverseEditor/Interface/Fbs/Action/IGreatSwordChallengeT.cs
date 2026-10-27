using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A1 RID: 26785
	public class IGreatSwordChallengeT
	{
		// Token: 0x1700C6DC RID: 50908
		// (get) Token: 0x0602EB82 RID: 191362 RVA: 0x0065E7B4 File Offset: 0x0065C9B4
		// (set) Token: 0x0602EB83 RID: 191363 RVA: 0x0065E7BC File Offset: 0x0065C9BC
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C6DD RID: 50909
		// (get) Token: 0x0602EB84 RID: 191364 RVA: 0x0065E7C5 File Offset: 0x0065C9C5
		// (set) Token: 0x0602EB85 RID: 191365 RVA: 0x0065E7CD File Offset: 0x0065C9CD
		public string MainText { get; set; }

		// Token: 0x1700C6DE RID: 50910
		// (get) Token: 0x0602EB86 RID: 191366 RVA: 0x0065E7D6 File Offset: 0x0065C9D6
		// (set) Token: 0x0602EB87 RID: 191367 RVA: 0x0065E7DE File Offset: 0x0065C9DE
		public string SubText { get; set; }

		// Token: 0x0602EB88 RID: 191368 RVA: 0x0065E7E7 File Offset: 0x0065C9E7
		public IGreatSwordChallengeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MainText = null;
			this.SubText = null;
		}
	}
}
