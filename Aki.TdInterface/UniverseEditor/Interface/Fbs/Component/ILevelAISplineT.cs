using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D7 RID: 21719
	public class ILevelAISplineT
	{
		// Token: 0x1700A00C RID: 40972
		// (get) Token: 0x06023CC6 RID: 146630 RVA: 0x004F2E0E File Offset: 0x004F100E
		// (set) Token: 0x06023CC7 RID: 146631 RVA: 0x004F2E16 File Offset: 0x004F1016
		public ESplineType Type { get; set; }

		// Token: 0x1700A00D RID: 40973
		// (get) Token: 0x06023CC8 RID: 146632 RVA: 0x004F2E1F File Offset: 0x004F101F
		// (set) Token: 0x06023CC9 RID: 146633 RVA: 0x004F2E27 File Offset: 0x004F1027
		public int EntityId { get; set; }

		// Token: 0x1700A00E RID: 40974
		// (get) Token: 0x06023CCA RID: 146634 RVA: 0x004F2E30 File Offset: 0x004F1030
		// (set) Token: 0x06023CCB RID: 146635 RVA: 0x004F2E38 File Offset: 0x004F1038
		public ILevelAiCycleLooplyT CycleOption { get; set; }

		// Token: 0x1700A00F RID: 40975
		// (get) Token: 0x06023CCC RID: 146636 RVA: 0x004F2E41 File Offset: 0x004F1041
		// (set) Token: 0x06023CCD RID: 146637 RVA: 0x004F2E49 File Offset: 0x004F1049
		public bool UsePathFinding { get; set; }

		// Token: 0x1700A010 RID: 40976
		// (get) Token: 0x06023CCE RID: 146638 RVA: 0x004F2E52 File Offset: 0x004F1052
		// (set) Token: 0x06023CCF RID: 146639 RVA: 0x004F2E5A File Offset: 0x004F105A
		public bool IsPassEveryKeyPoint { get; set; }

		// Token: 0x1700A011 RID: 40977
		// (get) Token: 0x06023CD0 RID: 146640 RVA: 0x004F2E63 File Offset: 0x004F1063
		// (set) Token: 0x06023CD1 RID: 146641 RVA: 0x004F2E6B File Offset: 0x004F106B
		public List<ILevelAISplinePointT> Points { get; set; }

		// Token: 0x1700A012 RID: 40978
		// (get) Token: 0x06023CD2 RID: 146642 RVA: 0x004F2E74 File Offset: 0x004F1074
		// (set) Token: 0x06023CD3 RID: 146643 RVA: 0x004F2E7C File Offset: 0x004F107C
		public byte NullMask { get; set; }

		// Token: 0x06023CD4 RID: 146644 RVA: 0x004F2E85 File Offset: 0x004F1085
		public ILevelAISplineT()
		{
			this.Type = ESplineType.Common;
			this.EntityId = 0;
			this.CycleOption = null;
			this.UsePathFinding = false;
			this.IsPassEveryKeyPoint = false;
			this.Points = null;
			this.NullMask = 0;
		}
	}
}
