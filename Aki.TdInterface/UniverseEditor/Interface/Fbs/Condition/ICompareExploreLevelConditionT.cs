using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B9F RID: 19359
	public class ICompareExploreLevelConditionT
	{
		// Token: 0x17008C81 RID: 35969
		// (get) Token: 0x0601E860 RID: 125024 RVA: 0x00445786 File Offset: 0x00443986
		// (set) Token: 0x0601E861 RID: 125025 RVA: 0x0044578E File Offset: 0x0044398E
		public ECondition Type { get; set; }

		// Token: 0x17008C82 RID: 35970
		// (get) Token: 0x0601E862 RID: 125026 RVA: 0x00445797 File Offset: 0x00443997
		// (set) Token: 0x0601E863 RID: 125027 RVA: 0x0044579F File Offset: 0x0044399F
		public ECompare Compare { get; set; }

		// Token: 0x17008C83 RID: 35971
		// (get) Token: 0x0601E864 RID: 125028 RVA: 0x004457A8 File Offset: 0x004439A8
		// (set) Token: 0x0601E865 RID: 125029 RVA: 0x004457B0 File Offset: 0x004439B0
		public int Level { get; set; }

		// Token: 0x0601E866 RID: 125030 RVA: 0x004457B9 File Offset: 0x004439B9
		public ICompareExploreLevelConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
