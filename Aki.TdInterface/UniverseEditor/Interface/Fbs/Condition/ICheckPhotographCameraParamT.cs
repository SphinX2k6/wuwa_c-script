using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD6 RID: 19158
	public class ICheckPhotographCameraParamT
	{
		// Token: 0x17008AE9 RID: 35561
		// (get) Token: 0x0601E180 RID: 123264 RVA: 0x00438D51 File Offset: 0x00436F51
		// (set) Token: 0x0601E181 RID: 123265 RVA: 0x00438D59 File Offset: 0x00436F59
		public ECondition Type { get; set; }

		// Token: 0x17008AEA RID: 35562
		// (get) Token: 0x0601E182 RID: 123266 RVA: 0x00438D62 File Offset: 0x00436F62
		// (set) Token: 0x0601E183 RID: 123267 RVA: 0x00438D6A File Offset: 0x00436F6A
		public ECommonMatchType CheckType { get; set; }

		// Token: 0x17008AEB RID: 35563
		// (get) Token: 0x0601E184 RID: 123268 RVA: 0x00438D73 File Offset: 0x00436F73
		// (set) Token: 0x0601E185 RID: 123269 RVA: 0x00438D7B File Offset: 0x00436F7B
		public List<TPhotographCameraCheckTypeUnion> CameraParam { get; set; }

		// Token: 0x0601E186 RID: 123270 RVA: 0x00438D84 File Offset: 0x00436F84
		public ICheckPhotographCameraParamT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = ECommonMatchType.MatchAll;
			this.CameraParam = null;
		}
	}
}
