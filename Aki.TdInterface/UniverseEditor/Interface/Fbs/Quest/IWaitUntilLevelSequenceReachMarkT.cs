using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004287 RID: 17031
	public class IWaitUntilLevelSequenceReachMarkT
	{
		// Token: 0x170078EE RID: 30958
		// (get) Token: 0x0601939C RID: 103324 RVA: 0x0039FC27 File Offset: 0x0039DE27
		// (set) Token: 0x0601939D RID: 103325 RVA: 0x0039FC2F File Offset: 0x0039DE2F
		public EChildQuest Type { get; set; }

		// Token: 0x170078EF RID: 30959
		// (get) Token: 0x0601939E RID: 103326 RVA: 0x0039FC38 File Offset: 0x0039DE38
		// (set) Token: 0x0601939F RID: 103327 RVA: 0x0039FC40 File Offset: 0x0039DE40
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170078F0 RID: 30960
		// (get) Token: 0x060193A0 RID: 103328 RVA: 0x0039FC49 File Offset: 0x0039DE49
		// (set) Token: 0x060193A1 RID: 103329 RVA: 0x0039FC51 File Offset: 0x0039DE51
		public int EntityId { get; set; }

		// Token: 0x170078F1 RID: 30961
		// (get) Token: 0x060193A2 RID: 103330 RVA: 0x0039FC5A File Offset: 0x0039DE5A
		// (set) Token: 0x060193A3 RID: 103331 RVA: 0x0039FC62 File Offset: 0x0039DE62
		public string Mark { get; set; }

		// Token: 0x060193A4 RID: 103332 RVA: 0x0039FC6B File Offset: 0x0039DE6B
		public IWaitUntilLevelSequenceReachMarkT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityId = 0;
			this.Mark = null;
		}
	}
}
