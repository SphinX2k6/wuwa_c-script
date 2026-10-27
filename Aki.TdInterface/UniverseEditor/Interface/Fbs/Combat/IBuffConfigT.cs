using System;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EE5 RID: 24293
	public class IBuffConfigT
	{
		// Token: 0x1700B5A7 RID: 46503
		// (get) Token: 0x06029B84 RID: 170884 RVA: 0x005B9CB7 File Offset: 0x005B7EB7
		// (set) Token: 0x06029B85 RID: 170885 RVA: 0x005B9CBF File Offset: 0x005B7EBF
		public int Id { get; set; }

		// Token: 0x1700B5A8 RID: 46504
		// (get) Token: 0x06029B86 RID: 170886 RVA: 0x005B9CC8 File Offset: 0x005B7EC8
		// (set) Token: 0x06029B87 RID: 170887 RVA: 0x005B9CD0 File Offset: 0x005B7ED0
		public string Name { get; set; }

		// Token: 0x06029B88 RID: 170888 RVA: 0x005B9CD9 File Offset: 0x005B7ED9
		public IBuffConfigT()
		{
			this.Id = 0;
			this.Name = null;
		}
	}
}
