using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006471 RID: 25713
	public class IPhotoTargetCaptureUiCustomPointsT
	{
		// Token: 0x1700BDC2 RID: 48578
		// (get) Token: 0x0602BB1E RID: 178974 RVA: 0x005F23B7 File Offset: 0x005F05B7
		// (set) Token: 0x0602BB1F RID: 178975 RVA: 0x005F23BF File Offset: 0x005F05BF
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x1700BDC3 RID: 48579
		// (get) Token: 0x0602BB20 RID: 178976 RVA: 0x005F23C8 File Offset: 0x005F05C8
		// (set) Token: 0x0602BB21 RID: 178977 RVA: 0x005F23D0 File Offset: 0x005F05D0
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x0602BB22 RID: 178978 RVA: 0x005F23D9 File Offset: 0x005F05D9
		public IPhotoTargetCaptureUiCustomPointsT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
			this.Points = null;
		}
	}
}
