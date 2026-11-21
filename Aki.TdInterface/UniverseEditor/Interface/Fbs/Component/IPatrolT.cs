using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF1 RID: 23793
	public class IPatrolT
	{
		// Token: 0x1700AED9 RID: 44761
		// (get) Token: 0x06027838 RID: 161848 RVA: 0x00568368 File Offset: 0x00566568
		// (set) Token: 0x06027839 RID: 161849 RVA: 0x00568370 File Offset: 0x00566570
		public bool Disabled { get; set; }

		// Token: 0x1700AEDA RID: 44762
		// (get) Token: 0x0602783A RID: 161850 RVA: 0x00568379 File Offset: 0x00566579
		// (set) Token: 0x0602783B RID: 161851 RVA: 0x00568381 File Offset: 0x00566581
		public int SplineEntityId { get; set; }

		// Token: 0x1700AEDB RID: 44763
		// (get) Token: 0x0602783C RID: 161852 RVA: 0x0056838A File Offset: 0x0056658A
		// (set) Token: 0x0602783D RID: 161853 RVA: 0x00568392 File Offset: 0x00566592
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x1700AEDC RID: 44764
		// (get) Token: 0x0602783E RID: 161854 RVA: 0x0056839B File Offset: 0x0056659B
		// (set) Token: 0x0602783F RID: 161855 RVA: 0x005683A3 File Offset: 0x005665A3
		public bool IsCircle { get; set; }

		// Token: 0x1700AEDD RID: 44765
		// (get) Token: 0x06027840 RID: 161856 RVA: 0x005683AC File Offset: 0x005665AC
		// (set) Token: 0x06027841 RID: 161857 RVA: 0x005683B4 File Offset: 0x005665B4
		public List<IPatrolActionT> Actions { get; set; }

		// Token: 0x1700AEDE RID: 44766
		// (get) Token: 0x06027842 RID: 161858 RVA: 0x005683BD File Offset: 0x005665BD
		// (set) Token: 0x06027843 RID: 161859 RVA: 0x005683C5 File Offset: 0x005665C5
		public byte NullMask { get; set; }

		// Token: 0x06027844 RID: 161860 RVA: 0x005683CE File Offset: 0x005665CE
		public IPatrolT()
		{
			this.Disabled = false;
			this.SplineEntityId = 0;
			this.SplineEntityIds = null;
			this.IsCircle = false;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
