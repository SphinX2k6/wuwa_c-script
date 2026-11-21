using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004137 RID: 16695
	public class IAtomicProcessStoveCoreFallT
	{
		// Token: 0x17007110 RID: 28944
		// (get) Token: 0x06016EC3 RID: 93891 RVA: 0x0034571F File Offset: 0x0034391F
		// (set) Token: 0x06016EC4 RID: 93892 RVA: 0x00345727 File Offset: 0x00343927
		public EAtomicProcess Type { get; set; }

		// Token: 0x17007111 RID: 28945
		// (get) Token: 0x06016EC5 RID: 93893 RVA: 0x00345730 File Offset: 0x00343930
		// (set) Token: 0x06016EC6 RID: 93894 RVA: 0x00345738 File Offset: 0x00343938
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x06016EC7 RID: 93895 RVA: 0x00345741 File Offset: 0x00343941
		public IAtomicProcessStoveCoreFallT()
		{
			this.Type = EAtomicProcess.StoveCoreFall;
			this.SplineEntityIds = null;
		}
	}
}
