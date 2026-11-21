using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004278 RID: 17016
	public class IFinishKuroSimpleCombatKillMonsterT
	{
		// Token: 0x17007422 RID: 29730
		// (get) Token: 0x06017BC0 RID: 97216 RVA: 0x00362A57 File Offset: 0x00360C57
		// (set) Token: 0x06017BC1 RID: 97217 RVA: 0x00362A5F File Offset: 0x00360C5F
		public EChildQuest Type { get; set; }

		// Token: 0x17007423 RID: 29731
		// (get) Token: 0x06017BC2 RID: 97218 RVA: 0x00362A68 File Offset: 0x00360C68
		// (set) Token: 0x06017BC3 RID: 97219 RVA: 0x00362A70 File Offset: 0x00360C70
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007424 RID: 29732
		// (get) Token: 0x06017BC4 RID: 97220 RVA: 0x00362A79 File Offset: 0x00360C79
		// (set) Token: 0x06017BC5 RID: 97221 RVA: 0x00362A81 File Offset: 0x00360C81
		public int KuroSimpleCombatSpawnMonsterConfigId { get; set; }

		// Token: 0x17007425 RID: 29733
		// (get) Token: 0x06017BC6 RID: 97222 RVA: 0x00362A8A File Offset: 0x00360C8A
		// (set) Token: 0x06017BC7 RID: 97223 RVA: 0x00362A92 File Offset: 0x00360C92
		public byte NullMask { get; set; }

		// Token: 0x06017BC8 RID: 97224 RVA: 0x00362A9B File Offset: 0x00360C9B
		public IFinishKuroSimpleCombatKillMonsterT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.KuroSimpleCombatSpawnMonsterConfigId = 0;
			this.NullMask = 0;
		}
	}
}
