using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED0 RID: 20176
	public class ICheckEntityPositionT
	{
		// Token: 0x1700900E RID: 36878
		// (get) Token: 0x0601F50A RID: 128266 RVA: 0x0045D533 File Offset: 0x0045B733
		// (set) Token: 0x0601F50B RID: 128267 RVA: 0x0045D53B File Offset: 0x0045B73B
		public ECondition Type { get; set; }

		// Token: 0x1700900F RID: 36879
		// (get) Token: 0x0601F50C RID: 128268 RVA: 0x0045D544 File Offset: 0x0045B744
		// (set) Token: 0x0601F50D RID: 128269 RVA: 0x0045D54C File Offset: 0x0045B74C
		public int EntityId { get; set; }

		// Token: 0x17009010 RID: 36880
		// (get) Token: 0x0601F50E RID: 128270 RVA: 0x0045D555 File Offset: 0x0045B755
		// (set) Token: 0x0601F50F RID: 128271 RVA: 0x0045D55D File Offset: 0x0045B75D
		public TRangeUnion Range { get; set; }

		// Token: 0x17009011 RID: 36881
		// (get) Token: 0x0601F510 RID: 128272 RVA: 0x0045D566 File Offset: 0x0045B766
		// (set) Token: 0x0601F511 RID: 128273 RVA: 0x0045D56E File Offset: 0x0045B76E
		public bool IsOnRange { get; set; }

		// Token: 0x0601F512 RID: 128274 RVA: 0x0045D577 File Offset: 0x0045B777
		public ICheckEntityPositionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.Range = null;
			this.IsOnRange = false;
		}
	}
}
