using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFC RID: 28156
	public class IQuestBranchConfigT
	{
		// Token: 0x1700D1DC RID: 53724
		// (get) Token: 0x06031BD5 RID: 203733 RVA: 0x006BC0A0 File Offset: 0x006BA2A0
		// (set) Token: 0x06031BD6 RID: 203734 RVA: 0x006BC0A8 File Offset: 0x006BA2A8
		public bool EnableAnimation { get; set; }

		// Token: 0x1700D1DD RID: 53725
		// (get) Token: 0x06031BD7 RID: 203735 RVA: 0x006BC0B1 File Offset: 0x006BA2B1
		// (set) Token: 0x06031BD8 RID: 203736 RVA: 0x006BC0B9 File Offset: 0x006BA2B9
		public byte NullMask { get; set; }

		// Token: 0x06031BD9 RID: 203737 RVA: 0x006BC0C2 File Offset: 0x006BA2C2
		public IQuestBranchConfigT()
		{
			this.EnableAnimation = false;
			this.NullMask = 0;
		}
	}
}
