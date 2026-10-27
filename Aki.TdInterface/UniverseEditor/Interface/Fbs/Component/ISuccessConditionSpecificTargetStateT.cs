using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059ED RID: 23021
	public class ISuccessConditionSpecificTargetStateT
	{
		// Token: 0x1700ACEF RID: 44271
		// (get) Token: 0x060270F0 RID: 159984 RVA: 0x0055F923 File Offset: 0x0055DB23
		// (set) Token: 0x060270F1 RID: 159985 RVA: 0x0055F92B File Offset: 0x0055DB2B
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x1700ACF0 RID: 44272
		// (get) Token: 0x060270F2 RID: 159986 RVA: 0x0055F934 File Offset: 0x0055DB34
		// (set) Token: 0x060270F3 RID: 159987 RVA: 0x0055F93C File Offset: 0x0055DB3C
		public List<IEntityStateConditionT> Conditions { get; set; }

		// Token: 0x060270F4 RID: 159988 RVA: 0x0055F945 File Offset: 0x0055DB45
		public ISuccessConditionSpecificTargetStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
			this.Conditions = null;
		}
	}
}
