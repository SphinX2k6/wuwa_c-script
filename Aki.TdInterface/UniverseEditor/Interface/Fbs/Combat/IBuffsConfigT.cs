using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EE8 RID: 24296
	public class IBuffsConfigT
	{
		// Token: 0x1700B5AB RID: 46507
		// (get) Token: 0x06029B9E RID: 170910 RVA: 0x005B9FE1 File Offset: 0x005B81E1
		// (set) Token: 0x06029B9F RID: 170911 RVA: 0x005B9FE9 File Offset: 0x005B81E9
		public List<IBuffConfigT> Buffs { get; set; }

		// Token: 0x06029BA0 RID: 170912 RVA: 0x005B9FF2 File Offset: 0x005B81F2
		public IBuffsConfigT()
		{
			this.Buffs = null;
		}
	}
}
