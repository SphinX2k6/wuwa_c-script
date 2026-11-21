using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778A RID: 30602
	public class ISetBattleTagsT
	{
		// Token: 0x1700E042 RID: 57410
		// (get) Token: 0x06035B84 RID: 220036 RVA: 0x00732C3F File Offset: 0x00730E3F
		// (set) Token: 0x06035B85 RID: 220037 RVA: 0x00732C47 File Offset: 0x00730E47
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700E043 RID: 57411
		// (get) Token: 0x06035B86 RID: 220038 RVA: 0x00732C50 File Offset: 0x00730E50
		// (set) Token: 0x06035B87 RID: 220039 RVA: 0x00732C58 File Offset: 0x00730E58
		public List<ISetBattleTagConfigT> Configs { get; set; }

		// Token: 0x06035B88 RID: 220040 RVA: 0x00732C61 File Offset: 0x00730E61
		public ISetBattleTagsT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.Configs = null;
		}
	}
}
