using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB6 RID: 15798
	public class IConditionSelectorBtNodeSlotT
	{
		// Token: 0x17006D09 RID: 27913
		// (get) Token: 0x06016086 RID: 90246 RVA: 0x0032F8CE File Offset: 0x0032DACE
		// (set) Token: 0x06016087 RID: 90247 RVA: 0x0032F8D6 File Offset: 0x0032DAD6
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17006D0A RID: 27914
		// (get) Token: 0x06016088 RID: 90248 RVA: 0x0032F8DF File Offset: 0x0032DADF
		// (set) Token: 0x06016089 RID: 90249 RVA: 0x0032F8E7 File Offset: 0x0032DAE7
		public TBtNodeUnion Node { get; set; }

		// Token: 0x17006D0B RID: 27915
		// (get) Token: 0x0601608A RID: 90250 RVA: 0x0032F8F0 File Offset: 0x0032DAF0
		// (set) Token: 0x0601608B RID: 90251 RVA: 0x0032F8F8 File Offset: 0x0032DAF8
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x0601608C RID: 90252 RVA: 0x0032F901 File Offset: 0x0032DB01
		public IConditionSelectorBtNodeSlotT()
		{
			this.Condition = null;
			this.Node = null;
			this.PerformanceSetting = null;
		}
	}
}
