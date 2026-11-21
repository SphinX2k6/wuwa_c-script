using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045CC RID: 17868
	public class ITakePhoto2KeepCameraOpenT
	{
		// Token: 0x17007CFC RID: 31996
		// (get) Token: 0x0601A18D RID: 106893 RVA: 0x003B8286 File Offset: 0x003B6486
		// (set) Token: 0x0601A18E RID: 106894 RVA: 0x003B828E File Offset: 0x003B648E
		public ETakePhoto2SuccessCameraBehavior Type { get; set; }

		// Token: 0x0601A18F RID: 106895 RVA: 0x003B8297 File Offset: 0x003B6497
		public ITakePhoto2KeepCameraOpenT()
		{
			this.Type = ETakePhoto2SuccessCameraBehavior.KeepOpen;
		}
	}
}
