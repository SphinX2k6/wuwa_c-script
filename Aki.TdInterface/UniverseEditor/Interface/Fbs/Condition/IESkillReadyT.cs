using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C1D RID: 19485
	public class IESkillReadyT
	{
		// Token: 0x17008D8D RID: 36237
		// (get) Token: 0x0601EDEB RID: 126443 RVA: 0x00452382 File Offset: 0x00450582
		// (set) Token: 0x0601EDEC RID: 126444 RVA: 0x0045238A File Offset: 0x0045058A
		public ESkillReadyType Type { get; set; }

		// Token: 0x0601EDED RID: 126445 RVA: 0x00452393 File Offset: 0x00450593
		public IESkillReadyT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
