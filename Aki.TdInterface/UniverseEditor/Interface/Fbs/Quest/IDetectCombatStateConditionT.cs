using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD1 RID: 15825
	public class IDetectCombatStateConditionT
	{
		// Token: 0x17006D47 RID: 27975
		// (get) Token: 0x06016189 RID: 90505 RVA: 0x00331C23 File Offset: 0x0032FE23
		// (set) Token: 0x0601618A RID: 90506 RVA: 0x00331C2B File Offset: 0x0032FE2B
		public EChildQuest Type { get; set; }

		// Token: 0x17006D48 RID: 27976
		// (get) Token: 0x0601618B RID: 90507 RVA: 0x00331C34 File Offset: 0x0032FE34
		// (set) Token: 0x0601618C RID: 90508 RVA: 0x00331C3C File Offset: 0x0032FE3C
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006D49 RID: 27977
		// (get) Token: 0x0601618D RID: 90509 RVA: 0x00331C45 File Offset: 0x0032FE45
		// (set) Token: 0x0601618E RID: 90510 RVA: 0x00331C4D File Offset: 0x0032FE4D
		public int EntityId { get; set; }

		// Token: 0x17006D4A RID: 27978
		// (get) Token: 0x0601618F RID: 90511 RVA: 0x00331C56 File Offset: 0x0032FE56
		// (set) Token: 0x06016190 RID: 90512 RVA: 0x00331C5E File Offset: 0x0032FE5E
		public string State { get; set; }

		// Token: 0x17006D4B RID: 27979
		// (get) Token: 0x06016191 RID: 90513 RVA: 0x00331C67 File Offset: 0x0032FE67
		// (set) Token: 0x06016192 RID: 90514 RVA: 0x00331C6F File Offset: 0x0032FE6F
		public ECompare Compare { get; set; }

		// Token: 0x17006D4C RID: 27980
		// (get) Token: 0x06016193 RID: 90515 RVA: 0x00331C78 File Offset: 0x0032FE78
		// (set) Token: 0x06016194 RID: 90516 RVA: 0x00331C80 File Offset: 0x0032FE80
		public byte NullMask { get; set; }

		// Token: 0x06016195 RID: 90517 RVA: 0x00331C89 File Offset: 0x0032FE89
		public IDetectCombatStateConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityId = 0;
			this.State = null;
			this.Compare = ECompare.Eq;
			this.NullMask = 0;
		}
	}
}
