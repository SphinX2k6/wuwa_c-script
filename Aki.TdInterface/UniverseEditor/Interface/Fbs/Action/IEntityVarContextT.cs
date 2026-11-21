using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D74 RID: 28020
	public class IEntityVarContextT
	{
		// Token: 0x1700CD97 RID: 52631
		// (get) Token: 0x0603059F RID: 198047 RVA: 0x00691FF8 File Offset: 0x006901F8
		// (set) Token: 0x060305A0 RID: 198048 RVA: 0x00692000 File Offset: 0x00690200
		public EVarContext Type { get; set; }

		// Token: 0x1700CD98 RID: 52632
		// (get) Token: 0x060305A1 RID: 198049 RVA: 0x00692009 File Offset: 0x00690209
		// (set) Token: 0x060305A2 RID: 198050 RVA: 0x00692011 File Offset: 0x00690211
		public int Id { get; set; }

		// Token: 0x1700CD99 RID: 52633
		// (get) Token: 0x060305A3 RID: 198051 RVA: 0x0069201A File Offset: 0x0069021A
		// (set) Token: 0x060305A4 RID: 198052 RVA: 0x00692022 File Offset: 0x00690222
		public EEntityVarMatchType MatchType { get; set; }

		// Token: 0x1700CD9A RID: 52634
		// (get) Token: 0x060305A5 RID: 198053 RVA: 0x0069202B File Offset: 0x0069022B
		// (set) Token: 0x060305A6 RID: 198054 RVA: 0x00692033 File Offset: 0x00690233
		public byte NullMask { get; set; }

		// Token: 0x060305A7 RID: 198055 RVA: 0x0069203C File Offset: 0x0069023C
		public IEntityVarContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
			this.MatchType = EEntityVarMatchType.EntityId;
			this.NullMask = 0;
		}
	}
}
