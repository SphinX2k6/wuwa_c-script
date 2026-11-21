using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200434A RID: 17226
	public class IListenToEventT
	{
		// Token: 0x170075E4 RID: 30180
		// (get) Token: 0x06018401 RID: 99329 RVA: 0x00374BB1 File Offset: 0x00372DB1
		// (set) Token: 0x06018402 RID: 99330 RVA: 0x00374BB9 File Offset: 0x00372DB9
		public EChildQuest Type { get; set; }

		// Token: 0x170075E5 RID: 30181
		// (get) Token: 0x06018403 RID: 99331 RVA: 0x00374BC2 File Offset: 0x00372DC2
		// (set) Token: 0x06018404 RID: 99332 RVA: 0x00374BCA File Offset: 0x00372DCA
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170075E6 RID: 30182
		// (get) Token: 0x06018405 RID: 99333 RVA: 0x00374BD3 File Offset: 0x00372DD3
		// (set) Token: 0x06018406 RID: 99334 RVA: 0x00374BDB File Offset: 0x00372DDB
		public TCommonEventTypeUnion EventType { get; set; }

		// Token: 0x06018407 RID: 99335 RVA: 0x00374BE4 File Offset: 0x00372DE4
		public IListenToEventT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EventType = null;
		}
	}
}
