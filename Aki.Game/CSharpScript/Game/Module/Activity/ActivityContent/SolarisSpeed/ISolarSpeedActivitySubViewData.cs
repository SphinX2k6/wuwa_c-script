using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200502C RID: 20524
	[NullableContext(1)]
	public interface ISolarSpeedActivitySubViewData
	{
		// Token: 0x1700640F RID: 25615
		// (get) Token: 0x060335FB RID: 210427
		// (set) Token: 0x060335FC RID: 210428
		string RewardTextId { get; set; }

		// Token: 0x17006410 RID: 25616
		// (get) Token: 0x060335FD RID: 210429
		// (set) Token: 0x060335FE RID: 210430
		string ButtonTextId { get; set; }

		// Token: 0x17006411 RID: 25617
		// (get) Token: 0x060335FF RID: 210431
		// (set) Token: 0x06033600 RID: 210432
		Func<bool> RewardRedDotStateGetter { get; set; }

		// Token: 0x17006412 RID: 25618
		// (get) Token: 0x06033601 RID: 210433
		// (set) Token: 0x06033602 RID: 210434
		Func<bool> ConfirmRedDotStateGetter { get; set; }

		// Token: 0x17006413 RID: 25619
		// (get) Token: 0x06033603 RID: 210435
		// (set) Token: 0x06033604 RID: 210436
		Func<string> RewardProgressCurrentGetter { get; set; }

		// Token: 0x17006414 RID: 25620
		// (get) Token: 0x06033605 RID: 210437
		// (set) Token: 0x06033606 RID: 210438
		string RewardProgressTextId { get; set; }

		// Token: 0x17006415 RID: 25621
		// (get) Token: 0x06033607 RID: 210439
		// (set) Token: 0x06033608 RID: 210440
		string RewardProgressTotal { get; set; }
	}
}
