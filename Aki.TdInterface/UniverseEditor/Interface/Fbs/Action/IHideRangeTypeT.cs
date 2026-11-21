using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA8 RID: 28584
	public class IHideRangeTypeT
	{
		// Token: 0x1700D15E RID: 53598
		// (get) Token: 0x060317D1 RID: 202705 RVA: 0x006B545E File Offset: 0x006B365E
		// (set) Token: 0x060317D2 RID: 202706 RVA: 0x006B5466 File Offset: 0x006B3666
		public EHideType Type { get; set; }

		// Token: 0x060317D3 RID: 202707 RVA: 0x006B546F File Offset: 0x006B366F
		public IHideRangeTypeT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
		}
	}
}
