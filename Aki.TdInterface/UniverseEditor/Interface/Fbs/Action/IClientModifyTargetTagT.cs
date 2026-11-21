using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5A RID: 27226
	public class IClientModifyTargetTagT
	{
		// Token: 0x1700C806 RID: 51206
		// (get) Token: 0x0602EB59 RID: 191321 RVA: 0x0065DE3E File Offset: 0x0065C03E
		// (set) Token: 0x0602EB5A RID: 191322 RVA: 0x0065DE46 File Offset: 0x0065C046
		public bool IsAddTag { get; set; }

		// Token: 0x1700C807 RID: 51207
		// (get) Token: 0x0602EB5B RID: 191323 RVA: 0x0065DE4F File Offset: 0x0065C04F
		// (set) Token: 0x0602EB5C RID: 191324 RVA: 0x0065DE57 File Offset: 0x0065C057
		public TClientModifyTargetUnion Target { get; set; }

		// Token: 0x1700C808 RID: 51208
		// (get) Token: 0x0602EB5D RID: 191325 RVA: 0x0065DE60 File Offset: 0x0065C060
		// (set) Token: 0x0602EB5E RID: 191326 RVA: 0x0065DE68 File Offset: 0x0065C068
		public List<string> PerformanceTag { get; set; }

		// Token: 0x0602EB5F RID: 191327 RVA: 0x0065DE71 File Offset: 0x0065C071
		public IClientModifyTargetTagT()
		{
			this.IsAddTag = false;
			this.Target = null;
			this.PerformanceTag = null;
		}
	}
}
