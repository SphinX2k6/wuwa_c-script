using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D8 RID: 26840
	public class IBvbUseFieldCardSkillT
	{
		// Token: 0x1700C540 RID: 50496
		// (get) Token: 0x0602DED5 RID: 188117 RVA: 0x00646D26 File Offset: 0x00644F26
		// (set) Token: 0x0602DED6 RID: 188118 RVA: 0x00646D2E File Offset: 0x00644F2E
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602DED7 RID: 188119 RVA: 0x00646D37 File Offset: 0x00644F37
		public IBvbUseFieldCardSkillT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
		}
	}
}
