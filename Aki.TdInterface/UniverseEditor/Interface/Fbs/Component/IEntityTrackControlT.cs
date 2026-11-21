using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005725 RID: 22309
	public class IEntityTrackControlT
	{
		// Token: 0x1700A108 RID: 41224
		// (get) Token: 0x06023E00 RID: 146944 RVA: 0x004EE929 File Offset: 0x004ECB29
		// (set) Token: 0x06023E01 RID: 146945 RVA: 0x004EE931 File Offset: 0x004ECB31
		public ETrackControlMode Type { get; set; }

		// Token: 0x1700A109 RID: 41225
		// (get) Token: 0x06023E02 RID: 146946 RVA: 0x004EE93A File Offset: 0x004ECB3A
		// (set) Token: 0x06023E03 RID: 146947 RVA: 0x004EE942 File Offset: 0x004ECB42
		public int EntityId { get; set; }

		// Token: 0x1700A10A RID: 41226
		// (get) Token: 0x06023E04 RID: 146948 RVA: 0x004EE94B File Offset: 0x004ECB4B
		// (set) Token: 0x06023E05 RID: 146949 RVA: 0x004EE953 File Offset: 0x004ECB53
		public List<IEntityTrackControlPointT> ControlPoints { get; set; }

		// Token: 0x06023E06 RID: 146950 RVA: 0x004EE95C File Offset: 0x004ECB5C
		public IEntityTrackControlT()
		{
			this.Type = ETrackControlMode.Sequence;
			this.EntityId = 0;
			this.ControlPoints = null;
		}
	}
}
