using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200604E RID: 24654
	public class ITeleControlDestroyConditionT
	{
		// Token: 0x1700B70E RID: 46862
		// (get) Token: 0x06029A28 RID: 170536 RVA: 0x005AF3DE File Offset: 0x005AD5DE
		// (set) Token: 0x06029A29 RID: 170537 RVA: 0x005AF3E6 File Offset: 0x005AD5E6
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x06029A2A RID: 170538 RVA: 0x005AF3EF File Offset: 0x005AD5EF
		public ITeleControlDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
		}
	}
}
