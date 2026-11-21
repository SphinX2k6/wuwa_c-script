using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200647A RID: 25722
	public class IPhotoTargetCaptureUiRequiredPointsCenterT
	{
		// Token: 0x1700BDCC RID: 48588
		// (get) Token: 0x0602BB56 RID: 179030 RVA: 0x005F2866 File Offset: 0x005F0A66
		// (set) Token: 0x0602BB57 RID: 179031 RVA: 0x005F286E File Offset: 0x005F0A6E
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x0602BB58 RID: 179032 RVA: 0x005F2877 File Offset: 0x005F0A77
		public IPhotoTargetCaptureUiRequiredPointsCenterT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
