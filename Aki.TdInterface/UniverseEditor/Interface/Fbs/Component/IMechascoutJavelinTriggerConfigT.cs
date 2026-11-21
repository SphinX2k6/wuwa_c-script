using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC0 RID: 23232
	public class IMechascoutJavelinTriggerConfigT
	{
		// Token: 0x1700A94D RID: 43341
		// (get) Token: 0x06026183 RID: 156035 RVA: 0x00537F4E File Offset: 0x0053614E
		// (set) Token: 0x06026184 RID: 156036 RVA: 0x00537F56 File Offset: 0x00536156
		public ETeleCtrlTriggerType Type { get; set; }

		// Token: 0x06026185 RID: 156037 RVA: 0x00537F5F File Offset: 0x0053615F
		public IMechascoutJavelinTriggerConfigT()
		{
			this.Type = ETeleCtrlTriggerType.MechascoutJavelin;
		}
	}
}
