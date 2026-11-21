using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768B RID: 30347
	public class IRotatorEntityT
	{
		// Token: 0x1700DEB4 RID: 57012
		// (get) Token: 0x060353CC RID: 218060 RVA: 0x00724E95 File Offset: 0x00723095
		// (set) Token: 0x060353CD RID: 218061 RVA: 0x00724E9D File Offset: 0x0072309D
		public TTargetEntityUnion Entity { get; set; }

		// Token: 0x060353CE RID: 218062 RVA: 0x00724EA6 File Offset: 0x007230A6
		public IRotatorEntityT()
		{
			this.Entity = null;
		}
	}
}
