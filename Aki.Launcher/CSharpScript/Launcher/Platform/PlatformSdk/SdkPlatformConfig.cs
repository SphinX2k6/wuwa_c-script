using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200012F RID: 303
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkPlatformConfig
	{
		// Token: 0x040005A2 RID: 1442
		public string PrivacyPolicy;

		// Token: 0x040005A3 RID: 1443
		public string TermsOfService;

		// Token: 0x040005A4 RID: 1444
		public string ChildProtocol;

		// Token: 0x040005A5 RID: 1445
		public List<string> ServerUrl;

		// Token: 0x040005A6 RID: 1446
		public List<string> PayUrl;

		// Token: 0x040005A7 RID: 1447
		public string client_id;

		// Token: 0x040005A8 RID: 1448
		public string client_secret;

		// Token: 0x040005A9 RID: 1449
		public string platform_pkg;

		// Token: 0x040005AA RID: 1450
		public string platform_client_id;

		// Token: 0x040005AB RID: 1451
		public string platform_client_secret;

		// Token: 0x040005AC RID: 1452
		public string UserCenterUrl;

		// Token: 0x040005AD RID: 1453
		public string CustomServiceUrl;

		// Token: 0x040005AE RID: 1454
		public string DataReportUrl;

		// Token: 0x040005AF RID: 1455
		public string DataReportId;

		// Token: 0x040005B0 RID: 1456
		public string kuro_DataReportUrl;

		// Token: 0x040005B1 RID: 1457
		public Dictionary<string, CsLinkEntry> cs_links;
	}
}
