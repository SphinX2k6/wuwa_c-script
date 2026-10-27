using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754E RID: 30030
	public class IVisionSettlementTipT
	{
		// Token: 0x1700E3D9 RID: 58329
		// (get) Token: 0x06036A3E RID: 223806 RVA: 0x0076C114 File Offset: 0x0076A314
		// (set) Token: 0x06036A3F RID: 223807 RVA: 0x0076C11C File Offset: 0x0076A31C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E3DA RID: 58330
		// (get) Token: 0x06036A40 RID: 223808 RVA: 0x0076C125 File Offset: 0x0076A325
		// (set) Token: 0x06036A41 RID: 223809 RVA: 0x0076C12D File Offset: 0x0076A32D
		public string TidMainText { get; set; }

		// Token: 0x1700E3DB RID: 58331
		// (get) Token: 0x06036A42 RID: 223810 RVA: 0x0076C136 File Offset: 0x0076A336
		// (set) Token: 0x06036A43 RID: 223811 RVA: 0x0076C13E File Offset: 0x0076A33E
		public string TidSubText { get; set; }

		// Token: 0x06036A44 RID: 223812 RVA: 0x0076C147 File Offset: 0x0076A347
		public IVisionSettlementTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
