using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBB RID: 28603
	public class ISetBattleTagT
	{
		// Token: 0x1700D460 RID: 54368
		// (get) Token: 0x060328E4 RID: 207076 RVA: 0x006D2937 File Offset: 0x006D0B37
		// (set) Token: 0x060328E5 RID: 207077 RVA: 0x006D293F File Offset: 0x006D0B3F
		public ESetBattleStateType Type { get; set; }

		// Token: 0x1700D461 RID: 54369
		// (get) Token: 0x060328E6 RID: 207078 RVA: 0x006D2948 File Offset: 0x006D0B48
		// (set) Token: 0x060328E7 RID: 207079 RVA: 0x006D2950 File Offset: 0x006D0B50
		public List<ISetEntityTagT> SetTags { get; set; }

		// Token: 0x060328E8 RID: 207080 RVA: 0x006D2959 File Offset: 0x006D0B59
		public ISetBattleTagT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
			this.SetTags = null;
		}
	}
}
