using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004317 RID: 17175
	public class IKurotatoConditionStepBattleT
	{
		// Token: 0x1700759D RID: 30109
		// (get) Token: 0x06018280 RID: 98944 RVA: 0x0037215A File Offset: 0x0037035A
		// (set) Token: 0x06018281 RID: 98945 RVA: 0x00372162 File Offset: 0x00370362
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06018282 RID: 98946 RVA: 0x0037216B File Offset: 0x0037036B
		public IKurotatoConditionStepBattleT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
