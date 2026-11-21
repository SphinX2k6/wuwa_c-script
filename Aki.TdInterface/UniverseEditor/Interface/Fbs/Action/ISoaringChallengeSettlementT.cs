using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007930 RID: 31024
	public class ISoaringChallengeSettlementT
	{
		// Token: 0x1700E395 RID: 58261
		// (get) Token: 0x06036A28 RID: 223784 RVA: 0x0074F93E File Offset: 0x0074DB3E
		// (set) Token: 0x06036A29 RID: 223785 RVA: 0x0074F946 File Offset: 0x0074DB46
		public EDynamicSettlementType Type { get; set; }

		// Token: 0x06036A2A RID: 223786 RVA: 0x0074F94F File Offset: 0x0074DB4F
		public ISoaringChallengeSettlementT()
		{
			this.Type = EDynamicSettlementType.Battle;
		}
	}
}
