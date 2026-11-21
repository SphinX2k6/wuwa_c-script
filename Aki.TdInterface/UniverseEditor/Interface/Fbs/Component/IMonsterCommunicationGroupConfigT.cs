using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0E RID: 23310
	public class IMonsterCommunicationGroupConfigT
	{
		// Token: 0x1700AA15 RID: 43541
		// (get) Token: 0x060264D8 RID: 156888 RVA: 0x0053F26A File Offset: 0x0053D46A
		// (set) Token: 0x060264D9 RID: 156889 RVA: 0x0053F272 File Offset: 0x0053D472
		public int GroupId { get; set; }

		// Token: 0x060264DA RID: 156890 RVA: 0x0053F27B File Offset: 0x0053D47B
		public IMonsterCommunicationGroupConfigT()
		{
			this.GroupId = 0;
		}
	}
}
