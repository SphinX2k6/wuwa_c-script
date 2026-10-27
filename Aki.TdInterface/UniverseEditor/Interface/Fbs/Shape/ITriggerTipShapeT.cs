using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C6E RID: 15470
	public class ITriggerTipShapeT
	{
		// Token: 0x17006AB6 RID: 27318
		// (get) Token: 0x0601569D RID: 87709 RVA: 0x0031879A File Offset: 0x0031699A
		// (set) Token: 0x0601569E RID: 87710 RVA: 0x003187A2 File Offset: 0x003169A2
		public ETriggerTipShape Type { get; set; }

		// Token: 0x0601569F RID: 87711 RVA: 0x003187AB File Offset: 0x003169AB
		public ITriggerTipShapeT()
		{
			this.Type = ETriggerTipShape.Box;
		}
	}
}
