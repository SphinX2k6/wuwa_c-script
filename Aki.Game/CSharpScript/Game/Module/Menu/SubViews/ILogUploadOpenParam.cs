using System;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005420 RID: 21536
	public interface ILogUploadOpenParam
	{
		// Token: 0x17008436 RID: 33846
		// (get) Token: 0x06037075 RID: 225397
		// (set) Token: 0x06037076 RID: 225398
		EKuroSdkOpenCustomerServerType? OpenSourceType { get; set; }

		// Token: 0x17008437 RID: 33847
		// (get) Token: 0x06037077 RID: 225399
		// (set) Token: 0x06037078 RID: 225400
		bool? AutoStartUpload { get; set; }

		// Token: 0x17008438 RID: 33848
		// (get) Token: 0x06037079 RID: 225401
		// (set) Token: 0x0603707A RID: 225402
		int? ErrorCode { get; set; }
	}
}
