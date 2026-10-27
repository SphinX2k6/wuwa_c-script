using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A70 RID: 19056
	public class ICheckHookLockPointConditionT
	{
		// Token: 0x17008A03 RID: 35331
		// (get) Token: 0x0601DDCE RID: 122318 RVA: 0x00431F29 File Offset: 0x00430129
		// (set) Token: 0x0601DDCF RID: 122319 RVA: 0x00431F31 File Offset: 0x00430131
		public ECondition Type { get; set; }

		// Token: 0x17008A04 RID: 35332
		// (get) Token: 0x0601DDD0 RID: 122320 RVA: 0x00431F3A File Offset: 0x0043013A
		// (set) Token: 0x0601DDD1 RID: 122321 RVA: 0x00431F42 File Offset: 0x00430142
		public List<int> EntityIds { get; set; }

		// Token: 0x17008A05 RID: 35333
		// (get) Token: 0x0601DDD2 RID: 122322 RVA: 0x00431F4B File Offset: 0x0043014B
		// (set) Token: 0x0601DDD3 RID: 122323 RVA: 0x00431F53 File Offset: 0x00430153
		public byte NullMask { get; set; }

		// Token: 0x0601DDD4 RID: 122324 RVA: 0x00431F5C File Offset: 0x0043015C
		public ICheckHookLockPointConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
