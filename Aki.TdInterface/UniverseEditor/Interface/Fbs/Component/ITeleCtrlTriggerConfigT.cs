using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006054 RID: 24660
	public class ITeleCtrlTriggerConfigT
	{
		// Token: 0x1700B713 RID: 46867
		// (get) Token: 0x06029A4A RID: 170570 RVA: 0x005AF6E2 File Offset: 0x005AD8E2
		// (set) Token: 0x06029A4B RID: 170571 RVA: 0x005AF6EA File Offset: 0x005AD8EA
		public ETeleCtrlTriggerType Type { get; set; }

		// Token: 0x06029A4C RID: 170572 RVA: 0x005AF6F3 File Offset: 0x005AD8F3
		public ITeleCtrlTriggerConfigT()
		{
			this.Type = ETeleCtrlTriggerType.MechascoutJavelin;
		}
	}
}
