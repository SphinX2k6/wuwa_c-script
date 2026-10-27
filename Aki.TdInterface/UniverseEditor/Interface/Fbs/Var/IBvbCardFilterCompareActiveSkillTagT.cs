using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A3A RID: 14906
	public class IBvbCardFilterCompareActiveSkillTagT
	{
		// Token: 0x17006625 RID: 26149
		// (get) Token: 0x060142C4 RID: 82628 RVA: 0x002F301C File Offset: 0x002F121C
		// (set) Token: 0x060142C5 RID: 82629 RVA: 0x002F3024 File Offset: 0x002F1224
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006626 RID: 26150
		// (get) Token: 0x060142C6 RID: 82630 RVA: 0x002F302D File Offset: 0x002F122D
		// (set) Token: 0x060142C7 RID: 82631 RVA: 0x002F3035 File Offset: 0x002F1235
		public int ActiveSkillTag { get; set; }

		// Token: 0x060142C8 RID: 82632 RVA: 0x002F303E File Offset: 0x002F123E
		public IBvbCardFilterCompareActiveSkillTagT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.ActiveSkillTag = 0;
		}
	}
}
