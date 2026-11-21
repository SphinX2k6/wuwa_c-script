using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200502D RID: 20525
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedActivitySubViewData : ISolarSpeedActivitySubViewData
	{
		// Token: 0x17006416 RID: 25622
		// (get) Token: 0x06033609 RID: 210441 RVA: 0x00E67134 File Offset: 0x00E65334
		// (set) Token: 0x0603360A RID: 210442 RVA: 0x00E6713C File Offset: 0x00E6533C
		public string RewardTextId { get; set; }

		// Token: 0x17006417 RID: 25623
		// (get) Token: 0x0603360B RID: 210443 RVA: 0x00E67145 File Offset: 0x00E65345
		// (set) Token: 0x0603360C RID: 210444 RVA: 0x00E6714D File Offset: 0x00E6534D
		public string ButtonTextId { get; set; }

		// Token: 0x17006418 RID: 25624
		// (get) Token: 0x0603360D RID: 210445 RVA: 0x00E67156 File Offset: 0x00E65356
		// (set) Token: 0x0603360E RID: 210446 RVA: 0x00E6715E File Offset: 0x00E6535E
		public Func<bool> RewardRedDotStateGetter { get; set; }

		// Token: 0x17006419 RID: 25625
		// (get) Token: 0x0603360F RID: 210447 RVA: 0x00E67167 File Offset: 0x00E65367
		// (set) Token: 0x06033610 RID: 210448 RVA: 0x00E6716F File Offset: 0x00E6536F
		public Func<bool> ConfirmRedDotStateGetter { get; set; }

		// Token: 0x1700641A RID: 25626
		// (get) Token: 0x06033611 RID: 210449 RVA: 0x00E67178 File Offset: 0x00E65378
		// (set) Token: 0x06033612 RID: 210450 RVA: 0x00E67180 File Offset: 0x00E65380
		public Func<string> RewardProgressCurrentGetter { get; set; }

		// Token: 0x1700641B RID: 25627
		// (get) Token: 0x06033613 RID: 210451 RVA: 0x00E67189 File Offset: 0x00E65389
		// (set) Token: 0x06033614 RID: 210452 RVA: 0x00E67191 File Offset: 0x00E65391
		public string RewardProgressTextId { get; set; }

		// Token: 0x1700641C RID: 25628
		// (get) Token: 0x06033615 RID: 210453 RVA: 0x00E6719A File Offset: 0x00E6539A
		// (set) Token: 0x06033616 RID: 210454 RVA: 0x00E671A2 File Offset: 0x00E653A2
		public string RewardProgressTotal { get; set; }
	}
}
