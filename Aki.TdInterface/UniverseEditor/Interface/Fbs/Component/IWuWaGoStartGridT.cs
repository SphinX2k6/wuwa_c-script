using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDD RID: 23517
	public class IWuWaGoStartGridT
	{
		// Token: 0x1700B1BB RID: 45499
		// (get) Token: 0x060284ED RID: 165101 RVA: 0x00589E37 File Offset: 0x00588037
		// (set) Token: 0x060284EE RID: 165102 RVA: 0x00589E3F File Offset: 0x0058803F
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B1BC RID: 45500
		// (get) Token: 0x060284EF RID: 165103 RVA: 0x00589E48 File Offset: 0x00588048
		// (set) Token: 0x060284F0 RID: 165104 RVA: 0x00589E50 File Offset: 0x00588050
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700B1BD RID: 45501
		// (get) Token: 0x060284F1 RID: 165105 RVA: 0x00589E59 File Offset: 0x00588059
		// (set) Token: 0x060284F2 RID: 165106 RVA: 0x00589E61 File Offset: 0x00588061
		public List<TWuWaGoHintStepUnion> HintSteps { get; set; }

		// Token: 0x1700B1BE RID: 45502
		// (get) Token: 0x060284F3 RID: 165107 RVA: 0x00589E6A File Offset: 0x0058806A
		// (set) Token: 0x060284F4 RID: 165108 RVA: 0x00589E72 File Offset: 0x00588072
		public byte NullMask { get; set; }

		// Token: 0x060284F5 RID: 165109 RVA: 0x00589E7B File Offset: 0x0058807B
		public IWuWaGoStartGridT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.HintSteps = null;
			this.NullMask = 0;
		}
	}
}
