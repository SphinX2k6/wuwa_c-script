using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200469E RID: 18078
	public class IUseItemConditionT
	{
		// Token: 0x17007EA0 RID: 32416
		// (get) Token: 0x0601A8CD RID: 108749 RVA: 0x003C7083 File Offset: 0x003C5283
		// (set) Token: 0x0601A8CE RID: 108750 RVA: 0x003C708B File Offset: 0x003C528B
		public int ItemId { get; set; }

		// Token: 0x17007EA1 RID: 32417
		// (get) Token: 0x0601A8CF RID: 108751 RVA: 0x003C7094 File Offset: 0x003C5294
		// (set) Token: 0x0601A8D0 RID: 108752 RVA: 0x003C709C File Offset: 0x003C529C
		public int Count { get; set; }

		// Token: 0x17007EA2 RID: 32418
		// (get) Token: 0x0601A8D1 RID: 108753 RVA: 0x003C70A5 File Offset: 0x003C52A5
		// (set) Token: 0x0601A8D2 RID: 108754 RVA: 0x003C70AD File Offset: 0x003C52AD
		public EChildQuest Type { get; set; }

		// Token: 0x17007EA3 RID: 32419
		// (get) Token: 0x0601A8D3 RID: 108755 RVA: 0x003C70B6 File Offset: 0x003C52B6
		// (set) Token: 0x0601A8D4 RID: 108756 RVA: 0x003C70BE File Offset: 0x003C52BE
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x0601A8D5 RID: 108757 RVA: 0x003C70C7 File Offset: 0x003C52C7
		public IUseItemConditionT()
		{
			this.ItemId = 0;
			this.Count = 0;
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
		}
	}
}
