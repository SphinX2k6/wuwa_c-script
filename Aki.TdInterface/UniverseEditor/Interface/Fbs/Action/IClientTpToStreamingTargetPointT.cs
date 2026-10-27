using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006404 RID: 25604
	public class IClientTpToStreamingTargetPointT
	{
		// Token: 0x1700BEAC RID: 48812
		// (get) Token: 0x0602C4D5 RID: 181461 RVA: 0x00614CB0 File Offset: 0x00612EB0
		// (set) Token: 0x0602C4D6 RID: 181462 RVA: 0x00614CB8 File Offset: 0x00612EB8
		public EClientTeleportType Type { get; set; }

		// Token: 0x1700BEAD RID: 48813
		// (get) Token: 0x0602C4D7 RID: 181463 RVA: 0x00614CC1 File Offset: 0x00612EC1
		// (set) Token: 0x0602C4D8 RID: 181464 RVA: 0x00614CC9 File Offset: 0x00612EC9
		public IClientTpToStreamingTargetSuccessEffectT StreamingSuccessEffect { get; set; }

		// Token: 0x1700BEAE RID: 48814
		// (get) Token: 0x0602C4D9 RID: 181465 RVA: 0x00614CD2 File Offset: 0x00612ED2
		// (set) Token: 0x0602C4DA RID: 181466 RVA: 0x00614CDA File Offset: 0x00612EDA
		public TTeleportTransitionOptionUnion StreamingTimeoutEffect { get; set; }

		// Token: 0x1700BEAF RID: 48815
		// (get) Token: 0x0602C4DB RID: 181467 RVA: 0x00614CE3 File Offset: 0x00612EE3
		// (set) Token: 0x0602C4DC RID: 181468 RVA: 0x00614CEB File Offset: 0x00612EEB
		public IVectorInfoT LocationOffset { get; set; }

		// Token: 0x1700BEB0 RID: 48816
		// (get) Token: 0x0602C4DD RID: 181469 RVA: 0x00614CF4 File Offset: 0x00612EF4
		// (set) Token: 0x0602C4DE RID: 181470 RVA: 0x00614CFC File Offset: 0x00612EFC
		public IVectorInfoT RotationOffset { get; set; }

		// Token: 0x0602C4DF RID: 181471 RVA: 0x00614D05 File Offset: 0x00612F05
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
