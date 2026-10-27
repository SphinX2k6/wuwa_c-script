using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B83 RID: 27523
	public class IMp4GamepadShakeFadeInConfigT
	{
		// Token: 0x1700CC9A RID: 52378
		// (get) Token: 0x06030567 RID: 197991 RVA: 0x0069141E File Offset: 0x0068F61E
		// (set) Token: 0x06030568 RID: 197992 RVA: 0x00691426 File Offset: 0x0068F626
		public float FadeInTime { get; set; }

		// Token: 0x1700CC9B RID: 52379
		// (get) Token: 0x06030569 RID: 197993 RVA: 0x0069142F File Offset: 0x0068F62F
		// (set) Token: 0x0603056A RID: 197994 RVA: 0x00691437 File Offset: 0x0068F637
		public EMp4GamepadShakeCurve FadeInCurve { get; set; }

		// Token: 0x1700CC9C RID: 52380
		// (get) Token: 0x0603056B RID: 197995 RVA: 0x00691440 File Offset: 0x0068F640
		// (set) Token: 0x0603056C RID: 197996 RVA: 0x00691448 File Offset: 0x0068F648
		public byte NullMask { get; set; }

		// Token: 0x0603056D RID: 197997 RVA: 0x00691451 File Offset: 0x0068F651
		public IMp4GamepadShakeFadeInConfigT()
		{
			this.FadeInTime = 0f;
			this.FadeInCurve = EMp4GamepadShakeCurve.Linear;
			this.NullMask = 0;
		}
	}
}
