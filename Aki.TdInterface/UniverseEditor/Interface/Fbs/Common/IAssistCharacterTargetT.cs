using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200634B RID: 25419
	public class IAssistCharacterTargetT
	{
		// Token: 0x1700BBF0 RID: 48112
		// (get) Token: 0x0602B1BD RID: 176573 RVA: 0x005E018C File Offset: 0x005DE38C
		// (set) Token: 0x0602B1BE RID: 176574 RVA: 0x005E0194 File Offset: 0x005DE394
		public ECommonTargetType Type { get; set; }

		// Token: 0x1700BBF1 RID: 48113
		// (get) Token: 0x0602B1BF RID: 176575 RVA: 0x005E019D File Offset: 0x005DE39D
		// (set) Token: 0x0602B1C0 RID: 176576 RVA: 0x005E01A5 File Offset: 0x005DE3A5
		public int Id { get; set; }

		// Token: 0x0602B1C1 RID: 176577 RVA: 0x005E01AE File Offset: 0x005DE3AE
		public IAssistCharacterTargetT()
		{
			this.Type = ECommonTargetType.Player;
			this.Id = 0;
		}
	}
}
