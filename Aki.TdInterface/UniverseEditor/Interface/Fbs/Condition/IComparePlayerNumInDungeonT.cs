using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050AD RID: 20653
	public class IComparePlayerNumInDungeonT
	{
		// Token: 0x170093F4 RID: 37876
		// (get) Token: 0x06020561 RID: 132449 RVA: 0x0047A8E5 File Offset: 0x00478AE5
		// (set) Token: 0x06020562 RID: 132450 RVA: 0x0047A8ED File Offset: 0x00478AED
		public ECondition Type { get; set; }

		// Token: 0x170093F5 RID: 37877
		// (get) Token: 0x06020563 RID: 132451 RVA: 0x0047A8F6 File Offset: 0x00478AF6
		// (set) Token: 0x06020564 RID: 132452 RVA: 0x0047A8FE File Offset: 0x00478AFE
		public ECompare CompareType { get; set; }

		// Token: 0x170093F6 RID: 37878
		// (get) Token: 0x06020565 RID: 132453 RVA: 0x0047A907 File Offset: 0x00478B07
		// (set) Token: 0x06020566 RID: 132454 RVA: 0x0047A90F File Offset: 0x00478B0F
		public TVarRefUnion CompareValue { get; set; }

		// Token: 0x06020567 RID: 132455 RVA: 0x0047A918 File Offset: 0x00478B18
		public IComparePlayerNumInDungeonT()
		{
			this.Type = ECondition.CompareVar;
			this.CompareType = ECompare.Eq;
			this.CompareValue = null;
		}
	}
}
