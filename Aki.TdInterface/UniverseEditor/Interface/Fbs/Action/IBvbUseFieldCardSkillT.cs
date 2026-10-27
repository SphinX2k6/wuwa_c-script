using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006267 RID: 25191
	public class IBvbUseFieldCardSkillT
	{
		// Token: 0x1700BBB8 RID: 48056
		// (get) Token: 0x0602B774 RID: 178036 RVA: 0x005FBF1E File Offset: 0x005FA11E
		// (set) Token: 0x0602B775 RID: 178037 RVA: 0x005FBF26 File Offset: 0x005FA126
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602B776 RID: 178038 RVA: 0x005FBF2F File Offset: 0x005FA12F
		public IBvbUseFieldCardSkillT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
		}
	}
}
