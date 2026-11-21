using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B6 RID: 18102
	public class IUseSkillQuestConditionT
	{
		// Token: 0x17007ECA RID: 32458
		// (get) Token: 0x0601A98C RID: 108940 RVA: 0x003C8555 File Offset: 0x003C6755
		// (set) Token: 0x0601A98D RID: 108941 RVA: 0x003C855D File Offset: 0x003C675D
		public EChildQuest Type { get; set; }

		// Token: 0x17007ECB RID: 32459
		// (get) Token: 0x0601A98E RID: 108942 RVA: 0x003C8566 File Offset: 0x003C6766
		// (set) Token: 0x0601A98F RID: 108943 RVA: 0x003C856E File Offset: 0x003C676E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007ECC RID: 32460
		// (get) Token: 0x0601A990 RID: 108944 RVA: 0x003C8577 File Offset: 0x003C6777
		// (set) Token: 0x0601A991 RID: 108945 RVA: 0x003C857F File Offset: 0x003C677F
		public ESkillType SkillType { get; set; }

		// Token: 0x17007ECD RID: 32461
		// (get) Token: 0x0601A992 RID: 108946 RVA: 0x003C8588 File Offset: 0x003C6788
		// (set) Token: 0x0601A993 RID: 108947 RVA: 0x003C8590 File Offset: 0x003C6790
		public int SkillId { get; set; }

		// Token: 0x17007ECE RID: 32462
		// (get) Token: 0x0601A994 RID: 108948 RVA: 0x003C8599 File Offset: 0x003C6799
		// (set) Token: 0x0601A995 RID: 108949 RVA: 0x003C85A1 File Offset: 0x003C67A1
		public TUseSkillCheckUnion Check { get; set; }

		// Token: 0x17007ECF RID: 32463
		// (get) Token: 0x0601A996 RID: 108950 RVA: 0x003C85AA File Offset: 0x003C67AA
		// (set) Token: 0x0601A997 RID: 108951 RVA: 0x003C85B2 File Offset: 0x003C67B2
		public bool IsWaitFinish { get; set; }

		// Token: 0x17007ED0 RID: 32464
		// (get) Token: 0x0601A998 RID: 108952 RVA: 0x003C85BB File Offset: 0x003C67BB
		// (set) Token: 0x0601A999 RID: 108953 RVA: 0x003C85C3 File Offset: 0x003C67C3
		public byte NullMask { get; set; }

		// Token: 0x0601A99A RID: 108954 RVA: 0x003C85CC File Offset: 0x003C67CC
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
