using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006362 RID: 25442
	public class ICheckFlowLookAtEntityT
	{
		// Token: 0x1700BDD4 RID: 48596
		// (get) Token: 0x0602C047 RID: 180295 RVA: 0x0060C77C File Offset: 0x0060A97C
		// (set) Token: 0x0602C048 RID: 180296 RVA: 0x0060C784 File Offset: 0x0060A984
		public ECheckFlowLookAtTargetType Type { get; set; }

		// Token: 0x1700BDD5 RID: 48597
		// (get) Token: 0x0602C049 RID: 180297 RVA: 0x0060C78D File Offset: 0x0060A98D
		// (set) Token: 0x0602C04A RID: 180298 RVA: 0x0060C795 File Offset: 0x0060A995
		public int EntityId { get; set; }

		// Token: 0x0602C04B RID: 180299 RVA: 0x0060C79E File Offset: 0x0060A99E
		public ICheckFlowLookAtEntityT()
		{
			this.Type = ECheckFlowLookAtTargetType.Entity;
			this.EntityId = 0;
		}
	}
}
