using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E37 RID: 24119
	public class IPhotoTargetCaptureUiEachRequiredPointsT
	{
		// Token: 0x1700B460 RID: 46176
		// (get) Token: 0x060294A8 RID: 169128 RVA: 0x005A9846 File Offset: 0x005A7A46
		// (set) Token: 0x060294A9 RID: 169129 RVA: 0x005A984E File Offset: 0x005A7A4E
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x060294AA RID: 169130 RVA: 0x005A9857 File Offset: 0x005A7A57
		public IPhotoTargetCaptureUiEachRequiredPointsT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
