using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044AC RID: 17580
	public class IReachAreaQuestConditionT
	{
		// Token: 0x17007A53 RID: 31315
		// (get) Token: 0x06019602 RID: 103938 RVA: 0x0039F561 File Offset: 0x0039D761
		// (set) Token: 0x06019603 RID: 103939 RVA: 0x0039F569 File Offset: 0x0039D769
		public EChildQuest Type { get; set; }

		// Token: 0x17007A54 RID: 31316
		// (get) Token: 0x06019604 RID: 103940 RVA: 0x0039F572 File Offset: 0x0039D772
		// (set) Token: 0x06019605 RID: 103941 RVA: 0x0039F57A File Offset: 0x0039D77A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007A55 RID: 31317
		// (get) Token: 0x06019606 RID: 103942 RVA: 0x0039F583 File Offset: 0x0039D783
		// (set) Token: 0x06019607 RID: 103943 RVA: 0x0039F58B File Offset: 0x0039D78B
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17007A56 RID: 31318
		// (get) Token: 0x06019608 RID: 103944 RVA: 0x0039F594 File Offset: 0x0039D794
		// (set) Token: 0x06019609 RID: 103945 RVA: 0x0039F59C File Offset: 0x0039D79C
		public int Range { get; set; }

		// Token: 0x17007A57 RID: 31319
		// (get) Token: 0x0601960A RID: 103946 RVA: 0x0039F5A5 File Offset: 0x0039D7A5
		// (set) Token: 0x0601960B RID: 103947 RVA: 0x0039F5AD File Offset: 0x0039D7AD
		public int EntityId { get; set; }

		// Token: 0x17007A58 RID: 31320
		// (get) Token: 0x0601960C RID: 103948 RVA: 0x0039F5B6 File Offset: 0x0039D7B6
		// (set) Token: 0x0601960D RID: 103949 RVA: 0x0039F5BE File Offset: 0x0039D7BE
		public int RangeEntityId { get; set; }

		// Token: 0x17007A59 RID: 31321
		// (get) Token: 0x0601960E RID: 103950 RVA: 0x0039F5C7 File Offset: 0x0039D7C7
		// (set) Token: 0x0601960F RID: 103951 RVA: 0x0039F5CF File Offset: 0x0039D7CF
		public List<int> RangeEntities { get; set; }

		// Token: 0x17007A5A RID: 31322
		// (get) Token: 0x06019610 RID: 103952 RVA: 0x0039F5D8 File Offset: 0x0039D7D8
		// (set) Token: 0x06019611 RID: 103953 RVA: 0x0039F5E0 File Offset: 0x0039D7E0
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17007A5B RID: 31323
		// (get) Token: 0x06019612 RID: 103954 RVA: 0x0039F5E9 File Offset: 0x0039D7E9
		// (set) Token: 0x06019613 RID: 103955 RVA: 0x0039F5F1 File Offset: 0x0039D7F1
		public string EffectPath { get; set; }

		// Token: 0x17007A5C RID: 31324
		// (get) Token: 0x06019614 RID: 103956 RVA: 0x0039F5FA File Offset: 0x0039D7FA
		// (set) Token: 0x06019615 RID: 103957 RVA: 0x0039F602 File Offset: 0x0039D802
		public byte NullMask { get; set; }

		// Token: 0x06019616 RID: 103958 RVA: 0x0039F60C File Offset: 0x0039D80C
		public IReachAreaQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Pos = null;
			this.Range = 0;
			this.EntityId = 0;
			this.RangeEntityId = 0;
			this.RangeEntities = null;
			this.MatchRoleOption = null;
			this.EffectPath = null;
			this.NullMask = 0;
		}
	}
}
