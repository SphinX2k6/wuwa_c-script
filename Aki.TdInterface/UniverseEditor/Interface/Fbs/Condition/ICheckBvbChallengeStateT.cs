using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E46 RID: 20038
	public class ICheckBvbChallengeStateT
	{
		// Token: 0x17008EC3 RID: 36547
		// (get) Token: 0x0601EFFD RID: 126973 RVA: 0x004541F6 File Offset: 0x004523F6
		// (set) Token: 0x0601EFFE RID: 126974 RVA: 0x004541FE File Offset: 0x004523FE
		public ECondition Type { get; set; }

		// Token: 0x17008EC4 RID: 36548
		// (get) Token: 0x0601EFFF RID: 126975 RVA: 0x00454207 File Offset: 0x00452407
		// (set) Token: 0x0601F000 RID: 126976 RVA: 0x0045420F File Offset: 0x0045240F
		public int ChallengeId { get; set; }

		// Token: 0x17008EC5 RID: 36549
		// (get) Token: 0x0601F001 RID: 126977 RVA: 0x00454218 File Offset: 0x00452418
		// (set) Token: 0x0601F002 RID: 126978 RVA: 0x00454220 File Offset: 0x00452420
		public EBvbChallengeStateType ChallengeState { get; set; }

		// Token: 0x0601F003 RID: 126979 RVA: 0x00454229 File Offset: 0x00452429
		public ICheckBvbChallengeStateT()
		{
			this.Type = ECondition.CompareVar;
			this.ChallengeId = 0;
			this.ChallengeState = EBvbChallengeStateType.Default;
		}
	}
}
