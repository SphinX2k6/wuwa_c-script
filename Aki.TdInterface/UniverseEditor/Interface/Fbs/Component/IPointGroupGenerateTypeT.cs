using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D68 RID: 23912
	public class IPointGroupGenerateTypeT
	{
		// Token: 0x1700B001 RID: 45057
		// (get) Token: 0x06027CF3 RID: 163059 RVA: 0x005722C6 File Offset: 0x005704C6
		// (set) Token: 0x06027CF4 RID: 163060 RVA: 0x005722CE File Offset: 0x005704CE
		public EPointGroupGenerateType Type { get; set; }

		// Token: 0x06027CF5 RID: 163061 RVA: 0x005722D7 File Offset: 0x005704D7
		public IPointGroupGenerateTypeT()
		{
			this.Type = EPointGroupGenerateType.Layer;
		}
	}
}
