using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E1 RID: 20961
	public class IExploreSkillEavesdropT
	{
		// Token: 0x1700996D RID: 39277
		// (get) Token: 0x06021FFE RID: 139262 RVA: 0x004B75BB File Offset: 0x004B57BB
		// (set) Token: 0x06021FFF RID: 139263 RVA: 0x004B75C3 File Offset: 0x004B57C3
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700996E RID: 39278
		// (get) Token: 0x06022000 RID: 139264 RVA: 0x004B75CC File Offset: 0x004B57CC
		// (set) Token: 0x06022001 RID: 139265 RVA: 0x004B75D4 File Offset: 0x004B57D4
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700996F RID: 39279
		// (get) Token: 0x06022002 RID: 139266 RVA: 0x004B75DD File Offset: 0x004B57DD
		// (set) Token: 0x06022003 RID: 139267 RVA: 0x004B75E5 File Offset: 0x004B57E5
		public IVectorInfoT InteractOffset { get; set; }

		// Token: 0x06022004 RID: 139268 RVA: 0x004B75EE File Offset: 0x004B57EE
		public IExploreSkillEavesdropT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.Actions = null;
			this.InteractOffset = null;
		}
	}
}
