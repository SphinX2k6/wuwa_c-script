using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425A RID: 16986
	public class IUseSkillQuestConditionT
	{
		// Token: 0x17007899 RID: 30873
		// (get) Token: 0x06019220 RID: 102944 RVA: 0x0039CE7D File Offset: 0x0039B07D
		// (set) Token: 0x06019221 RID: 102945 RVA: 0x0039CE85 File Offset: 0x0039B085
		public EChildQuest Type { get; set; }

		// Token: 0x1700789A RID: 30874
		// (get) Token: 0x06019222 RID: 102946 RVA: 0x0039CE8E File Offset: 0x0039B08E
		// (set) Token: 0x06019223 RID: 102947 RVA: 0x0039CE96 File Offset: 0x0039B096
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700789B RID: 30875
		// (get) Token: 0x06019224 RID: 102948 RVA: 0x0039CE9F File Offset: 0x0039B09F
		// (set) Token: 0x06019225 RID: 102949 RVA: 0x0039CEA7 File Offset: 0x0039B0A7
		public ESkillType SkillType { get; set; }

		// Token: 0x1700789C RID: 30876
		// (get) Token: 0x06019226 RID: 102950 RVA: 0x0039CEB0 File Offset: 0x0039B0B0
		// (set) Token: 0x06019227 RID: 102951 RVA: 0x0039CEB8 File Offset: 0x0039B0B8
		public int SkillId { get; set; }

		// Token: 0x1700789D RID: 30877
		// (get) Token: 0x06019228 RID: 102952 RVA: 0x0039CEC1 File Offset: 0x0039B0C1
		// (set) Token: 0x06019229 RID: 102953 RVA: 0x0039CEC9 File Offset: 0x0039B0C9
		public TUseSkillCheckUnion Check { get; set; }

		// Token: 0x1700789E RID: 30878
		// (get) Token: 0x0601922A RID: 102954 RVA: 0x0039CED2 File Offset: 0x0039B0D2
		// (set) Token: 0x0601922B RID: 102955 RVA: 0x0039CEDA File Offset: 0x0039B0DA
		public bool IsWaitFinish { get; set; }

		// Token: 0x1700789F RID: 30879
		// (get) Token: 0x0601922C RID: 102956 RVA: 0x0039CEE3 File Offset: 0x0039B0E3
		// (set) Token: 0x0601922D RID: 102957 RVA: 0x0039CEEB File Offset: 0x0039B0EB
		public byte NullMask { get; set; }

		// Token: 0x0601922E RID: 102958 RVA: 0x0039CEF4 File Offset: 0x0039B0F4
		public IUseSkillQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SkillType = ESkillType.NormalSkill;
			this.SkillId = 0;
			this.Check = null;
			this.IsWaitFinish = false;
			this.NullMask = 0;
		}
	}
}
