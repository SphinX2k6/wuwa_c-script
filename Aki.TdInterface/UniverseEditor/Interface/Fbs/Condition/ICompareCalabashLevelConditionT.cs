using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200506E RID: 20590
	public class ICompareCalabashLevelConditionT
	{
		// Token: 0x17009364 RID: 37732
		// (get) Token: 0x06020330 RID: 131888 RVA: 0x00476D0A File Offset: 0x00474F0A
		// (set) Token: 0x06020331 RID: 131889 RVA: 0x00476D12 File Offset: 0x00474F12
		public ECondition Type { get; set; }

		// Token: 0x17009365 RID: 37733
		// (get) Token: 0x06020332 RID: 131890 RVA: 0x00476D1B File Offset: 0x00474F1B
		// (set) Token: 0x06020333 RID: 131891 RVA: 0x00476D23 File Offset: 0x00474F23
		public ECompare Compare { get; set; }

		// Token: 0x17009366 RID: 37734
		// (get) Token: 0x06020334 RID: 131892 RVA: 0x00476D2C File Offset: 0x00474F2C
		// (set) Token: 0x06020335 RID: 131893 RVA: 0x00476D34 File Offset: 0x00474F34
		public int CalabashLevel { get; set; }

		// Token: 0x06020336 RID: 131894 RVA: 0x00476D3D File Offset: 0x00474F3D
		public ICompareCalabashLevelConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.CalabashLevel = 0;
		}
	}
}
