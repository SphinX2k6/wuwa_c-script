using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005170 RID: 20848
	public class IPhotographCameraCheckTemplateT
	{
		// Token: 0x1700955D RID: 38237
		// (get) Token: 0x06020CD7 RID: 134359 RVA: 0x0048A9E4 File Offset: 0x00488BE4
		// (set) Token: 0x06020CD8 RID: 134360 RVA: 0x0048A9EC File Offset: 0x00488BEC
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x1700955E RID: 38238
		// (get) Token: 0x06020CD9 RID: 134361 RVA: 0x0048A9F5 File Offset: 0x00488BF5
		// (set) Token: 0x06020CDA RID: 134362 RVA: 0x0048A9FD File Offset: 0x00488BFD
		public int TemplateId { get; set; }

		// Token: 0x06020CDB RID: 134363 RVA: 0x0048AA06 File Offset: 0x00488C06
		public IPhotographCameraCheckTemplateT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
			this.TemplateId = 0;
		}
	}
}
