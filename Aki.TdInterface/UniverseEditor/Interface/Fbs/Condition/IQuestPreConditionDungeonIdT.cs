using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA7 RID: 19623
	public class IQuestPreConditionDungeonIdT
	{
		// Token: 0x17008E75 RID: 36469
		// (get) Token: 0x0601F209 RID: 127497 RVA: 0x004590B8 File Offset: 0x004572B8
		// (set) Token: 0x0601F20A RID: 127498 RVA: 0x004590C0 File Offset: 0x004572C0
		public EQuestPreConditionDungeonType Type { get; set; }

		// Token: 0x17008E76 RID: 36470
		// (get) Token: 0x0601F20B RID: 127499 RVA: 0x004590C9 File Offset: 0x004572C9
		// (set) Token: 0x0601F20C RID: 127500 RVA: 0x004590D1 File Offset: 0x004572D1
		public int DungeonId { get; set; }

		// Token: 0x0601F20D RID: 127501 RVA: 0x004590DA File Offset: 0x004572DA
		public IQuestPreConditionDungeonIdT()
		{
			this.Type = EQuestPreConditionDungeonType.DungeonId;
			this.DungeonId = 0;
		}
	}
}
