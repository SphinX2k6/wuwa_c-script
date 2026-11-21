using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A84 RID: 27268
	public class IClientTpToStreamingTargetPointT
	{
		// Token: 0x1700C846 RID: 51270
		// (get) Token: 0x0602ECAB RID: 191659 RVA: 0x00660B3C File Offset: 0x0065ED3C
		// (set) Token: 0x0602ECAC RID: 191660 RVA: 0x00660B44 File Offset: 0x0065ED44
		public EClientTeleportType Type { get; set; }

		// Token: 0x1700C847 RID: 51271
		// (get) Token: 0x0602ECAD RID: 191661 RVA: 0x00660B4D File Offset: 0x0065ED4D
		// (set) Token: 0x0602ECAE RID: 191662 RVA: 0x00660B55 File Offset: 0x0065ED55
		public IClientTpToStreamingTargetSuccessEffectT StreamingSuccessEffect { get; set; }

		// Token: 0x1700C848 RID: 51272
		// (get) Token: 0x0602ECAF RID: 191663 RVA: 0x00660B5E File Offset: 0x0065ED5E
		// (set) Token: 0x0602ECB0 RID: 191664 RVA: 0x00660B66 File Offset: 0x0065ED66
		public TTeleportTransitionOptionUnion StreamingTimeoutEffect { get; set; }

		// Token: 0x1700C849 RID: 51273
		// (get) Token: 0x0602ECB1 RID: 191665 RVA: 0x00660B6F File Offset: 0x0065ED6F
		// (set) Token: 0x0602ECB2 RID: 191666 RVA: 0x00660B77 File Offset: 0x0065ED77
		public IVectorInfoT LocationOffset { get; set; }

		// Token: 0x1700C84A RID: 51274
		// (get) Token: 0x0602ECB3 RID: 191667 RVA: 0x00660B80 File Offset: 0x0065ED80
		// (set) Token: 0x0602ECB4 RID: 191668 RVA: 0x00660B88 File Offset: 0x0065ED88
		public IVectorInfoT RotationOffset { get; set; }

		// Token: 0x0602ECB5 RID: 191669 RVA: 0x00660B91 File Offset: 0x0065ED91
		public IClientTpToStreamingTargetPointT()
		{
			this.Type = EClientTeleportType.RelativeEntityPos;
			this.StreamingSuccessEffect = null;
			this.StreamingTimeoutEffect = null;
			this.LocationOffset = null;
			this.RotationOffset = null;
		}
	}
}
