using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200480A RID: 18442
	public class INodeRefOccupationsT
	{
		// Token: 0x170080A5 RID: 32933
		// (get) Token: 0x0601B430 RID: 111664 RVA: 0x003DCCC3 File Offset: 0x003DAEC3
		// (set) Token: 0x0601B431 RID: 111665 RVA: 0x003DCCCB File Offset: 0x003DAECB
		public int NodeId { get; set; }

		// Token: 0x170080A6 RID: 32934
		// (get) Token: 0x0601B432 RID: 111666 RVA: 0x003DCCD4 File Offset: 0x003DAED4
		// (set) Token: 0x0601B433 RID: 111667 RVA: 0x003DCCDC File Offset: 0x003DAEDC
		public List<INodeRefOccupationDataT> Occupations { get; set; }

		// Token: 0x0601B434 RID: 111668 RVA: 0x003DCCE5 File Offset: 0x003DAEE5
		public INodeRefOccupationsT()
		{
			this.NodeId = 0;
			this.Occupations = null;
		}
	}
}
