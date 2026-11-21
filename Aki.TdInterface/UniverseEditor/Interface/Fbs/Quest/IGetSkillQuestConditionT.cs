using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B7 RID: 17079
	public class IGetSkillQuestConditionT
	{
		// Token: 0x170074D9 RID: 29913
		// (get) Token: 0x06017EE2 RID: 98018 RVA: 0x0036ABEF File Offset: 0x00368DEF
		// (set) Token: 0x06017EE3 RID: 98019 RVA: 0x0036ABF7 File Offset: 0x00368DF7
		public EChildQuest Type { get; set; }

		// Token: 0x170074DA RID: 29914
		// (get) Token: 0x06017EE4 RID: 98020 RVA: 0x0036AC00 File Offset: 0x00368E00
		// (set) Token: 0x06017EE5 RID: 98021 RVA: 0x0036AC08 File Offset: 0x00368E08
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170074DB RID: 29915
		// (get) Token: 0x06017EE6 RID: 98022 RVA: 0x0036AC11 File Offset: 0x00368E11
		// (set) Token: 0x06017EE7 RID: 98023 RVA: 0x0036AC19 File Offset: 0x00368E19
		public ESkillType SkillType { get; set; }

		// Token: 0x170074DC RID: 29916
		// (get) Token: 0x06017EE8 RID: 98024 RVA: 0x0036AC22 File Offset: 0x00368E22
		// (set) Token: 0x06017EE9 RID: 98025 RVA: 0x0036AC2A File Offset: 0x00368E2A
		public int SkillId { get; set; }

		// Token: 0x06017EEA RID: 98026 RVA: 0x0036AC33 File Offset: 0x00368E33
		public IGetSkillQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SkillType = ESkillType.NormalSkill;
			this.SkillId = 0;
		}
	}
}
