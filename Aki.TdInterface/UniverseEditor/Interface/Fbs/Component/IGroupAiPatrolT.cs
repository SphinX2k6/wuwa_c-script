using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005348 RID: 21320
	public class IGroupAiPatrolT
	{
		// Token: 0x17009CA3 RID: 40099
		// (get) Token: 0x06022DF4 RID: 142836 RVA: 0x004D4B98 File Offset: 0x004D2D98
		// (set) Token: 0x06022DF5 RID: 142837 RVA: 0x004D4BA0 File Offset: 0x004D2DA0
		public EGroupAiMode Type { get; set; }

		// Token: 0x17009CA4 RID: 40100
		// (get) Token: 0x06022DF6 RID: 142838 RVA: 0x004D4BA9 File Offset: 0x004D2DA9
		// (set) Token: 0x06022DF7 RID: 142839 RVA: 0x004D4BB1 File Offset: 0x004D2DB1
		public int Leader { get; set; }

		// Token: 0x17009CA5 RID: 40101
		// (get) Token: 0x06022DF8 RID: 142840 RVA: 0x004D4BBA File Offset: 0x004D2DBA
		// (set) Token: 0x06022DF9 RID: 142841 RVA: 0x004D4BC2 File Offset: 0x004D2DC2
		public int SplineEntityId { get; set; }

		// Token: 0x17009CA6 RID: 40102
		// (get) Token: 0x06022DFA RID: 142842 RVA: 0x004D4BCB File Offset: 0x004D2DCB
		// (set) Token: 0x06022DFB RID: 142843 RVA: 0x004D4BD3 File Offset: 0x004D2DD3
		public int PlayerPlaceholderEntityId { get; set; }

		// Token: 0x17009CA7 RID: 40103
		// (get) Token: 0x06022DFC RID: 142844 RVA: 0x004D4BDC File Offset: 0x004D2DDC
		// (set) Token: 0x06022DFD RID: 142845 RVA: 0x004D4BE4 File Offset: 0x004D2DE4
		public EGroupAiFormationBasis FormationBasis { get; set; }

		// Token: 0x17009CA8 RID: 40104
		// (get) Token: 0x06022DFE RID: 142846 RVA: 0x004D4BED File Offset: 0x004D2DED
		// (set) Token: 0x06022DFF RID: 142847 RVA: 0x004D4BF5 File Offset: 0x004D2DF5
		public bool IsPreciseFormation { get; set; }

		// Token: 0x17009CA9 RID: 40105
		// (get) Token: 0x06022E00 RID: 142848 RVA: 0x004D4BFE File Offset: 0x004D2DFE
		// (set) Token: 0x06022E01 RID: 142849 RVA: 0x004D4C06 File Offset: 0x004D2E06
		public IGroupAiEcologyGameplayAbpT EcologyGameplayAbp { get; set; }

		// Token: 0x17009CAA RID: 40106
		// (get) Token: 0x06022E02 RID: 142850 RVA: 0x004D4C0F File Offset: 0x004D2E0F
		// (set) Token: 0x06022E03 RID: 142851 RVA: 0x004D4C17 File Offset: 0x004D2E17
		public byte NullMask { get; set; }

		// Token: 0x06022E04 RID: 142852 RVA: 0x004D4C20 File Offset: 0x004D2E20
		public IGroupAiPatrolT()
		{
			this.Type = EGroupAiMode.Default;
			this.Leader = 0;
			this.SplineEntityId = 0;
			this.PlayerPlaceholderEntityId = 0;
			this.FormationBasis = EGroupAiFormationBasis.Spline;
			this.IsPreciseFormation = false;
			this.EcologyGameplayAbp = new IGroupAiEcologyGameplayAbpT();
			this.NullMask = 0;
		}
	}
}
