using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC3 RID: 19395
	public class IComparePlayerNumInDungeonT
	{
		// Token: 0x17008CDB RID: 36059
		// (get) Token: 0x0601E9B5 RID: 125365 RVA: 0x00447D81 File Offset: 0x00445F81
		// (set) Token: 0x0601E9B6 RID: 125366 RVA: 0x00447D89 File Offset: 0x00445F89
		public ECondition Type { get; set; }

		// Token: 0x17008CDC RID: 36060
		// (get) Token: 0x0601E9B7 RID: 125367 RVA: 0x00447D92 File Offset: 0x00445F92
		// (set) Token: 0x0601E9B8 RID: 125368 RVA: 0x00447D9A File Offset: 0x00445F9A
		public ECompare CompareType { get; set; }

		// Token: 0x17008CDD RID: 36061
		// (get) Token: 0x0601E9B9 RID: 125369 RVA: 0x00447DA3 File Offset: 0x00445FA3
		// (set) Token: 0x0601E9BA RID: 125370 RVA: 0x00447DAB File Offset: 0x00445FAB
		public TVarRefUnion CompareValue { get; set; }

		// Token: 0x0601E9BB RID: 125371 RVA: 0x00447DB4 File Offset: 0x00445FB4
		public IComparePlayerNumInDungeonT()
		{
			this.Type = ECondition.CompareVar;
			this.CompareType = ECompare.Eq;
			this.CompareValue = null;
		}
	}
}
