using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E3D RID: 24125
	public class IPhotoTargetCaptureUiRequiredPointsCenterT
	{
		// Token: 0x1700B466 RID: 46182
		// (get) Token: 0x060294CC RID: 169164 RVA: 0x005A9B36 File Offset: 0x005A7D36
		// (set) Token: 0x060294CD RID: 169165 RVA: 0x005A9B3E File Offset: 0x005A7D3E
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x060294CE RID: 169166 RVA: 0x005A9B47 File Offset: 0x005A7D47
		public IPhotoTargetCaptureUiRequiredPointsCenterT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
