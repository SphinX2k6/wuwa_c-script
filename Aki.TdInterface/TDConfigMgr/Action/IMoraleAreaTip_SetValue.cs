using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C0D RID: 7181
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoraleAreaTip_SetValue
	{
		// Token: 0x04005DAB RID: 23979
		public ECommonTipType Type;

		// Token: 0x04005DAC RID: 23980
		public string TidAreaNameText;

		// Token: 0x04005DAD RID: 23981
		public string TidRecommendText;

		// Token: 0x04005DAE RID: 23982
		public EMoraleAreaType AreaType;

		// Token: 0x04005DAF RID: 23983
		public EMoraleUiType? UiType;

		// Token: 0x04005DB0 RID: 23984
		[Nullable(2)]
		public string EdTidAreaNameText;

		// Token: 0x04005DB1 RID: 23985
		[Nullable(2)]
		public string EdTidRecommendText;
	}
}
