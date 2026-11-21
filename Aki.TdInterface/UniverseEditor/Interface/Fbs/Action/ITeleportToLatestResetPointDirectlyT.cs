using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B76 RID: 31606
	public class ITeleportToLatestResetPointDirectlyT
	{
		// Token: 0x1700ECA4 RID: 60580
		// (get) Token: 0x06038EC8 RID: 233160 RVA: 0x007B1E4A File Offset: 0x007B004A
		// (set) Token: 0x06038EC9 RID: 233161 RVA: 0x007B1E52 File Offset: 0x007B0052
		public ETeleportToLatestResetPointType Type { get; set; }

		// Token: 0x06038ECA RID: 233162 RVA: 0x007B1E5B File Offset: 0x007B005B
		public ITeleportToLatestResetPointDirectlyT()
		{
			this.Type = ETeleportToLatestResetPointType.Directly;
		}
	}
}
