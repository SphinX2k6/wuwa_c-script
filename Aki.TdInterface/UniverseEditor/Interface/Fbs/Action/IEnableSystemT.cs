using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006694 RID: 26260
	public class IEnableSystemT
	{
		// Token: 0x1700C32C RID: 49964
		// (get) Token: 0x0602DA51 RID: 186961 RVA: 0x0063F464 File Offset: 0x0063D664
		// (set) Token: 0x0602DA52 RID: 186962 RVA: 0x0063F46C File Offset: 0x0063D66C
		public ESystem SystemType { get; set; }

		// Token: 0x1700C32D RID: 49965
		// (get) Token: 0x0602DA53 RID: 186963 RVA: 0x0063F475 File Offset: 0x0063D675
		// (set) Token: 0x0602DA54 RID: 186964 RVA: 0x0063F47D File Offset: 0x0063D67D
		public bool IsEnable { get; set; }

		// Token: 0x0602DA55 RID: 186965 RVA: 0x0063F486 File Offset: 0x0063D686
		public IEnableSystemT()
		{
			this.SystemType = ESystem.None;
			this.IsEnable = false;
		}
	}
}
