using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005363 RID: 21347
	public class IHeadInfoChangeDataT
	{
		// Token: 0x17009CDD RID: 40157
		// (get) Token: 0x06022EDE RID: 143070 RVA: 0x004D6671 File Offset: 0x004D4871
		// (set) Token: 0x06022EDF RID: 143071 RVA: 0x004D6679 File Offset: 0x004D4879
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17009CDE RID: 40158
		// (get) Token: 0x06022EE0 RID: 143072 RVA: 0x004D6682 File Offset: 0x004D4882
		// (set) Token: 0x06022EE1 RID: 143073 RVA: 0x004D668A File Offset: 0x004D488A
		public string TidName { get; set; }

		// Token: 0x17009CDF RID: 40159
		// (get) Token: 0x06022EE2 RID: 143074 RVA: 0x004D6693 File Offset: 0x004D4893
		// (set) Token: 0x06022EE3 RID: 143075 RVA: 0x004D669B File Offset: 0x004D489B
		public string Icon { get; set; }

		// Token: 0x17009CE0 RID: 40160
		// (get) Token: 0x06022EE4 RID: 143076 RVA: 0x004D66A4 File Offset: 0x004D48A4
		// (set) Token: 0x06022EE5 RID: 143077 RVA: 0x004D66AC File Offset: 0x004D48AC
		public string TidSecondaryName { get; set; }

		// Token: 0x06022EE6 RID: 143078 RVA: 0x004D66B5 File Offset: 0x004D48B5
		public IHeadInfoChangeDataT()
		{
			this.Conditions = null;
			this.TidName = null;
			this.Icon = null;
			this.TidSecondaryName = null;
		}
	}
}
