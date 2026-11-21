using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051FA RID: 20986
	public class ITrafficMatchTargetByEntityLogicT
	{
		// Token: 0x1700963D RID: 38461
		// (get) Token: 0x060210E1 RID: 135393 RVA: 0x00491673 File Offset: 0x0048F873
		// (set) Token: 0x060210E2 RID: 135394 RVA: 0x0049167B File Offset: 0x0048F87B
		public ETrafficMatchTargetType Type { get; set; }

		// Token: 0x1700963E RID: 38462
		// (get) Token: 0x060210E3 RID: 135395 RVA: 0x00491684 File Offset: 0x0048F884
		// (set) Token: 0x060210E4 RID: 135396 RVA: 0x0049168C File Offset: 0x0048F88C
		public List<EEntityLogic> EntityLogicTypes { get; set; }

		// Token: 0x060210E5 RID: 135397 RVA: 0x00491695 File Offset: 0x0048F895
		public ITrafficMatchTargetByEntityLogicT()
		{
			this.Type = ETrafficMatchTargetType.MatchByEntityLogic;
			this.EntityLogicTypes = null;
		}
	}
}
