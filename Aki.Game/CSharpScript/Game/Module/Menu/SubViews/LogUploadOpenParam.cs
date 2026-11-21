using System;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004404 RID: 17412
	public class LogUploadOpenParam : ILogUploadOpenParam
	{
		// Token: 0x17005805 RID: 22533
		// (get) Token: 0x0602BFC4 RID: 180164 RVA: 0x00C596A0 File Offset: 0x00C578A0
		// (set) Token: 0x0602BFC5 RID: 180165 RVA: 0x00C596A8 File Offset: 0x00C578A8
		public EKuroSdkOpenCustomerServerType? OpenSourceType { get; set; }

		// Token: 0x17005806 RID: 22534
		// (get) Token: 0x0602BFC6 RID: 180166 RVA: 0x00C596B1 File Offset: 0x00C578B1
		// (set) Token: 0x0602BFC7 RID: 180167 RVA: 0x00C596B9 File Offset: 0x00C578B9
		public bool? AutoStartUpload { get; set; }

		// Token: 0x17005807 RID: 22535
		// (get) Token: 0x0602BFC8 RID: 180168 RVA: 0x00C596C2 File Offset: 0x00C578C2
		// (set) Token: 0x0602BFC9 RID: 180169 RVA: 0x00C596CA File Offset: 0x00C578CA
		public int? ErrorCode { get; set; }
	}
}
