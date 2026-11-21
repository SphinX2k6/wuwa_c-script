using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC9 RID: 28617
	public class IHideWorldMonsterAndMonsterTreasureGroupT
	{
		// Token: 0x1700D1A3 RID: 53667
		// (get) Token: 0x06031944 RID: 203076 RVA: 0x006B7EBF File Offset: 0x006B60BF
		// (set) Token: 0x06031945 RID: 203077 RVA: 0x006B7EC7 File Offset: 0x006B60C7
		public EHideType Type { get; set; }

		// Token: 0x1700D1A4 RID: 53668
		// (get) Token: 0x06031946 RID: 203078 RVA: 0x006B7ED0 File Offset: 0x006B60D0
		// (set) Token: 0x06031947 RID: 203079 RVA: 0x006B7ED8 File Offset: 0x006B60D8
		public List<int> HideRangeEntities { get; set; }

		// Token: 0x06031948 RID: 203080 RVA: 0x006B7EE1 File Offset: 0x006B60E1
		public IHideWorldMonsterAndMonsterTreasureGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.HideRangeEntities = null;
		}
	}
}
