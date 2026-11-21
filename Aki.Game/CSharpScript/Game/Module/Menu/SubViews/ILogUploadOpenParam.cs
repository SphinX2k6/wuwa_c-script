using System;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004403 RID: 17411
	public interface ILogUploadOpenParam
	{
		// Token: 0x17005802 RID: 22530
		// (get) Token: 0x0602BFBE RID: 180158
		// (set) Token: 0x0602BFBF RID: 180159
		EKuroSdkOpenCustomerServerType? OpenSourceType { get; set; }

		// Token: 0x17005803 RID: 22531
		// (get) Token: 0x0602BFC0 RID: 180160
		// (set) Token: 0x0602BFC1 RID: 180161
		bool? AutoStartUpload { get; set; }

		// Token: 0x17005804 RID: 22532
		// (get) Token: 0x0602BFC2 RID: 180162
		// (set) Token: 0x0602BFC3 RID: 180163
		int? ErrorCode { get; set; }
	}
}
