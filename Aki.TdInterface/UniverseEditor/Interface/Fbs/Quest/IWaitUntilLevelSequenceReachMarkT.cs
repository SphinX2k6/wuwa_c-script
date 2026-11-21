using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E3 RID: 18147
	public class IWaitUntilLevelSequenceReachMarkT
	{
		// Token: 0x17007F1F RID: 32543
		// (get) Token: 0x0601AB08 RID: 109320 RVA: 0x003CB2FF File Offset: 0x003C94FF
		// (set) Token: 0x0601AB09 RID: 109321 RVA: 0x003CB307 File Offset: 0x003C9507
		public EChildQuest Type { get; set; }

		// Token: 0x17007F20 RID: 32544
		// (get) Token: 0x0601AB0A RID: 109322 RVA: 0x003CB310 File Offset: 0x003C9510
		// (set) Token: 0x0601AB0B RID: 109323 RVA: 0x003CB318 File Offset: 0x003C9518
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007F21 RID: 32545
		// (get) Token: 0x0601AB0C RID: 109324 RVA: 0x003CB321 File Offset: 0x003C9521
		// (set) Token: 0x0601AB0D RID: 109325 RVA: 0x003CB329 File Offset: 0x003C9529
		public int EntityId { get; set; }

		// Token: 0x17007F22 RID: 32546
		// (get) Token: 0x0601AB0E RID: 109326 RVA: 0x003CB332 File Offset: 0x003C9532
		// (set) Token: 0x0601AB0F RID: 109327 RVA: 0x003CB33A File Offset: 0x003C953A
		public string Mark { get; set; }

		// Token: 0x0601AB10 RID: 109328 RVA: 0x003CB343 File Offset: 0x003C9543
		public IWaitUntilLevelSequenceReachMarkT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityId = 0;
			this.Mark = null;
		}
	}
}
