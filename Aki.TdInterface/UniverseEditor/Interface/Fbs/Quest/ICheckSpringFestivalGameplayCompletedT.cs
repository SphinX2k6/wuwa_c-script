using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D65 RID: 15717
	public class ICheckSpringFestivalGameplayCompletedT
	{
		// Token: 0x17006BDE RID: 27614
		// (get) Token: 0x06015BFD RID: 89085 RVA: 0x00323089 File Offset: 0x00321289
		// (set) Token: 0x06015BFE RID: 89086 RVA: 0x00323091 File Offset: 0x00321291
		public EChildQuest Type { get; set; }

		// Token: 0x17006BDF RID: 27615
		// (get) Token: 0x06015BFF RID: 89087 RVA: 0x0032309A File Offset: 0x0032129A
		// (set) Token: 0x06015C00 RID: 89088 RVA: 0x003230A2 File Offset: 0x003212A2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006BE0 RID: 27616
		// (get) Token: 0x06015C01 RID: 89089 RVA: 0x003230AB File Offset: 0x003212AB
		// (set) Token: 0x06015C02 RID: 89090 RVA: 0x003230B3 File Offset: 0x003212B3
		public TCheckSpringFestivalGameplayTypeUnion GameplayType { get; set; }

		// Token: 0x06015C03 RID: 89091 RVA: 0x003230BC File Offset: 0x003212BC
		public ICheckSpringFestivalGameplayCompletedT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.GameplayType = null;
		}
	}
}
