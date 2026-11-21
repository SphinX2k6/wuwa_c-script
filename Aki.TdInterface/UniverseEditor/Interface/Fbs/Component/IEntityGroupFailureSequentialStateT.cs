using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EC RID: 22252
	public class IEntityGroupFailureSequentialStateT
	{
		// Token: 0x1700A069 RID: 41065
		// (get) Token: 0x06023B55 RID: 146261 RVA: 0x004E8D15 File Offset: 0x004E6F15
		// (set) Token: 0x06023B56 RID: 146262 RVA: 0x004E8D1D File Offset: 0x004E6F1D
		public EEntityGroupFailureCondition Type { get; set; }

		// Token: 0x1700A06A RID: 41066
		// (get) Token: 0x06023B57 RID: 146263 RVA: 0x004E8D26 File Offset: 0x004E6F26
		// (set) Token: 0x06023B58 RID: 146264 RVA: 0x004E8D2E File Offset: 0x004E6F2E
		public List<IEntityStateConditionT> Order { get; set; }

		// Token: 0x1700A06B RID: 41067
		// (get) Token: 0x06023B59 RID: 146265 RVA: 0x004E8D37 File Offset: 0x004E6F37
		// (set) Token: 0x06023B5A RID: 146266 RVA: 0x004E8D3F File Offset: 0x004E6F3F
		public byte NullMask { get; set; }

		// Token: 0x06023B5B RID: 146267 RVA: 0x004E8D48 File Offset: 0x004E6F48
		public IEntityGroupFailureSequentialStateT()
		{
			this.Type = EEntityGroupFailureCondition.SequentialState;
			this.Order = null;
			this.NullMask = 0;
		}
	}
}
