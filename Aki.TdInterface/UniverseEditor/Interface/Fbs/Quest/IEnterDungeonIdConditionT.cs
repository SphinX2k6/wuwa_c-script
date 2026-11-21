using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004239 RID: 16953
	public class IEnterDungeonIdConditionT
	{
		// Token: 0x17007394 RID: 29588
		// (get) Token: 0x0601795E RID: 96606 RVA: 0x0035D78C File Offset: 0x0035B98C
		// (set) Token: 0x0601795F RID: 96607 RVA: 0x0035D794 File Offset: 0x0035B994
		public EDungeonConditionType Type { get; set; }

		// Token: 0x17007395 RID: 29589
		// (get) Token: 0x06017960 RID: 96608 RVA: 0x0035D79D File Offset: 0x0035B99D
		// (set) Token: 0x06017961 RID: 96609 RVA: 0x0035D7A5 File Offset: 0x0035B9A5
		public int DungeonId { get; set; }

		// Token: 0x06017962 RID: 96610 RVA: 0x0035D7AE File Offset: 0x0035B9AE
		public IEnterDungeonIdConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.DungeonId = 0;
		}
	}
}
