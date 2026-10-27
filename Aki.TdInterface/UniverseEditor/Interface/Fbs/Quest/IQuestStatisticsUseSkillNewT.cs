using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200405F RID: 16479
	public class IQuestStatisticsUseSkillNewT
	{
		// Token: 0x1700740D RID: 29709
		// (get) Token: 0x06017E77 RID: 97911 RVA: 0x00373399 File Offset: 0x00371599
		// (set) Token: 0x06017E78 RID: 97912 RVA: 0x003733A1 File Offset: 0x003715A1
		public EStatisticsEventType Type { get; set; }

		// Token: 0x1700740E RID: 29710
		// (get) Token: 0x06017E79 RID: 97913 RVA: 0x003733AA File Offset: 0x003715AA
		// (set) Token: 0x06017E7A RID: 97914 RVA: 0x003733B2 File Offset: 0x003715B2
		public TVarRefUnion Var { get; set; }

		// Token: 0x1700740F RID: 29711
		// (get) Token: 0x06017E7B RID: 97915 RVA: 0x003733BB File Offset: 0x003715BB
		// (set) Token: 0x06017E7C RID: 97916 RVA: 0x003733C3 File Offset: 0x003715C3
		public TUseSkillCheckUnion SkillCheck { get; set; }

		// Token: 0x17007410 RID: 29712
		// (get) Token: 0x06017E7D RID: 97917 RVA: 0x003733CC File Offset: 0x003715CC
		// (set) Token: 0x06017E7E RID: 97918 RVA: 0x003733D4 File Offset: 0x003715D4
		public bool IsWaitFinish { get; set; }

		// Token: 0x17007411 RID: 29713
		// (get) Token: 0x06017E7F RID: 97919 RVA: 0x003733DD File Offset: 0x003715DD
		// (set) Token: 0x06017E80 RID: 97920 RVA: 0x003733E5 File Offset: 0x003715E5
		public byte NullMask { get; set; }

		// Token: 0x06017E81 RID: 97921 RVA: 0x003733EE File Offset: 0x003715EE
		public IQuestStatisticsUseSkillNewT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.SkillCheck = null;
			this.IsWaitFinish = false;
			this.NullMask = 0;
		}
	}
}
