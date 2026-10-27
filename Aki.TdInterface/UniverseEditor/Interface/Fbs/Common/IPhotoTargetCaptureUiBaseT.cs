using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E2E RID: 24110
	public class IPhotoTargetCaptureUiBaseT
	{
		// Token: 0x1700B456 RID: 46166
		// (get) Token: 0x06029468 RID: 169064 RVA: 0x005A915A File Offset: 0x005A735A
		// (set) Token: 0x06029469 RID: 169065 RVA: 0x005A9162 File Offset: 0x005A7362
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x0602946A RID: 169066 RVA: 0x005A916B File Offset: 0x005A736B
		public IPhotoTargetCaptureUiBaseT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
