using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E3 RID: 22243
	public class IEntityGroupFailureArbitraryStateT
	{
		// Token: 0x1700A05E RID: 41054
		// (get) Token: 0x06023B17 RID: 146199 RVA: 0x004E866F File Offset: 0x004E686F
		// (set) Token: 0x06023B18 RID: 146200 RVA: 0x004E8677 File Offset: 0x004E6877
		public EEntityGroupFailureCondition Type { get; set; }

		// Token: 0x1700A05F RID: 41055
		// (get) Token: 0x06023B19 RID: 146201 RVA: 0x004E8680 File Offset: 0x004E6880
		// (set) Token: 0x06023B1A RID: 146202 RVA: 0x004E8688 File Offset: 0x004E6888
		public string State { get; set; }

		// Token: 0x06023B1B RID: 146203 RVA: 0x004E8691 File Offset: 0x004E6891
		public IEntityGroupFailureArbitraryStateT()
		{
			this.Type = EEntityGroupFailureCondition.SequentialState;
			this.State = null;
		}
	}
}
