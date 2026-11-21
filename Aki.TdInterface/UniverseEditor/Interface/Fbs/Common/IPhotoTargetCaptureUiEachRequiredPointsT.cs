using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006474 RID: 25716
	public class IPhotoTargetCaptureUiEachRequiredPointsT
	{
		// Token: 0x1700BDC6 RID: 48582
		// (get) Token: 0x0602BB32 RID: 178994 RVA: 0x005F2576 File Offset: 0x005F0776
		// (set) Token: 0x0602BB33 RID: 178995 RVA: 0x005F257E File Offset: 0x005F077E
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x0602BB34 RID: 178996 RVA: 0x005F2587 File Offset: 0x005F0787
		public IPhotoTargetCaptureUiEachRequiredPointsT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
