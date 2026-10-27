using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B87 RID: 19335
	public class ICompareCalabashLevelConditionT
	{
		// Token: 0x17008C54 RID: 35924
		// (get) Token: 0x0601E7A2 RID: 124834 RVA: 0x004444BE File Offset: 0x004426BE
		// (set) Token: 0x0601E7A3 RID: 124835 RVA: 0x004444C6 File Offset: 0x004426C6
		public ECondition Type { get; set; }

		// Token: 0x17008C55 RID: 35925
		// (get) Token: 0x0601E7A4 RID: 124836 RVA: 0x004444CF File Offset: 0x004426CF
		// (set) Token: 0x0601E7A5 RID: 124837 RVA: 0x004444D7 File Offset: 0x004426D7
		public ECompare Compare { get; set; }

		// Token: 0x17008C56 RID: 35926
		// (get) Token: 0x0601E7A6 RID: 124838 RVA: 0x004444E0 File Offset: 0x004426E0
		// (set) Token: 0x0601E7A7 RID: 124839 RVA: 0x004444E8 File Offset: 0x004426E8
		public int CalabashLevel { get; set; }

		// Token: 0x0601E7A8 RID: 124840 RVA: 0x004444F1 File Offset: 0x004426F1
		public ICompareCalabashLevelConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.CalabashLevel = 0;
		}
	}
}
