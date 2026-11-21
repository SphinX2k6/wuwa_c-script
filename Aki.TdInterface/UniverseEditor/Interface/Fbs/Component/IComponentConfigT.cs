using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553F RID: 21823
	public class IComponentConfigT
	{
		// Token: 0x17009C07 RID: 39943
		// (get) Token: 0x060229EB RID: 141803 RVA: 0x004C4B7B File Offset: 0x004C2D7B
		// (set) Token: 0x060229EC RID: 141804 RVA: 0x004C4B83 File Offset: 0x004C2D83
		public List<EAction> BaseActions { get; set; }

		// Token: 0x17009C08 RID: 39944
		// (get) Token: 0x060229ED RID: 141805 RVA: 0x004C4B8C File Offset: 0x004C2D8C
		// (set) Token: 0x060229EE RID: 141806 RVA: 0x004C4B94 File Offset: 0x004C2D94
		public string ActionsByComponent { get; set; }

		// Token: 0x060229EF RID: 141807 RVA: 0x004C4B9D File Offset: 0x004C2D9D
		public IComponentConfigT()
		{
			this.BaseActions = null;
			this.ActionsByComponent = null;
		}
	}
}
