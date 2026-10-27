using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B90 RID: 15248
	public class ICheckpointDisplayT
	{
		// Token: 0x17006881 RID: 26753
		// (get) Token: 0x06014E30 RID: 85552 RVA: 0x00307FA2 File Offset: 0x003061A2
		// (set) Token: 0x06014E31 RID: 85553 RVA: 0x00307FAA File Offset: 0x003061AA
		public ECheckpointDisplayType Type { get; set; }

		// Token: 0x06014E32 RID: 85554 RVA: 0x00307FB3 File Offset: 0x003061B3
		public ICheckpointDisplayT()
		{
			this.Type = ECheckpointDisplayType.Role;
		}
	}
}
