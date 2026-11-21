using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C66 RID: 31846
	public class ITriggerCameraShakeT
	{
		// Token: 0x1700EE5D RID: 61021
		// (get) Token: 0x0603967D RID: 235133 RVA: 0x007BFE7B File Offset: 0x007BE07B
		// (set) Token: 0x0603967E RID: 235134 RVA: 0x007BFE83 File Offset: 0x007BE083
		public TCameraShakeConfigUnion CameraShakeConfig { get; set; }

		// Token: 0x1700EE5E RID: 61022
		// (get) Token: 0x0603967F RID: 235135 RVA: 0x007BFE8C File Offset: 0x007BE08C
		// (set) Token: 0x06039680 RID: 235136 RVA: 0x007BFE94 File Offset: 0x007BE094
		public string CameraShakeBp { get; set; }

		// Token: 0x06039681 RID: 235137 RVA: 0x007BFE9D File Offset: 0x007BE09D
		public ITriggerCameraShakeT()
		{
			this.CameraShakeConfig = null;
			this.CameraShakeBp = null;
		}
	}
}
