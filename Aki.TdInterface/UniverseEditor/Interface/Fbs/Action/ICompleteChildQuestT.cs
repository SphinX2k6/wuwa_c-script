using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B22 RID: 27426
	public class ICompleteChildQuestT
	{
		// Token: 0x1700C964 RID: 51556
		// (get) Token: 0x0602F2CE RID: 193230 RVA: 0x0066E844 File Offset: 0x0066CA44
		// (set) Token: 0x0602F2CF RID: 193231 RVA: 0x0066E84C File Offset: 0x0066CA4C
		public int QuestId { get; set; }

		// Token: 0x1700C965 RID: 51557
		// (get) Token: 0x0602F2D0 RID: 193232 RVA: 0x0066E855 File Offset: 0x0066CA55
		// (set) Token: 0x0602F2D1 RID: 193233 RVA: 0x0066E85D File Offset: 0x0066CA5D
		public int NodeId { get; set; }

		// Token: 0x0602F2D2 RID: 193234 RVA: 0x0066E866 File Offset: 0x0066CA66
		public ICompleteChildQuestT()
		{
			this.QuestId = 0;
			this.NodeId = 0;
		}
	}
}
