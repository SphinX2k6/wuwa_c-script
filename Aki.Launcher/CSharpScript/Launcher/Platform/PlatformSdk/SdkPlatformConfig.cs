using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000133 RID: 307
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkPlatformConfig
	{
		// Token: 0x040005DD RID: 1501
		public string PrivacyPolicy;

		// Token: 0x040005DE RID: 1502
		public string TermsOfService;

		// Token: 0x040005DF RID: 1503
		public string ChildProtocol;

		// Token: 0x040005E0 RID: 1504
		public List<string> ServerUrl;

		// Token: 0x040005E1 RID: 1505
		public List<string> PayUrl;

		// Token: 0x040005E2 RID: 1506
		public string client_id;

		// Token: 0x040005E3 RID: 1507
		public string client_secret;

		// Token: 0x040005E4 RID: 1508
		public string platform_pkg;

		// Token: 0x040005E5 RID: 1509
		public string platform_client_id;

		// Token: 0x040005E6 RID: 1510
		public string platform_client_secret;

		// Token: 0x040005E7 RID: 1511
		public string UserCenterUrl;

		// Token: 0x040005E8 RID: 1512
		public string CustomServiceUrl;

		// Token: 0x040005E9 RID: 1513
		public string DataReportUrl;

		// Token: 0x040005EA RID: 1514
		public string DataReportId;

		// Token: 0x040005EB RID: 1515
		public string kuro_DataReportUrl;

		// Token: 0x040005EC RID: 1516
		public Dictionary<string, CsLinkEntry> cs_links;
	}
}
