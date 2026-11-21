using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006036 RID: 24630
	public class ITargetGearGroupComponentT
	{
		// Token: 0x1700B6CF RID: 46799
		// (get) Token: 0x0602990E RID: 170254 RVA: 0x005AC980 File Offset: 0x005AAB80
		// (set) Token: 0x0602990F RID: 170255 RVA: 0x005AC988 File Offset: 0x005AAB88
		public bool Disabled { get; set; }

		// Token: 0x1700B6D0 RID: 46800
		// (get) Token: 0x06029910 RID: 170256 RVA: 0x005AC991 File Offset: 0x005AAB91
		// (set) Token: 0x06029911 RID: 170257 RVA: 0x005AC999 File Offset: 0x005AAB99
		public string Type { get; set; }

		// Token: 0x1700B6D1 RID: 46801
		// (get) Token: 0x06029912 RID: 170258 RVA: 0x005AC9A2 File Offset: 0x005AABA2
		// (set) Token: 0x06029913 RID: 170259 RVA: 0x005AC9AA File Offset: 0x005AABAA
		public List<ITargetGearGroupConfigT> GroupConfigs { get; set; }

		// Token: 0x1700B6D2 RID: 46802
		// (get) Token: 0x06029914 RID: 170260 RVA: 0x005AC9B3 File Offset: 0x005AABB3
		// (set) Token: 0x06029915 RID: 170261 RVA: 0x005AC9BB File Offset: 0x005AABBB
		public byte NullMask { get; set; }

		// Token: 0x06029916 RID: 170262 RVA: 0x005AC9C4 File Offset: 0x005AABC4
		public ITargetGearGroupComponentT()
		{
			this.Disabled = false;
			this.Type = null;
			this.GroupConfigs = null;
			this.NullMask = 0;
		}
	}
}
