using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F0C RID: 16140
	public class IListenToEventT
	{
		// Token: 0x17006FF5 RID: 28661
		// (get) Token: 0x06016DAA RID: 93610 RVA: 0x0034B9E5 File Offset: 0x00349BE5
		// (set) Token: 0x06016DAB RID: 93611 RVA: 0x0034B9ED File Offset: 0x00349BED
		public EChildQuest Type { get; set; }

		// Token: 0x17006FF6 RID: 28662
		// (get) Token: 0x06016DAC RID: 93612 RVA: 0x0034B9F6 File Offset: 0x00349BF6
		// (set) Token: 0x06016DAD RID: 93613 RVA: 0x0034B9FE File Offset: 0x00349BFE
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006FF7 RID: 28663
		// (get) Token: 0x06016DAE RID: 93614 RVA: 0x0034BA07 File Offset: 0x00349C07
		// (set) Token: 0x06016DAF RID: 93615 RVA: 0x0034BA0F File Offset: 0x00349C0F
		public TCommonEventTypeUnion EventType { get; set; }

		// Token: 0x06016DB0 RID: 93616 RVA: 0x0034BA18 File Offset: 0x00349C18
		public IListenToEventT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EventType = null;
		}
	}
}
