using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007265 RID: 29285
	public class IMotorRadioDisableByRangeEntitiesT
	{
		// Token: 0x1700D6BD RID: 54973
		// (get) Token: 0x06033086 RID: 209030 RVA: 0x006E37C3 File Offset: 0x006E19C3
		// (set) Token: 0x06033087 RID: 209031 RVA: 0x006E37CB File Offset: 0x006E19CB
		public EMotorRadioDisableRangeType Type { get; set; }

		// Token: 0x1700D6BE RID: 54974
		// (get) Token: 0x06033088 RID: 209032 RVA: 0x006E37D4 File Offset: 0x006E19D4
		// (set) Token: 0x06033089 RID: 209033 RVA: 0x006E37DC File Offset: 0x006E19DC
		public List<int> RangeEntities { get; set; }

		// Token: 0x0603308A RID: 209034 RVA: 0x006E37E5 File Offset: 0x006E19E5
		public IMotorRadioDisableByRangeEntitiesT()
		{
			this.Type = EMotorRadioDisableRangeType.ByAreaId;
			this.RangeEntities = null;
		}
	}
}
