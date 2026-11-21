using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005614 RID: 22036
	public class IDollGrabStandbyPoolItemT
	{
		// Token: 0x17009E09 RID: 40457
		// (get) Token: 0x06023247 RID: 143943 RVA: 0x004D642C File Offset: 0x004D462C
		// (set) Token: 0x06023248 RID: 143944 RVA: 0x004D6434 File Offset: 0x004D4634
		public int UniqueId { get; set; }

		// Token: 0x17009E0A RID: 40458
		// (get) Token: 0x06023249 RID: 143945 RVA: 0x004D643D File Offset: 0x004D463D
		// (set) Token: 0x0602324A RID: 143946 RVA: 0x004D6445 File Offset: 0x004D4645
		public int ItemId { get; set; }

		// Token: 0x0602324B RID: 143947 RVA: 0x004D644E File Offset: 0x004D464E
		public IDollGrabStandbyPoolItemT()
		{
			this.UniqueId = 0;
			this.ItemId = 0;
		}
	}
}
