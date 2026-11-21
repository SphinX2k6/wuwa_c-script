using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B37 RID: 27447
	public class IControlElementalBoxCaptureT
	{
		// Token: 0x1700C998 RID: 51608
		// (get) Token: 0x0602F3BC RID: 193468 RVA: 0x006731BF File Offset: 0x006713BF
		// (set) Token: 0x0602F3BD RID: 193469 RVA: 0x006731C7 File Offset: 0x006713C7
		public EControlElementalBoxType Type { get; set; }

		// Token: 0x1700C999 RID: 51609
		// (get) Token: 0x0602F3BE RID: 193470 RVA: 0x006731D0 File Offset: 0x006713D0
		// (set) Token: 0x0602F3BF RID: 193471 RVA: 0x006731D8 File Offset: 0x006713D8
		public string CaptureCompleteSeq { get; set; }

		// Token: 0x0602F3C0 RID: 193472 RVA: 0x006731E1 File Offset: 0x006713E1
		public IControlElementalBoxCaptureT()
		{
			this.Type = EControlElementalBoxType.Capture;
			this.CaptureCompleteSeq = null;
		}
	}
}
