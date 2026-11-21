using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005728 RID: 22312
	public class IEntityTrackControlPointT
	{
		// Token: 0x1700A10F RID: 41231
		// (get) Token: 0x06023E1C RID: 146972 RVA: 0x004EECE2 File Offset: 0x004ECEE2
		// (set) Token: 0x06023E1D RID: 146973 RVA: 0x004EECEA File Offset: 0x004ECEEA
		public string State { get; set; }

		// Token: 0x1700A110 RID: 41232
		// (get) Token: 0x06023E1E RID: 146974 RVA: 0x004EECF3 File Offset: 0x004ECEF3
		// (set) Token: 0x06023E1F RID: 146975 RVA: 0x004EECFB File Offset: 0x004ECEFB
		public IConditionGroupT LeftCondition { get; set; }

		// Token: 0x1700A111 RID: 41233
		// (get) Token: 0x06023E20 RID: 146976 RVA: 0x004EED04 File Offset: 0x004ECF04
		// (set) Token: 0x06023E21 RID: 146977 RVA: 0x004EED0C File Offset: 0x004ECF0C
		public IConditionGroupT RightCondition { get; set; }

		// Token: 0x06023E22 RID: 146978 RVA: 0x004EED15 File Offset: 0x004ECF15
		public IEntityTrackControlPointT()
		{
			this.State = null;
			this.LeftCondition = null;
			this.RightCondition = null;
		}
	}
}
