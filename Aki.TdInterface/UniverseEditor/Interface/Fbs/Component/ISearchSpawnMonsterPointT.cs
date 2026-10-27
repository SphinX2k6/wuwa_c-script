using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F5 RID: 22773
	public class ISearchSpawnMonsterPointT
	{
		// Token: 0x1700AAAA RID: 43690
		// (get) Token: 0x06026790 RID: 157584 RVA: 0x0054D17C File Offset: 0x0054B37C
		// (set) Token: 0x06026791 RID: 157585 RVA: 0x0054D184 File Offset: 0x0054B384
		public ERangeConstraint Type { get; set; }

		// Token: 0x1700AAAB RID: 43691
		// (get) Token: 0x06026792 RID: 157586 RVA: 0x0054D18D File Offset: 0x0054B38D
		// (set) Token: 0x06026793 RID: 157587 RVA: 0x0054D195 File Offset: 0x0054B395
		public int Radius { get; set; }

		// Token: 0x1700AAAC RID: 43692
		// (get) Token: 0x06026794 RID: 157588 RVA: 0x0054D19E File Offset: 0x0054B39E
		// (set) Token: 0x06026795 RID: 157589 RVA: 0x0054D1A6 File Offset: 0x0054B3A6
		public int TagId { get; set; }

		// Token: 0x1700AAAD RID: 43693
		// (get) Token: 0x06026796 RID: 157590 RVA: 0x0054D1AF File Offset: 0x0054B3AF
		// (set) Token: 0x06026797 RID: 157591 RVA: 0x0054D1B7 File Offset: 0x0054B3B7
		public byte NullMask { get; set; }

		// Token: 0x06026798 RID: 157592 RVA: 0x0054D1C0 File Offset: 0x0054B3C0
		public ISearchSpawnMonsterPointT()
		{
			this.Type = ERangeConstraint.SearchSpawnMonsterPoint;
			this.Radius = 0;
			this.TagId = 0;
			this.NullMask = 0;
		}
	}
}
