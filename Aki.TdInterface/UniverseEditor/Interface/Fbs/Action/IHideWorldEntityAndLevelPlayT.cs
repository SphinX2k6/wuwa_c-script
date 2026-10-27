using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690D RID: 26893
	public class IHideWorldEntityAndLevelPlayT
	{
		// Token: 0x1700C788 RID: 51080
		// (get) Token: 0x0602EEF0 RID: 192240 RVA: 0x00666A6D File Offset: 0x00664C6D
		// (set) Token: 0x0602EEF1 RID: 192241 RVA: 0x00666A75 File Offset: 0x00664C75
		public EHideType Type { get; set; }

		// Token: 0x1700C789 RID: 51081
		// (get) Token: 0x0602EEF2 RID: 192242 RVA: 0x00666A7E File Offset: 0x00664C7E
		// (set) Token: 0x0602EEF3 RID: 192243 RVA: 0x00666A86 File Offset: 0x00664C86
		public List<int> ExcludeEntities { get; set; }

		// Token: 0x1700C78A RID: 51082
		// (get) Token: 0x0602EEF4 RID: 192244 RVA: 0x00666A8F File Offset: 0x00664C8F
		// (set) Token: 0x0602EEF5 RID: 192245 RVA: 0x00666A97 File Offset: 0x00664C97
		public byte NullMask { get; set; }

		// Token: 0x0602EEF6 RID: 192246 RVA: 0x00666AA0 File Offset: 0x00664CA0
		public IHideWorldEntityAndLevelPlayT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.ExcludeEntities = null;
			this.NullMask = 0;
		}
	}
}
