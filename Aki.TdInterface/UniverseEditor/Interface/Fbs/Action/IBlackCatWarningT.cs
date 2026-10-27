using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006204 RID: 25092
	public class IBlackCatWarningT
	{
		// Token: 0x1700BB0E RID: 47886
		// (get) Token: 0x0602B41F RID: 177183 RVA: 0x005F59CB File Offset: 0x005F3BCB
		// (set) Token: 0x0602B420 RID: 177184 RVA: 0x005F59D3 File Offset: 0x005F3BD3
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BB0F RID: 47887
		// (get) Token: 0x0602B421 RID: 177185 RVA: 0x005F59DC File Offset: 0x005F3BDC
		// (set) Token: 0x0602B422 RID: 177186 RVA: 0x005F59E4 File Offset: 0x005F3BE4
		public string WarningText { get; set; }

		// Token: 0x0602B423 RID: 177187 RVA: 0x005F59ED File Offset: 0x005F3BED
		public IBlackCatWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
