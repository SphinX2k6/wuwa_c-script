using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E34 RID: 24116
	public class IPhotoTargetCaptureUiCustomPointsT
	{
		// Token: 0x1700B45C RID: 46172
		// (get) Token: 0x06029494 RID: 169108 RVA: 0x005A9687 File Offset: 0x005A7887
		// (set) Token: 0x06029495 RID: 169109 RVA: 0x005A968F File Offset: 0x005A788F
		public EPhotoTargetCaptureUiType Type { get; set; }

		// Token: 0x1700B45D RID: 46173
		// (get) Token: 0x06029496 RID: 169110 RVA: 0x005A9698 File Offset: 0x005A7898
		// (set) Token: 0x06029497 RID: 169111 RVA: 0x005A96A0 File Offset: 0x005A78A0
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x06029498 RID: 169112 RVA: 0x005A96A9 File Offset: 0x005A78A9
		public IPhotoTargetCaptureUiCustomPointsT()
		{
			this.Type = EPhotoTargetCaptureUiType.RequiredPointsCenter;
			this.Points = null;
		}
	}
}
