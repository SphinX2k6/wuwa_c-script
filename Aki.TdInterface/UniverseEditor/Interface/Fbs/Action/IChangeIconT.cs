using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006971 RID: 26993
	public class IChangeIconT
	{
		// Token: 0x1700C6B9 RID: 50873
		// (get) Token: 0x0602E496 RID: 189590 RVA: 0x00651FB7 File Offset: 0x006501B7
		// (set) Token: 0x0602E497 RID: 189591 RVA: 0x00651FBF File Offset: 0x006501BF
		public int Icon { get; set; }

		// Token: 0x1700C6BA RID: 50874
		// (get) Token: 0x0602E498 RID: 189592 RVA: 0x00651FC8 File Offset: 0x006501C8
		// (set) Token: 0x0602E499 RID: 189593 RVA: 0x00651FD0 File Offset: 0x006501D0
		public bool ChangeWhenSelectedInCurrentTalk { get; set; }

		// Token: 0x1700C6BB RID: 50875
		// (get) Token: 0x0602E49A RID: 189594 RVA: 0x00651FD9 File Offset: 0x006501D9
		// (set) Token: 0x0602E49B RID: 189595 RVA: 0x00651FE1 File Offset: 0x006501E1
		public IConditionGroupT ChangeWhenMatchConditions { get; set; }

		// Token: 0x1700C6BC RID: 50876
		// (get) Token: 0x0602E49C RID: 189596 RVA: 0x00651FEA File Offset: 0x006501EA
		// (set) Token: 0x0602E49D RID: 189597 RVA: 0x00651FF2 File Offset: 0x006501F2
		public byte NullMask { get; set; }

		// Token: 0x0602E49E RID: 189598 RVA: 0x00651FFB File Offset: 0x006501FB
		public IChangeIconT()
		{
			this.Icon = 0;
			this.ChangeWhenSelectedInCurrentTalk = false;
			this.ChangeWhenMatchConditions = null;
			this.NullMask = 0;
		}
	}
}
