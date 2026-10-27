using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F39 RID: 16185
	public class IMonsterHpPointTypeConfigT
	{
		// Token: 0x17007090 RID: 28816
		// (get) Token: 0x06017001 RID: 94209 RVA: 0x00351568 File Offset: 0x0034F768
		// (set) Token: 0x06017002 RID: 94210 RVA: 0x00351570 File Offset: 0x0034F770
		public EMonsterMatchType MonsterType { get; set; }

		// Token: 0x17007091 RID: 28817
		// (get) Token: 0x06017003 RID: 94211 RVA: 0x00351579 File Offset: 0x0034F779
		// (set) Token: 0x06017004 RID: 94212 RVA: 0x00351581 File Offset: 0x0034F781
		public int PointOfEveryOnePercentHp { get; set; }

		// Token: 0x06017005 RID: 94213 RVA: 0x0035158A File Offset: 0x0034F78A
		public IMonsterHpPointTypeConfigT()
		{
			this.MonsterType = EMonsterMatchType.Normal;
			this.PointOfEveryOnePercentHp = 0;
		}
	}
}
