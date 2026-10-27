using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D19 RID: 19737
	public class IVisionSkillReadyT
	{
		// Token: 0x17008F1F RID: 36639
		// (get) Token: 0x0601F544 RID: 128324 RVA: 0x0045E5F2 File Offset: 0x0045C7F2
		// (set) Token: 0x0601F545 RID: 128325 RVA: 0x0045E5FA File Offset: 0x0045C7FA
		public ESkillReadyType Type { get; set; }

		// Token: 0x0601F546 RID: 128326 RVA: 0x0045E603 File Offset: 0x0045C803
		public IVisionSkillReadyT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
