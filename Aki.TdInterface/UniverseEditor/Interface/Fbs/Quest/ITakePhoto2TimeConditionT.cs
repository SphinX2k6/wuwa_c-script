using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A6 RID: 16806
	public class ITakePhoto2TimeConditionT
	{
		// Token: 0x1700772D RID: 30509
		// (get) Token: 0x06018BCC RID: 101324 RVA: 0x0038FCFB File Offset: 0x0038DEFB
		// (set) Token: 0x06018BCD RID: 101325 RVA: 0x0038FD03 File Offset: 0x0038DF03
		public IHourToHourT TimeRange { get; set; }

		// Token: 0x1700772E RID: 30510
		// (get) Token: 0x06018BCE RID: 101326 RVA: 0x0038FD0C File Offset: 0x0038DF0C
		// (set) Token: 0x06018BCF RID: 101327 RVA: 0x0038FD14 File Offset: 0x0038DF14
		public ECompare Compare { get; set; }

		// Token: 0x06018BD0 RID: 101328 RVA: 0x0038FD1D File Offset: 0x0038DF1D
		public ITakePhoto2TimeConditionT()
		{
			this.TimeRange = null;
			this.Compare = ECompare.Eq;
		}
	}
}
