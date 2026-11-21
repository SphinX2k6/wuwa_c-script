using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045DE RID: 17886
	public class ITakePhoto2SuccessCameraBehaviorBaseT
	{
		// Token: 0x17007D17 RID: 32023
		// (get) Token: 0x0601A209 RID: 107017 RVA: 0x003B8ED2 File Offset: 0x003B70D2
		// (set) Token: 0x0601A20A RID: 107018 RVA: 0x003B8EDA File Offset: 0x003B70DA
		public ETakePhoto2SuccessCameraBehavior Type { get; set; }

		// Token: 0x0601A20B RID: 107019 RVA: 0x003B8EE3 File Offset: 0x003B70E3
		public ITakePhoto2SuccessCameraBehaviorBaseT()
		{
			this.Type = ETakePhoto2SuccessCameraBehavior.KeepOpen;
		}
	}
}
