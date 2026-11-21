using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E4 RID: 17124
	public class IInformationViewT
	{
		// Token: 0x17007544 RID: 30020
		// (get) Token: 0x060180A9 RID: 98473 RVA: 0x0036E404 File Offset: 0x0036C604
		// (set) Token: 0x060180AA RID: 98474 RVA: 0x0036E40C File Offset: 0x0036C60C
		public EShowUiType Type { get; set; }

		// Token: 0x17007545 RID: 30021
		// (get) Token: 0x060180AB RID: 98475 RVA: 0x0036E415 File Offset: 0x0036C615
		// (set) Token: 0x060180AC RID: 98476 RVA: 0x0036E41D File Offset: 0x0036C61D
		public int InformationViewId { get; set; }

		// Token: 0x060180AD RID: 98477 RVA: 0x0036E426 File Offset: 0x0036C626
		public IInformationViewT()
		{
			this.Type = EShowUiType.All;
			this.InformationViewId = 0;
		}
	}
}
