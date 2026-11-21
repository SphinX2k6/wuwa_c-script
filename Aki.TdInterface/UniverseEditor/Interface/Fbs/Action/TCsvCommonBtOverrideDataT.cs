using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA4 RID: 32420
	public class TCsvCommonBtOverrideDataT
	{
		// Token: 0x1700F238 RID: 62008
		// (get) Token: 0x0603A88B RID: 239755 RVA: 0x007E0A3F File Offset: 0x007DEC3F
		// (set) Token: 0x0603A88C RID: 239756 RVA: 0x007E0A47 File Offset: 0x007DEC47
		public int Id { get; set; }

		// Token: 0x1700F239 RID: 62009
		// (get) Token: 0x0603A88D RID: 239757 RVA: 0x007E0A50 File Offset: 0x007DEC50
		// (set) Token: 0x0603A88E RID: 239758 RVA: 0x007E0A58 File Offset: 0x007DEC58
		public ICommonBtOverrideT Data { get; set; }

		// Token: 0x0603A88F RID: 239759 RVA: 0x007E0A61 File Offset: 0x007DEC61
		public TCsvCommonBtOverrideDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
