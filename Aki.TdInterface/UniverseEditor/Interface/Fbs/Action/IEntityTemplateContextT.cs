using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6E RID: 28014
	public class IEntityTemplateContextT
	{
		// Token: 0x1700CD87 RID: 52615
		// (get) Token: 0x06030560 RID: 197984 RVA: 0x00691787 File Offset: 0x0068F987
		// (set) Token: 0x06030561 RID: 197985 RVA: 0x0069178F File Offset: 0x0068F98F
		public EVarContext Type { get; set; }

		// Token: 0x1700CD88 RID: 52616
		// (get) Token: 0x06030562 RID: 197986 RVA: 0x00691798 File Offset: 0x0068F998
		// (set) Token: 0x06030563 RID: 197987 RVA: 0x006917A0 File Offset: 0x0068F9A0
		public string Id { get; set; }

		// Token: 0x06030564 RID: 197988 RVA: 0x006917A9 File Offset: 0x0068F9A9
		public IEntityTemplateContextT()
		{
			this.Type = EVarContext.None;
			this.Id = null;
		}
	}
}
