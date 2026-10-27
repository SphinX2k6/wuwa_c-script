using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200017C RID: 380
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectResponseData
	{
		// Token: 0x04000687 RID: 1671
		public ThirdLogin thirdLogin;

		// Token: 0x04000688 RID: 1672
		public int heartFreq;

		// Token: 0x04000689 RID: 1673
		public int heartEnable;

		// Token: 0x0400068A RID: 1674
		public string uagr;

		// Token: 0x0400068B RID: 1675
		public string pagr;

		// Token: 0x0400068C RID: 1676
		public string childArgUrl;

		// Token: 0x0400068D RID: 1677
		public string pwdLife;

		// Token: 0x0400068E RID: 1678
		public ClientSwitch clientSwitch;

		// Token: 0x0400068F RID: 1679
		public ClientUrl clientUrl;

		// Token: 0x04000690 RID: 1680
		public int kefuInterval;

		// Token: 0x04000691 RID: 1681
		public ThirdShareParams thirdShareParams;

		// Token: 0x04000692 RID: 1682
		public int regionMinAge;

		// Token: 0x04000693 RID: 1683
		public bool ageCheckBox;

		// Token: 0x04000694 RID: 1684
		public bool didSmSwitch;

		// Token: 0x04000695 RID: 1685
		public bool didTxSwitch;

		// Token: 0x04000696 RID: 1686
		public bool geetestSwitch;

		// Token: 0x04000697 RID: 1687
		public bool audioSwitch;

		// Token: 0x04000698 RID: 1688
		public bool iosCrossDistrict;

		// Token: 0x04000699 RID: 1689
		public bool googleCrossDistrict;

		// Token: 0x0400069A RID: 1690
		public int googlePcConsumeIntervalSec;
	}
}
