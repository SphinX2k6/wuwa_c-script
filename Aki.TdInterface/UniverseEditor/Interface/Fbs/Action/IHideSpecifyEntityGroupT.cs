using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB7 RID: 28599
	public class IHideSpecifyEntityGroupT
	{
		// Token: 0x1700D173 RID: 53619
		// (get) Token: 0x06031857 RID: 202839 RVA: 0x006B62B7 File Offset: 0x006B44B7
		// (set) Token: 0x06031858 RID: 202840 RVA: 0x006B62BF File Offset: 0x006B44BF
		public EHideType Type { get; set; }

		// Token: 0x1700D174 RID: 53620
		// (get) Token: 0x06031859 RID: 202841 RVA: 0x006B62C8 File Offset: 0x006B44C8
		// (set) Token: 0x0603185A RID: 202842 RVA: 0x006B62D0 File Offset: 0x006B44D0
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D175 RID: 53621
		// (get) Token: 0x0603185B RID: 202843 RVA: 0x006B62D9 File Offset: 0x006B44D9
		// (set) Token: 0x0603185C RID: 202844 RVA: 0x006B62E1 File Offset: 0x006B44E1
		public bool ForceClean { get; set; }

		// Token: 0x1700D176 RID: 53622
		// (get) Token: 0x0603185D RID: 202845 RVA: 0x006B62EA File Offset: 0x006B44EA
		// (set) Token: 0x0603185E RID: 202846 RVA: 0x006B62F2 File Offset: 0x006B44F2
		public byte NullMask { get; set; }

		// Token: 0x0603185F RID: 202847 RVA: 0x006B62FB File Offset: 0x006B44FB
		public IHideSpecifyEntityGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.EntityIds = null;
			this.ForceClean = false;
			this.NullMask = 0;
		}
	}
}
