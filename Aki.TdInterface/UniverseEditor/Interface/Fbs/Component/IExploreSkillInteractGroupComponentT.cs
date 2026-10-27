using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051EA RID: 20970
	public class IExploreSkillInteractGroupComponentT
	{
		// Token: 0x1700999E RID: 39326
		// (get) Token: 0x060220DE RID: 139486 RVA: 0x004BA1F9 File Offset: 0x004B83F9
		// (set) Token: 0x060220DF RID: 139487 RVA: 0x004BA201 File Offset: 0x004B8401
		public bool Disabled { get; set; }

		// Token: 0x1700999F RID: 39327
		// (get) Token: 0x060220E0 RID: 139488 RVA: 0x004BA20A File Offset: 0x004B840A
		// (set) Token: 0x060220E1 RID: 139489 RVA: 0x004BA212 File Offset: 0x004B8412
		public List<IExploreSkillInteractT> ExploreSkillInteractList { get; set; }

		// Token: 0x170099A0 RID: 39328
		// (get) Token: 0x060220E2 RID: 139490 RVA: 0x004BA21B File Offset: 0x004B841B
		// (set) Token: 0x060220E3 RID: 139491 RVA: 0x004BA223 File Offset: 0x004B8423
		public byte NullMask { get; set; }

		// Token: 0x060220E4 RID: 139492 RVA: 0x004BA22C File Offset: 0x004B842C
		public IExploreSkillInteractGroupComponentT()
		{
			this.Disabled = false;
			this.ExploreSkillInteractList = null;
			this.NullMask = 0;
		}
	}
}
