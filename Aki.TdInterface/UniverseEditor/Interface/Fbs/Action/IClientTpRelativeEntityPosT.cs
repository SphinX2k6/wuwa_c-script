using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006401 RID: 25601
	public class IClientTpRelativeEntityPosT
	{
		// Token: 0x1700BEA3 RID: 48803
		// (get) Token: 0x0602C4AA RID: 181418 RVA: 0x00614382 File Offset: 0x00612582
		// (set) Token: 0x0602C4AB RID: 181419 RVA: 0x0061438A File Offset: 0x0061258A
		public EClientTeleportType Type { get; set; }

		// Token: 0x1700BEA4 RID: 48804
		// (get) Token: 0x0602C4AC RID: 181420 RVA: 0x00614393 File Offset: 0x00612593
		// (set) Token: 0x0602C4AD RID: 181421 RVA: 0x0061439B File Offset: 0x0061259B
		public int SourcePosEntityId { get; set; }

		// Token: 0x1700BEA5 RID: 48805
		// (get) Token: 0x0602C4AE RID: 181422 RVA: 0x006143A4 File Offset: 0x006125A4
		// (set) Token: 0x0602C4AF RID: 181423 RVA: 0x006143AC File Offset: 0x006125AC
		public int TargetPosEntityId { get; set; }

		// Token: 0x0602C4B0 RID: 181424 RVA: 0x006143B5 File Offset: 0x006125B5
		public IClientTpRelativeEntityPosT()
		{
			this.Type = EClientTeleportType.RelativeEntityPos;
			this.SourcePosEntityId = 0;
			this.TargetPosEntityId = 0;
		}
	}
}
