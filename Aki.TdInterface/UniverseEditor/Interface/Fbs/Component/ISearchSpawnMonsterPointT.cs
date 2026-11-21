using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F02 RID: 24322
	public class ISearchSpawnMonsterPointT
	{
		// Token: 0x1700B3DE RID: 46046
		// (get) Token: 0x06028CFA RID: 167162 RVA: 0x00593DE8 File Offset: 0x00591FE8
		// (set) Token: 0x06028CFB RID: 167163 RVA: 0x00593DF0 File Offset: 0x00591FF0
		public ERangeConstraint Type { get; set; }

		// Token: 0x1700B3DF RID: 46047
		// (get) Token: 0x06028CFC RID: 167164 RVA: 0x00593DF9 File Offset: 0x00591FF9
		// (set) Token: 0x06028CFD RID: 167165 RVA: 0x00593E01 File Offset: 0x00592001
		public int Radius { get; set; }

		// Token: 0x1700B3E0 RID: 46048
		// (get) Token: 0x06028CFE RID: 167166 RVA: 0x00593E0A File Offset: 0x0059200A
		// (set) Token: 0x06028CFF RID: 167167 RVA: 0x00593E12 File Offset: 0x00592012
		public int TagId { get; set; }

		// Token: 0x1700B3E1 RID: 46049
		// (get) Token: 0x06028D00 RID: 167168 RVA: 0x00593E1B File Offset: 0x0059201B
		// (set) Token: 0x06028D01 RID: 167169 RVA: 0x00593E23 File Offset: 0x00592023
		public byte NullMask { get; set; }

		// Token: 0x06028D02 RID: 167170 RVA: 0x00593E2C File Offset: 0x0059202C
		public ISearchSpawnMonsterPointT()
		{
			this.Type = ERangeConstraint.SearchSpawnMonsterPoint;
			this.Radius = 0;
			this.TagId = 0;
			this.NullMask = 0;
		}
	}
}
