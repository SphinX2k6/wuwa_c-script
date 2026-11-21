using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200646B RID: 25707
	public class IPhotoTargetCaptureUiBaseT
	{
		// Token: 0x1700BDBC RID: 48572
		// (get) Token: 0x0602BAF2 RID: 178930 RVA: 0x005F1E8A File Offset: 0x005F008A
		// (set) Token: 0x0602BAF3 RID: 178931 RVA: 0x005F1E92 File Offset: 0x005F0092
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x0602BAF4 RID: 178932 RVA: 0x005F1E9B File Offset: 0x005F009B
		public IPhotoTargetCaptureUiBaseT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
