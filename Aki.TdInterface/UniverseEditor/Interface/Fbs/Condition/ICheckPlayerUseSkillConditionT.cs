using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B06 RID: 19206
	public class ICheckPlayerUseSkillConditionT
	{
		// Token: 0x17008B51 RID: 35665
		// (get) Token: 0x0601E340 RID: 123712 RVA: 0x0043C4B9 File Offset: 0x0043A6B9
		// (set) Token: 0x0601E341 RID: 123713 RVA: 0x0043C4C1 File Offset: 0x0043A6C1
		public ECondition Type { get; set; }

		// Token: 0x17008B52 RID: 35666
		// (get) Token: 0x0601E342 RID: 123714 RVA: 0x0043C4CA File Offset: 0x0043A6CA
		// (set) Token: 0x0601E343 RID: 123715 RVA: 0x0043C4D2 File Offset: 0x0043A6D2
		public ECommonMatchType CheckType { get; set; }

		// Token: 0x17008B53 RID: 35667
		// (get) Token: 0x0601E344 RID: 123716 RVA: 0x0043C4DB File Offset: 0x0043A6DB
		// (set) Token: 0x0601E345 RID: 123717 RVA: 0x0043C4E3 File Offset: 0x0043A6E3
		public List<ISkillUseTypeRoleSkillT> CheckSkills { get; set; }

		// Token: 0x0601E346 RID: 123718 RVA: 0x0043C4EC File Offset: 0x0043A6EC
		public ICheckPlayerUseSkillConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = ECommonMatchType.MatchAll;
			this.CheckSkills = null;
		}
	}
}
