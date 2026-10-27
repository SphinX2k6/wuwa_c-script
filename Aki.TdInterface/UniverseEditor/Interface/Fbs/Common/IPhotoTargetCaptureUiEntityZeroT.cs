using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E3A RID: 24122
	public class IPhotoTargetCaptureUiEntityZeroT
	{
		// Token: 0x1700B463 RID: 46179
		// (get) Token: 0x060294BA RID: 169146 RVA: 0x005A99BE File Offset: 0x005A7BBE
		// (set) Token: 0x060294BB RID: 169147 RVA: 0x005A99C6 File Offset: 0x005A7BC6
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x060294BC RID: 169148 RVA: 0x005A99CF File Offset: 0x005A7BCF
		public IPhotoTargetCaptureUiEntityZeroT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
