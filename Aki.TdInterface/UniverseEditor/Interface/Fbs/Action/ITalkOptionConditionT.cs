using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007323 RID: 29475
	public class ITalkOptionConditionT
	{
		// Token: 0x1700DFEF RID: 57327
		// (get) Token: 0x060357F2 RID: 219122 RVA: 0x00749F37 File Offset: 0x00748137
		// (set) Token: 0x060357F3 RID: 219123 RVA: 0x00749F3F File Offset: 0x0074813F
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x1700DFF0 RID: 57328
		// (get) Token: 0x060357F4 RID: 219124 RVA: 0x00749F48 File Offset: 0x00748148
		// (set) Token: 0x060357F5 RID: 219125 RVA: 0x00749F50 File Offset: 0x00748150
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x060357F6 RID: 219126 RVA: 0x00749F59 File Offset: 0x00748159
		public ITalkOptionConditionT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
			this.Conditions = null;
		}
	}
}
