using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007473 RID: 29811
	public class ITriggerCameraShakeT
	{
		// Token: 0x1700E240 RID: 57920
		// (get) Token: 0x06036294 RID: 221844 RVA: 0x0075D14F File Offset: 0x0075B34F
		// (set) Token: 0x06036295 RID: 221845 RVA: 0x0075D157 File Offset: 0x0075B357
		public TCameraShakeConfigUnion CameraShakeConfig { get; set; }

		// Token: 0x1700E241 RID: 57921
		// (get) Token: 0x06036296 RID: 221846 RVA: 0x0075D160 File Offset: 0x0075B360
		// (set) Token: 0x06036297 RID: 221847 RVA: 0x0075D168 File Offset: 0x0075B368
		public string CameraShakeBp { get; set; }

		// Token: 0x06036298 RID: 221848 RVA: 0x0075D171 File Offset: 0x0075B371
		public ITriggerCameraShakeT()
		{
			this.CameraShakeConfig = null;
			this.CameraShakeBp = null;
		}
	}
}
