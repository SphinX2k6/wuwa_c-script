using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E3D RID: 15933
	public class IFinishKuroSimpleCombatKillMonsterT
	{
		// Token: 0x17006E3E RID: 28222
		// (get) Token: 0x06016599 RID: 91545 RVA: 0x00339F27 File Offset: 0x00338127
		// (set) Token: 0x0601659A RID: 91546 RVA: 0x00339F2F File Offset: 0x0033812F
		public EChildQuest Type { get; set; }

		// Token: 0x17006E3F RID: 28223
		// (get) Token: 0x0601659B RID: 91547 RVA: 0x00339F38 File Offset: 0x00338138
		// (set) Token: 0x0601659C RID: 91548 RVA: 0x00339F40 File Offset: 0x00338140
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E40 RID: 28224
		// (get) Token: 0x0601659D RID: 91549 RVA: 0x00339F49 File Offset: 0x00338149
		// (set) Token: 0x0601659E RID: 91550 RVA: 0x00339F51 File Offset: 0x00338151
		public int KuroSimpleCombatSpawnMonsterConfigId { get; set; }

		// Token: 0x17006E41 RID: 28225
		// (get) Token: 0x0601659F RID: 91551 RVA: 0x00339F5A File Offset: 0x0033815A
		// (set) Token: 0x060165A0 RID: 91552 RVA: 0x00339F62 File Offset: 0x00338162
		public byte NullMask { get; set; }

		// Token: 0x060165A1 RID: 91553 RVA: 0x00339F6B File Offset: 0x0033816B
		public IFinishKuroSimpleCombatKillMonsterT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.KuroSimpleCombatSpawnMonsterConfigId = 0;
			this.NullMask = 0;
		}
	}
}
