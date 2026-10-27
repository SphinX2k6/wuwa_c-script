using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A2E RID: 14894
	public class IBvbCardFilterCheckHasBattleFactorT
	{
		// Token: 0x17006611 RID: 26129
		// (get) Token: 0x06014265 RID: 82533 RVA: 0x002F2593 File Offset: 0x002F0793
		// (set) Token: 0x06014266 RID: 82534 RVA: 0x002F259B File Offset: 0x002F079B
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006612 RID: 26130
		// (get) Token: 0x06014267 RID: 82535 RVA: 0x002F25A4 File Offset: 0x002F07A4
		// (set) Token: 0x06014268 RID: 82536 RVA: 0x002F25AC File Offset: 0x002F07AC
		public List<int> BattleFactorList { get; set; }

		// Token: 0x06014269 RID: 82537 RVA: 0x002F25B5 File Offset: 0x002F07B5
		public IBvbCardFilterCheckHasBattleFactorT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.BattleFactorList = null;
		}
	}
}
