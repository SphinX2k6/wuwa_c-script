using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005089 RID: 20617
	public class ICompareExploreLevelConditionT
	{
		// Token: 0x1700939A RID: 37786
		// (get) Token: 0x0602040C RID: 132108 RVA: 0x004782EA File Offset: 0x004764EA
		// (set) Token: 0x0602040D RID: 132109 RVA: 0x004782F2 File Offset: 0x004764F2
		public ECondition Type { get; set; }

		// Token: 0x1700939B RID: 37787
		// (get) Token: 0x0602040E RID: 132110 RVA: 0x004782FB File Offset: 0x004764FB
		// (set) Token: 0x0602040F RID: 132111 RVA: 0x00478303 File Offset: 0x00476503
		public ECompare Compare { get; set; }

		// Token: 0x1700939C RID: 37788
		// (get) Token: 0x06020410 RID: 132112 RVA: 0x0047830C File Offset: 0x0047650C
		// (set) Token: 0x06020411 RID: 132113 RVA: 0x00478314 File Offset: 0x00476514
		public int Level { get; set; }

		// Token: 0x06020412 RID: 132114 RVA: 0x0047831D File Offset: 0x0047651D
		public ICompareExploreLevelConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
