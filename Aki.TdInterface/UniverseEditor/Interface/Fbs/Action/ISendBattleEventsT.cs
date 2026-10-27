using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F61 RID: 28513
	public class ISendBattleEventsT
	{
		// Token: 0x1700D3D8 RID: 54232
		// (get) Token: 0x060325FF RID: 206335 RVA: 0x006CD08F File Offset: 0x006CB28F
		// (set) Token: 0x06032600 RID: 206336 RVA: 0x006CD097 File Offset: 0x006CB297
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700D3D9 RID: 54233
		// (get) Token: 0x06032601 RID: 206337 RVA: 0x006CD0A0 File Offset: 0x006CB2A0
		// (set) Token: 0x06032602 RID: 206338 RVA: 0x006CD0A8 File Offset: 0x006CB2A8
		public List<ISetBattleTagConfigT> Configs { get; set; }

		// Token: 0x06032603 RID: 206339 RVA: 0x006CD0B1 File Offset: 0x006CB2B1
		public ISendBattleEventsT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.Configs = null;
		}
	}
}
