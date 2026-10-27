using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FFB RID: 20475
	public class IConditionSpawnMonsterT
	{
		// Token: 0x1700945A RID: 37978
		// (get) Token: 0x06020BC3 RID: 134083 RVA: 0x0048D4E7 File Offset: 0x0048B6E7
		// (set) Token: 0x06020BC4 RID: 134084 RVA: 0x0048D4EF File Offset: 0x0048B6EF
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700945B RID: 37979
		// (get) Token: 0x06020BC5 RID: 134085 RVA: 0x0048D4F8 File Offset: 0x0048B6F8
		// (set) Token: 0x06020BC6 RID: 134086 RVA: 0x0048D500 File Offset: 0x0048B700
		public IConditionGroupT EndCondition { get; set; }

		// Token: 0x1700945C RID: 37980
		// (get) Token: 0x06020BC7 RID: 134087 RVA: 0x0048D509 File Offset: 0x0048B709
		// (set) Token: 0x06020BC8 RID: 134088 RVA: 0x0048D511 File Offset: 0x0048B711
		public bool Loop { get; set; }

		// Token: 0x1700945D RID: 37981
		// (get) Token: 0x06020BC9 RID: 134089 RVA: 0x0048D51A File Offset: 0x0048B71A
		// (set) Token: 0x06020BCA RID: 134090 RVA: 0x0048D522 File Offset: 0x0048B722
		public List<IDynamicSpawnMonsterConfigT> BatchConfigs { get; set; }

		// Token: 0x1700945E RID: 37982
		// (get) Token: 0x06020BCB RID: 134091 RVA: 0x0048D52B File Offset: 0x0048B72B
		// (set) Token: 0x06020BCC RID: 134092 RVA: 0x0048D533 File Offset: 0x0048B733
		public byte NullMask { get; set; }

		// Token: 0x06020BCD RID: 134093 RVA: 0x0048D53C File Offset: 0x0048B73C
		public IConditionSpawnMonsterT()
		{
			this.Condition = null;
			this.EndCondition = null;
			this.Loop = false;
			this.BatchConfigs = null;
			this.NullMask = 0;
		}
	}
}
