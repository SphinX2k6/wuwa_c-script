using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060AE RID: 24750
	[NullableContext(1)]
	public interface ISolarSpeedActivitySubViewData
	{
		// Token: 0x170090AD RID: 37037
		// (get) Token: 0x0603E937 RID: 256311
		// (set) Token: 0x0603E938 RID: 256312
		string RewardTextId { get; set; }

		// Token: 0x170090AE RID: 37038
		// (get) Token: 0x0603E939 RID: 256313
		// (set) Token: 0x0603E93A RID: 256314
		string ButtonTextId { get; set; }

		// Token: 0x170090AF RID: 37039
		// (get) Token: 0x0603E93B RID: 256315
		// (set) Token: 0x0603E93C RID: 256316
		Func<bool> RewardRedDotStateGetter { get; set; }

		// Token: 0x170090B0 RID: 37040
		// (get) Token: 0x0603E93D RID: 256317
		// (set) Token: 0x0603E93E RID: 256318
		Func<bool> ConfirmRedDotStateGetter { get; set; }

		// Token: 0x170090B1 RID: 37041
		// (get) Token: 0x0603E93F RID: 256319
		// (set) Token: 0x0603E940 RID: 256320
		Func<string> RewardProgressCurrentGetter { get; set; }

		// Token: 0x170090B2 RID: 37042
		// (get) Token: 0x0603E941 RID: 256321
		// (set) Token: 0x0603E942 RID: 256322
		string RewardProgressTextId { get; set; }

		// Token: 0x170090B3 RID: 37043
		// (get) Token: 0x0603E943 RID: 256323
		// (set) Token: 0x0603E944 RID: 256324
		string RewardProgressTotal { get; set; }
	}
}
