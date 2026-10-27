using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8F RID: 28303
	public class IResetPlayerCameraFocusT
	{
		// Token: 0x1700D2C2 RID: 53954
		// (get) Token: 0x06032065 RID: 204901 RVA: 0x006C42E5 File Offset: 0x006C24E5
		// (set) Token: 0x06032066 RID: 204902 RVA: 0x006C42ED File Offset: 0x006C24ED
		public TResetPlayerFocusTypeUnion ResetType { get; set; }

		// Token: 0x1700D2C3 RID: 53955
		// (get) Token: 0x06032067 RID: 204903 RVA: 0x006C42F6 File Offset: 0x006C24F6
		// (set) Token: 0x06032068 RID: 204904 RVA: 0x006C42FE File Offset: 0x006C24FE
		public float FadeInTime { get; set; }

		// Token: 0x1700D2C4 RID: 53956
		// (get) Token: 0x06032069 RID: 204905 RVA: 0x006C4307 File Offset: 0x006C2507
		// (set) Token: 0x0603206A RID: 204906 RVA: 0x006C430F File Offset: 0x006C250F
		public bool CannotInterrupt { get; set; }

		// Token: 0x1700D2C5 RID: 53957
		// (get) Token: 0x0603206B RID: 204907 RVA: 0x006C4318 File Offset: 0x006C2518
		// (set) Token: 0x0603206C RID: 204908 RVA: 0x006C4320 File Offset: 0x006C2520
		public float Duration { get; set; }

		// Token: 0x1700D2C6 RID: 53958
		// (get) Token: 0x0603206D RID: 204909 RVA: 0x006C4329 File Offset: 0x006C2529
		// (set) Token: 0x0603206E RID: 204910 RVA: 0x006C4331 File Offset: 0x006C2531
		public byte NullMask { get; set; }

		// Token: 0x0603206F RID: 204911 RVA: 0x006C433A File Offset: 0x006C253A
		public IResetPlayerCameraFocusT()
		{
			this.ResetType = null;
			this.FadeInTime = 0f;
			this.CannotInterrupt = false;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
