using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006477 RID: 25719
	public class IPhotoTargetCaptureUiEntityZeroT
	{
		// Token: 0x1700BDC9 RID: 48585
		// (get) Token: 0x0602BB44 RID: 179012 RVA: 0x005F26EE File Offset: 0x005F08EE
		// (set) Token: 0x0602BB45 RID: 179013 RVA: 0x005F26F6 File Offset: 0x005F08F6
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x0602BB46 RID: 179014 RVA: 0x005F26FF File Offset: 0x005F08FF
		public IPhotoTargetCaptureUiEntityZeroT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
		}
	}
}
