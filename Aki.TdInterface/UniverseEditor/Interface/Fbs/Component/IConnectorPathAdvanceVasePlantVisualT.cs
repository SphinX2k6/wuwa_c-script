using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005013 RID: 20499
	public class IConnectorPathAdvanceVasePlantVisualT
	{
		// Token: 0x1700949D RID: 38045
		// (get) Token: 0x06020CD7 RID: 134359 RVA: 0x0048F911 File Offset: 0x0048DB11
		// (set) Token: 0x06020CD8 RID: 134360 RVA: 0x0048F919 File Offset: 0x0048DB19
		public EConnectorPathAdvanceVisualType Type { get; set; }

		// Token: 0x1700949E RID: 38046
		// (get) Token: 0x06020CD9 RID: 134361 RVA: 0x0048F922 File Offset: 0x0048DB22
		// (set) Token: 0x06020CDA RID: 134362 RVA: 0x0048F92A File Offset: 0x0048DB2A
		public float ScatterWidth { get; set; }

		// Token: 0x1700949F RID: 38047
		// (get) Token: 0x06020CDB RID: 134363 RVA: 0x0048F933 File Offset: 0x0048DB33
		// (set) Token: 0x06020CDC RID: 134364 RVA: 0x0048F93B File Offset: 0x0048DB3B
		public float ScatterDensity { get; set; }

		// Token: 0x170094A0 RID: 38048
		// (get) Token: 0x06020CDD RID: 134365 RVA: 0x0048F944 File Offset: 0x0048DB44
		// (set) Token: 0x06020CDE RID: 134366 RVA: 0x0048F94C File Offset: 0x0048DB4C
		public float Scale { get; set; }

		// Token: 0x170094A1 RID: 38049
		// (get) Token: 0x06020CDF RID: 134367 RVA: 0x0048F955 File Offset: 0x0048DB55
		// (set) Token: 0x06020CE0 RID: 134368 RVA: 0x0048F95D File Offset: 0x0048DB5D
		public bool SnapToSurface { get; set; }

		// Token: 0x170094A2 RID: 38050
		// (get) Token: 0x06020CE1 RID: 134369 RVA: 0x0048F966 File Offset: 0x0048DB66
		// (set) Token: 0x06020CE2 RID: 134370 RVA: 0x0048F96E File Offset: 0x0048DB6E
		public List<string> PathRtList { get; set; }

		// Token: 0x170094A3 RID: 38051
		// (get) Token: 0x06020CE3 RID: 134371 RVA: 0x0048F977 File Offset: 0x0048DB77
		// (set) Token: 0x06020CE4 RID: 134372 RVA: 0x0048F97F File Offset: 0x0048DB7F
		public byte NullMask { get; set; }

		// Token: 0x06020CE5 RID: 134373 RVA: 0x0048F988 File Offset: 0x0048DB88
		public IConnectorPathAdvanceVasePlantVisualT()
		{
			this.Type = EConnectorPathAdvanceVisualType.VasePlant;
			this.ScatterWidth = 0f;
			this.ScatterDensity = 0f;
			this.Scale = 0f;
			this.SnapToSurface = false;
			this.PathRtList = null;
			this.NullMask = 0;
		}
	}
}
