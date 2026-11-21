using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005173 RID: 20851
	public class IPhotographCameraCheckTypeT
	{
		// Token: 0x17009561 RID: 38241
		// (get) Token: 0x06020CEB RID: 134379 RVA: 0x0048AB82 File Offset: 0x00488D82
		// (set) Token: 0x06020CEC RID: 134380 RVA: 0x0048AB8A File Offset: 0x00488D8A
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x06020CED RID: 134381 RVA: 0x0048AB93 File Offset: 0x00488D93
		public IPhotographCameraCheckTypeT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
		}
	}
}
