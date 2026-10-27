using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051DE RID: 20958
	public class IExploreSkillCustomT
	{
		// Token: 0x17009965 RID: 39269
		// (get) Token: 0x06021FDC RID: 139228 RVA: 0x004B70D5 File Offset: 0x004B52D5
		// (set) Token: 0x06021FDD RID: 139229 RVA: 0x004B70DD File Offset: 0x004B52DD
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x17009966 RID: 39270
		// (get) Token: 0x06021FDE RID: 139230 RVA: 0x004B70E6 File Offset: 0x004B52E6
		// (set) Token: 0x06021FDF RID: 139231 RVA: 0x004B70EE File Offset: 0x004B52EE
		public int LockConfigId { get; set; }

		// Token: 0x17009967 RID: 39271
		// (get) Token: 0x06021FE0 RID: 139232 RVA: 0x004B70F7 File Offset: 0x004B52F7
		// (set) Token: 0x06021FE1 RID: 139233 RVA: 0x004B70FF File Offset: 0x004B52FF
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009968 RID: 39272
		// (get) Token: 0x06021FE2 RID: 139234 RVA: 0x004B7108 File Offset: 0x004B5308
		// (set) Token: 0x06021FE3 RID: 139235 RVA: 0x004B7110 File Offset: 0x004B5310
		public IVectorInfoT InteractOffset { get; set; }

		// Token: 0x06021FE4 RID: 139236 RVA: 0x004B7119 File Offset: 0x004B5319
		public IExploreSkillCustomT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.LockConfigId = 0;
			this.Actions = null;
			this.InteractOffset = null;
		}
	}
}
