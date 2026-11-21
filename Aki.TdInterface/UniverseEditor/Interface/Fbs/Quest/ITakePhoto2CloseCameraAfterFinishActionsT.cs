using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C3 RID: 17859
	public class ITakePhoto2CloseCameraAfterFinishActionsT
	{
		// Token: 0x17007CC8 RID: 31944
		// (get) Token: 0x0601A0EB RID: 106731 RVA: 0x003B676E File Offset: 0x003B496E
		// (set) Token: 0x0601A0EC RID: 106732 RVA: 0x003B6776 File Offset: 0x003B4976
		public ETakePhoto2SuccessCameraBehavior Type { get; set; }

		// Token: 0x0601A0ED RID: 106733 RVA: 0x003B677F File Offset: 0x003B497F
		public ITakePhoto2CloseCameraAfterFinishActionsT()
		{
			this.Type = ETakePhoto2SuccessCameraBehavior.KeepOpen;
		}
	}
}
