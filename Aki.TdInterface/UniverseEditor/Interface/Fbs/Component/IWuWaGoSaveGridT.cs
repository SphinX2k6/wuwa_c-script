using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD7 RID: 23511
	public class IWuWaGoSaveGridT
	{
		// Token: 0x1700B1AC RID: 45484
		// (get) Token: 0x060284A9 RID: 165033 RVA: 0x005894BF File Offset: 0x005876BF
		// (set) Token: 0x060284AA RID: 165034 RVA: 0x005894C7 File Offset: 0x005876C7
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B1AD RID: 45485
		// (get) Token: 0x060284AB RID: 165035 RVA: 0x005894D0 File Offset: 0x005876D0
		// (set) Token: 0x060284AC RID: 165036 RVA: 0x005894D8 File Offset: 0x005876D8
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700B1AE RID: 45486
		// (get) Token: 0x060284AD RID: 165037 RVA: 0x005894E1 File Offset: 0x005876E1
		// (set) Token: 0x060284AE RID: 165038 RVA: 0x005894E9 File Offset: 0x005876E9
		public List<TWuWaGoHintStepUnion> HintSteps { get; set; }

		// Token: 0x1700B1AF RID: 45487
		// (get) Token: 0x060284AF RID: 165039 RVA: 0x005894F2 File Offset: 0x005876F2
		// (set) Token: 0x060284B0 RID: 165040 RVA: 0x005894FA File Offset: 0x005876FA
		public byte NullMask { get; set; }

		// Token: 0x060284B1 RID: 165041 RVA: 0x00589503 File Offset: 0x00587703
		public IWuWaGoSaveGridT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.HintSteps = null;
			this.NullMask = 0;
		}
	}
}
