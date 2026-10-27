using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FE RID: 26878
	public class IHideSpecifyDataLayersT
	{
		// Token: 0x1700C764 RID: 51044
		// (get) Token: 0x0602EE47 RID: 192071 RVA: 0x006656AF File Offset: 0x006638AF
		// (set) Token: 0x0602EE48 RID: 192072 RVA: 0x006656B7 File Offset: 0x006638B7
		public EHideType Type { get; set; }

		// Token: 0x1700C765 RID: 51045
		// (get) Token: 0x0602EE49 RID: 192073 RVA: 0x006656C0 File Offset: 0x006638C0
		// (set) Token: 0x0602EE4A RID: 192074 RVA: 0x006656C8 File Offset: 0x006638C8
		public List<int> DataLayers { get; set; }

		// Token: 0x0602EE4B RID: 192075 RVA: 0x006656D1 File Offset: 0x006638D1
		public IHideSpecifyDataLayersT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.DataLayers = null;
		}
	}
}
