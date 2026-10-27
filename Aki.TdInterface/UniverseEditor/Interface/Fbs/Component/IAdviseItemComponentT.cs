using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E6C RID: 20076
	public class IAdviseItemComponentT
	{
		// Token: 0x17008FB7 RID: 36791
		// (get) Token: 0x0601F878 RID: 129144 RVA: 0x00464210 File Offset: 0x00462410
		// (set) Token: 0x0601F879 RID: 129145 RVA: 0x00464218 File Offset: 0x00462418
		public bool Disabled { get; set; }

		// Token: 0x17008FB8 RID: 36792
		// (get) Token: 0x0601F87A RID: 129146 RVA: 0x00464221 File Offset: 0x00462421
		// (set) Token: 0x0601F87B RID: 129147 RVA: 0x00464229 File Offset: 0x00462429
		public byte NullMask { get; set; }

		// Token: 0x0601F87C RID: 129148 RVA: 0x00464232 File Offset: 0x00462432
		public IAdviseItemComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
