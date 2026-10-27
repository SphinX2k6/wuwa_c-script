using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006922 RID: 26914
	public class IHonamiStoryEvacuateConfirmBoxT
	{
		// Token: 0x1700C7AF RID: 51119
		// (get) Token: 0x0602EFC1 RID: 192449 RVA: 0x0066805A File Offset: 0x0066625A
		// (set) Token: 0x0602EFC2 RID: 192450 RVA: 0x00668062 File Offset: 0x00666262
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x0602EFC3 RID: 192451 RVA: 0x0066806B File Offset: 0x0066626B
		public IHonamiStoryEvacuateConfirmBoxT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
		}
	}
}
