using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E7C RID: 15996
	public class IGetSkillQuestConditionT
	{
		// Token: 0x17006EF1 RID: 28401
		// (get) Token: 0x060168AB RID: 92331 RVA: 0x00341E6B File Offset: 0x0034006B
		// (set) Token: 0x060168AC RID: 92332 RVA: 0x00341E73 File Offset: 0x00340073
		public EChildQuest Type { get; set; }

		// Token: 0x17006EF2 RID: 28402
		// (get) Token: 0x060168AD RID: 92333 RVA: 0x00341E7C File Offset: 0x0034007C
		// (set) Token: 0x060168AE RID: 92334 RVA: 0x00341E84 File Offset: 0x00340084
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006EF3 RID: 28403
		// (get) Token: 0x060168AF RID: 92335 RVA: 0x00341E8D File Offset: 0x0034008D
		// (set) Token: 0x060168B0 RID: 92336 RVA: 0x00341E95 File Offset: 0x00340095
		public ESkillType SkillType { get; set; }

		// Token: 0x17006EF4 RID: 28404
		// (get) Token: 0x060168B1 RID: 92337 RVA: 0x00341E9E File Offset: 0x0034009E
		// (set) Token: 0x060168B2 RID: 92338 RVA: 0x00341EA6 File Offset: 0x003400A6
		public int SkillId { get; set; }

		// Token: 0x060168B3 RID: 92339 RVA: 0x00341EAF File Offset: 0x003400AF
		public IGetSkillQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SkillType = ESkillType.NormalSkill;
			this.SkillId = 0;
		}
	}
}
