using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004428 RID: 17448
	public class IQuestFailedConditionPlayerMovementModeT
	{
		// Token: 0x170078CE RID: 30926
		// (get) Token: 0x06018F5C RID: 102236 RVA: 0x0038F3B8 File Offset: 0x0038D5B8
		// (set) Token: 0x06018F5D RID: 102237 RVA: 0x0038F3C0 File Offset: 0x0038D5C0
		public EPlayerMovementMode Mode { get; set; }

		// Token: 0x170078CF RID: 30927
		// (get) Token: 0x06018F5E RID: 102238 RVA: 0x0038F3C9 File Offset: 0x0038D5C9
		// (set) Token: 0x06018F5F RID: 102239 RVA: 0x0038F3D1 File Offset: 0x0038D5D1
		public ECompare Compare { get; set; }

		// Token: 0x06018F60 RID: 102240 RVA: 0x0038F3DA File Offset: 0x0038D5DA
		public IQuestFailedConditionPlayerMovementModeT()
		{
			this.Mode = EPlayerMovementMode.Ski;
			this.Compare = ECompare.Eq;
		}
	}
}
