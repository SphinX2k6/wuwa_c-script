using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5D RID: 23133
	public class ILevelAISplineT
	{
		// Token: 0x1700A846 RID: 43078
		// (get) Token: 0x06025D7E RID: 155006 RVA: 0x0052FE82 File Offset: 0x0052E082
		// (set) Token: 0x06025D7F RID: 155007 RVA: 0x0052FE8A File Offset: 0x0052E08A
		public ESplineType Type { get; set; }

		// Token: 0x1700A847 RID: 43079
		// (get) Token: 0x06025D80 RID: 155008 RVA: 0x0052FE93 File Offset: 0x0052E093
		// (set) Token: 0x06025D81 RID: 155009 RVA: 0x0052FE9B File Offset: 0x0052E09B
		public int EntityId { get; set; }

		// Token: 0x1700A848 RID: 43080
		// (get) Token: 0x06025D82 RID: 155010 RVA: 0x0052FEA4 File Offset: 0x0052E0A4
		// (set) Token: 0x06025D83 RID: 155011 RVA: 0x0052FEAC File Offset: 0x0052E0AC
		public ILevelAiCycleLooplyT CycleOption { get; set; }

		// Token: 0x1700A849 RID: 43081
		// (get) Token: 0x06025D84 RID: 155012 RVA: 0x0052FEB5 File Offset: 0x0052E0B5
		// (set) Token: 0x06025D85 RID: 155013 RVA: 0x0052FEBD File Offset: 0x0052E0BD
		public bool UsePathFinding { get; set; }

		// Token: 0x1700A84A RID: 43082
		// (get) Token: 0x06025D86 RID: 155014 RVA: 0x0052FEC6 File Offset: 0x0052E0C6
		// (set) Token: 0x06025D87 RID: 155015 RVA: 0x0052FECE File Offset: 0x0052E0CE
		public bool IsPassEveryKeyPoint { get; set; }

		// Token: 0x1700A84B RID: 43083
		// (get) Token: 0x06025D88 RID: 155016 RVA: 0x0052FED7 File Offset: 0x0052E0D7
		// (set) Token: 0x06025D89 RID: 155017 RVA: 0x0052FEDF File Offset: 0x0052E0DF
		public List<ILevelAISplinePointT> Points { get; set; }

		// Token: 0x1700A84C RID: 43084
		// (get) Token: 0x06025D8A RID: 155018 RVA: 0x0052FEE8 File Offset: 0x0052E0E8
		// (set) Token: 0x06025D8B RID: 155019 RVA: 0x0052FEF0 File Offset: 0x0052E0F0
		public byte NullMask { get; set; }

		// Token: 0x06025D8C RID: 155020 RVA: 0x0052FEF9 File Offset: 0x0052E0F9
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
