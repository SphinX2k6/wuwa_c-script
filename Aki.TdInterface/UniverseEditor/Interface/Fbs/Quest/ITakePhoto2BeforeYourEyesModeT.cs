using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045BD RID: 17853
	public class ITakePhoto2BeforeYourEyesModeT
	{
		// Token: 0x17007CBF RID: 31935
		// (get) Token: 0x0601A0C1 RID: 106689 RVA: 0x003B639F File Offset: 0x003B459F
		// (set) Token: 0x0601A0C2 RID: 106690 RVA: 0x003B63A7 File Offset: 0x003B45A7
		public ETakePhoto2Mode Type { get; set; }

		// Token: 0x17007CC0 RID: 31936
		// (get) Token: 0x0601A0C3 RID: 106691 RVA: 0x003B63B0 File Offset: 0x003B45B0
		// (set) Token: 0x0601A0C4 RID: 106692 RVA: 0x003B63B8 File Offset: 0x003B45B8
		public TTakePhoto2SuccessCameraBehaviorUnion SuccessCameraBehavior { get; set; }

		// Token: 0x0601A0C5 RID: 106693 RVA: 0x003B63C1 File Offset: 0x003B45C1
		public ITakePhoto2BeforeYourEyesModeT()
		{
			this.Type = ETakePhoto2Mode.BeforeYourEyes;
			this.SuccessCameraBehavior = null;
		}
	}
}
