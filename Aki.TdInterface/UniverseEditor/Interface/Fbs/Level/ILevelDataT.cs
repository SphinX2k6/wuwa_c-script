using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004875 RID: 18549
	public class ILevelDataT
	{
		// Token: 0x1700812C RID: 33068
		// (get) Token: 0x0601B6E7 RID: 112359 RVA: 0x003E2011 File Offset: 0x003E0211
		// (set) Token: 0x0601B6E8 RID: 112360 RVA: 0x003E2019 File Offset: 0x003E0219
		public List<IEntityDataT> EntityDatas { get; set; }

		// Token: 0x0601B6E9 RID: 112361 RVA: 0x003E2022 File Offset: 0x003E0222
		public ILevelDataT()
		{
			this.EntityDatas = null;
		}
	}
}
