using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B75 RID: 27509
	public class IMovingCameraTimeParamsT
	{
		// Token: 0x1700CC7C RID: 52348
		// (get) Token: 0x060304F2 RID: 197874 RVA: 0x006906BC File Offset: 0x0068E8BC
		// (set) Token: 0x060304F3 RID: 197875 RVA: 0x006906C4 File Offset: 0x0068E8C4
		public float FadeInTime { get; set; }

		// Token: 0x1700CC7D RID: 52349
		// (get) Token: 0x060304F4 RID: 197876 RVA: 0x006906CD File Offset: 0x0068E8CD
		// (set) Token: 0x060304F5 RID: 197877 RVA: 0x006906D5 File Offset: 0x0068E8D5
		public float AfterFadeInStayTime { get; set; }

		// Token: 0x1700CC7E RID: 52350
		// (get) Token: 0x060304F6 RID: 197878 RVA: 0x006906DE File Offset: 0x0068E8DE
		// (set) Token: 0x060304F7 RID: 197879 RVA: 0x006906E6 File Offset: 0x0068E8E6
		public float FadeOutTime { get; set; }

		// Token: 0x1700CC7F RID: 52351
		// (get) Token: 0x060304F8 RID: 197880 RVA: 0x006906EF File Offset: 0x0068E8EF
		// (set) Token: 0x060304F9 RID: 197881 RVA: 0x006906F7 File Offset: 0x0068E8F7
		public float BeforeFadeOutStayTime { get; set; }

		// Token: 0x060304FA RID: 197882 RVA: 0x00690700 File Offset: 0x0068E900
		public IMovingCameraTimeParamsT()
		{
			this.FadeInTime = 0f;
			this.AfterFadeInStayTime = 0f;
			this.FadeOutTime = 0f;
			this.BeforeFadeOutStayTime = 0f;
		}
	}
}
