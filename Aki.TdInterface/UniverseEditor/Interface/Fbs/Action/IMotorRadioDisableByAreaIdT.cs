using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007262 RID: 29282
	public class IMotorRadioDisableByAreaIdT
	{
		// Token: 0x1700D6B8 RID: 54968
		// (get) Token: 0x06033068 RID: 209000 RVA: 0x006E3497 File Offset: 0x006E1697
		// (set) Token: 0x06033069 RID: 209001 RVA: 0x006E349F File Offset: 0x006E169F
		public EMotorRadioDisableRangeType Type { get; set; }

		// Token: 0x1700D6B9 RID: 54969
		// (get) Token: 0x0603306A RID: 209002 RVA: 0x006E34A8 File Offset: 0x006E16A8
		// (set) Token: 0x0603306B RID: 209003 RVA: 0x006E34B0 File Offset: 0x006E16B0
		public List<int> AreaIdList { get; set; }

		// Token: 0x0603306C RID: 209004 RVA: 0x006E34B9 File Offset: 0x006E16B9
		public IMotorRadioDisableByAreaIdT()
		{
			this.Type = EMotorRadioDisableRangeType.ByAreaId;
			this.AreaIdList = null;
		}
	}
}
