using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007002 RID: 28674
	public class IInfrActivityInfrastructureStageT
	{
		// Token: 0x1700D1FF RID: 53759
		// (get) Token: 0x06031AF8 RID: 203512 RVA: 0x006BAAA4 File Offset: 0x006B8CA4
		// (set) Token: 0x06031AF9 RID: 203513 RVA: 0x006BAAAC File Offset: 0x006B8CAC
		public EInfrActivityBuildStageType Type { get; set; }

		// Token: 0x1700D200 RID: 53760
		// (get) Token: 0x06031AFA RID: 203514 RVA: 0x006BAAB5 File Offset: 0x006B8CB5
		// (set) Token: 0x06031AFB RID: 203515 RVA: 0x006BAABD File Offset: 0x006B8CBD
		public int Stage { get; set; }

		// Token: 0x06031AFC RID: 203516 RVA: 0x006BAAC6 File Offset: 0x006B8CC6
		public IInfrActivityInfrastructureStageT()
		{
			this.Type = EInfrActivityBuildStageType.Infrastructure;
			this.Stage = 0;
		}
	}
}
