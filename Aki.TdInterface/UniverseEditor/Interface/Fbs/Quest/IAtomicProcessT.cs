using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412E RID: 16686
	public class IAtomicProcessT
	{
		// Token: 0x17007105 RID: 28933
		// (get) Token: 0x06016E85 RID: 93829 RVA: 0x00345119 File Offset: 0x00343319
		// (set) Token: 0x06016E86 RID: 93830 RVA: 0x00345121 File Offset: 0x00343321
		public EChildQuest Type { get; set; }

		// Token: 0x17007106 RID: 28934
		// (get) Token: 0x06016E87 RID: 93831 RVA: 0x0034512A File Offset: 0x0034332A
		// (set) Token: 0x06016E88 RID: 93832 RVA: 0x00345132 File Offset: 0x00343332
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007107 RID: 28935
		// (get) Token: 0x06016E89 RID: 93833 RVA: 0x0034513B File Offset: 0x0034333B
		// (set) Token: 0x06016E8A RID: 93834 RVA: 0x00345143 File Offset: 0x00343343
		public IAtomicProcessStoveCoreFallT AtomicProcessType { get; set; }

		// Token: 0x06016E8B RID: 93835 RVA: 0x0034514C File Offset: 0x0034334C
		public IAtomicProcessT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.AtomicProcessType = null;
		}
	}
}
