using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200440D RID: 17421
	public class ILevelDataT
	{
		// Token: 0x17007AED RID: 31469
		// (get) Token: 0x06019F16 RID: 106262 RVA: 0x003B5E05 File Offset: 0x003B4005
		// (set) Token: 0x06019F17 RID: 106263 RVA: 0x003B5E0D File Offset: 0x003B400D
		public List<IEntityDataT> EntityDatas { get; set; }

		// Token: 0x06019F18 RID: 106264 RVA: 0x003B5E16 File Offset: 0x003B4016
		public ILevelDataT()
		{
			this.EntityDatas = null;
		}
	}
}
