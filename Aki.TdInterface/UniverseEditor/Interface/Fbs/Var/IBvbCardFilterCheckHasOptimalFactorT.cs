using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E0C RID: 15884
	public class IBvbCardFilterCheckHasOptimalFactorT
	{
		// Token: 0x17006B46 RID: 27462
		// (get) Token: 0x0601559E RID: 87454 RVA: 0x00315BD7 File Offset: 0x00313DD7
		// (set) Token: 0x0601559F RID: 87455 RVA: 0x00315BDF File Offset: 0x00313DDF
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006B47 RID: 27463
		// (get) Token: 0x060155A0 RID: 87456 RVA: 0x00315BE8 File Offset: 0x00313DE8
		// (set) Token: 0x060155A1 RID: 87457 RVA: 0x00315BF0 File Offset: 0x00313DF0
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x060155A2 RID: 87458 RVA: 0x00315BF9 File Offset: 0x00313DF9
		public IBvbCardFilterCheckHasOptimalFactorT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.HandCard = null;
		}
	}
}
