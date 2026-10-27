using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C7A RID: 19578
	public class IPhotographCameraCheckTypeT
	{
		// Token: 0x17008E33 RID: 36403
		// (get) Token: 0x0601F0C9 RID: 127177 RVA: 0x00457032 File Offset: 0x00455232
		// (set) Token: 0x0601F0CA RID: 127178 RVA: 0x0045703A File Offset: 0x0045523A
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x0601F0CB RID: 127179 RVA: 0x00457043 File Offset: 0x00455243
		public IPhotographCameraCheckTypeT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
		}
	}
}
