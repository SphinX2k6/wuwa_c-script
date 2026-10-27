using System;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005421 RID: 21537
	public class LogUploadOpenParam : ILogUploadOpenParam
	{
		// Token: 0x17008439 RID: 33849
		// (get) Token: 0x0603707B RID: 225403 RVA: 0x00D0A280 File Offset: 0x00D08480
		// (set) Token: 0x0603707C RID: 225404 RVA: 0x00D0A288 File Offset: 0x00D08488
		public EKuroSdkOpenCustomerServerType? OpenSourceType { get; set; }

		// Token: 0x1700843A RID: 33850
		// (get) Token: 0x0603707D RID: 225405 RVA: 0x00D0A291 File Offset: 0x00D08491
		// (set) Token: 0x0603707E RID: 225406 RVA: 0x00D0A299 File Offset: 0x00D08499
		public bool? AutoStartUpload { get; set; }

		// Token: 0x1700843B RID: 33851
		// (get) Token: 0x0603707F RID: 225407 RVA: 0x00D0A2A2 File Offset: 0x00D084A2
		// (set) Token: 0x06037080 RID: 225408 RVA: 0x00D0A2AA File Offset: 0x00D084AA
		public int? ErrorCode { get; set; }
	}
}
