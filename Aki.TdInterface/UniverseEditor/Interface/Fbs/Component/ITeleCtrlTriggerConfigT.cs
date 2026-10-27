using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A47 RID: 23111
	public class ITeleCtrlTriggerConfigT
	{
		// Token: 0x1700ADDB RID: 44507
		// (get) Token: 0x060274D2 RID: 160978 RVA: 0x005686D6 File Offset: 0x005668D6
		// (set) Token: 0x060274D3 RID: 160979 RVA: 0x005686DE File Offset: 0x005668DE
		public ETeleCtrlTriggerType Type { get; set; }

		// Token: 0x060274D4 RID: 160980 RVA: 0x005686E7 File Offset: 0x005668E7
		public ITeleCtrlTriggerConfigT()
		{
			this.Type = ETeleCtrlTriggerType.MechascoutJavelin;
		}
	}
}
