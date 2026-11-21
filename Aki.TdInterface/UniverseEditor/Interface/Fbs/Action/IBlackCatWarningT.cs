using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006875 RID: 26741
	public class IBlackCatWarningT
	{
		// Token: 0x1700C494 RID: 50324
		// (get) Token: 0x0602DB78 RID: 187256 RVA: 0x006405B7 File Offset: 0x0063E7B7
		// (set) Token: 0x0602DB79 RID: 187257 RVA: 0x006405BF File Offset: 0x0063E7BF
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C495 RID: 50325
		// (get) Token: 0x0602DB7A RID: 187258 RVA: 0x006405C8 File Offset: 0x0063E7C8
		// (set) Token: 0x0602DB7B RID: 187259 RVA: 0x006405D0 File Offset: 0x0063E7D0
		public string WarningText { get; set; }

		// Token: 0x0602DB7C RID: 187260 RVA: 0x006405D9 File Offset: 0x0063E7D9
		public IBlackCatWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
