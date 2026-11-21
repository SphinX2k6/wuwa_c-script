using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004377 RID: 17271
	public class IMonsterHpPointTypeConfigT
	{
		// Token: 0x17007681 RID: 30337
		// (get) Token: 0x06018663 RID: 99939 RVA: 0x0037A9DC File Offset: 0x00378BDC
		// (set) Token: 0x06018664 RID: 99940 RVA: 0x0037A9E4 File Offset: 0x00378BE4
		public EMonsterMatchType MonsterType { get; set; }

		// Token: 0x17007682 RID: 30338
		// (get) Token: 0x06018665 RID: 99941 RVA: 0x0037A9ED File Offset: 0x00378BED
		// (set) Token: 0x06018666 RID: 99942 RVA: 0x0037A9F5 File Offset: 0x00378BF5
		public int PointOfEveryOnePercentHp { get; set; }

		// Token: 0x06018667 RID: 99943 RVA: 0x0037A9FE File Offset: 0x00378BFE
		public IMonsterHpPointTypeConfigT()
		{
			this.MonsterType = EMonsterMatchType.Normal;
			this.PointOfEveryOnePercentHp = 0;
		}
	}
}
