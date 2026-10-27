using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064CC RID: 25804
	public class IControlElementalBoxCaptureT
	{
		// Token: 0x1700C00B RID: 49163
		// (get) Token: 0x0602CC38 RID: 183352 RVA: 0x00627097 File Offset: 0x00625297
		// (set) Token: 0x0602CC39 RID: 183353 RVA: 0x0062709F File Offset: 0x0062529F
		public EControlElementalBoxType Type { get; set; }

		// Token: 0x1700C00C RID: 49164
		// (get) Token: 0x0602CC3A RID: 183354 RVA: 0x006270A8 File Offset: 0x006252A8
		// (set) Token: 0x0602CC3B RID: 183355 RVA: 0x006270B0 File Offset: 0x006252B0
		public string CaptureCompleteSeq { get; set; }

		// Token: 0x0602CC3C RID: 183356 RVA: 0x006270B9 File Offset: 0x006252B9
		public IControlElementalBoxCaptureT()
		{
			this.Type = EControlElementalBoxType.Capture;
			this.CaptureCompleteSeq = null;
		}
	}
}
