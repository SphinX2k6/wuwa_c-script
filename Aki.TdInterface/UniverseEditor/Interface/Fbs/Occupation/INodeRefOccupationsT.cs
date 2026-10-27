using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A8 RID: 17320
	public class INodeRefOccupationsT
	{
		// Token: 0x17007A70 RID: 31344
		// (get) Token: 0x06019CA2 RID: 105634 RVA: 0x003B129B File Offset: 0x003AF49B
		// (set) Token: 0x06019CA3 RID: 105635 RVA: 0x003B12A3 File Offset: 0x003AF4A3
		public int NodeId { get; set; }

		// Token: 0x17007A71 RID: 31345
		// (get) Token: 0x06019CA4 RID: 105636 RVA: 0x003B12AC File Offset: 0x003AF4AC
		// (set) Token: 0x06019CA5 RID: 105637 RVA: 0x003B12B4 File Offset: 0x003AF4B4
		public List<INodeRefOccupationDataT> Occupations { get; set; }

		// Token: 0x06019CA6 RID: 105638 RVA: 0x003B12BD File Offset: 0x003AF4BD
		public INodeRefOccupationsT()
		{
			this.NodeId = 0;
			this.Occupations = null;
		}
	}
}
