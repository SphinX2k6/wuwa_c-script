using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F64 RID: 24420
	public class ISpawnMonsterPointT
	{
		// Token: 0x1700B4E7 RID: 46311
		// (get) Token: 0x060290DF RID: 168159 RVA: 0x0059BA67 File Offset: 0x00599C67
		// (set) Token: 0x060290E0 RID: 168160 RVA: 0x0059BA6F File Offset: 0x00599C6F
		public EPointChooseType Type { get; set; }

		// Token: 0x1700B4E8 RID: 46312
		// (get) Token: 0x060290E1 RID: 168161 RVA: 0x0059BA78 File Offset: 0x00599C78
		// (set) Token: 0x060290E2 RID: 168162 RVA: 0x0059BA80 File Offset: 0x00599C80
		public ISearchSpawnMonsterPointT RangeConstraint { get; set; }

		// Token: 0x060290E3 RID: 168163 RVA: 0x0059BA89 File Offset: 0x00599C89
		public ISpawnMonsterPointT()
		{
			this.Type = EPointChooseType.SpawnMonsterPoint;
			this.RangeConstraint = null;
		}
	}
}
