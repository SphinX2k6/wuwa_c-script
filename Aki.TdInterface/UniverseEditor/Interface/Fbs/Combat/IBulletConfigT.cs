using System;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EEB RID: 24299
	public class IBulletConfigT
	{
		// Token: 0x1700B5AF RID: 46511
		// (get) Token: 0x06029BB4 RID: 170932 RVA: 0x005BA207 File Offset: 0x005B8407
		// (set) Token: 0x06029BB5 RID: 170933 RVA: 0x005BA20F File Offset: 0x005B840F
		public int Id { get; set; }

		// Token: 0x1700B5B0 RID: 46512
		// (get) Token: 0x06029BB6 RID: 170934 RVA: 0x005BA218 File Offset: 0x005B8418
		// (set) Token: 0x06029BB7 RID: 170935 RVA: 0x005BA220 File Offset: 0x005B8420
		public string Name { get; set; }

		// Token: 0x06029BB8 RID: 170936 RVA: 0x005BA229 File Offset: 0x005B8429
		public IBulletConfigT()
		{
			this.Id = 0;
			this.Name = null;
		}
	}
}
