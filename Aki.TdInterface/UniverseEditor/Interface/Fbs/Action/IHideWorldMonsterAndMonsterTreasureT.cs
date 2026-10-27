using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006913 RID: 26899
	public class IHideWorldMonsterAndMonsterTreasureT
	{
		// Token: 0x1700C79C RID: 51100
		// (get) Token: 0x0602EF58 RID: 192344 RVA: 0x006676CE File Offset: 0x006658CE
		// (set) Token: 0x0602EF59 RID: 192345 RVA: 0x006676D6 File Offset: 0x006658D6
		public EHideType Type { get; set; }

		// Token: 0x0602EF5A RID: 192346 RVA: 0x006676DF File Offset: 0x006658DF
		public IHideWorldMonsterAndMonsterTreasureT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
		}
	}
}
