using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000180 RID: 384
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectResponseData
	{
		// Token: 0x040006C2 RID: 1730
		public ThirdLogin thirdLogin;

		// Token: 0x040006C3 RID: 1731
		public int heartFreq;

		// Token: 0x040006C4 RID: 1732
		public int heartEnable;

		// Token: 0x040006C5 RID: 1733
		public string uagr;

		// Token: 0x040006C6 RID: 1734
		public string pagr;

		// Token: 0x040006C7 RID: 1735
		public string childArgUrl;

		// Token: 0x040006C8 RID: 1736
		public string pwdLife;

		// Token: 0x040006C9 RID: 1737
		public ClientSwitch clientSwitch;

		// Token: 0x040006CA RID: 1738
		public ClientUrl clientUrl;

		// Token: 0x040006CB RID: 1739
		public int kefuInterval;

		// Token: 0x040006CC RID: 1740
		public ThirdShareParams thirdShareParams;

		// Token: 0x040006CD RID: 1741
		public int regionMinAge;

		// Token: 0x040006CE RID: 1742
		public bool ageCheckBox;

		// Token: 0x040006CF RID: 1743
		public bool didSmSwitch;

		// Token: 0x040006D0 RID: 1744
		public bool didTxSwitch;

		// Token: 0x040006D1 RID: 1745
		public bool geetestSwitch;

		// Token: 0x040006D2 RID: 1746
		public bool audioSwitch;

		// Token: 0x040006D3 RID: 1747
		public bool iosCrossDistrict;

		// Token: 0x040006D4 RID: 1748
		public bool googleCrossDistrict;

		// Token: 0x040006D5 RID: 1749
		public int googlePcConsumeIntervalSec;
	}
}
