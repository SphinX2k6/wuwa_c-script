using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A39 RID: 27193
	public class ILongPressButtonActionMappingT
	{
		// Token: 0x1700C9B1 RID: 51633
		// (get) Token: 0x0602F97C RID: 194940 RVA: 0x0067A483 File Offset: 0x00678683
		// (set) Token: 0x0602F97D RID: 194941 RVA: 0x0067A48B File Offset: 0x0067868B
		public int Id { get; set; }

		// Token: 0x1700C9B2 RID: 51634
		// (get) Token: 0x0602F97E RID: 194942 RVA: 0x0067A494 File Offset: 0x00678694
		// (set) Token: 0x0602F97F RID: 194943 RVA: 0x0067A49C File Offset: 0x0067869C
		public string ActionName { get; set; }

		// Token: 0x0602F980 RID: 194944 RVA: 0x0067A4A5 File Offset: 0x006786A5
		public ILongPressButtonActionMappingT()
		{
			this.Id = 0;
			this.ActionName = null;
		}
	}
}
