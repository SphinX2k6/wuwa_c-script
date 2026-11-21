using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F36 RID: 20278
	public class ICheckHookLockPointConditionT
	{
		// Token: 0x170090DF RID: 37087
		// (get) Token: 0x0601F871 RID: 129137 RVA: 0x004630B5 File Offset: 0x004612B5
		// (set) Token: 0x0601F872 RID: 129138 RVA: 0x004630BD File Offset: 0x004612BD
		public ECondition Type { get; set; }

		// Token: 0x170090E0 RID: 37088
		// (get) Token: 0x0601F873 RID: 129139 RVA: 0x004630C6 File Offset: 0x004612C6
		// (set) Token: 0x0601F874 RID: 129140 RVA: 0x004630CE File Offset: 0x004612CE
		public List<int> EntityIds { get; set; }

		// Token: 0x170090E1 RID: 37089
		// (get) Token: 0x0601F875 RID: 129141 RVA: 0x004630D7 File Offset: 0x004612D7
		// (set) Token: 0x0601F876 RID: 129142 RVA: 0x004630DF File Offset: 0x004612DF
		public byte NullMask { get; set; }

		// Token: 0x0601F877 RID: 129143 RVA: 0x004630E8 File Offset: 0x004612E8
		public ICheckHookLockPointConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
