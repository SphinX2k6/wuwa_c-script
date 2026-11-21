using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B13 RID: 27411
	public class ICommonTipPrepareCountdownT
	{
		// Token: 0x1700C94F RID: 51535
		// (get) Token: 0x0602F21E RID: 193054 RVA: 0x0066D536 File Offset: 0x0066B736
		// (set) Token: 0x0602F21F RID: 193055 RVA: 0x0066D53E File Offset: 0x0066B73E
		public ECommonTipType Type { get; set; }

		// Token: 0x0602F220 RID: 193056 RVA: 0x0066D547 File Offset: 0x0066B747
		public ICommonTipPrepareCountdownT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
		}
	}
}
