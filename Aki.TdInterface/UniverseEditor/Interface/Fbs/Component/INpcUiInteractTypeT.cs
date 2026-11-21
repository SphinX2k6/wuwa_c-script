using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2E RID: 23598
	public class INpcUiInteractTypeT
	{
		// Token: 0x1700AD57 RID: 44375
		// (get) Token: 0x060271B6 RID: 160182 RVA: 0x0055BCAE File Offset: 0x00559EAE
		// (set) Token: 0x060271B7 RID: 160183 RVA: 0x0055BCB6 File Offset: 0x00559EB6
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x060271B8 RID: 160184 RVA: 0x0055BCBF File Offset: 0x00559EBF
		public INpcUiInteractTypeT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
		}
	}
}
