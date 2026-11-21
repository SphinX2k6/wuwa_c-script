using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005842 RID: 22594
	public class IFreeAngleTurntableT
	{
		// Token: 0x1700A3A2 RID: 41890
		// (get) Token: 0x06024979 RID: 149881 RVA: 0x0050716B File Offset: 0x0050536B
		// (set) Token: 0x0602497A RID: 149882 RVA: 0x00507173 File Offset: 0x00505373
		public EControllerType Type { get; set; }

		// Token: 0x1700A3A3 RID: 41891
		// (get) Token: 0x0602497B RID: 149883 RVA: 0x0050717C File Offset: 0x0050537C
		// (set) Token: 0x0602497C RID: 149884 RVA: 0x00507184 File Offset: 0x00505384
		public int RotationSpeed { get; set; }

		// Token: 0x1700A3A4 RID: 41892
		// (get) Token: 0x0602497D RID: 149885 RVA: 0x0050718D File Offset: 0x0050538D
		// (set) Token: 0x0602497E RID: 149886 RVA: 0x00507195 File Offset: 0x00505395
		public List<IFreeAngleItemT> ItemConfig { get; set; }

		// Token: 0x1700A3A5 RID: 41893
		// (get) Token: 0x0602497F RID: 149887 RVA: 0x0050719E File Offset: 0x0050539E
		// (set) Token: 0x06024980 RID: 149888 RVA: 0x005071A6 File Offset: 0x005053A6
		public int IntervalAngle { get; set; }

		// Token: 0x06024981 RID: 149889 RVA: 0x005071AF File Offset: 0x005053AF
		public IFreeAngleTurntableT()
		{
			this.Type = EControllerType.FreeAngle;
			this.RotationSpeed = 0;
			this.ItemConfig = null;
			this.IntervalAngle = 0;
		}
	}
}
