using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538D RID: 21389
	public class IHitLogicActionByHitTypeT
	{
		// Token: 0x17009D31 RID: 40241
		// (get) Token: 0x06023074 RID: 143476 RVA: 0x004D9C87 File Offset: 0x004D7E87
		// (set) Token: 0x06023075 RID: 143477 RVA: 0x004D9C8F File Offset: 0x004D7E8F
		public EHitLogicType Type { get; set; }

		// Token: 0x17009D32 RID: 40242
		// (get) Token: 0x06023076 RID: 143478 RVA: 0x004D9C98 File Offset: 0x004D7E98
		// (set) Token: 0x06023077 RID: 143479 RVA: 0x004D9CA0 File Offset: 0x004D7EA0
		public List<IActionByHitTypeConfigT> Configs { get; set; }

		// Token: 0x06023078 RID: 143480 RVA: 0x004D9CA9 File Offset: 0x004D7EA9
		public IHitLogicActionByHitTypeT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.Configs = null;
		}
	}
}
