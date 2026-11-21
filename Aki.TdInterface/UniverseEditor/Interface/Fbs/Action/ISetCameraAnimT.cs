using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779B RID: 30619
	public class ISetCameraAnimT
	{
		// Token: 0x1700E059 RID: 57433
		// (get) Token: 0x06035BF9 RID: 220153 RVA: 0x007338C3 File Offset: 0x00731AC3
		// (set) Token: 0x06035BFA RID: 220154 RVA: 0x007338CB File Offset: 0x00731ACB
		public string CameraAnimDataAsset { get; set; }

		// Token: 0x1700E05A RID: 57434
		// (get) Token: 0x06035BFB RID: 220155 RVA: 0x007338D4 File Offset: 0x00731AD4
		// (set) Token: 0x06035BFC RID: 220156 RVA: 0x007338DC File Offset: 0x00731ADC
		public float Speed { get; set; }

		// Token: 0x1700E05B RID: 57435
		// (get) Token: 0x06035BFD RID: 220157 RVA: 0x007338E5 File Offset: 0x00731AE5
		// (set) Token: 0x06035BFE RID: 220158 RVA: 0x007338ED File Offset: 0x00731AED
		public bool UseNoise { get; set; }

		// Token: 0x1700E05C RID: 57436
		// (get) Token: 0x06035BFF RID: 220159 RVA: 0x007338F6 File Offset: 0x00731AF6
		// (set) Token: 0x06035C00 RID: 220160 RVA: 0x007338FE File Offset: 0x00731AFE
		public byte NullMask { get; set; }

		// Token: 0x06035C01 RID: 220161 RVA: 0x00733907 File Offset: 0x00731B07
		public ISetCameraAnimT()
		{
			this.CameraAnimDataAsset = null;
			this.Speed = 0f;
			this.UseNoise = false;
			this.NullMask = 0;
		}
	}
}
