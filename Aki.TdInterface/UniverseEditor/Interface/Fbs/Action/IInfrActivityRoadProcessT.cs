using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007005 RID: 28677
	public class IInfrActivityRoadProcessT
	{
		// Token: 0x1700D204 RID: 53764
		// (get) Token: 0x06031B0E RID: 203534 RVA: 0x006BACA4 File Offset: 0x006B8EA4
		// (set) Token: 0x06031B0F RID: 203535 RVA: 0x006BACAC File Offset: 0x006B8EAC
		public EInfrActivityBuildStageType Type { get; set; }

		// Token: 0x1700D205 RID: 53765
		// (get) Token: 0x06031B10 RID: 203536 RVA: 0x006BACB5 File Offset: 0x006B8EB5
		// (set) Token: 0x06031B11 RID: 203537 RVA: 0x006BACBD File Offset: 0x006B8EBD
		public int Id { get; set; }

		// Token: 0x06031B12 RID: 203538 RVA: 0x006BACC6 File Offset: 0x006B8EC6
		public IInfrActivityRoadProcessT()
		{
			this.Type = EInfrActivityBuildStageType.Infrastructure;
			this.Id = 0;
		}
	}
}
