using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B90 RID: 19344
	public class ICameraDataT
	{
		// Token: 0x170088D1 RID: 35025
		// (get) Token: 0x0601D7AA RID: 120746 RVA: 0x004239A2 File Offset: 0x00421BA2
		// (set) Token: 0x0601D7AB RID: 120747 RVA: 0x004239AA File Offset: 0x00421BAA
		public IVectorInfoT Pos { get; set; }

		// Token: 0x170088D2 RID: 35026
		// (get) Token: 0x0601D7AC RID: 120748 RVA: 0x004239B3 File Offset: 0x00421BB3
		// (set) Token: 0x0601D7AD RID: 120749 RVA: 0x004239BB File Offset: 0x00421BBB
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0601D7AE RID: 120750 RVA: 0x004239C4 File Offset: 0x00421BC4
		public ICameraDataT()
		{
			this.Pos = null;
			this.Rot = null;
		}
	}
}
