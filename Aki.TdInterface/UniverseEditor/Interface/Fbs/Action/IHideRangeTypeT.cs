using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F5 RID: 26869
	public class IHideRangeTypeT
	{
		// Token: 0x1700C75B RID: 51035
		// (get) Token: 0x0602EE01 RID: 192001 RVA: 0x00664F76 File Offset: 0x00663176
		// (set) Token: 0x0602EE02 RID: 192002 RVA: 0x00664F7E File Offset: 0x0066317E
		public EHideType Type { get; set; }

		// Token: 0x0602EE03 RID: 192003 RVA: 0x00664F87 File Offset: 0x00663187
		public IHideRangeTypeT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
		}
	}
}
