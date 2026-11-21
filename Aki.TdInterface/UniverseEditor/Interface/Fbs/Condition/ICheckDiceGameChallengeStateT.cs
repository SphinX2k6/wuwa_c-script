using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E85 RID: 20101
	public class ICheckDiceGameChallengeStateT
	{
		// Token: 0x17008F5B RID: 36699
		// (get) Token: 0x0601F237 RID: 127543 RVA: 0x00457EBA File Offset: 0x004560BA
		// (set) Token: 0x0601F238 RID: 127544 RVA: 0x00457EC2 File Offset: 0x004560C2
		public ECondition Type { get; set; }

		// Token: 0x17008F5C RID: 36700
		// (get) Token: 0x0601F239 RID: 127545 RVA: 0x00457ECB File Offset: 0x004560CB
		// (set) Token: 0x0601F23A RID: 127546 RVA: 0x00457ED3 File Offset: 0x004560D3
		public int ChallengeId { get; set; }

		// Token: 0x17008F5D RID: 36701
		// (get) Token: 0x0601F23B RID: 127547 RVA: 0x00457EDC File Offset: 0x004560DC
		// (set) Token: 0x0601F23C RID: 127548 RVA: 0x00457EE4 File Offset: 0x004560E4
		public EDiceGameChallengeStateType ChallengeState { get; set; }

		// Token: 0x0601F23D RID: 127549 RVA: 0x00457EED File Offset: 0x004560ED
		public ICheckDiceGameChallengeStateT()
		{
			this.Type = ECondition.CompareVar;
			this.ChallengeId = 0;
			this.ChallengeState = EDiceGameChallengeStateType.Default;
		}
	}
}
