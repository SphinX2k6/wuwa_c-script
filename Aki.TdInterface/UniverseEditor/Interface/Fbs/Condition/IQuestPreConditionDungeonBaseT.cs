using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA1 RID: 19617
	public class IQuestPreConditionDungeonBaseT
	{
		// Token: 0x17008E6F RID: 36463
		// (get) Token: 0x0601F1E9 RID: 127465 RVA: 0x00458DE2 File Offset: 0x00456FE2
		// (set) Token: 0x0601F1EA RID: 127466 RVA: 0x00458DEA File Offset: 0x00456FEA
		public EQuestPreConditionDungeonType Type { get; set; }

		// Token: 0x0601F1EB RID: 127467 RVA: 0x00458DF3 File Offset: 0x00456FF3
		public IQuestPreConditionDungeonBaseT()
		{
			this.Type = EQuestPreConditionDungeonType.DungeonId;
		}
	}
}
