using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F42 RID: 16194
	public class IMonsterPointTypeConfigT
	{
		// Token: 0x1700709F RID: 28831
		// (get) Token: 0x0601704B RID: 94283 RVA: 0x00351C94 File Offset: 0x0034FE94
		// (set) Token: 0x0601704C RID: 94284 RVA: 0x00351C9C File Offset: 0x0034FE9C
		public EMonsterMatchType MonsterType { get; set; }

		// Token: 0x170070A0 RID: 28832
		// (get) Token: 0x0601704D RID: 94285 RVA: 0x00351CA5 File Offset: 0x0034FEA5
		// (set) Token: 0x0601704E RID: 94286 RVA: 0x00351CAD File Offset: 0x0034FEAD
		public int Point { get; set; }

		// Token: 0x0601704F RID: 94287 RVA: 0x00351CB6 File Offset: 0x0034FEB6
		public IMonsterPointTypeConfigT()
		{
			this.MonsterType = EMonsterMatchType.Normal;
			this.Point = 0;
		}
	}
}
