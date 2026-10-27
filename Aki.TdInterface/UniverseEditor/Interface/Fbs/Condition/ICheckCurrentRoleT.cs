using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B3 RID: 18867
	public class ICheckCurrentRoleT
	{
		// Token: 0x1700886F RID: 34927
		// (get) Token: 0x0601D748 RID: 120648 RVA: 0x00426667 File Offset: 0x00424867
		// (set) Token: 0x0601D749 RID: 120649 RVA: 0x0042666F File Offset: 0x0042486F
		public ECondition Type { get; set; }

		// Token: 0x17008870 RID: 34928
		// (get) Token: 0x0601D74A RID: 120650 RVA: 0x00426678 File Offset: 0x00424878
		// (set) Token: 0x0601D74B RID: 120651 RVA: 0x00426680 File Offset: 0x00424880
		public int RoleId { get; set; }

		// Token: 0x17008871 RID: 34929
		// (get) Token: 0x0601D74C RID: 120652 RVA: 0x00426689 File Offset: 0x00424889
		// (set) Token: 0x0601D74D RID: 120653 RVA: 0x00426691 File Offset: 0x00424891
		public ECompare Compare { get; set; }

		// Token: 0x17008872 RID: 34930
		// (get) Token: 0x0601D74E RID: 120654 RVA: 0x0042669A File Offset: 0x0042489A
		// (set) Token: 0x0601D74F RID: 120655 RVA: 0x004266A2 File Offset: 0x004248A2
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601D750 RID: 120656 RVA: 0x004266AB File Offset: 0x004248AB
		public ICheckCurrentRoleT()
		{
			this.Type = ECondition.CompareVar;
			this.RoleId = 0;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
