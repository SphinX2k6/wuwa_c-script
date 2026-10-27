using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005223 RID: 21027
	public class IFailureConditionHitTargetEntityT
	{
		// Token: 0x17009A01 RID: 39425
		// (get) Token: 0x060222D9 RID: 139993 RVA: 0x004BDD47 File Offset: 0x004BBF47
		// (set) Token: 0x060222DA RID: 139994 RVA: 0x004BDD4F File Offset: 0x004BBF4F
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x17009A02 RID: 39426
		// (get) Token: 0x060222DB RID: 139995 RVA: 0x004BDD58 File Offset: 0x004BBF58
		// (set) Token: 0x060222DC RID: 139996 RVA: 0x004BDD60 File Offset: 0x004BBF60
		public List<int> EntityIds { get; set; }

		// Token: 0x060222DD RID: 139997 RVA: 0x004BDD69 File Offset: 0x004BBF69
		public IFailureConditionHitTargetEntityT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
			this.EntityIds = null;
		}
	}
}
