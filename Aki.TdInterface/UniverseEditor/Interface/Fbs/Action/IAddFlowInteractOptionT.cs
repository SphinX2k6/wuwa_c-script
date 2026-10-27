using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006129 RID: 24873
	public class IAddFlowInteractOptionT
	{
		// Token: 0x1700B752 RID: 46930
		// (get) Token: 0x0602A84D RID: 174157 RVA: 0x005DAF21 File Offset: 0x005D9121
		// (set) Token: 0x0602A84E RID: 174158 RVA: 0x005DAF29 File Offset: 0x005D9129
		public IInteractOptionT Option { get; set; }

		// Token: 0x1700B753 RID: 46931
		// (get) Token: 0x0602A84F RID: 174159 RVA: 0x005DAF32 File Offset: 0x005D9132
		// (set) Token: 0x0602A850 RID: 174160 RVA: 0x005DAF3A File Offset: 0x005D913A
		public int EntityId { get; set; }

		// Token: 0x1700B754 RID: 46932
		// (get) Token: 0x0602A851 RID: 174161 RVA: 0x005DAF43 File Offset: 0x005D9143
		// (set) Token: 0x0602A852 RID: 174162 RVA: 0x005DAF4B File Offset: 0x005D914B
		public bool DelayRemoveByQuestEnd { get; set; }

		// Token: 0x1700B755 RID: 46933
		// (get) Token: 0x0602A853 RID: 174163 RVA: 0x005DAF54 File Offset: 0x005D9154
		// (set) Token: 0x0602A854 RID: 174164 RVA: 0x005DAF5C File Offset: 0x005D915C
		public string InteractToken { get; set; }

		// Token: 0x1700B756 RID: 46934
		// (get) Token: 0x0602A855 RID: 174165 RVA: 0x005DAF65 File Offset: 0x005D9165
		// (set) Token: 0x0602A856 RID: 174166 RVA: 0x005DAF6D File Offset: 0x005D916D
		public byte NullMask { get; set; }

		// Token: 0x0602A857 RID: 174167 RVA: 0x005DAF76 File Offset: 0x005D9176
		public IAddFlowInteractOptionT()
		{
			this.Option = null;
			this.EntityId = 0;
			this.DelayRemoveByQuestEnd = false;
			this.InteractToken = null;
			this.NullMask = 0;
		}
	}
}
