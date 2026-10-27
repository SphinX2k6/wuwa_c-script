using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004281 RID: 17025
	public class IWaitBattleConditionT
	{
		// Token: 0x170078D8 RID: 30936
		// (get) Token: 0x06019356 RID: 103254 RVA: 0x0039F38F File Offset: 0x0039D58F
		// (set) Token: 0x06019357 RID: 103255 RVA: 0x0039F397 File Offset: 0x0039D597
		public EChildQuest Type { get; set; }

		// Token: 0x170078D9 RID: 30937
		// (get) Token: 0x06019358 RID: 103256 RVA: 0x0039F3A0 File Offset: 0x0039D5A0
		// (set) Token: 0x06019359 RID: 103257 RVA: 0x0039F3A8 File Offset: 0x0039D5A8
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170078DA RID: 30938
		// (get) Token: 0x0601935A RID: 103258 RVA: 0x0039F3B1 File Offset: 0x0039D5B1
		// (set) Token: 0x0601935B RID: 103259 RVA: 0x0039F3B9 File Offset: 0x0039D5B9
		public EConditionCount Count { get; set; }

		// Token: 0x170078DB RID: 30939
		// (get) Token: 0x0601935C RID: 103260 RVA: 0x0039F3C2 File Offset: 0x0039D5C2
		// (set) Token: 0x0601935D RID: 103261 RVA: 0x0039F3CA File Offset: 0x0039D5CA
		public List<TBattleConditionUnion> Option { get; set; }

		// Token: 0x0601935E RID: 103262 RVA: 0x0039F3D3 File Offset: 0x0039D5D3
		public IWaitBattleConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Option = null;
		}
	}
}
