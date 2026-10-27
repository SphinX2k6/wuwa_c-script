using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB6 RID: 23990
	public class IGiantAnimDataTypeT
	{
		// Token: 0x1700B3A3 RID: 45987
		// (get) Token: 0x06029100 RID: 168192 RVA: 0x005A3432 File Offset: 0x005A1632
		// (set) Token: 0x06029101 RID: 168193 RVA: 0x005A343A File Offset: 0x005A163A
		public EGiantAnimationType Type { get; set; }

		// Token: 0x06029102 RID: 168194 RVA: 0x005A3443 File Offset: 0x005A1643
		public IGiantAnimDataTypeT()
		{
			this.Type = EGiantAnimationType.Idle;
		}
	}
}
