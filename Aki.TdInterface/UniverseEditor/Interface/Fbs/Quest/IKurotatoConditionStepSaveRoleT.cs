using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004323 RID: 17187
	public class IKurotatoConditionStepSaveRoleT
	{
		// Token: 0x170075A9 RID: 30121
		// (get) Token: 0x060182C8 RID: 99016 RVA: 0x0037273A File Offset: 0x0037093A
		// (set) Token: 0x060182C9 RID: 99017 RVA: 0x00372742 File Offset: 0x00370942
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x060182CA RID: 99018 RVA: 0x0037274B File Offset: 0x0037094B
		public IKurotatoConditionStepSaveRoleT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
