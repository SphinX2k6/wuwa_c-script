using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC6 RID: 28614
	public class IHideWorldMonsterAndMonsterTreasureT
	{
		// Token: 0x1700D19F RID: 53663
		// (get) Token: 0x06031928 RID: 203048 RVA: 0x006B7BB6 File Offset: 0x006B5DB6
		// (set) Token: 0x06031929 RID: 203049 RVA: 0x006B7BBE File Offset: 0x006B5DBE
		public EHideType Type { get; set; }

		// Token: 0x0603192A RID: 203050 RVA: 0x006B7BC7 File Offset: 0x006B5DC7
		public IHideWorldMonsterAndMonsterTreasureT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
		}
	}
}
