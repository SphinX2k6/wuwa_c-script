using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BB RID: 29371
	public class IMovingCameraTimeParamsT
	{
		// Token: 0x1700D761 RID: 55137
		// (get) Token: 0x0603334A RID: 209738 RVA: 0x006E8CDC File Offset: 0x006E6EDC
		// (set) Token: 0x0603334B RID: 209739 RVA: 0x006E8CE4 File Offset: 0x006E6EE4
		public float FadeInTime { get; set; }

		// Token: 0x1700D762 RID: 55138
		// (get) Token: 0x0603334C RID: 209740 RVA: 0x006E8CED File Offset: 0x006E6EED
		// (set) Token: 0x0603334D RID: 209741 RVA: 0x006E8CF5 File Offset: 0x006E6EF5
		public float AfterFadeInStayTime { get; set; }

		// Token: 0x1700D763 RID: 55139
		// (get) Token: 0x0603334E RID: 209742 RVA: 0x006E8CFE File Offset: 0x006E6EFE
		// (set) Token: 0x0603334F RID: 209743 RVA: 0x006E8D06 File Offset: 0x006E6F06
		public float FadeOutTime { get; set; }

		// Token: 0x1700D764 RID: 55140
		// (get) Token: 0x06033350 RID: 209744 RVA: 0x006E8D0F File Offset: 0x006E6F0F
		// (set) Token: 0x06033351 RID: 209745 RVA: 0x006E8D17 File Offset: 0x006E6F17
		public float BeforeFadeOutStayTime { get; set; }

		// Token: 0x06033352 RID: 209746 RVA: 0x006E8D20 File Offset: 0x006E6F20
		public IMovingCameraTimeParamsT()
		{
			this.FadeInTime = 0f;
			this.AfterFadeInStayTime = 0f;
			this.FadeOutTime = 0f;
			this.BeforeFadeOutStayTime = 0f;
		}
	}
}
