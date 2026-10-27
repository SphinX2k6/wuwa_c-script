using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1B RID: 23323
	public class IVehicleGenerationConfigT
	{
		// Token: 0x1700B00C RID: 45068
		// (get) Token: 0x06027DBE RID: 163262 RVA: 0x0057B81F File Offset: 0x00579A1F
		// (set) Token: 0x06027DBF RID: 163263 RVA: 0x0057B827 File Offset: 0x00579A27
		public float Range { get; set; }

		// Token: 0x1700B00D RID: 45069
		// (get) Token: 0x06027DC0 RID: 163264 RVA: 0x0057B830 File Offset: 0x00579A30
		// (set) Token: 0x06027DC1 RID: 163265 RVA: 0x0057B838 File Offset: 0x00579A38
		public List<ISplineWayPointT> Destinations { get; set; }

		// Token: 0x1700B00E RID: 45070
		// (get) Token: 0x06027DC2 RID: 163266 RVA: 0x0057B841 File Offset: 0x00579A41
		// (set) Token: 0x06027DC3 RID: 163267 RVA: 0x0057B849 File Offset: 0x00579A49
		public List<TVehicleGenerationTypeUnion> VehicleConfig { get; set; }

		// Token: 0x1700B00F RID: 45071
		// (get) Token: 0x06027DC4 RID: 163268 RVA: 0x0057B852 File Offset: 0x00579A52
		// (set) Token: 0x06027DC5 RID: 163269 RVA: 0x0057B85A File Offset: 0x00579A5A
		public float Cd { get; set; }

		// Token: 0x1700B010 RID: 45072
		// (get) Token: 0x06027DC6 RID: 163270 RVA: 0x0057B863 File Offset: 0x00579A63
		// (set) Token: 0x06027DC7 RID: 163271 RVA: 0x0057B86B File Offset: 0x00579A6B
		public IVectorInfoT Offset { get; set; }

		// Token: 0x06027DC8 RID: 163272 RVA: 0x0057B874 File Offset: 0x00579A74
		public IVehicleGenerationConfigT()
		{
			this.Range = 0f;
			this.Destinations = null;
			this.VehicleConfig = null;
			this.Cd = 0f;
			this.Offset = null;
		}
	}
}
