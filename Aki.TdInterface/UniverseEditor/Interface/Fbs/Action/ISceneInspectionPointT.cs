using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B8 RID: 30392
	public class ISceneInspectionPointT
	{
		// Token: 0x1700DEF1 RID: 57073
		// (get) Token: 0x06035511 RID: 218385 RVA: 0x0072712C File Offset: 0x0072532C
		// (set) Token: 0x06035512 RID: 218386 RVA: 0x00727134 File Offset: 0x00725334
		public IVectorInfoT InteractPointPos { get; set; }

		// Token: 0x1700DEF2 RID: 57074
		// (get) Token: 0x06035513 RID: 218387 RVA: 0x0072713D File Offset: 0x0072533D
		// (set) Token: 0x06035514 RID: 218388 RVA: 0x00727145 File Offset: 0x00725345
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x06035515 RID: 218389 RVA: 0x0072714E File Offset: 0x0072534E
		public ISceneInspectionPointT()
		{
			this.InteractPointPos = null;
			this.ActionList = null;
		}
	}
}
