using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC1 RID: 28609
	public class ISetBattleTagsT
	{
		// Token: 0x1700D46E RID: 54382
		// (get) Token: 0x0603291E RID: 207134 RVA: 0x006D2FFB File Offset: 0x006D11FB
		// (set) Token: 0x0603291F RID: 207135 RVA: 0x006D3003 File Offset: 0x006D1203
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700D46F RID: 54383
		// (get) Token: 0x06032920 RID: 207136 RVA: 0x006D300C File Offset: 0x006D120C
		// (set) Token: 0x06032921 RID: 207137 RVA: 0x006D3014 File Offset: 0x006D1214
		public List<ISetBattleTagConfigT> Configs { get; set; }

		// Token: 0x06032922 RID: 207138 RVA: 0x006D301D File Offset: 0x006D121D
		public ISetBattleTagsT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.Configs = null;
		}
	}
}
