using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBA RID: 28602
	public class IHideSpecifyLevelPlayGroupT
	{
		// Token: 0x1700D17A RID: 53626
		// (get) Token: 0x06031879 RID: 202873 RVA: 0x006B663F File Offset: 0x006B483F
		// (set) Token: 0x0603187A RID: 202874 RVA: 0x006B6647 File Offset: 0x006B4847
		public EHideType Type { get; set; }

		// Token: 0x1700D17B RID: 53627
		// (get) Token: 0x0603187B RID: 202875 RVA: 0x006B6650 File Offset: 0x006B4850
		// (set) Token: 0x0603187C RID: 202876 RVA: 0x006B6658 File Offset: 0x006B4858
		public List<int> LevelPlays { get; set; }

		// Token: 0x0603187D RID: 202877 RVA: 0x006B6661 File Offset: 0x006B4861
		public IHideSpecifyLevelPlayGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.LevelPlays = null;
		}
	}
}
